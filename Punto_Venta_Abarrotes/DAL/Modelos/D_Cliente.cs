using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class D_Cliente
    {
        private D_Conexion Conexion = new D_Conexion();
        public D_Persona dPersona = new D_Persona();

        public int IdPersonaCliente { get; set; }
        public string Curp { get; set; }
        public int Status { get; set; }

        #region Método para mostrar

        public DataTable Mostrar()
        {
            var tablaMostrarCliente = new DataTable();

            try
            {
                Conexion.abrir();

                var cmd = new SqlCommand("SP_MOSTRARCLIENTE", Conexion.conexion);
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

        #region Método para insertar

        public bool Insertar()
        {
            bool success = false;

            try
            {
                Conexion.abrir();

                var cmd = new SqlCommand("SP_INSERTARCLIENTES", Conexion.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", dPersona.nombre);
                cmd.Parameters.AddWithValue("@apPaterno", dPersona.apPaterno);
                cmd.Parameters.AddWithValue("@apMaterno", dPersona.apMaterno);
                cmd.Parameters.AddWithValue("@FechaNac", dPersona.fechaNac);
                cmd.Parameters.AddWithValue("@Telefono", dPersona.telefono);
                cmd.Parameters.AddWithValue("@IdDomicilio", dPersona.idDomicilio);
                cmd.Parameters.AddWithValue("@CURP", Curp);
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
    }
}
