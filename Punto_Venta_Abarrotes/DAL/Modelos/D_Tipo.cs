using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class D_Tipo
    {
        #region Objeto conexión

        private D_Conexion Conexion = new D_Conexion();

        #endregion

        #region Propiedades

        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Status { get; set; }

        #endregion

        #region Método para insertar

        public bool Insertar()
        {
            bool success = false;

            try
            {
                Conexion.abrir();

                var cmd = new SqlCommand("SP_INSERTARTIPOPRODUCTO", Conexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreTipo", Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                cmd.Parameters.AddWithValue("@Status", Status);
                var resultado = cmd.ExecuteNonQuery();

                if (resultado == 1)
                {
                    success = true;
                }

                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return success;
        }

        #endregion

        #region Método para seleccionar los tipos en el cmb

        public DataTable seleccionarTipo()
        {
            var tablaTipo = new DataTable();

            try
            {
                Conexion.abrir();
                string sql = "Select idTipo, nombre from Tipo";

                var cmd = new SqlCommand(sql, Conexion.conexion);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    return null;
                }
                tablaTipo.Load(reader);
                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaTipo;
        }

        #endregion

        /*public DataTable Mostrar()
        {
            var tablaMostrarTipo = new DataTable();

            try
            {
                Conexion.abrir();

                var cmd = new SqlCommand("SP_MOSTRARTIPOPRODUCTO", Conexion.conexion);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    reader.Close();
                    return null;
                }
                tablaMostrarTipo.Load(reader);

                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaMostrarTipo;
        }*/

        public DataTable BuscarTipoProducto()
        {
            var tablaBuscarTipo = new DataTable();

            try
            {
                Conexion.abrir();

                var cmd = new SqlCommand("SP_BUSCARTIPOPRODUCTO", Conexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    return null;
                }
                tablaBuscarTipo.Load(reader);

                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaBuscarTipo;
        }

        public void Actualizar()
        {

        }

        public void Borrar()
        {

        }
    }
}
