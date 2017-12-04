using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using MathNet.Numerics.Providers.FourierTransform;
using System.Numerics;
using System.Drawing;
using System.Management;

namespace ModalTest
{
    //turn start and stop into a toggle, and make the space bar trigger it
    //load csv: file contained these errors which were ignored ""
    //generate wave, and have a resolution number which determines time steps, and time length, and controls to add sub waves
    //turn load and save stuff into a file dropdown menu
    //add control s support
    //add realtime cpu usage toggle with warning
    //add a function that essentially zeros the vibration wave, and then only displays differences above a certain limit. similar to a tear button on scale.
    //add button to view csv raw data which uses a textbox window
    //simulate sensor reading by reading from a file
    //"export project or export dataset" to a folder that gets named by user, but all files are named according to their graphs like vot, frf and the likes

    //make settings page with tons of settings
    //frf max length in fraction like 1/2 or 1/10 with 1/2 being ultimate max
    //vot max data length for live scrolling, currently at 5000
    public partial class ModalTesterForm : Form
    {
        IDataSource SelectedPort = new ISerialPort();

        Stopwatch graphsw = new Stopwatch();
        decimal graphtime;
        bool COMFeed = false;
        bool DataRecording = false;
        bool COMOrSim = true;
        string lastportname = "";

        public ModalTesterForm()
        {
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
            Thread.CurrentThread.Priority = ThreadPriority.Highest;

            InitializeComponent();

            SetupMouseMove();

            USBInsertHandler(this, null);
            RefreshLiveFeed(false);

            portlist.SelectedIndexChanged += portlist_SelectedIndexChanged;

            lcfrf.ChartAreas[0].AxisX.Minimum = 0;
            lcfrf.ChartAreas[0].AxisY.Maximum = 1024;

            SetupUSBInsertDetection();
        }

        private void SetupMouseMove()
        {
            foreach (Control c in Controls)
            {
                if (c is Chart)
                    ((Chart)c).MouseMove += chart_MouseMove;
            }
        }

        private void RefreshControls(Control c)
        {
            c.Refresh();

            foreach (Control sc in c.Controls)
                RefreshControls(sc);
        }

        private void SetupUSBInsertDetection()
        {
            ManagementScope scope = new ManagementScope("root\\CIMV2");
            scope.Options.EnablePrivileges = true;

            try
            {
                //usb insert detection
                WqlEventQuery q = new WqlEventQuery();
                q.EventClassName = "__InstanceCreationEvent";
                q.WithinInterval = new TimeSpan(0, 0, 3);
                q.Condition = "TargetInstance ISA 'Win32_USBControllerdevice'";
                ManagementEventWatcher w = new ManagementEventWatcher(scope, q);
                w.EventArrived += USBInsertHandler;
                w.Start();

                //usb remove detection
                WqlEventQuery q2 = new WqlEventQuery();
                q2.EventClassName = "__InstanceDeletionEvent";
                q2.WithinInterval = new TimeSpan(0, 0, 3);
                q2.Condition = "TargetInstance ISA 'Win32_USBControllerdevice'";
                ManagementEventWatcher w2 = new ManagementEventWatcher(scope, q2);
                w2.EventArrived += USBRemoveHandler;
                w2.Start();
            }
            catch (Exception) { }
        }

        private void USBRemoveHandler(object sender, EventArrivedEventArgs e)
        {
            if (!SelectedPort.IsOpen)
                GetAvailablePorts();
        }

        private void USBInsertHandler(object sender, EventArrivedEventArgs e)
        {
            if (!SelectedPort.IsOpen)
                GetAvailablePorts();
        }

        private void GetAvailablePorts()
        {
            this.PerformSafely(() =>
            {
                portlist.Items.Clear();

                foreach (string s in SerialPort.GetPortNames())
                    if (!portlist.Items.Contains(s))
                        portlist.Items.Add(s);

                portlist.SelectedIndex = portlist.Items.Count - 1;
            });
        }

        private void portlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (portlist.SelectedItem.ToString() != lastportname)
                liveToolStripMenuItem_Click(sender, e);
        }

        private void RefreshLiveFeed(bool displayerror = true)
        {
            if (!COMFeed)
                DataRecording = false;

            if (!DataRecording)
            {
                COMFeed = false;

                lastportname = portlist.SelectedItem.ToString();

                if (SelectedPort.IsOpen)
                    SelectedPort.Close();

                
                resetgraphstuff();

                SelectedPort.Dispose();

                if (COMOrSim)
                {
                    SelectedPort = new ISerialPort();
                    ((ISerialPort)SelectedPort).PortName = lastportname;
                    ((ISerialPort)SelectedPort).BaudRate = 19200;
                    ((ISerialPort)SelectedPort).ReadTimeout = 1000;
                    ((ISerialPort)SelectedPort).WriteTimeout = 1000;
                }
                else
                {
                    SelectedPort = new ISimulatedWave();
                    lastportname = "generated_wave";
                }

                Thread RTloop = new Thread(ReadTimeLoop);
                RTloop.Priority = ThreadPriority.Highest;

                Thread RCloop = new Thread(ReadCOMLoop);
                RCloop.Priority = ThreadPriority.Highest;

                Thread Cloop = new Thread(correctionLoop);
                Cloop.Priority = ThreadPriority.Lowest;

                COMFeed = true;

                try
                {
                    SelectedPort.Open();

                    //this is essentially a solution of timing out a connection, if it cant read after .5 second. if nothing is connected, the read will cause an exception
                    Thread.Sleep(500);
                    SelectedPort.ReadLine();

                    RTloop.Start();
                    RCloop.Start();
                    Cloop.Start();
                    graphsw.Start();
                }
                catch (Exception e)
                {
                    COMFeed = false;
                    resetgraphstuff();

                    if (displayerror)
                        MessageBox.Show(e.ToString(), "Port is unavailable!");
                }
            }
        }

        double Markstart = 0;
        double Markend = 0;

        private void collectdata_Click(object sender, EventArgs e)
        {
            if (!COMFeed)
            {
                MessageBox.Show("Live feed must be enabled first!");
                return;
            }

            if (!DataRecording)
            {
                Markstart = (double)graphtime;
                DataRecording = true;
                collectdata.Text = "Press space to stop";
            }
            else
            {
                Markend = (double)graphtime;
                collectdata.Text = "Press space to record";
                COMFeed = false;
                Thread.Sleep(100);
                DataRecording = false;

                List<DataPoint> r = new List<DataPoint>();

                foreach (DataPoint dp in lc.Series[0].Points)
                {
                    if (dp.XValue > Markstart && dp.XValue < Markend)
                        r.Add(dp);
                }

                lc.PerformSafely(() =>
                {
                    lc.Series[0].Points.Clear();

                    foreach (DataPoint dp in r)
                    {
                        lc.Series[0].Points.Add(dp);
                    }

                    if (lc.Series[0].Points.Count > 0)
                        lc.ChartAreas[0].AxisX.Minimum = lc.Series[0].Points[0].XValue;
                });

                if (r.Count > 0)
                    DrawFRFMathNumericsFFTAndPSD(r.ToArray());
            }

            RefreshControls(this);
        }

        private void resetgraphstuff()
        {
            graphsw.Reset();
            graphtime = 0;

            foreach (Control c in Controls)
            {
                if (c is Chart)
                {
                    c.PerformSafely(() =>
                    {
                        ((Chart)c).Series[0].Points.Clear();
                    });
                }
            }
        }

        private void correctionLoop()
        {
            while (COMFeed)
            {
                CorrectErrors();
            }
        }

        private void CorrectErrors()
        {
            try
            {
                for (int l = lc.Series[0].Points.Count; l > 2; l--)
                {
                    if (lc.Series[0].Points.Count > 1 && Math.Abs(lc.Series[0].Points[l - 1].XValue - lc.Series[0].Points[l - 2].XValue) > 0.5)
                    {
                        lc.PerformSafely(() =>
                        {
                            DataPoint d = lc.Series[0].Points[l - 1]; //currently looked at
                            DataPoint d2 = lc.Series[0].Points[l - 2]; //previous
                            double old = d.XValue;

                            //gonna make a loop to change the target, because the errors are the time always being off by a multiple of 10.
                            //this will result in some data loss, on the very end of the decimal, but its better than loosing that datapoint
                            //entirely
                            //and actually, data is very rarely lost, but sometimes a very small amount is.

                            int direction = -1;

                            if (d.XValue < d2.XValue)
                                direction = 1;

                            for (; Math.Abs(d.XValue - d2.XValue) > 0.5; d.XValue = d.XValue * Math.Pow(10, direction)) { }

                        });
                        break;
                    }
                }
            }
            catch (Exception) { }
        }

        private void ReadTimeLoop()
        {
            while (COMFeed)
            {
                graphtime = Convert.ToDecimal(graphsw.ElapsedTicks) / Convert.ToDecimal(Stopwatch.Frequency);
            }
        }

        private void ReadCOMLoop()
        {
            while (COMFeed)
            {
                try
                {
                    double t = (double)graphtime;
                    string dd = SelectedPort.ReadLine();
                    //TMessageBox(dd);

                    int d = int.Parse(dd.Substring(0, dd.IndexOf(" ")));
                    int d2 = int.Parse(dd.Substring(dd.IndexOf(" ") + 1));

                    lc.PerformSafely(() =>
                    {
                        if (d < 1024)
                            lc.Series[0].Points.AddXY(t, d);

                        if (COMFeed && !DataRecording)
                        {
                            lc.ChartAreas[0].AxisX.Minimum = (double)t - 0.5;
                        }
                    });

                    acc.PerformSafely(() =>
                    {
                        if (d2 < 1024)
                            acc.Series[0].Points.AddXY(t, d2);

                        if (COMFeed && !DataRecording)
                        {
                            acc.ChartAreas[0].AxisX.Minimum = (double)t - 0.5;
                        }
                    });
                }
                catch (Exception e)
                {
                    //TMessageBox(dd + Environment.NewLine + Environment.NewLine + e.ToString());
                }
            }
        }

        private string ParseToCSV(string title, DataPointCollection points)
        {
            string csv = title;

            for (int i = 0; i < points.Count; i++)
                csv += Environment.NewLine + points[i].XValue + "," + points[i].YValues[0];

            return csv;
        }

        public void DrawFRFMathNumericsFFTAndPSD(DataPoint[] data)
        {
            Complex[] samples = new Complex[data.Length];

            for (int i = 0; i < samples.Length; i++)
                samples[i] = new Complex(data[i].XValue, data[i].YValues[0]);

            double samplerate = samples.Length / samples[samples.Length - 1].Real;
            double hzpersample = samplerate / samples.Length;

            TMessageBox("samplerate: " + samplerate);

            ManagedFourierTransformProvider fp = new ManagedFourierTransformProvider();

            fp.Forward(samples, FourierTransformScaling.NoScaling);

            //https://www.youtube.com/watch?v=DqQlNoQW00w at 27:18

            lcfrf.PerformSafely(() =>
            {
                lcfrf.ChartAreas[0].AxisY.Maximum = 0;

                for (int i = 1; i < samples.Length / 2; i++)
                {
                    double magnitude = (2.0 / samples.Length) * (Math.Abs(Math.Sqrt(Math.Pow(samples[i].Real, 2) + Math.Pow(samples[i].Imaginary, 2))));

                    if (magnitude > lcfrf.ChartAreas[0].AxisY.Maximum)
                        lcfrf.ChartAreas[0].AxisY.Maximum = magnitude;

                    lcfrf.Series[0].Points.AddXY(hzpersample * i, magnitude);
                }
            });

            lcpsd.PerformSafely(() =>
            {
                foreach (DataPoint d in lcfrf.Series[0].Points)
                {
                    lcpsd.Series[0].Points.AddXY(d.XValue, Math.Pow(d.YValues[0], 2));
                }
            });
        }

        public static void TMessageBox(string str)
        {
            new Thread(() => { MessageBox.Show(str); }).Start();
        }

        private List<DataPoint> ParseFromCSV(string csv)
        {
            csv += Environment.NewLine;

            List<DataPoint> d = new List<DataPoint>();

            while (csv.Contains(Environment.NewLine))
            {
                //TMessageBox(csv);

                int n = csv.IndexOf(Environment.NewLine);

                try
                {
                    string line = csv.Substring(0, n);

                    int c = line.IndexOf(",");
                    double x = double.Parse(line.Substring(0, c));
                    double y = double.Parse(line.Substring(c + 1));
                    d.Add(new DataPoint(x, y));

                    //TMessageBox(d[d.Count - 1].ToString());
                }
                catch (Exception) { }

                csv = csv.Substring(n + 1);

            }

            return d;
        }

        private void SaveFRFCSV(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();

            sf.Filter = "Comma separated values (*.csv)|*.csv|All files (*.*)|*.*";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(sf.FileName, ParseToCSV("Hz,magnitude", lcfrf.Series[0].Points));
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot access that file. Make sure it is not in use by another program.");
                }
            }

            sf.Dispose();
        }

        Point? prevPosition = null;
        ToolTip tooltip = new ToolTip();

        void chart_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                var pos = e.Location;

                if (prevPosition.HasValue && pos == prevPosition.Value)
                    return;

                Chart c = sender as Chart;

                tooltip.RemoveAll();

                prevPosition = pos;

                for (int i = c.Series[0].Points.Count - 1; i > 0; i--)
                {
                    DataPoint d = c.Series[0].Points[i];

                    if (d != null)
                    {
                        var pointXPixel = c.ChartAreas[0].AxisX.ValueToPixelPosition(d.XValue);
                        var pointYPixel = c.ChartAreas[0].AxisY.ValueToPixelPosition(d.YValues[0]);

                        // check if the cursor is really close to the point (2 pixels around the point)
                        if (Math.Abs(pos.X - pointXPixel) < 2)//&& Math.Abs(pos.Y - pointYPixel) < 2)
                        {
                            tooltip.Show("X=" + d.XValue + ", Y=" + d.YValues[0], c,
                                            pos.X, pos.Y - 15);
                        }//make this scale with data density
                    }
                }
            }
            catch (Exception) { }
        }

        private void ModalTesterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            COMFeed = false;
            DataRecording = false;
        }

        private void exportToCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataRecording)
                collectdata_Click(this, null);

            COMFeed = false;
            DataRecording = false;

            SaveFileDialog sf = new SaveFileDialog();

            sf.Filter = "Comma separated values (*.csv)|*.csv|All files (*.*)|*.*";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(sf.FileName, ParseToCSV("seconds,voltage", lc.Series[0].Points));
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot access that file. Make sure it is not in use by another program.");
                }
            }

            sf.Dispose();
        }

        private void cSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            COMFeed = false;

            OpenFileDialog sf = new OpenFileDialog();

            sf.Filter = "Comma separated values (*.csv)|*.csv|All files (*.*)|*.*";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<DataPoint> d = ParseFromCSV(File.ReadAllText(sf.FileName));

                    resetgraphstuff();

                    for (int i = 0; i < d.Count; i++)
                    {
                        lc.Series[0].Points.Add(d[i]);
                    }
                    lc.ChartAreas[0].AxisX.Minimum = lc.Series[0].Points[0].XValue;

                    DrawFRFMathNumericsFFTAndPSD(d.ToArray());
                }
                catch (Exception ex)
                {
                    TMessageBox("Error parsing CSV file" + Environment.NewLine + Environment.NewLine + ex.ToString());
                }
            }

            sf.Dispose();
        }

        private void ModalTesterForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && COMFeed)
            {
                e.Handled = true;
                collectdata_Click(this, null);
            }
        }

        private void liveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            COMOrSim = true;
            RefreshLiveFeed();
        }

        private void simulatedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            COMOrSim = false;
            RefreshLiveFeed();
        }
    }
}
