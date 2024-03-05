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
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Final
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        ArrayList pedidos = new ArrayList();
        ArrayList modelos = new ArrayList();

        public void CargarArchivo(string boton)
        {
            //leer el archivo de texto
            string[] lineas = File.ReadAllLines(boton);
            //recorrer el archivo de texto
            foreach (string linea in lineas)
            {
                //separamos los datos por el caracter |
                string[] datos = linea.Split('|');
                Pedido nuevoPedido = new Pedido();
                Modelos nuevoModelo = new Modelos();
                if (boton == "Pedidos.txt")
                {
                    nuevoPedido.modelo = Convert.ToInt32(datos[0]);
                    nuevoPedido.nroConcesionaria = Convert.ToInt32(datos[1]);
                    nuevoPedido.cantidad = Convert.ToInt32(datos[2]);
                    pedidos.Add(nuevoPedido);
                }
                else if (boton == "StockTerminado.txt" || boton == "StockPiezas.txt")
                {
                    nuevoModelo.modelo = Convert.ToInt32(datos[0]);
                    nuevoModelo.descripcion = datos[1];
                    nuevoModelo.cantidad = Convert.ToInt32(datos[2]);
                    modelos.Add(nuevoModelo);
                }
            }
            ActualizarDGVDatos(boton);

        }

        public void ActualizarDGVDatos(string boton)
        {
            if (boton == "Pedidos.txt")
            {
                dgvDatos.DataSource = null;
                dgvDatos.DataSource = pedidos;
            }
            else
            {
                dgvDatos.DataSource = null;
                dgvDatos.DataSource = modelos;
            }
        }

        public void LimpiarCampos()
        {
            txtModelo.Text = "";
            txtDescripcion.Text = "";
            txtNroConcesionaria.Text = "";
            txtCantidad.Text = "";
        }

        private bool ValidarCampos()
        {
            if (txtModelo.Text == "" || txtCantidad.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos");
                return false;
            }
            return true;
        }

        public void EnviarDatos(string archivo)
        {
            if (!ValidarCampos())
            {
                return;
            }

            int modelo = Convert.ToInt32(txtModelo.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Text);

            if (modelo < 1 || modelo > 5)
            {
                MessageBox.Show("El modelo debe ser un número entero entre 1 y 5");
                return;
            }

            if (archivo == "StockTerminado.txt" || archivo == "StockPiezas.txt")
            {
                string descripcion = txtDescripcion.Text;

                //instanciar la clase modelo
                Modelos nuevoModelo = new Modelos();
                nuevoModelo.modelo = modelo;
                nuevoModelo.descripcion = descripcion;
                nuevoModelo.cantidad = cantidad;

                modelos.Add(nuevoModelo);
            }
            else
            {
                //validar que el número de concesionaria sea 10, 20, 30, 40 o 50
                if (!int.TryParse(txtNroConcesionaria.Text, out int concesionaria) || (concesionaria != 10 && concesionaria != 20 && concesionaria != 30 && concesionaria != 40 && concesionaria != 50))
                {
                    MessageBox.Show("El número de concesionaria debe ser 10, 20, 30, 40 o 50");
                    return;
                }

                //validar que la cantidad sea un número mayor a 0
                if (cantidad < 1)
                {
                    MessageBox.Show("La cantidad debe ser un número mayor a 0");
                    return;
                }

                //instanciar la clase pedido
                Pedido nuevoPedido = new Pedido();
                nuevoPedido.modelo = modelo;
                nuevoPedido.nroConcesionaria = concesionaria;
                nuevoPedido.cantidad = cantidad;

                var pedidosOrdenados = pedidos.Cast<Pedido>().OrderBy(p => p.modelo).ThenBy(p => p.nroConcesionaria).ToList();
                //agregar el pedido al arraylist
                pedidos.Add(nuevoPedido);

                //ordenar el arraylist
                pedidos.Sort(new ComparadorElemento());
            }

            ActualizarDGVDatos(archivo);
            LimpiarCampos();
            MessageBox.Show("Pedido enviado");
        }

        public void LimpiarArchivo(string archivo)
        {
            TextWriter escribir = new StreamWriter(archivo);
            escribir.Close();
        }

        public void GuardarArchivo(string archivo)
        {
            //creo el archivo de texto si no existe
            TextWriter escribir = new StreamWriter(archivo, true);
            escribir.Close();

            if (archivo == "Pedidos.txt")
            {
                foreach (Pedido pedido in pedidos)
                {
                    escribir = new StreamWriter(archivo, true);
                    escribir.WriteLine(pedido.modelo + "|" + pedido.nroConcesionaria + "|" + pedido.cantidad);
                    escribir.Close();
                }
            }
            else
            {
                foreach (Modelos modelo in modelos)
                {
                    escribir = new StreamWriter(archivo, true);
                    escribir.WriteLine(modelo.modelo + "|" + modelo.descripcion + "|" + modelo.cantidad);
                    escribir.Close();
                }
            }

            MessageBox.Show("Archivo guardado");
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            string archivo = "Pedidos.txt";
            CargarArchivo(archivo);
        }


        private void btnModelos_Click(object sender, EventArgs e)
        {
            string archivo = "StockTerminado.txt";
            CargarArchivo(archivo);
        }

        private void btnPiezas_Click(object sender, EventArgs e)
        {
            string archivo = "StockPiezas.txt";
            CargarArchivo(archivo);
        }

        private void btnEnviarPedido_Click(object sender, EventArgs e)
        {
            string archivo = "Pedidos.txt";
            EnviarDatos(archivo);
        }

        private void btnEnviarModelo_Click(object sender, EventArgs e)
        {
            string archivo = "StockTerminado.txt";
            EnviarDatos(archivo);
        }

        private void btnEnviarPieza_Click(object sender, EventArgs e)
        {
            string archivo = "StockPiezas.txt";
            EnviarDatos(archivo);
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            txtNroConcesionaria.Enabled = false;
            if (txtDescripcion.Text == "")
            {
                txtNroConcesionaria.Enabled = true;
            }
        }

        private void txtNroConcesionaria_TextChanged(object sender, EventArgs e)
        {
            txtDescripcion.Enabled = false;
            if (txtNroConcesionaria.Text == "")
            {
                txtDescripcion.Enabled = true;
            }
        }

        private void btnAltaPedidos_Click(object sender, EventArgs e)
        {
            LimpiarArchivo("Pedidos.txt");
            GuardarArchivo("Pedidos.txt");
        }
    }
}
