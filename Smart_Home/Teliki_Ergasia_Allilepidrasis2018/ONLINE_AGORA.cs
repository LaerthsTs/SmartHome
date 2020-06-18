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
    public partial class ONLINE_AGORA : Form
    {
        

        public ONLINE_AGORA(string sunolikoPoso)
        {
            InitializeComponent();
            poso.Text = sunolikoPoso;

        }

        private void ONLINE_AGORA_Load(object sender, EventArgs e)
        {

        }

        private void menuBUTTON_Click(object sender, EventArgs e)
        {
            MENU_APP MENU = new MENU_APP();
            Hide();
            MENU.Show();
            eikonaCard.Visible = false;
            panelCreditCard.Visible = false;
            panel1.Location = new Point(211, 335);
        }

        private void piswBUTTON_Click(object sender, EventArgs e)
        {
           
            Hide();
            
            eikonaCard.Visible = false;
            panelCreditCard.Visible = false;
            panel1.Location = new Point(211, 335);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void helpOnoma_Click(object sender, EventArgs e)
        {
            timerONOMA.Enabled = true;
            onomaF.Visible = true;
            helpOnoma.Enabled = false;

        }

        private void helpEmail_Click(object sender, EventArgs e)
        {
            timerMAIL.Enabled = true;
            emailF.Visible = true;
            helpEmail.Enabled = false;
        }

        private void helpEpwnumo_Click(object sender, EventArgs e)
        {
            timerEPWNUMO.Enabled = true;
            epwnumoF.Visible = true;
            helpEpwnumo.Enabled = false;
        }

        private void helpTil_Click(object sender, EventArgs e)
        {
            timerTIL.Enabled = true;
            tilefwnoF.Visible = true;
            helpTil.Enabled = false;
        }

        private void helpOdos_Click(object sender, EventArgs e)
        {
            timerODOS.Enabled = true;
            odosF.Visible = true;
            helpOdos.Enabled = false;

        }

        private void helpTK_Click(object sender, EventArgs e)
        {
            timerTK.Enabled = true;
            tkF.Visible = true;
            helpTK.Enabled = false;
        }

        private void helpNomos_Click(object sender, EventArgs e)
        {
            timerNOMOS.Enabled = true;
            nomosF.Visible = true;
            helpNomos.Enabled = false;
        }

        private void helpXwra_Click(object sender, EventArgs e)
        {
            timerXWRA.Enabled = true;
            xwraF.Visible = true;
            helpXwra.Enabled = false;
        }

        private void timerONOMA_Tick(object sender, EventArgs e)
        {
            onomaF.Visible = false;
            helpOnoma.Enabled = true;
            timerONOMA.Enabled = false;
        }

        private void timerEPWNUMO_Tick(object sender, EventArgs e)
        {
            epwnumoF.Visible = false;
            helpEpwnumo.Enabled = true;
            timerEPWNUMO.Enabled = false;
        }

        private void timerMAIL_Tick(object sender, EventArgs e)
        { 
            emailF.Visible = false;
            helpEmail.Enabled = true;
            timerMAIL.Enabled = false;
        }

        private void timerTIL_Tick(object sender, EventArgs e)
        {  
            tilefwnoF.Visible = false;
            helpTil.Enabled = true;
            timerTIL.Enabled = false;
        }

        private void timerODOS_Tick(object sender, EventArgs e)
        {
            odosF.Visible = false;
            helpOdos.Enabled = true;
            timerODOS.Enabled = false;
        }

        private void timerTK_Tick(object sender, EventArgs e)
        {
            tkF.Visible = false;
            helpTK.Enabled = true;
            timerTK.Enabled = false;
        }

        private void timerNOMOS_Tick(object sender, EventArgs e)
        { 
            nomosF.Visible = false;
            helpNomos.Enabled = true;
            timerNOMOS.Enabled = false;
        }

        private void timerXWRA_Tick(object sender, EventArgs e)
        {
            
            xwraF.Visible = false;
            helpXwra.Enabled = true;
            timerXWRA.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(12, 269);
            panelCreditCard.Visible = true;
            panelCreditCard.Location = new Point(325,269);
        }

        private void helpCredit1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                eikonaCard.Visible = true;
                eikonaCard.Image = Properties.Resources.americanola1;
                timerCreditCard1.Enabled = true;
                helpCredit1.Enabled = false;
                

            }
            else if (radioButton2.Checked == true)
            {
                eikonaCard.Visible = true;
                eikonaCard.Image = Properties.Resources.maestroocardola1;
                timerCreditCard1.Enabled = true;
                helpCredit1.Enabled = false;
               
            }
            else if(radioButton3.Checked==true)
            {
                eikonaCard.Visible = true;
                eikonaCard.Image = Properties.Resources.mastercardola1;
                timerCreditCard1.Enabled = true;
                helpCredit1.Enabled = false;
               
            }
            else
            {
                eikonaCard.Visible = true;
                eikonaCard.Image = Properties.Resources.visaola1;
                timerCreditCard1.Enabled = true;
                helpCredit1.Enabled = false;
               

            }
        }

        private void timerCreditCard1_Tick(object sender, EventArgs e)
        {
            eikonaCard.Visible = false;
            helpCredit1.Enabled = true;
            timerCreditCard1.Enabled = false;
        }

        private void helpCredit2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                eikonaCard.Visible = true;
                eikonaCard.Image = Properties.Resources.americanola2;
                timerCreditCard2.Enabled = true;
                helpCredit2.Enabled = false;
                

            }
            else if (radioButton2.Checked == true)
            {
                eikonaCard.Visible = true;
                eikonaCard.Image = Properties.Resources.maestroocardola2;
                timerCreditCard2.Enabled = true;
                helpCredit2.Enabled = false;
               
            }
            else if (radioButton3.Checked == true)
            {
                eikonaCard.Visible = true;
                eikonaCard.Image = Properties.Resources.mastercardola2;
                timerCreditCard2.Enabled = true;
                helpCredit2.Enabled = false;
            
            }
            else
            {
                eikonaCard.Visible = true;
                eikonaCard.Image = Properties.Resources.visaola2;
                timerCreditCard2.Enabled = true;
                helpCredit2.Enabled = false;
            

            }
        }

        private void timerCreditCard2_Tick(object sender, EventArgs e)
        {
            eikonaCard.Visible = false;
            helpCredit2.Enabled = true;
            timerCreditCard2.Enabled = false;
        }

        private void helpCredit3_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                eikonaCard.Visible = true;
                eikonaCard.Image = Properties.Resources.americanola3;
                timerCreditCard3.Enabled = true;
                helpCredit3.Enabled = false;


            }
            else if (radioButton2.Checked == true)
            {
                eikonaCard.Visible = true;
                eikonaCard.Image = Properties.Resources.maestroocardola3;
                timerCreditCard3.Enabled = true;
                helpCredit3.Enabled = false;

            }
            else if (radioButton3.Checked == true)
            {
                eikonaCard.Visible = true;
                eikonaCard.Image = Properties.Resources.mastercardola3;
                timerCreditCard3.Enabled = true;
                helpCredit3.Enabled = false;

            }
            else
            {
                eikonaCard.Visible = true;
                eikonaCard.Image = Properties.Resources.visaola3;
                timerCreditCard3.Enabled = true;
                helpCredit3.Enabled = false;


            }
        }

        private void timerCreditCard3_Tick(object sender, EventArgs e)
        {
            eikonaCard.Visible = false;
            helpCredit3.Enabled = true;
            timerCreditCard3.Enabled = false;
        }

        private void helpCredit4_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                eikonaCard.Visible = true;
                eikonaCard.Image = Properties.Resources.AM;
                timerCreditCard4.Enabled = true;
                helpCredit4.Enabled = false;


            }
            else if (radioButton2.Checked == true)
            {
                eikonaCard.Visible = true;
                eikonaCard.Image = Properties.Resources.olesCARD;
                timerCreditCard4.Enabled = true;
                helpCredit4.Enabled = false;

            }
            else if (radioButton3.Checked == true)
            {
                eikonaCard.Visible = true;
                eikonaCard.Image = Properties.Resources.olesCARD;
                timerCreditCard4.Enabled = true;
                helpCredit4.Enabled = false;

            }
            else
            {
                eikonaCard.Visible = true;
                eikonaCard.Image = Properties.Resources.olesCARD;
                timerCreditCard4.Enabled = true;
                helpCredit4.Enabled = false;


            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void timerCreditCard4_Tick(object sender, EventArgs e)
        {

            eikonaCard.Visible = false;
            helpCredit4.Enabled = true;
            timerCreditCard4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textB2.Text!="" && textB.Text!="" && textB3.Text != "" && textB4.Text != "" && textB5.Text != "" && textB6.Text != "" && textB7.Text != "")
            {
               

                if (panelCreditCard.Visible == true)
                {
                    if (textCard1.Text != "" && textCard2.Text != "" && textCard3.Text != "" && textCard4.Text != "" && textCard5.Text != "")
                    {
                        panel1.Location = new Point(211, 335);
                        panelCreditCard.Visible = false;
                       
                        if (MessageBox.Show("ΣΥΓΧΑΡΗΤΗΡΙΑ ΟΛΟΚΛΗΡΩΘΗΚΕ ΕΠΙΤΥΧΩΣ Η ΑΓΟΡΑ ΣΑΣ!" + "\n" + "ΘΑ ΣΑΣ ΕΡΘΕΙ ΕΝΗΜΕΡΩΤΙΚΟ ΜΗΝΥΜΑ ΣΤΟ ΣΧΕΤΙΚΟ EMAIL."+"\n"+"ΘΑ ΘΕΛΑΤΕ ΝΑ ΣΥΝΕΧΙΣΕΤΕ ΤΙΣ ΑΓΟΡΕΣ ΣΑΣ?", "ΤΟ ΚΑΤΑΣΤΗΜΑ ΣΑΣ ΕΥΧΑΡΙΣΤΕΙ ΓΙΑ ΤΗΝ ΠΡΟΤΙΜΗΣΗ!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                        {
                            Hide();


                        }
                        else
                        {
                            EKSUPNO_PSUGEIO EK = new EKSUPNO_PSUGEIO();
                            Hide();
                            EK.ShowDialog();
                            
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("ΔΕΝ ΕΧΕΤΕ ΣΥΜΠΛΗΡΩΣΕΙ ΣΩΣΤΑ ΤΑ ΠΕΔΙΑ ΤΗΣ ΚΑΡΤΑΣ!");
                    }
                } else
                {
                    MessageBox.Show("ΕΠΙΛΕΞΤΕ ΤΡΟΠΟ ΠΛΗΡΩΜΗΣ!");
                }
            }else
            {
                MessageBox.Show("ΣΥΜΠΛΗΡΩΣΤΕ ΤΑ ΥΠΟΧΡΕΩΤΙΚΑ ΠΕΔΙΑ ΜΕ ΤΗΝ ΕΝΔΥΞΗ *" + "\n" + "ΓΙΑ ΝΑ ΣΥΝΕΧΙΣΕΤΕ ΤΗΝ ΑΓΟΡΑ ΣΑΣ!");
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(12, 269);
            panelCreditCard.Visible = true;
            panelCreditCard.Location = new Point(325, 269);
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(12, 269);
            panelCreditCard.Visible = true;
            panelCreditCard.Location = new Point(325, 269);
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(12, 269);
            panelCreditCard.Visible = true;
            panelCreditCard.Location = new Point(325, 269);
        }
    }
}
