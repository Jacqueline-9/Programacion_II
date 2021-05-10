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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();

            /*Mensajes de acciones de cada herramienta*/
            this.tltBuscar.SetToolTip(this.txtNombreBuscar, "Buscar producto por nombre");
            this.tltBuscar.SetToolTip(this.txtPrecioBuscar, "Buscar producto por precio");
            this.tltBuscar.SetToolTip(this.nudExistenciaBuscar, "Buscar producto por existencia");
            this.tltBuscar.SetToolTip(this.cmbTipoBuscar, "Buscar producto por el tipo");
            this.tltBuscar.SetToolTip(this.txtEstatus, "1 activo y 0 inactivo");
        }

        #region Mostrar Fecha y Hora

        private void tmrHoraFecha_Tick(object sender, EventArgs e)
        {
            lblMostrarFecha.Text = DateTime.Now.ToLongDateString();
            lblMostrarHora.Text = DateTime.Now.ToLongTimeString();
        }

        #endregion

        #region Validaciones 

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Regex reNombre = new Regex("^[a-zA-Z]*$", RegexOptions.Compiled);
            if (!reNombre.IsMatch(txtNombre.Text))
            {
                erpProductos.SetError(txtNombre, "Debe colocar un nombre válido");
                txtNombre.Focus();
                return;
            }
            erpProductos.SetError(txtNombre, "");

            if (txtNombre.Text == "")
            {
                erpProductos.SetError(txtNombre, "Favor de ingresar el nombre del producto");
                txtNombre.Focus();
                return;
            }
            erpProductos.SetError(txtNombre, "");

            if (txtDescripcion.Text == "")
            {
                erpProductos.SetError(txtDescripcion, "Favor de ingresar una descrupción del producto");
                txtDescripcion.Focus();
                return;
            }
            erpProductos.SetError(txtDescripcion, "");

            if (txtPrecio.Text == "")
            {
                erpProductos.SetError(txtPrecio, "Favor de ingresar el precio del producto");
                txtPrecio.Focus();
                return;
            }
            erpProductos.SetError(txtPrecio, "");

            if (txtContenidoNeto.Text == "")
            {
                erpProductos.SetError(txtContenidoNeto, "Favor de ingresar el contenido del producto");
                txtContenidoNeto.Focus();
                return;
            }
            erpProductos.SetError(txtContenidoNeto, "");

            if (nudExistencia.Text == "")
            {
                erpProductos.SetError(nudExistencia, "Favor de ingresar la existencia del producto");
                nudExistencia.Focus();
                return;
            }
            erpProductos.SetError(nudExistencia, "");

            if (txtEstatus.Text == "")
            {
                erpProductos.SetError(txtEstatus, "Favor de ingresar el estatus del producto");
                txtEstatus.Focus();
                return;
            }
            erpProductos.SetError(txtEstatus, "");

            if (int.Parse(txtPrecio.Text) <= 0)
            {
                erpProductos.SetError(txtPrecio, "El precio debe ser mayor a 0");
                txtPrecio.Focus();
                return;
            }
            erpProductos.SetError(txtPrecio, "");

            if (int.Parse(txtContenidoNeto.Text) <= 0)
            {
                erpProductos.SetError(txtContenidoNeto, "El contenido del producto debe ser mayor a 0");
                txtContenidoNeto.Focus();
                return;
            }
            erpProductos.SetError(txtContenidoNeto, "");

            if (int.Parse(nudExistencia.Text) > 10)
            {
                erpProductos.SetError(nudExistencia, "Las existencias de los productos no deben ser mayor a 10");
                nudExistencia.Focus();
                return;
            }
            erpProductos.SetError(nudExistencia, "");

            txtNombre.Clear();
            txtPrecio.Clear();
            txtContenidoNeto.Clear();
            nudExistencia.Value = 0;
            txtEstatus.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Regex reNombre = new Regex("^[a-zA-Z]*$", RegexOptions.Compiled);
            if (!reNombre.IsMatch(txtNombreBuscar.Text))
            {
                erpProductos.SetError(txtNombreBuscar, "Debe colocar un nombre válido");
                txtNombreBuscar.Focus();
                return;
            }
            erpProductos.SetError(txtNombreBuscar, "");

            txtNombreBuscar.Clear();
            txtPrecioBuscar.Clear();
            nudExistenciaBuscar.Value = 0;
        }

        #endregion

        #region Validaiones de solo números y letras

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar<= 255))
            {
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            } 
        }

        private void txtContenidoNeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPrecioBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtEstatus_KeyPress(object sender, KeyPressEventArgs e)
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
