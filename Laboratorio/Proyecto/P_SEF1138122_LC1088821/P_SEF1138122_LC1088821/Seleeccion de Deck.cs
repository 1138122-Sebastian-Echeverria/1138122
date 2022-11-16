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

namespace P_SEF1138122_LC1088821
{
    public partial class Seleeccion_de_Deck : Form
    {
        string nombre1;
        string nombre2;
        public Seleeccion_de_Deck(string nombre1, string nombre2)
        {
            InitializeComponent();
            this.nombre1 = nombre1;
            this.nombre2 = nombre2;

            groupBox1.Text = nombre1;
            groupBox2.Text = nombre2;
        }


        private void Regreso_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
