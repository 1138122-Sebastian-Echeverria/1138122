using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_SEF1138122
{
    internal class Empleados
    {
        private string nombreEmpleado;
        private double salario;
        private string turno = "Mañana";

        public Empleados()
        {
            nombreEmpleado = "";
            salario = 0;
        }

        public void Cargar(string nombre, double salario, string turno)
        {
            this.nombreEmpleado = nombre;
            this.salario = salario;
            this.turno = turno;
        }

        public double ObtenerSalario()
        {
            return this.salario;
        }

        public string ObtenerTurno()
        {
            return this.turno;
        }

        public String toString()
        {
            return "[ Nombre: " + nombreEmpleado + "\n" +
                "Salario: " + salario + "\n" +
                "Turno: " + turno + "]";
        }
    }
}
