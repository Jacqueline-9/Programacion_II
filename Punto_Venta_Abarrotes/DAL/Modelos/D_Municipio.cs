using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class D_Municipio
    {
        private D_Conexion Conexion = new D_Conexion();

        public int idMunicipio { get; set; }
        public string nombre { get; set; }
        public int status { get; set; }

        public DataTable seleccionarMunicipio()
        {
            var tablaMunicipio = new DataTable();

            try
            {
                Conexion.abrir();
                string sql = "Select idMunicipio, nombre from Municipio";

                var cmd = new SqlCommand(sql, Conexion.conexion);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    return null;
                }
                tablaMunicipio.Load(reader);
                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaMunicipio;
        }
    }
}
