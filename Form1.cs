﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._1Listas_simples_Ordenadas
{
    public partial class Form1 : Form
    {
        Inventario inventario;

        public Form1()
        {
            InitializeComponent();
            Inventario inventario = new Inventario();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtCosto.Text));
            inventario.Agregar(producto);
            txtCodigo.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            if (inventario.Buscar(codigo) != null)
            {
                txtInventario.Text = inventario.Buscar(codigo).NombreProducto;
            }
            else
            {
                txtInventario.Clear();
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            txtInventario.Text = inventario.Reporte();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            inventario.Eliminar(Convert.ToInt32(txtCodigo.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
