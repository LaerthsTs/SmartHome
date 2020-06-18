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
    public partial class OnlineShop : Form
    {
        int proion;
        string p1, p2, p3, p4, p5, p6, p7, p8, p9;
        double sum;
       

        public OnlineShop()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ΜΕ ΤΟ ΠΑΤΗΜΑ ΤΟΥ ΚΟΥΜΠΙΟΥ ΚΑΘΑΡΙΖΕΤΕ ΟΛΗ ΤΗΣ ΛΙΣΤΑΣ!");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ΜΠΟΡΕΙΤΕ ΝΑ ΑΦΑΙΡΕΣΕΤΕ ΚΑΠΟΙΟ ΠΡΟΙΟΝ ΜΕΣΑ ΑΠΟ ΤΗΝ ΛΙΣΤΑ ΠΟΥ ΔΕΝ ΕΠΙΘΥΜΕΙΤΕ ΤΕΛΙΚΑ!");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ΜΕ ΤΟ ΠΑΤΗΜΑ ΤΟΥ ΚΟΥΜΠΙΟΥ ΣΥΝΕΧΙΖΕΤΑΙ ΓΙΑ ΤΗΝ ΟΛΟΚΛΗΡΩΣΗ ΤΗΣ ΑΓΟΡΑΣ ΣΑΣ ΜΕΣΩ ΤΗΣ ΠΙΣΤΩΤΙΚΗΣ ΣΑΣ ΚΑΡΤΑΣ!");
        }

        private void piswBUTTON_Click(object sender, EventArgs e)
        {
            EKSUPNO_PSUGEIO PS = new EKSUPNO_PSUGEIO();
            Hide();
            PS.ShowDialog();

        }

        private void menuBUTTON_Click(object sender, EventArgs e)
        {
            MENU_APP MENU = new MENU_APP();
            Hide();
            MENU.ShowDialog();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            proion += 1;
            sum = sum + 1.27;
            listBox1.Items.Add("ΑΝΑΝΑΣ 1,27");
            sunolikoPoso.Text = sum.ToString() + " €";
            p1 = "ΑΝΑΝΑΣ 1,27";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            proion += 1;
            sum += 2.42;
            listBox1.Items.Add("ΜΕΒΓΑΛ ΑΝΘΟΤΥΡΟ 2,42");
            sunolikoPoso.Text = sum.ToString() + " €";
            p2 = "ΜΕΒΓΑΛ ΑΝΘΟΤΥΡΟ 2,42";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ONLINE_AGORA ON = new ONLINE_AGORA(sunolikoPoso.Text);
            ON.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            proion += 1;
            sum += 1.85;
            listBox1.Items.Add("ΜΠΑΝΑΝΑ CHIQUITA 1,85");
            sunolikoPoso.Text = sum.ToString() + " €";
            p3 = "ΜΠΑΝΑΝΑ CHIQUITA 1,85";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            proion += 1;
            sum += 1.54;
            listBox1.Items.Add("ELITE ΦΡΥΓΑΝΙΕΣ 1,54");
            sunolikoPoso.Text = sum.ToString() + " €";
            p4 = "ELITE ΦΡΥΓΑΝΙΕΣ 1,54";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            proion += 1;
            sum += 2.94;
            listBox1.Items.Add("FOUANTRE ΥΦΑΝΤΗΣ 2,94");
            sunolikoPoso.Text = sum.ToString() + " €";
            p5 = "FOUANTRE ΥΦΑΝΤΗΣ 2,94";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            proion += 1;
            sum += 2.16;
            listBox1.Items.Add("ΝΟΥΝΟΥ ΤΥΡΙ GOUDA 2,16");
            sunolikoPoso.Text = sum.ToString() + " €";
            p6 = "ΝΟΥΝΟΥ ΤΥΡΙ GOUDA 2,16";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            proion += 1;
            sum += 2.45;
            listBox1.Items.Add("ΚΟΤΟΠΟΥΛΟ ΤΟΣΤ 2,45");
            sunolikoPoso.Text = sum.ToString() + " €";
            p7 = "ΚΟΤΟΠΟΥΛΟ ΤΟΣΤ 2,45";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            proion += 1;
            sum += 0.47;
            listBox1.Items.Add("ΛΑΧΑΝΟ ΚΟΚΚΙΝΟ 0,47");
            sunolikoPoso.Text = sum.ToString() + " €";
            p8 = "ΛΑΧΑΝΟ ΚΟΚΚΙΝΟ 0,47";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            proion += 1;
            sum += 5.54;
            listBox1.Items.Add("ΜΥΘΟΣ ΜΠΥΡΑ 5,54");
            sunolikoPoso.Text = sum.ToString() + " €";
            p9 = "ΜΥΘΟΣ ΜΠΥΡΑ 5,54";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("ΤΟ ΚΑΛΑΘΙ ΣΑΣ ΕΙΝΑΙ ΑΔΕΙΟ! ");
            }
            else
            {


                if (MessageBox.Show("ΕΙΣΤΕ ΣΙΓΟΥΡΟΙ ΟΤΙ ΘΕΛΕΤΕ ΝΑ ΑΔΕΙΑΣΕΤΕ ΤΟ ΚΑΛΑΘΙ ΣΑΣ?", "ΠΡΟΣΟΧΗ!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    listBox1.Items.Clear();
                    sum = 0;
                    proion = 0;
                    sunolikoPoso.Text = "0  €";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (listBox1.Items.Count != 0)
            {
                if (listBox1.SelectedIndex >= 0)
                {


#pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
                    if (listBox1.SelectedItem==p1)
#pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast
                    {
                        listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        sum = sum - 1.27;
                    }
#pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
                    else if (listBox1.SelectedItem==p2)
#pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast
                    {
                        listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        sum = sum - 2.42;
                    }
#pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
                    else if (listBox1.SelectedItem==p3)
#pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast
                    {
                        listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        sum = sum - 1.85;
                    }
#pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
                    else if (listBox1.SelectedItem == p4)
#pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast
                    {
                        listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        sum = sum - 1.54;
                    }
#pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
                    else if (listBox1.SelectedItem == p5)
#pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast
                    {
                        listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        sum = sum - 2.94;
                    }
#pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
                    else if (listBox1.SelectedItem==p6)
#pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast
                    {
                        listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        sum = sum - 2.16;
                    }
#pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
                    else if (listBox1.SelectedItem==p7)
#pragma warning restore CS0252 // Possible unintnded reference comparison; left hand side needs cast
                    {
                        listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        sum = sum - 2.45;
                    }
#pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
                    else if (listBox1.SelectedItem==p8)
#pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast
                    {
                        listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        sum = sum - 0.47;
                    }
                    else
                    {
                        listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        sum = sum - 5.54;
                    }
                    sunolikoPoso.Text = sum.ToString();
                }
                else
                {
                    MessageBox.Show("ΕΠΙΛΕΓΤΕ ΠΡΩΤΑ ΚΑΠΟΙΟ ΠΡΟΙΟΝ ΓΙΑ ΔΙΑΓΡΑΦΗ!");
                }



            }
            else
            {
                MessageBox.Show("ΤΟ ΚΑΛΑΘΙ ΣΑΣ ΕΙΝΑΙ ΑΔΕΙΟ!");


            }

            }
        }

    }

