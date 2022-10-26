using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_Con_Sumas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suma 5 + 10 = " + Suma(5, 10));
            Console.WriteLine("Multiplicacion 5 * 10 = " + Multiplicacion(5, 10));
            Console.WriteLine("Potencia 5 ^ 3 = " + Potencia(5, 3));
            Console.WriteLine("Resta 5 - 3 = " + Resta(5, 3));
            Console.WriteLine("Cociente 5 / 3 = " + Cociente(5, 3));
            Console.WriteLine("Cociente 9 / 3 = " + Cociente(9, 3));
            Console.WriteLine("Cociente 3 / 9 = " + Cociente(3, 9));
            Console.WriteLine("Residuo 5 / 3 = " + Residuo(5, 3));
            Console.WriteLine("Residuo 9 / 3 = " + Residuo(9, 3));
            Console.WriteLine("Residuo 3 / 9 = " + Residuo(3, 9));


            Console.ReadKey();
        }

        static int Suma(int sumando1, int sumando2) 
        {
            return sumando1 + sumando2;
        }

        static int Multiplicacion(int factor1, int factor2) 
        {
            int acumulador = 0;
            
            for (int i = 0; i < factor2; i++) {
                acumulador = Suma(acumulador, factor1);
            }

            return acumulador;
        }

        static int Potencia(int _base, int _exponente) {
            int acumulador = 1;

            for (int i = 0; i < _exponente; i++)
            {
                acumulador = Multiplicacion(acumulador, _base);
            }

            return acumulador;
        }

        static int Resta(int minuendo, int sustraendo) {
            sustraendo = -sustraendo;
            return Suma(minuendo, sustraendo);
        }

        static int Cociente(int dividendo, int divisor)
        {
            int contadora = 0;
            int resultado = Resta(dividendo, divisor);

            while (resultado >= 0) {
                resultado = Resta(resultado, divisor);
                contadora = contadora + 1; //contadora++;
            }

            return contadora;
        }

        static int Residuo(int dividendo,int divisor)
        {
            int Res = Cociente(dividendo, divisor);
            Res = Multiplicacion(divisor, Res);
            Res = Resta(dividendo, Res);
            return Res;
        }
    }
}
