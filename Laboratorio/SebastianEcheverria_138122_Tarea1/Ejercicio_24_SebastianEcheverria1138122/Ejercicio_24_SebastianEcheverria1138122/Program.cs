using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_24_SebastianEcheverria1138122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 24
            Console.WriteLine("Ingrese cantidad de presupuesto anual");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Recursos humanos recibe el 50% el cual es: ");
            double Res = x * 0.5;
            Console.WriteLine(Res);

            Console.WriteLine("");

            Console.WriteLine("Manufactura recibe el 25% el cual es: ");
            Res = x * 0.25;
            Console.WriteLine(Res);

            Console.WriteLine("");

            Console.WriteLine("Empaquetado recibe el 15% el cual es: ");
            Res = x * 0.15;
            Console.WriteLine(Res);

            Console.WriteLine("Publicidad recibe el 10% el cual es: ");
            Res = x * 0.1;
            Console.WriteLine(Res);
        }
    }
}
