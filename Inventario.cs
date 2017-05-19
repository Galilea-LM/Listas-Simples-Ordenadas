using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1Listas_simples_Ordenadas
{
    class Inventario
    {
        Producto inicio;
        Producto temp;

        
        public Inventario()
        {
            inicio = null;
        }

        public void Agregar(Producto producto)
        {
            bool va = true;
            if (inicio == null)
            {
                inicio = producto;
            }
            else
            {
                temp = inicio;
                while (temp.sig != null)
                {
                    if (temp.CodigoProducto == producto.CodigoProducto)
                    {
                        va = false;
                    }
                    temp = temp.sig;
                }
                if (temp.CodigoProducto != producto.CodigoProducto && va)
                {
                    temp = inicio;
                    if (producto.CodigoProducto < temp.CodigoProducto)
                    {
                        producto.sig = temp;
                        inicio = producto;
                    }
                    else
                    {
                        va = true;
                        while (temp.sig != null)
                        {
                            if (producto.CodigoProducto < temp.sig.CodigoProducto)
                            {
                                producto.sig = temp.sig;
                                temp.sig = producto;
                                va = false;
                                break;
                            }
                            temp = temp.sig;
                        }
                        if (va)
                        {
                            temp.sig = producto;
                        }
                    }
                }
            }
        }
            
         public void Eliminar(int codigo)
        {
            temp = inicio;
            if (temp.CodigoProducto == codigo)
            {
                inicio = temp.sig;
            }
            else
            {
                while (temp.sig != null)
                {
                    if (temp.sig.CodigoProducto == codigo)
                    {
                        if (temp.sig.sig == null)
                        {
                            temp.sig = null;
                        }
                        else
                        {
                            temp.sig = temp.sig.sig;
                        }
                    }
                    if (temp.sig != null)
                    {
                        temp = temp.sig;
                    }
                }
            }
        }


        public Producto Buscar(int codigo)
        {
            temp = inicio;
            Producto producto = null;
            while (temp != null)
            {
                if (temp.CodigoProducto == codigo)
                {
                    producto = temp;
                }
                temp = temp.sig;
            }
            return producto;
        }

        public string Reporte()
        {
            String datos = "";
            temp = inicio;
            while (temp != null)
            {
                datos += temp.ToString() + Environment.NewLine;
                temp = temp.sig;
            }
            return datos;
        }

    }
}



