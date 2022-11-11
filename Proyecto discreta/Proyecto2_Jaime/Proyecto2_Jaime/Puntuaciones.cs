using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2_Jaime
{
    internal class Puntuaciones
    {
        public string nombreCompleto;
        public int carnet;
        public string carrera;
        public int puntos = 0;

        public Puntuaciones(string nombre, int carnet, string Carrera, int puntos)
        {
            this.nombreCompleto = nombre;
            this.carnet = carnet;
            this.carrera = Carrera;
            this.puntos = puntos;
        }

        public int Suma(int a)
        {
            puntos = puntos + a;

            return puntos;
        }

       public String toString()
       {
            return "- Nombre: " + this.nombreCompleto + 
                " \n- Carnet: " + this.carnet + "\n- Carrera: " + 
                this.carrera + "\n- Puntuacion: " + 
                this.puntos;
        }
    }
}
