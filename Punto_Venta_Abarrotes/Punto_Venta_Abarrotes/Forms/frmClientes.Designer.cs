namespace Punto_Venta_Abarrotes
{
    partial class frmClientes
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
            this.gpbBuscarClientes = new System.Windows.Forms.GroupBox();
            this.btnVerClientes = new System.Windows.Forms.Button();
            this.txtApeMatBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.lblApeMatBuscar = new System.Windows.Forms.Label();
            this.lblApPatBuscar = new System.Windows.Forms.Label();
            this.txtApPatBuscar = new System.Windows.Forms.TextBox();
            this.lblNomBuscar = new System.Windows.Forms.Label();
            this.txtNombreBuscar = new System.Windows.Forms.TextBox();
            this.btnBorrarClientes = new System.Windows.Forms.Button();
            this.btnActualizarClientes = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnBuscarClientes = new System.Windows.Forms.Button();
            this.gpbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.lblCurp = new System.Windows.Forms.Label();
            this.txtIdDomicilioCliente = new System.Windows.Forms.TextBox();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.btnRegistrarClientes = new System.Windows.Forms.Button();
            this.dtpFechaNacCliente = new System.Windows.Forms.DateTimePicker();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblIdDomicilio = new System.Windows.Forms.Label();
            this.lblApeMat = new System.Windows.Forms.Label();
            this.txtApeMatCliente = new System.Windows.Forms.TextBox();
            this.lblApePat = new System.Windows.Forms.Label();
            this.txtApePatCliente = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.paneFechaHora = new System.Windows.Forms.Panel();
            this.lblMostrarHora = new System.Windows.Forms.Label();
            this.lblMostrarFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.tmrFechaHora = new System.Windows.Forms.Timer(this.components);
            this.tltBuscar = new System.Windows.Forms.ToolTip(this.components);
            this.ptbClientes = new System.Windows.Forms.PictureBox();
            this.erpClientes = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpbBuscarClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.gpbDatosPersonales.SuspendLayout();
            this.paneFechaHora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbBuscarClientes
            // 
            this.gpbBuscarClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbBuscarClientes.Controls.Add(this.btnVerClientes);
            this.gpbBuscarClientes.Controls.Add(this.txtApeMatBuscar);
            this.gpbBuscarClientes.Controls.Add(this.lblBuscarPor);
            this.gpbBuscarClientes.Controls.Add(this.lblApeMatBuscar);
            this.gpbBuscarClientes.Controls.Add(this.lblApPatBuscar);
            this.gpbBuscarClientes.Controls.Add(this.txtApPatBuscar);
            this.gpbBuscarClientes.Controls.Add(this.lblNomBuscar);
            this.gpbBuscarClientes.Controls.Add(this.txtNombreBuscar);
            this.gpbBuscarClientes.Controls.Add(this.btnBorrarClientes);
            this.gpbBuscarClientes.Controls.Add(this.btnActualizarClientes);
            this.gpbBuscarClientes.Controls.Add(this.dgvClientes);
            this.gpbBuscarClientes.Controls.Add(this.btnBuscarClientes);
            this.gpbBuscarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBuscarClientes.ForeColor = System.Drawing.Color.White;
            this.gpbBuscarClientes.Location = new System.Drawing.Point(503, 152);
            this.gpbBuscarClientes.Name = "gpbBuscarClientes";
            this.gpbBuscarClientes.Size = new System.Drawing.Size(558, 407);
            this.gpbBuscarClientes.TabIndex = 69;
            this.gpbBuscarClientes.TabStop = false;
            this.gpbBuscarClientes.Text = "Clientes";
            // 
            // btnVerClientes
            // 
            this.btnVerClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnVerClientes.FlatAppearance.BorderSize = 0;
            this.btnVerClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btnVerClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnVerClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerClientes.ForeColor = System.Drawing.Color.White;
            this.btnVerClientes.Location = new System.Drawing.Point(361, 355);
            this.btnVerClientes.Name = "btnVerClientes";
            this.btnVerClientes.Size = new System.Drawing.Size(190, 31);
            this.btnVerClientes.TabIndex = 77;
            this.btnVerClientes.Text = "Ver Clientes";
            this.btnVerClientes.UseVisualStyleBackColor = false;
            // 
            // txtApeMatBuscar
            // 
            this.txtApeMatBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApeMatBuscar.Location = new System.Drawing.Point(126, 108);
            this.txtApeMatBuscar.Name = "txtApeMatBuscar";
            this.txtApeMatBuscar.Size = new System.Drawing.Size(186, 22);
            this.txtApeMatBuscar.TabIndex = 73;
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPor.Location = new System.Drawing.Point(263, 26);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(76, 16);
            this.lblBuscarPor.TabIndex = 72;
            this.lblBuscarPor.Text = "Buscar por:";
            // 
            // lblApeMatBuscar
            // 
            this.lblApeMatBuscar.AutoSize = true;
            this.lblApeMatBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApeMatBuscar.ForeColor = System.Drawing.Color.White;
            this.lblApeMatBuscar.Location = new System.Drawing.Point(10, 111);
            this.lblApeMatBuscar.Name = "lblApeMatBuscar";
            this.lblApeMatBuscar.Size = new System.Drawing.Size(110, 16);
            this.lblApeMatBuscar.TabIndex = 70;
            this.lblApeMatBuscar.Text = "Apellido Materno";
            // 
            // lblApPatBuscar
            // 
            this.lblApPatBuscar.AutoSize = true;
            this.lblApPatBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApPatBuscar.ForeColor = System.Drawing.Color.White;
            this.lblApPatBuscar.Location = new System.Drawing.Point(252, 67);
            this.lblApPatBuscar.Name = "lblApPatBuscar";
            this.lblApPatBuscar.Size = new System.Drawing.Size(108, 16);
            this.lblApPatBuscar.TabIndex = 69;
            this.lblApPatBuscar.Text = "Apellido Paterno";
            // 
            // txtApPatBuscar
            // 
            this.txtApPatBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApPatBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApPatBuscar.Location = new System.Drawing.Point(366, 64);
            this.txtApPatBuscar.Name = "txtApPatBuscar";
            this.txtApPatBuscar.Size = new System.Drawing.Size(186, 22);
            this.txtApPatBuscar.TabIndex = 68;
            // 
            // lblNomBuscar
            // 
            this.lblNomBuscar.AutoSize = true;
            this.lblNomBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomBuscar.ForeColor = System.Drawing.Color.White;
            this.lblNomBuscar.Location = new System.Drawing.Point(14, 67);
            this.lblNomBuscar.Name = "lblNomBuscar";
            this.lblNomBuscar.Size = new System.Drawing.Size(57, 16);
            this.lblNomBuscar.TabIndex = 67;
            this.lblNomBuscar.Text = "Nombre";
            // 
            // txtNombreBuscar
            // 
            this.txtNombreBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreBuscar.Location = new System.Drawing.Point(77, 64);
            this.txtNombreBuscar.Name = "txtNombreBuscar";
            this.txtNombreBuscar.Size = new System.Drawing.Size(169, 22);
            this.txtNombreBuscar.TabIndex = 66;
            // 
            // btnBorrarClientes
            // 
            this.btnBorrarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBorrarClientes.FlatAppearance.BorderSize = 0;
            this.btnBorrarClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBorrarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnBorrarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarClientes.ForeColor = System.Drawing.Color.White;
            this.btnBorrarClientes.Location = new System.Drawing.Point(185, 355);
            this.btnBorrarClientes.Name = "btnBorrarClientes";
            this.btnBorrarClientes.Size = new System.Drawing.Size(127, 31);
            this.btnBorrarClientes.TabIndex = 64;
            this.btnBorrarClientes.Text = "Borrar";
            this.btnBorrarClientes.UseVisualStyleBackColor = false;
            // 
            // btnActualizarClientes
            // 
            this.btnActualizarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnActualizarClientes.FlatAppearance.BorderSize = 0;
            this.btnActualizarClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnActualizarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnActualizarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarClientes.ForeColor = System.Drawing.Color.White;
            this.btnActualizarClientes.Location = new System.Drawing.Point(17, 355);
            this.btnActualizarClientes.Name = "btnActualizarClientes";
            this.btnActualizarClientes.Size = new System.Drawing.Size(125, 31);
            this.btnActualizarClientes.TabIndex = 65;
            this.btnActualizarClientes.Text = "Actualizar";
            this.btnActualizarClientes.UseVisualStyleBackColor = false;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(16, 158);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(535, 151);
            this.dgvClientes.TabIndex = 63;
            // 
            // btnBuscarClientes
            // 
            this.btnBuscarClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBuscarClientes.FlatAppearance.BorderSize = 0;
            this.btnBuscarClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.btnBuscarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnBuscarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarClientes.ForeColor = System.Drawing.Color.White;
            this.btnBuscarClientes.Location = new System.Drawing.Point(366, 104);
            this.btnBuscarClientes.Name = "btnBuscarClientes";
            this.btnBuscarClientes.Size = new System.Drawing.Size(186, 26);
            this.btnBuscarClientes.TabIndex = 62;
            this.btnBuscarClientes.Text = "Buscar ";
            this.btnBuscarClientes.UseVisualStyleBackColor = false;
            this.btnBuscarClientes.Click += new System.EventHandler(this.btnBuscarClientes_Click);
            // 
            // gpbDatosPersonales
            // 
            this.gpbDatosPersonales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gpbDatosPersonales.Controls.Add(this.txtEstatus);
            this.gpbDatosPersonales.Controls.Add(this.lblEstatus);
            this.gpbDatosPersonales.Controls.Add(this.txtCurp);
            this.gpbDatosPersonales.Controls.Add(this.lblCurp);
            this.gpbDatosPersonales.Controls.Add(this.txtIdDomicilioCliente);
            this.gpbDatosPersonales.Controls.Add(this.txtTelefonoCliente);
            this.gpbDatosPersonales.Controls.Add(this.btnRegistrarClientes);
            this.gpbDatosPersonales.Controls.Add(this.dtpFechaNacCliente);
            this.gpbDatosPersonales.Controls.Add(this.lblTelefono);
            this.gpbDatosPersonales.Controls.Add(this.lblFechaNac);
            this.gpbDatosPersonales.Controls.Add(this.lblIdDomicilio);
            this.gpbDatosPersonales.Controls.Add(this.lblApeMat);
            this.gpbDatosPersonales.Controls.Add(this.txtApeMatCliente);
            this.gpbDatosPersonales.Controls.Add(this.lblApePat);
            this.gpbDatosPersonales.Controls.Add(this.txtApePatCliente);
            this.gpbDatosPersonales.Controls.Add(this.lblNombre);
            this.gpbDatosPersonales.Controls.Add(this.txtNombreCliente);
            this.gpbDatosPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatosPersonales.ForeColor = System.Drawing.Color.White;
            this.gpbDatosPersonales.Location = new System.Drawing.Point(19, 138);
            this.gpbDatosPersonales.Name = "gpbDatosPersonales";
            this.gpbDatosPersonales.Size = new System.Drawing.Size(460, 421);
            this.gpbDatosPersonales.TabIndex = 68;
            this.gpbDatosPersonales.TabStop = false;
            this.gpbDatosPersonales.Text = "Datos personales";
            // 
            // txtEstatus
            // 
            this.txtEstatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstatus.Location = new System.Drawing.Point(273, 345);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(162, 23);
            this.txtEstatus.TabIndex = 37;
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatus.ForeColor = System.Drawing.Color.White;
            this.lblEstatus.Location = new System.Drawing.Point(20, 342);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(70, 24);
            this.lblEstatus.TabIndex = 36;
            this.lblEstatus.Text = "Estatus";
            // 
            // txtCurp
            // 
            this.txtCurp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurp.Location = new System.Drawing.Point(179, 265);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(256, 23);
            this.txtCurp.TabIndex = 35;
            // 
            // lblCurp
            // 
            this.lblCurp.AutoSize = true;
            this.lblCurp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurp.ForeColor = System.Drawing.Color.White;
            this.lblCurp.Location = new System.Drawing.Point(20, 262);
            this.lblCurp.Name = "lblCurp";
            this.lblCurp.Size = new System.Drawing.Size(51, 24);
            this.lblCurp.TabIndex = 34;
            this.lblCurp.Text = "Curp";
            // 
            // txtIdDomicilioCliente
            // 
            this.txtIdDomicilioCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdDomicilioCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDomicilioCliente.Location = new System.Drawing.Point(341, 306);
            this.txtIdDomicilioCliente.Name = "txtIdDomicilioCliente";
            this.txtIdDomicilioCliente.Size = new System.Drawing.Size(94, 23);
            this.txtIdDomicilioCliente.TabIndex = 33;
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefonoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoCliente.Location = new System.Drawing.Point(179, 226);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(256, 23);
            this.txtTelefonoCliente.TabIndex = 32;
            // 
            // btnRegistrarClientes
            // 
            this.btnRegistrarClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRegistrarClientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegistrarClientes.FlatAppearance.BorderSize = 0;
            this.btnRegistrarClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRegistrarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnRegistrarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarClientes.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarClientes.Location = new System.Drawing.Point(147, 384);
            this.btnRegistrarClientes.Name = "btnRegistrarClientes";
            this.btnRegistrarClientes.Size = new System.Drawing.Size(171, 31);
            this.btnRegistrarClientes.TabIndex = 31;
            this.btnRegistrarClientes.Text = "Registrar";
            this.btnRegistrarClientes.UseVisualStyleBackColor = false;
            this.btnRegistrarClientes.Click += new System.EventHandler(this.btnRegistrarClientes_Click);
            // 
            // dtpFechaNacCliente
            // 
            this.dtpFechaNacCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaNacCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacCliente.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacCliente.Location = new System.Drawing.Point(273, 182);
            this.dtpFechaNacCliente.Name = "dtpFechaNacCliente";
            this.dtpFechaNacCliente.Size = new System.Drawing.Size(162, 26);
            this.dtpFechaNacCliente.TabIndex = 30;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(20, 223);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(85, 24);
            this.lblTelefono.TabIndex = 25;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.ForeColor = System.Drawing.Color.White;
            this.lblFechaNac.Location = new System.Drawing.Point(20, 182);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(191, 24);
            this.lblFechaNac.TabIndex = 29;
            this.lblFechaNac.Text = "Fecha de Nacimiento";
            // 
            // lblIdDomicilio
            // 
            this.lblIdDomicilio.AutoSize = true;
            this.lblIdDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDomicilio.ForeColor = System.Drawing.Color.White;
            this.lblIdDomicilio.Location = new System.Drawing.Point(20, 306);
            this.lblIdDomicilio.Name = "lblIdDomicilio";
            this.lblIdDomicilio.Size = new System.Drawing.Size(109, 24);
            this.lblIdDomicilio.TabIndex = 27;
            this.lblIdDomicilio.Text = "ID Domicilio";
            // 
            // lblApeMat
            // 
            this.lblApeMat.AutoSize = true;
            this.lblApeMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApeMat.ForeColor = System.Drawing.Color.White;
            this.lblApeMat.Location = new System.Drawing.Point(20, 138);
            this.lblApeMat.Name = "lblApeMat";
            this.lblApeMat.Size = new System.Drawing.Size(153, 24);
            this.lblApeMat.TabIndex = 24;
            this.lblApeMat.Text = "Apellido Materno";
            // 
            // txtApeMatCliente
            // 
            this.txtApeMatCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApeMatCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApeMatCliente.Location = new System.Drawing.Point(175, 138);
            this.txtApeMatCliente.Name = "txtApeMatCliente";
            this.txtApeMatCliente.Size = new System.Drawing.Size(260, 23);
            this.txtApeMatCliente.TabIndex = 23;
            // 
            // lblApePat
            // 
            this.lblApePat.AutoSize = true;
            this.lblApePat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApePat.ForeColor = System.Drawing.Color.White;
            this.lblApePat.Location = new System.Drawing.Point(20, 96);
            this.lblApePat.Name = "lblApePat";
            this.lblApePat.Size = new System.Drawing.Size(149, 24);
            this.lblApePat.TabIndex = 22;
            this.lblApePat.Text = "Apellido Paterno";
            // 
            // txtApePatCliente
            // 
            this.txtApePatCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApePatCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApePatCliente.Location = new System.Drawing.Point(175, 96);
            this.txtApePatCliente.Name = "txtApePatCliente";
            this.txtApePatCliente.Size = new System.Drawing.Size(260, 23);
            this.txtApePatCliente.TabIndex = 21;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(20, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 24);
            this.lblNombre.TabIndex = 20;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(116, 54);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(319, 23);
            this.txtNombreCliente.TabIndex = 18;
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
            this.paneFechaHora.TabIndex = 71;
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
            // ptbClientes
            // 
            this.ptbClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbClientes.Image = global::Punto_Venta_Abarrotes.Properties.Resources.ptbClient;
            this.ptbClientes.Location = new System.Drawing.Point(401, 47);
            this.ptbClientes.Name = "ptbClientes";
            this.ptbClientes.Size = new System.Drawing.Size(339, 76);
            this.ptbClientes.TabIndex = 70;
            this.ptbClientes.TabStop = false;
            // 
            // erpClientes
            // 
            this.erpClientes.ContainerControl = this;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1080, 615);
            this.Controls.Add(this.paneFechaHora);
            this.Controls.Add(this.ptbClientes);
            this.Controls.Add(this.gpbBuscarClientes);
            this.Controls.Add(this.gpbDatosPersonales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientes";
            this.Text = "Clientes";
            this.gpbBuscarClientes.ResumeLayout(false);
            this.gpbBuscarClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.gpbDatosPersonales.ResumeLayout(false);
            this.gpbDatosPersonales.PerformLayout();
            this.paneFechaHora.ResumeLayout(false);
            this.paneFechaHora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbClientes;
        private System.Windows.Forms.GroupBox gpbBuscarClientes;
        private System.Windows.Forms.Button btnVerClientes;
        private System.Windows.Forms.TextBox txtApeMatBuscar;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.Label lblApeMatBuscar;
        private System.Windows.Forms.Label lblApPatBuscar;
        private System.Windows.Forms.TextBox txtApPatBuscar;
        private System.Windows.Forms.Label lblNomBuscar;
        private System.Windows.Forms.TextBox txtNombreBuscar;
        private System.Windows.Forms.Button btnBorrarClientes;
        private System.Windows.Forms.Button btnActualizarClientes;
        public System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnBuscarClientes;
        private System.Windows.Forms.GroupBox gpbDatosPersonales;
        private System.Windows.Forms.TextBox txtIdDomicilioCliente;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.Button btnRegistrarClientes;
        private System.Windows.Forms.DateTimePicker dtpFechaNacCliente;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblIdDomicilio;
        private System.Windows.Forms.Label lblApeMat;
        private System.Windows.Forms.TextBox txtApeMatCliente;
        private System.Windows.Forms.Label lblApePat;
        private System.Windows.Forms.TextBox txtApePatCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Panel paneFechaHora;
        private System.Windows.Forms.Label lblMostrarHora;
        private System.Windows.Forms.Label lblMostrarFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.Label lblCurp;
        private System.Windows.Forms.Timer tmrFechaHora;
        private System.Windows.Forms.ToolTip tltBuscar;
        private System.Windows.Forms.ErrorProvider erpClientes;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.Label lblEstatus;
    }
}