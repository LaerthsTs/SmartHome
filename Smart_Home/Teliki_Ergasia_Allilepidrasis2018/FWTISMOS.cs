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
    public partial class FWTISMOS : Form
    {
        bool diakoptis = true;
        bool d1 = true, d2 = true, d3 = true, d4 = true;
        int m = 0;



        public FWTISMOS()
        {
            InitializeComponent();
            onSaloni.Visible = true;
            offsaloni.Visible = false;
            onKouzina.Visible = true;
            offKouzina.Visible = false;
            on2.BackgroundImage = Properties.Resources.off_f;
            on4.BackgroundImage = Properties.Resources.off_f;
            timer1.Enabled = false;
        }

       

        private void on1_Click(object sender, EventArgs e)
        {
            if (d1)
            {
                onSaloni.Visible = true;
                offsaloni.Visible = false;
                on1.BackgroundImage = Properties.Resources.on_f;
                d1 = false;
            }
            else
            {
                onSaloni.Visible = false;
                offsaloni.Visible = true;
                on1.BackgroundImage = Properties.Resources.off_f;
                d1 = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (m < 500)
            {
                pictureBox1.Visible = true;
                onHELP1.Visible = true;
                m += 10;
            }
            else if (m < 1000)
            {
                pictureBox1.Visible = false;
                onHELP1.Visible = false;
                pictureBox2.Visible = true;
                onHelp2.Visible = true;
                onHelp3.Visible = true;
                m += 10;
            }
            else
            {
                pictureBox2.Visible = false;
                onHelp2.Visible = false;
                onHelp3.Visible = false;
                m = 0;
                timer1.Enabled = false;
            }
        }

        private void onoffall_Click(object sender, EventArgs e)
        {

            if (diakoptis)
            {
                onoffall.BackgroundImage = Properties.Resources.off_all;
                onSaloni.Visible = false;
                offsaloni.Visible = true;
                on1.BackgroundImage = Properties.Resources.off_f;

                onKouzina.Visible = false;
                offKouzina.Visible = true;
                on2.BackgroundImage = Properties.Resources.off_f;

                onDwmatio.Visible = false;
                offDwmatio.Visible = true;
                on3.BackgroundImage = Properties.Resources.off_f;

                onMpanio.Visible = false;
                offMpanio.Visible = true;
                on4.BackgroundImage = Properties.Resources.off_f;
                diakoptis = false;
            }
            else
            {
                onoffall.BackgroundImage = Properties.Resources.on_all;
                onSaloni.Visible = true;
                offsaloni.Visible = false;
                on1.BackgroundImage = Properties.Resources.on_f;

                onKouzina.Visible = true;
                offKouzina.Visible = false;
                on2.BackgroundImage = Properties.Resources.on_f;

                onDwmatio.Visible = true;
                offDwmatio.Visible = false;
                on3.BackgroundImage = Properties.Resources.on_f;

                onMpanio.Visible = true;
                offMpanio.Visible = false;
                on4.BackgroundImage = Properties.Resources.on_f;

                diakoptis = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            MENU_APP menu = new MENU_APP();
            menu.ShowDialog();
        }

        private void OnlineHelp_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
           
        }

        private void piswBUTTON_Click(object sender, EventArgs e)
        {
            MENU_APP M = new MENU_APP();
            Hide();
            M.Show();
        }

        private void menuBUTTON_Click(object sender, EventArgs e)
        {
            MENU_APP M = new MENU_APP();
            Hide();
            M.Show();
        }

        private void on2_Click(object sender, EventArgs e)
        {
            if (d2)
            {
                onDwmatio.Visible = true;
                offDwmatio.Visible = false;
                on2.BackgroundImage = Properties.Resources.on_f;
                d2 = false;
            }
            else
            {
                onDwmatio.Visible = false;
                offDwmatio.Visible = true;
                on2.BackgroundImage = Properties.Resources.off_f;
                d2 = true;
            }
        }

       
        private void on3_Click(object sender, EventArgs e)
        {
            if (d3)
            {
                onKouzina.Visible = true;
                offKouzina.Visible = false;
                on3.BackgroundImage = Properties.Resources.on_f;
                d3 = false;
            }
            else
            {
                onKouzina.Visible = false;
                offKouzina.Visible = true;
                on3.BackgroundImage = Properties.Resources.off_f;
                d3 = true;
            }
        }
        private void on4_Click(object sender, EventArgs e)
        {
            if (d4)
            {
                onMpanio.Visible = true;
                offMpanio.Visible = false;
                on4.BackgroundImage = Properties.Resources.on_f;
                d4 = false;
            }
            else
            {
                onMpanio.Visible = false;
                offMpanio.Visible = true;
                on4.BackgroundImage = Properties.Resources.off_f;
                d4 = true;
            }
        }
    }
}
