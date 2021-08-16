using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekaprojekti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MuutaBT_Click(object sender, EventArgs e)
        {
            ViestiLB.Text = "Hei, " + TekstiTB.Text + " Mene töihin!!!";
            ViestiLB.Visible = true;
        }

        private void PeruutaTB_Click(object sender, EventArgs e)
        {
            ViestiLB.Text = " ";

        }

        private void ViestiLB_Click(object sender, EventArgs e)
        {

        }
    }
}
