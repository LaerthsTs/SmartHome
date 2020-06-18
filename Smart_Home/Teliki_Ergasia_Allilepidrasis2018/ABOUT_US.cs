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
    public partial class ABOUT_US : Form
    {
        public ABOUT_US()
        {
            InitializeComponent();
        }

        

        private void plirofories_Click(object sender, EventArgs e)
        {
            plirofories.Location = new Point(10, 88);
            oroi.Visible = false;
            suxnes_erwt.Visible = false;
            eksipiretisi.Visible = false;
            panel1.Visible = true;
            panel1.Location = new Point(83, 162);
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void oroi_Click(object sender, EventArgs e)
        {
            oroi.Location = new Point(10, 88);
            plirofories.Visible = false;
            suxnes_erwt.Visible = false;
            eksipiretisi.Visible = false;
            panel2.Visible = true;
            panel2.Location = new Point(83, 162);
            panel1.Visible = false;
            panel3.Visible = false;
        }

        private void eksipiretisi_Click(object sender, EventArgs e)
        {
            eksipiretisi.Location = new Point(10, 88);
            oroi.Visible = false;
            suxnes_erwt.Visible = false;
            plirofories.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel3.Location = new Point(83, 162);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel2.Visible = false;
            eksipiretisi.Location = new Point(10, 312);
            oroi.Visible = true;
            plirofories.Visible = true;
            suxnes_erwt.Visible = true;
            eksipiretisi.Visible = true;
            panel3.Visible = false;
        }

        private void OKK2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel2.Visible = false;
            oroi.Location = new Point(10, 239);
            oroi.Visible = true;
            plirofories.Visible = true;
            suxnes_erwt.Visible = true;
            eksipiretisi.Visible = true;
            panel3.Visible = false;
        }

        private void OKK_Click(object sender, EventArgs e)
        {
            plirofories.Visible = true;
            plirofories.Location = new Point(10, 162);
            oroi.Visible = true;
            suxnes_erwt.Visible = true;
            eksipiretisi.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void ABOUT_US_Load(object sender, EventArgs e)
        {

        }

        private void menuBUTTON_Click(object sender, EventArgs e)
        {
            Hide();
            MENU_APP MENU = new MENU_APP();
            MENU.ShowDialog();
        }

        private void piswBUTTON_Click(object sender, EventArgs e)
        {
            Hide();
            MENU_APP MENU = new MENU_APP();
            MENU.ShowDialog();
        }
    }
}
