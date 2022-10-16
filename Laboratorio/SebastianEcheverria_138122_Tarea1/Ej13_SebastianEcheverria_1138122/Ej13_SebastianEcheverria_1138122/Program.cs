using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej13_SebastianEcheverria_1138122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sumar los 100 primeros números naturales
            int numeros = 0;
            
            for (int i = 0; i <= 100; i++)
            {
                numeros = numeros + i;

                Console.WriteLine(numeros);
                Console.WriteLine("");
            }
            
            Console.ReadKey();
        }
    }
}
