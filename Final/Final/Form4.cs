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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        ArrayList modelos = new ArrayList();

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            LimpiarArchivo();
            GuardarArchivo();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            BajaPedido();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //valiaciones de datos
            if (txtModelo.Text == "" || txtDescripcion.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                int nroModelo = Convert.ToInt32(txtModelo.Text);
                string descripcion = txtDescripcion.Text;
                Random random = new Random();
                int cantidad = random.Next(1, 51);

                if (nroModelo < 1 || nroModelo > 5)
                {
                    MessageBox.Show("El modelo debe ser un numero entero entre 1 y 5");
                }
                else
                {

                    //instanciar la clase pedido
                    Modelos nuevoModelo = new Modelos();
                    nuevoModelo.modelo = nroModelo;
                    nuevoModelo.descripcion = descripcion;
                    nuevoModelo.cantidad = cantidad;

                    //agregar el pedido al arraylist
                    modelos.Add(nuevoModelo);

                    ActualizarDGVPedido();

                    LimpiarCampos();
                    MessageBox.Show("Pedido enviado");

                }
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CargarArchivo();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
        }


        public void GuardarArchivo()
        {
            //Creo el archivo de texto
            TextWriter escribir = new StreamWriter("StockTerminado.txt", true);
            escribir.Close();


            foreach (Modelos modelo in modelos)
            {
                StreamWriter agregar = File.AppendText("StockTerminado.txt");
                agregar.WriteLine(modelo.modelo + "|" + modelo.descripcion + "|" + modelo.cantidad);
                agregar.Close();
            }

            MessageBox.Show("Archivo guardado");
        }

        public void LimpiarArchivo()
        {
            TextWriter escribir = new StreamWriter("StockTerminado.txt");
            escribir.Close();
        }

        public void ActualizarDGVPedido()
        {
            dgvPedido.DataSource = null;
            dgvPedido.DataSource = modelos;
        }

        private void LimpiarCampos()
        {
            txtModelo.Text = "";
            txtDescripcion.Text = "";
        }


        public void BajaPedido()
        {
            //seleccionamos el pedido que queremos dar de baja
            Modelos pedido = (Modelos)dgvPedido.CurrentRow.DataBoundItem;
            modelos.Remove(pedido);
            ActualizarDGVPedido();
        }

        public void ModificarPedido()
        {
            //seleccionamos el pedido que queremos modificar
            Modelos pedido = (Modelos)dgvPedido.CurrentRow.DataBoundItem;

            //modificamos el pedido
            pedido.modelo = Convert.ToInt32(txtModelo.Text);
            pedido.descripcion = txtDescripcion.Text;
            Random random = new Random();
            pedido.cantidad = random.Next(1, 51);

            ActualizarDGVPedido();

            LimpiarCampos();

        }

        //metodo para validar los campos
        public void ValidarCampos()
        {
            if (txtModelo.Text == "" || txtDescripcion.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                int nroModelo = Convert.ToInt32(txtModelo.Text);

                if (nroModelo < 1 || nroModelo > 5)
                {
                    MessageBox.Show("El modelo debe ser un numero entero entre 1 y 5");
                }
                else
                {
                    ModificarPedido();
                }
            }
        }



        public void CargarArchivo()
        {
            //leemos el archivo de texto
            string[] lineas = File.ReadAllLines("StockTerminado.txt");
            //recorremos el archivo de texto
            foreach (string linea in lineas)
            {
                //separamos los datos por el caracter |
                string[] datos = linea.Split('|');
                Modelos nuevoModelo = new Modelos();
                nuevoModelo.modelo = Convert.ToInt32(datos[0]);
                nuevoModelo.descripcion = datos[1];
                nuevoModelo.cantidad = Convert.ToInt32(datos[2]);
                modelos.Add(nuevoModelo);
            }

            ActualizarDGVPedido();
        }


    }
}
