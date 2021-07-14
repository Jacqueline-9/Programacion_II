namespace Punto_Venta_Abarrotes
{
    partial class frmProveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ptbProveedor = new System.Windows.Forms.PictureBox();
            this.gpbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.lblIdProveedor = new System.Windows.Forms.Label();
            this.gpbDomicilio = new System.Windows.Forms.GroupBox();
            this.cmbNumInt = new System.Windows.Forms.ComboBox();
            this.cmbNumExt = new System.Windows.Forms.ComboBox();
            this.cmbCalles = new System.Windows.Forms.ComboBox();
            this.lblNumInt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNombreCalles = new System.Windows.Forms.Label();
            this.lblNombreColonia = new System.Windows.Forms.Label();
            this.cmbColonias = new System.Windows.Forms.ComboBox();
            this.cmbLocalidades = new System.Windows.Forms.ComboBox();
            this.lblNombreLocalidadIxtlan = new System.Windows.Forms.Label();
            this.lblNombreMunicipio = new System.Windows.Forms.Label();
            this.cmbMunicipios = new System.Windows.Forms.ComboBox();
            this.txtTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.btnRegistrarEntidades = new System.Windows.Forms.Button();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.paneFechaHora = new System.Windows.Forms.Panel();
            this.lblMostrarHora = new System.Windows.Forms.Label();
            this.lblMostrarFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.gpbBuscarProveedores = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.lblRazonSocialBuscar = new System.Windows.Forms.Label();
            this.txtRazonSocialBuscar = new System.Windows.Forms.TextBox();
            this.btnVerEntidades = new System.Windows.Forms.Button();
            this.btnBorrarEntidades = new System.Windows.Forms.Button();
            this.btnActualizarEntidades = new System.Windows.Forms.Button();
            this.tmrFechaHera = new System.Windows.Forms.Timer(this.components);
            this.erpProveedores = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProveedor)).BeginInit();
            this.gpbDatosPersonales.SuspendLayout();
            this.gpbDomicilio.SuspendLayout();
            this.paneFechaHora.SuspendLayout();
            this.gpbBuscarProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbProveedor
            // 
            this.ptbProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbProveedor.Image = global::Punto_Venta_Abarrotes.Properties.Resources.ptbProveedores;
            this.ptbProveedor.Location = new System.Drawing.Point(306, 29);
            this.ptbProveedor.Name = "ptbProveedor";
            this.ptbProveedor.Size = new System.Drawing.Size(484, 72);
            this.ptbProveedor.TabIndex = 66;
            this.ptbProveedor.TabStop = false;
            // 
            // gpbDatosPersonales
            // 
            this.gpbDatosPersonales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gpbDatosPersonales.Controls.Add(this.lblIdProveedor);
            this.gpbDatosPersonales.Controls.Add(this.gpbDomicilio);
            this.gpbDatosPersonales.Controls.Add(this.txtTelefonoProveedor);
            this.gpbDatosPersonales.Controls.Add(this.btnRegistrarEntidades);
            this.gpbDatosPersonales.Controls.Add(this.lblTelefono);
            this.gpbDatosPersonales.Controls.Add(this.lblRazonSocial);
            this.gpbDatosPersonales.Controls.Add(this.txtRazonSocial);
            this.gpbDatosPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatosPersonales.ForeColor = System.Drawing.Color.White;
            this.gpbDatosPersonales.Location = new System.Drawing.Point(12, 107);
            this.gpbDatosPersonales.Name = "gpbDatosPersonales";
            this.gpbDatosPersonales.Size = new System.Drawing.Size(382, 459);
            this.gpbDatosPersonales.TabIndex = 72;
            this.gpbDatosPersonales.TabStop = false;
            this.gpbDatosPersonales.Text = "Datos de la Entidad";
            // 
            // lblIdProveedor
            // 
            this.lblIdProveedor.AutoSize = true;
            this.lblIdProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProveedor.ForeColor = System.Drawing.Color.White;
            this.lblIdProveedor.Location = new System.Drawing.Point(361, 18);
            this.lblIdProveedor.Name = "lblIdProveedor";
            this.lblIdProveedor.Size = new System.Drawing.Size(0, 24);
            this.lblIdProveedor.TabIndex = 34;
            this.lblIdProveedor.Visible = false;
            // 
            // gpbDomicilio
            // 
            this.gpbDomicilio.Controls.Add(this.cmbNumInt);
            this.gpbDomicilio.Controls.Add(this.cmbNumExt);
            this.gpbDomicilio.Controls.Add(this.cmbCalles);
            this.gpbDomicilio.Controls.Add(this.lblNumInt);
            this.gpbDomicilio.Controls.Add(this.label4);
            this.gpbDomicilio.Controls.Add(this.lblNombreCalles);
            this.gpbDomicilio.Controls.Add(this.lblNombreColonia);
            this.gpbDomicilio.Controls.Add(this.cmbColonias);
            this.gpbDomicilio.Controls.Add(this.cmbLocalidades);
            this.gpbDomicilio.Controls.Add(this.lblNombreLocalidadIxtlan);
            this.gpbDomicilio.Controls.Add(this.lblNombreMunicipio);
            this.gpbDomicilio.Controls.Add(this.cmbMunicipios);
            this.gpbDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDomicilio.ForeColor = System.Drawing.Color.White;
            this.gpbDomicilio.Location = new System.Drawing.Point(15, 132);
            this.gpbDomicilio.Name = "gpbDomicilio";
            this.gpbDomicilio.Size = new System.Drawing.Size(352, 276);
            this.gpbDomicilio.TabIndex = 33;
            this.gpbDomicilio.TabStop = false;
            this.gpbDomicilio.Text = "Ubicación";
            // 
            // cmbNumInt
            // 
            this.cmbNumInt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNumInt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNumInt.FormattingEnabled = true;
            this.cmbNumInt.Location = new System.Drawing.Point(162, 238);
            this.cmbNumInt.Name = "cmbNumInt";
            this.cmbNumInt.Size = new System.Drawing.Size(184, 24);
            this.cmbNumInt.TabIndex = 89;
            // 
            // cmbNumExt
            // 
            this.cmbNumExt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNumExt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNumExt.FormattingEnabled = true;
            this.cmbNumExt.Location = new System.Drawing.Point(162, 202);
            this.cmbNumExt.Name = "cmbNumExt";
            this.cmbNumExt.Size = new System.Drawing.Size(184, 24);
            this.cmbNumExt.TabIndex = 88;
            // 
            // cmbCalles
            // 
            this.cmbCalles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCalles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCalles.FormattingEnabled = true;
            this.cmbCalles.Location = new System.Drawing.Point(106, 162);
            this.cmbCalles.Name = "cmbCalles";
            this.cmbCalles.Size = new System.Drawing.Size(240, 24);
            this.cmbCalles.TabIndex = 87;
            // 
            // lblNumInt
            // 
            this.lblNumInt.AutoSize = true;
            this.lblNumInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumInt.ForeColor = System.Drawing.Color.White;
            this.lblNumInt.Location = new System.Drawing.Point(7, 238);
            this.lblNumInt.Name = "lblNumInt";
            this.lblNumInt.Size = new System.Drawing.Size(141, 24);
            this.lblNumInt.TabIndex = 84;
            this.lblNumInt.Text = "Número Interior";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 24);
            this.label4.TabIndex = 83;
            this.label4.Text = "Número Exterior";
            // 
            // lblNombreCalles
            // 
            this.lblNombreCalles.AutoSize = true;
            this.lblNombreCalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCalles.ForeColor = System.Drawing.Color.White;
            this.lblNombreCalles.Location = new System.Drawing.Point(7, 162);
            this.lblNombreCalles.Name = "lblNombreCalles";
            this.lblNombreCalles.Size = new System.Drawing.Size(52, 24);
            this.lblNombreCalles.TabIndex = 76;
            this.lblNombreCalles.Text = "Calle";
            // 
            // lblNombreColonia
            // 
            this.lblNombreColonia.AutoSize = true;
            this.lblNombreColonia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreColonia.ForeColor = System.Drawing.Color.White;
            this.lblNombreColonia.Location = new System.Drawing.Point(7, 120);
            this.lblNombreColonia.Name = "lblNombreColonia";
            this.lblNombreColonia.Size = new System.Drawing.Size(74, 24);
            this.lblNombreColonia.TabIndex = 82;
            this.lblNombreColonia.Text = "Colonia";
            // 
            // cmbColonias
            // 
            this.cmbColonias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbColonias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColonias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColonias.FormattingEnabled = true;
            this.cmbColonias.Location = new System.Drawing.Point(106, 120);
            this.cmbColonias.Name = "cmbColonias";
            this.cmbColonias.Size = new System.Drawing.Size(240, 24);
            this.cmbColonias.TabIndex = 81;
            // 
            // cmbLocalidades
            // 
            this.cmbLocalidades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLocalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocalidades.FormattingEnabled = true;
            this.cmbLocalidades.Location = new System.Drawing.Point(106, 77);
            this.cmbLocalidades.Name = "cmbLocalidades";
            this.cmbLocalidades.Size = new System.Drawing.Size(240, 24);
            this.cmbLocalidades.TabIndex = 80;
            // 
            // lblNombreLocalidadIxtlan
            // 
            this.lblNombreLocalidadIxtlan.AutoSize = true;
            this.lblNombreLocalidadIxtlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreLocalidadIxtlan.ForeColor = System.Drawing.Color.White;
            this.lblNombreLocalidadIxtlan.Location = new System.Drawing.Point(7, 77);
            this.lblNombreLocalidadIxtlan.Name = "lblNombreLocalidadIxtlan";
            this.lblNombreLocalidadIxtlan.Size = new System.Drawing.Size(91, 24);
            this.lblNombreLocalidadIxtlan.TabIndex = 79;
            this.lblNombreLocalidadIxtlan.Text = "Localidad";
            // 
            // lblNombreMunicipio
            // 
            this.lblNombreMunicipio.AutoSize = true;
            this.lblNombreMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMunicipio.ForeColor = System.Drawing.Color.White;
            this.lblNombreMunicipio.Location = new System.Drawing.Point(6, 35);
            this.lblNombreMunicipio.Name = "lblNombreMunicipio";
            this.lblNombreMunicipio.Size = new System.Drawing.Size(92, 24);
            this.lblNombreMunicipio.TabIndex = 20;
            this.lblNombreMunicipio.Text = "Municipio";
            // 
            // cmbMunicipios
            // 
            this.cmbMunicipios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMunicipios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMunicipios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMunicipios.FormattingEnabled = true;
            this.cmbMunicipios.Location = new System.Drawing.Point(106, 35);
            this.cmbMunicipios.Name = "cmbMunicipios";
            this.cmbMunicipios.Size = new System.Drawing.Size(240, 24);
            this.cmbMunicipios.TabIndex = 19;
            // 
            // txtTelefonoProveedor
            // 
            this.txtTelefonoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoProveedor.Location = new System.Drawing.Point(144, 88);
            this.txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            this.txtTelefonoProveedor.Size = new System.Drawing.Size(223, 23);
            this.txtTelefonoProveedor.TabIndex = 32;
            // 
            // btnRegistrarEntidades
            // 
            this.btnRegistrarEntidades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarEntidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRegistrarEntidades.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegistrarEntidades.FlatAppearance.BorderSize = 0;
            this.btnRegistrarEntidades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRegistrarEntidades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnRegistrarEntidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarEntidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEntidades.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarEntidades.Location = new System.Drawing.Point(99, 422);
            this.btnRegistrarEntidades.Name = "btnRegistrarEntidades";
            this.btnRegistrarEntidades.Size = new System.Drawing.Size(196, 31);
            this.btnRegistrarEntidades.TabIndex = 31;
            this.btnRegistrarEntidades.Text = "Registrar";
            this.btnRegistrarEntidades.UseVisualStyleBackColor = false;
            this.btnRegistrarEntidades.Click += new System.EventHandler(this.btnRegistrarEntidades_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(20, 88);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(85, 24);
            this.lblTelefono.TabIndex = 25;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.ForeColor = System.Drawing.Color.White;
            this.lblRazonSocial.Location = new System.Drawing.Point(20, 48);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(120, 24);
            this.lblRazonSocial.TabIndex = 20;
            this.lblRazonSocial.Text = "Razón Social";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(144, 49);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(223, 23);
            this.txtRazonSocial.TabIndex = 18;
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
            this.paneFechaHora.Size = new System.Drawing.Size(1056, 43);
            this.paneFechaHora.TabIndex = 73;
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
            // gpbBuscarProveedores
            // 
            this.gpbBuscarProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbBuscarProveedores.Controls.Add(this.btnBuscar);
            this.gpbBuscarProveedores.Controls.Add(this.lblBuscarPor);
            this.gpbBuscarProveedores.Controls.Add(this.lblRazonSocialBuscar);
            this.gpbBuscarProveedores.Controls.Add(this.txtRazonSocialBuscar);
            this.gpbBuscarProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBuscarProveedores.ForeColor = System.Drawing.Color.White;
            this.gpbBuscarProveedores.Location = new System.Drawing.Point(435, 107);
            this.gpbBuscarProveedores.Name = "gpbBuscarProveedores";
            this.gpbBuscarProveedores.Size = new System.Drawing.Size(609, 121);
            this.gpbBuscarProveedores.TabIndex = 74;
            this.gpbBuscarProveedores.TabStop = false;
            this.gpbBuscarProveedores.Text = "Proveedores";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(469, 60);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 27);
            this.btnBuscar.TabIndex = 88;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPor.Location = new System.Drawing.Point(286, 26);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(56, 16);
            this.lblBuscarPor.TabIndex = 81;
            this.lblBuscarPor.Text = "Buscar";
            // 
            // lblRazonSocialBuscar
            // 
            this.lblRazonSocialBuscar.AutoSize = true;
            this.lblRazonSocialBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocialBuscar.ForeColor = System.Drawing.Color.White;
            this.lblRazonSocialBuscar.Location = new System.Drawing.Point(19, 63);
            this.lblRazonSocialBuscar.Name = "lblRazonSocialBuscar";
            this.lblRazonSocialBuscar.Size = new System.Drawing.Size(115, 22);
            this.lblRazonSocialBuscar.TabIndex = 80;
            this.lblRazonSocialBuscar.Text = "Razón Social";
            // 
            // txtRazonSocialBuscar
            // 
            this.txtRazonSocialBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRazonSocialBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocialBuscar.Location = new System.Drawing.Point(149, 63);
            this.txtRazonSocialBuscar.Name = "txtRazonSocialBuscar";
            this.txtRazonSocialBuscar.Size = new System.Drawing.Size(314, 24);
            this.txtRazonSocialBuscar.TabIndex = 79;
            // 
            // btnVerEntidades
            // 
            this.btnVerEntidades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerEntidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnVerEntidades.FlatAppearance.BorderSize = 0;
            this.btnVerEntidades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btnVerEntidades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnVerEntidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerEntidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerEntidades.ForeColor = System.Drawing.Color.White;
            this.btnVerEntidades.Location = new System.Drawing.Point(820, 535);
            this.btnVerEntidades.Name = "btnVerEntidades";
            this.btnVerEntidades.Size = new System.Drawing.Size(224, 31);
            this.btnVerEntidades.TabIndex = 77;
            this.btnVerEntidades.Text = "Ver Entidades";
            this.btnVerEntidades.UseVisualStyleBackColor = false;
            this.btnVerEntidades.Click += new System.EventHandler(this.btnVerEntidades_Click);
            // 
            // btnBorrarEntidades
            // 
            this.btnBorrarEntidades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrarEntidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBorrarEntidades.FlatAppearance.BorderSize = 0;
            this.btnBorrarEntidades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBorrarEntidades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnBorrarEntidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarEntidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarEntidades.ForeColor = System.Drawing.Color.White;
            this.btnBorrarEntidades.Location = new System.Drawing.Point(633, 535);
            this.btnBorrarEntidades.Name = "btnBorrarEntidades";
            this.btnBorrarEntidades.Size = new System.Drawing.Size(157, 31);
            this.btnBorrarEntidades.TabIndex = 64;
            this.btnBorrarEntidades.Text = "Borrar";
            this.btnBorrarEntidades.UseVisualStyleBackColor = false;
            // 
            // btnActualizarEntidades
            // 
            this.btnActualizarEntidades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarEntidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnActualizarEntidades.FlatAppearance.BorderSize = 0;
            this.btnActualizarEntidades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnActualizarEntidades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnActualizarEntidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarEntidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEntidades.ForeColor = System.Drawing.Color.White;
            this.btnActualizarEntidades.Location = new System.Drawing.Point(435, 535);
            this.btnActualizarEntidades.Name = "btnActualizarEntidades";
            this.btnActualizarEntidades.Size = new System.Drawing.Size(153, 31);
            this.btnActualizarEntidades.TabIndex = 65;
            this.btnActualizarEntidades.Text = "Actualizar";
            this.btnActualizarEntidades.UseVisualStyleBackColor = false;
            this.btnActualizarEntidades.Click += new System.EventHandler(this.btnActualizarEntidades_Click);
            // 
            // tmrFechaHera
            // 
            this.tmrFechaHera.Enabled = true;
            this.tmrFechaHera.Tick += new System.EventHandler(this.tmrFechaHera_Tick);
            // 
            // erpProveedores
            // 
            this.erpProveedores.ContainerControl = this;
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProveedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.dgvProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.EnableHeadersVisualStyles = false;
            this.dgvProveedores.Location = new System.Drawing.Point(435, 234);
            this.dgvProveedores.Name = "dgvProveedores";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProveedores.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProveedores.Size = new System.Drawing.Size(609, 281);
            this.dgvProveedores.TabIndex = 78;
            this.dgvProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellContentClick);
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1056, 615);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.gpbBuscarProveedores);
            this.Controls.Add(this.paneFechaHora);
            this.Controls.Add(this.gpbDatosPersonales);
            this.Controls.Add(this.ptbProveedor);
            this.Controls.Add(this.btnVerEntidades);
            this.Controls.Add(this.btnActualizarEntidades);
            this.Controls.Add(this.btnBorrarEntidades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProveedores";
            this.Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.ptbProveedor)).EndInit();
            this.gpbDatosPersonales.ResumeLayout(false);
            this.gpbDatosPersonales.PerformLayout();
            this.gpbDomicilio.ResumeLayout(false);
            this.gpbDomicilio.PerformLayout();
            this.paneFechaHora.ResumeLayout(false);
            this.paneFechaHora.PerformLayout();
            this.gpbBuscarProveedores.ResumeLayout(false);
            this.gpbBuscarProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbProveedor;
        private System.Windows.Forms.GroupBox gpbDatosPersonales;
        private System.Windows.Forms.TextBox txtTelefonoProveedor;
        private System.Windows.Forms.Button btnRegistrarEntidades;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Panel paneFechaHora;
        private System.Windows.Forms.Label lblMostrarHora;
        private System.Windows.Forms.Label lblMostrarFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox gpbBuscarProveedores;
        private System.Windows.Forms.Button btnVerEntidades;
        private System.Windows.Forms.Button btnBorrarEntidades;
        private System.Windows.Forms.Button btnActualizarEntidades;
        private System.Windows.Forms.Timer tmrFechaHera;
        private System.Windows.Forms.ErrorProvider erpProveedores;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.Label lblRazonSocialBuscar;
        private System.Windows.Forms.TextBox txtRazonSocialBuscar;
        private System.Windows.Forms.GroupBox gpbDomicilio;
        private System.Windows.Forms.Label lblNombreMunicipio;
        private System.Windows.Forms.ComboBox cmbMunicipios;
        private System.Windows.Forms.ComboBox cmbLocalidades;
        private System.Windows.Forms.Label lblNombreLocalidadIxtlan;
        private System.Windows.Forms.Label lblNombreColonia;
        private System.Windows.Forms.ComboBox cmbColonias;
        private System.Windows.Forms.Label lblNombreCalles;
        private System.Windows.Forms.Label lblNumInt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.ComboBox cmbCalles;
        private System.Windows.Forms.ComboBox cmbNumInt;
        private System.Windows.Forms.ComboBox cmbNumExt;
        private System.Windows.Forms.Label lblIdProveedor;
    }
}