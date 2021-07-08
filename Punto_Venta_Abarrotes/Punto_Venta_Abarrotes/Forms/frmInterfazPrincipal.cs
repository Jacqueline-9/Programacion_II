using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Punto_Venta_Abarrotes
{
    public partial class frmInterfazPrincipal : Form
    {
        public frmInterfazPrincipal()
        {
            InitializeComponent();

            InicializarMenu();
        }

        #region Mover Formulario

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region Mostrar Logo al Iniciar 

        private void InterfazPrincipal_Load(object sender, EventArgs e)
        {
            ptbLogo_Click(null, e);
        }

        private void ptbLogo_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmLogo());
        }

        #endregion

        #region Método Abrir Formulario

        private void AbrirFormulario (Form form)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }

            Form formHijo = form;
            form.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formHijo);
            formHijo.Show();
        }

        #endregion

        #region Abrir formularios hijos

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmProductos());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmClientes());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmEmpleados());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmVentas());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmProveedores());
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCompras());
        }

        private void btnPuestosHoararios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmPuestos());
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmUsuarios());
        }

        private void ibtnDomicilio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmDomicilio());
        }

        private void btnPerdidas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmPerdidas());
        }

        private void brnReportesVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmReporteVentas());
        }

        private void btnReporteCompras_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new frmReporteCompras());
        }

        #endregion

        #region Eventos Click

        private void ptbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptbMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ptbMaximizar.Visible = false;
            ptbRestaurar.Visible = true;
        }

        private void ptbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            ptbRestaurar.Visible = false;
            ptbMaximizar.Visible = true;
        }


        #endregion

        #region Métodos de Inicialización 

        private void InicializarMenu()
        {
            panelSubmenuRepor.Visible = false;
        }

        #endregion

        #region Método Ocultar Submenu

        private void OcultarSubmenu()
        {
            if (panelSubmenuRepor.Visible == true)
            {
                panelSubmenuRepor.Visible = false;
            }
        }

        #endregion

        #region Método Mostrar Submenu

        private void MostrarSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                OcultarSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        #endregion

        #region Mostrar Submenu

        private void btnReportes_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelSubmenuRepor);
        }

        #endregion
    }
}
