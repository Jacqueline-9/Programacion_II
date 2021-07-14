using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_DetalleVentaProductos
    {
        private D_Conexion Conexion = new D_Conexion();

        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }

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
