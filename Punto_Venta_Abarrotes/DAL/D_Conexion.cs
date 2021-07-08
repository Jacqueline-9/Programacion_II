using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class D_Conexion
    {
        //Cadena conexión
        private readonly string CADENACONEXION = "Data Source=DESKTOP-BKOIH1I;Initial Catalog=Punto_Venta_Abarrotes;Integrated Security=True";

        //objeto conexión 
        public SqlConnection conexion = new SqlConnection();

        //Constructor
        public D_Conexion()
        {
            conexion.ConnectionString = CADENACONEXION;
        }

        //Métodos para abrir y cerrar
        public void abrir()
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexión abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la base de datos " + ex.Message);
            }
        }

        public void cerrar()
        {
            conexion.Close();
        }
    }
}
