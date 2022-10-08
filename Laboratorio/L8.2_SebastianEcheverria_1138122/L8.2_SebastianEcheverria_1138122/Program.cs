using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8._2_SebastianEcheverria_1138122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            int n = int.Parse(Console.ReadLine());

            while (n > 18)
            {
                Console.WriteLine("Estas a salvo.");
                Console.WriteLine("Ingresa otro numero: ");

                n = int.Parse(Console.ReadLine());

                Console.WriteLine("Veamos...");
            }
            Console.WriteLine("Ya no estas a salvo.");
            Console.ReadKey();

            do
            {
                Console.WriteLine("Esto es el do while.");
            }
            while (n < 10);
        }
    }
}
