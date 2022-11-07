using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_SEF1138122_LC1088821
{
    internal class Deck
    {
        public Carta[] Cartas = new Carta[8];
        public double PuntosdeVida;
        public double Daño;
        public double ataque;
        public double defensa;
        public double sinergia;
        public double balance;
        public string nombre;

        public double GetDañoTotal()
        {
            double DañoT = 0;
            for (int i = 0; i < Cartas.Length; i++)
            {
                DañoT = DañoT + Cartas[i].daño;
            }

            return DañoT;
        }

        public double GetPuntosDeVida()
        {
            double VidaT = 0;
            for (int i = 0; i < Cartas.Length; i++)
            {
                VidaT = VidaT + Cartas[i].puntosDeVida;
            }

            return VidaT;
        }

        public Deck(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
