using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kriptografija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKeys_Click(object sender, EventArgs e)
        {
            FrmKeys frmKeys = new FrmKeys();
            frmKeys.ShowDialog();
        }

        private void btnSymetric_Click(object sender, EventArgs e)
        {
            Asymetric symetric = new Asymetric();
            symetric.ShowDialog();
        }

        private void btnAsymetric_Click(object sender, EventArgs e)
        {
            Symetric asymetric = new Symetric();
            asymetric.ShowDialog();
        }

        private void btnDigitalSign_Click(object sender, EventArgs e)
        {
            DigitalSign digitalSign = new DigitalSign();
            digitalSign.ShowDialog();
        }
    }
}
