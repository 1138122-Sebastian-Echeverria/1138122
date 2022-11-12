using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace P1_DISCRETAII
{
    public partial class grafo1 : Form
    {
        public grafo1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        //Completado
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button1.BackColor = Color.Green;

            }
            if (radioButton2.Checked == true)
            {
                button1.BackColor = Color.Red;

            }         
            if (radioButton3.Checked == true)
            {
                button1.BackColor = Color.Blue;

            }
            if (radioButton4.Checked == true)
            {
                button1.BackColor = Color.Yellow;
            }

            if (button1.BackColor == button2.BackColor)
            {
                MessageBox.Show("Perdiste...");
                Application.Restart();
            }
            if (button1.BackColor == button4.BackColor)
            {
                MessageBox.Show("Perdiste...");
                Application.Restart();
            }
            if (button1.BackColor == button6.BackColor)
            {
                MessageBox.Show("Perdiste...");
                Application.Restart();
            }
        }

        //Completado
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button2.BackColor = Color.Green;
               
            }
            else if (radioButton2.Checked == true)
            {
                button2.BackColor = Color.Red;
            }
            else if (radioButton3.Checked == true)
            {
                button2.BackColor = Color.Blue;
            }
            else if (radioButton4.Checked == true)
            {
                button2.BackColor = Color.Yellow;
            }


            if (button1.BackColor == button2.BackColor)
            {
                MessageBox.Show("Perdiste...");
                Application.Restart();
            }

            if (button2.BackColor == button3.BackColor)
            {
                MessageBox.Show("Perdiste...");
                Application.Restart();
            }

            if (button2.BackColor == button7.BackColor)
            {
                MessageBox.Show("Perdiste...");
                Application.Restart();
            }
        }

        //Completado
        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button3.BackColor = Color.Green;

            }
            else if (radioButton2.Checked == true)
            {
                button3.BackColor = Color.Red;
            }
            else if (radioButton3.Checked == true)
            {
                button3.BackColor = Color.Blue;
            }
            else if (radioButton4.Checked == true)
            {
                button3.BackColor = Color.Yellow;
            }

            if (button2.BackColor == button3.BackColor)
            {
                MessageBox.Show("Perdiste...");
                Application.Restart();
            }
            if (button3.BackColor == button4.BackColor)
            {
                MessageBox.Show("Perdiste...");
                Application.Restart();
            }
            if (button3.BackColor == button8.BackColor)
            {
                MessageBox.Show("Perdiste...");
                Application.Restart();
            }

        }

        //Completado
        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button4.BackColor = Color.Green;

            }
            else if (radioButton2.Checked == true)
            {
                button4.BackColor = Color.Red;
            }
            else if (radioButton3.Checked == true)
            {
                button4.BackColor = Color.Blue;
            }
            else if (radioButton4.Checked == true)
            {
                button4.BackColor = Color.Yellow;
            }


            if (button1.BackColor == button4.BackColor)
            {
                MessageBox.Show("Perdiste...");
                Application.Restart();
            }
            
            if (button3.BackColor == button4.BackColor)
            {
                MessageBox.Show("Perdiste...");
                Application.Restart();
            }

            if (button4.BackColor == button5.BackColor)
            {
                MessageBox.Show("Perdiste...");
                Application.Restart();
            }
        }

        //Completado
        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button5.BackColor = Color.Green;

            }
            else if (radioButton2.Checked == true)
            {
                button5.BackColor = Color.Red;
            }
            else if (radioButton3.Checked == true)
            {
                button5.BackColor = Color.Blue;
            }
            else if (radioButton4.Checked == true)
            {
                button5.BackColor = Color.Yellow;
            }


            if (button4.BackColor == button5.BackColor)
            {
                MessageBox.Show("Perdiste...");
                Application.Restart();
            }
            if (button5.BackColor == button6.BackColor)
            {
                MessageBox.Show("Perdiste...");
                Application.Restart();
            }
            if (button5.BackColor == button8.BackColor)
            {
                MessageBox.Show("Perdiste...");
                Application.Restart();
            }
        }

        //Completado
        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button6.BackColor = Color.Green;

            }
            else if (radioButton2.Checked == true)
            {
                button6.BackColor = Color.Red;
            }
            else if (radioButton3.Checked == true)
            {
                button6.BackColor = Color.Blue;
            }
            else if (radioButton4.Checked == true)
            {
                button6.BackColor = Color.Yellow;
            }


            if (button1.BackColor == button6.BackColor)
            {
                MessageBox.Show("Perdiste...");
                Application.Restart();
            }
            if (button5.BackColor == button6.BackColor)
            {
                MessageBox.Show("Perdiste...");
                Application.Restart();
            }
            if (button6.BackColor == button7.BackColor)
            {
                MessageBox.Show("Perdiste...");
                Application.Restart();
            }
        }


        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button7.BackColor = Color.Green;

            }
            else if (radioButton2.Checked == true)
            {
                button7.BackColor = Color.Red;
            }
            else if (radioButton3.Checked == true)
            {
                button7.BackColor = Color.Blue;
            }
            else if (radioButton4.Checked == true)
            {
                button7.BackColor = Color.Yellow;
            }


            if (button2.BackColor == button7.BackColor)
            {
                MessageBox.Show("Perdiste...");
                Application.Restart();
            }
            if (button6.BackColor == button7.BackColor)
            {
                MessageBox.Show("Perdiste...");
                Application.Restart();
            }
            if (button7.BackColor == button8.BackColor)
            {
                MessageBox.Show("Perdiste...");
                Application.Restart();
            }
        }


        private void button8_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button8.BackColor = Color.Green;

            }
            else if (radioButton2.Checked == true)
            {
                button8.BackColor = Color.Red;
            }
            else if (radioButton3.Checked == true)
            {
                button8.BackColor = Color.Blue;
            }
            else if (radioButton4.Checked == true)
            {
                button8.BackColor = Color.Yellow;
            }


            if (button3.BackColor == button8.BackColor)
            {
                MessageBox.Show("Perdiste...");
                Application.Restart();
            }
            if (button5.BackColor == button8.BackColor)
            {
                MessageBox.Show("Perdiste...");
                Application.Restart();
            }
            if (button7.BackColor == button8.BackColor)
            {
                MessageBox.Show("Perdiste...");
                Application.Restart();
            }
        }


        public void grafo1_Load(object sender, EventArgs e)
        {
            //inicializacion del grafo1
            
        }


        private void button9_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 18)
            {
                MessageBox.Show("USTED ES MENOR DE EDAD");
            }
            else
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                pictureBox1.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true; 
                button7.Enabled = true;
                button8.Enabled = true;
                button11.Enabled = true;
            }
        }


        private void button10_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Hide();
        }


        private void button11_Click(object sender, EventArgs e)
        {
            //siguiente//llamar metodos



        }


        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
