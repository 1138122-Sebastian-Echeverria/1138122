using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._2_SebastianEcheverria1138122
{
    internal class Circulo
    {
        //Atributo
        private double radio;

        //metodo construcotr
        //Opcional
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public double ObtenerPerimetro()
        {
            return 2 * Math.PI * radio;
        }

        public double ObtenerArea()
        {
            return Math.PI * Math.Pow(radio,2);
        }

        public double ObtenerVolumen()
        {
            return 4 / 3 * Math.PI * Math.Pow(radio, 2);
        }

        public void CalcularGeometria(double _perimetro, double _area, double _volumen)
        {
            Console.WriteLine("Perimetro: " + _perimetro);
            Console.WriteLine("Area: " + _area);
            Console.WriteLine("Volumen: " + _volumen);
        }
    }
}
