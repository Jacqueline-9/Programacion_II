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
    public partial class frmPuestos : Form
    {
        public frmPuestos()
        {
            InitializeComponent();

            /*Mensajes de acciones de cada herramienta*/
            this.tltBuscar.SetToolTip(this.txtNombrePuestoBuscar, "Buscar puesto por nombre");
            this.tltBuscar.SetToolTip(this.txtNombreTurnoBuscar, "Buscarturno por nombre");
            this.tltBuscar.SetToolTip(this.txtEstatusPuesto, "1 activo y 0 inactivo");
            this.tltBuscar.SetToolTip(this.txtEstatusTurno, "1 activo y 0 inactivo");
        }

        #region Fecha y Hora

        private void tmrFechaHora_Tick(object sender, EventArgs e)
        {
            lblMostrarFecha.Text = DateTime.Now.ToLongDateString();
            lblMostrarHora.Text = DateTime.Now.ToLongTimeString();
        }


        #endregion

        #region Validaciones

        private void btnRegistrarPuestos_Click(object sender, EventArgs e)
        {
            if (txtSalario.Text == "")
            {
                erpPuestosTurnos.SetError(txtSalario, "Favor de ingresar el salario del puesto");
                txtSalario.Focus();
                return;
            }
            erpPuestosTurnos.SetError(txtSalario, "");

            if (txtDescripcionTurno.Text == "")
            {
                erpPuestosTurnos.SetError(txtDescripcionTurno, "Favor de ingresar la descripción del puesto");
                txtDescripcionTurno.Focus();
                return;
            }
            erpPuestosTurnos.SetError(txtDescripcionTurno, "");

            if (txtEstatusPuesto.Text == "")
            {
                erpPuestosTurnos.SetError(txtEstatusPuesto, "Favor de ingresar el estatus del puesto");
                txtEstatusPuesto.Focus();
                return;
            }
            erpPuestosTurnos.SetError(txtEstatusPuesto, "");

            txtSalario.Clear();
            txtDescripcionTurno.Clear();
            txtEstatusPuesto.Clear();
        }

        private void btnBuscarPuestos_Click(object sender, EventArgs e)
        {
            txtNombrePuestoBuscar.Clear();
        }

        private void btnRegistrarTurno_Click(object sender, EventArgs e)
        {
            if (txtEstatusTurno.Text == "")
            {
                erpPuestosTurnos.SetError(txtEstatusTurno, "Favor de ingresar el estatus del turno");
                txtEstatusTurno.Focus();
                return;
            }
            erpPuestosTurnos.SetError(txtEstatusTurno, "");

            txtEstatusTurno.Clear();
        }

        private void btnTurnoBuscar_Click(object sender, EventArgs e)
        {
            txtNombreTurnoBuscar.Clear();
        }

        #endregion
    }
}
