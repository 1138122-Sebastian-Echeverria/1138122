using System;
using System.Collections.Generic;
using System.Text;

namespace LabTS11_SEF1138122
{
    //plantilla para la creacion de pokemon
    class Pokemon
    {
        //Atributos de un pokemon
        String nombrePokemon;
        string tipoPokemon;
        string evolucionPokemon;
        int puntosAtaque;
        int nivelPokemon;
        int puntosDefensa;
        int puntosVelocidad;

        //creacion de constructor : debe tener el mismo nombre de la clase
        public Pokemon(String nombrePokemon, string tipoPokemon, string evolucionPokemon, int nivelPokemon, int puntosAtaque, int puntosDefensa, int puntosVelocidad)
        {
            this.nombrePokemon = nombrePokemon;
            this.tipoPokemon = tipoPokemon;
            this.evolucionPokemon = evolucionPokemon;
            this.nivelPokemon = nivelPokemon;
            this.puntosAtaque = puntosAtaque;
            this.puntosDefensa = puntosDefensa;
            this.puntosVelocidad = puntosVelocidad;
        }

        //acciones de los pokemones
        
        //Defensa del pokemon
        public int getPuntosDefensa()
        {
            return this.puntosDefensa;
        }

        //Este es mi nombre
        public string getnombrePokemon()
        {
            return this.nombrePokemon;
        }

        //Tipo de pokemon
        public string getTipoPokemon()
        {
            return this.tipoPokemon;
        }

        public int getPuntosAtaque()
        {
            return this.puntosAtaque;
        }

        //Agregar puntos de ataque + 50
        public void sumarPuntosAtaque()
        {
            this.puntosAtaque = puntosAtaque + 50;
        }

        //Metodo de evolucion
        public void evolucionDePokemon(String nombreEvolucion)
        {
            this.evolucionPokemon = nombreEvolucion;
        }

        public void setNombrePokemon(String nombrePokemon)
        {
            this.nombrePokemon = nombrePokemon;
        }

        public void setTipoPokemon(String Tipo)
        {
            this.tipoPokemon = Tipo;
        }

        public void setevolucionPokemon(String NewEvolucion)
        {
            this.evolucionPokemon = NewEvolucion;
        }

        public void setNuevoNivel(int newNivel)
        {
            this.nivelPokemon = newNivel;
        }

        public void setPuntosAtaque(int Puntos)
        {
            this.puntosAtaque = Puntos;
        }

        public void setPuntosDefensa(int Defensa)
        {
            this.puntosDefensa = Defensa;
        }

        public void setPuntosVelocidad(int newNivel)
        {
            this.nivelPokemon = newNivel;
        }
    }
}
