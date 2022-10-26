using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnticipacionErrores
{
    public class Calculadora
    {

        public int suma(int sumando1, int sumando2) {
            return sumando1 + sumando2;
        }

        public int resta(int minuendo, int sustraendo) {
            return suma(minuendo, -sustraendo);
        }

        public int multiplicacion(int factor1, int factor2) {
            int acumuladora = 0;
            bool ocurrioCambioFactor2 = false;

            //Si el factor 2 viene negativo lo convierto a positivo temporalmente
            if (factor2 < 0) {
                factor2 = factor2 * (-1);
                ocurrioCambioFactor2 = true;
            }

            for (int i = 0; i < factor2; i++) {
                acumuladora = suma(acumuladora, factor1);
            }

            if (ocurrioCambioFactor2) {
                acumuladora = acumuladora * (-1);
            }
            
            return acumuladora;
        }

        public int cociente(int dividendo, int divisor) {
            int acumuladora = dividendo;
            int contadora = 0;

            while ((acumuladora >= 0)) {
                acumuladora = resta(acumuladora, divisor);
                contadora++;
            }

            return contadora;
        }

        public int residuo(int dividendo, int divisor)
        {
            int acumuladora = dividendo;

            while ((resta(acumuladora, divisor) >= 0))
            {
                acumuladora = resta(acumuladora, divisor);
            }

            return acumuladora;
        }

    }
}
