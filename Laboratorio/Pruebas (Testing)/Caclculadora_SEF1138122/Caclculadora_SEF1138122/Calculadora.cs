using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caclculadora_SEF1138122
{
    internal class Calculadora
    {
        public double Dividir(double a, double b)
        {
            try
            {
                return a / b;
            }
            catch
            {
                return 0;
                throw new DivideByZeroException("Se intento dividir dentro de 0");
            }
        }
    }
}
