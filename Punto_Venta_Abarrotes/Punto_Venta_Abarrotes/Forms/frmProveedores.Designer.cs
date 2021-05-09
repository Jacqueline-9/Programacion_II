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
            this.ptbProveedor = new System.Windows.Forms.PictureBox();
            this.gpbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.txtIdDomicilioEntidad = new System.Windows.Forms.TextBox();
            this.txtTelefonoEmpleado = new System.Windows.Forms.TextBox();
            this.btnRegistrarEntidades = new System.Windows.Forms.Button();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblIdDomicilio = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.paneFechaHora = new System.Windows.Forms.Panel();
            this.lblMostrarHora = new System.Windows.Forms.Label();
            this.lblMostrarFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.gpbBuscarProveedores = new System.Windows.Forms.GroupBox();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.lblRazonSocialBuscar = new System.Windows.Forms.Label();
            this.txtRazonSocialBuscar = new System.Windows.Forms.TextBox();
            this.dgvRazonSocial = new System.Windows.Forms.DataGridView();
            this.btnVerEntidades = new System.Windows.Forms.Button();
            this.btnBorrarEntidades = new System.Windows.Forms.Button();
            this.btnActualizarEntidades = new System.Windows.Forms.Button();
            this.btnBuscarEntidades = new System.Windows.Forms.Button();
            this.tmrFechaHera = new System.Windows.Forms.Timer(this.components);
            this.tltBuscar = new System.Windows.Forms.ToolTip(this.components);
            this.erpProveedores = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbProveedor)).BeginInit();
            this.gpbDatosPersonales.SuspendLayout();
            this.paneFechaHora.SuspendLayout();
            this.gpbBuscarProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRazonSocial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbProveedor
            // 
            this.ptbProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbProveedor.Image = global::Punto_Venta_Abarrotes.Properties.Resources.ptbProveedores;
            this.ptbProveedor.Location = new System.Drawing.Point(306, 29);
            this.ptbProveedor.Name = "ptbProveedor";
            this.ptbProveedor.Size = new System.Drawing.Size(508, 72);
            this.ptbProveedor.TabIndex = 66;
            this.ptbProveedor.TabStop = false;
            // 
            // gpbDatosPersonales
            // 
            this.gpbDatosPersonales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbDatosPersonales.Controls.Add(this.txtEstatus);
            this.gpbDatosPersonales.Controls.Add(this.lblEstatus);
            this.gpbDatosPersonales.Controls.Add(this.txtIdDomicilioEntidad);
            this.gpbDatosPersonales.Controls.Add(this.txtTelefonoEmpleado);
            this.gpbDatosPersonales.Controls.Add(this.btnRegistrarEntidades);
            this.gpbDatosPersonales.Controls.Add(this.lblTelefono);
            this.gpbDatosPersonales.Controls.Add(this.lblIdDomicilio);
            this.gpbDatosPersonales.Controls.Add(this.lblRazonSocial);
            this.gpbDatosPersonales.Controls.Add(this.txtRazonSocial);
            this.gpbDatosPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatosPersonales.ForeColor = System.Drawing.Color.White;
            this.gpbDatosPersonales.Location = new System.Drawing.Point(12, 107);
            this.gpbDatosPersonales.Name = "gpbDatosPersonales";
            this.gpbDatosPersonales.Size = new System.Drawing.Size(1056, 181);
            this.gpbDatosPersonales.TabIndex = 72;
            this.gpbDatosPersonales.TabStop = false;
            this.gpbDatosPersonales.Text = "Datos de la Entidad";
            // 
            // txtEstatus
            // 
            this.txtEstatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstatus.Location = new System.Drawing.Point(667, 89);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(364, 23);
            this.txtEstatus.TabIndex = 41;
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatus.ForeColor = System.Drawing.Color.White;
            this.lblEstatus.Location = new System.Drawing.Point(552, 89);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(70, 24);
            this.lblEstatus.TabIndex = 40;
            this.lblEstatus.Text = "Estatus";
            // 
            // txtIdDomicilioEntidad
            // 
            this.txtIdDomicilioEntidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdDomicilioEntidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDomicilioEntidad.Location = new System.Drawing.Point(667, 45);
            this.txtIdDomicilioEntidad.Name = "txtIdDomicilioEntidad";
            this.txtIdDomicilioEntidad.Size = new System.Drawing.Size(364, 23);
            this.txtIdDomicilioEntidad.TabIndex = 33;
            this.txtIdDomicilioEntidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdDomicilioEntidad_KeyPress);
            // 
            // txtTelefonoEmpleado
            // 
            this.txtTelefonoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoEmpleado.Location = new System.Drawing.Point(164, 92);
            this.txtTelefonoEmpleado.Name = "txtTelefonoEmpleado";
            this.txtTelefonoEmpleado.Size = new System.Drawing.Size(367, 23);
            this.txtTelefonoEmpleado.TabIndex = 32;
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
            this.btnRegistrarEntidades.Location = new System.Drawing.Point(390, 134);
            this.btnRegistrarEntidades.Name = "btnRegistrarEntidades";
            this.btnRegistrarEntidades.Size = new System.Drawing.Size(333, 31);
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
            this.lblTelefono.Location = new System.Drawing.Point(20, 92);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(85, 24);
            this.lblTelefono.TabIndex = 25;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblIdDomicilio
            // 
            this.lblIdDomicilio.AutoSize = true;
            this.lblIdDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDomicilio.ForeColor = System.Drawing.Color.White;
            this.lblIdDomicilio.Location = new System.Drawing.Point(552, 45);
            this.lblIdDomicilio.Name = "lblIdDomicilio";
            this.lblIdDomicilio.Size = new System.Drawing.Size(109, 24);
            this.lblIdDomicilio.TabIndex = 27;
            this.lblIdDomicilio.Text = "ID Domicilio";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.ForeColor = System.Drawing.Color.White;
            this.lblRazonSocial.Location = new System.Drawing.Point(20, 45);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(120, 24);
            this.lblRazonSocial.TabIndex = 20;
            this.lblRazonSocial.Text = "Razón Social";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(164, 45);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(367, 23);
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
            this.paneFechaHora.Size = new System.Drawing.Size(1080, 43);
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
            this.gpbBuscarProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbBuscarProveedores.Controls.Add(this.lblBuscarPor);
            this.gpbBuscarProveedores.Controls.Add(this.lblRazonSocialBuscar);
            this.gpbBuscarProveedores.Controls.Add(this.txtRazonSocialBuscar);
            this.gpbBuscarProveedores.Controls.Add(this.dgvRazonSocial);
            this.gpbBuscarProveedores.Controls.Add(this.btnVerEntidades);
            this.gpbBuscarProveedores.Controls.Add(this.btnBorrarEntidades);
            this.gpbBuscarProveedores.Controls.Add(this.btnActualizarEntidades);
            this.gpbBuscarProveedores.Controls.Add(this.btnBuscarEntidades);
            this.gpbBuscarProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBuscarProveedores.ForeColor = System.Drawing.Color.White;
            this.gpbBuscarProveedores.Location = new System.Drawing.Point(12, 294);
            this.gpbBuscarProveedores.Name = "gpbBuscarProveedores";
            this.gpbBuscarProveedores.Size = new System.Drawing.Size(1056, 272);
            this.gpbBuscarProveedores.TabIndex = 74;
            this.gpbBuscarProveedores.TabStop = false;
            this.gpbBuscarProveedores.Text = "Proveedores";
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
            // lblRazonSocialBuscar
            // 
            this.lblRazonSocialBuscar.AutoSize = true;
            this.lblRazonSocialBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocialBuscar.ForeColor = System.Drawing.Color.White;
            this.lblRazonSocialBuscar.Location = new System.Drawing.Point(17, 53);
            this.lblRazonSocialBuscar.Name = "lblRazonSocialBuscar";
            this.lblRazonSocialBuscar.Size = new System.Drawing.Size(88, 16);
            this.lblRazonSocialBuscar.TabIndex = 80;
            this.lblRazonSocialBuscar.Text = "Razón Social";
            // 
            // txtRazonSocialBuscar
            // 
            this.txtRazonSocialBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocialBuscar.Location = new System.Drawing.Point(137, 50);
            this.txtRazonSocialBuscar.Name = "txtRazonSocialBuscar";
            this.txtRazonSocialBuscar.Size = new System.Drawing.Size(296, 22);
            this.txtRazonSocialBuscar.TabIndex = 79;
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
            this.dgvRazonSocial.Location = new System.Drawing.Point(61, 95);
            this.dgvRazonSocial.Name = "dgvRazonSocial";
            this.dgvRazonSocial.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRazonSocial.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRazonSocial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRazonSocial.Size = new System.Drawing.Size(662, 143);
            this.dgvRazonSocial.TabIndex = 78;
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
            this.btnVerEntidades.Location = new System.Drawing.Point(746, 207);
            this.btnVerEntidades.Name = "btnVerEntidades";
            this.btnVerEntidades.Size = new System.Drawing.Size(224, 31);
            this.btnVerEntidades.TabIndex = 77;
            this.btnVerEntidades.Text = "Ver Entidades";
            this.btnVerEntidades.UseVisualStyleBackColor = false;
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
            this.btnBorrarEntidades.Location = new System.Drawing.Point(746, 146);
            this.btnBorrarEntidades.Name = "btnBorrarEntidades";
            this.btnBorrarEntidades.Size = new System.Drawing.Size(127, 31);
            this.btnBorrarEntidades.TabIndex = 64;
            this.btnBorrarEntidades.Text = "Borrar";
            this.btnBorrarEntidades.UseVisualStyleBackColor = false;
            // 
            // btnActualizarEntidades
            // 
            this.btnActualizarEntidades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarEntidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnActualizarEntidades.FlatAppearance.BorderSize = 0;
            this.btnActualizarEntidades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnActualizarEntidades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnActualizarEntidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarEntidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEntidades.ForeColor = System.Drawing.Color.White;
            this.btnActualizarEntidades.Location = new System.Drawing.Point(746, 95);
            this.btnActualizarEntidades.Name = "btnActualizarEntidades";
            this.btnActualizarEntidades.Size = new System.Drawing.Size(125, 31);
            this.btnActualizarEntidades.TabIndex = 65;
            this.btnActualizarEntidades.Text = "Actualizar";
            this.btnActualizarEntidades.UseVisualStyleBackColor = false;
            // 
            // btnBuscarEntidades
            // 
            this.btnBuscarEntidades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarEntidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBuscarEntidades.FlatAppearance.BorderSize = 0;
            this.btnBuscarEntidades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.btnBuscarEntidades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnBuscarEntidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEntidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEntidades.ForeColor = System.Drawing.Color.White;
            this.btnBuscarEntidades.Location = new System.Drawing.Point(452, 47);
            this.btnBuscarEntidades.Name = "btnBuscarEntidades";
            this.btnBuscarEntidades.Size = new System.Drawing.Size(180, 26);
            this.btnBuscarEntidades.TabIndex = 62;
            this.btnBuscarEntidades.Text = "Buscar ";
            this.btnBuscarEntidades.UseVisualStyleBackColor = false;
            this.btnBuscarEntidades.Click += new System.EventHandler(this.btnBuscarEntidades_Click);
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
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1080, 615);
            this.Controls.Add(this.gpbBuscarProveedores);
            this.Controls.Add(this.paneFechaHora);
            this.Controls.Add(this.gpbDatosPersonales);
            this.Controls.Add(this.ptbProveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProveedores";
            this.Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.ptbProveedor)).EndInit();
            this.gpbDatosPersonales.ResumeLayout(false);
            this.gpbDatosPersonales.PerformLayout();
            this.paneFechaHora.ResumeLayout(false);
            this.paneFechaHora.PerformLayout();
            this.gpbBuscarProveedores.ResumeLayout(false);
            this.gpbBuscarProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRazonSocial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbProveedor;
        private System.Windows.Forms.GroupBox gpbDatosPersonales;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.TextBox txtIdDomicilioEntidad;
        private System.Windows.Forms.TextBox txtTelefonoEmpleado;
        private System.Windows.Forms.Button btnRegistrarEntidades;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblIdDomicilio;
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
        private System.Windows.Forms.Button btnBuscarEntidades;
        private System.Windows.Forms.Timer tmrFechaHera;
        private System.Windows.Forms.ToolTip tltBuscar;
        private System.Windows.Forms.ErrorProvider erpProveedores;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.Label lblRazonSocialBuscar;
        private System.Windows.Forms.TextBox txtRazonSocialBuscar;
        public System.Windows.Forms.DataGridView dgvRazonSocial;
    }
}