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
    public partial class frmDomicilio : Form
    {
        public frmDomicilio()
        {
            InitializeComponent();
        }

        #region Mostrar Fecha y Hora

        private void tmrFechaHira_Tick(object sender, EventArgs e)
        {
            lblMostrarFecha.Text = DateTime.Now.ToLongDateString();
            lblMostrarHora.Text = DateTime.Now.ToLongTimeString();
        }

        #endregion

        #region Validaciones

        private void btnRegistrarMunicipios_Click(object sender, EventArgs e)
        {
            if (cmbMunicipios.Text == "Ixtlán del Rio")
            {
                cmbLocalidadIxtlan.Visible = true;
                cmbLocalidadesAhuaca.Visible = false;
            }
            else
            {
                cmbLocalidadIxtlan.Visible = false;
                cmbLocalidadesAhuaca.Visible = true;
            }
        }

        private void btnRegistrarLocalidad_Click(object sender, EventArgs e)
        {
            if (txtIdMunicipio.Text == "")
            {
                erpDomicilios.SetError(txtIdMunicipio, "Favor de ingresar el id del municipio");
                txtIdMunicipio.Focus();
                return;
            }
            erpDomicilios.SetError(txtIdMunicipio, "");

            txtIdMunicipio.Clear();
        }

        private void btnRegistrarColonia_Click(object sender, EventArgs e)
        {
            if (txtIdLocalidad.Text == "")
            {
                erpDomicilios.SetError(txtIdLocalidad, "Favor de ingresar el id de la localidad");
                txtIdLocalidad.Focus();
                return;
            }
            erpDomicilios.SetError(txtIdLocalidad, "");

            txtIdLocalidad.Clear();
        }

        private void btnRegistrarDomicilio_Click(object sender, EventArgs e)
        {
            if (txtNumExt.Text == "")
            {
                erpDomicilios.SetError(txtNumExt, "Favor de ingresar el número exterior de la vivienda");
                txtNumExt.Focus();
                return;
            }
            erpDomicilios.SetError(txtNumExt, "");

            txtNumExt.Clear();
            txtNumInt.Clear();
        }

        private void btnRegistrarCalle_Click(object sender, EventArgs e)
        {
            if (txtIdColonia.Text == "")
            {
                erpDomicilios.SetError(txtIdColonia, "Favor de ingresar el id de la colonia");
                txtIdColonia.Focus();
                return;
            }
            erpDomicilios.SetError(txtIdColonia, "");

            if (txtIdDomicilio.Text == "")
            {
                erpDomicilios.SetError(txtIdDomicilio, "Favor de ingresar el id del domicilio");
                txtIdDomicilio.Focus();
                return;
            }
            erpDomicilios.SetError(txtIdDomicilio, "");

            txtIdColonia.Clear();
            txtIdDomicilio.Clear();
        }


        #endregion

        #region Validaciones de solo números o letras

        private void txtIdMunicipio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtIdLocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtIdColonia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtIdDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNumExt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNumInt_KeyPress(object sender, KeyPressEventArgs e)
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
