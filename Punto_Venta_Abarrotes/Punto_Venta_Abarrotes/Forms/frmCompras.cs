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
    public partial class frmCompras : Form
    {
        public frmCompras()
        {
            InitializeComponent();

            /*Mensajes de acciones de cada herramienta*/
            this.tltBuscar.SetToolTip(this.txtSubtotalBuscar, "Buscar compra por subtotal");
            this.tltBuscar.SetToolTip(this.dtpFechaRealiBuscar, "Buscar compra por fecha de relización");
            this.tltBuscar.SetToolTip(this.txtPosicion, "La posición comienza en 0");
        }

        #region Fecha y Hora

        private void tmrFechaHora_Tick(object sender, EventArgs e)
        {
            lblMostrarFecha.Text = DateTime.Now.ToLongDateString();
            lblMostrarHora.Text = DateTime.Now.ToLongTimeString();
        }

        #endregion

        #region Validaciones

        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            if (txtIdProducto.Text == "")
            {
                erpCompras.SetError(txtIdProducto, "Ingresar el producto");
                txtIdProducto.Focus();
                return;
            }
            erpCompras.SetError(txtIdProducto, "");

            if (txtPrecio.Text == "")
            {
                erpCompras.SetError(txtPrecio, "Ingresar el precio del producto");
                txtPrecio.Focus();
                return;
            }
            erpCompras.SetError(txtPrecio, "");

            if (txtCantidad.Text == "")
            {
                erpCompras.SetError(txtCantidad, "Ingresar la cantidad de producto a comprar");
                txtCantidad.Focus();
                return;
            }
            erpCompras.SetError(txtCantidad, "");

            if (int.Parse(txtPrecio.Text) <= 0)
            {
                erpCompras.SetError(txtPrecio, "El precio debe ser mayor a 0");
                txtPrecio.Focus();
                return;
            }
            erpCompras.SetError(txtPrecio, "");

            if (int.Parse(txtCantidad.Text) <= 0)
            {
                erpCompras.SetError(txtCantidad, "La cantidad de un producto debe ser mayor a 0");
                txtCantidad.Focus();
                return;
            }
            erpCompras.SetError(txtCantidad, "");

            txtIdProducto.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            if (txtIdProveedor.Text == "")
            {
                erpCompras.SetError(txtIdProveedor, "Ingresar el id del proveedor");
                txtIdProveedor.Focus();
                return;
            }
            erpCompras.SetError(txtIdProveedor, "");

            if (txtIdEmpleado.Text == "")
            {
                erpCompras.SetError(txtIdEmpleado, "Ingresar el id del empleado");
                txtIdEmpleado.Focus();
                return;
            }
            erpCompras.SetError(txtIdEmpleado, "");

            if (int.Parse(txtSubtotal.Text) <= 0)
            {
                erpCompras.SetError(txtSubtotal, "El subtotal debe ser mayor a 0");
                txtSubtotal.Focus();
                return;
            }
            erpCompras.SetError(txtSubtotal, "");

            if (int.Parse(txtIVA.Text) <= 0)
            {
                erpCompras.SetError(txtIVA, "El Iva debe ser mayor a 0");
                txtIVA.Focus();
                return;
            }
            erpCompras.SetError(txtIVA, "");

            if (int.Parse(txtTotal.Text) <= 0)
            {
                erpCompras.SetError(txtTotal, "El total debe ser mayor a 0");
                txtTotal.Focus();
                return;
            }
            erpCompras.SetError(txtTotal, "");

            txtIdProveedor.Clear();
            txtIdEmpleado.Clear();
            txtSubtotal.Clear();
            txtIVA.Clear();
            txtTotal.Clear();
        }

        private void btnBuscarCompra_Click(object sender, EventArgs e)
        {
            txtSubtotalBuscar.Clear();
        }

        #endregion

        #region Validaciones de solo números o letras

        private void txtIdProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtIdEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtIdProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPosicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        #endregion
    }
}
