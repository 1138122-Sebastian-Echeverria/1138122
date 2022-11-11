using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2_Jaime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string Apellidos;
            int carnet;
            string verCarnet;
            string Carrera;
            string respuesta;
            int puntos = 0;
            bool menu = true;
            int opciones;

            do
            {
                //Inicio de menu
                Console.Clear();
                Console.WriteLine("----------- Bienvenid@ -----------");
                Console.WriteLine("Porfavor seleccione una opcion.");
                Console.WriteLine("1) Empezar prueba \n 0) Salir");
                // El \n hace un espacio como de enter.
                opciones = int.Parse(Console.ReadLine());

                Console.Clear();

                // Opciones del menu
                switch (opciones)
                {
                    //Prueba
                    case 1:
                        Console.WriteLine("Porfavor ingrese los siguientes: ");

                        Console.WriteLine("");

                        Console.WriteLine("Ingrese su Nombre: ");
                        nombre = Console.ReadLine();

                        Console.WriteLine("");

                        Console.WriteLine("Ingrese su Apellidos");
                        Apellidos = Console.ReadLine();

                        string nombreCom = nombre + " " + Apellidos;

                        Console.WriteLine("");

                        Console.WriteLine("Ingrese su número de carné");
                        carnet = int.Parse(Console.ReadLine());

                        //verificacion del carnet, aqui se cambia
                        verCarnet = Convert.ToString(carnet);

                        //aqui reviza que termine con 22
                        if (verCarnet.Trim().EndsWith("22"))
                        {
                            Console.WriteLine("\n Su carnet es valido. \n");
                        }
                        else
                        {
                            Console.WriteLine("\n Su carnet no es de primer ingreso del año 2022! \n");
                            break;
                        }

                        Console.WriteLine("Ingrese su carrera");
                        Carrera = Console.ReadLine();

                        Console.WriteLine("");
                        
                        //Empieza la prueba
                        Console.Clear();
                        Console.WriteLine("Primera pregunta:"); //Pregunta 1
                        Console.WriteLine("Una abstracción se pierde cuando toma detalles en consideración. \n Conteste con V / F");
                        respuesta = Console.ReadLine();

                        respuesta.ToLower();

                        if (respuesta == "v")
                        {
                            puntos = puntos + 50;
                        }

                        Console.Clear();
                        Console.WriteLine("Segunda pregunta:");//Pregunta 2
                        Console.WriteLine("Una abstracción debe ser instanciada antes de ser ejecutada. \n V / F");
                        respuesta = Console.ReadLine();

                        respuesta.ToLower();

                        if (respuesta == "v")
                        {
                            puntos = puntos + 50;
                        }

                        Console.Clear();
                        Console.WriteLine("Tercera pregunta:"); //Pregunta 3
                        Console.WriteLine("Un modelo dinámico muestra los cambios de estado de algo a través del tiempo. \n V / F");
                        respuesta = Console.ReadLine();

                        respuesta.ToLower();

                        if (respuesta == "v")
                        {
                            puntos = puntos + 50;
                        }

                        Console.Clear();
                        Console.WriteLine("Cuarta pregunta:"); //Pregunta 4
                        Console.WriteLine("Un grafo direccionado NO es un modelo dinámico. \n V / F");
                        respuesta = Console.ReadLine();

                        respuesta.ToLower();

                        if (respuesta == "f")
                        {
                            puntos = puntos + 50;
                        }

                        Console.Clear();
                        Console.WriteLine("Quinta pregunta:"); //Pregunta 5
                        Console.WriteLine("La fidelidad describe la cercanía al valor real, la precisión describe el nivel de refinamiento de una medida. \n V / F");
                        respuesta = Console.ReadLine();

                        respuesta.ToLower();

                        if (respuesta == "v")
                        {
                            puntos = puntos + 50;
                        }

                        Console.Clear();
                        Console.WriteLine("Sexta pregunta:"); //Pregunta 6
                        Console.WriteLine("Aproximadamente, ¿cuántos huesos tiene el cuerpo humano? \n a) 40 \n b) 206 \n c) 390");
                        respuesta = Console.ReadLine();

                        respuesta.ToLower();

                        if (respuesta == "b")
                        {
                            puntos = puntos + 100;
                        }

                        Console.Clear();
                        Console.WriteLine("Septima pregunta:"); //Pregunta 7
                        Console.WriteLine(" ¿Quien es Don Quijote de la Mancha? \n a) Un pobre hidalgo \n b) Un caballero \n c) Un general");
                        respuesta = Console.ReadLine();

                        respuesta.ToLower();

                        if (respuesta == "a")
                        {
                            puntos = puntos + 100;
                        }

                        Console.Clear();
                        Console.WriteLine("Octava pregunta:"); //Pregunta 8
                        Console.WriteLine(" ¿Cual es el salario minimo en Guatemala para un salario no agricola? \n a) 3,209.24 \n b) 3,122.55 \n c) 2,954.35");
                        respuesta = Console.ReadLine();

                        respuesta.ToLower();

                        if (respuesta == "a")
                        {
                            puntos = puntos + 100;
                        }

                        Console.Clear();
                        Console.WriteLine("Novena pregunta:"); //Pregunta 9
                        Console.WriteLine(" ¿Cual de los siguientes es una maravilla del mundo? \n a) Petra \n b) El Presidente \n c) La McRib");
                        respuesta = Console.ReadLine();

                        respuesta.ToLower();

                        if (respuesta == "a")
                        {
                            puntos = puntos + 100;
                        }

                        Console.Clear();
                        Console.WriteLine("Decima pregunta:"); //Pregunta 10
                        Console.WriteLine(" \n a) \n b) \n c)");
                        respuesta = Console.ReadLine();

                        respuesta.ToLower();

                        if (respuesta == "v")
                        {
                            puntos = puntos + 100;
                        }

                        Console.Clear();
                        Console.WriteLine("Onceava pregunta:"); //Pregunta 11
                        Console.WriteLine(" s = 'No, print this!'; \n Console.WriteLine(s); \n s = 'Print this message'; \n Console.WriteLine(s);  \n Cual es la salida del programa: \n a)Imprimer solo el ultimo mensaje \n b) No imprime nada \n c) Imprime ambos mensajes \n d) imprime solo el primero.");
                        respuesta = Console.ReadLine();

                        respuesta.ToLower();

                        if (respuesta == "v")
                        {
                            puntos = puntos + 50;
                        }

                        Console.Clear();
                        Console.WriteLine("Doceava pregunta:"); //Pregunta 12
                        Console.WriteLine(" \n a) \n b) \n c) \n d)");
                        respuesta = Console.ReadLine();

                        respuesta.ToLower();

                        if (respuesta == "v")
                        {
                            puntos = puntos + 50;
                        }

                        Console.Clear();
                        Console.WriteLine("Treceava pregunta:"); //Pregunta 13
                        Console.WriteLine(" \n a) \n b) \n c) \n d)");
                        respuesta = Console.ReadLine();

                        respuesta.ToLower();

                        if (respuesta == "v")
                        {
                            puntos = puntos + 50;
                        }

                        Console.Clear();
                        Console.WriteLine("Catorceava pregunta:"); //Pregunta 14
                        Console.WriteLine(" \n a) \n b) \n c) \n d)");
                        respuesta = Console.ReadLine();

                        respuesta.ToLower();

                        if (respuesta == "v")
                        {
                            puntos = puntos + 50;
                        }

                        Console.Clear();
                        Console.WriteLine("Quinceava pregunta:"); //Pregunta 15
                        Console.WriteLine(" \n a) \n b) \n c) \n d)");
                        respuesta = Console.ReadLine();

                        respuesta.ToLower();

                        if (respuesta == "v")
                        {
                            puntos = puntos + 50;
                        }

                        //Guardar datos de los estudiantes
                        Console.Clear();
                        List<Puntuaciones> puntuaciones = new List<Puntuaciones>();
                        puntuaciones.Add(new Puntuaciones(nombreCom, carnet, Carrera, puntos));

                        foreach (Puntuaciones persona in puntuaciones)
                        {
                            Console.WriteLine(persona.toString());
                        }

                        Console.ReadKey();
                        break;

                    case 0:
                        menu = false;
                        break;

                    default: 

                        break;
                }
            }
            while (menu == true);


        }
    }
}
