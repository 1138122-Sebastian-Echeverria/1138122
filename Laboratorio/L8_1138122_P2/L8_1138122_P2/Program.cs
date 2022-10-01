using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8_1138122_P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Ingrese el segundo numero: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Ingrese el tercer numero: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("A es el mayor");
                }
                else
                {
                    if (a == c)
                    {
                        Console.WriteLine("A y C son los mayores");
                    }
                    else
                    {
                        Console.WriteLine("C es el mayor");
                    }
                }
            }
            else
            {
                if (a == b)
                {
                    if (a > c)
                    {
                        Console.WriteLine("A y B son mayores");
                    }
                    else
                    {
                        if (a == c)
                        {
                            Console.WriteLine("A, B y C por lo tanto no hay mayores.");
                        }
                        else
                        {
                            Console.WriteLine("C es el mayor.");
                        }
                    }
                }
                else
                {
                    if (b > c)
                    {
                        Console.WriteLine("B es el mayor.");
                    }
                    else
                    {
                        if (b == c)
                        {
                            Console.WriteLine("B y C son los mayores.");
                        }
                        else
                        {
                            Console.WriteLine("C es el mayor.");
                        }
                    }
                }
            }
        }
    }
}
