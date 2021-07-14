using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace Business
{
    public class B_OperacionesProveedor
    {
        #region Objetos 

        public D_Proveedor dProveedor = new D_Proveedor();
        public D_Municipio dMunicipio = new D_Municipio();
        public D_Localidad dLocalidad = new D_Localidad();
        public D_Colonia dColonia = new D_Colonia();
        public D_Calle dCalle = new D_Calle();
        public D_Domicilio dDomicilio = new D_Domicilio();

        #endregion

        #region Operaciones CRUD

        //Método para mostrar
        public DataTable mostrarProveedor()
        {
            try
            {
                return dProveedor.Mostrar();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Método para insertar
        public string insertarProveedor(string razonSocial, string telefono, int idDomicilio, int status)
        {
            try
            {
                dProveedor.RazonSocial = razonSocial;
                dProveedor.Telefono = telefono;
                dProveedor.IdDomicilio = idDomicilio;
                dProveedor.Status = status;

                if (dProveedor.Insertar())
                {
                    return "El proveedor a sido dado de alta correctamente";
                }
                else
                {
                    return "El proveedor no a sido dado de alta";
                }
            }
            catch
            {
                throw;
            }
        }

        //Método para buscar proveedor
        public DataTable BuscarProveedor(string razonSocial)
        {
            try
            {
                dProveedor.RazonSocial = razonSocial;
                return dProveedor.Buscar();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Método para actualizar proveedor
        public string actualizarProveedor(int idProveedor, string razonSocial, string telefono, int idDomicilio)
        {
            try
            {
                dProveedor.IdProveedor = idProveedor;
                dProveedor.RazonSocial = razonSocial;
                dProveedor.Telefono = telefono;
                dProveedor.IdDomicilio = idDomicilio;

                dProveedor.actualizarProveedor();

                return "El proveedor se actualizó correctamente";
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Método para mostrar los municipios en el cmb

        public DataTable seleccionarMunicipios()
        {
            try
            {
                return dMunicipio.seleccionarMunicipio();

            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Método para mostrar las localidades en el cmb

        public DataTable seleccionarLocalidades()
        {
            try
            {
                return dLocalidad.seleccionarLocalidad();

            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Método para mostrar las colonias en el cmb

        public DataTable seleccionarColonias()
        {
            try
            {
                return dColonia.seleccionarColonia();

            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Método para mostrar las calles en el cmb

        public DataTable seleccionarCalles()
        {
            try
            {
                return dCalle.seleccionarCalle();

            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Método para mostrar los domicilios en el cmb

        public DataTable seleccionarDomicilios()
        {
            try
            {
                return dDomicilio.seleccionarDomicilio();

            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
