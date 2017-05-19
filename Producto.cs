using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1Listas_simples_Ordenadas
{
    class Producto
    {
        public String NombreProducto { private set; get; }
        public int CodigoProducto { private set; get; }
        public double CostoUnitarioProducto { set; get; }
        public int CantidadProducto { set; get; }
        public Producto sig { set; get; }


        public Producto(int codigo, string nombre, double costo, int cantidad)
        {
            this.CodigoProducto = codigo;
            this.NombreProducto = nombre;
            this.CostoUnitarioProducto = costo;
            this.CantidadProducto = cantidad;

        }

        public override string ToString()

        {
            string mostrar = "" + CodigoProducto + " " + NombreProducto + " " + CostoUnitarioProducto + " " + CantidadProducto;
            return mostrar;
        }
    }
}
