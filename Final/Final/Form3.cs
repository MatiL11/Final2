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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        ArrayList pedidos = new ArrayList();

        //metodo para cargar el archivo de texto
        public void CargarArchivo()
        {
            //leemos el archivo de texto
            string[] lineas = File.ReadAllLines("Pedidos.txt");
            //recorremos el archivo de texto
            foreach (string linea in lineas)
            {
                //separamos los datos por el caracter |
                string[] datos = linea.Split('|');
                Pedido nuevoPedido = new Pedido();
                nuevoPedido.modelo = Convert.ToInt32(datos[0]);
                 nuevoPedido.nroConcesionaria = Convert.ToInt32(datos[1]);
                nuevoPedido.cantidad = Convert.ToInt32(datos[2]);
                pedidos.Add(nuevoPedido);
            }

            //actualizamos el datagridview
            dgvPedidos.DataSource = null;
            dgvPedidos.DataSource = pedidos;
         }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            CargarArchivo();
        }

        //metodo para dar de baja un pedido
        public void BajaPedido()
        {
            //seleccionamos el pedido que queremos dar de baja
            Pedido pedido = (Pedido)dgvPedidos.CurrentRow.DataBoundItem;
            pedidos.Remove(pedido);
            //actualizamos el datagridview
            dgvPedidos.DataSource = null;
            dgvPedidos.DataSource = pedidos;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            BajaPedido();
        }

        //metodo para modificar un pedido
        public void ModificarPedido()
        {
            //seleccionamos el pedido que queremos modificar
            Pedido pedido = (Pedido)dgvPedidos.CurrentRow.DataBoundItem;

            //modificamos el pedido
            pedido.modelo = Convert.ToInt32(txtModelo.Text);
            pedido.nroConcesionaria = Convert.ToInt32(txtNroConcesionaria.Text);
            pedido.cantidad = Convert.ToInt32(txtCantidad.Text);


            //ordenamos el arraylist
            pedidos.Sort(new ComparadorElemento());
            

            //actualizamos el datagridview
            dgvPedidos.DataSource = null;
            dgvPedidos.DataSource = pedidos;

            LimpiarCampos();
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarPedido();
        }

        //metodo para limpiar los campos
        public void LimpiarCampos()
        {
            txtModelo.Text = "";
            txtNroConcesionaria.Text = "";
            txtCantidad.Text = "";
        }
    }
}
