using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace Business
{
    public class B_OperacionesTipo
    {
        public D_Tipo dTipo = new D_Tipo();

        

        /*public DataTable mostrarTipoProducto()
        {
            try
            {
                return dTipo.Mostrar();
            }
            catch (Exception)
            {
                throw;
            }
        }*/

        /*public DataTable BuscarTipoProducto(string nombre)
        {
            try
            {
                dTipo.Nombre = nombre;
                return dTipo.Buscar();
            }
            catch (Exception)
            {
                throw;
            }
        }*/
    }
}
