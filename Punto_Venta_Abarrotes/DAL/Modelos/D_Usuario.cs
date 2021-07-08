using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class D_Usuario
    {
        private D_Conexion Conexion = new D_Conexion();

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contrasenia { get; set; }
        public int Status { get; set; }

        public bool Insertar()
        {
            bool sucess = false;

            try
            {
                Conexion.abrir();
                string sql = "INSERT INTO Usuario VALUES ('" + Nombre + "', '";
                sql += Correo + "', '" + Contrasenia + "', " + Status.ToString() + ")";

                var cmd = new SqlCommand(sql, Conexion.conexion);
                var resultado = cmd.ExecuteNonQuery();

                if (resultado == 1)
                {
                    sucess = true;
                }

                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return sucess;
        }

        public DataTable Mostrar()
        {
            var dgvRazonSocial = new DataTable();
            try
            {
                Conexion.abrir();
                string sql = "select idUsuario, nombre, correo, contrasenia, status '%" + Nombre + "%'";

                var cmd = new SqlCommand("SP_BUSQUEDAUSUARIO", Conexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreBuscado", Nombre);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    return null;
                }

                dgvRazonSocial.Load(reader);

                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return dgvRazonSocial;
        }

        public void Actualizar()
        {

        }

        public void Borrar()
        {

        }
    }
}
