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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();

            /*Mensajes de acciones de cada herramienta*/
            this.tltBuscar.SetToolTip(this.txtNombreBuscar, "Buscar cliente por nombre");
            this.tltBuscar.SetToolTip(this.txtApePatCliente, "Buscar cliente por apellido paterno");
            this.tltBuscar.SetToolTip(this.txtApeMatBuscar, "Buscar cliente por apellido materno");
            this.tltBuscar.SetToolTip(this.txtEstatus, "1 activo y 0 inactivo");
        }

        #region Mostrar Fecha y Hora

        private void tmrFechaHora_Tick(object sender, EventArgs e)
        {
            lblMostrarFecha.Text = DateTime.Now.ToLongDateString();
            lblMostrarHora.Text = DateTime.Now.ToLongTimeString();
        }

        #endregion

        #region Validaciones 

        private void btnRegistrarClientes_Click(object sender, EventArgs e)
        {
            if (txtNombreCliente.Text == "")
            {
                erpClientes.SetError(txtNombreCliente, "Favor de ingresar el nombre del cliente");
                txtNombreCliente.Focus();
                return;
            }
            erpClientes.SetError(txtNombreCliente, "");

            if (txtApePatCliente.Text == "")
            {
                erpClientes.SetError(txtApePatCliente, "Favor de ingresar el apellido paterno del cliente");
                txtApePatCliente.Focus();
                return;
            }
            erpClientes.SetError(txtApePatCliente, "");

            if (txtTelefonoCliente.Text == "")
            {
                erpClientes.SetError(txtTelefonoCliente, "Favor de ingresar el teléfono del cliente");
                txtTelefonoCliente.Focus();
                return;
            }
            erpClientes.SetError(txtTelefonoCliente, "");

            if (txtCurp.Text == "")
            {
                erpClientes.SetError(txtCurp, "Favor de ingresar la curp del cliente");
                txtCurp.Focus();
                return;
            }
            erpClientes.SetError(txtCurp, "");

            if (txtIdDomicilioCliente.Text == "")
            {
                erpClientes.SetError(txtIdDomicilioCliente, "Favor de ingresar el domicilio del cliente");
                txtIdDomicilioCliente.Focus();
                return;
            }
            erpClientes.SetError(txtIdDomicilioCliente, "");

            if (txtEstatus.Text == "")
            {
                erpClientes.SetError(txtEstatus, "Favor de ingresar el estatus del cliente");
                txtEstatus.Focus();
                return;
            }
            erpClientes.SetError(txtEstatus, "");

            txtNombreCliente.Clear();
            txtApePatCliente.Clear();
            txtApeMatCliente.Clear();
            txtTelefonoCliente.Clear();
            txtCurp.Clear();
            txtIdDomicilioCliente.Clear();
            txtEstatus.Clear();
        }

        private void btnBuscarClientes_Click(object sender, EventArgs e)
        {
            txtNombreCliente.Clear();
            txtApePatCliente.Clear();
            txtApeMatCliente.Clear();
        }

        #endregion

        #region Validaciones de solo letras o numeros

        private void txtIdDomicilioCliente_KeyPress(object sender, KeyPressEventArgs e)
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
