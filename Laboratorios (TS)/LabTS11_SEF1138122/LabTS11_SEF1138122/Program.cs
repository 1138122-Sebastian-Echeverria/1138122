using System;

namespace LabTS11_SEF1138122
{
    class Program
    {
        static void Main(string[] args)
        {
            // creacion de un pokemon
            Pokemon pokemon = new Pokemon("Pikachu", "Electrico", "Raichu", 41, 24, 18, 35);

            Console.WriteLine("Mi nombre es:  " + pokemon.getnombrePokemon());
            Console.WriteLine("Mi tipo es:  " + pokemon.getTipoPokemon());
            Console.WriteLine("Mi poder de ataque es de:  " + pokemon.getPuntosAtaque());
            pokemon.sumarPuntosAtaque();
            Console.WriteLine("Mi poder despues del ataque:  " + pokemon.getPuntosAtaque());
            Console.WriteLine("Mi poder de defensa es de:  " + pokemon.getPuntosDefensa());
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

            Pokemon pokemon1 = new Pokemon("Charmander", "Fuego", "Charmander", 41, 35, 24, 18);

            Console.WriteLine("Mi nombre es:  " + pokemon1.getnombrePokemon());
            Console.WriteLine("Mi tipo es:  " + pokemon1.getTipoPokemon());
            Console.WriteLine("Mi poder de ataque es de:  " + pokemon1.getPuntosAtaque());
            pokemon.sumarPuntosAtaque();
            Console.WriteLine("Mi poder despues del ataque:  " + pokemon1.getPuntosAtaque());
            Console.WriteLine("Mi poder de defensa es de:  " + pokemon1.getPuntosDefensa());

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

            pokemon.setNombrePokemon("Raichu");
            pokemon.setTipoPokemon("Electrico");
            pokemon.setevolucionPokemon("Null");
            pokemon.setNuevoNivel(74);
            pokemon.setPuntosAtaque(54);
            pokemon.setPuntosDefensa(34);
            pokemon.setPuntosVelocidad(48);


            Console.WriteLine("Mi nombre es:  " + pokemon.getnombrePokemon());
            Console.WriteLine("Mi tipo es:  " + pokemon1.getTipoPokemon());
            Console.WriteLine("Mi poder de ataque es de:  " + pokemon.getPuntosAtaque());
            pokemon.sumarPuntosAtaque();
            Console.WriteLine("Mi poder despues del ataque:  " + pokemon.getPuntosAtaque());
            Console.WriteLine("Mi poder de defensa es de:  " + pokemon.getPuntosDefensa());

            Console.ReadLine();
        }
    }
}
