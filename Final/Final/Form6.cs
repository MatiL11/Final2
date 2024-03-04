using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Final
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        ArrayList pedidos = new ArrayList();

        public void CargarArchivo(string boton)
        {
            string archivo = boton;
            //leemos el archivo de texto
            string[] lineas = File.ReadAllLines(archivo);
            //recorremos el archivo de texto
            foreach (string linea in lineas)
            {
                //separamos los datos por el caracter |
                string[] datos = linea.Split('|');
                Pedido nuevoPedido = new Pedido();
                Modelos nuevoModelo = new Modelos();
                nuevoPedido.modelo = Convert.ToInt32(datos[0]);
                if (boton == "Pedidos.txt")
                {
                    nuevoPedido.nroConcesionaria = Convert.ToInt32(datos[1]);
                }
                else
                {
                    nuevoModelo.descripcion = datos[1];
                }
                nuevoPedido.cantidad = Convert.ToInt32(datos[2]);
                pedidos.Add(nuevoPedido);
            }

            ActualizarDGVDatos();
        }

        public void ActualizarDGVDatos()
        {
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = pedidos;
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            string boton = "Pedidos.txt";
            CargarArchivo(boton);
        }

        private void btnModelos_Click(object sender, EventArgs e)
        {
            string boton = "StockTerminado.txt";
            CargarArchivo(boton);
        }

        private void btnPiezas_Click(object sender, EventArgs e)
        {
            string boton = "StockPiezas.txt";
            CargarArchivo(boton);
        }
    }
}
