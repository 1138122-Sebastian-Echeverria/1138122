using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_SEF1138122
{
    public class Cancion
    {
        public string nombreCancion;
        public int duracionCancion;
        public string generoCancion;
        public string compositor;
        public string cantautor;

        public Cancion(string nombreCancion, int duracionCancion, string generoCancion, string compositor, string cantautor)
        {
            this.nombreCancion = nombreCancion;
            this.duracionCancion = duracionCancion;
            this.generoCancion = generoCancion;
            this.compositor = compositor;
            this.cantautor = cantautor;
        }

        public String toString()
        {
            return "Canción: [ n: " + this.nombreCancion + " - c: " + this.cantautor + " - d: " + this.duracionCancion + " - CC: " + this.compositor + " - g: " + this.generoCancion + " ]";
        }
    }
}
