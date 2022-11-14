using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_SEF1138122_LC1088821
{
    internal class Carta
    {
        public string nombre;
        public int puntosDeVida;
        public double daño;

        public Carta(string nombre, int puntosDeVida, double daño)
        {
            this.nombre = nombre;
            this.puntosDeVida = puntosDeVida;
            this.daño = daño;
        }
    }
}
