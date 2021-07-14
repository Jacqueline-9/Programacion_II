using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace Business
{
    public class B_OperacionesClientes
    {
        public D_Cliente dCliente = new D_Cliente();
        public D_Persona dPersona = new D_Persona();
        public D_Municipio dMunicipio = new D_Municipio();
        public D_Localidad dLocalidad = new D_Localidad();
        public D_Colonia dColonia = new D_Colonia();
        public D_Calle dCalle = new D_Calle();
        public D_Domicilio dDomicilio = new D_Domicilio();

        //Método para mostrar
        public DataTable mostrarClientes()
        {
            try
            {
                return dCliente.Mostrar();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Método para insertar
        public string insertarCliente(string nombre, string apPaterno, string apMaterno, DateTime fechaNac,  string telefono, int idDomicilio, string curp, int status)
        {
            try
            {
                dPersona.nombre = nombre;
                dPersona.apPaterno = apPaterno;
                dPersona.apMaterno = apMaterno;
                dPersona.fechaNac = fechaNac;
                dPersona.telefono = telefono;
                dPersona.idDomicilio = idDomicilio;
                dCliente.Curp = curp;
                dCliente.Status = status;

                if (dCliente.Insertar())
                {
                    return "El cliente a sido dado de alta correctamente";
                }
                else
                {
                    return "El cliente no a sido dado de alta";
                }
            }
            catch
            {
                throw;
            }
        }

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
