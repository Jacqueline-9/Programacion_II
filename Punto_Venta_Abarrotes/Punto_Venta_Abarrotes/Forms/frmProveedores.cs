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
    public partial class frmProveedores : Form
    {
        #region Objetos

        private B_OperacionesProveedor bProveedor = new B_OperacionesProveedor();
        private B_OperacionesProveedor bMunicipio = new B_OperacionesProveedor();
        private B_OperacionesProveedor bLocalidad = new B_OperacionesProveedor();
        private B_OperacionesProveedor bColonia = new B_OperacionesProveedor();
        private B_OperacionesProveedor bCalle = new B_OperacionesProveedor();
        private B_OperacionesProveedor bDomicilio = new B_OperacionesProveedor();

        #endregion

        #region Variables globales

        string razonSocial, telefono;
        int idProveedor, idDomicilio, status;

        #endregion

        public frmProveedores()
        {
            InitializeComponent();

            seleccionarMunicipio();
            seleccionarLocalidad();
            seleccionarColonia();
            seleccionarCalle();
            seleccionarDomicilio();
        }

        #region Mostrar Fecha Y hora

        private void tmrFechaHera_Tick(object sender, EventArgs e)
        {
            lblMostrarFecha.Text = DateTime.Now.ToLongDateString();
            lblMostrarHora.Text = DateTime.Now.ToLongTimeString();
        }


        #endregion

        #region Registrar proveedor

        private void btnRegistrarEntidades_Click(object sender, EventArgs e)
        {
            Regex reTelefono = new Regex("[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]", RegexOptions.Compiled);
            if (!reTelefono.IsMatch(txtTelefonoProveedor.Text))
            {
                erpProveedores.SetError(txtTelefonoProveedor, "Debe colocar un telefono valido");
                txtTelefonoProveedor.Focus();
                return;
            }
            erpProveedores.SetError(txtTelefonoProveedor, "");

            if (txtRazonSocial.Text == "")
            {
                erpProveedores.SetError(txtRazonSocial, "Favor de ingresar el nombre de la entidad");
                txtRazonSocial.Focus();
                return;
            }
            erpProveedores.SetError(txtRazonSocial, "");

            if (txtTelefonoProveedor.Text == "")
            {
                erpProveedores.SetError(txtTelefonoProveedor, "Favor de ingresar el teléfono de la entidad");
                txtTelefonoProveedor.Focus();
                return;
            }
            erpProveedores.SetError(txtTelefonoProveedor, "");

            //INSERTAR PROVEEDORES
            conversionesProveedor();
            MessageBox.Show(bProveedor.insertarProveedor(razonSocial, telefono, idDomicilio, status));

            txtRazonSocial.Clear();
            txtTelefonoProveedor.Clear();
        }

        #endregion

        #region Mostrar proveedores en el dgv

        private void btnVerEntidades_Click(object sender, EventArgs e)
        {
            mostrarProveedores();
        }

        #endregion

        #region Buscar proveedores

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtRazonSocialBuscar.Text != "")
            {
                razonSocial = txtRazonSocialBuscar.Text;
                dgvProveedores.DataSource = bProveedor.BuscarProveedor(razonSocial);
            }
            else
            {
                mostrarProveedores();
            }

            /*razonSocial = txtRazonSocialBuscar.Text;
            dgvProveedores.DataSource = bProveedor.BuscarProveedor(razonSocial);

            txtRazonSocialBuscar.Clear();*/
        }

        #endregion

        #region Actualizar proveedores

        private void btnActualizarEntidades_Click(object sender, EventArgs e)
        {
            conversionesProveedor();
            idProveedor = Convert.ToInt32(lblIdProveedor.Text);
            MessageBox.Show(bProveedor.actualizarProveedor(idProveedor, razonSocial, telefono, idDomicilio), "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvProveedores.DataSource = bProveedor.mostrarProveedor();
        }

        #endregion

        #region Conversiones 

        private void conversionesProveedor()
        {
            
            razonSocial = txtRazonSocial.Text.ToUpper();
            telefono = txtTelefonoProveedor.Text.ToUpper();
            idDomicilio = Convert.ToInt32(cmbNumExt.SelectedValue);
            idDomicilio = Convert.ToInt32(cmbNumInt.SelectedValue);

            status = 1;
        }

        #endregion

        #region Métodos para mostrar la información en los cmb

        public void seleccionarMunicipio()
        {
            var lista = bMunicipio.seleccionarMunicipios();
            cmbMunicipios.DataSource = lista;
            cmbMunicipios.DisplayMember = "nombre";
            cmbMunicipios.ValueMember = "idMunicipio";
        }

        public void seleccionarLocalidad()
        {
            var lista = bLocalidad.seleccionarLocalidades();
            cmbLocalidades.DataSource = lista;
            cmbLocalidades.DisplayMember = "nombre";
            cmbLocalidades.ValueMember = "idLocalidad";
        }

        public void seleccionarColonia()
        {
            var lista = bColonia.seleccionarColonias();
            cmbColonias.DataSource = lista;
            cmbColonias.DisplayMember = "nombre";
            cmbColonias.ValueMember = "idColonia";
        }

        public void seleccionarCalle()
        {
            var lista = bCalle.seleccionarCalles();
            cmbCalles.DataSource = lista;
            cmbCalles.DisplayMember = "nombre";
            cmbCalles.ValueMember = "idCalle";
        }

        public void seleccionarDomicilio()
        {
            var lista = bDomicilio.seleccionarDomicilios();
            cmbNumExt.DataSource = lista;
            cmbNumInt.DataSource = lista;
            cmbNumExt.DisplayMember = "numeroExt";
            cmbNumInt.DisplayMember = "numeroInt";
            cmbNumExt.ValueMember = "idDomicilio";
            cmbNumInt.ValueMember = "idDomicilio";
        }

        #endregion

        #region Evento para mostrar la columna del dgv en los controles

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIdProveedor.Text = dgvProveedores.CurrentRow.Cells[0].Value.ToString();
            txtRazonSocial.Text = dgvProveedores.CurrentRow.Cells[1].Value.ToString();
            txtTelefonoProveedor.Text = dgvProveedores.CurrentRow.Cells[2].Value.ToString();
            cmbMunicipios.Text = dgvProveedores.CurrentRow.Cells[3].Value.ToString();
            cmbLocalidades.Text = dgvProveedores.CurrentRow.Cells[4].Value.ToString();
            cmbColonias.Text = dgvProveedores.CurrentRow.Cells[5].Value.ToString();
            cmbCalles.Text = dgvProveedores.CurrentRow.Cells[6].Value.ToString();
            cmbNumExt.Text = dgvProveedores.CurrentRow.Cells[7].Value.ToString();
            cmbNumInt.Text = dgvProveedores.CurrentRow.Cells[8].Value.ToString();
        }

        #endregion

        #region Método para mostrar los proveedores

        public void mostrarProveedores()
        {
            dgvProveedores.DataSource = bProveedor.mostrarProveedor();
            dgvProveedores.Columns["idProveedor"].Visible = false;
        }

        #endregion
    }
}
