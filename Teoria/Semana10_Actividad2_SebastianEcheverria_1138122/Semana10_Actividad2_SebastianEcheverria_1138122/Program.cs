using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana10_Actividad2_SebastianEcheverria_1138122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aca leemos la oracion y la guardamos en una variable string (paso 1)
            Console.WriteLine("Ingrese una oracion");
            string oracion = Console.ReadLine();

            //Paso 2 Aca guardamos las palabras, separadas por espacios en blanco
            char delimitador = ' ';
            string[] palabras = oracion.Split(delimitador);

            //Estoy creando 2 vectores vacios con la cantidad de espacios suficientes para guardar todas las palabras
            string[] palabras_finales = new string[palabras.Length];
            int[] frencia_palabras = new int[palabras.Length];

            for (int i = 0; i < palabras_finales.Length; i++)
            {
                palabras_finales[i] = "";
                frencia_palabras[i] = 0;
            }


            //Recorre todas las palabras, de la oracion palabra por palabra
            for (int i = 0; i < palabras.Length; i++)
            {

                //Aca recorro todo el vector de las palabras finales
                for (int j = 0; j < palabras_finales.Length; j++)
                {
                    if (palabras_finales[j] == "")
                    {
                        palabras_finales[j] = palabras[i];
                        frencia_palabras[j]++;
                        break;
                    }
                    else if (palabras[i] == palabras_finales[j])
                    {
                        frencia_palabras[j]++;
                        break;
                    }

                }

            }

            //Aca recorro todo el vector de las palabras finales
            for (int i = 0; i < palabras_finales.Length; i++)
            {
                Console.WriteLine("Palabra " + i + ": " + palabras_finales[i] + " frecuencia: " + frencia_palabras[i]);
            }

            Console.WriteLine("************PALABRAS UNICAS************");
            //Ahora debo colocar las palabras que son unicas
            for (int i = 0; i < palabras_finales.Length; i++)
            {
                if (frencia_palabras[i] == 1)
                {
                    Console.WriteLine(palabras_finales[i]);
                }
            }
        }
    }
}
