using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_SEF1138122.Clases
{
    internal class Empleado
    {
        private string nombreEmpleado;
        private double salario;
        private string turno = "Mañana";

        public Empleado()
        {
            nombreEmpleado = "";
            salario = 0;
        }

        public void Cargar(string nombre, double salario)
        {
           this.nombreEmpleado = nombre;
           this.salario = salario;
        }

        public double ObtenerSalario()
        {
            return this.salario;
        }

        public string ObtenerTurno()
        {
            return this.turno;
        }

    }
}
