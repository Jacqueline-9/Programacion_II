using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace Punto_Venta_Abarrotes
{
    public partial class frmUsuarios : Form
    {
        private B_OperacionesUsuarios bUsuarios = new B_OperacionesUsuarios();

        string nombre, correo, contrasenia;
        int status;

        public frmUsuarios()
        {
            InitializeComponent();

            /*Mensajes de acciones de cada herramienta*/
            this.tltBuscar.SetToolTip(this.txtNombreUserBuscar, "Buscar usuario por nombre");
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

        private void btnRegistrarUsuarios_Click(object sender, EventArgs e)
        {
            Regex regEmail = new Regex(@"^(([^<>()[\]\\.,;:\s@\""]+"
                                    + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                                    + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}]"
                                    + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                                    + @"[a-zA-Z]{2,}))$", RegexOptions.Compiled);

            if (!regEmail.IsMatch(txtCorreo.Text))
            {
                erpUsuarios.SetError(txtCorreo, "Debe ingresar una dirección de correo válida");
                txtCorreo.Focus();
                return;
            }
            erpUsuarios.SetError(txtCorreo, "");

            if (txtNombreUsuario.Text == "")
            {
                erpUsuarios.SetError(txtNombreUsuario, "Favor de ingresar el nombre de usuario");
                txtNombreUsuario.Focus();
                return;
            }
            erpUsuarios.SetError(txtNombreUsuario, "");

            if (txtEstatus.Text == "")
            {
                erpUsuarios.SetError(txtEstatus, "Favor de ingresar el estatus del usuario");
                txtEstatus.Focus();
                return;
            }
            erpUsuarios.SetError(txtEstatus, "");

            if (txtCorreo.Text == "")
            {
                erpUsuarios.SetError(txtCorreo, "Favor de ingresar el correo del usuario");
                txtCorreo.Focus();
                return;
            }
            erpUsuarios.SetError(txtCorreo, "");

            Conversiones();
            MessageBox.Show(bUsuarios.insertarUsuario(nombre, correo, contrasenia, status));

            txtNombreUsuario.Clear();
            txtCorreo.Clear();
            txtContrasenia.Clear();
            txtEstatus.Clear();
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

        private void btnBuscarUsuarios_Click(object sender, EventArgs e)
        {
            txtNombreUserBuscar.Clear();
        }

        #endregion

        #region Evento Enter

        private void txtContrasenia_Enter(object sender, EventArgs e)
        {
            txtContrasenia.Text = "";
            txtContrasenia.ForeColor = Color.Black;
            txtContrasenia.UseSystemPasswordChar = true;
        }

        #endregion

        public void Conversiones()
        {
            nombre = txtNombreUsuario.Text.ToUpper();
            correo = txtCorreo.Text.ToUpper();
            contrasenia = txtContrasenia.Text.ToUpper();
            status = int.Parse(txtEstatus.Text.ToUpper());
        }
    }
}
