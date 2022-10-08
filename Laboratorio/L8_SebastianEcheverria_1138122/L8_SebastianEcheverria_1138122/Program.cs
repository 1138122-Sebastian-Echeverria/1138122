using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8_SebastianEcheverria_1138122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine("Bienvenido " + nombre);

            Console.WriteLine("Que numero de Fibonacci desea?");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Ese numero de Fibonacci no existe");
            }
            else
            {
                if (n == 1)
                {
                    Console.WriteLine(0);
                }
                else if (n == 2)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    int resultado = 0;
                    int n1 = 0;
                    int n2 = 1;
                    for (int i = 3; i <= n; i++)
                    {
                        resultado = n1 + n2;
                        n1 = n2;
                        n2 = resultado;
                    }
                    Console.WriteLine(resultado);
                }
            }
            Console.ReadLine();
        }
    }
}
