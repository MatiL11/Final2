using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        //public void CargarArchivo()
        //{
        //    string[] lineas = File.ReadAllLines("Pedidos.txt");
        //    foreach (string linea in lineas)
        //    {
        //        string[] datos = linea.Split('|');
        //        Pedido nuevoPedido = new Pedido();
        //        nuevoPedido.modelo = Convert.ToInt32(datos[0]);
        //        nuevoPedido.nroConcesionaria = Convert.ToInt32(datos[1]);
        //        nuevoPedido.cantidad = Convert.ToInt32(datos[2]);
        //        pedidos.Add(nuevoPedido);
        //    }
        //    dgvPedidoExitoso.DataSource = null;
        //    dgvPedidoExitoso.DataSource = pedidos;
        //}

    }
}
