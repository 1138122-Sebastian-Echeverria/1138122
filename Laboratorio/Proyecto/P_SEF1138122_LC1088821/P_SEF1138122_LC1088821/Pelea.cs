using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_SEF1138122_LC1088821
{
    public partial class Pelea : Form
    {
        string nombre1;
        string nombre2;
        int deckJ1;
        int deckJ2;
        string n1;
        double D1;
        double V1;
        double Def1;
        double A1;
        double S1;
        string n2;
        double D2;
        double V2;
        double Def2;
        double A2;
        double S2;
        int cont1 = 0;
        int cont2 = 0;

        public Pelea(string nombre1, string nombre2, int deckJ1, int deckJ2)
        {
            InitializeComponent();
            this.nombre1 = nombre1;
            this.nombre2 = nombre2;
            this.deckJ1 = deckJ1;
            this.deckJ2 = deckJ2;

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
            deck1P2.Cartas[2] = new Carta("Rey Fantasma", 1210, 261);
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

            


            if (deckJ1 == 1)
            {
                n1 = deck1P1.nombre;
                this.D1 = deck1P1.GetDañoTotal(); ;
                this.V1 = deck1P1.GetPuntosDeVida();
                this.Def1 = deck1P1.ataque;
                this.A1 = deck1P1.defensa;
                this.S1 = deck1P1.sinergia;


                groupBox1.Text = nombre1;
                D1j1.Text = D1j1.Text + "\n" + D1;
                V1J1.Text = V1J1.Text + "\n" + V1;
                A1J1.Text = A1J1.Text + "\n" + Def1;
                Def1J1.Text = Def1J1.Text + "\n" + A1;
                S1J1.Text = S1J1.Text = "\n" + S1;

                groupBox4.Text = nombre1;
                groupBox4.Hide();
            }
            else if (deckJ1 == 2)
            {
                n1 = deck2P1.nombre;
                this.D1 = deck2P1.GetDañoTotal();
                this.V1 = deck2P1.GetPuntosDeVida();
                this.Def1 = deck2P1.ataque;
                this.A1 = deck2P1.defensa;
                this.S1 = deck2P1.sinergia;

                groupBox4.Text = nombre1;
                D2j1.Text = D2j1.Text + "\n" + D1;
                V2J1.Text = V2J1.Text + "\n" + V1;
                A2J1.Text = A2J1.Text + "\n" + Def1;
                Def2J1.Text = Def2J1.Text + "\n" + A1;
                S2J1.Text = S2J1.Text = "\n" + S1;

                groupBox1.Text = nombre1;
                groupBox1.Hide();
            }


            if (deckJ2 == 1)
            {
                n2 = deck1P2.nombre;
                this.D2 = deck1P2.GetDañoTotal();
                this.V2 = deck1P2.GetPuntosDeVida();
                this.Def2 = deck1P2.ataque;
                this.A2 = deck1P2.defensa;
                this.S2 = deck1P2.sinergia;

                groupBox2.Text = nombre2;
                D1j2.Text = D1j2.Text + "\n" + D2;
                V1J2.Text = V1J2.Text + "\n" + V2;
                A1J2.Text = A1J2.Text + "\n" + Def2;
                Def1J2.Text = Def1J2.Text + "\n" + A2;
                S1J2.Text = S1J2.Text = "\n" + S2;

                groupBox3.Text = nombre2;
                groupBox3.Hide();
            }
            else if (deckJ2 == 2)
            {
                n2 = deck2P2.nombre;
                this.D2 = deck2P2.GetDañoTotal();
                this.V2 = deck2P2.GetPuntosDeVida();
                this.Def2 = deck2P2.ataque;
                this.A2 = deck2P2.defensa;
                this.S2 = deck2P2.sinergia;

                groupBox3.Text = nombre2;
                D2j2.Text = D2j2.Text + "\n" + D2;
                V2J2.Text = V2J2.Text + "\n" + V2;
                A2J2.Text = A2J2.Text + "\n" + Def2;
                Def2J2.Text = Def2J2.Text + "\n" + A2;
                S2J2.Text = S2J2.Text = "\n" + S2;

                groupBox2.Text = nombre2;
                groupBox2.Hide();
            }

        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            Seleeccion_de_Deck sel = new Seleeccion_de_Deck(nombre1, nombre2);
            sel.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (D1 > V2)
            {
                cont1++;
                Res.Text = nombre1 + " vs " + nombre2 + "\nDaño total vs Vida total, Gana: " + nombre1;

            }
            else if (V2 > D1)
            {
                cont2++;
                Res.Text = nombre1 + " vs " + nombre2 + "\nDaño total vs Vida total, Gana: " + nombre2;
            }
            else
            {
                Res.Text = nombre1 + " vs " + nombre2 + "\nDaño total vs Vida total, Empate. ";
            }

            if (A1 > Def2)
            {
                cont1++;
                Res.Text = Res.Text + "\nAtaque vs Defensa, Gana: " + nombre1;
            }
            else if (Def2 > A1)
            {
                cont2++;
                Res.Text = Res.Text + "\nAtaque vs Defensa, Gana: " + nombre2;
            }
            else
            {
                Res.Text = Res.Text + "\nAtaque vs Defensa, Empate";
            }

            //--------------------------------------------------------------------

            if (D2 > V1)
            {
                cont2++;
                Res.Text = Res.Text + "\nVida total vs Daño total, Gana: " + nombre2;
            }
            else if (V1 > D2)
            {
                cont1++;
                Res.Text = Res.Text + "\nVida total vs Daño total, Gana: " + nombre1;
            }
            else
            {
                Res.Text = Res.Text + "\nVida total vs Daño total, Empate";
            }

            if (A2 > Def1)
            {
                cont2++;
                Res.Text = Res.Text + "\nDefensa vs Ataque, Gana: " + nombre2;
            }
            else if (Def1 > A2)
            {
                cont1++;
                Res.Text = Res.Text + "\nDefensa vs Ataque, Gana: " + nombre1;
            }
            else
            {

            }

            //Rompe empates
            if (cont1 == cont2)
            {
                if (S1 > S2)
                {
                    cont1++;
                    Res.Text = Res.Text + "\nSinergia vs Sinergia, Gana: " + nombre1;
                }
                else if (S1 < S2)
                {
                    cont2++;
                    Res.Text = Res.Text + "\nSinergia vs Sinergia, Gana: " + nombre2;
                }
                else
                {

                }
            }

            if (cont1 > cont2)
            {
                Res.Text = Res.Text + "\nEl ganador de la contienda es: " + nombre1 + "\nCon la baraja: " + n1;
            }
            else if (cont2 > cont1)
            {
                Res.Text = Res.Text + "\nEl ganador de la contienda es: " + nombre2 + "\nCon la baraja: " + n2;
            }
        }

        //De aqui en adelante ya anda tiene importancia.
        private void D1j1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void EE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La victoria se consigue no siendo el más fuerte o el más agil, se logra utilizando tus recursos al maximo y con esto lograr seguir avanzando", "Pequeño Easter Egg", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
