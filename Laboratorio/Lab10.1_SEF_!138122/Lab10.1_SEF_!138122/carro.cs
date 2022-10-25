using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10._1_SEF__138122
{
    internal class carro
    {
        private string Marca = "";
        private int modelo = 0;
        private double precio = 0;
        private string descripcion = "";
        private double IVA = 0;

        public void SetMarca(string marca)
        {
            if (marca != null && marca != "")
            {
                this.Marca = marca;
            }
        }

        public void SetModelo(int modelo)
        {
            this.modelo = modelo;
        }

        public void SetPrecio(double precio)
        {
            this.precio = precio;
        }

        public void SetDescripcion(string desc)
        {
            this.descripcion = desc;
        }

        public void SetIVA(double iva)
        {
            this.IVA = iva;
        }

        public string LeerMarca()
        {
            return this.Marca;
        }

        public int LeerModelo()
        {
            return this.modelo;
        }

        public double LeerPrecio()
        {
            return this.precio;
        }

        public string LeerDescr()
        {
            return this.descripcion;
        }

        public double LeerPF()
        {
            return this.precio + (IVA * precio);
        }
    }
}
