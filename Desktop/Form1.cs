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

namespace ModalTest
{
    public partial class Form1 : Form
    {
        SerialPort SelectedPort = new SerialPort();

        Stopwatch graphsw = new Stopwatch();
        decimal graphtime;
        bool ShouldTime = false;

        public Form1()
        {
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
            Thread.CurrentThread.Priority = ThreadPriority.Highest;

            InitializeComponent();

            portlist.DataSource = SerialPort.GetPortNames();

            //frf.ChartAreas[0].Axes = vot.ChartAreas[0].Axes;

            frf.ChartAreas[0].AxisX.Title = "Hz";
            frf.ChartAreas[0].AxisY.Title = "Magnitude";
            frf.ChartAreas[0].AxisX.Minimum = 0;
        }

        private void portlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            SerialPort s = new SerialPort();
            s.PortName = portlist.SelectedItem.ToString();
            s.BaudRate = 2000000;
            s.Parity = Parity.None;
            s.Handshake = Handshake.None;
            s.ReadTimeout = 500;
            s.WriteTimeout = 500;

            //s.DataReceived += SelectedPort_DataReceived;

            //SelectedPort.DataReceived -= SelectedPort_DataReceived;
            
            SelectedPort.Dispose();

            SelectedPort = s;
        }

        private void SelectedPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string data = sp.ReadLine();

            datadebugbox.PerformSafely(() =>
            {
                datadebugbox.Text = data;
            });

            vot.PerformSafely(() =>
            {
                try
                {
                    if (int.Parse(data) < 1024)
                        vot.Series[0].Points.AddXY(graphtime, int.Parse(data));
                }
                catch (Exception) { }
            });
        }

        private void collectdata_Click(object sender, EventArgs e)
        {
            sampletimechooser.Enabled = false;
            stop.Enabled = true;
            portlist.Enabled = false;
            collectdata.Enabled = false;
            saveresults.Enabled = false;

            resetgraphstuff();

            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = (int)sampletimechooser.Value;
            t.Tick += T_Tick;

            Thread th = new Thread(StopwatchLoop);
            th.Priority = ThreadPriority.Highest;

            Thread th2 = new Thread(ReadLoop);
            th2.Priority = ThreadPriority.Highest;

            Thread th3 = new Thread(correctionloop);
            th3.Priority = ThreadPriority.Lowest;

            ShouldTime = true;

            try
            {
                th.Start();
                SelectedPort.Open();
                th2.Start();
                th3.Start();
                graphsw.Start();
                t.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("That port is already in use!");
                stop_Click(sender, e);
            }
        }

        private void resetgraphstuff()
        {
            graphsw.Reset();
            graphtime = 0;
            
            vot.Series[0].Points.Clear();
            frf.Series[0].Points.Clear();
        }

        private void correctionloop()
        {
            while (ShouldTime)
            {
                CorrectErrors();
                Thread.Sleep(1000);
            }
        }

        private void CorrectErrors()
        {
            try
            {
                for (int l = 2; l < vot.Series[0].Points.Count; l++)
                {
                    if (vot.Series[0].Points.Count > 1 && Math.Abs(vot.Series[0].Points[l - 1].XValue - vot.Series[0].Points[l - 2].XValue) > 0.5)
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

                            //TMessageBox("Corrected malformed data:\n" + old + "\n" + d.XValue);

                            //add a textbox that this appends to when correcting a time
                        });
                }
            }
            catch (Exception) { }
        }

        private void StopwatchLoop()
        {
            while (ShouldTime)
            {
                graphtime = Convert.ToDecimal(graphsw.ElapsedTicks) / Convert.ToDecimal(Stopwatch.Frequency);
            }
        }

        private void ReadLoop()
        {
            while (ShouldTime)
            {
                try
                {
                    string data = SelectedPort.ReadLine();

                    datadebugbox.PerformSafely(() =>
                    {
                        datadebugbox.Text = data;
                    });

                    vot.PerformSafely(() =>
                    {
                        try
                        {
                            int d = int.Parse(data);
                            if (d < 1024)
                                vot.Series[0].Points.AddXY(graphtime, d);
                        }
                        catch (Exception) { }
                    });
                }
                catch (TimeoutException) { }
                catch (Exception e)
                {
                    TMessageBox(e.ToString());
                }
            }
        }

        private void T_Tick(object sender, EventArgs e)
        {
            //stop 5 second graphs
            //sender is timer object
        }
        
        private void stop_Click(object sender, EventArgs e)
        {
            if (SelectedPort.IsOpen)
                SelectedPort.Close();

            ShouldTime = false;

            sampletimechooser.Enabled = true;
            stop.Enabled = false;
            portlist.Enabled = true;
            collectdata.Enabled = true;
            saveresults.Enabled = true;

            CorrectErrors();

            if (vot.Series[0].Points.Count > 0)
            {
                new Thread(() =>
                {
                    frf.BeginPerformSafely(() =>
                    {
                        vot.BeginPerformSafely(() =>
                        {
                            DrawFRFMathNumericsFFT(vot.Series[0].Points);
                        });
                    });
                }).Start();
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

        public void DrawFRFMathNumericsFFT(DataPointCollection data)
        {
            Complex[] samples = new Complex[data.Count];

            for (int i = 0; i < samples.Length; i++)
                samples[i] = new Complex(data[i].XValue, data[i].YValues[0]);

            double samplerate = samples.Length / samples[samples.Length - 1].Real;
            double hzpersample = samplerate / samples.Length;

            //TMessageBox("samplerate: " + samplerate + Environment.NewLine + "hz per sample: " + hzpersample);

            ManagedFourierTransformProvider fp = new ManagedFourierTransformProvider();

            fp.Forward(samples, FourierTransformScaling.NoScaling);

            //https://www.youtube.com/watch?v=DqQlNoQW00w at 27:18

            //frf.ChartAreas[0].AxisX.Maximum = c.Length / 2;
            frf.ChartAreas[0].AxisY.Maximum = 0;

            //double samplerate = 

            for (int i = 1; i < samples.Length / 10; i++)
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

            stop_Click(this, null);
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
            Chart c = sender as Chart;

            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            tooltip.RemoveAll();
            prevPosition = pos;
            var results = c.HitTest(pos.X, pos.Y, false,
                                            ChartElementType.DataPoint);
            foreach (DataPoint d in c.Series[0].Points)
            {
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
    }
}
