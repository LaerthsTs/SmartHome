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
    public partial class SUSKEUES_MOU : Form
    {
        int  sk = 0, m = 0, m2 = 0, rd = 1, kanali = 1, vol = 1, patima = 1;

        bool radio = false, tv = true, volButton = false, koumpi=false , boiler=true;
        

        public SUSKEUES_MOU()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (sk == 1)
            {

                if (m <= 10)
                {
                    coffeeReady.Visible = true;
                    coffeeNoready.Visible = false;
                    m += 1;
                }
                else
                {
                    coffeeReady.Visible = false;
                    coffeeNoready.Visible = true;
                    timer1.Enabled = false;
                    button2.BackgroundImage = Properties.Resources.off_all;
                    patima = 1;
                    button2.Enabled = true;
                    m = 1;
                }
            }
            else if (sk == 2)
            {
                if (m <= 100)
                {

                    tmpLabel.Text = m.ToString();
                    m += 1;
                }
                else
                {
                    m = 0;
                    timer1.Enabled = false;
                    buttBoilerStart.BackgroundImage = Properties.Resources.off_all;
                    boiler = true;
                }
            }
            else if (sk == 3)
            {
                if (radio == true)
                {
                    if (trackBar1.Value == 1)
                    {

                        radioPicChange.Image = Properties.Resources.kissfm;

                    }
                    else if (trackBar1.Value == 2)
                    {

                        radioPicChange.BackgroundImage = Properties.Resources.athensfm;
                    }
                    else if (trackBar1.Value == 3)
                    {


                        radioPicChange.BackgroundImage = Properties.Resources.lovefm;
                    }
                    else if (trackBar1.Value == 4)
                    {

                        radioPicChange.BackgroundImage = Properties.Resources.sfairafm;
                    }

                }
                else
                {
                    radioPicChange.BackgroundImage = Properties.Resources.final;
                    timer1.Enabled = false;
                    timer1.Interval = 1000;
                    radio = false;

                }
            }
            else
            {
                if (m < 3000)
                {
                    volume.Visible = true;
                    m += 1000;
                }
                else
                {
                    volume.Visible = false;
                    timer1.Enabled = false;
                    m = 0;
                }
            }
        }
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (rd==1)
            {
                radio = true;
                
                
                button3.BackgroundImage = Properties.Resources.on_all;
                rd = 2;
                if (trackBar1.Value == 1 )
                {
                    radioPicChange.BackgroundImage = Properties.Resources.kissfm;
                   
                    System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"..\..\media\Skiss.wav");
                    sp.Play();
                    
                }
                else if (trackBar1.Value == 2 )
                {
                    radioPicChange.BackgroundImage = Properties.Resources.athensfm;
                    
                    System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"..\..\media\Sathens.wav");
                    sp.Play();
                    
                }
                else if (trackBar1.Value==3  )
                {
                   
                    System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"..\..\media\Slove.wav");
                    sp.Play();
                    radioPicChange.BackgroundImage = Properties.Resources.lovefm;
                    
                }
                else
                {
                    radioPicChange.BackgroundImage = Properties.Resources.sfairafm;
                   
                    System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"..\..\media\Ssfaira.wav");
                    sp.Play();
                    
                }
            }
            else
            {
                
                radioPicChange.BackgroundImage = Properties.Resources.final;
                button3.BackgroundImage = Properties.Resources.off_all;
                rd = 1;
                sp.Stop();


            }
        }

        private void buttCoffee_Click_1(object sender, EventArgs e)
        {
            patima = 1;
            sk = 1;
            panel1.Visible = true;
            panel1.Location = new Point(178, 12);
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            timer1.Enabled = false;
            timer2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            m2 = 0;
        }

        private void help2_Click(object sender, EventArgs e)
        {

        }

        private void tvButtStart_Click(object sender, EventArgs e)
        {
            if (tv)
            {


                tvButtStart.BackgroundImage = Properties.Resources.on_all;
                tileorasi.BackgroundImage = Properties.Resources.TV_icon01;
                control.Enabled = true;
                tv = false;
            }
            else
            {
                tvButtStart.BackgroundImage = Properties.Resources.off_all;
                tileorasi.BackgroundImage = Properties.Resources.TV_icon;
                control.Enabled = false;
               
                tv = true;
            }
        }

        private void leftChange_Click(object sender, EventArgs e)
        {
            if (kanali == 1)
            {
                tileorasi.BackgroundImage = Properties.Resources.TV_icon04;
                kanali = 4;
            }
            else if (kanali == 2)
            {
                tileorasi.BackgroundImage = Properties.Resources.TV_icon01;
                kanali = 1;
            }
            else if (kanali == 3)
            {
                tileorasi.BackgroundImage = Properties.Resources.TV_icon02;
                kanali = 2;
            }
            else
            {
                tileorasi.BackgroundImage = Properties.Resources.TV_icon03;
                kanali = 3;
            }
        }

        private void rightChange_Click(object sender, EventArgs e)
        {
            if (kanali == 1)
            {
                tileorasi.BackgroundImage = Properties.Resources.TV_icon02;
                kanali = 2;
            }
            else if (kanali == 2)
            {
                tileorasi.BackgroundImage = Properties.Resources.TV_icon03;
                kanali = 3;
            }
            else if (kanali == 3)
            {
                tileorasi.BackgroundImage = Properties.Resources.TV_icon04;
                kanali = 4;
            }
            else
            {
                tileorasi.BackgroundImage = Properties.Resources.TV_icon01;
                kanali = 1;
            }
        }

        private void plusVolume_Click(object sender, EventArgs e)
        {
            volButton = true;
            timer1.Enabled = true;
            timer1.Interval = 3000;
            volume.Visible = true;
            if (vol == 1)
            {
                volume.Image = Properties.Resources._00004;
                vol = 2;
                plusVolume.Enabled = true;
                minVolume.Enabled = true;
            }
            else if (vol == 2)
            {
                volume.Image = Properties.Resources._00002;
                vol = 3;
                plusVolume.Enabled = true;
                minVolume.Enabled = true;
            }
             else
            {
                volume.Image = Properties.Resources._00001;
                vol = 1;
                plusVolume.Enabled = false;
                minVolume.Enabled = true;

            }
        }

        private void minVolume_Click(object sender, EventArgs e)
        {
            volButton = true;
            timer1.Enabled = true;
            timer1.Interval = 1000;
            volume.Visible = true;
            if (vol == 1)
            {
                volume.Image = Properties.Resources._00002;
                vol = 2;
                plusVolume.Enabled = true;
                minVolume.Enabled = true;
            }
            else if (vol == 2)
            {
                volume.Image = Properties.Resources._00004;
                vol = 3;
                plusVolume.Enabled = true;
                minVolume.Enabled = true;
            }
            else
            {
                volume.Image = Properties.Resources._00003;
                vol = 1;
                plusVolume.Enabled = true;
                minVolume.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void piswBUTTON_Click(object sender, EventArgs e)
        {
            Hide();
            MENU_APP menu = new MENU_APP();
            menu.ShowDialog();
            timer1.Enabled = false;
            timer2.Enabled = false;
        }

        private void menuBUTTON_Click(object sender, EventArgs e)
        {
            Hide();
            MENU_APP menu = new MENU_APP();
            menu.ShowDialog();
            timer1.Enabled = false;
            timer2.Enabled = false;
        }

        private void buttBoiler_Click_1(object sender, EventArgs e)
        {
            patima = 1;
            sk = 2;
            panel1.Visible = false;
            panel2.Visible = true;
            panel2.Location = new Point(178, 12);
            panel3.Visible = false;
            panel4.Visible = false;
            timer1.Enabled = false;
            timer2.Enabled = false;
        }

        private void buttRadio_Click_1(object sender, EventArgs e)
        {
            patima = 1;
            sk = 3;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel3.Location = new Point(178, 12);
            panel4.Visible = false;
            timer1.Enabled = false;
            timer2.Enabled = false;
        }

        private void buttTv_Click_1(object sender, EventArgs e)
        {
            patima = 1;
            sk = 4;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            panel4.Location = new Point(178, 12);
            timer1.Enabled = false;
            timer2.Enabled = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        { 

            if ((radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true) &&
                      (radioButton4.Checked == true || radioButton5.Checked == true || radioButton6.Checked == true))
            {
                koumpi = true;
                if (patima == 1)
                {
                    button2.BackgroundImage = Properties.Resources.on_all;
                    coffeeNoready.Visible = false;
                    coffeeReady.Visible = true;
                    timer1.Interval = 1000;
                    timer1.Enabled = true;
                    System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"..\..\media\sound1.wav");
                    sp.Play();
                   
                    patima = 2;
                }
                else
                {
                    timer1.Enabled = false;
                    m = 0;
                    coffeeNoready.Visible = true;
                    coffeeReady.Visible = false;
                    koumpi = false;
                    sp.Stop();
                    button2.BackgroundImage = Properties.Resources.off_all;
                    patima = 1;
                }
            }
        }




        private void buttBoilerStart_Click(object sender, EventArgs e)
        {


            if (boiler)
            {
                buttBoilerStart.BackgroundImage = Properties.Resources.on_all;
                timer1.Enabled = true;
                timer1.Interval =200;
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"..\..\media\sound2.wav");
                sp.Play();
                boiler = false;
                m = 19;
            }
            else
            {
                boiler = true;
                buttBoilerStart.BackgroundImage = Properties.Resources.off_all;
                timer1.Enabled = false;
                m = 0;
                sp.Stop();

            }

            

        }
       
        private void onlineHelp_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer2.Interval = 200;
            m2 = 0;
        }

        private void onHelpBoiler_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer2.Interval = 1000;
            m2 = 0;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (sk == 1) {
                if (m2 < 100)
                {
                    velos1.Visible = true;
                    help1.Visible = true;
                    m2 += 10;
                }
                else if (m2 < 200)
                {

                    velos1.Location = new Point(281, 471);

                    help1.Text = "ΠΑΤΗΣΤΕ ΓΙΑ ΕΝΕΡΓΟΠΟΙΗΣΗ ΤΗΣ ΜΗΧΑΝΗΣ ΚΑΦΕ!";

                    m2 += 10;
                }
                else
                {
                    velos1.Visible = false;
                    help1.Visible = false;
                    timer2.Enabled = false;
                    m2 = 0;

                }
            }else if (sk == 2)
            {
                if (m2<5)
                {
                    velos.Visible = true;
                    help2.Visible = true;
                    help2.Text = "ΠΑΤΗΣΤΕ ΤΟ ΚΟΥΜΠΙ ΓΙΑ ΝΑ ΞΕΚΙΝΗΣΕΙ"+"\n"+" Ο ΒΡΑΣΤΗΡΑΣ!";
                    m2 += 1;
                }else if(m2>=5 && m2 < 10)
                {
                    velos.Visible = false;
                    velos2.Visible = true;
                    help2.Text = "ΔΕΙΤΕ ΤΗΝ ΕΝΔΥΞΗ ΘΕΡΜΟΚΡΑΣΙΑΣ ΟΤΑΝ ΣΤΑΜΑΤΗΣΕΙ!"+"\n"+"ΤΟ ΝΕΡΟ ΣΑΣ ΘΑ ΕΧΕΙ ΒΡΑΣΕΙ!";
                    m2 += 1;
                }
                else
                {
                    timer2.Enabled = false;
                    velos2.Visible = false;
                    help2.Visible = false;
                    m2 = 0;
                }
            }else if(sk==3)
            {
                if (m2 < 15)
                {
                    m2 += 1;
                    helpRadio.Visible = true;
                    velosRadiou.Visible = true;
                    
                }else if(m2>=15 && m2 < 30)
                {
                    m2 += 1;
                    velosRadiou.Visible = false;
                    velosRadiou2.Visible = true;
                    helpRadio.Text = "ΕΝΕΡΓΟΠΟΙΗΣΕ ΤΟ ΡΑΔΙΟΦΩΝΟ!"+"\n"+"ΕΠΑΝΑΛΑΒΕ ΤΗΝ ΔΙΑΔΙΚΑΣΙΑ ΓΙΑ ΝΑ ΑΛΛΑΞΕΙΣ ΣΤΑΘΜΟ"+"\n"+" ΜΕ ΔΙΠΛΟ ΚΛΙΚ!";
                }
                else
                {
                    m2 = 0;
                    velosRadiou2.Visible = false;
                    helpRadio.Visible = false;
                    timer2.Enabled = false;
                }
                

                
            }
            else
            {

            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
           
        }

        System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
      
    }
}
