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
    public partial class frmClientes : Form
    {
        #region Objetos

        private B_OperacionesClientes bCliente = new B_OperacionesClientes();
        private B_OperacionesClientes bMunicipio = new B_OperacionesClientes();
        private B_OperacionesClientes bLocalidad = new B_OperacionesClientes();
        private B_OperacionesClientes bColonia = new B_OperacionesClientes();
        private B_OperacionesClientes bCalle = new B_OperacionesClientes();
        private B_OperacionesClientes bDomicilio = new B_OperacionesClientes();

        #endregion

        #region Variables globales

        string nombre, apPaterno, apMaterno, telefono, curp;
        DateTime fechaNac;
        int idCliente, idDomicilio, status;

        #endregion

        public frmClientes()
        {
            InitializeComponent();

            seleccionarMunicipio();
            seleccionarLocalidad();
            seleccionarColonia();
            seleccionarCalle();
            seleccionarDomicilio();

            /*Mensajes de acciones de cada herramienta*/
            this.tltBuscar.SetToolTip(this.txtNombreBuscar, "Buscar cliente por nombre");
            this.tltBuscar.SetToolTip(this.txtApePatCliente, "Buscar cliente por apellido paterno");
            this.tltBuscar.SetToolTip(this.txtApeMatBuscar, "Buscar cliente por apellido materno");
        }

        #region Mostrar Fecha y Hora

        private void tmrFechaHora_Tick(object sender, EventArgs e)
        {
            lblMostrarFecha.Text = DateTime.Now.ToLongDateString();
            lblMostrarHora.Text = DateTime.Now.ToLongTimeString();
        }

        #endregion

        #region RegistrarCliente 

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

            erpClientes.SetError(txtApeMatCliente, "");

            Regex reTelefono = new Regex("[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]", RegexOptions.Compiled);
            if (!reTelefono.IsMatch(txtTelefonoCliente.Text))
            {
                erpClientes.SetError(txtTelefonoCliente, "Debe colocar un telefono valido");
                txtTelefonoCliente.Focus();
                return;
            }
            erpClientes.SetError(txtTelefonoCliente, "");

            if (txtTelefonoCliente.Text == "")
            {
                erpClientes.SetError(txtTelefonoCliente, "Favor de ingresar el teléfono del cliente");
                txtTelefonoCliente.Focus();
                return;
            }
            erpClientes.SetError(txtTelefonoCliente, "");

            Regex reCurp = new Regex("^.*(?=.{18})(?=.*[0-9])(?=.*[A-ZÑ]).*$", RegexOptions.Compiled);
            if (!reCurp.IsMatch(txtCurp.Text))
            {
                erpClientes.SetError(txtCurp, "Debe colocar una curp válida");
                txtCurp.Focus();
                return;
            }
            erpClientes.SetError(txtCurp, "");

            if (txtCurp.Text == "")
            {
                erpClientes.SetError(txtCurp, "Favor de ingresar la curp del cliente");
                txtCurp.Focus();
                return;
            }
            erpClientes.SetError(txtCurp, "");

            //INSERTAR CLIENTES
            conversionesCliente();
            MessageBox.Show(bCliente.insertarCliente(nombre, apPaterno, apMaterno, fechaNac, telefono, idDomicilio, curp, status));

            txtNombreCliente.Clear();
            txtApePatCliente.Clear();
            txtApeMatCliente.Clear();
            txtTelefonoCliente.Clear();
            txtCurp.Clear();
        }

        private void btnBuscarClientes_Click(object sender, EventArgs e)
        {
            Regex reNombre = new Regex("^[a-zA-Z]*$", RegexOptions.Compiled);
            if (!reNombre.IsMatch(txtNombreBuscar.Text))
            {
                erpClientes.SetError(txtNombreBuscar, "Debe colocar un nombre válido");
                txtNombreBuscar.Focus();
                return;
            }
            erpClientes.SetError(txtNombreBuscar, "");

            Regex reApellido = new Regex("^[a-zA-Z]*$", RegexOptions.Compiled);
            if (!reApellido.IsMatch(txtApPatBuscar.Text))
            {
                erpClientes.SetError(txtApPatBuscar, "Debe colocar un apellido válido");
                txtApPatBuscar.Focus();
                return;
            }
            erpClientes.SetError(txtApPatBuscar, "");

            if (!reApellido.IsMatch(txtApeMatBuscar.Text))
            {
                erpClientes.SetError(txtApeMatBuscar, "Debe colocar un apellido válido");
                txtApeMatBuscar.Focus();
                return;
            }
            erpClientes.SetError(txtApeMatBuscar, "");

            txtNombreBuscar.Clear();
            txtApePatCliente.Clear();
            txtApeMatBuscar.Clear();
        }

        #endregion

        #region Validaciones de solo letras o numeros

        private void txtIdDomicilioCliente_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

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

        #region Mostrar clientes en el dgv 

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            mostrarClientes();
        }

        #endregion

        #region Método para mostrar clientes

        public void mostrarClientes()
        {
            dgvClientes.DataSource = bCliente.mostrarClientes();
            dgvClientes.Columns["idPersona"].Visible = false;
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

        #region Conversiones 

        private void conversionesCliente()
        {

            nombre = txtNombreCliente.Text.ToUpper();
            apPaterno = txtApePatCliente.Text.ToUpper();
            apMaterno = txtApeMatCliente.Text.ToUpper();
            fechaNac = dtpFechaNac.Value;
            telefono = txtTelefonoCliente.Text.ToUpper();
            idDomicilio = Convert.ToInt32(cmbNumExt.SelectedValue);
            idDomicilio = Convert.ToInt32(cmbNumInt.SelectedValue);
            curp = txtCurp.Text.ToUpper();
            status = 1;
        }

        #endregion
    }
}
