using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;


namespace Business
{
    public class B_OperacionesProductos
    {
        #region Objetos

        public D_Productos dProducto = new D_Productos();
        public D_Tipo dTipo = new D_Tipo();
        public D_Unidad dUnidad = new D_Unidad();

        #endregion

        #region Operaciones CRUD para productos

        //Método para insertar
        public string insertarProducto(string nombre, decimal precio, decimal contenidoNeto, int idUnidad, int existencia, DateTime fechaCaducidad, int idTipo, int status)
        {
            try
            {
                dProducto.Nombre = nombre;
                dProducto.Precio = precio;
                dProducto.ContenidoNeto = contenidoNeto;
                dProducto.IdUnidad = idUnidad;
                dProducto.Existencia = existencia;
                dProducto.FechaCaducidad = fechaCaducidad;
                dProducto.IdTipo = idTipo;
                dProducto.Status = status;

                if (dProducto.Insertar())
                {
                    return "El producto a sido dado de alta correctamente";
                }
                else
                {
                    return "El producto no a sido dado de alta";
                }
            }
            catch
            {
                throw;
            }
        }

        //Método para mostrar
        public DataTable mostrarProducto()
        {
            try
            {
                return dProducto.Mostrar();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Método para buscar producto por nombre
        public DataTable BuscarProducto(string nombre)
        {
            try
            {
                dProducto.Nombre = nombre;
                return dProducto.Buscar();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Método para buscar producto por precio
        public DataTable BuscarProductoPrecio(decimal precio)
        {
            try
            {
                dProducto.Precio = precio;
                return dProducto.BuscarProPrecio();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Método para Buscar producto por tipo
        /*public DataTable BuscarTipoProducto(string nombreTipo)
        {
            try
            {
                dTipo.Nombre = nombreTipo;
                return dTipo.BuscarTipoProducto();
            }
            catch (Exception)
            {
                throw;
            }
        }*/

        #endregion

        #region Método para mostrar los tipos en el cmb

        public DataTable seleccionarTipos()
        {
            try
            {
                return dTipo.seleccionarTipo();

            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Método para mostrar las unidades en el cmb

        public DataTable seleccionarUnidad()
        {
            try
            {
                return dUnidad.seleccionarUnidad();

            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        public string insertarTipoProducto(string nombre, string descripcion, int status)
        {
            try
            {
                dTipo.Nombre = nombre;
                dTipo.Descripcion = descripcion;
                dTipo.Status = status;

                if (dTipo.Insertar())
                {
                    return "El tipo de producto a sido dado de alta correctamente";
                }
                else
                {
                    return "El tipo de producto no a sido dado de alta";
                }

            }
            catch
            {
                throw;
            }
        }

        public string insertarUnidad(string nombre, string descripcion, int status)
        {
            try
            {
                dTipo.Nombre = nombre;
                dTipo.Descripcion = descripcion;
                dTipo.Status = status;

                if (dTipo.Insertar())
                {
                    return "la unidad a sido dado de alta correctamente";
                }
                else
                {
                    return "El la unidad no a sido dado de alta";
                }

            }
            catch
            {
                throw;
            }
        }
    }
}
