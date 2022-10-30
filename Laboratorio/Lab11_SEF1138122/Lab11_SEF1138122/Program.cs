using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_SEF1138122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero mayor a 10");
            int N = int.Parse(Console.ReadLine());

            // Array creado de tipo entero
            int[] elementos = new int[N];

            //Manera de rocorrer un arreglo
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Ingrese el numero que desea guardar");
                int numero = int.Parse(Console.ReadLine());

                elementos[i] = numero;
            }

            /*
            Carro carro = new Carro();
            Carro[] carros = new Carro[10];
            String[] mensajes = new string[19];
            Double[] valores = new double[5];
            Boolean[] banderas = new Boolean[5];
            */


            Console.WriteLine("Ingrese X:");
            int X = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Y:");
            int Y = int.Parse(Console.ReadLine());

            //Arreglo multidimencional de 2 dimensiones
            int[,] table = new int[X, Y];
            table[0, 1] = 1239;

            //Recorrer un arreglo multidimencional
            for (int x = 0; x < X; x++)
            {
                for (int y = 0; y < Y; y++)
                {
                    table[x, y] = 1;
                }
            }


            Console.WriteLine();
        }
    }
}
