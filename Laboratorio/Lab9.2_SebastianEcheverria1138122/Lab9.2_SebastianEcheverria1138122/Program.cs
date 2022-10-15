using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._2_SebastianEcheverria1138122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo objCirculo = new Circulo(100);

            double area = objCirculo.ObtenerArea();
            double perimetro = objCirculo.ObtenerPerimetro();
            double volumen = objCirculo.ObtenerVolumen();

            objCirculo.CalcularGeometria(perimetro, area, volumen);

            Console.ReadKey();
        }
    }
}
