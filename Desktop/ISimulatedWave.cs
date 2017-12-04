using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModalTest
{
    //generate wave, or repeat csv file
    class ISimulatedWave : IDataSource
    {
        private Wave WaveTemplate;

        private bool _IsOpen = false;

        public bool IsOpen { get { return _IsOpen; } }

        public void Open() //settings form here
        {
            WaveGenForm wgf = new WaveGenForm();
            wgf.ShowDialog();
            WaveTemplate = wgf.WaveTemplate;
            wgf.Dispose();
        }

        public string ReadLine() //duh do wave generation stuffs
        {
            throw new NotImplementedException("in readline");
        }

        public void Close() //send stop signals use isopen?
        {
            _IsOpen = false;
        }

        public void Dispose() //basically unused
        {
            if (!IsOpen)
                Close();
        }
    }
}
