using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        //metodo para volver al menu principal
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
            Form1 form1 = new Form1();
            form1.Show();
        }


        //metodo para limpiar los textbox
        private void LimpiarTextBox()
        {
            txtModelo.Text = "";
            txtNroConcesionaria.Text = "";
            txtCantidad.Text = "";
        }

        //arraylist para guardar los pedidos
        ArrayList pedidos = new ArrayList();


        //metodo para enviar el pedido
        private void btnEnviarPedido_Click(object sender, EventArgs e)
        {

            //valiaciones de datos
            if (txtModelo.Text == "" || txtNroConcesionaria.Text == "" || txtCantidad.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                int modelo = Convert.ToInt32(txtModelo.Text);
                int nroConcesionaria = Convert.ToInt32(txtNroConcesionaria.Text);
                int cantidad = Convert.ToInt32(txtCantidad.Text);

                if (modelo < 1 || modelo > 5)
                {
                    MessageBox.Show("El modelo debe ser un numero entero entre 1 y 5");
                }
                else if (nroConcesionaria != 10 && nroConcesionaria != 20 && nroConcesionaria != 30 && nroConcesionaria != 40 && nroConcesionaria != 50)
                {
                    MessageBox.Show("El numero de concesionaria debe ser 10, 20, 30, 40 o 50");
                }
                else if (cantidad < 1)
                {
                    MessageBox.Show("La cantidad debe ser un numero mayor a 0");
                }
                else
                {

                    //instanciar la clase pedido
                    Pedido nuevoPedido = new Pedido();
                    nuevoPedido.modelo = modelo;
                    nuevoPedido.nroConcesionaria = nroConcesionaria;
                    nuevoPedido.cantidad = cantidad;

                    //agregar el pedido al arraylist
                    var pedidosOrdenados = pedidos.Cast<Pedido>().OrderBy(p => p.modelo).ThenBy(p => p.nroConcesionaria).ToList();
                    pedidos.Add(nuevoPedido);

                    //ordenar el arraylist
                    pedidos.Sort(new ComparadorElemento());

                    ActualizarDGVPedido();

                    LimpiarTextBox();
                    MessageBox.Show("Pedido enviado");

                }
            }
        } 

        //metodo para actualizar el data grid view
        public void ActualizarDGVPedido()
        {
            dgvPedidoExitoso.DataSource = null;
            dgvPedidoExitoso.DataSource = pedidos;
        }

        //metodo para guardar el pedido en el archivo de texto
        public void GuardarArchivo()
        {
            //intanciar la clase pedido
            Pedido nuevoPedido = new Pedido();
            TextWriter escribir = new StreamWriter("Pedidos.txt", true);
            escribir.Close();

            foreach (Pedido pedido in pedidos)
            {
                StreamWriter agregar = File.AppendText("Pedidos.txt");
                agregar.WriteLine(pedido.modelo + "|" + pedido.nroConcesionaria + "|" + pedido.cantidad);
                agregar.Close();
            }

            MessageBox.Show("Archivo guardado");
        }

        //metodo para limpiar el archivo de texto
        public void LimpiarArchivo()
        {
            TextWriter escribir = new StreamWriter("Pedidos.txt");
            escribir.Close();
        }

        private void btnGuardarArchivo_Click(object sender, EventArgs e)
        {
            LimpiarArchivo();
            GuardarArchivo();
        }

        //Terminado
    }
}
