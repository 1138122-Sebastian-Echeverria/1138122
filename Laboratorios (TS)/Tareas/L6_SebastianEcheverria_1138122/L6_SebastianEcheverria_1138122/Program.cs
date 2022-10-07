using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_SebastianEcheverria_1138122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //verificador de contraseña
            String contraseniaDos = "";
            String contrasenia = "";
            Console.WriteLine("Ingrese una constraseña: ");
            contraseniaDos = Console.ReadLine();

            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese la constraseña: ");
                contrasenia = Console.ReadLine();

            } while (!(contrasenia == contraseniaDos));
        }
    }
}
