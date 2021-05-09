using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Punto_Venta_Abarrotes
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();

            /*Mensajes de acciones de cada herramienta*/
            this.tltBuscar.SetToolTip(this.txtRazonSocialBuscar, "Buscar razón social por nombre");
            this.tltBuscar.SetToolTip(this.txtEstatus, "1 activo y 0 inactivo");
        }

        #region Mostrar Fecha Y hora

        private void tmrFechaHera_Tick(object sender, EventArgs e)
        {
            lblMostrarFecha.Text = DateTime.Now.ToLongDateString();
            lblMostrarHora.Text = DateTime.Now.ToLongTimeString();
        }


        #endregion

        #region Validaciones 

        private void btnRegistrarEntidades_Click(object sender, EventArgs e)
        {
            Regex reRazonSocial = new Regex("^[a-zA-Z]*$", RegexOptions.Compiled);
            if (!reRazonSocial.IsMatch(txtRazonSocial.Text))
            {
                erpProveedores.SetError(txtRazonSocial, "Debe colocar un nombre válido");
                txtRazonSocial.Focus();
                return;
            }
            erpProveedores.SetError(txtRazonSocial, "");

            Regex reTelefono = new Regex("[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]", RegexOptions.Compiled);
            if (!reTelefono.IsMatch(txtTelefonoEmpleado.Text))
            {
                erpProveedores.SetError(txtTelefonoEmpleado, "Debe colocar un telefono valido");
                txtTelefonoEmpleado.Focus();
                return;
            }
            erpProveedores.SetError(txtTelefonoEmpleado, "");

            if (txtRazonSocial.Text == "")
            {
                erpProveedores.SetError(txtRazonSocial, "Favor de ingresar el nombre de la entidad");
                txtRazonSocial.Focus();
                return;
            }
            erpProveedores.SetError(txtRazonSocial, "");

            if (txtIdDomicilioEntidad.Text == "")
            {
                erpProveedores.SetError(txtIdDomicilioEntidad, "Favor de ingresar el id del domicilio de la entidad");
                txtIdDomicilioEntidad.Focus();
                return;
            }
            erpProveedores.SetError(txtIdDomicilioEntidad, "");

            if (txtTelefonoEmpleado.Text == "")
            {
                erpProveedores.SetError(txtTelefonoEmpleado, "Favor de ingresar el teléfono de la entidad");
                txtTelefonoEmpleado.Focus();
                return;
            }
            erpProveedores.SetError(txtTelefonoEmpleado, "");

            if (txtEstatus.Text == "")
            {
                erpProveedores.SetError(txtEstatus, "Favor de ingresar el estatus de la entidad");
                txtEstatus.Focus();
                return;
            }
            erpProveedores.SetError(txtEstatus, "");


            txtRazonSocial.Clear();
            txtIdDomicilioEntidad.Clear();
            txtTelefonoEmpleado.Clear();
            txtEstatus.Clear();
        }

        private void btnBuscarEntidades_Click(object sender, EventArgs e)
        {
            txtRazonSocialBuscar.Clear();
        }

        #endregion

        #region Validaciones de solo letras o números 

        private void txtIdDomicilioEntidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        #endregion
    }
}
