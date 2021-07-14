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
        #region Objeto conexión

        private D_Conexion Conexion = new D_Conexion();

        #endregion

        #region Propiedades

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contrasenia { get; set; }
        public int Status { get; set; }

        #endregion

        #region Método para insertar

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

        #endregion

        #region Método para mostrar

        public DataTable Mostrar()
        {
            var tablaMostrarUsuario = new DataTable();

            try
            {
                Conexion.abrir();

                var cmd = new SqlCommand("SP_MOSTRARUSUARIOS", Conexion.conexion);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    reader.Close();
                    return null;
                }
                tablaMostrarUsuario.Load(reader);

                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaMostrarUsuario;
        }

        #endregion

        #region Método para buscar

        public DataTable Buscar()
        {
            var tablaBuscarUsuario = new DataTable();

            try
            {
                Conexion.abrir();

                var cmd = new SqlCommand("SP_BUSCARUSUARIO", Conexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    return null;
                }
                tablaBuscarUsuario.Load(reader);

                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaBuscarUsuario;
        }

        #endregion

        #region Método para actualizar 

        public void Actualizar()
        {

        }

        #endregion
    }
}
