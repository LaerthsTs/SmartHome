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
    public partial class simiwmatario : Form
    {
        int click = 0, hmera=1;
        public simiwmatario()
        {
            InitializeComponent();
        }

        private void piswBUTTON_Click(object sender, EventArgs e)
        {
            EKSUPNO_PSUGEIO ps = new EKSUPNO_PSUGEIO();
            Hide();
            ps.ShowDialog();
        }

        private void menuBUTTON_Click(object sender, EventArgs e)
        {
            MENU_APP menu = new MENU_APP();
            Hide();
            menu.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel01.Visible = true;
           
            hmera = 13;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel01.Visible = true;
            click = click + 1;
            hmera = 1;
            
        }

        private void addSimiwsi_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
               
                if (hmera == 1)
                {
                    b1.BackColor = Color.Blue;
                    listBox1.Items.Add("01/02/2018 "+textBox1.Text);
                    textBox1.Text = "";
                }else if (hmera == 2)
                {
                    b2.BackColor = Color.Blue;
                    listBox1.Items.Add("02/02/2018 " + textBox1.Text);
                    textBox1.Text = "";
                }
                else if (hmera == 3)
                {
                    b3.BackColor = Color.Blue;
                    listBox1.Items.Add("03/02/2018 " + textBox1.Text);
                    textBox1.Text = "";
                }
                else if (hmera == 4)
                {
                    b4.BackColor = Color.Blue;
                    listBox1.Items.Add("04/02/2018 " + textBox1.Text);
                    textBox1.Text = "";
                }
                else if (hmera == 5)
                {
                    b5.BackColor = Color.Blue;
                    listBox1.Items.Add("05/02/2018 " + textBox1.Text);
                    textBox1.Text = "";
                }
                else if (hmera == 6)
                {
                    b6.BackColor = Color.Blue;
                    listBox1.Items.Add("06/02/2018 " + textBox1.Text);
                    textBox1.Text = "";
                }
                else if (hmera == 7)
                {
                    b7.BackColor = Color.Blue;
                    listBox1.Items.Add("07/02/2018 " + textBox1.Text);
                    textBox1.Text = "";
                }
                else if (hmera == 8)
                {
                    b8.BackColor = Color.Blue;
                    listBox1.Items.Add("08/02/2018 " + textBox1.Text);
                    textBox1.Text = "";
                }
                else if (hmera == 2)
                {
                    b1.BackColor = Color.Blue;
                    listBox1.Items.Add("01/02/2018 " + textBox1.Text);
                    textBox1.Text = "";
                }
                else if (hmera == 9)
                {
                    b9.BackColor = Color.Blue;
                    listBox1.Items.Add("09/02/2018 " + textBox1.Text);
                    textBox1.Text = "";
                }
                else if (hmera == 10)
                {
                    b10.BackColor = Color.Blue;
                    listBox1.Items.Add("10/02/2018 " + textBox1.Text);
                    textBox1.Text = "";
                }
                else if (hmera == 11)
                {
                    b11.BackColor = Color.Blue;
                    listBox1.Items.Add("11/02/2018 " + textBox1.Text);
                    textBox1.Text = "";
                }
                else if (hmera == 12)
                {
                    b12.BackColor = Color.Blue;
                    listBox1.Items.Add("12/02/2018 " + textBox1.Text);
                    textBox1.Text = "";
                }
                else if (hmera == 13)
                {
                    b13.BackColor = Color.Blue;
                    listBox1.Items.Add("13/02/2018 " + textBox1.Text);
                    textBox1.Text = "";
                }
                else if (hmera == 14)
                {
                    b14.BackColor = Color.Blue;
                    listBox1.Items.Add("14/02/2018 " + textBox1.Text);
                    textBox1.Text = "";
                }
                else if (hmera == 15)
                {
                    b15.BackColor = Color.Blue;
                    listBox1.Items.Add("15/02/2018 " + textBox1.Text);
                    textBox1.Text = "";
                }
                else if (hmera == 16)
                {
                    b16.BackColor = Color.Blue;
                    listBox1.Items.Add("16/02/2018 " + textBox1.Text);
                    textBox1.Text = "";
                }
                else if (hmera == 17)
                {
                    b17.BackColor = Color.Blue;
                    listBox1.Items.Add("17/02/2018 " + textBox1.Text);
                    textBox1.Text = "";
                }
                else if (hmera == 18)
                {
                    b18.BackColor = Color.Blue;
                    listBox1.Items.Add("18/02/2018 " + textBox1.Text);
                    textBox1.Text = "";
                }
                else if (hmera == 19)
                {
                    b19.BackColor = Color.Blue;
                    listBox1.Items.Add("19/02/2018 " + textBox1.Text);
                    textBox1.Text = "";
                }
                else if (hmera == 20)
                {
                    b20.BackColor = Color.Blue;
                    listBox1.Items.Add("20/02/2018 " + textBox1.Text);
                    textBox1.Text = "";
                }
                else if (hmera == 21)
                {
                    b21.BackColor = Color.Blue;
                    listBox1.Items.Add("21/02/2018 " + textBox1.Text);
                    textBox1.Text = "";
                }
                else if (hmera == 22)
                {
                    b22.BackColor = Color.Blue;
                    listBox1.Items.Add("22/02/2018 " + textBox1.Text);
                    textBox1.Text = "";
                }
                else if (hmera == 23)
                {
                    b23.BackColor = Color.Blue;
                    listBox1.Items.Add("23/02/2018 " + textBox1.Text);
                    textBox1.Text = "";
                }
                else if (hmera == 24)
                {
                    b24.BackColor = Color.Blue;
                    listBox1.Items.Add("24/02/2018 " + textBox1.Text);
                    textBox1.Text = "";
                }
                else if (hmera == 25)
                {
                    b25.BackColor = Color.Blue;
                    listBox1.Items.Add("25/02/2018 " + textBox1.Text);
                    textBox1.Text = "";
                }
                else if (hmera == 26)
                {
                    b26.BackColor = Color.Blue;
                    listBox1.Items.Add("26/02/2018 " + textBox1.Text);
                    textBox1.Text = "";
                }
                else if (hmera == 27)
                {
                    b27.BackColor = Color.Blue;
                    listBox1.Items.Add("27/02/2018 " + textBox1.Text);
                    textBox1.Text = "";
                }
                else if (hmera == 28)
                {
                    b28.BackColor = Color.Blue;
                    listBox1.Items.Add("28/02/2018 " + textBox1.Text);
                    textBox1.Text = "";
                }
                else if (hmera == 29)
                {
                    b29.BackColor = Color.Blue;
                    listBox1.Items.Add("29/02/2018 " + textBox1.Text);
                    textBox1.Text = "";
                }
                else if (hmera == 30)
                {
                    b30.BackColor = Color.Blue;
                    listBox1.Items.Add("30/02/2018 " + textBox1.Text);
                    textBox1.Text = "";
                }
                else 
                {
                    b31.BackColor = Color.Blue;
                    listBox1.Items.Add("31/02/2018 " + textBox1.Text);
                    textBox1.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Ούπς! Δεν έγραψες κάποια σημείωση! ");
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >=0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Επιλέξτε πρώτα τη σημείωση που θέλετε να διεγράψετε!");
            }
        }

        private void helpEpwnumo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Επιλέξτε τον μήνα που επιθυμείτε να κάνετε την σημείωση!");
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Επιλέξτε τον έτος που επιθυμείτε να κάνετε την σημείωση!");
        }

        private void simiwmatario_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;

            if (selectedIndex==1)
            {
                b29.Location = new Point(19, 39);
                b30.Location = new Point(101, 39);
                b31.Location = new Point(184, 39);
                b1.Location = new Point(267, 39);
                b2.Location = new Point(350, 39);
                b3.Location = new Point(433, 39);
                b4.Location = new Point(516, 39);
                b5.Location = new Point(19, 104);
                b6.Location = new Point(101, 104);
                b7.Location = new Point(184, 104);
                b8.Location = new Point(267, 104);
                b9.Location = new Point(350, 104);
                b10.Location = new Point(433, 104);
                b11.Location = new Point(516, 104);
                b12.Location = new Point(19, 168);
                b13.Location = new Point(101, 168);
                b14.Location = new Point(184, 168);
                b15.Location = new Point(267, 168);
                b16.Location = new Point(350, 168);
                b17.Location = new Point(433, 168);
                b18.Location = new Point(516, 168);
                b19.Location = new Point(19, 231);
                b20.Location = new Point(101, 231);
                b21.Location = new Point(184, 231);
                b22.Location = new Point(267, 231);
                b23.Location = new Point(350, 231);
                b24.Location = new Point(433, 231);
                b25.Location = new Point(516, 231);
                b26.Location = new Point(19, 294);
                b27.Location = new Point(101, 294);
                b28.Location = new Point(184, 294);
                b001.Location = new Point(267, 294);
                b002.Location = new Point(350, 294);
                b003.Location = new Point(433, 294);
                b004.Location = new Point(516, 294);

                b1.Enabled = true;
                b2.Enabled = true;
                b3.Enabled = true;
                b4.Enabled = true;
                b5.Enabled = true;
                b6.Enabled = true;
                b7.Enabled = true;
                b8.Enabled = true;
                b9.Enabled = true;
                b11.Enabled = true;
                b12.Enabled = true;
                b13.Enabled = true;
                b14.Enabled = true;
                b15.Enabled = true;
                b16.Enabled = true;
                b17.Enabled = true;
                b18.Enabled = true;
                b19.Enabled = true;
                b20.Enabled = true;
                b21.Enabled = true;
                b22.Enabled = true;
                b23.Enabled = true;
                b24.Enabled = true;
                b25.Enabled = true;
                b26.Enabled = true;
                b27.Enabled = true;
                b28.Enabled = true;
                b29.Enabled = false;
                b30.Enabled = false;
                b31.Enabled = false;
                b001.Enabled = false;
                b002.Enabled = false;
                b003.Enabled = false;
                b004.Enabled = false;
                b001.Text = "01";
                b002.Text = "02";
                b003.Text = "03";
                b004.Text = "04";


            }
            else if (selectedIndex == 0)
            {
                b1.Location = new Point(19, 39);
                b2.Location = new Point(101, 39);
                b3.Location = new Point(184, 39);
                b4.Location = new Point(267, 39);
                b5.Location = new Point(350, 39);
                b6.Location = new Point(433, 39);
                b7.Location = new Point(516, 39);
                b8.Location = new Point(19, 104);
                b9.Location = new Point(101, 104);
                b10.Location = new Point(184, 104);
                b11.Location = new Point(267, 104);
                b12.Location = new Point(350, 104);
                b13.Location = new Point(433, 104);
                b14.Location = new Point(516, 104);
                b15.Location = new Point(19, 168);
                b16.Location = new Point(101, 168);
                b17.Location = new Point(184, 168);
                b18.Location = new Point(267, 168);
                b19.Location = new Point(350, 168);
                b20.Location = new Point(433, 168);
                b21.Location = new Point(516, 168);
                b22.Location = new Point(19, 231);
                b23.Location = new Point(101, 231);
                b24.Location = new Point(184, 231);
                b25.Location = new Point(267, 231);
                b26.Location = new Point(350, 231);
                b27.Location = new Point(433, 231);
                b28.Location = new Point(516, 231);
                b29.Location = new Point(19, 294);
                b30.Location = new Point(101, 294);
                b31.Location = new Point(184, 294);
                b001.Location = new Point(267, 294);
                b002.Location = new Point(350, 294);
                b003.Location = new Point(433, 294);
                b004.Location = new Point(516, 294);

                b1.Enabled = true;
                b2.Enabled = true;
                b3.Enabled = true;
                b4.Enabled = true;
                b5.Enabled = true;
                b6.Enabled = true;
                b7.Enabled = true;
                b8.Enabled = true;
                b9.Enabled = true;
                b11.Enabled = true;
                b12.Enabled = true;
                b13.Enabled = true;
                b14.Enabled = true;
                b15.Enabled = true;
                b16.Enabled = true;
                b17.Enabled = true;
                b18.Enabled = true;
                b19.Enabled = true;
                b20.Enabled = true;
                b21.Enabled = true;
                b22.Enabled = true;
                b23.Enabled = true;
                b24.Enabled = true;
                b25.Enabled = true;
                b26.Enabled = true;
                b27.Enabled = true;
                b28.Enabled = true;
                b29.Enabled = true;
                b30.Enabled = true;
                b31.Enabled = true;
                b001.Enabled = false;
                b002.Enabled = false;
                b003.Enabled = false;
                b004.Enabled = false;

                b001.Text = "01";
                b002.Text = "02";
                b003.Text = "03";
                b004.Text = "04";
            }
            else if (selectedIndex == 2)
            {
                b002.Location = new Point(19, 39);
                b003.Location = new Point(101, 39);
                b004.Location = new Point(184, 39);
                b1.Location = new Point(267, 39);
                b2.Location = new Point(350, 39);
                b3.Location = new Point(433, 39);
                b4.Location = new Point(516, 39);
                b5.Location = new Point(19, 104);
                b6.Location = new Point(101, 104);
                b7.Location = new Point(184, 104);
                b8.Location = new Point(267, 104);
                b9.Location = new Point(350, 104);
                b10.Location = new Point(433, 104);
                b11.Location = new Point(516, 104);
                b12.Location = new Point(19, 168);
                b13.Location = new Point(101, 168);
                b14.Location = new Point(184, 168);
                b15.Location = new Point(267, 168);
                b16.Location = new Point(350, 168);
                b17.Location = new Point(433, 168);
                b18.Location = new Point(516, 168);
                b19.Location = new Point(19, 231);
                b20.Location = new Point(101, 231);
                b21.Location = new Point(184, 231);
                b22.Location = new Point(267, 231);
                b23.Location = new Point(350, 231);
                b24.Location = new Point(433, 231);
                b25.Location = new Point(516, 231);
                b26.Location = new Point(19, 294);
                b27.Location = new Point(101, 294);
                b28.Location = new Point(184, 294);
                b29.Location = new Point(267, 294);
                b30.Location = new Point(350, 294);
                b31.Location = new Point(433, 294);
                b001.Location = new Point(516, 294);


                b1.Enabled = true;
                b2.Enabled = true;
                b3.Enabled = true;
                b4.Enabled = true;
                b5.Enabled = true;
                b6.Enabled = true;
                b7.Enabled = true;
                b8.Enabled = true;
                b9.Enabled = true;
                b11.Enabled = true;
                b12.Enabled = true;
                b13.Enabled = true;
                b14.Enabled = true;
                b15.Enabled = true;
                b16.Enabled = true;
                b17.Enabled = true;
                b18.Enabled = true;
                b19.Enabled = true;
                b20.Enabled = true;
                b21.Enabled = true;
                b22.Enabled = true;
                b23.Enabled = true;
                b24.Enabled = true;
                b25.Enabled = true;
                b26.Enabled = true;
                b27.Enabled = true;
                b28.Enabled = true;
                b29.Enabled = true;
                b30.Enabled = true;
                b31.Enabled = false;
                b001.Enabled = false;
                b002.Enabled = false;
                b003.Enabled = false;
                b004.Enabled = false;
                b001.Text = "01";
                b002.Text = "26";
                b003.Text = "27";
                b004.Text = "28";

            }else if (selectedIndex == 4)
            {
                b004.Location = new Point(19, 39);
                b1.Location = new Point(101, 39);
                b2.Location = new Point(184, 39);
                b3.Location = new Point(267, 39);
                b4.Location = new Point(350, 39);
                b5.Location = new Point(433, 39);
                b6.Location = new Point(516, 39);
                b7.Location = new Point(19, 104);
                b8.Location = new Point(101, 104);
                b9.Location = new Point(184, 104);
                b10.Location = new Point(267, 104);
                b11.Location = new Point(350, 104);
                b12.Location = new Point(433, 104);
                b13.Location = new Point(516, 104);
                b14.Location = new Point(19, 168);
                b15.Location = new Point(101, 168);
                b16.Location = new Point(184, 168);
                b17.Location = new Point(267, 168);
                b18.Location = new Point(350, 168);
                b19.Location = new Point(433, 168);
                b20.Location = new Point(516, 168);
                b21.Location = new Point(19, 231);
                b22.Location = new Point(101, 231);
                b23.Location = new Point(184, 231);
                b24.Location = new Point(267, 231);
                b25.Location = new Point(350, 231);
                b26.Location = new Point(433, 231);
                b27.Location = new Point(516, 231);
                b28.Location = new Point(19, 294);
                b29.Location = new Point(101, 294);
                b30.Location = new Point(184, 294);
                b31.Location = new Point(267, 294);
                b001.Location = new Point(350, 294);
                b002.Location = new Point(433, 294);
                b003.Location = new Point(516, 294);

                b1.Enabled = true;
                b2.Enabled = true;
                b3.Enabled = true;
                b4.Enabled = true;
                b5.Enabled = true;
                b6.Enabled = true;
                b7.Enabled = true;
                b8.Enabled = true;
                b9.Enabled = true;
                b11.Enabled = true;
                b12.Enabled = true;
                b13.Enabled = true;
                b14.Enabled = true;
                b15.Enabled = true;
                b16.Enabled = true;
                b17.Enabled = true;
                b18.Enabled = true;
                b19.Enabled = true;
                b20.Enabled = true;
                b21.Enabled = true;
                b22.Enabled = true;
                b23.Enabled = true;
                b24.Enabled = true;
                b25.Enabled = true;
                b26.Enabled = true;
                b27.Enabled = true;
                b28.Enabled = true;
                b29.Enabled = true;
                b30.Enabled = true;
                b31.Enabled = true;
                b001.Enabled = false;
                b002.Enabled = false;
                b003.Enabled = false;
                b004.Enabled = false;

                b001.Text = "01";
                b002.Text = "02";
                b003.Text = "03";
                b004.Text = "30";
            }else if (selectedIndex==5)
            {
                b001.Location = new Point(19, 39);
                b002.Location = new Point(101, 39);
                b003.Location = new Point(184, 39);
                b31.Location = new Point(267, 39);
                b1.Location = new Point(350, 39);
                b2.Location = new Point(433, 39);
                b3.Location = new Point(516, 39);
                b4.Location = new Point(19, 104);
                b5.Location = new Point(101, 104);
                b6.Location = new Point(184, 104);
                b7.Location = new Point(267, 104);
                b8.Location = new Point(350, 104);
                b9.Location = new Point(433, 104);
                b10.Location = new Point(516, 104);
                b11.Location = new Point(19, 168);
                b12.Location = new Point(101, 168);
                b13.Location = new Point(184, 168);
                b14.Location = new Point(267, 168);
                b15.Location = new Point(350, 168);
                b16.Location = new Point(433, 168);
                b17.Location = new Point(516, 168);
                b18.Location = new Point(19, 231);
                b19.Location = new Point(101, 231);
                b20.Location = new Point(184, 231);
                b21.Location = new Point(267, 231);
                b22.Location = new Point(350, 231);
                b23.Location = new Point(433, 231);
                b24.Location = new Point(516, 231);
                b25.Location = new Point(19, 294);
                b26.Location = new Point(101, 294);
                b27.Location = new Point(184, 294);
                b28.Location = new Point(267, 294);
                b29.Location = new Point(350, 294);
                b30.Location = new Point(433, 294);
                b004.Location = new Point(516, 294);

                b1.Enabled = true;
                b2.Enabled = true;
                b3.Enabled = true;
                b4.Enabled = true;
                b5.Enabled = true;
                b6.Enabled = true;
                b7.Enabled = true;
                b8.Enabled = true;
                b9.Enabled = true;
                b11.Enabled = true;
                b12.Enabled = true;
                b13.Enabled = true;
                b14.Enabled = true;
                b15.Enabled = true;
                b16.Enabled = true;
                b17.Enabled = true;
                b18.Enabled = true;
                b19.Enabled = true;
                b20.Enabled = true;
                b21.Enabled = true;
                b22.Enabled = true;
                b23.Enabled = true;
                b24.Enabled = true;
                b25.Enabled = true;
                b26.Enabled = true;
                b27.Enabled = true;
                b28.Enabled = true;
                b29.Enabled = true;
                b30.Enabled = true;
                b31.Enabled = false;
                b001.Enabled = false;
                b002.Enabled = false;
                b003.Enabled = false;
                b004.Enabled = false;

                b001.Text = "28";
                b002.Text = "29";
                b003.Text = "30";
                b004.Text = "01";
                
            }else if (selectedIndex == 7)
            {

                b003.Location = new Point(19, 39);
                b004.Location = new Point(101, 39);
                b1.Location = new Point(184, 39);
                b2.Location = new Point(267, 39);
                b3.Location = new Point(350, 39);
                b4.Location = new Point(433, 39);
                b5.Location = new Point(516, 39);
                b6.Location = new Point(19, 104);
                b7.Location = new Point(101, 104);
                b8.Location = new Point(184, 104);
                b9.Location = new Point(267, 104);
                b10.Location = new Point(350, 104);
                b11.Location = new Point(433, 104);
                b12.Location = new Point(516, 104);
                b13.Location = new Point(19, 168);
                b14.Location = new Point(101, 168);
                b15.Location = new Point(184, 168);
                b16.Location = new Point(267, 168);
                b17.Location = new Point(350, 168);
                b18.Location = new Point(433, 168);
                b19.Location = new Point(516, 168);
                b20.Location = new Point(19, 231);
                b21.Location = new Point(101, 231);
                b22.Location = new Point(184, 231);
                b23.Location = new Point(267, 231);
                b24.Location = new Point(350, 231);
                b25.Location = new Point(433, 231);
                b26.Location = new Point(516, 231);
                b27.Location = new Point(19, 294);
                b28.Location = new Point(101, 294);
                b29.Location = new Point(184, 294);
                b30.Location = new Point(267, 294);
                b31.Location = new Point(350, 294);
                b001.Location = new Point(433, 294);
                b002.Location = new Point(516, 294);

                b1.Enabled = true;
                b2.Enabled = true;
                b3.Enabled = true;
                b4.Enabled = true;
                b5.Enabled = true;
                b6.Enabled = true;
                b7.Enabled = true;
                b8.Enabled = true;
                b9.Enabled = true;
                b11.Enabled = true;
                b12.Enabled = true;
                b13.Enabled = true;
                b14.Enabled = true;
                b15.Enabled = true;
                b16.Enabled = true;
                b17.Enabled = true;
                b18.Enabled = true;
                b19.Enabled = true;
                b20.Enabled = true;
                b21.Enabled = true;
                b22.Enabled = true;
                b23.Enabled = true;
                b24.Enabled = true;
                b25.Enabled = true;
                b26.Enabled = true;
                b27.Enabled = true;
                b28.Enabled = true;
                b29.Enabled = true;
                b30.Enabled = true;
                b31.Enabled = true;
                b001.Enabled = false;
                b002.Enabled = false;
                b003.Enabled = false;
                b004.Enabled = false;

                b001.Text = "01";
                b002.Text = "02";
                b003.Text = "30";
                b004.Text = "31";
            }else if (selectedIndex == 8)
            {

                b001.Location = new Point(19, 39);
                b002.Location = new Point(101, 39);
                b003.Location = new Point(184, 39);
                b004.Location = new Point(267, 39);
                b31.Location = new Point(350, 39);
                b1.Location = new Point(433, 39);
                b2.Location = new Point(516, 39);
                b3.Location = new Point(19, 104);
                b4.Location = new Point(101, 104);
                b5.Location = new Point(184, 104);
                b6.Location = new Point(267, 104);
                b7.Location = new Point(350, 104);
                b8.Location = new Point(433, 104);
                b9.Location = new Point(516, 104);
                b10.Location = new Point(19, 168);
                b11.Location = new Point(101, 168);
                b12.Location = new Point(184, 168);
                b13.Location = new Point(267, 168);
                b14.Location = new Point(350, 168);
                b15.Location = new Point(433, 168);
                b16.Location = new Point(516, 168);
                b17.Location = new Point(19, 231);
                b18.Location = new Point(101, 231);
                b19.Location = new Point(184, 231);
                b20.Location = new Point(267, 231);
                b21.Location = new Point(350, 231);
                b22.Location = new Point(433, 231);
                b23.Location = new Point(516, 231);
                b24.Location = new Point(19, 294);
                b25.Location = new Point(101, 294);
                b26.Location = new Point(184, 294);
                b27.Location = new Point(267, 294);
                b28.Location = new Point(350, 294);
                b29.Location = new Point(433, 294);
                b30.Location = new Point(516, 294);

                b1.Enabled = true;
                b2.Enabled = true;
                b3.Enabled = true;
                b4.Enabled = true;
                b5.Enabled = true;
                b6.Enabled = true;
                b7.Enabled = true;
                b8.Enabled = true;
                b9.Enabled = true;
                b11.Enabled = true;
                b12.Enabled = true;
                b13.Enabled = true;
                b14.Enabled = true;
                b15.Enabled = true;
                b16.Enabled = true;
                b17.Enabled = true;
                b18.Enabled = true;
                b19.Enabled = true;
                b20.Enabled = true;
                b21.Enabled = true;
                b22.Enabled = true;
                b23.Enabled = true;
                b24.Enabled = true;
                b25.Enabled = true;
                b26.Enabled = true;
                b27.Enabled = true;
                b28.Enabled = true;
                b29.Enabled = true;
                b30.Enabled = true;
                b31.Enabled = false;
                b001.Enabled = false;
                b002.Enabled = false;
                b003.Enabled = false;
                b004.Enabled = false;

                b001.Text = "27";
                b002.Text = "28";
                b003.Text = "29";
                b004.Text = "30";
            }else if (selectedIndex == 9)
            {

                b1.Location = new Point(19, 39);
                b2.Location = new Point(101, 39);
                b3.Location = new Point(184, 39);
                b4.Location = new Point(267, 39);
                b5.Location = new Point(350, 39);
                b6.Location = new Point(433, 39);
                b7.Location = new Point(516, 39);
                b8.Location = new Point(19, 104);
                b9.Location = new Point(101, 104);
                b10.Location = new Point(184, 104);
                b11.Location = new Point(267, 104);
                b12.Location = new Point(350, 104);
                b13.Location = new Point(433, 104);
                b14.Location = new Point(516, 104);
                b15.Location = new Point(19, 168);
                b16.Location = new Point(101, 168);
                b17.Location = new Point(184, 168);
                b18.Location = new Point(267, 168);
                b19.Location = new Point(350, 168);
                b20.Location = new Point(433, 168);
                b21.Location = new Point(516, 168);
                b22.Location = new Point(19, 231);
                b23.Location = new Point(101, 231);
                b24.Location = new Point(184, 231);
                b25.Location = new Point(267, 231);
                b26.Location = new Point(350, 231);
                b27.Location = new Point(433, 231);
                b28.Location = new Point(516, 231);
                b29.Location = new Point(19, 294);
                b30.Location = new Point(101, 294);
                b31.Location = new Point(184, 294);
                b001.Location = new Point(267, 294);
                b002.Location = new Point(350, 294);
                b003.Location = new Point(433, 294);
                b004.Location = new Point(516, 294);

                b1.Enabled = true;
                b2.Enabled = true;
                b3.Enabled = true;
                b4.Enabled = true;
                b5.Enabled = true;
                b6.Enabled = true;
                b7.Enabled = true;
                b8.Enabled = true;
                b9.Enabled = true;
                b11.Enabled = true;
                b12.Enabled = true;
                b13.Enabled = true;
                b14.Enabled = true;
                b15.Enabled = true;
                b16.Enabled = true;
                b17.Enabled = true;
                b18.Enabled = true;
                b19.Enabled = true;
                b20.Enabled = true;
                b21.Enabled = true;
                b22.Enabled = true;
                b23.Enabled = true;
                b24.Enabled = true;
                b25.Enabled = true;
                b26.Enabled = true;
                b27.Enabled = true;
                b28.Enabled = true;
                b29.Enabled = true;
                b30.Enabled = true;
                b31.Enabled = true;
                b001.Enabled = false;
                b002.Enabled = false;
                b003.Enabled = false;
                b004.Enabled = false;

                b001.Text = "01";
                b002.Text = "02";
                b003.Text = "03";
                b004.Text = "04";
            }else if (selectedIndex == 10)
            {

                b003.Location = new Point(19, 39);
                b004.Location = new Point(101, 39);
                b31.Location = new Point(184, 39);
                b1.Location = new Point(267, 39);
                b2.Location = new Point(350, 39);
                b3.Location = new Point(433, 39);
                b4.Location = new Point(516, 39);
                b5.Location = new Point(19, 104);
                b6.Location = new Point(101, 104);
                b7.Location = new Point(184, 104);
                b8.Location = new Point(267, 104);
                b9.Location = new Point(350, 104);
                b10.Location = new Point(433, 104);
                b11.Location = new Point(516, 104);
                b12.Location = new Point(19, 168);
                b13.Location = new Point(101, 168);
                b14.Location = new Point(184, 168);
                b15.Location = new Point(267, 168);
                b16.Location = new Point(350, 168);
                b17.Location = new Point(433, 168);
                b18.Location = new Point(516, 168);
                b19.Location = new Point(19, 231);
                b20.Location = new Point(101, 231);
                b21.Location = new Point(184, 231);
                b22.Location = new Point(267, 231);
                b23.Location = new Point(350, 231);
                b24.Location = new Point(433, 231);
                b25.Location = new Point(516, 231);
                b26.Location = new Point(19, 294);
                b27.Location = new Point(101, 294);
                b28.Location = new Point(184, 294);
                b29.Location = new Point(267, 294);
                b30.Location = new Point(350, 294);
                b001.Location = new Point(433, 294);
                b002.Location = new Point(516, 294);

                b1.Enabled = true;
                b2.Enabled = true;
                b3.Enabled = true;
                b4.Enabled = true;
                b5.Enabled = true;
                b6.Enabled = true;
                b7.Enabled = true;
                b8.Enabled = true;
                b9.Enabled = true;
                b11.Enabled = true;
                b12.Enabled = true;
                b13.Enabled = true;
                b14.Enabled = true;
                b15.Enabled = true;
                b16.Enabled = true;
                b17.Enabled = true;
                b18.Enabled = true;
                b19.Enabled = true;
                b20.Enabled = true;
                b21.Enabled = true;
                b22.Enabled = true;
                b23.Enabled = true;
                b24.Enabled = true;
                b25.Enabled = true;
                b26.Enabled = true;
                b27.Enabled = true;
                b28.Enabled = true;
                b29.Enabled = true;
                b30.Enabled = true;
                b31.Enabled = false;
                b001.Enabled = false;
                b002.Enabled = false;
                b003.Enabled = false;
                b004.Enabled = false;

                b001.Text = "01";
                b002.Text = "02";
                b003.Text = "29";
                b004.Text = "30";
            }





        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void b2_Click(object sender, EventArgs e)
        {
            panel01.Visible = true;
            click = click + 1;
            hmera = 2;
           
        }

        private void b3_Click(object sender, EventArgs e)
        {
            panel01.Visible = true;
            click = click + 1;
            hmera = 3;
           
        }

        private void b4_Click(object sender, EventArgs e)
        {
            panel01.Visible = true;
            click = click + 1;
            hmera = 4;
           
        }

        private void b5_Click(object sender, EventArgs e)
        {
            panel01.Visible = true;
            click = click + 1;
            hmera = 5;
           
        }

        private void b6_Click(object sender, EventArgs e)
        {
            panel01.Visible = true;
            click = click + 1;
            hmera = 6;
           
        }

        private void b7_Click(object sender, EventArgs e)
        {
            panel01.Visible = true;
            hmera = 7;
            click = click + 1;
           

        }

        private void b8_Click(object sender, EventArgs e)
        {
            panel01.Visible = true;
            hmera = 8;
            click = click + 1;
           
        }

        private void b9_Click(object sender, EventArgs e)
        {
            panel01.Visible = true;
            hmera = 9;
            click = click + 1;
            hmera = 9;
          
        }

        private void b10_Click(object sender, EventArgs e)
        {
            panel01.Visible = true;
            click = click + 1;
            hmera = 10;
           
        }

        private void b11_Click(object sender, EventArgs e)
        {
            panel01.Visible = true;
            click = click + 1;
            hmera = 11;
           
        }

        private void b12_Click(object sender, EventArgs e)
        {
            panel01.Visible = true;
            click = click + 1;
            hmera = 12;
           
        }

        private void b14_Click(object sender, EventArgs e)
        {
            panel01.Visible = true;
            click = click + 1;
            hmera = 14;
           
        }

        private void b15_Click(object sender, EventArgs e)
        {
            panel01.Visible = true;
            click = click + 1;
            hmera = 15;
           
        }

        private void b16_Click(object sender, EventArgs e)
        {
            panel01.Visible = true;
            click = click + 1;
            hmera = 16;
           
        }

        private void b17_Click(object sender, EventArgs e)
        {
            panel01.Visible = true;
            click = click + 1;
            hmera = 17;
          
        }

        private void b18_Click(object sender, EventArgs e)
        {
            panel01.Visible = true;
            hmera = 18;
            click = click + 1;
          
           
        }

        private void b19_Click(object sender, EventArgs e)
        {
            panel01.Visible = true;
            hmera = 19;
            click = click + 1;
           
        }

        private void b20_Click(object sender, EventArgs e)
        {
            panel01.Visible = true;
            hmera = 20;
            click = click + 1;
           
          
        }

        private void b21_Click(object sender, EventArgs e)
        {
            panel01.Visible = true;
            click = click + 1;
            hmera = 21;
         
        }

        private void b22_Click(object sender, EventArgs e)
        {
            panel01.Visible = true;
            click = click + 1;
            hmera = 22;
          
        }

        private void b23_Click(object sender, EventArgs e)
        {
            panel01.Visible = true;
            click = click + 1;
            hmera = 23;
           
        }

        private void b24_Click(object sender, EventArgs e)
        {
            panel01.Visible = true;
            click = click + 1;
            hmera = 24;
           
        }

        private void b25_Click(object sender, EventArgs e)
        {
            panel01.Visible = true;
            hmera = 25;
            click = click + 1;
       
          
        }

        private void b26_Click(object sender, EventArgs e)
        {
            panel01.Visible = true;
            click = click + 1;
            hmera = 26;
           
        }

        private void b27_Click(object sender, EventArgs e)
        {
            panel01.Visible = true;
            hmera = 27;
            click = click + 1;
          
        }

        private void b28_Click(object sender, EventArgs e)
        {
            panel01.Visible = true;
            hmera = 28;
            click = click + 1;
        
        }

        private void b29_Click(object sender, EventArgs e)
        {
            panel01.Visible = true;
            hmera = 29;
            click = click + 1;
       
          
        }

        private void b30_Click(object sender, EventArgs e)
        {
            panel01.Visible = true;
            hmera = 30;
            click = click + 1;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Η λίστα με όλες τις ενέργιες που έχετε να κάνετε ανα ημερομηνία");      

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Συμπλήρωστε την σημείωση σας και πατήστε την Πρόσθηκη!"+ "Θα παρατηρήσετε οτι η σημέιωση θα μπεί στη λίστα και η ημερομηνία θα σημαδευτεί με μπλέ ένδηξη!");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Επιλέξτε μια σημέιωση που θέλετε να αφαιρέσετε απο τη λίστα και μέτα πατήστε την επιλογή Διαγραφή!");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Επιλέξτε την ημερομηνία που θέλετε για να εμφάνιστει η λίστα σημειώσεων! " +"\n"+ "ΥΓ: Παρακαλούμε να το δοκιμάσετε στον μήνα Φεβρουάριο!");
        }

        private void b31_Click(object sender, EventArgs e)
        {
            panel01.Visible = true;
            click = click + 1;
            hmera = 31;
           
        }
    }
}
