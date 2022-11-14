using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_SEF1138122_LC1088821
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //Primer Mazo
            Deck deck1P1 = new Deck("Torre del Noble");
            deck1P1.Cartas[0] = new Carta("Gigante Noble", 3072, 307);
            deck1P1.Cartas[1] = new Carta("Bola de fuego", 689, 207);
            deck1P1.Cartas[2] = new Carta("Gigante", 4091, 254);
            deck1P1.Cartas[3] = new Carta("Cementerio", 1539, 1539);
            deck1P1.Cartas[4] = new Carta("Bruja Nocturna", 1069, 476);
            deck1P1.Cartas[5] = new Carta("Esqueletos", 243, 243);
            deck1P1.Cartas[6] = new Carta("Zap!", 0, 192);
            deck1P1.Cartas[7] = new Carta("Mago Electrico", 713, 225);
            deck1P1.ataque = 7.0;
            deck1P1.defensa = 10.0;
            deck1P1.sinergia = 6.0;

            //Segundo Mazo
            Deck deck2P1 = new Deck("Defensiva Barbara");
            deck2P1.Cartas[0] = new Carta("", 0, 0);
            deck2P1.Cartas[1] = new Carta("", 0, 0);
            deck2P1.Cartas[2] = new Carta("", 0, 0);
            deck2P1.Cartas[3] = new Carta("", 0, 0);
            deck2P1.Cartas[4] = new Carta("", 0, 0);
            deck2P1.Cartas[5] = new Carta("", 0, 0);
            deck2P1.Cartas[6] = new Carta("", 0, 0);
            deck2P1.Cartas[7] = new Carta("", 0, 0);
            deck2P1.ataque = 0;
            deck2P1.defensa = 0;
            deck2P1.sinergia = 0;

            //Tercer Mazo
            Deck deck1P2 = new Deck("La venganza del noble");
            deck1P2.Cartas[0] = new Carta("", 0, 0);
            deck1P2.Cartas[1] = new Carta("", 0, 0);
            deck1P2.Cartas[2] = new Carta("", 0, 0);
            deck1P2.Cartas[3] = new Carta("", 0, 0);
            deck1P2.Cartas[4] = new Carta("", 0, 0);
            deck1P2.Cartas[5] = new Carta("", 0, 0);
            deck1P2.Cartas[6] = new Carta("", 0, 0);
            deck1P2.Cartas[7] = new Carta("", 0, 0);
            deck1P2.ataque = 0;
            deck1P2.defensa = 0;
            deck1P2.sinergia = 0;

            //Cuarto Mazo
            Deck deck2P2 = new Deck("Las tierras oscuras");
            deck2P2.Cartas[0] = new Carta("", 0, 0);
            deck2P2.Cartas[1] = new Carta("", 0, 0);
            deck2P2.Cartas[2] = new Carta("", 0, 0);
            deck2P2.Cartas[3] = new Carta("", 0, 0);
            deck2P2.Cartas[4] = new Carta("", 0, 0);
            deck2P2.Cartas[5] = new Carta("", 0, 0);
            deck2P2.Cartas[6] = new Carta("", 0, 0);
            deck2P2.Cartas[7] = new Carta("", 0, 0);
            deck2P2.ataque = 0;
            deck2P2.defensa = 0;
            deck2P2.sinergia = 0;
        }
    }
}
