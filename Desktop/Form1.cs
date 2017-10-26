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

namespace ModalTest
{
    public partial class Form1 : Form
    {
        SerialPort SelectedPort = new SerialPort();
        
        int sampleratecounter = 0;

        System.Windows.Forms.Timer sampletimer;

        Stopwatch graphsw = new Stopwatch();
        double graphtime;
        bool ShouldTime = false;

        private object lockerobject = "";

        public Form1()
        {
            InitializeComponent();

            portlist.DataSource = SerialPort.GetPortNames();
        }

        private void sampletimer_Tick(object sender, EventArgs e)
        {
            lock (lockerobject)
            {
                samplerate.Text = sampleratecounter.ToString();
                sampleratecounter = 0;
            }

        }

        private void portlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            SerialPort s = new SerialPort();
            s.PortName = portlist.SelectedItem.ToString();
            s.BaudRate = 9600;
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

            lock (lockerobject)
            {
                sampleratecounter += Encoding.ASCII.GetByteCount(data);
            }

            datadebugbox.PerformSafely(() =>
            {
                datadebugbox.Text = data;
            });

            vot.PerformSafely(() =>
            {
                try
                {
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

            if (sampletimer != null) sampletimer.Dispose();

            graphsw.Reset();
            graphtime = 0;

            sampletimer = new System.Windows.Forms.Timer();
            sampletimer.Interval = 1000;
            sampletimer.Tick += sampletimer_Tick;

            //also reset graph stuff
            vot.Series[0].Points.Clear();

            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = (int)sampletimechooser.Value;
            t.Tick += T_Tick;

            try
            {
                new Thread(StopwatchLoop).Start();
                SelectedPort.Open();
                sampletimer.Start();
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
                graphtime = (double)graphsw.ElapsedMilliseconds / 1000;
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

            sampletimer.Stop();

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
                File.WriteAllText(sf.FileName, String.Join(",", vot.Series[0].Points));
            }

            sf.Dispose();
        }
    }
}
