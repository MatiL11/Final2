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
    public partial class PanelComposiciones : Form
    {
        public PanelComposiciones()
        {
            InitializeComponent();
        }

        ArrayList compos = new ArrayList();

        private bool ValidarCampos()
        {
            if (txtModelo.Text == "" || txtPieza.Text == "" || txtCantidad.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos");
                return false;
            }
            return true;
        }

        public void EnviarDatos()
        {
            if (!ValidarCampos())
            {
                return;
            }

            int modelo = Convert.ToInt32(txtModelo.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int pieza = Convert.ToInt32(txtPieza.Text);


            if (modelo < 1 || modelo > 5)
            {
                MessageBox.Show("El modelo debe ser un número entero entre 1 y 5");
                return;
            }
            else if (pieza < 1 || pieza > 5)
            {
                MessageBox.Show("La pieza debe ser un número entero entre 1 y 5");
                return;
            }
            
            Composiciones composicion = new Composiciones();
            composicion.modelo = modelo;
            composicion.pieza = pieza;
            composicion.cantidad = cantidad;

            compos.Add(composicion);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            EnviarDatos();
        }
    }
}
