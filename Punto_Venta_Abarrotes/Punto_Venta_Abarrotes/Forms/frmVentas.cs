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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();

            /*Mensajes de acciones de cada herramienta*/
            this.tltBuscar.SetToolTip(this.txtSubtotalBuscar, "Buscar venta por subtotal");
            this.tltBuscar.SetToolTip(this.dtpFechaRealiBuscar, "Buscar venta por fecha de relización");
            this.tltBuscar.SetToolTip(this.txtPosicion, "La posición comienza en 0");
        }

        #region Mostrar Fecha y Hora

        private void tmrHoraFecha_Tick(object sender, EventArgs e)
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
                erpVentas.SetError(txtIdProducto, "Ingresar el producto");
                txtIdProducto.Focus();
                return;
            }
            erpVentas.SetError(txtIdProducto, "");

            if (txtPrecio.Text == "")
            {
                erpVentas.SetError(txtPrecio, "Ingresar el precio del producto");
                txtPrecio.Focus();
                return;
            }
            erpVentas.SetError(txtPrecio, "");

            if (txtCantidad.Text == "")
            {
                erpVentas.SetError(txtCantidad, "Ingresar la cantidad de producto a comprar");
                txtCantidad.Focus();
                return;
            }
            erpVentas.SetError(txtCantidad, "");

            if (int.Parse(txtPrecio.Text) <= 0)
            {
                erpVentas.SetError(txtPrecio, "El precio debe ser mayor a 0");
                txtPrecio.Focus();
                return;
            }
            erpVentas.SetError(txtPrecio, "");

            if (int.Parse(txtCantidad.Text) <= 0)
            {
                erpVentas.SetError(txtCantidad, "La cantidad de un producto debe ser mayor a 0");
                txtCantidad.Focus();
                return;
            }
            erpVentas.SetError(txtCantidad, "");

            txtIdProducto.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (txtIdCliente.Text == "")
            {
                erpVentas.SetError(txtIdCliente, "Ingresar el id del cliente");
                txtIdCliente.Focus();
                return;
            }
            erpVentas.SetError(txtIdCliente, "");

            if (txtIdEmpleado.Text == "")
            {
                erpVentas.SetError(txtIdEmpleado, "Ingresar el id del empleado");
                txtIdEmpleado.Focus();
                return;
            }
            erpVentas.SetError(txtIdEmpleado, "");

            if (int.Parse(txtSubtotal.Text) <= 0)
            {
                erpVentas.SetError(txtPrecio, "El subtotal debe ser mayor a 0");
                txtSubtotal.Focus();
                return;
            }
            erpVentas.SetError(txtSubtotal, "");

            if (int.Parse(txtIVA.Text) <= 0)
            {
                erpVentas.SetError(txtPrecio, "El Iva debe ser mayor a 0");
                txtIVA.Focus();
                return;
            }
            erpVentas.SetError(txtIVA, "");

            if (int.Parse(txtTotal.Text) <= 0)
            {
                erpVentas.SetError(txtPrecio, "El total debe ser mayor a 0");
                txtTotal.Focus();
                return;
            }
            erpVentas.SetError(txtTotal, "");

            txtIdCliente.Clear();
            txtIdEmpleado.Clear();
            txtSubtotal.Clear();
            txtIVA.Clear();
            txtTotal.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtSubtotalBuscar.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtIdCliente.Clear();
            txtIdEmpleado.Clear();
            txtSubtotal.Clear();
            txtIVA.Clear();
            txtTotal.Clear();
            ListProductos.Items.Clear();
        }

        #endregion

        #region Validaciones de solo numeros y letras

        private void txtIdCliente_KeyPress(object sender, KeyPressEventArgs e)
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
