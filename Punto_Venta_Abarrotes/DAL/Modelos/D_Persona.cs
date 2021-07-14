using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class D_Persona
    {
        private D_Conexion Conexion = new D_Conexion();

        public int idPersona { get; set; }
        public string nombre { get; set; }
        public string apPaterno { get; set; }
        public string apMaterno { get; set; }
        public DateTime fechaNac { get; set; }
        public string telefono { get; set; }
        public int idDomicilio { get; set; }

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
