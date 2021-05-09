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

namespace Punto_Venta_Abarrotes
{
    public partial class frmUsuarios : Form
    {
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

        private void btnRegistrarEntidades_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text == "")
            {
                erpUsuarios.SetError(txtNombreUsuario, "Favor de ingresar el nombre de usuario");
                txtNombreUsuario.Focus();
                return;
            }
            erpUsuarios.SetError(txtNombreUsuario, "");

            if (txtCorreo.Text == "")
            {
                erpUsuarios.SetError(txtCorreo, "Favor de ingresar el correo del usuario");
                txtCorreo.Focus();
                return;
            }
            erpUsuarios.SetError(txtCorreo, "");

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

            if (txtEstatus.Text == "")
            {
                erpUsuarios.SetError(txtEstatus, "Favor de ingresar el estatus del usuario");
                txtEstatus.Focus();
                return;
            }
            erpUsuarios.SetError(txtEstatus, "");

            txtNombreUsuario.Clear();
            txtCorreo.Clear();
            txtContrasenia.Clear();
            txtEstatus.Clear();
        }

        private void btnBuscarUsuarios_Click(object sender, EventArgs e)
        {
            txtNombreUserBuscar.Clear();
        }

        #endregion
    }
}
