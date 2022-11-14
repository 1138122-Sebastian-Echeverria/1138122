using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int[] Cartas = new int[8];

            for (int i = 0; i < Cartas.Length; i++)
            {
                Cartas[i] = i;
                Console.WriteLine(Cartas[i]);
            }

            Console.ReadLine();

        }
    }
}
