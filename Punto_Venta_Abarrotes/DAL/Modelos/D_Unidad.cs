using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class D_Unidad
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

                var cmd = new SqlCommand("SP_INSERTARUNIDADES", Conexion.conexion);
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

        #region Método para selccionar las unidades en el cmb

        public DataTable seleccionarUnidad()
        {
            var tablaUnidad = new DataTable();

            try
            {
                Conexion.abrir();
                string sql = "Select idUnidad, nombre from Unidad";

                var cmd = new SqlCommand(sql, Conexion.conexion);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    return null;
                }
                tablaUnidad.Load(reader);
                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaUnidad;
        }

        #endregion

    }
}
