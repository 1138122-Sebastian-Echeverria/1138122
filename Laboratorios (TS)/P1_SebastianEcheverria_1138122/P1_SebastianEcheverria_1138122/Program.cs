using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_SebastianEcheverria_1138122
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menu = true;
            double ing = 0.0;
            double egr = 0.0;
            double res = 0;
            do
            {
                try
                { 

                    do
                    {
                        bool menu2 = true;
                        Console.Clear();
                        Console.WriteLine("----------------- Bienvenido a nuestro servicio -----------------");
                        Console.WriteLine("");
                        Console.WriteLine("Seleccione una opcion: ");
                        Console.WriteLine("1. Ingresos");
                        Console.WriteLine("2. Egresos");
                        Console.WriteLine("3. Resultados");
                        Console.WriteLine("4. Salir");
                        int m = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        switch (m)
                        {
                            case 1:
                                while (menu2 == true)
                                {


                                    Console.WriteLine("Ingrese la cantidad de sus ingresos ");
                                    Console.WriteLine("Formato: 0.00 ");
                                    ing = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("¿Desea agregar?");
                                    Console.WriteLine("1. Si");
                                    Console.WriteLine("2. No");
                                    int respuesta = Convert.ToInt32(Console.ReadLine());
                                    switch (respuesta)
                                    {
                                        case 1:
                                            menu2 = false;
                                            break;

                                        case 2:
                                            menu2 = true;
                                            break;
                                    }
                                }
                                break;

                            case 2:
                                while (menu2 == true)
                                {
                                    Console.WriteLine("Ingrese el total de sus egresos: ");
                                    Console.WriteLine("Formato: 0.00 ");
                                    Console.WriteLine("");
                                    egr = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("¿Desea agregar?");
                                    Console.WriteLine("1. Si");
                                    Console.WriteLine("2. No");
                                    int respuesta = Convert.ToInt32(Console.ReadLine());
                                    switch (respuesta)
                                    {
                                        case 1:
                                            menu2 = false;
                                            break;

                                        case 2:
                                            menu2 = true;
                                            break;
                                    }
                                    break;
                                }
                                break;

                            case 3:
                                if (egr == 0.0 || ing == 0.0)
                                {
                                    Console.WriteLine("Ingrese numeros en las primeras opciones.");
                                }
                                else if (egr < 0 || ing < 0)
                                {
                                    Console.WriteLine("Ingreso un numero negativo por tanto, sus finanzas no tienen sentido. Aprenda a hacer bien sus cuentas.");
                                }
                                else
                                {
                                    Console.WriteLine("El total de sus ingresos es: ");
                                    res = ing - egr;
                                    Console.Write(res);

                                    if (res == 0)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("Tablas");
                                    }
                                    if (res > 0)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("Consejos de inversion");
                                        Console.WriteLine("Busca información sobre las opciones de inversión que existen");
                                        Console.WriteLine("Conoce la conducta financiera del mercado elegido");
                                        Console.WriteLine("Establece objetivos y metas de inversión");
                                        Console.WriteLine("Consulta a un especialista");
                                        Console.WriteLine("Haz un presupuesto, no te endeudes");
                                    }
                                    else if (res < 0)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("Algunos consejos para mejorar finanzas: ");
                                        Console.WriteLine("Mantén un registro de tus gastos para mejorar tus finanzas ");
                                        Console.WriteLine("Crea un presupuesto mensual realista");
                                        Console.WriteLine("Crea tu fondo de emergencia");
                                        Console.WriteLine("Paga tus facturas al final del mes ");
                                        Console.WriteLine("Ahorra dinero para hacer compras grandes ");
                                    }
                                }

                                Console.ReadKey();
                                break;

                            case 4:
                                menu = false;
                                break;

                        }
                    }
                    while (menu == true);
                }
                catch (Exception)
                {
                    Console.WriteLine("Asegurese que no haya valores en blanco o esten correctos.");
                    Console.ReadKey();

                }
            }
            while (menu == true);

        }
    }
}
