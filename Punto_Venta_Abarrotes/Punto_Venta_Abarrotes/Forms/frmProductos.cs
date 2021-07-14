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
using Business;

namespace Punto_Venta_Abarrotes
{
    public partial class frmProductos : Form
    {
        #region Objetos

        private B_OperacionesProductos bTipo = new B_OperacionesProductos();
        private B_OperacionesProductos bProducto = new B_OperacionesProductos();
        private B_OperacionesProductos bUnidad = new B_OperacionesProductos();

        #endregion

        #region Variables

        string nombreProducto, nombreTipo, nombreUnidad, descripcionTipo, descripcionUnidad, PrecioProductoBuscar;
        decimal precioProducto, contenidoNeto;
        int idUnidad, idTipo, existencia, status;
        DateTime fechaCaducidad;

        #endregion

        public frmProductos()
        {
            InitializeComponent();

            seleccionarTipo();
            seleccionarUnidades();

            /*Mensajes de acciones de cada herramienta*/
            this.tltBuscar.SetToolTip(this.txtNombreBuscar, "Buscar producto por nombre");
            this.tltBuscar.SetToolTip(this.txtPrecioBuscar, "Buscar producto por precio");
            this.tltBuscar.SetToolTip(this.nudExistenciaBuscar, "Buscar producto por existencia");
            this.tltBuscar.SetToolTip(this.cmbTipoBuscar, "Buscar producto por el tipo");
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

            conversionesProducto();
            MessageBox.Show(bProducto.insertarProducto(nombreProducto, precioProducto, contenidoNeto, idUnidad, existencia, fechaCaducidad, idTipo, status));

            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtContenidoNeto.Clear();
            nudExistencia.Value = 0;
        }

        #endregion

        #region Validaiones de solo números y letras

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
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

        #region Busqueda de datos

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            nombreProducto = txtNombreBuscar.Text;
            dgvProductos.DataSource = bProducto.BuscarProducto(nombreProducto);

            txtNombreBuscar.Clear();
        }

        private void btnBuscarPrecio_Click(object sender, EventArgs e)
        {
            PrecioProductoBuscar = txtPrecioBuscar.Text;
            dgvProductos.DataSource = bProducto.BuscarProductoPrecio(Convert.ToDecimal(PrecioProductoBuscar));

            txtPrecioBuscar.Clear();
        }

        private void btnBuscarTipo_Click(object sender, EventArgs e)
        {
            nombreTipo = cmbTipo.Text;
            //dgvProductos.DataSource = bTipo.BuscarTipoProducto(nombreTipo);
        }

        #endregion

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            mostrarProducto();
        }

        private void conversionesProducto()
        {
            nombreProducto = txtNombre.Text.ToUpper();
            precioProducto = decimal.Parse(txtPrecio.Text.ToUpper());
            contenidoNeto = decimal.Parse(txtContenidoNeto.Text.ToUpper());
            idUnidad = Convert.ToInt32(cmbUnidad.SelectedValue);
            existencia = Convert.ToInt32(nudExistencia.Value);
            fechaCaducidad = dtpFechaCaduci.Value;
            idTipo = Convert.ToInt32(cmbTipo.SelectedValue);
            status = 1;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (rdbNombre.Checked == true)
            {
                lblNomBuscar.Visible = true;
                txtNombreBuscar.Visible = true;
                btnBuscarNombre.Visible = true;
                gpbBuscar.Visible = false;
                btnCambiarModoBusqueda.Visible = true;
            }
            else if (rdbPrecio.Checked == true)
            {
                lblPrecioBuscar.Visible = true;
                txtPrecioBuscar.Visible = true;
                btnBuscarPrecio.Visible = true;
                gpbBuscar.Visible = false;
                btnCambiarModoBusqueda.Visible = true;
            }
            else if (rdbExistencia.Checked == true)
            {
                lblExistenciaBuscar.Visible = true;
                nudExistenciaBuscar.Visible = true;
                btnBuscarExistencia.Visible = true;
                gpbBuscar.Visible = false;
                btnCambiarModoBusqueda.Visible = true;
            }
            else
            {
                lblTipoBuscar.Visible = true;
                cmbTipoBuscar.Visible = true;
                btnBuscarTipo.Visible = true;
                gpbBuscar.Visible = false;
                btnCambiarModoBusqueda.Visible = true;
            }
        }

        private void btnCambiarModoBusqueda_Click(object sender, EventArgs e)
        {
            gpbBuscar.Visible = true;
            lblNomBuscar.Visible = false;
            lblPrecioBuscar.Visible = false;
            lblExistenciaBuscar.Visible = false;
            lblTipoBuscar.Visible = false;
            txtNombreBuscar.Visible = false;
            txtPrecioBuscar.Visible = false;
            nudExistenciaBuscar.Visible = false;
            cmbTipoBuscar.Visible = false;
            btnBuscarTipo.Visible = false;
            btnCambiarModoBusqueda.Visible = false;
        }

        

        public void mostrarProducto()
        {
            dgvProductos.DataSource = bProducto.mostrarProducto();
        }

        public void seleccionarTipo()
        {
            var lista = bTipo.seleccionarTipos();
            cmbTipo.DataSource = lista;
            cmbTipo.DisplayMember = "nombre";
            //cmbTipoBuscar.DisplayMember = "nombre";
            cmbTipo.ValueMember = "idTipo";
            //cmbTipoBuscar.ValueMember = "idTipo";
        }

        public void seleccionarUnidades()
        {
            var lista = bUnidad.seleccionarUnidad();
            cmbUnidad.DataSource = lista;
            cmbUnidad.DisplayMember = "nombre";
            cmbUnidad.ValueMember = "idUnidad";
        }
    }
}
