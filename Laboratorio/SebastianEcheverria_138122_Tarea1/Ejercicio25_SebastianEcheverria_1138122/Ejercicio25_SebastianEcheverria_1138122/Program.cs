using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio25_SebastianEcheverria_1138122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*/Ejercicio 25, Realice una aplicación que calcule el salario neto a 
             * pagar a un empleado de una Empresa. Dicha empresa realiza los 
             * siguientes descuentos. 
             * ISSS   (9%) 
             * AFP     (7%)
             * Renta (10%)/*/

            Console.WriteLine("Ingrese el salario del empleado: ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Descuentos a realizar: ");
            double I = x * 0.09;
            Console.WriteLine("ISSS (9%): " + I);
            double A = x * 0.07;
            Console.WriteLine("AFP (7%): " + A);
            double R = x * 0.1;
            Console.WriteLine("Renta (10%): " + R);

            Console.WriteLine("");
            double SN = x - (I+A+R);
            Console.WriteLine("El salario neto de la persona es: " + SN);
            
            Console.ReadKey();
        }
    }
}
