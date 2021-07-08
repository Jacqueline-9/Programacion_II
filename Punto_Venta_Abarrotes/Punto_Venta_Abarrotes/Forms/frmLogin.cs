﻿using System;
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
    public partial class frmLogin : Form
    {
        public string usuario = ""; /*Varible global*/

        public frmLogin()
        {
            InitializeComponent();

            /*Mensajes de acciones de cada herramienta*/
            this.tltHelp.SetToolTip(this.txtUsuario, "Ingresar usuario");
            this.tltHelp.SetToolTip(this.txtContrasenia, "Ingresar contraseña");
            this.tltHelp.SetToolTip(this.ckbMostrarContra, "Precione para mostrar u ocultar contraseña");
            this.tltHelp.SetToolTip(this.btnAcceder, "De click para acceder");
            this.tltHelp.SetToolTip(this.linkLblContrasenia, "De click en caso de que haya olvidado su contraseña");
            this.tltHelp.SetToolTip(this.ptbClose, "De click para cerrar el programa");
            this.tltHelp.SetToolTip(this.ptbMinimix, "De click para miximizar la pantalla");
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           // Conexion conex = new Conexion();
            //conex.abrir();
        }

        #region Mover formulario

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion

        #region Evento Mouse Down

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
   
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region Evento Enter de los textbox usuario y contraseña

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Silver;
            }
        }

        private void txtContrasenia_Enter(object sender, EventArgs e)
        {
            if (txtContrasenia.Text == "CONTRASEÑA")
            {
                txtContrasenia.Text = "";
                txtContrasenia.ForeColor = Color.Silver;
                txtContrasenia.UseSystemPasswordChar = true;
            }
        }

        #endregion

        #region Evento Leave de los textbox usuario y contraseña

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Silver;
            }
        }

        private void txtContrasenia_Leave(object sender, EventArgs e)
        {
            if (txtContrasenia.Text == "")
            {
                txtContrasenia.Text = "CONTRASEÑA";
                txtContrasenia.ForeColor = Color.Silver;
                txtContrasenia.UseSystemPasswordChar = false;
            }
        }

        #endregion

        #region Eventos Click

        private void ptbMinimix_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Acceder Usuario

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                erpLogin.SetError(txtUsuario, "Favor de ingresar un usuario");
                txtUsuario.Focus();
                return;
            }
            erpLogin.SetError(txtUsuario, "");

            if (txtContrasenia.Text == "CONTRASEÑA")
            {
                erpLogin.SetError(txtContrasenia, "Favor de ingresar una contraseña");
                txtContrasenia.Focus();
                return;
            }
            erpLogin.SetError(txtContrasenia, "");

            if (txtUsuario.Text == "ADMIN")
            {
                if (txtContrasenia.Text == "Admin")
                {
                    frmInterfazPrincipal inter = new frmInterfazPrincipal();
                    inter.Show();
                    this.Hide();
                    usuario = txtUsuario.Text;
                }
                else
                {
                    MessageBox.Show("Contraseña no válida", "Login");
                }
            }
            else
            {
                MessageBox.Show("Usuario no válido", "Login");
            }
        }

        #endregion

        #region Mostrar y Ocultar Contraseña

        private void ckbMostrarContra_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMostrarContra.Checked == false)
            {
                txtContrasenia.UseSystemPasswordChar = true;
                var ckbMostrarContra = (CheckBox)sender;
                ckbMostrarContra.Text = "mostrar contraseña";
            }
            else
            {
                txtContrasenia.UseSystemPasswordChar = false;
                var ckbMostrarContra = (CheckBox)sender;
                ckbMostrarContra.Text = "ocultar contraseña";
            }
        }

        #endregion

        #region Acceder con tecla enter

        private void txtContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtUsuario.Text == "ADMIN")
                {
                    if (txtContrasenia.Text == "Admin")
                    {
                        frmInterfazPrincipal inter = new frmInterfazPrincipal();
                        inter.Show();
                        this.Hide();
                        usuario = txtUsuario.Text;
                    }
                    else
                    {
                        MessageBox.Show("Contraseña no válida", "Login");
                        txtContrasenia.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no válido", "Login");
                    txtUsuario.Clear();
                }
            }
        }

        #endregion

    }
}
