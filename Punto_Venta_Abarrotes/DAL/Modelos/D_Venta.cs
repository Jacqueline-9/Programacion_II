using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class D_Venta
    {
        #region objetos 

        private D_Conexion Conexion = new D_Conexion();
        public D_DetalleVentaProductos dDetalleVentaProducto = new D_DetalleVentaProductos();
        public D_Productos dProducto = new D_Productos();
        public D_Empleados dEmpleado = new D_Empleados();
        public D_Cliente dCliente = new D_Cliente();

        #endregion

        #region Propiedades

        public int idVenta { get; set; }
        public int idPersonaCliente { get; set; }
        public int idPersonaEmpleado { get; set; }
        public decimal subtotal { get; set; }
        public decimal iva { get; set; }
        public decimal total { get; set; }
        public DateTime fecha { get; set; }
        public int status { get; set; }

        #endregion

        #region Método para mostrar clientes 

        public DataTable mostrarClientes()
        {
            var tablaMostrarCliente = new DataTable();

            try
            {
                Conexion.abrir();
                var cmd = new SqlCommand("SP_VENTAMOSTRARCLIENTE", Conexion.conexion);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    reader.Close();
                    return null;
                }
                tablaMostrarCliente.Load(reader);

                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaMostrarCliente;
        }

        #endregion

        #region Método para mostrar productos

        public DataTable mostrarProductos()
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

        #region Método para mostrar ventas

        public DataTable mostrarVenta()
        {
            var tablaMostrarVenta = new DataTable();
            try
            {
                Conexion.abrir();
                var cmd = new SqlCommand("SP_MOSTRARVENTA", Conexion.conexion);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    reader.Close();
                    return null;
                }
                tablaMostrarVenta.Load(reader);

                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaMostrarVenta;
        }

        #endregion

        #region Método para mostrar la venta que se reliazo

        public DataTable mostrarVentaProceso()
        {
            var tablaMostrarVentaProceso = new DataTable();

            try
            {
                Conexion.abrir();
                var cmd = new SqlCommand("SP_MOSTRARVENTAPROCESO", Conexion.conexion);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    reader.Close();
                    return null;
                }
                tablaMostrarVentaProceso.Load(reader);

                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaMostrarVentaProceso;
        }

        #endregion

        #region Método para mostrar los detalles

        public DataTable mostrarDetalle()
        {
            var tablaMostrarDetalle = new DataTable();

            try
            {
                Conexion.abrir();
                var cmd = new SqlCommand("SP_MOSTRARDETALLE", Conexion.conexion);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    reader.Close();
                    return null;
                }
                tablaMostrarDetalle.Load(reader);

                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaMostrarDetalle;
        }

        #endregion

        #region Método para insertar venta

        public bool InsertarVenta()
        {
            bool success = false;

            try
            {
                Conexion.abrir();

                var cmd = new SqlCommand("SP_REALIZARVENTA", Conexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProducto", dProducto.IdProducto);
                cmd.Parameters.AddWithValue("@Cantidad", dDetalleVentaProducto.Cantidad);
                cmd.Parameters.AddWithValue("@IdEmpleado", dEmpleado.IdPersonaEmpleado);
                cmd.Parameters.AddWithValue("@IdCliente", dCliente.IdPersonaCliente);
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
    }
}
