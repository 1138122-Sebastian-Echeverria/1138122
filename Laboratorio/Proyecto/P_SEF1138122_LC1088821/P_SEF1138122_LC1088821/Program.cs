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
            deck1P1.Cartas[1] = new Carta("Torre infernal", 1749, 1113.5);
            deck1P1.Cartas[2] = new Carta("Valkiria", 1908, 178);
            deck1P1.Cartas[3] = new Carta("Mago", 720, 281);
            deck1P1.Cartas[4] = new Carta("Zap!", 0, 192);
            deck1P1.Cartas[5] = new Carta("Bola de fuego", 0, 689);
            deck1P1.Cartas[6] = new Carta("Murcielagos", 405, 405);
            deck1P1.Cartas[7] = new Carta("Ariete de batalla", 2251, 670);
            deck1P1.ataque = 7.0;
            deck1P1.defensa = 10.0;
            deck1P1.sinergia = 6.0;

            //Segundo Mazo
            Deck deck2P1 = new Deck("Defensiva Barbara");
            deck2P1.Cartas[0] = new Carta("Monta Puercos", 1696, 318);
            deck2P1.Cartas[1] = new Carta("Arqueras", 608, 214);
            deck2P1.Cartas[2] = new Carta("Mortero", 1396, 266);
            deck2P1.Cartas[3] = new Carta("Zap!", 0, 192);
            deck2P1.Cartas[4] = new Carta("Mini Pekka", 1361, 720);
            deck2P1.Cartas[5] = new Carta("Bola de fuego", 0, 689);
            deck2P1.Cartas[6] = new Carta("Barbaros", 3350, 960);
            deck2P1.Cartas[7] = new Carta("Banda de duendes", 1005, 603);
            deck2P1.ataque = 8.0;
            deck2P1.defensa = 10.0;
            deck2P1.sinergia = 9.2;

            //Tercer Mazo
            Deck deck1P2 = new Deck("La venganza del noble");
            deck1P2.Cartas[0] = new Carta("Bandida", 907, 387);
            deck1P2.Cartas[1] = new Carta("Bola de fuego", 0, 689);
            deck1P2.Cartas[2] = new Carta("Rey fantasma", 1210, 261);
            deck1P2.Cartas[3] = new Carta("Arquero mágico", 532, 134);
            deck1P2.Cartas[4] = new Carta("Pekka", 3760, 816);
            deck1P2.Cartas[5] = new Carta("Ariete de batalla", 911, 265);
            deck1P2.Cartas[6] = new Carta("Zap!", 0, 192);
            deck1P2.Cartas[7] = new Carta("Mago eléctrico", 713, 225);
            deck1P2.ataque = 10.0;
            deck1P2.defensa = 10.0;
            deck1P2.sinergia = 7.8;

            //Cuarto Mazo
            Deck deck2P2 = new Deck("Las tierras oscuras");
            deck2P2.Cartas[0] = new Carta("Bandida", 907, 193);
            deck2P2.Cartas[1] = new Carta("Bola de fuego", 689, 207);
            deck2P2.Cartas[2] = new Carta("Gigante", 4091, 254);
            deck2P2.Cartas[3] = new Carta("Cementerio", 1539, 1539);
            deck2P2.Cartas[4] = new Carta("Bruja Nocturna", 1069, 476);
            deck2P2.Cartas[5] = new Carta("Esqueletos", 243, 243);
            deck2P2.Cartas[6] = new Carta("Zap!", 0, 192);
            deck2P2.Cartas[7] = new Carta("Mago Eléctrico", 713, 225);
            deck2P2.ataque = 9.2;
            deck2P2.defensa = 8.0;
            deck2P2.sinergia = 10.0;
        }
    }
}
