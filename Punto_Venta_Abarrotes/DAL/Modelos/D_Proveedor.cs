using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class D_Proveedor
    {
        private D_Conexion Conexion = new D_Conexion();

        public int idProveedor { get; set; }
        public string razonSocial { get; set; }
        public string telefono { get; set; }
        public int idDomicilio { get; set; }
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
