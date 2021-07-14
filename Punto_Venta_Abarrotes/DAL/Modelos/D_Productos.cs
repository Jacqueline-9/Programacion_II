using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class D_Productos
    {
        #region Objeto conexión

        private D_Conexion Conexion = new D_Conexion();

        #endregion

        #region Propiedades

        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public decimal ContenidoNeto { get; set; }
        public int IdUnidad { get; set; }
        public int Existencia { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public int IdTipo { get; set; }
        public int Status { get; set; }

        #endregion

        #region Método para insertar

        public bool Insertar()
        {
            bool success = false;

            try
            {
                Conexion.abrir();

                var cmd = new SqlCommand("SP_INSERTARPRODUCTOS", Conexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Precio", Precio);
                cmd.Parameters.AddWithValue("@ContenidoNeto", ContenidoNeto);
                cmd.Parameters.AddWithValue("@IdUnidad", IdUnidad);
                cmd.Parameters.AddWithValue("@existencia", Existencia);
                cmd.Parameters.AddWithValue("@FechaCaducidad", FechaCaducidad);
                cmd.Parameters.AddWithValue("@IdTipo", IdTipo);
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

        #region Método para mostrar

        public DataTable Mostrar()
        {
            var tablaMostrarProducto = new DataTable();

            try
            {
                Conexion.abrir();

                var cmd = new SqlCommand("SP_MOSTRARPRODUCTOS", Conexion.conexion);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    reader.Close();
                    return null;
                }
                tablaMostrarProducto.Load(reader);

                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaMostrarProducto;
        }

        #endregion

        #region Método para buscar

        //Buscar producto por nombre
        public DataTable Buscar()
        {
            var tablaBuscarProducto = new DataTable();

            try
            {
                Conexion.abrir();

                var cmd = new SqlCommand("SP_BUSCARPRODUCTO", Conexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    return null;
                }
                tablaBuscarProducto.Load(reader);

                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaBuscarProducto;
        }

        //Buscas producto por precio
        public DataTable BuscarProPrecio()
        {
            var tablaBuscarProductoPrecio = new DataTable();

            try
            {
                Conexion.abrir();

                var cmd = new SqlCommand("SP_BUSCARPRODUCTOPRECIO", Conexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Precio", Precio);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    return null;
                }
                tablaBuscarProductoPrecio.Load(reader);

                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaBuscarProductoPrecio;
        }


        #endregion

        public void Actualizar()
        {

        }

        public void Borrar()
        {

        }
    }
}
