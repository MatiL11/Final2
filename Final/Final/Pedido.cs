using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class Pedido
    {
        //propiedades definidas para trasladar informacion
        public int modelo { get; set; }
        public int nroConcesionaria { get; set; }
        public int cantidad { get; set; }

        //metodo para concatenar informacion
        public string pedidoListo(int modelo, int nroConcecionaria, int cantidad)
        {
            return "Modelo: " + modelo + "|" + "Concesionaria: " + nroConcesionaria + "|" + "Cantidad: " + cantidad;
        }
    }
}
