 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_SEF1138122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool menuPrincipal = true;
            int[] num = new int[0];
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("------------------------- Bienvenid@ -------------------------");
                    Console.WriteLine("Porfavor eliga uno de los siguientes Opciones");
                    Console.WriteLine("1) Parte 1");
                    Console.WriteLine("2) Parte 2");
                    Console.WriteLine("0) Salir del programa.");

                    int control = int.Parse(Console.ReadLine());

                    Console.Clear();

                    switch (control)
                    {
                        case 1:
                            num = new int[10];
                            double Div = num.Length;
                            int Suma = 0;
                            bool submenu1 = true;

                            do
                            {
                                try
                                {
                                    for (int i = 0; i < num.Length; i++)
                                    {
                                        Console.Clear();
                                        int n = i + 1;
                                        Console.WriteLine("Ingrese el valor para el numero " + n + ": (Solo numeros enteros.)");
                                        num[i] = int.Parse(Console.ReadLine());
                                    }

                                    Console.Clear();

                                    foreach (int y in num)
                                    {
                                        Suma = Suma + num[y];
                                    }

                                    Console.WriteLine("La suma de todos los numeros es igual a: " + Suma);

                                    Div = (double)Suma / Div;

                                    Console.WriteLine("La media de aritmetica de los elementos es: " + Div);

                                    Console.ReadKey();

                                    submenu1 = false;
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Ingrese solo numeros enteros!");
                                    Console.ReadKey();
                                }
                            } while (submenu1 == true);

                            break;

                        case 2:

                            bool submenu2 = true;
                            int x = 0;
                            do
                            {
                                try
                                {
                                    int contadorCeros = 0;
                                    int contadorPos = 0;
                                    int contadorNeg = 0;

                                    Console.WriteLine("Ingrese el tamaño del arreglo: (Numero enteros)");
                                    x = int.Parse(Console.ReadLine());

                                    num = new int[x];

                                    for (int i = 0; i < num.Length; i++)
                                    {
                                        Console.Clear();
                                        int n = i + 1;
                                        Console.WriteLine("Ingrese el valor para el numero " + n + ":");
                                        num[i] = int.Parse(Console.ReadLine());
                                    }

                                    for (int y = 0; y < num.Length; y++)
                                    {
                                        if (num[y] < 0)
                                        {
                                            contadorNeg++;
                                        }
                                        else if (num[y] > 0)
                                        {
                                            contadorPos++;
                                        }
                                        else if (num[y] == 0)
                                        {
                                            contadorCeros++;
                                        }
                                    }

                                    Console.WriteLine("La cantidad de numeros negativos es: " + contadorNeg);
                                    Console.WriteLine("La cantidad de numeros positivos es: " + contadorPos);
                                    Console.WriteLine("La cantidad de 0 es: " + contadorCeros);

                                    Console.ReadKey();
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Ingrese solo numeros enteros!");
                                    Console.ReadKey();
                                }
                            } while (submenu2 == true);
                            
                            break;

                        case 0:
                            menuPrincipal = false;

                            break;

                        default:
                            Console.WriteLine("Opcion no valida");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Asegurese de haber elegido una opcion valida!");
                    Console.ReadKey();
                }
            }
            while (menuPrincipal == true);

            Console.WriteLine("Esperamos haya disfrutado su estadia.");
            Console.ReadKey();
        }
    }
}
