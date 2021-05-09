using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (txtNombreEmpleado.Text == "")
            {
                erpEmpleados.SetError(txtNombreEmpleado, "Favor de ingresar el nombre del empleado");
                txtNombreEmpleado.Focus();
                return;
            }
            erpEmpleados.SetError(txtNombreEmpleado, "");

            if (txtApePatEmpleado.Text == "")
            {
                erpEmpleados.SetError(txtApePatEmpleado, "Favor de ingresar el apellido paterno del empleado");
                txtApePatEmpleado.Focus();
                return;
            }
            erpEmpleados.SetError(txtApePatEmpleado, "");

            if (txtTelefonoEmpleado.Text == "")
            {
                erpEmpleados.SetError(txtTelefonoEmpleado, "Favor de ingresar el teléfono del empleado");
                txtTelefonoEmpleado.Focus();
                return;
            }
            erpEmpleados.SetError(txtTelefonoEmpleado, "");

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

            if (int.Parse(txtEstatus.Text) != 0 && int.Parse(txtEstatus.Text) != 1)
            {
                erpEmpleados.SetError(txtEstatus, "Solo puede ser 0 o 1");
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
            txtNombreEmpleado.Clear();
            txtApePatEmpleado.Clear();
            txtApeMatEmpleado.Clear();
        }

        #endregion
    }
}
