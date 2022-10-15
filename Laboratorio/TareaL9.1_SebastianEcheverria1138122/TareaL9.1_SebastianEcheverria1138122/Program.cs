using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaL9._1_SebastianEcheverria1138122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motocicleta objMotocicleta = new Motocicleta();

            objMotocicleta.DefinirPrecio(5000);
            objMotocicleta.DefinirIva(0.05);

            Console.WriteLine("Datos:");
            Console.WriteLine(objMotocicleta.MostrasDatos());
            Console.WriteLine("Precio sin IVA: " + objMotocicleta.PrecioSinIva());
            Console.WriteLine("IVA: " + objMotocicleta.DevolverIva());
            Console.WriteLine("Precio final: " + objMotocicleta.PrecioConIva());

        }
    }
}
