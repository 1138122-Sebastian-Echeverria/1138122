using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio.Forms_SebastianEcheverria_1138122
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtN.Text == "")
            {
                Nombre.Text = "El campo esta vacio.";
            }
            else
            {
                Nombre.Text = txtN.Text;
            }
        }
    }
}
