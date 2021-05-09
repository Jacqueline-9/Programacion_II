namespace Punto_Venta_Abarrotes
{
    partial class frmUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ptbUsuarios = new System.Windows.Forms.PictureBox();
            this.gpbRegistrarUsuario = new System.Windows.Forms.GroupBox();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.btnRegistrarUsuarios = new System.Windows.Forms.Button();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.gpbBuscarUsuarios = new System.Windows.Forms.GroupBox();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.lblNombreUserBuscar = new System.Windows.Forms.Label();
            this.txtNombreUserBuscar = new System.Windows.Forms.TextBox();
            this.dgvRazonSocial = new System.Windows.Forms.DataGridView();
            this.btnVerUsuarios = new System.Windows.Forms.Button();
            this.btnBorrarUsuarios = new System.Windows.Forms.Button();
            this.btnActualizarUsuarios = new System.Windows.Forms.Button();
            this.btnBuscarUsuarios = new System.Windows.Forms.Button();
            this.paneFechaHora = new System.Windows.Forms.Panel();
            this.lblMostrarHora = new System.Windows.Forms.Label();
            this.lblMostrarFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.tmrFechaHora = new System.Windows.Forms.Timer(this.components);
            this.tltBuscar = new System.Windows.Forms.ToolTip(this.components);
            this.erpUsuarios = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsuarios)).BeginInit();
            this.gpbRegistrarUsuario.SuspendLayout();
            this.gpbBuscarUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRazonSocial)).BeginInit();
            this.paneFechaHora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbUsuarios
            // 
            this.ptbUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbUsuarios.Image = global::Punto_Venta_Abarrotes.Properties.Resources.ptbUsuarios;
            this.ptbUsuarios.Location = new System.Drawing.Point(387, 12);
            this.ptbUsuarios.Name = "ptbUsuarios";
            this.ptbUsuarios.Size = new System.Drawing.Size(365, 76);
            this.ptbUsuarios.TabIndex = 71;
            this.ptbUsuarios.TabStop = false;
            // 
            // gpbRegistrarUsuario
            // 
            this.gpbRegistrarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbRegistrarUsuario.Controls.Add(this.txtEstatus);
            this.gpbRegistrarUsuario.Controls.Add(this.lblEstatus);
            this.gpbRegistrarUsuario.Controls.Add(this.txtContrasenia);
            this.gpbRegistrarUsuario.Controls.Add(this.txtCorreo);
            this.gpbRegistrarUsuario.Controls.Add(this.lblContrasenia);
            this.gpbRegistrarUsuario.Controls.Add(this.btnRegistrarUsuarios);
            this.gpbRegistrarUsuario.Controls.Add(this.lblCorreo);
            this.gpbRegistrarUsuario.Controls.Add(this.lblNombreUsuario);
            this.gpbRegistrarUsuario.Controls.Add(this.txtNombreUsuario);
            this.gpbRegistrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbRegistrarUsuario.ForeColor = System.Drawing.Color.White;
            this.gpbRegistrarUsuario.Location = new System.Drawing.Point(12, 107);
            this.gpbRegistrarUsuario.Name = "gpbRegistrarUsuario";
            this.gpbRegistrarUsuario.Size = new System.Drawing.Size(1056, 181);
            this.gpbRegistrarUsuario.TabIndex = 73;
            this.gpbRegistrarUsuario.TabStop = false;
            this.gpbRegistrarUsuario.Text = "Registrar usuario";
            // 
            // txtEstatus
            // 
            this.txtEstatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstatus.Location = new System.Drawing.Point(664, 89);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(367, 23);
            this.txtEstatus.TabIndex = 41;
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatus.ForeColor = System.Drawing.Color.White;
            this.lblEstatus.Location = new System.Drawing.Point(574, 88);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(70, 24);
            this.lblEstatus.TabIndex = 40;
            this.lblEstatus.Text = "Estatus";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenia.Location = new System.Drawing.Point(167, 92);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(364, 23);
            this.txtContrasenia.TabIndex = 33;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(664, 45);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(367, 23);
            this.txtCorreo.TabIndex = 32;
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenia.ForeColor = System.Drawing.Color.White;
            this.lblContrasenia.Location = new System.Drawing.Point(20, 92);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(106, 24);
            this.lblContrasenia.TabIndex = 27;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // btnRegistrarUsuarios
            // 
            this.btnRegistrarUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRegistrarUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegistrarUsuarios.FlatAppearance.BorderSize = 0;
            this.btnRegistrarUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRegistrarUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnRegistrarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarUsuarios.Location = new System.Drawing.Point(390, 134);
            this.btnRegistrarUsuarios.Name = "btnRegistrarUsuarios";
            this.btnRegistrarUsuarios.Size = new System.Drawing.Size(333, 31);
            this.btnRegistrarUsuarios.TabIndex = 31;
            this.btnRegistrarUsuarios.Text = "Registrar";
            this.btnRegistrarUsuarios.UseVisualStyleBackColor = false;
            this.btnRegistrarUsuarios.Click += new System.EventHandler(this.btnRegistrarEntidades_Click);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(576, 46);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(68, 24);
            this.lblCorreo.TabIndex = 25;
            this.lblCorreo.Text = "Correo";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNombreUsuario.Location = new System.Drawing.Point(20, 45);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(173, 24);
            this.lblNombreUsuario.TabIndex = 20;
            this.lblNombreUsuario.Text = "Nombre de usuario";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(199, 46);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(332, 23);
            this.txtNombreUsuario.TabIndex = 18;
            // 
            // gpbBuscarUsuarios
            // 
            this.gpbBuscarUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbBuscarUsuarios.Controls.Add(this.lblBuscarPor);
            this.gpbBuscarUsuarios.Controls.Add(this.lblNombreUserBuscar);
            this.gpbBuscarUsuarios.Controls.Add(this.txtNombreUserBuscar);
            this.gpbBuscarUsuarios.Controls.Add(this.dgvRazonSocial);
            this.gpbBuscarUsuarios.Controls.Add(this.btnVerUsuarios);
            this.gpbBuscarUsuarios.Controls.Add(this.btnBorrarUsuarios);
            this.gpbBuscarUsuarios.Controls.Add(this.btnActualizarUsuarios);
            this.gpbBuscarUsuarios.Controls.Add(this.btnBuscarUsuarios);
            this.gpbBuscarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBuscarUsuarios.ForeColor = System.Drawing.Color.White;
            this.gpbBuscarUsuarios.Location = new System.Drawing.Point(12, 294);
            this.gpbBuscarUsuarios.Name = "gpbBuscarUsuarios";
            this.gpbBuscarUsuarios.Size = new System.Drawing.Size(1056, 272);
            this.gpbBuscarUsuarios.TabIndex = 75;
            this.gpbBuscarUsuarios.TabStop = false;
            this.gpbBuscarUsuarios.Text = "Usuarios";
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPor.Location = new System.Drawing.Point(17, 26);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(76, 16);
            this.lblBuscarPor.TabIndex = 81;
            this.lblBuscarPor.Text = "Buscar por:";
            // 
            // lblNombreUserBuscar
            // 
            this.lblNombreUserBuscar.AutoSize = true;
            this.lblNombreUserBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUserBuscar.ForeColor = System.Drawing.Color.White;
            this.lblNombreUserBuscar.Location = new System.Drawing.Point(17, 53);
            this.lblNombreUserBuscar.Name = "lblNombreUserBuscar";
            this.lblNombreUserBuscar.Size = new System.Drawing.Size(123, 16);
            this.lblNombreUserBuscar.TabIndex = 80;
            this.lblNombreUserBuscar.Text = "Nombre de usuario";
            // 
            // txtNombreUserBuscar
            // 
            this.txtNombreUserBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUserBuscar.Location = new System.Drawing.Point(146, 50);
            this.txtNombreUserBuscar.Name = "txtNombreUserBuscar";
            this.txtNombreUserBuscar.Size = new System.Drawing.Size(385, 22);
            this.txtNombreUserBuscar.TabIndex = 79;
            // 
            // dgvRazonSocial
            // 
            this.dgvRazonSocial.AllowUserToAddRows = false;
            this.dgvRazonSocial.AllowUserToDeleteRows = false;
            this.dgvRazonSocial.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRazonSocial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRazonSocial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRazonSocial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRazonSocial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRazonSocial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvRazonSocial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvRazonSocial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRazonSocial.Location = new System.Drawing.Point(48, 108);
            this.dgvRazonSocial.Name = "dgvRazonSocial";
            this.dgvRazonSocial.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRazonSocial.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRazonSocial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRazonSocial.Size = new System.Drawing.Size(661, 134);
            this.dgvRazonSocial.TabIndex = 78;
            // 
            // btnVerUsuarios
            // 
            this.btnVerUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnVerUsuarios.FlatAppearance.BorderSize = 0;
            this.btnVerUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btnVerUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnVerUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnVerUsuarios.Location = new System.Drawing.Point(758, 220);
            this.btnVerUsuarios.Name = "btnVerUsuarios";
            this.btnVerUsuarios.Size = new System.Drawing.Size(224, 31);
            this.btnVerUsuarios.TabIndex = 77;
            this.btnVerUsuarios.Text = "Ver Entidades";
            this.btnVerUsuarios.UseVisualStyleBackColor = false;
            // 
            // btnBorrarUsuarios
            // 
            this.btnBorrarUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBorrarUsuarios.FlatAppearance.BorderSize = 0;
            this.btnBorrarUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBorrarUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnBorrarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnBorrarUsuarios.Location = new System.Drawing.Point(758, 165);
            this.btnBorrarUsuarios.Name = "btnBorrarUsuarios";
            this.btnBorrarUsuarios.Size = new System.Drawing.Size(127, 31);
            this.btnBorrarUsuarios.TabIndex = 64;
            this.btnBorrarUsuarios.Text = "Borrar";
            this.btnBorrarUsuarios.UseVisualStyleBackColor = false;
            // 
            // btnActualizarUsuarios
            // 
            this.btnActualizarUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnActualizarUsuarios.FlatAppearance.BorderSize = 0;
            this.btnActualizarUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnActualizarUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnActualizarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnActualizarUsuarios.Location = new System.Drawing.Point(758, 108);
            this.btnActualizarUsuarios.Name = "btnActualizarUsuarios";
            this.btnActualizarUsuarios.Size = new System.Drawing.Size(125, 31);
            this.btnActualizarUsuarios.TabIndex = 65;
            this.btnActualizarUsuarios.Text = "Actualizar";
            this.btnActualizarUsuarios.UseVisualStyleBackColor = false;
            // 
            // btnBuscarUsuarios
            // 
            this.btnBuscarUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBuscarUsuarios.FlatAppearance.BorderSize = 0;
            this.btnBuscarUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.btnBuscarUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnBuscarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnBuscarUsuarios.Location = new System.Drawing.Point(543, 50);
            this.btnBuscarUsuarios.Name = "btnBuscarUsuarios";
            this.btnBuscarUsuarios.Size = new System.Drawing.Size(180, 26);
            this.btnBuscarUsuarios.TabIndex = 62;
            this.btnBuscarUsuarios.Text = "Buscar ";
            this.btnBuscarUsuarios.UseVisualStyleBackColor = false;
            this.btnBuscarUsuarios.Click += new System.EventHandler(this.btnBuscarUsuarios_Click);
            // 
            // paneFechaHora
            // 
            this.paneFechaHora.Controls.Add(this.lblMostrarHora);
            this.paneFechaHora.Controls.Add(this.lblMostrarFecha);
            this.paneFechaHora.Controls.Add(this.lblHora);
            this.paneFechaHora.Controls.Add(this.lblFecha);
            this.paneFechaHora.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paneFechaHora.Location = new System.Drawing.Point(0, 572);
            this.paneFechaHora.Name = "paneFechaHora";
            this.paneFechaHora.Size = new System.Drawing.Size(1080, 43);
            this.paneFechaHora.TabIndex = 76;
            // 
            // lblMostrarHora
            // 
            this.lblMostrarHora.AutoSize = true;
            this.lblMostrarHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarHora.ForeColor = System.Drawing.Color.White;
            this.lblMostrarHora.Location = new System.Drawing.Point(445, 10);
            this.lblMostrarHora.Name = "lblMostrarHora";
            this.lblMostrarHora.Size = new System.Drawing.Size(0, 24);
            this.lblMostrarHora.TabIndex = 3;
            // 
            // lblMostrarFecha
            // 
            this.lblMostrarFecha.AutoSize = true;
            this.lblMostrarFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarFecha.ForeColor = System.Drawing.Color.White;
            this.lblMostrarFecha.Location = new System.Drawing.Point(107, 10);
            this.lblMostrarFecha.Name = "lblMostrarFecha";
            this.lblMostrarFecha.Size = new System.Drawing.Size(0, 24);
            this.lblMostrarFecha.TabIndex = 2;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(383, 10);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(56, 24);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "Hora:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(32, 10);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(69, 24);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha:";
            // 
            // tmrFechaHora
            // 
            this.tmrFechaHora.Enabled = true;
            this.tmrFechaHora.Tick += new System.EventHandler(this.tmrFechaHora_Tick);
            // 
            // erpUsuarios
            // 
            this.erpUsuarios.ContainerControl = this;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1080, 615);
            this.Controls.Add(this.paneFechaHora);
            this.Controls.Add(this.gpbBuscarUsuarios);
            this.Controls.Add(this.gpbRegistrarUsuario);
            this.Controls.Add(this.ptbUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsuarios)).EndInit();
            this.gpbRegistrarUsuario.ResumeLayout(false);
            this.gpbRegistrarUsuario.PerformLayout();
            this.gpbBuscarUsuarios.ResumeLayout(false);
            this.gpbBuscarUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRazonSocial)).EndInit();
            this.paneFechaHora.ResumeLayout(false);
            this.paneFechaHora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbUsuarios;
        private System.Windows.Forms.GroupBox gpbRegistrarUsuario;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Button btnRegistrarUsuarios;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.GroupBox gpbBuscarUsuarios;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.Label lblNombreUserBuscar;
        private System.Windows.Forms.TextBox txtNombreUserBuscar;
        public System.Windows.Forms.DataGridView dgvRazonSocial;
        private System.Windows.Forms.Button btnVerUsuarios;
        private System.Windows.Forms.Button btnBorrarUsuarios;
        private System.Windows.Forms.Button btnActualizarUsuarios;
        private System.Windows.Forms.Button btnBuscarUsuarios;
        private System.Windows.Forms.Panel paneFechaHora;
        private System.Windows.Forms.Label lblMostrarHora;
        private System.Windows.Forms.Label lblMostrarFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer tmrFechaHora;
        private System.Windows.Forms.ToolTip tltBuscar;
        private System.Windows.Forms.ErrorProvider erpUsuarios;
    }
}