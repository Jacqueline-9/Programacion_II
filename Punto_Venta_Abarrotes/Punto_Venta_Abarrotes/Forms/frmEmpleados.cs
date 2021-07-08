using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Punto_Venta_Abarrotes
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();

            /*Mensajes de acciones de cada herramienta*/
            this.tltBuscar.SetToolTip(this.txtNombreBuscar, "Buscar empleado por nombre");
            this.tltBuscar.SetToolTip(this.txtApPatBuscar, "Buscar empleado por apellido paterno");
            this.tltBuscar.SetToolTip(this.txtApeMatBuscar, "Buscar empleado por apellido materno");
            this.tltBuscar.SetToolTip(this.txtEstatus, "1 activo y 0 inactivo");
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {

        }

        #region Mostrar Fecha y Hora

        private void tmrFechaHora_Tick(object sender, EventArgs e)
        {
            lblMostrarFecha.Text = DateTime.Now.ToLongDateString();
            lblMostrarHora.Text = DateTime.Now.ToLongTimeString();
        }

        #endregion

        #region Validaciones de solo numeros o letras

        private void txtIdDomicilioCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtIdPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtIdUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        #endregion

        #region Validaciones

        private void btnRegistrarEmpleados_Click(object sender, EventArgs e)
        {

            Regex reNombre = new Regex("^[a-zA-Z]*$", RegexOptions.Compiled);
            if (!reNombre.IsMatch(txtNombreEmpleado.Text))
            {
                erpEmpleados.SetError(txtNombreEmpleado, "Debe colocar un nombre válido");
                txtNombreEmpleado.Focus();
                return;
            }
            erpEmpleados.SetError(txtNombreEmpleado, "");

            if (txtNombreEmpleado.Text == "")
            {
                erpEmpleados.SetError(txtNombreEmpleado, "Favor de ingresar el nombre del empleado");
                txtNombreEmpleado.Focus();
                return;
            }
            erpEmpleados.SetError(txtNombreEmpleado, "");

            Regex reApellido = new Regex("^[a-zA-Z]*$", RegexOptions.Compiled);
            if (!reApellido.IsMatch(txtApePatEmpleado.Text))
            {
                erpEmpleados.SetError(txtApePatEmpleado, "Debe colocar un apellido válido");
                txtApePatEmpleado.Focus();
                return;
            }
            erpEmpleados.SetError(txtApePatEmpleado, "");

            if (txtApePatEmpleado.Text == "")
            {
                erpEmpleados.SetError(txtApePatEmpleado, "Favor de ingresar el apellido paterno del empleado");
                txtApePatEmpleado.Focus();
                return;
            }
            erpEmpleados.SetError(txtApePatEmpleado, "");

            if (!reApellido.IsMatch(txtApeMatEmpleado.Text))
            {
                erpEmpleados.SetError(txtApeMatEmpleado, "Debe colocar un apellido válido");
                txtApeMatEmpleado.Focus();
                return;
            }
            erpEmpleados.SetError(txtApeMatEmpleado, "");

            Regex reTelefono = new Regex("[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]", RegexOptions.Compiled);
            if (!reTelefono.IsMatch(txtTelefonoEmpleado.Text))
            {
                erpEmpleados.SetError(txtTelefonoEmpleado, "Debe colocar un telefono valido");
                txtTelefonoEmpleado.Focus();
                return;
            }
            erpEmpleados.SetError(txtTelefonoEmpleado, "");

            if (txtTelefonoEmpleado.Text == "")
            {
                erpEmpleados.SetError(txtTelefonoEmpleado, "Favor de ingresar el teléfono del empleado");
                txtTelefonoEmpleado.Focus();
                return;
            }
            erpEmpleados.SetError(txtTelefonoEmpleado, "");

            Regex reRFC = new Regex("[A-Z][A-Z][A-Z][A-Z][0-9][0-9][0-9][0-9][0-9][0-9][A-Z][A-Z][0-9]", RegexOptions.Compiled);
            if (!reRFC.IsMatch(txtRFC.Text))
            {
                erpEmpleados.SetError(txtRFC, "Debe colocar un RFC válido");
                txtRFC.Focus();
                return;
            }
            erpEmpleados.SetError(txtRFC, "");

            if (txtRFC.Text == "")
            {
                erpEmpleados.SetError(txtRFC, "Favor de ingresar el RFC del empleado");
                txtRFC.Focus();
                return;
            }
            erpEmpleados.SetError(txtRFC, "");

            if (txtIdDomicilioEmpleado.Text == "")
            {
                erpEmpleados.SetError(txtIdDomicilioEmpleado, "Favor de ingresar el domicilio del empleado");
                txtIdDomicilioEmpleado.Focus();
                return;
            }
            erpEmpleados.SetError(txtIdDomicilioEmpleado, "");

            if (txtIdPuesto.Text == "")
            {
                erpEmpleados.SetError(txtIdPuesto, "Favor de ingresar el puesto del empleado");
                txtIdPuesto.Focus();
                return;
            }
            erpEmpleados.SetError(txtIdPuesto, "");

            if (txtIdUsuario.Text == "")
            {
                erpEmpleados.SetError(txtIdUsuario, "Favor de ingresar el usuario del empleado");
                txtIdUsuario.Focus();
                return;
            }
            erpEmpleados.SetError(txtIdUsuario, "");

            if (txtEstatus.Text == "")
            {
                erpEmpleados.SetError(txtEstatus, "Favor de ingresar el estatus del producto");
                txtEstatus.Focus();
                return;
            }
            erpEmpleados.SetError(txtEstatus, "");

            txtNombreEmpleado.Clear();
            txtApePatEmpleado.Clear();
            txtApeMatEmpleado.Clear();
            txtTelefonoEmpleado.Clear();
            txtRFC.Clear();
            txtIdDomicilioEmpleado.Clear();
            txtIdPuesto.Clear();
            txtIdUsuario.Clear();
            txtEstatus.Clear();
        }

        private void btnBuscarEmpleados_Click(object sender, EventArgs e)
        {
            Regex reNombre = new Regex("^[a-zA-Z]*$", RegexOptions.Compiled);
            if (!reNombre.IsMatch(txtNombreBuscar.Text))
            {
                erpEmpleados.SetError(txtNombreBuscar, "Debe colocar un nombre válido");
                txtNombreBuscar.Focus();
                return;
            }
            erpEmpleados.SetError(txtNombreBuscar, "");

            Regex reApellido = new Regex("^[a-zA-Z]*$", RegexOptions.Compiled);
            if (!reApellido.IsMatch(txtApPatBuscar.Text))
            {
                erpEmpleados.SetError(txtApPatBuscar, "Debe colocar un apellido válido");
                txtApPatBuscar.Focus();
                return;
            }
            erpEmpleados.SetError(txtApPatBuscar, "");

            if (!reApellido.IsMatch(txtApeMatBuscar.Text))
            {
                erpEmpleados.SetError(txtApeMatBuscar, "Debe colocar un apellido válido");
                txtApeMatBuscar.Focus();
                return;
            }
            erpEmpleados.SetError(txtApeMatBuscar, "");

            txtNombreEmpleado.Clear();
            txtApePatEmpleado.Clear();
            txtApeMatEmpleado.Clear();
        }

        #endregion

        /*public DataTable MostrarTabla()
         {
             D_Conexion conex = new D_Conexion();
             conex.abrir();
             string cadena = "select nombre, apPaterno, apMaterno, fechaNac, telefono, rfc, status  from Persona INNER JOIN Empleado on Empleado.IdPersona = Persona.IdPersona";
             SqlCommand comando = new SqlCommand(cadena, conex.conectarbd);
             SqlDataAdapter adaptador = new SqlDataAdapter(comando);
             DataTable tabla = new DataTable();
             adaptador.Fill(tabla);
             return (tabla);
         }*/

        private void btnVerEmpleados_Click(object sender, EventArgs e)
        {
            //dgvEmpleados.DataSource = MostrarTabla();
            //dgvEmpleados.Columns[0].Visible = false;
        }

    }
}
