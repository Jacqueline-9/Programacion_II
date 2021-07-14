using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class D_Empleados
    {
        private D_Conexion Conexion = new D_Conexion();
        public D_Usuario dUsuario = new D_Usuario();
        public D_Persona dPersona = new D_Persona();

        public int IdPersonaEmpleado { get; set; }
        public int IdPuesto { get; set; }
        public int IdUsuario { get; set; }
        public string Rfc { get; set; }
        public int Status { get; set; }

        public DataTable validarUsuario()
        {
            var tablaValidarUsuario = new DataTable();

            try
            {
                Conexion.abrir();

                var cmd = new SqlCommand("SP_USUARIOS", Conexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreUser", dUsuario.Nombre);
                cmd.Parameters.AddWithValue("@Contrasenia", dUsuario.Contrasenia);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    return null;
                }
                tablaValidarUsuario.Load(reader);

                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaValidarUsuario;
        }

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
