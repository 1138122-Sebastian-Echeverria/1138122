using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_SEF1138122
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arreglo de tipo de dato primitivo
            /*int[] numeros = new int[10];

            numeros[1] = 32;

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = i;
                Console.WriteLine(i);
            }
            */

            //Vector de tipo primitivo
            /*int[,] matrizPrueba = new int[3, 2];
            matrizPrueba[1, 1] = 43;

            foreach (int i in matrizPrueba)
            {
                Console.WriteLine(i);
            }
            */

            //Arreglos de tipo class

            Cancion cancion_moscow_mule = new Cancion("Moscow Mule",4,"trap", "Benito Antonio Martinezocasio", "Bad Bunny");

            Cancion cancion_how_we_coming = new Cancion("How we coming", 3, "rap", "Migos", "Migos");

            //creacion de arreglo
            List<Cancion> playlist = new List<Cancion>();
            playlist.Add(cancion_moscow_mule);
            playlist.Add(cancion_how_we_coming);
            playlist.Add(new Cancion("Moscow Mule", 4, "trap", "Benito Antonio Martinezocasio", "Bad Bunny"));
            playlist.Add(cancion_how_we_coming = new Cancion("La dificil", 5, "trap", "Bad Bunny", "Benito Antonio Martinezocasio"));

            //recorrer
            foreach (Cancion rola in playlist)
            {
                Console.WriteLine(rola.toString());
            }

            //Generando aleatoriedad
            /*var random = new Random();

            playlist = playlist.OrderBy<item => random.Next())>
            */

            Console.ReadLine();
        }
    }
}
