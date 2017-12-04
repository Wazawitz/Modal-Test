using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModalTest
{
    interface IDataSource
    {
        bool IsOpen { get; }

        void Close();
        void Dispose();

        void Open();
        string ReadLine();
    }
}
