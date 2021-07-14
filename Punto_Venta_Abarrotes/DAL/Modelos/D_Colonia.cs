using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class D_Colonia
    {
        private D_Conexion Conexion = new D_Conexion();

        public int idColonia { get; set; }
        public string nombre { get; set; }
        public int idLocalidad { get; set; }
        public int status { get; set; }

        public DataTable seleccionarColonia()
        {
            var tablaColonia = new DataTable();

            try
            {
                Conexion.abrir();
                string sql = "Select idColonia, nombre from Colonia";

                var cmd = new SqlCommand(sql, Conexion.conexion);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    return null;
                }
                tablaColonia.Load(reader);
                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaColonia;
        }
    }
}
