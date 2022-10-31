using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_SEF1138122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            bool tempLoop = true;
            string nombreEmpleado;
            double salario;
            string turno = "Mañana";
            double sumaSalarios = 0;
            int i = 1;
            int empleadosT = 0;
            int empleadosM = 0;

            while (loop == true)
            {
                Console.WriteLine("--------------------------- Bienvenido ---------------------------");

                try
                {
                    Console.WriteLine("Ingrese una de las opciones:");
                    Console.WriteLine("1) Ejercicio 3");
                    Console.WriteLine("0) Salir");
                    int Menu = int.Parse(Console.ReadLine());

                    switch (Menu)
                    {
                        case 0:
                            loop = false;
                            break;

                            case 1:
                            Empleados empleado1 = new Empleados();
                            Console.Clear();

                            Console.WriteLine("Ingrese el nombre de el empleado numero: " + i);
                            nombreEmpleado = Console.ReadLine();

                            Console.Clear();
                            Console.WriteLine("Ingrese el salario del empleado: " + nombreEmpleado);
                            salario = int.Parse(Console.ReadLine());

                            while (tempLoop == true)
                            {
                                Console.Clear();
                                Console.WriteLine("Ingrese el turno del empleado: " + nombreEmpleado + " (mañana o tarde, no importa si es con mayusculas o minusculas.)");
                                turno = Console.ReadLine();
                                turno.ToLower();

                                if (turno == "mañana" || turno == "tarde")
                                {
                                    tempLoop = false;
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese una opcion valida");
                                    Console.ReadKey();
                                }
                            }

                            tempLoop = true;
                            Console.Clear();
                            if (turno == "mañana")
                            {
                                turno = "Mañana";
                                empleadosM++;
                            }
                            else if (turno == "tarde")
                            {
                                turno = "Tarde";
                                empleadosT++;
                            }

                            empleado1.Cargar(nombreEmpleado, salario, turno);


                            Empleados empleado2 = new Empleados();
                            Console.Clear();

                            i++;
                            Console.WriteLine("Ingrese el nombre de el empleado numero: " + i);
                            nombreEmpleado = Console.ReadLine();

                            Console.Clear();
                            Console.WriteLine("Ingrese el salario del empleado: " + nombreEmpleado);
                            salario = int.Parse(Console.ReadLine());

                            while (tempLoop == true)
                            {
                                Console.Clear();
                                Console.WriteLine("Ingrese el turno del empleado: " + nombreEmpleado + " (mañana o tarde, no importa si es con mayusculas o minusculas.)");
                                turno = Console.ReadLine();
                                turno.ToLower();

                                if (turno == "mañana" || turno == "tarde")
                                {
                                    tempLoop = false;
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese una opcion valida");
                                    Console.ReadKey();
                                }
                            }

                            tempLoop = true;
                            Console.Clear();
                            if (turno == "mañana")
                            {
                                turno = "Mañana";
                                empleadosM++;
                            }
                            else if (turno == "tarde")
                            {
                                turno = "Tarde";
                                empleadosT++;
                            }

                            empleado2.Cargar(nombreEmpleado, salario, turno);

                            Empleados empleado3 = new Empleados();
                            Console.Clear();

                            i++;
                            Console.WriteLine("Ingrese el nombre de el empleado numero: " + i);
                            nombreEmpleado = Console.ReadLine();

                            Console.Clear();
                            Console.WriteLine("Ingrese el salario del empleado: " + nombreEmpleado);
                            salario = int.Parse(Console.ReadLine());

                            while (tempLoop == true)
                            {
                                Console.Clear();
                                Console.WriteLine("Ingrese el turno del empleado: " + nombreEmpleado + " (mañana o tarde, no importa si es con mayusculas o minusculas.)");
                                turno = Console.ReadLine();
                                turno.ToLower();

                                if (turno == "mañana" || turno == "tarde")
                                {
                                    tempLoop = false;
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese una opcion valida");
                                    Console.ReadKey();
                                }
                            }

                            tempLoop = true;
                            Console.Clear();
                            if (turno == "mañana")
                            {
                                turno = "Mañana";
                                empleadosM++;
                            }
                            else if (turno == "tarde")
                            {
                                turno = "Tarde";
                                empleadosT++;
                            }

                            empleado3.Cargar(nombreEmpleado, salario, turno);

                            Empleados empleado4 = new Empleados();
                            Console.Clear();

                            i++;
                            Console.WriteLine("Ingrese el nombre de el empleado numero: " + i);
                            nombreEmpleado = Console.ReadLine();

                            Console.Clear();
                            Console.WriteLine("Ingrese el salario del empleado: " + nombreEmpleado);
                            salario = int.Parse(Console.ReadLine());

                            while (tempLoop == true)
                            {
                                Console.Clear();
                                Console.WriteLine("Ingrese el turno del empleado: " + nombreEmpleado + " (mañana o tarde, no importa si es con mayusculas o minusculas.)");
                                turno = Console.ReadLine();
                                turno.ToLower();

                                if (turno == "mañana" || turno == "tarde")
                                {
                                    tempLoop = false;
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese una opcion valida");
                                    Console.ReadKey();
                                }
                            }

                            tempLoop = true;
                            Console.Clear();
                            if (turno == "mañana")
                            {
                                turno = "Mañana";
                                empleadosM++;
                            }
                            else if (turno == "tarde")
                            {
                                turno = "Tarde";
                                empleadosT++;
                            }

                            empleado4.Cargar(nombreEmpleado, salario, turno);

                            Empleados empleado5 = new Empleados();
                            Console.Clear();

                            i++;
                            Console.WriteLine("Ingrese el nombre de el empleado numero: " + i);
                            nombreEmpleado = Console.ReadLine();

                            Console.Clear();
                            Console.WriteLine("Ingrese el salario del empleado: " + nombreEmpleado);
                            salario = int.Parse(Console.ReadLine());

                            while (tempLoop == true)
                            {
                                Console.Clear();
                                Console.WriteLine("Ingrese el turno del empleado: " + nombreEmpleado + " (mañana o tarde, no importa si es con mayusculas o minusculas.)");
                                turno = Console.ReadLine();
                                turno.ToLower();

                                if (turno == "mañana" || turno == "tarde")
                                {
                                    if (turno == "mañana" && empleadosM < 4)
                                    {
                                        tempLoop = false;
                                    }
                                    else if (turno == "tarde" && empleadosT < 4)
                                    {
                                        tempLoop = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("El numero de personas en ese turno ya esta lleno, seleccione otro turno.");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese una opcion valida");
                                    Console.ReadKey();
                                }
                            }

                            tempLoop = true;
                            Console.Clear();
                            if (turno == "mañana")
                            {
                                turno = "Mañana";
                                empleadosM++;
                            }
                            else if (turno == "tarde")
                            {
                                turno = "Tarde";
                                empleadosT++;
                            }

                            empleado5.Cargar(nombreEmpleado, salario, turno);

                            Empleados empleado6 = new Empleados();
                            Console.Clear();

                            i++;
                            Console.WriteLine("Ingrese el nombre de el empleado numero: " + i);
                            nombreEmpleado = Console.ReadLine();

                            Console.Clear();
                            Console.WriteLine("Ingrese el salario del empleado: " + nombreEmpleado);
                            salario = int.Parse(Console.ReadLine());

                            while (tempLoop == true)
                            {
                                Console.Clear();
                                Console.WriteLine("Ingrese el turno del empleado: " + nombreEmpleado + " (mañana o tarde, no importa si es con mayusculas o minusculas.)");
                                turno = Console.ReadLine();
                                turno.ToLower();

                                if (turno == "mañana" || turno == "tarde")
                                {
                                    if (turno == "mañana" && empleadosM < 4)
                                    {
                                        tempLoop = false;
                                    }
                                    else if (turno == "tarde" && empleadosT < 4)
                                    {
                                        tempLoop = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("El numero de personas en ese turno ya esta lleno, seleccione otro turno.");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese una opcion valida");
                                    Console.ReadKey();
                                }
                            }

                            tempLoop = true;
                            Console.Clear();
                            if (turno == "mañana")
                            {
                                turno = "Mañana";
                                empleadosM++;
                            }
                            else if (turno == "tarde")
                            {
                                turno = "Tarde";
                                empleadosT++;
                            }

                            empleado6.Cargar(nombreEmpleado, salario, turno);

                            Empleados empleado7 = new Empleados();
                            Console.Clear();

                            i++;
                            Console.WriteLine("Ingrese el nombre de el empleado numero: " + i);
                            nombreEmpleado = Console.ReadLine();

                            Console.Clear();
                            Console.WriteLine("Ingrese el salario del empleado: " + nombreEmpleado);
                            salario = int.Parse(Console.ReadLine());

                            while (tempLoop == true)
                            {
                                Console.Clear();
                                Console.WriteLine("Ingrese el turno del empleado: " + nombreEmpleado + " (mañana o tarde, no importa si es con mayusculas o minusculas.)");
                                turno = Console.ReadLine();
                                turno.ToLower();

                                if (turno == "mañana" || turno == "tarde")
                                {
                                    if (turno == "mañana" && empleadosM < 4)
                                    {
                                        tempLoop = false;
                                    }
                                    else if (turno == "tarde" && empleadosT < 4)
                                    {
                                        tempLoop = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("El numero de personas en ese turno ya esta lleno, seleccione otro turno.");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese una opcion valida");
                                    Console.ReadKey();
                                }
                            }

                            tempLoop = true;
                            Console.Clear();
                            if (turno == "mañana")
                            {
                                turno = "Mañana";
                                empleadosM++;
                            }
                            else if (turno == "tarde")
                            {
                                turno = "Tarde";
                                empleadosT++;
                            }

                            empleado7.Cargar(nombreEmpleado, salario, turno);

                            Empleados empleado8 = new Empleados();
                            Console.Clear();

                            i++;
                            Console.WriteLine("Ingrese el nombre de el empleado numero: " + i);
                            nombreEmpleado = Console.ReadLine();

                            Console.Clear();
                            Console.WriteLine("Ingrese el salario del empleado: " + nombreEmpleado);
                            salario = int.Parse(Console.ReadLine());

                            while (tempLoop == true)
                            {
                                Console.Clear();
                                Console.WriteLine("Ingrese el turno del empleado: " + nombreEmpleado + " (mañana o tarde, no importa si es con mayusculas o minusculas.)");
                                turno = Console.ReadLine();
                                turno.ToLower();

                                if (turno == "mañana" || turno == "tarde")
                                {
                                    if (turno == "mañana" && empleadosM < 4)
                                    {
                                        tempLoop = false;
                                    }
                                    else if (turno == "tarde" && empleadosT < 4)
                                    {
                                        tempLoop = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("El numero de personas en ese turno ya esta lleno, seleccione otro turno.");
                                        Console.ReadKey();

                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese una opcion valida");
                                    Console.ReadKey();
                                }
                            }

                            tempLoop = true;
                            Console.Clear();
                            if (turno == "mañana")
                            {
                                turno = "Mañana";
                                empleadosM++;
                            }
                            else if (turno == "tarde")
                            {
                                turno = "Tarde";
                                empleadosT++;
                            }

                            empleado8.Cargar(nombreEmpleado, salario, turno);

                            sumaSalarios = empleado1.ObtenerSalario() + empleado2.ObtenerSalario() +
                                empleado3.ObtenerSalario() + empleado4.ObtenerSalario() +
                                empleado5.ObtenerSalario() + empleado6.ObtenerSalario() +
                                empleado7.ObtenerSalario() + empleado8.ObtenerSalario();

                            Console.Clear();
                            List<Empleados> Lista = new List<Empleados>();
                            Lista.Add(empleado1);
                            Lista.Add(empleado2);
                            Lista.Add(empleado3);
                            Lista.Add(empleado4);
                            Lista.Add(empleado5);
                            Lista.Add(empleado6);
                            Lista.Add(empleado7);
                            Lista.Add(empleado8);

                            foreach (Empleados Persona in Lista)
                            {
                                Console.WriteLine(Persona.toString());
                            }

                            Console.WriteLine();
                            Console.WriteLine("La suma de sus salarios es de: " + sumaSalarios);

                            Console.ReadKey();
                            Console.Clear();
                            break;

                        default:
                            Console.WriteLine("Seleccione una opcion valida");
                            break;
                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("Ingrese una opcion valida.");
                }
            }

        }
    }
}
/**/