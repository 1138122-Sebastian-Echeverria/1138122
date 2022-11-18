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
        public double Daño = 0;
        public double ataque;
        public double defensa;
        public double sinergia;
        public string nombre;



        public double GetDañoTotal()
        {
            Daño = 0;
            for (int i = 0; i < Cartas.Length; i++)
            {
                Daño = Daño + Cartas[i].daño;
            }

            return Daño;
        }

        public double GetPuntosDeVida()
        {
            PuntosdeVida = 0;
            for (int i = 0; i < Cartas.Length; i++)
            {
                PuntosdeVida = PuntosdeVida + Cartas[i].puntosDeVida;
            }

            return PuntosdeVida;
        }

        public Deck(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
