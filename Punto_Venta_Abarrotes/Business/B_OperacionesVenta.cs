using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace Business
{
    public class B_OperacionesVenta
    {
        #region Objeto

        private D_Venta dVenta = new D_Venta();

        #endregion

        #region Método para mostrar clientes 

        public DataTable MostrarClientes()
        {
            try
            {
                return dVenta.mostrarClientes();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Método para mostrar productos 

        public DataTable MostrarProductos()
        {
            try
            {
                return dVenta.mostrarProductos();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Método para mostrar ventas

        public DataTable MostrarVenta()
        {
            try
            {
                return dVenta.mostrarVenta();
            }
            catch (Exception)
            {
                throw;
            }

        }

        #endregion

        #region Método para mostrar la venta que se realizó

        public DataTable MostrarVentaProceso()
        {
            try
            {
                return dVenta.mostrarVentaProceso();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Método para mostrar los detalles

        public DataTable MostrarDetalle()
        {
            try
            {
                return dVenta.mostrarDetalle();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Método para insertar ventas

        public string insertarVenta(int idProducto, int cantidad, int idEmpleado, int idCliente)
        {
            try
            {
                dVenta.dProducto.IdProducto = idProducto;
                dVenta.dDetalleVentaProducto.Cantidad = cantidad;
                dVenta.dEmpleado.IdPersonaEmpleado = idEmpleado;
                dVenta.dCliente.IdPersonaCliente = idCliente;

                dVenta.InsertarVenta();
                return "La venta a sido de alta correctamente";
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
