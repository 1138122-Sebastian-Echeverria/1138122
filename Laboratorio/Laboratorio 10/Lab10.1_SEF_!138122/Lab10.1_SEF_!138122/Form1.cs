using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10._1_SEF__138122
{
    public partial class Form1 : Form
    {
        carro Carro = new carro();

        public Form1()
        {
            InitializeComponent();
        }

        private void inputDatos_Click(object sender, EventArgs e)
        {
            

            string marca = inputMarca.Text;
            int modelo = (int)inputModelo.Value;
            double precio = (double)inputPrecio.Value;
            string descripcion = inputDescripcion.Text;

            Carro.SetMarca(marca);
            Carro.SetPrecio(precio);
            Carro.SetDescripcion(descripcion);
            Carro.SetModelo(modelo);


        }

        private void botonActualizar_Click(object sender, EventArgs e)
        {
            outputMarca.Text = Carro.LeerMarca();
            OutputModelo.Text = Carro.LeerModelo().ToString();
            outputPrecio.Text = Carro.LeerPrecio().ToString();
            outputDescripcion.Text = Carro.LeerDescr();
        }

        private void botonIVA_Click(object sender, EventArgs e)
        {
            double IVA = (double)inputIVA.Value;

            Carro.SetIVA(IVA);
            outputPF.Text = Carro.LeerPF().ToString();
        }
    }
}
