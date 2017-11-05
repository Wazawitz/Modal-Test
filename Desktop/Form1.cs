using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

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

            graphsw.Reset();
            graphtime = 0;

            //also reset graph stuff
            vot.Series[0].Points.Clear();
            frf.Series[0].Points.Clear();

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
            //SelectedPort.DataReceived -= SelectedPort_DataReceived;

            if (SelectedPort.IsOpen)
                SelectedPort.Close();

            ShouldTime = false;

            sampletimechooser.Enabled = true;
            stop.Enabled = false;
            portlist.Enabled = true;
            collectdata.Enabled = true;
            saveresults.Enabled = true;

            CorrectErrors();

            new Thread(() =>
            {
                frf.BeginPerformSafely(() =>
                {
                    vot.BeginPerformSafely(() =>
                    {
                        DrawFRFOLD(vot.Series[0].Points);
                    });
                });
            }).Start();
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

        //add load button to load data
        //add process button to process data



        //input data as time(decimal) and voltage(int)
        public void DrawFRF(DataPointCollection data)
        {
            Complex[] c = new Complex[data.Count];

            for (int i = 0; i < data.Count; i++)
                c[i] = new Complex(data[i].XValue, data[i].YValues[0]);

            c = Complex.RecursiveFFT(c);

            for (int i = 0; i < c.Length; i++)
            {
                frf.Series[0].Points.AddXY(c[i].re, c[i].im);
            }
        }

        public void DrawFRFOLD(DataPointCollection data)
        {
            int m = 1;

            while (m < data.Count)
                m = m << 1;

            double[] x = new double[m];
            double[] y = new double[m];

            for (int i = 0; i < m; i++)
            {
                if (i < data.Count)
                {
                    x[i] = data[i].XValue;
                    y[i] = data[i].YValues[0];
                }
                else
                {
                    y[i] = 0;
                    x[i] = 0;
                }
            }

            Complex.FFT(1, m, x, y);

            for (int i = 0; i < x.Length; i++)
            {
                frf.Series[0].Points.AddXY(x[i], y[i]);
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
    }
}
