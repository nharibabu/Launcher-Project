using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public partial class FrmMain : Form
    {
        private int counter = 0;
        public FrmMain()
        {
            InitializeComponent();
        }

        public int Counter { get => counter; set => counter = value; }

        private void cmdSubmit_Click(object sender, EventArgs e)
        {
            Counter = Counter + 1;
            lblCount.Text = Counter.ToString();
        }
    }
}
