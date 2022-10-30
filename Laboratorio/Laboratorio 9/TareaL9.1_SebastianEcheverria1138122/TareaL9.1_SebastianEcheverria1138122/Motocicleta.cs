using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaL9._1_SebastianEcheverria1138122
{
    internal class Motocicleta
    {
        private int Modelo = 2019;
        private double Precio = 1000;
        private string Marca = "";
        private double Iva = 0.12;

        public string MostrasDatos()
        {
            string datos = "Modelo: " + Modelo + "\n" +
                "Precio: " + Precio + "\n" +
                "Marca: " + Marca + "\n" +
                "Iva: " + Iva;
            return datos;

        }

        public void DefinirPrecio(double precio)
        {
            this.Precio = precio;
        }

        public void DefinirIva(double iva)
        {
            if (iva > 0 && iva < 1)
            {
                this.Iva = iva;
            }
        }

        public double PrecioSinIva()
        {
            return Precio;
        }

        public double PrecioConIva()
        {

            return Precio + (Iva * Precio);
        }

        public double DevolverIva()
        {
            return Precio * Iva;
        }

        public void MostrarDatos()
        {

        }
    }
}
