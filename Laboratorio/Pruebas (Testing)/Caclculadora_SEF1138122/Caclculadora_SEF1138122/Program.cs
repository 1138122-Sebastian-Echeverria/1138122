using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caclculadora_SEF1138122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese el numero a:");
                double a = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el numero b:");
                double b = double.Parse(Console.ReadLine());

                Calculadora cal = new Calculadora();

                Console.WriteLine("La division de a y b es:");
                Console.WriteLine(cal.Dividir(a, b));
            }
            catch (Exception)
            {
                Console.WriteLine("Ni modo no le sabe a la mate.");
            }


        }
    }
}
