using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace Business
{
    public class B_OperacionesUsuarios
    {
        #region Objetos 

        public D_Usuario dUsuarios = new D_Usuario();

        #endregion

        #region Operaciones CRUD

        //Método para mostrar
        public DataTable mostrarUsuario()
        {
            try
            {
                return dUsuarios.Mostrar();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Método para insertar
        public string insertarUsuario (string nombre, string correo, string contrasenia, int status)
        {
            try
            {
                dUsuarios.Nombre = nombre;
                dUsuarios.Correo = correo;
                dUsuarios.Contrasenia = correo;
                dUsuarios.Status = status;

                if (dUsuarios.Insertar())
                {
                    return "El usuario a sido dado de alta correctamente";
                }
                else
                {
                    return "El usuario no a sido dado de alta";
                }
                
            }
            catch
            {
                throw;
            }
        }

        //Método para actualizar
        public string actualizarUsuario(string nombre, string correo, string contrasenia, int status)
        {
            try
            {
                dUsuarios.Nombre = nombre;
                dUsuarios.Correo = correo;
                dUsuarios.Contrasenia = contrasenia;
                dUsuarios.Status = status;

                dUsuarios.Actualizar();
                return "El usuario se a actualizado";
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Método para buscar
        public DataTable BuscarUsuario(string nombre)
        {
            try
            {
                dUsuarios.Nombre = nombre;
                return dUsuarios.Buscar();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
