using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace Business
{
    public class B_OperacionesEmpleados
    {
        private D_Empleados dEmpleado = new D_Empleados();

        public DataTable validarUsuario(string nombre, string contrasenia)
        {
            try
            {
                dEmpleado.dUsuario.Nombre = nombre;
                dEmpleado.dUsuario.Contrasenia = contrasenia;
                return dEmpleado.validarUsuario();

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
