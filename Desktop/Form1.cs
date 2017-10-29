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

            s.DataReceived += SelectedPort_DataReceived;

            SelectedPort.DataReceived -= SelectedPort_DataReceived;
            
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

            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = (int)sampletimechooser.Value;
            t.Tick += T_Tick;

            Thread th = new Thread(StopwatchLoop);
            th.Priority = ThreadPriority.Highest;

            try
            {
                th.Start();
                SelectedPort.Open();
                graphsw.Start();
                t.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("That port is already in use!");
                stop_Click(sender, e);
            }
        }

        private void StopwatchLoop()
        {
            ShouldTime = true;

            while (ShouldTime)
            {
                //graphtime = (double)graphsw.ElapsedMilliseconds / 1000;
                graphtime = graphsw.ElapsedTicks / (decimal)Stopwatch.Frequency;
            }
        }

        private void T_Tick(object sender, EventArgs e)
        {
            //stop 5 second graphs
            //sender is timer object
        }
        
        private void stop_Click(object sender, EventArgs e)
        {
            //the new thread is a workaround for some weird bug where the program hangs when closing.
            new Thread(() => {
                SelectedPort.Close();
            }).Start();

            ShouldTime = false;

            sampletimechooser.Enabled = true;
            stop.Enabled = false;
            portlist.Enabled = true;
            collectdata.Enabled = true;
            saveresults.Enabled = true;
        }

        private void saveresults_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();

            sf.Filter = "Comma separated values (*.csv)|*.csv|All files (*.*)|*.*";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(sf.FileName, csvParse("seconds,voltage", vot.Series[0].Points));
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot access that file. Make sure it is not in use by another program.");
                }
            }

            sf.Dispose();
        }

        private string csvParse(string title, DataPointCollection points)
        {
            string csv = title;

            for (int i = 0; i < points.Count; i++)
                csv += "\n" + points[i].XValue + "," + points[i].YValues[0];

            return csv;
        }
    }
}
