using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace Punto_Venta_Abarrotes
{
    public partial class frmVentas : Form
    {
        #region Objeto 

        private B_OperacionesVenta bVenta = new B_OperacionesVenta();

        #endregion

        #region Variables globales

        int idProducto, cantidad, idCliente, idEmpleado;

        #endregion

        #region Constructor 

        public frmVentas()
        {
            InitializeComponent();
        }

        #endregion

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

        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            
            

            if (txtIdEmpleado.Text == "")
            {
                erpVentas.SetError(txtIdEmpleado, "Ingresar el id del empleado");
                txtIdEmpleado.Focus();
                return;
            }
            erpVentas.SetError(txtIdEmpleado, "");

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
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

        #region Proceso para ver clientes 

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            mostrarClientes();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIDClienteRes.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            lblNombreRes.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            lblApePaternoRes.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            lblApeMaternoRes.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            lblCurpRes.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
        }

        public void mostrarClientes()
        {
            dgvClientes.DataSource = bVenta.MostrarClientes();
            dgvClientes.Columns["idPersona"].Visible = false;
        }

        #endregion

        #region Proceso para ver productos 

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            mostrarProductos();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIdProductoRes.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            lblNombreProductoRes.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
        }

        public void mostrarProductos()
        {
            dgvProductos.DataSource = bVenta.MostrarProductos();
            dgvProductos.Columns["idProducto"].Visible = false;
        }

        #endregion

        #region Proceso para ver ventas 

        private void btnVerVentas_Click(object sender, EventArgs e)
        {
            mostrarVenta();
        }

        public void mostrarVenta()
        {
            dgvVentas.DataSource = bVenta.MostrarVenta();
        }

        #endregion

        #region Proceso para ver detalle de venta

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            mostrarDetalle();
        }

        public void mostrarDetalle()
        {
            dgvVentas.DataSource = bVenta.MostrarDetalle();
        }

        #endregion

        #region Elegir cliente

        private void btnElegirCliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cliente seleccionado", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                btnElegirCliente.Enabled = false;
            }
        }

        #endregion

        #region Método para agregar producto

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (nudCantidad.Value == 0)
            {
                erpVentas.SetError(nudCantidad, "El campo no puede quedar vacio");
                nudCantidad.Focus();
                return;
            }
            erpVentas.SetError(nudCantidad, "");

            if (MessageBox.Show("Producto seleccionado", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                conversionesVenta();
                MessageBox.Show(bVenta.insertarVenta(idProducto, cantidad, idEmpleado, idCliente), "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mostrarVentaProceso();
            }
        }

        public void mostrarVentaProceso()
        {
            dgvVentas.DataSource = bVenta.MostrarVentaProceso();
        }
        #endregion

        #region Método para insertar o realizar la venta

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La venta a sido exitosa", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        #endregion

        #region Conversiones de la venta 

        private void conversionesVenta()
        {
            idProducto = Convert.ToInt32(lblIdProductoRes.Text);
            cantidad = Convert.ToInt32(nudCantidad.Value);
            idEmpleado = Convert.ToInt32(txtIdEmpleado.Text);
            idCliente = Convert.ToInt32(lblIDClienteRes.Text);
        }

        #endregion
    }
}
