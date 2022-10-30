using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ej11_SebastianEcheverria_1138122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*/Escribir un programa que permita emitir la FACTURA correspondiente, a una compra de un Artículo determinado, 
             * del que se adquieren una o varias Unidades. El IVA a aplicar es de 13% y si el Sub Total 
             * (precio de venta por cantidad), es Mayor de 1000, se aplicará un descuento del 15%./*/

            double subtotal = 0;
            bool Sub = true;
            double IVA = 0.13;

            //Precio y cantidad
            while (Sub == true)
            {
                Console.Clear();

                Console.WriteLine("Ingrese precio de un producto: ");
                double precio = double.Parse(Console.ReadLine());

                Console.WriteLine("");

                Console.WriteLine("ìngrese la cantidad de producto que se esta vendiendo: ");
                double cantidad = double.Parse(Console.ReadLine());

                Console.WriteLine("");

                subtotal = subtotal + (precio * cantidad);
                Console.WriteLine("Subtotal: " + subtotal);

                Console.WriteLine("");

                Console.WriteLine("Desea agregar otro producto? Introduzca el numero de la opcion. ");
                Console.WriteLine("1) Si");
                Console.WriteLine("2) No");
                int D = int.Parse(Console.ReadLine());

                switch (D)
                {
                    case 1:
                        break;

                    case 2:
                        Sub = false;
                        break;

                    default:
                        Console.WriteLine("Ingrese el numero especificado.");
                        break;
                }


            }

            Console.Clear();
            //Descuento, aqui como no dice si el descuento se aplica antes o despues del IVA yo lo tomare antes del IVA.
            if (subtotal > 1000)
            {
                Console.WriteLine("Felicidades usted aplica para el 15% de descuento!");
                subtotal = subtotal - (subtotal*0.15);
                Console.WriteLine("");
            }

            //IVA
            double Total = subtotal + (subtotal * IVA);

            Console.WriteLine("El subtotal: " + subtotal);
            Console.WriteLine("El total a pagar es de: " + Total);
            Console.WriteLine("Gracias por su compra");
        }
    }
}
