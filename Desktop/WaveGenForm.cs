using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModalTest
{
    public partial class WaveGenForm : Form
    {
        private Wave _Wave; //edit waves settings

        public Wave WaveTemplate { get { return _Wave; } }

        public WaveGenForm()
        {
            _Wave = new Wave();
            InitializeComponent();
        }
    }
}
