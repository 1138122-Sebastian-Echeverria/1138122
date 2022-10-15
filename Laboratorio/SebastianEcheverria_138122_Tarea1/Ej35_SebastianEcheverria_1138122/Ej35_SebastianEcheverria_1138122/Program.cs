using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej35_SebastianEcheverria_1138122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*/ Realice un programa que permita ingresar dos números y 
             * luego un operador matemático, de acuerdo a este operador 
             * se realizará la operación indicada, los operadores deben 
             * ser +, -, *, /, Mod /*/

            //Console.WriteLine("");
            Console.WriteLine("Ingrese el primer numero: ");
            double N1 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Ingrese el segundo numero: ");
            double N2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double Res = N1 + N2;
            Console.WriteLine(N1 + " + " + N2 + " = " + Res);

            Console.WriteLine("");

            Res = N1 - N2;
            Console.WriteLine(N1 + " - " + N2 + " = " + Res);

            Console.WriteLine("");

            Res = N1 * N2;
            Console.WriteLine(N1 + " * " + N2 + " = " + Res);

            Console.WriteLine("");

            Res = N1 / N2;
            Console.WriteLine(N1 + " / " + N2 + " = " + Res);

            Console.WriteLine("");

            Res = N1 % N2;
            Console.WriteLine(N1 + " MOD " + N2 + " = " + Res);

            Console.ReadLine();
        }
    }
}
