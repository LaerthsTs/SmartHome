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
    public partial class RIKSEMIAMATIA : Form
    {
        public RIKSEMIAMATIA()
        {
            InitializeComponent();
        }

        private void openmeKATW_Click(object sender, EventArgs e)
        {
            panel2KATW.Visible = true;
        }

        private void openmePANW_Click(object sender, EventArgs e)
        {
            panel1PANW.Visible = true;
        }

        private void closemePANW_Click(object sender, EventArgs e)
        {
            panel1PANW.Visible = false;
        }

        private void closemeKATW_Click(object sender, EventArgs e)
        {
            panel2KATW.Visible = false;
        }

        private void backToMenu_Click(object sender, EventArgs e)
        {
            Hide();
            EKSUPNO_PSUGEIO psm = new EKSUPNO_PSUGEIO();
            psm.Show();
        }
    }
}
