using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class D_Venta
    {
        public int idCompra { get; set; }
        public int idPersonaCliente { get; set; }
        public int idPersonaEmpleado { get; set; }
        public decimal subtotal { get; set; }
        public decimal iva { get; set; }
        public decimal total { get; set; }
        public DateTime fecha { get; set; }
        public int status { get; set; }

        public void Insertar()
        {

        }

        public void Mostrar()
        {

        }

        public void Actualizar()
        {

        }

        public void Borrar()
        {

        }
    }
}
