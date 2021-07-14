using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class D_Calle
    {
        private D_Conexion Conexion = new D_Conexion();

        public int idCalle { get; set; }
        public string nombre { get; set; }
        public int idColonia { get; set; }
        public int idDomicilio { get; set; }
        public int status { get; set; }

        public DataTable seleccionarCalle()
        {
            var tablaCalle = new DataTable();

            try
            {
                Conexion.abrir();
                string sql = "Select idCalle, nombre from Calle";

                var cmd = new SqlCommand(sql, Conexion.conexion);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    return null;
                }
                tablaCalle.Load(reader);
                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaCalle;
        }
    }
}
