using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_SebastianEcheverria_1138122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero del programa que desea usar.");
            Console.WriteLine("1) Averiguar si numero es positivo o negativo");
            Console.WriteLine("2) Numero y dia de la semana.");
            int Menu = int.Parse(Console.ReadLine());

            switch (Menu)
            {
                //Averigurar si numero es positivo o negativo.
                case 1:
                    Console.Clear();
                    Console.WriteLine("Ingrese un numero");
                    int N = int.Parse(Console.ReadLine());

                    //Positivo
                    if (N > 0)
                    {
                        Console.WriteLine("El numero " + N + " es positivo");
                        Console.ReadKey();
                    }
                    //Negativo
                    else if (N < 0)
                    {
                        Console.WriteLine("El numero " + N + " es negativo");
                        Console.ReadKey();
                    }
                    //Cero
                    else if (N == 0)
                    {

                        Console.WriteLine("El numero es cero.");
                    }
                    break;
                    
                    //Numero y dia de la semana
                case 2:
                    Console.Clear();
                    Console.WriteLine("Ingrese un numero del 1 al 7");
                    int Num = int.Parse(Console.ReadLine());
                    switch (Num)
                    {
                        case 1:
                            Console.WriteLine("Hoy es Lunes");
                            Console.ReadKey();
                            break;

                        case 2:
                            Console.WriteLine("Hoy es Martes");
                            Console.ReadKey();
                            break;

                        case 3:
                            Console.WriteLine("Hoy es Miercoles");
                            Console.ReadKey();
                            break;

                        case 4:
                            Console.WriteLine("Hoy es Jueves");
                            Console.ReadKey();
                            break;

                        case 5:
                            Console.WriteLine("Hoy es Viernes");
                            Console.ReadKey();
                            break;

                        case 6:
                            Console.WriteLine("Hoy es Sabado");
                            Console.ReadKey();
                            break;

                        case 7:
                            Console.WriteLine("Hoy es Domingo");
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Bobi");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Numero invalido.");
                    break;
            }
        }
    }
}
