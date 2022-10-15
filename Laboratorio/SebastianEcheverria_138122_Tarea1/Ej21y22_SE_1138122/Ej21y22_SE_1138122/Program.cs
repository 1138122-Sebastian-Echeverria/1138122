using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej21y22_SE_1138122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double y1 = 0.001;
            double y2 = 0.001;
            double y3 = 0.001;

            Console.WriteLine("Ingrese el numero X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Primera ecuacion: ");
            Console.WriteLine("(3 * (x^3)) - (x^(1/3)) + (4*(x^2))");
            y1 = y1 + (3 * (Math.Pow(x, 3))) - (Math.Pow(x, (1 / 3))) + (4 * (Math.Pow(x, 2)));
            Console.WriteLine("Respuesta: ");
            Console.WriteLine(y1);

            Console.WriteLine("");

            Console.WriteLine("Segunda ecuacion: ");
            Console.WriteLine("4x^3 - 3x^2 + 2x - 5");
            y2 = y2 + (4 * (Math.Pow(x, 3)) - (3 * (Math.Pow(x, 2))) + (2 * x) - 5);
            Console.WriteLine("Respuesta: ");
            Console.WriteLine(y2);

            Console.WriteLine("");

            Console.WriteLine("Tercera ecuacion: ");
            Console.WriteLine("(5^3)*(x^(1/2)) + 4x^2 + 6");
            y3 = y3 + (Math.Pow(5, 3) * (Math.Pow(x, (1 / 2))) + 4 * (Math.Pow(x, 2)) + 6);
            Console.WriteLine("Respuesta: ");
            Console.WriteLine(y3);

            Console.ReadKey();
        }
    }
}
