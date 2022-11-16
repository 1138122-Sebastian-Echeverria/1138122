using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P_SEF1138122_LC1088821
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string nombre;
            string apellido;
            string Nickname1;
            string equipo1 = "";
            string Nickname2;
            string equipo2 = "";
            int numero;

            if (EquipoJ1.Text == null || NombreJ1.Text == null || ApellidoJ1.Text == null || EquipoJ2.Text == null || NombreJ2.Text == null || ApellidoJ2.Text == null)
            {
                MessageBox.Show("Porfavor asegurese de llenar todos los espacios", "Pequeño error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                nombre = NombreJ1.Text;
                apellido = ApellidoJ1.Text;
                string[] Subs = EquipoJ1.Text.Split(' ');
                for (int i = 0; i < Subs.Length; i++)
                {
                    equipo1 = equipo1 + Subs[i][0];
                }
                Nickname1 = equipo1 + nombre + apellido;
                numero = Nickname1.Length;
                Nickname1 = Nickname1 + numero;

                nombre = NombreJ2.Text;
                apellido = ApellidoJ2.Text;
                Subs = EquipoJ2.Text.Split(' ');
                for (int i = 0; i < Subs.Length; i++)
                {
                    equipo2 = equipo2 + Subs[i][0];
                }
                Nickname2 = equipo2 + nombre + apellido;
                numero = Nickname2.Length;
                Nickname2 = Nickname2 + numero;

                Seleeccion_de_Deck form2 = new Seleeccion_de_Deck(Nickname1, Nickname2);
                form2.Show();
                Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
