using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8_1138122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1");
            Console.WriteLine("Ingrese el numero del mes: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (m < 1 || m > 12)
            {
                Console.WriteLine("Error: Numero invalido");
            }
            else
            {

                switch (m)
                {
                    case 1:
                        Console.WriteLine("Estamos en el mes Enero.");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("Estamos en el mes Febrero.");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Estamos en el mes Marzo.");
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("Estamos en el mes Abril.");Console.ReadKey();
                        break;

                    case 5:
                        Console.WriteLine("Estamos en el mes Mayo.");
                        break;

                    case 6:
                        Console.WriteLine("Estamos en el mes Junio.");
                        break;

                    case 7:
                        Console.WriteLine("Estamos en el mes Julio.");
                        break;

                    case 8:
                        Console.WriteLine("Estamos en el mes Agosto.");
                        break;

                    case 9:
                        Console.WriteLine("Estamos en el mes Septiembre.");
                        break;

                    case 10:
                        Console.WriteLine("Estamos en el mes Octubre.");
                        break;

                    case 11:
                        Console.WriteLine("Estamos en el mes Noviembre.");
                        break;

                    case 12:
                        Console.WriteLine("Estamos en el mes Diciembre.");
                        break;
                }

                Console.ReadKey();
            }
        }
    }
}
