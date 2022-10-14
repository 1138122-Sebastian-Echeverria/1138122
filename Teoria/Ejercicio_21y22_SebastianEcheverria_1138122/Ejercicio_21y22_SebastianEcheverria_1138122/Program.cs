using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_21y22_SebastianEcheverria_1138122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Primera ecuacion: ");
            Console.WriteLine("(3 * (x^3)) - (x^(1/3)) + (4*(x^2))");
            double y1 = (3 * (Math.Pow(x, 3))) - (Math.Pow(x, (1/3))) + (4 * (Math.Pow(x,2)));
            Console.WriteLine("Respuesta: ");
            Console.WriteLine(y1);

            Console.WriteLine("");

            Console.WriteLine("Segunda ecuacion: ");
            Console.WriteLine("4x^3 - 3x^2 + 2x - 5");
            double y2 = ;
            Console.WriteLine("Respuesta: ");
            Console.WriteLine(y2);

            Console.WriteLine("");

            Console.WriteLine("Tercera ecuacion: ");
            Console.WriteLine("(5^3)*(x^(1/2)) + 4x^2 + 6");
            double y3 = ;
            Console.WriteLine("Respuesta: ");
            Console.WriteLine(y3);
        }
    }
}
