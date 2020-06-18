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
    public partial class EKSUPNO_PSUGEIO : Form
    {
        int help = 0, sec = 0;
        bool stop = false;
        Bitmap myBitmap;
        public EKSUPNO_PSUGEIO()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            okButtonHelp.Visible = true;
            okButtonHelp.BackgroundImage = Properties.Resources.okkk;
            okButtonHelp.Size = new Size(92,97);
            nextButtonHelp.Visible = true;
            timer1.Enabled = true;
            leitourgiesPsLabel.Visible = true;
            help = 1;
            button7.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
           
            panel1.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void okButtonHelp_Click(object sender, EventArgs e)
        {
            help = 1;
            timer1.Enabled = false;
            velos2.Visible = false;
            velos3.Visible = false;
            velos1.Visible = false;
            velos1.Location = new Point(156, 75);
            onlineHelpLabel.Visible = false;
            leitourgiesPsLabel.Visible = false;
            okButtonHelp.Visible = false;
            nextButtonHelp.Visible = false;
            button7.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
           
            panel1.Visible = false;

        }

        private void nextButtonHelp_Click(object sender, EventArgs e)
        {
            help += 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RIKSEMIAMATIA MATIA = new RIKSEMIAMATIA();
            Hide();
            MATIA.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OnlineShop os = new OnlineShop();
            Hide();
            os.ShowDialog();
        }

        private void menuBUTTON_Click(object sender, EventArgs e)
        {
            Hide();
            MENU_APP menu = new MENU_APP();
            menu.ShowDialog();
        }

        private void piswBUTTON_Click(object sender, EventArgs e)
        {
            Hide();
            MENU_APP menu = new MENU_APP();
            menu.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            settings st = new settings();
            Hide();
            st.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            simiwmatario sm = new simiwmatario();
            Hide();
            sm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SUNTAGESMOU suntages = new SUNTAGESMOU();
            Hide();
            suntages.Show();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (help == 1)
            {
                velos1.Visible = true;
                onlineHelpLabel.Visible = true;
                leitourgiesPsLabel.Text = "ΡΙΧΤΕ ΜΙΑ ΜΑΤΙΑ!";
                onlineHelpLabel.Text = "ΜΠΟΡΕΙΤΕ ΑΝΑ ΠΑΣΑ ΣΤΙΓΜΗ ΝΑ ΔΕΙΤΕ"+"\n"+"ΤΟ ΕΣΩΤΕΡΙΚΟ ΤΟΥ ΨΥΓΕΙΟΥ ΣΑΣ";

            } else if (help == 2)
            {
                velos1.Location = new Point(156, 242);
                
                leitourgiesPsLabel.Text = "ΠΑΜΕ ΣΟΥΠΕΡ ΜΑΡΚΕΤ!";
                onlineHelpLabel.Text = "ΓΙΑ ΝΑ ΜΠΟΡΕΙΤΕ ΑΝΑ ΠΑΣΑ ΣΤΙΓΜΗ ΝΑ" + "\n" + "ΚΑΝΕΤΕ ΤΙΣ ΑΓΟΡΕΣ ΣΑΣ ΜΕΣΩ ΤΟΥ APP";
            }
            else if (help == 3)
            {
                velos1.Visible = false;
                velos2.Visible = true;

                leitourgiesPsLabel.Text = "ΕΙΔΟΠΟΙΗΣΕΙΣ!";
                onlineHelpLabel.Text = "ΔΕΙΤΕ ΟΛΕΣ ΤΙΣ ΕΙΔΟΠΟΙΗΣΕΙΣ ΠΟΥ " + "\n" + "ΑΦΟΡΟΥΝ ΤΑ ΑΓΑΠΗΜΕΝΑ ΣΑΣ ΣΑΙΤ ΜΕΣΩ ΤΟΥ APP";

            }
            else if (help == 4)
            {
                velos3.Visible =true ;
                velos2.Visible = false;
              
                leitourgiesPsLabel.Text = "ΤΙ ΝΑ ΜΑΓΕΙΡΕΨΩ ΣΗΜΕΡΑ!";
                onlineHelpLabel.Text = "ΙΔΕΣ ΓΙΑ ΤΟ ΤΙ ΝΑ ΜΑΓΕΙΡΕΨΕΤΕ ΣΗΜΕΡΑ" + "\n" + "ΑΠΟ ΑΠΟΘΗΚΕΥΜΕΝΕΣ ΣΑΣ ΣΥΝΤΑΓΕΣ!";

            }
            else if (help == 5)
            {
                velos1.Visible = true;
                velos1.Location = new Point(156,446);
                velos3.Visible = false;
                nextButtonHelp.Visible = false;
                okButtonHelp.Size = new Size(92,172);
                okButtonHelp.BackgroundImage = Properties.Resources.telos2;
                
                leitourgiesPsLabel.Text = "ΡΥΘΜΙΣΕΙΣ!";
                onlineHelpLabel.Text = "ΓΙΑ ΝΑ ΜΠΟΡΕΙΤΕ ΝΑ ΕΛΕΓΧΕΤΕ" + "\n" + "ΤΗΝ ΘΕΡΜΟΚΡΑΣΙΑ ΚΑΙ ΤΗΝ ΥΓΡΑΣΕΙΣ ΤΟΥ ΨΥΓΕΙΟΥ ΣΑΣ" + "\n" + "ΜΕΣΩ ΤΗΣ ΕΦΑΡΜΟΓΗΣ!";

            }
            else
            {
               
                timer1.Enabled = false;
                velos1.Visible = false;
                velos1.Location = new Point(156,75);
                onlineHelpLabel.Visible = false;
                leitourgiesPsLabel.Visible = false;
                okButtonHelp.Visible = false;
                nextButtonHelp.Visible = false;
                button7.Enabled = true;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                
                panel1.Visible = false;
            }
        }
    }
}
