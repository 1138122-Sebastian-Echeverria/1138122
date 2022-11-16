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

        private void EquipoJ1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EquipoJ1.Items.Contains("Team Queso"))
            {
                EquipoJ2.Items.Remove("Team Queso");
            }
            else if (EquipoJ1.Items.Contains("Golden Wind"))
            {
                EquipoJ2.Items.Remove("Golden Wind");
            }
        }

        private void EquipoJ2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EquipoJ2.Items.Contains("Team Queso"))
            {
                EquipoJ1.Items.Remove("Team Queso");
            }
            else if (EquipoJ2.Items.Contains("Golden Wind"))
            {
                EquipoJ1.Items.Remove("Golden Wind");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre;
            string apellido;
            string Nickname1;
            string Nickname2;
            int numero;

            if (EquipoJ1.SelectedItem == null || NombreJ1.Text == null || ApellidoJ1.Text == null || EquipoJ2.SelectedItem == null || NombreJ2.Text == null || ApellidoJ2.Text == null)
            {
                MessageBox.Show("Porfavor asegurese de llenar todos los espacios", "Pequeño error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (EquipoJ1.Items.Contains("Team Queso"))
                {
                    nombre = NombreJ1.Text;
                    apellido = ApellidoJ1.Text;
                    Nickname1 = "TQ" + nombre + apellido;
                    numero = Nickname1.Length;
                    Nickname1 = Nickname1 + numero;

                    nombre = NombreJ2.Text;
                    apellido = ApellidoJ2.Text;
                    Nickname2 = "GW" + nombre + apellido;
                    numero = Nickname2.Length;
                    Nickname2 = Nickname1 + numero;

                    Nombre_de_jugadores Juego = new Nombre_de_jugadores(Nickname1, Nickname2);
                }
                else if (EquipoJ1.Items.Contains("Golden Wind"))
                {
                    nombre = NombreJ1.Text;
                    apellido = ApellidoJ1.Text;
                    Nickname1 = "GW" + nombre + apellido;
                    numero = Nickname1.Length;
                    Nickname1 = Nickname1 + numero;

                    nombre = NombreJ2.Text;
                    apellido = ApellidoJ2.Text;
                    Nickname2 = "TQ" + nombre + apellido;
                    numero = Nickname2.Length;
                    Nickname2 = Nickname1 + numero;
                    Nombre_de_jugadores Juego = new Nombre_de_jugadores(Nickname1, Nickname2);
                }
            }
        }
    }
}
