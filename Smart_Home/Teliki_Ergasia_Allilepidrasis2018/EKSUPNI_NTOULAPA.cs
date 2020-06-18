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
    public partial class EKSUPNI_NTOULAPA : Form
    {
        int click = 0, koitaw=1;
        bool flag=false;
        public EKSUPNI_NTOULAPA()
        {
            InitializeComponent();
        }
        //επιστρέφει με το πατημα του κουμπιου στην ακριβως προηγουμενη φορμα
        private void piswBUTTON_Click(object sender, EventArgs e)
        {
            MENU_APP menu = new MENU_APP();
            Hide();
            menu.Show();
        }
        //επιστρέφει με το πατημα του κουμπιου στην φορμα του αρχικου μενου
        private void menuBUTTON_Click(object sender, EventArgs e)
        {
            MENU_APP menu = new MENU_APP();
            Hide();
            menu.Show();
        }
        //
        private void button1_Click(object sender, EventArgs e)
        {
            click = click + 1;
            if (click==1)
            {
                this.BackgroundImage = Properties.Resources.a2;
                vpisw.Enabled = true;
            }else if (click == 2)
            {
                this.BackgroundImage = Properties.Resources.a3;

            }
            else
            {
                this.BackgroundImage = Properties.Resources.a4;
                vmprosta.Enabled = false;
                button3.Visible = true;
            }
        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            click = click - 1;
            if (click == 2)
            {
                this.BackgroundImage = Properties.Resources.a3;
                vmprosta.Enabled = true;
                button3.Visible = false;
            }else if (click == 1)
            {
                this.BackgroundImage = Properties.Resources.a2;
            }else 
            {
                this.BackgroundImage = Properties.Resources.a1;
                vpisw.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.ntoulapa001;
            vdeksia.Visible = true;
            varistera.Visible = true;
            vpisw.Visible = false;
            vmprosta.Visible = false;
            button3.Visible = false;
            exit.Visible = true;
            koitaw = 1;
            flag = true;
        }

        private void vdeksia_Click(object sender, EventArgs e)
        {
            koitaw =koitaw -1;
            if (koitaw == 0)
            {
                this.BackgroundImage = Properties.Resources.ntoulapa002;
                varistera.Enabled = true;
                vdeksia.Enabled = false;
            }else 
            { 
                
             this.BackgroundImage = Properties.Resources.ntoulapa001;
                    varistera.Enabled = true;
                    vdeksia.Enabled = true;
                
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            vdeksia.Visible = false;
            flag = false;
            varistera.Visible = false;
            vpisw.Visible = true;
            vmprosta.Visible = true;
            button3.Visible = false;
            vpisw.Enabled = false;
            vmprosta.Enabled = true;
            exit.Visible = false;
           click = 0;
            this.BackgroundImage = Properties.Resources.a1;
        }

        private void varistera_MouseDown(object sender, MouseEventArgs e)
        {
            varistera.BackgroundImage =Properties.Resources.mplearistera;
        }

        private void varistera_MouseUp(object sender, MouseEventArgs e)
        {
            varistera.BackgroundImage = Properties.Resources.varistera;
        }

        private void vdeksia_MouseDown(object sender, MouseEventArgs e)
        {
            vdeksia.BackgroundImage = Properties.Resources.mpledeksia;
        }

        private void vdeksia_MouseUp(object sender, MouseEventArgs e)
        {
            vdeksia.BackgroundImage = Properties.Resources.vdeksia;
        }

        private void vmprosta_MouseDown(object sender, MouseEventArgs e)
        {
            vmprosta.BackgroundImage = Properties.Resources.max__ddd;
        }

        private void vmprosta_MouseUp(object sender, MouseEventArgs e)
        {
            vmprosta.BackgroundImage = Properties.Resources.max__;
        }

        private void vpisw_MouseDown(object sender, MouseEventArgs e)
        {
            vpisw.BackgroundImage = Properties.Resources.minddd;
        }

        private void vpisw_MouseUp(object sender, MouseEventArgs e)
        {
            vpisw.BackgroundImage = Properties.Resources.min__;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {if (flag==false)
                MessageBox.Show("Πλησιάστε την ντουλάπα με την βοήθεια των κουμπιών για να μπορέσετε να την ανοίξετε!");
            else
                MessageBox.Show("Με την βοήθεια των κουμπιών μπορείτε να δείτε το εσωτερικό της ντουλάπας σας αναπάσα στιγμή!");
        }

        private void varistera_Click(object sender, EventArgs e)
        {
            koitaw =koitaw +1;
            if (koitaw==2)
            {
                this.BackgroundImage= Properties.Resources.ntoulapa003;
                varistera.Enabled = false;
                vdeksia.Enabled = true;
            }
            else 
            {

                this.BackgroundImage = Properties.Resources.ntoulapa001;
                varistera.Enabled = true;
                vdeksia.Enabled = true;

            }
        }
    }
}
