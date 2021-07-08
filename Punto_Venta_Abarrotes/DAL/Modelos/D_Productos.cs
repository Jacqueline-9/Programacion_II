using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class D_Productos
    {
        private D_Conexion Conexion = new D_Conexion();

        public int idProducto { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public decimal contenidoNeto { get; set; }
        public int idUnidad { get; set; }
        public int existencia { get; set; }
        public DateTime fechaCaducidad { get; set; }
        public int idTipo { get; set; }
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
