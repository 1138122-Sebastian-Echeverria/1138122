using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace P_SEF1138122_LC1088821
{
    public partial class Seleeccion_de_Deck : Form
    {
        string nombre1;
        string nombre2;
        int deck1;
        int deck2;
        string sub = "";
        

        public Seleeccion_de_Deck(string nombre1, string nombre2)
        {
            InitializeComponent();
            this.nombre1 = nombre1;
            this.nombre2 = nombre2;

            groupBox1.Text = nombre1;
            groupBox2.Text = nombre2;

            //Primer Mazo
            Deck deck1P1 = new Deck("Torre del Noble");
            deck1P1.Cartas[2] = new Carta("Gigante Noble", 3072, 307);
            deck1P1.Cartas[6] = new Carta("Torre infernal", 1749, 1113.5);
            deck1P1.Cartas[4] = new Carta("Valkiria", 1908, 178);
            deck1P1.Cartas[7] = new Carta("Mago", 720, 281);
            deck1P1.Cartas[1] = new Carta("Zap!", 0, 192);
            deck1P1.Cartas[3] = new Carta("Bola de fuego", 0, 689);
            deck1P1.Cartas[0] = new Carta("Murcielagos", 405, 405);
            deck1P1.Cartas[5] = new Carta("Ariete de batalla", 2251, 670);
            deck1P1.ataque = 7.0;
            deck1P1.defensa = 10.0;
            deck1P1.sinergia = 6.0;

            string[] Subs = deck1P1.Cartas[0].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label1.Text = sub;

            Subs = deck1P1.Cartas[1].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label2.Text = sub;

            Subs = deck1P1.Cartas[2].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label3.Text = sub;

            Subs = deck1P1.Cartas[3].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label4.Text = sub;

            Subs = deck1P1.Cartas[4].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label5.Text = sub;

            Subs = deck1P1.Cartas[5].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label6.Text = sub;

            Subs = deck1P1.Cartas[6].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label7.Text = sub;

            Subs = deck1P1.Cartas[7].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label8.Text = sub;

            //Segundo Mazo
            Deck deck2P1 = new Deck("Defensiva Barbara");
            deck2P1.Cartas[7] = new Carta("Monta Puercos", 1696, 318);
            deck2P1.Cartas[1] = new Carta("Arqueras", 608, 214);
            deck2P1.Cartas[3] = new Carta("Mortero", 1396, 266);
            deck2P1.Cartas[0] = new Carta("Zap!", 0, 192);
            deck2P1.Cartas[6] = new Carta("Mini Pekka", 1361, 720);
            deck2P1.Cartas[5] = new Carta("Bola de fuego", 0, 689);
            deck2P1.Cartas[4] = new Carta("Barbaros", 3350, 960);
            deck2P1.Cartas[2] = new Carta("Banda de duendes", 1005, 603);
            deck2P1.ataque = 8.0;
            deck2P1.defensa = 10.0;
            deck2P1.sinergia = 9.2;

            Subs = deck2P1.Cartas[0].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label9.Text = sub;

            Subs = deck2P1.Cartas[1].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label10.Text = sub;

            Subs = deck2P1.Cartas[2].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label11.Text = sub;

            Subs = deck2P1.Cartas[3].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label12.Text = sub;

            Subs = deck2P1.Cartas[4].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label13.Text = sub;

            Subs = deck2P1.Cartas[5].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label14.Text = sub;

            Subs = deck2P1.Cartas[6].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label15.Text = sub;

            Subs = deck2P1.Cartas[7].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label16.Text = sub;

            //Tercer Mazo
            Deck deck1P2 = new Deck("La venganza del noble");
            deck1P2.Cartas[5] = new Carta("Bandida", 907, 387);
            deck1P2.Cartas[1] = new Carta("Bola de fuego", 0, 689);
            deck1P2.Cartas[4] = new Carta("Rey Fantasma", 1210, 261);
            deck1P2.Cartas[7] = new Carta("Arquero mágico", 532, 134);
            deck1P2.Cartas[3] = new Carta("Pekka", 3760, 816);
            deck1P2.Cartas[2] = new Carta("Ariete de batalla", 911, 265);
            deck1P2.Cartas[0] = new Carta("Zap!", 0, 192);
            deck1P2.Cartas[6] = new Carta("Mago eléctrico", 713, 225);
            deck1P2.ataque = 10.0;
            deck1P2.defensa = 10.0;
            deck1P2.sinergia = 7.8;

            Subs = deck1P2.Cartas[0].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label17.Text = sub;

            Subs = deck1P2.Cartas[1].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label18.Text = sub;

            Subs = deck1P2.Cartas[2].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label19.Text = sub;

            Subs = deck1P2.Cartas[3].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label20.Text = sub;

            Subs = deck1P2.Cartas[4].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label21.Text = sub;

            Subs = deck1P2.Cartas[5].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label22.Text = sub;

            Subs = deck1P2.Cartas[6].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label23.Text = sub;

            Subs = deck1P2.Cartas[7].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label24.Text = sub;

            //Cuarto Mazo
            Deck deck2P2 = new Deck("Las tierras oscuras");
            deck2P2.Cartas[4] = new Carta("Bandida", 907, 193);
            deck2P2.Cartas[2] = new Carta("Bola de fuego", 689, 207);
            deck2P2.Cartas[3] = new Carta("Gigante", 4091, 254);
            deck2P2.Cartas[7] = new Carta("Cementerio", 1539, 1539);
            deck2P2.Cartas[6] = new Carta("Bruja Nocturna", 1069, 476);
            deck2P2.Cartas[0] = new Carta("Esqueletos", 243, 243);
            deck2P2.Cartas[1] = new Carta("Zap!", 0, 192);
            deck2P2.Cartas[5] = new Carta("Mago Eléctrico", 713, 225);
            deck2P2.ataque = 9.2;
            deck2P2.defensa = 8.0;
            deck2P2.sinergia = 10.0;

            
            Subs = deck2P2.Cartas[0].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label25.Text = sub;
            
            Subs = deck2P2.Cartas[1].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label26.Text = sub;

            Subs = deck2P2.Cartas[2].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label27.Text = sub;

            Subs = deck2P2.Cartas[3].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label28.Text = sub;

            Subs = deck2P2.Cartas[4].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label29.Text = sub;

            Subs = deck2P2.Cartas[5].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label30.Text = sub;

            Subs = deck2P2.Cartas[6].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label31.Text = sub;

            Subs = deck2P2.Cartas[7].nombre.Split(' ');
            sub = Subs[0];
            for (int i = 1; i < Subs.Length; i++)
            {
                sub = sub + "\n" + Subs[i];
            }
            label32.Text = sub;

            //Se agrega el numero de cada total y estrategias
            D1j1.Text = D1j1.Text + "\n" + deck1P1.GetDañoTotal();
            V1J1.Text = V1J1.Text + "\n" + deck1P1.GetPuntosDeVida();
            A1J1.Text = A1J1.Text + "\n" + deck1P1.ataque;
            Def1J1.Text = Def1J1.Text + "\n" + deck1P1.defensa;
            S1J1.Text = S1J1.Text + "\n" + deck1P1.sinergia;

            D2j1.Text = D2j1.Text + "\n" + deck2P1.GetDañoTotal();
            V2J1.Text = V2J1.Text + "\n" + deck2P1.GetPuntosDeVida();
            A2J1.Text = A2J1.Text + "\n" + deck2P1.ataque;
            Def2J1.Text = Def2J1.Text + "\n" + deck2P1.defensa;
            S2J1.Text = S2J1.Text + "\n" + deck2P1.sinergia;

            D1j2.Text = D1j2.Text + "\n" + deck1P2.GetDañoTotal();
            V1J2.Text = V1J2.Text + "\n" + deck1P2.GetPuntosDeVida();
            A1J2.Text = A1J2.Text + "\n" + deck1P2.ataque;
            Def1J2.Text = Def1J2.Text + "\n" + deck1P2.defensa;
            S1J2.Text = S1J2.Text + "\n" + deck1P2.sinergia;

            D2j2.Text = D2j2.Text + "\n" + deck2P2.GetDañoTotal();
            V2J2.Text = V2J2.Text + "\n" + deck2P2.GetPuntosDeVida();
            A2J2.Text = A2J2.Text + "\n" + deck2P2.ataque;
            Def2J2.Text = Def2J2.Text + "\n" + deck2P2.defensa;
            S2J2.Text = S2J2.Text + "\n" + deck2P2.sinergia;

            Deck1J1.Text = deck1P1.nombre;
            Deck2J1.Text = deck2P1.nombre;
            Deck1J2.Text = deck1P2.nombre;
            Deck2J2.Text = deck2P2.nombre;



            int puntosP1_1 = 0;
            int puntosP1_2 = 0;

            if (deck1P1.GetDañoTotal() > deck2P1.GetDañoTotal())
            {
                puntosP1_1++;
            }
            else if (deck1P1.GetDañoTotal() < deck2P1.GetDañoTotal())
            {
                puntosP1_2++;
            }
            else
            {

            }
            


            if (deck1P1.GetPuntosDeVida() > deck2P1.GetPuntosDeVida())
            {
                puntosP1_1++;
            }
            else if (deck1P1.GetPuntosDeVida() < deck2P1.GetPuntosDeVida())
            {
                puntosP1_2++;
            }
            else
            {

            }


            if (deck1P1.defensa > deck2P1.defensa)
            {
                puntosP1_1++;
            }
            else if (deck1P1.defensa < deck2P1.defensa)
            {
                puntosP1_2++;
            }
            else
            {

            }


            if (deck1P1.ataque > deck2P1.ataque)
            {
                puntosP1_1++;
            }
            else if(deck1P1.ataque < deck2P1.ataque)
            {
                puntosP1_2++;
            }
            else
            {

            }


            if (deck1P1.sinergia > deck2P1.sinergia)
            {
                puntosP1_1++;
            }
            else if (deck1P1.sinergia < deck2P1.sinergia)
            {
                puntosP1_2++;
            }
            else
            {

            }

            if (puntosP1_1 > puntosP1_2)
            {
                HintP1.Text = "La mejor baraja es la baraja\n" + deck1P1.nombre + "\nYa que esta gana con una puntuacion de\n" + puntosP1_1 + " - " + puntosP1_2 + "\nEn cantidad de estrategias";
            }
            else
            {
                HintP1.Text = "La mejor baraja es la baraja\n" + deck2P1.nombre + "\nYa que esta gana con una puntuacion de\n" + puntosP1_2 + " - " + puntosP1_1 + "\nEn cantidad de estrategias";
            }

            //-----------------------------------------------------------------------------------------------------

            int puntosP2_1 = 0;
            int puntosP2_2 = 0;

            if (deck1P2.GetDañoTotal() > deck2P2.GetDañoTotal())
            {
                puntosP2_1++;
            }
            else if (deck1P2.GetDañoTotal() < deck2P2.GetDañoTotal())
            {
                puntosP2_2++;
            }
            else
            {

            }


            if (deck1P2.GetPuntosDeVida() > deck2P2.GetPuntosDeVida())
            {
                puntosP2_1++;
            }
            else if (deck1P2.GetPuntosDeVida() < deck2P2.GetPuntosDeVida())
            {
                puntosP2_2++;
            }
            else
            {

            }


            if (deck1P2.defensa > deck2P2.defensa)
            {
                puntosP2_1++;
            }
            else if(deck1P2.defensa < deck2P2.defensa)
            {
                puntosP2_2++;
            }
            else
            {

            }


            if (deck1P2.ataque > deck2P2.ataque)
            {
                puntosP1_1++;
            }
            else if (deck1P2.ataque < deck2P2.ataque)
            {
                puntosP2_2++;
            }
            else
            {

            }


            if (deck1P2.sinergia > deck2P2.sinergia)
            {
                puntosP2_1++;
            }
            else if (deck1P2.sinergia < deck2P2.sinergia)
            {
                puntosP2_2++;
            }
            else
            {

            }

            if (puntosP2_1 > puntosP2_2)
            {
                HintP2.Text = "La mejor baraja es la baraja\n" + deck1P2.nombre + "\nYa que esta gana con una puntuacion de\n" + puntosP2_1 + " - " + puntosP2_2 + "\nEn cantidad de estrategias";
            }
            else
            {
                HintP2.Text = "La mejor baraja es la baraja\n" + deck2P2.nombre + "\nYa que esta gana con una puntuacion de\n" + puntosP2_2 + " - " + puntosP2_1 + "\nEn cantidad de estrategias";
            }

        }


        private void Regreso_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Deck1J1.Checked == false && Deck2J1.Checked == false || Deck1J2.Checked == false && Deck2J2.Checked == false)
            {
                MessageBox.Show("Ambos seleccionen una baraja porfavor", "Pequeño error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Deck1J1.Checked == true)
                {
                    deck1 = 1;
                }
                else if (Deck2J1.Checked == true)
                {
                    deck1 = 2;
                }

                if (Deck1J2.Checked == true)
                {
                    deck2 = 1;
                }
                else if (Deck2J2.Checked == true)
                {
                    deck2 = 2;
                }

                Pelea pelea = new Pelea(nombre1, nombre2, deck1, deck2);
                pelea.Show();
                Hide();
            }

            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
