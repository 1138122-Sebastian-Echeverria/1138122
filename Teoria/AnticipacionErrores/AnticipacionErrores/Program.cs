using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnticipacionErrores
{
    class Program
    {
        static void Main(string[] args)
        {
            int _dividendo = 0;
            int _divisor = 1;

            try
            {
                Console.WriteLine("Ingrese el dividendo");
                _dividendo = Convert.ToInt32(Console.ReadLine());
            }
            catch 
            {
                Console.WriteLine("El valor que ingreso no es un numero");
            }


            try
            {
                Console.WriteLine("Ingrese el divisor");
                _divisor = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("El valor que ingreso no es un numero");
            }

            

            try
            {
                int _cociente = _dividendo / _divisor;
                Console.WriteLine("El cociente es: " + _cociente);
            }
            catch 
            {
                Console.WriteLine("No se puede dividir por 0");
            }

            
            //ESTA NO ES UNA FORMA CORRECTA PERO SE OBTIENE EL MISMO RESULTADO
            /*
            try
            {
                Console.WriteLine("Ingrese el dividendo");
                _dividendo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el divisor");
                _divisor = Convert.ToInt32(Console.ReadLine());

                int _cociente = _dividendo / _divisor;
                Console.WriteLine("El cociente es: " + _cociente);
            }
            catch
            {
                Console.WriteLine("Ocurrio un error");
            }

            */
            Console.ReadKey();


        }
    }
}
