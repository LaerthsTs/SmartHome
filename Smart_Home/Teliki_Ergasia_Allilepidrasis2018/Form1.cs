using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teliki_Ergasia_Allilepidrasis2018
{
    public partial class MENU_APP : Form
    {
        public MENU_APP()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            EKSUPNI_NTOULAPA ek = new EKSUPNI_NTOULAPA();
            ek.ShowDialog();
        }

        private void bpsugeio_Click(object sender, EventArgs e)
        {
            Hide();
            EKSUPNO_PSUGEIO ep = new EKSUPNO_PSUGEIO();
            ep.ShowDialog();
        }

        private void bfwtismos_Click(object sender, EventArgs e)
        {
            Hide();
            FWTISMOS f = new FWTISMOS();
            f.ShowDialog();
        }

        private void bsuskeues_Click(object sender, EventArgs e)
        {
            Hide();
            SUSKEUES_MOU sk = new SUSKEUES_MOU();
            sk.ShowDialog();
        }

        private void baboutus_Click(object sender, EventArgs e)
        {
            Hide();
            ABOUT_US ab = new ABOUT_US();
            ab.ShowDialog();
        }
    }
}
