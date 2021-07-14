using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class D_Proveedor
    {
        #region Objeto conexión

        private D_Conexion Conexion = new D_Conexion();

        #endregion

        #region Propiedades

        public int IdProveedor { get; set; }
        public string RazonSocial { get; set; }
        public string Telefono { get; set; }
        public int IdDomicilio { get; set; }
        public int Status { get; set; }

        #endregion

        #region Método para insertar

        public bool Insertar()
        {
            bool success = false;

            try
            {
                Conexion.abrir();

                var cmd = new SqlCommand("SP_INSERTARPROVEEDORES", Conexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RazonSocial", RazonSocial);
                cmd.Parameters.AddWithValue("@Telefono", Telefono);
                cmd.Parameters.AddWithValue("@idDomicilio", IdDomicilio);
                cmd.Parameters.AddWithValue("@Status", Status);
                var resultado = cmd.ExecuteNonQuery();

                if (resultado == 1)
                    success = true;

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
            var tablaMostrarProveedor = new DataTable();

            try
            {
                Conexion.abrir();

                var cmd = new SqlCommand("SP_MOSTRARPROVEEDORES", Conexion.conexion);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    reader.Close();
                    return null;
                }
                tablaMostrarProveedor.Load(reader);

                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaMostrarProveedor;
        }

        #endregion

        #region Método para buscar

        public DataTable Buscar()
        {
            var tablaBuscarProveedor = new DataTable();

            try
            {
                Conexion.abrir();

                var cmd = new SqlCommand("SP_BUSCARPROVEEDOR", Conexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RazonSocial", RazonSocial);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    return null;
                }
                tablaBuscarProveedor.Load(reader);

                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaBuscarProveedor;
        }

        #endregion

        #region Método para actualizar

        public bool actualizarProveedor()
        {
            bool success = false;

            try
            {
                Conexion.abrir();
               
                var cmd = new SqlCommand("SP_ACTUALIZARPROVEEDOR", Conexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProveedor", IdProveedor);
                cmd.Parameters.AddWithValue("@RazonSocial", RazonSocial);
                cmd.Parameters.AddWithValue("@Telefono", Telefono);
                cmd.Parameters.AddWithValue("@idDomicilio", IdDomicilio);
                var resultado = cmd.ExecuteNonQuery();

                if (resultado == 1)
                    success = true;

                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return success;
        }

        #endregion
    }
}
