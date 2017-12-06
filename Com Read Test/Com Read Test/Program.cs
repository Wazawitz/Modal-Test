using RobustIO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Com_Read_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Writer w = Writer.FromConsole();
            w.Add(new FileStream(@"c:\users\me\desktop\" + "portread_" + DateTime.Now.ToFileTime() + ".log", FileMode.Create));
            string[] ports = SerialPort.GetPortNames();
            SerialPort s = new SerialPort();
            s.BaudRate = 19200;
            s.ReadTimeout = 500;

            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.RealTime;
            Thread.CurrentThread.Priority = ThreadPriority.Highest;

            foreach (string port in ports)
            {
                string[] data = new string[50000];
                long[] times = new long[50000];

                w.ol("Trying ", port);
                s.PortName = port;

                try
                {
                    s.Open();

                    for (int i = 0; i < data.Length; i++)
                    {
                        data[i] = s.ReadLine();
                        times[i] = DateTime.Now.ToFileTime();
                    }
                }
                catch (Exception e)
                {
                    w.ol(w.l, w.l, e.GetType(), ": ", e.Message);
                    s.Close();
                }

                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] != null)
                        w.ol(times[i] + ": " + data[i]);
                }
            }

            w.pause(w.l + "DONE");
        }
    }
}
