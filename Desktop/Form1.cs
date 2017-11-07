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
        SerialPort SelectedPort = new SerialPort();

        Stopwatch graphsw = new Stopwatch();
        decimal graphtime;
        bool LiveRecording = false;
        bool DataRecording = false;
        string lastportname = "";

        public ModalTesterForm()
        {
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
            Thread.CurrentThread.Priority = ThreadPriority.Normal;

            InitializeComponent();

            USBInsertHandler(this, null);
            portlist_SelectedIndexChanged(this, null);

            portlist.SelectedIndexChanged += portlist_SelectedIndexChanged;

            frf.ChartAreas[0].AxisX.Minimum = 0;
            frf.ChartAreas[0].AxisY.Maximum = 1024;

            SetupUSBInsertDetection();
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
            portlist.PerformSafely(() =>
            {
                List<string> names = new List<string>();

                foreach (string s in SerialPort.GetPortNames())
                    if (!names.Contains(s))
                        names.Add(s);

                portlist.DataSource = names;
                portlist.SelectedIndex = portlist.Items.Count - 1;
            });
        }

        private void portlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!DataRecording && portlist.SelectedItem.ToString() != lastportname)
            {
                LiveRecording = false;

                Thread.Sleep(500);

                lastportname = portlist.SelectedItem.ToString();

                resetgraphstuff();

                if (SelectedPort.IsOpen)
                    SelectedPort.Close();

                SerialPort s = new SerialPort();
                s.PortName = lastportname;
                s.BaudRate = 9600;
                s.Parity = Parity.None;
                s.Handshake = Handshake.None;
                s.ReadTimeout = 500;
                s.WriteTimeout = 500;

                SelectedPort.Dispose();
                SelectedPort = s;

                Thread RTloop = new Thread(ReadTimeLoop);
                RTloop.Priority = ThreadPriority.Highest;

                Thread RCloop = new Thread(ReadCOMLoop);
                RCloop.Priority = ThreadPriority.Highest;

                Thread Cloop = new Thread(correctionLoop);
                Cloop.Priority = ThreadPriority.Lowest;

                LiveRecording = true;

                try
                {
                    RTloop.Start();
                    SelectedPort.Open();
                    RCloop.Start();
                    Cloop.Start();
                    graphsw.Start();
                }
                catch (Exception)
                {
                    LiveRecording = false;
                    //MessageBox.Show("Port is unavailable!");
                }
            }
        }

        List<DataPoint> r = new List<DataPoint>();

        private void collectdata_Click(object sender, EventArgs e)
        {
            //TMessageBox(vot.Series[0].Points.Count.ToString());
            collectdata.Text = "Recording:" + (!DataRecording).ToString();

            if (!DataRecording)
            {
                r.Clear();
            }
            else
            {
                if (r.Count > 0)
                {
                    new Thread(() =>
                    {
                        frf.PerformSafely(() =>
                        {
                            DrawFRFMathNumericsFFT(r.ToArray());
                        });
                    }).Start();
                }
            }

            DataRecording = !DataRecording;
        }

        private void resetgraphstuff()
        {
            graphsw.Reset();
            graphtime = 0;
            
            vot.Series[0].Points.Clear();
            frf.Series[0].Points.Clear();
        }

        private void correctionLoop()
        {
            while (LiveRecording)
            {
                CorrectErrors();
            }
        }

        private void CorrectErrors()
        {
            try
            {
                for (int l = vot.Series[0].Points.Count; l > 2; l--)
                {
                    if (vot.Series[0].Points.Count > 1 && Math.Abs(vot.Series[0].Points[l - 1].XValue - vot.Series[0].Points[l - 2].XValue) > 0.5)
                    {
                        vot.PerformSafely(() =>
                        {
                            DataPoint d = vot.Series[0].Points[l - 1]; //currently looked at
                            DataPoint d2 = vot.Series[0].Points[l - 2]; //previous
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
            while (LiveRecording)
            {
                graphtime = Convert.ToDecimal(graphsw.ElapsedTicks) / Convert.ToDecimal(Stopwatch.Frequency);
            }
        }

        private void ReadCOMLoop()
        {
            while (LiveRecording)
            {
                try
                {
                    vot.PerformSafely(() =>
                    {
                        string dd = "";

                        try
                        {
                            dd = SelectedPort.ReadLine();
                            //TMessageBox(dd);

                            int d = int.Parse(dd);
                            if (d < 1024)
                            {
                                vot.Series[0].Points.AddXY(graphtime, d);
                                if (LiveRecording)
                                    r.Add(new DataPoint((double)graphtime, d));
                            }
                            //vot.ChartAreas[0].AxisX.Minimum = (double)graphtime - 5;
                        }
                        catch (Exception e) {
                            //TMessageBox(dd + Environment.NewLine + Environment.NewLine + e.ToString());
                        }
                    });
                }
                catch (Exception) { }
            }
        }

        private void saveresults_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();

            sf.Filter = "Comma separated values (*.csv)|*.csv|All files (*.*)|*.*";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(sf.FileName, ParseToCSV("seconds,voltage", vot.Series[0].Points));
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot access that file. Make sure it is not in use by another program.");
                }
            }

            sf.Dispose();
        }

        private string ParseToCSV(string title, DataPointCollection points)
        {
            string csv = title;

            for (int i = 0; i < points.Count; i++)
                csv += Environment.NewLine + points[i].XValue + "," + points[i].YValues[0];

            return csv;
        }

        public void DrawFRFMathNumericsFFT(DataPoint[] data)
        {
            Complex[] samples = new Complex[data.Length];

            for (int i = 0; i < samples.Length; i++)
                samples[i] = new Complex(data[i].XValue, data[i].YValues[0]);

            double samplerate = samples.Length / samples[samples.Length - 1].Real;
            double hzpersample = samplerate / samples.Length;

            //TMessageBox("samplerate: " + samplerate + Environment.NewLine + "hz per sample: " + hzpersample);

            ManagedFourierTransformProvider fp = new ManagedFourierTransformProvider();

            fp.Forward(samples, FourierTransformScaling.NoScaling);

            //https://www.youtube.com/watch?v=DqQlNoQW00w at 27:18

            frf.ChartAreas[0].AxisY.Maximum = 0;

<<<<<<< HEAD
            //double samplerate = 



            //put a choice for this /100
            for (int i = 1; i < samples.Length / 100; i++)
=======
            for (int i = 1; i < samples.Length / 2; i++)
>>>>>>> master
            {
                double magnitude = (2.0 / samples.Length) * (Math.Abs(Math.Sqrt(Math.Pow(samples[i].Real, 2) + Math.Pow(samples[i].Imaginary, 2))));

                if (magnitude > frf.ChartAreas[0].AxisY.Maximum)
                    frf.ChartAreas[0].AxisY.Maximum = magnitude;

                frf.Series[0].Points.AddXY(hzpersample * i, magnitude);
            }
        }

        public static void TMessageBox(string str)
        {
            new Thread(() => { MessageBox.Show(str); }).Start();
        }

        private void load_Click(object sender, EventArgs e)
        {
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
                        vot.Series[0].Points.Add(d[i]);
                    }
                }
                catch (Exception ex)
                {
                    TMessageBox("Error parsing CSV file" + Environment.NewLine + Environment.NewLine + ex.ToString());
                }
            }

            sf.Dispose();
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

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();

            sf.Filter = "Comma separated values (*.csv)|*.csv|All files (*.*)|*.*";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(sf.FileName, ParseToCSV("Hz,magnitude", frf.Series[0].Points));
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
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        private void ModalTesterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LiveRecording = false;
            DataRecording = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DataRecording)
                collectdata_Click(this, null);

            LiveRecording = false;
        }
    }
}
