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
    public partial class frmPerdidas : Form
    {
        public frmPerdidas()
        {
            InitializeComponent();
        }

        #region Mostrar Fecha y Hora

        private void tmrFechaHora_Tick(object sender, EventArgs e)
        {
            lblMostrarFecha.Text = DateTime.Now.ToLongDateString();
            lblMostrarHora.Text = DateTime.Now.ToLongTimeString();
        }

        #endregion

        #region Validaciones

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtIdProducto.Text == "")
            {
                erpPerdidas.SetError(txtIdProducto, "Favor de ingresar el id del producto");
                txtIdProducto.Focus();
                return;
            }
            erpPerdidas.SetError(txtIdProducto, "");

            if (txtPrecioPerdida.Text == "")
            {
                erpPerdidas.SetError(txtPrecioPerdida, "Favor de ingresar precio de la pérdida");
                txtPrecioPerdida.Focus();
                return;
            }
            erpPerdidas.SetError(txtPrecioPerdida, "");

            if (txtCausa.Text == "")
            {
                erpPerdidas.SetError(txtCausa, "Favor de ingresar la causa de la pérdida");
                txtCausa.Focus();
                return;
            }
            erpPerdidas.SetError(txtCausa, "");

            if (txtEstatus.Text == "")
            {
                erpPerdidas.SetError(txtEstatus, "Favor de ingresar el estatus de la pérdida");
                txtEstatus.Focus();
                return;
            }
            erpPerdidas.SetError(txtEstatus, "");
        }

        #endregion

        #region Validaciones de solo números o letras 

        private void txtEstatus_KeyPress(object sender, KeyPressEventArgs e)
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
