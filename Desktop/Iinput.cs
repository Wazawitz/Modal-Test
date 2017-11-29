using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModalTest
{
    interface IInput
    {
        bool IsOpen { get; }

        void Close();
        void Dispose();

        string PortName { get; set; }
        int BaudRate { get; set; }
        int ReadTimeout { get; set; }
        int WriteTimeout { get; set; }

        void Open();
        string ReadLine();
    }
}
