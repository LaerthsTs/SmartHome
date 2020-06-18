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
    public partial class settings : Form
    {
        int patima = 1, back = 1, sunt = 0, ps= 0, click=0;
        public settings()
        {
            InitializeComponent();
        }

        private void piswBUTTON_Click(object sender, EventArgs e)
        {
            if (back == 1)
            {
                EKSUPNO_PSUGEIO ek = new EKSUPNO_PSUGEIO();
                Hide();
                ek.ShowDialog();
            }
            else
            {
                panelwifi.Visible = true;
                panelwifi.Location = new Point(4, 125);
                panelthermo.Visible = true;
                panelthermo.Location = new Point(4, 206);
                panelugrasia.Visible = true;
                panelugrasia.Location = new Point(4, 287);
                back = 1;
                Wifi_panel.Visible = false;
                panel5.Visible = false;
                panelUGRASIAS.Visible = false;


            }
           
        }

        private void menuBUTTON_Click(object sender, EventArgs e)
        {
           
                MENU_APP menu = new MENU_APP();
                Hide();
                menu.ShowDialog();
            
        }

        private void WIFI_Click(object sender, EventArgs e)
        {
            back = 2;
            panelwifi.Location = new Point(4, 91 );
            panelthermo.Visible = false;
            panelugrasia.Visible = false;
            Wifi_panel.Visible = true;
            Wifi_panel.Location = new Point(3, 173);
        }

        private void settings_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sunt > 60)
            {


                sunt = Convert.ToInt32(suntirisi.Text);
                sunt =sunt -1;
                suntirisi.Text = sunt.ToString();
                plus1.Enabled = true;
            }
            else
            {
               min1.Enabled = false;
            }
        }

        private void plus1_MouseDown(object sender, MouseEventArgs e)
        {
            plus1.BackgroundImage = Properties.Resources.max__ddd;
        }

        private void plus1_MouseUp(object sender, MouseEventArgs e)
        {
            plus1.BackgroundImage = Properties.Resources.max__;
        }

        private void min1_MouseDown(object sender, MouseEventArgs e)
        {
            min1.BackgroundImage = Properties.Resources.minddd;
        }

        private void min1_MouseUp(object sender, MouseEventArgs e)
        {
            min1.BackgroundImage = Properties.Resources.min__;
        }

        private void plus2_Click(object sender, EventArgs e)
        {
            if (ps <= 4)
            {
                ps = Convert.ToInt32(psik.Text);
                ps = ps + 1;
                psik.Text = ps.ToString();
                min2.Enabled = true;
            }
            else
            {
                plus2.Enabled = false;
            }
        }

        private void min2_Click(object sender, EventArgs e)
        {

            if (ps > -18)
            {


                ps = Convert.ToInt32(psik.Text);
                ps = ps - 1;
                psik.Text = ps.ToString();
                plus2.Enabled = true;
            }
            else
            {
                min2.Enabled = false;
            }
        }

        private void plus2_MouseDown(object sender, MouseEventArgs e)
        {
            plus2.BackgroundImage = Properties.Resources.max__ddd;
        }

        private void plus2_MouseUp(object sender, MouseEventArgs e)
        {
            plus2.BackgroundImage = Properties.Resources.max__;
        }

        private void min2_MouseDown(object sender, MouseEventArgs e)
        {
            min2.BackgroundImage = Properties.Resources.minddd;
        }

        private void min2_MouseUp(object sender, MouseEventArgs e)
        {
            min2.BackgroundImage = Properties.Resources.min__;
        }

        private void helpEpwnumo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ρυθμίστε την θερμοκρασία της συντήρησης σας προσαυξάνοντας την με τη βοήθεια των σχετικών κουμπιών!");

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ρυθμίστε την θερμοκρασία της ψύξης σας προσαυξάνοντας την με τη βοήθεια των σχετικών κουμπιών!");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            ok.Visible = true;

        }

        private void ok_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            ok.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void ygrasia_Click(object sender, EventArgs e)
        {
            back = 2;
            panelthermo.Visible = false;
            panelwifi.Visible = false;
            panelugrasia.Visible = true;
            panelugrasia.Location = new Point(4,91);
            panelUGRASIAS.Visible = true;
            panelUGRASIAS.Location = new Point(3,173);
        }

        private void min3_Click(object sender, EventArgs e)
        {
            if (click > -2)
            {
                plus3.Enabled = true;
                click = click - 1;
                if (click == -2)
                {
                    pictThermostatis.Image = Properties.Resources._40va1;
                }
                else if (click == -1)
                {
                    pictThermostatis.Image = Properties.Resources._20VQ;
                }
                else if (click == 0)
                {
                    pictThermostatis.Image = Properties.Resources._0va;
                }
                else if (click == 1)
                {
                    pictThermostatis.Image = Properties.Resources._20VA;
                }
                else if (click == 2)
                {
                    pictThermostatis.Image = Properties.Resources._40VA;
                }
                else if (click == 3)
                {
                    pictThermostatis.Image = Properties.Resources._60VA;
                }
                else if (click == 4)
                {
                    pictThermostatis.Image = Properties.Resources._80VA;
                }
                else
                {
                    pictThermostatis.Image = Properties.Resources._100VA;
                }
            }else
            {
                min3.Enabled = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Δείτε την υγρασία που επικρατεί αυτη την στιγμή στο ψυγείο σας!"+"Και προσαρμόστε σύμφωνα με τον οδηγό!");
        }

        private void plus3_MouseDown(object sender, MouseEventArgs e)
        {
            plus3.BackgroundImage = Properties.Resources.max__ddd;
        }

        private void plus3_MouseUp(object sender, MouseEventArgs e)
        {
            plus3.BackgroundImage = Properties.Resources.max__;
        }

        private void min3_MouseDown(object sender, MouseEventArgs e)
        {
            min3.BackgroundImage = Properties.Resources.minddd;
        }

        private void min3_MouseUp(object sender, MouseEventArgs e)
        {
            min3.BackgroundImage = Properties.Resources.min__;
        }

        private void HELP2_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            OK2.Visible = true;
        }

        private void OK2_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            OK2.Visible = false;
        }

        private void plus3_Click(object sender, EventArgs e)
        {
            if (click < 5)
            {
                min3.Enabled = true;
                click = click + 1;

                if (click == -2)
                {
                    pictThermostatis.Image = Properties.Resources._40va1;
                }
                else if (click == -1)
                {
                    pictThermostatis.Image = Properties.Resources._20VQ;
                }
                else if (click == 0)
                {
                    pictThermostatis.Image = Properties.Resources._0va;
                }
                else if (click == 1)
                {
                    pictThermostatis.Image = Properties.Resources._20VA;
                }
                else if (click == 2)
                {
                    pictThermostatis.Image = Properties.Resources._40VA;
                }
                else if (click == 3)
                {
                    pictThermostatis.Image = Properties.Resources._60VA;
                }
                else if (click == 4)
                {
                    pictThermostatis.Image = Properties.Resources._80VA;
                }
                else
                {
                    pictThermostatis.Image = Properties.Resources._100VA;
                }
            }else
            {
                plus3.Enabled = false;
            }
        }
    

        private void thermokrasia_Click(object sender, EventArgs e)
        {
            back = 2;
            panelthermo.Location = new Point(4, 91);
            panelwifi.Visible = false;
            panelugrasia.Visible = false;
            panel5.Visible = true;
            panel5.Location = new Point(3, 173);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sunt <=80)
            {
                sunt = Convert.ToInt32(suntirisi.Text);
                sunt =sunt +1;
                suntirisi.Text = sunt.ToString();
                min1.Enabled = true;
            }
            else
            {
                plus1.Enabled = false;
            }
        }

        private void off_wifi_Click(object sender, EventArgs e)
        {
           if(patima==1)
            {
                off_wifi.Image = Properties.Resources.on_f;
                wifiBLUE.Visible = true;
                wifiBLACK.Visible = false;
                diathesimaDiktia.Visible = true;
                patima = 2;
            }
            else
            {
                off_wifi.Image = Properties.Resources.off_f;
                wifiBLUE.Visible = false;
                wifiBLACK.Visible = true;
                diathesimaDiktia.Visible = false;
                patima = 1;
            }
               
               
               

            
        }
    }
    
}
