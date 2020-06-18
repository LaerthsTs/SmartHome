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
    public partial class SUNTAGESMOU : Form
    {
        int m = 0;
        public SUNTAGESMOU()
        {
            InitializeComponent();
        }

        private void piswBUTTON_Click(object sender, EventArgs e)
        {
            EKSUPNO_PSUGEIO ps = new EKSUPNO_PSUGEIO();
            Hide();
            ps.Show();
        }

        private void menuBUTTON_Click(object sender, EventArgs e)
        {
            MENU_APP menu = new MENU_APP();
            Hide();
            menu.Show();
        }

        private void SUNTAGESMOU_Load(object sender, EventArgs e)
        {
           
            timer1.Enabled = true;
            label1.Visible = true;
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Location = new Point(197,263);
            timer1.Enabled = false;
            this.BackgroundImage = Properties.Resources.font1;
            timer2.Enabled = true;
            panelmenu.Visible = true;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            panel1.Visible = true;
            label1.Visible = false;
            timer2.Enabled = false;
            helpbutton.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelodigies.Visible = true;
            panelodigies.Location = new Point(12,96);
            panel1.Visible = false;
            panelodigies.BackgroundImage = Properties.Resources.Screenshot_20180215_182941;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelodigies.Visible = true;
            panelodigies.Location = new Point(12, 96);
            panel1.Visible = false;
            panelodigies.BackgroundImage = Properties.Resources.Screenshot_20180215_182959;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelodigies.Visible = true;
            panelodigies.Location = new Point(12, 96);
            panel1.Visible = false;
            panelodigies.BackgroundImage = Properties.Resources.Screenshot_20180215_182823;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelodigies.Visible = true;
            panelodigies.Location = new Point(12, 96);
            panel1.Visible = false;
            panelodigies.BackgroundImage = Properties.Resources._001;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelodigies.Visible = true;
            panelodigies.Location = new Point(12, 96);
            panel1.Visible = false;
            panelodigies.BackgroundImage = Properties.Resources._002;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelodigies.Visible = true;
            panelodigies.Location = new Point(12, 96);
            panel1.Visible = false;
            panelodigies.BackgroundImage = Properties.Resources.Screenshot_20180215_182911;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panelodigies.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panelodigies.Visible = false;
            panel1.Visible = false;
            timer3.Enabled = true;
            pictureBox1.Visible = true;
            pictureBox1.Location = new Point(197, 263);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            panel1.Visible = true;
            timer3.Enabled = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        { 
                panelanazitisis.Visible = true;
                pictureBox3.Enabled = false;
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panelanazitisis.Visible = false;
            pictureBox3.Enabled = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            panelanazitisis.Visible = false;
            pictureBox3.Enabled = true;
            panel1.Visible = false;
            pictureBox1.Visible = true;
            pictureBox1.Location = new Point(197, 263);
            timer3.Enabled = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (m<1000)
            {
                velosaristera.Visible = true;
                velosdeksia.Visible = false;
                labelHelp2.Visible = false;
                labelHelp.Location = new Point(100,65);
                labelHelp.Visible = true;
                m = m + 100;
            }else if(m>=1000 && m<2000)
            {
                velosdeksia.Visible = true;
                velosaristera.Visible = false;
                labelHelp.Visible = false;
                labelHelp2.Location = new Point(100,65);
                labelHelp2.Visible = true;
                m = m+100;
            }else
            {
                timer4.Enabled = false;
                velosdeksia.Visible = false;
                labelHelp2.Visible = false;
                helpbutton.Enabled = true;
                m = 0;
                
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            helpbutton.Enabled = false;
            timer4.Enabled = true;
        }
    }
}
