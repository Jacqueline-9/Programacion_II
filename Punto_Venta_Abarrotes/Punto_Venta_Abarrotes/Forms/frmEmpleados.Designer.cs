namespace Punto_Venta_Abarrotes
{
    partial class frmEmpleados
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
            this.gpbBuscarEmpleados = new System.Windows.Forms.GroupBox();
            this.btnVerEmpleados = new System.Windows.Forms.Button();
            this.txtApeMatBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.lblApeMatBuscar = new System.Windows.Forms.Label();
            this.lblApPatBuscar = new System.Windows.Forms.Label();
            this.txtApPatBuscar = new System.Windows.Forms.TextBox();
            this.lblNomBuscar = new System.Windows.Forms.Label();
            this.txtNombreBuscar = new System.Windows.Forms.TextBox();
            this.btnBorrarEmpleados = new System.Windows.Forms.Button();
            this.btnActualizarEmpleados = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnBuscarEmpleados = new System.Windows.Forms.Button();
            this.gpbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.txtIdPuesto = new System.Windows.Forms.TextBox();
            this.lblIdPuesto = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.lblRFC = new System.Windows.Forms.Label();
            this.txtIdDomicilioEmpleado = new System.Windows.Forms.TextBox();
            this.txtTelefonoEmpleado = new System.Windows.Forms.TextBox();
            this.btnRegistrarEmpleados = new System.Windows.Forms.Button();
            this.dtpFechaNacEmpleado = new System.Windows.Forms.DateTimePicker();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblIdDomicilio = new System.Windows.Forms.Label();
            this.lblApeMat = new System.Windows.Forms.Label();
            this.txtApeMatEmpleado = new System.Windows.Forms.TextBox();
            this.lblApePat = new System.Windows.Forms.Label();
            this.txtApePatEmpleado = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.ptbEmpleados = new System.Windows.Forms.PictureBox();
            this.paneFechaHora = new System.Windows.Forms.Panel();
            this.lblMostrarHora = new System.Windows.Forms.Label();
            this.lblMostrarFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.tmrFechaHora = new System.Windows.Forms.Timer(this.components);
            this.tltBuscar = new System.Windows.Forms.ToolTip(this.components);
            this.erpEmpleados = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpbBuscarEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.gpbDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEmpleados)).BeginInit();
            this.paneFechaHora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbBuscarEmpleados
            // 
            this.gpbBuscarEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbBuscarEmpleados.Controls.Add(this.btnVerEmpleados);
            this.gpbBuscarEmpleados.Controls.Add(this.txtApeMatBuscar);
            this.gpbBuscarEmpleados.Controls.Add(this.lblBuscarPor);
            this.gpbBuscarEmpleados.Controls.Add(this.lblApeMatBuscar);
            this.gpbBuscarEmpleados.Controls.Add(this.lblApPatBuscar);
            this.gpbBuscarEmpleados.Controls.Add(this.txtApPatBuscar);
            this.gpbBuscarEmpleados.Controls.Add(this.lblNomBuscar);
            this.gpbBuscarEmpleados.Controls.Add(this.txtNombreBuscar);
            this.gpbBuscarEmpleados.Controls.Add(this.btnBorrarEmpleados);
            this.gpbBuscarEmpleados.Controls.Add(this.btnActualizarEmpleados);
            this.gpbBuscarEmpleados.Controls.Add(this.dgvClientes);
            this.gpbBuscarEmpleados.Controls.Add(this.btnBuscarEmpleados);
            this.gpbBuscarEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBuscarEmpleados.ForeColor = System.Drawing.Color.White;
            this.gpbBuscarEmpleados.Location = new System.Drawing.Point(503, 141);
            this.gpbBuscarEmpleados.Name = "gpbBuscarEmpleados";
            this.gpbBuscarEmpleados.Size = new System.Drawing.Size(558, 418);
            this.gpbBuscarEmpleados.TabIndex = 72;
            this.gpbBuscarEmpleados.TabStop = false;
            this.gpbBuscarEmpleados.Text = "Búsqueda de Empleados";
            // 
            // btnVerEmpleados
            // 
            this.btnVerEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnVerEmpleados.FlatAppearance.BorderSize = 0;
            this.btnVerEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btnVerEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnVerEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnVerEmpleados.Location = new System.Drawing.Point(361, 355);
            this.btnVerEmpleados.Name = "btnVerEmpleados";
            this.btnVerEmpleados.Size = new System.Drawing.Size(190, 31);
            this.btnVerEmpleados.TabIndex = 77;
            this.btnVerEmpleados.Text = "Ver Empleados";
            this.btnVerEmpleados.UseVisualStyleBackColor = false;
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
            // btnBorrarEmpleados
            // 
            this.btnBorrarEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBorrarEmpleados.FlatAppearance.BorderSize = 0;
            this.btnBorrarEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBorrarEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnBorrarEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnBorrarEmpleados.Location = new System.Drawing.Point(172, 355);
            this.btnBorrarEmpleados.Name = "btnBorrarEmpleados";
            this.btnBorrarEmpleados.Size = new System.Drawing.Size(126, 31);
            this.btnBorrarEmpleados.TabIndex = 64;
            this.btnBorrarEmpleados.Text = "Borrar";
            this.btnBorrarEmpleados.UseVisualStyleBackColor = false;
            // 
            // btnActualizarEmpleados
            // 
            this.btnActualizarEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnActualizarEmpleados.FlatAppearance.BorderSize = 0;
            this.btnActualizarEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnActualizarEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnActualizarEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnActualizarEmpleados.Location = new System.Drawing.Point(16, 355);
            this.btnActualizarEmpleados.Name = "btnActualizarEmpleados";
            this.btnActualizarEmpleados.Size = new System.Drawing.Size(117, 31);
            this.btnActualizarEmpleados.TabIndex = 65;
            this.btnActualizarEmpleados.Text = "Actualizar";
            this.btnActualizarEmpleados.UseVisualStyleBackColor = false;
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
            // btnBuscarEmpleados
            // 
            this.btnBuscarEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBuscarEmpleados.FlatAppearance.BorderSize = 0;
            this.btnBuscarEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.btnBuscarEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnBuscarEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnBuscarEmpleados.Location = new System.Drawing.Point(366, 104);
            this.btnBuscarEmpleados.Name = "btnBuscarEmpleados";
            this.btnBuscarEmpleados.Size = new System.Drawing.Size(186, 26);
            this.btnBuscarEmpleados.TabIndex = 62;
            this.btnBuscarEmpleados.Text = "Buscar ";
            this.btnBuscarEmpleados.UseVisualStyleBackColor = false;
            this.btnBuscarEmpleados.Click += new System.EventHandler(this.btnBuscarEmpleados_Click);
            // 
            // gpbDatosPersonales
            // 
            this.gpbDatosPersonales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gpbDatosPersonales.Controls.Add(this.txtEstatus);
            this.gpbDatosPersonales.Controls.Add(this.lblEstatus);
            this.gpbDatosPersonales.Controls.Add(this.txtIdUsuario);
            this.gpbDatosPersonales.Controls.Add(this.lblIdUsuario);
            this.gpbDatosPersonales.Controls.Add(this.txtIdPuesto);
            this.gpbDatosPersonales.Controls.Add(this.lblIdPuesto);
            this.gpbDatosPersonales.Controls.Add(this.txtRFC);
            this.gpbDatosPersonales.Controls.Add(this.lblRFC);
            this.gpbDatosPersonales.Controls.Add(this.txtIdDomicilioEmpleado);
            this.gpbDatosPersonales.Controls.Add(this.txtTelefonoEmpleado);
            this.gpbDatosPersonales.Controls.Add(this.btnRegistrarEmpleados);
            this.gpbDatosPersonales.Controls.Add(this.dtpFechaNacEmpleado);
            this.gpbDatosPersonales.Controls.Add(this.lblTelefono);
            this.gpbDatosPersonales.Controls.Add(this.lblFechaNac);
            this.gpbDatosPersonales.Controls.Add(this.lblIdDomicilio);
            this.gpbDatosPersonales.Controls.Add(this.lblApeMat);
            this.gpbDatosPersonales.Controls.Add(this.txtApeMatEmpleado);
            this.gpbDatosPersonales.Controls.Add(this.lblApePat);
            this.gpbDatosPersonales.Controls.Add(this.txtApePatEmpleado);
            this.gpbDatosPersonales.Controls.Add(this.lblNombre);
            this.gpbDatosPersonales.Controls.Add(this.txtNombreEmpleado);
            this.gpbDatosPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatosPersonales.ForeColor = System.Drawing.Color.White;
            this.gpbDatosPersonales.Location = new System.Drawing.Point(19, 121);
            this.gpbDatosPersonales.Name = "gpbDatosPersonales";
            this.gpbDatosPersonales.Size = new System.Drawing.Size(460, 445);
            this.gpbDatosPersonales.TabIndex = 71;
            this.gpbDatosPersonales.TabStop = false;
            this.gpbDatosPersonales.Text = "Datos personales";
            // 
            // txtEstatus
            // 
            this.txtEstatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstatus.Location = new System.Drawing.Point(273, 362);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(162, 23);
            this.txtEstatus.TabIndex = 41;
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatus.ForeColor = System.Drawing.Color.White;
            this.lblEstatus.Location = new System.Drawing.Point(20, 359);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(70, 24);
            this.lblEstatus.TabIndex = 40;
            this.lblEstatus.Text = "Estatus";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsuario.Location = new System.Drawing.Point(273, 333);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(162, 23);
            this.txtIdUsuario.TabIndex = 39;
            this.txtIdUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdUsuario_KeyPress);
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUsuario.ForeColor = System.Drawing.Color.White;
            this.lblIdUsuario.Location = new System.Drawing.Point(20, 333);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(96, 24);
            this.lblIdUsuario.TabIndex = 38;
            this.lblIdUsuario.Text = "ID Usuario";
            // 
            // txtIdPuesto
            // 
            this.txtIdPuesto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPuesto.Location = new System.Drawing.Point(273, 304);
            this.txtIdPuesto.Name = "txtIdPuesto";
            this.txtIdPuesto.Size = new System.Drawing.Size(162, 23);
            this.txtIdPuesto.TabIndex = 37;
            this.txtIdPuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdPuesto_KeyPress);
            // 
            // lblIdPuesto
            // 
            this.lblIdPuesto.AutoSize = true;
            this.lblIdPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPuesto.ForeColor = System.Drawing.Color.White;
            this.lblIdPuesto.Location = new System.Drawing.Point(20, 304);
            this.lblIdPuesto.Name = "lblIdPuesto";
            this.lblIdPuesto.Size = new System.Drawing.Size(90, 24);
            this.lblIdPuesto.TabIndex = 36;
            this.lblIdPuesto.Text = "ID Puesto";
            // 
            // txtRFC
            // 
            this.txtRFC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFC.Location = new System.Drawing.Point(179, 237);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(256, 23);
            this.txtRFC.TabIndex = 35;
            // 
            // lblRFC
            // 
            this.lblRFC.AutoSize = true;
            this.lblRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRFC.ForeColor = System.Drawing.Color.White;
            this.lblRFC.Location = new System.Drawing.Point(20, 236);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(48, 24);
            this.lblRFC.TabIndex = 34;
            this.lblRFC.Text = "RFC";
            // 
            // txtIdDomicilioEmpleado
            // 
            this.txtIdDomicilioEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdDomicilioEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDomicilioEmpleado.Location = new System.Drawing.Point(273, 275);
            this.txtIdDomicilioEmpleado.Name = "txtIdDomicilioEmpleado";
            this.txtIdDomicilioEmpleado.Size = new System.Drawing.Size(162, 23);
            this.txtIdDomicilioEmpleado.TabIndex = 33;
            this.txtIdDomicilioEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdDomicilioCliente_KeyPress);
            // 
            // txtTelefonoEmpleado
            // 
            this.txtTelefonoEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefonoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoEmpleado.Location = new System.Drawing.Point(179, 199);
            this.txtTelefonoEmpleado.Name = "txtTelefonoEmpleado";
            this.txtTelefonoEmpleado.Size = new System.Drawing.Size(256, 23);
            this.txtTelefonoEmpleado.TabIndex = 32;
            // 
            // btnRegistrarEmpleados
            // 
            this.btnRegistrarEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRegistrarEmpleados.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegistrarEmpleados.FlatAppearance.BorderSize = 0;
            this.btnRegistrarEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRegistrarEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnRegistrarEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarEmpleados.Location = new System.Drawing.Point(146, 407);
            this.btnRegistrarEmpleados.Name = "btnRegistrarEmpleados";
            this.btnRegistrarEmpleados.Size = new System.Drawing.Size(171, 31);
            this.btnRegistrarEmpleados.TabIndex = 31;
            this.btnRegistrarEmpleados.Text = "Registrar";
            this.btnRegistrarEmpleados.UseVisualStyleBackColor = false;
            this.btnRegistrarEmpleados.Click += new System.EventHandler(this.btnRegistrarEmpleados_Click);
            // 
            // dtpFechaNacEmpleado
            // 
            this.dtpFechaNacEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaNacEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacEmpleado.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacEmpleado.Location = new System.Drawing.Point(273, 158);
            this.dtpFechaNacEmpleado.Name = "dtpFechaNacEmpleado";
            this.dtpFechaNacEmpleado.Size = new System.Drawing.Size(162, 26);
            this.dtpFechaNacEmpleado.TabIndex = 30;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(20, 196);
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
            this.lblFechaNac.Location = new System.Drawing.Point(20, 160);
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
            this.lblIdDomicilio.Location = new System.Drawing.Point(20, 275);
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
            this.lblApeMat.Location = new System.Drawing.Point(20, 125);
            this.lblApeMat.Name = "lblApeMat";
            this.lblApeMat.Size = new System.Drawing.Size(153, 24);
            this.lblApeMat.TabIndex = 24;
            this.lblApeMat.Text = "Apellido Materno";
            // 
            // txtApeMatEmpleado
            // 
            this.txtApeMatEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApeMatEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApeMatEmpleado.Location = new System.Drawing.Point(175, 125);
            this.txtApeMatEmpleado.Name = "txtApeMatEmpleado";
            this.txtApeMatEmpleado.Size = new System.Drawing.Size(260, 23);
            this.txtApeMatEmpleado.TabIndex = 23;
            // 
            // lblApePat
            // 
            this.lblApePat.AutoSize = true;
            this.lblApePat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApePat.ForeColor = System.Drawing.Color.White;
            this.lblApePat.Location = new System.Drawing.Point(20, 86);
            this.lblApePat.Name = "lblApePat";
            this.lblApePat.Size = new System.Drawing.Size(149, 24);
            this.lblApePat.TabIndex = 22;
            this.lblApePat.Text = "Apellido Paterno";
            // 
            // txtApePatEmpleado
            // 
            this.txtApePatEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApePatEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApePatEmpleado.Location = new System.Drawing.Point(175, 86);
            this.txtApePatEmpleado.Name = "txtApePatEmpleado";
            this.txtApePatEmpleado.Size = new System.Drawing.Size(260, 23);
            this.txtApePatEmpleado.TabIndex = 21;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(20, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 24);
            this.lblNombre.TabIndex = 20;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpleado.Location = new System.Drawing.Point(116, 46);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(319, 23);
            this.txtNombreEmpleado.TabIndex = 18;
            // 
            // ptbEmpleados
            // 
            this.ptbEmpleados.Image = global::Punto_Venta_Abarrotes.Properties.Resources.tbEmpleado;
            this.ptbEmpleados.Location = new System.Drawing.Point(312, 39);
            this.ptbEmpleados.Name = "ptbEmpleados";
            this.ptbEmpleados.Size = new System.Drawing.Size(489, 76);
            this.ptbEmpleados.TabIndex = 73;
            this.ptbEmpleados.TabStop = false;
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
            this.paneFechaHora.TabIndex = 74;
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
            // erpEmpleados
            // 
            this.erpEmpleados.ContainerControl = this;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1080, 615);
            this.Controls.Add(this.paneFechaHora);
            this.Controls.Add(this.ptbEmpleados);
            this.Controls.Add(this.gpbBuscarEmpleados);
            this.Controls.Add(this.gpbDatosPersonales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpleados";
            this.Text = "Empleados";
            this.gpbBuscarEmpleados.ResumeLayout(false);
            this.gpbBuscarEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.gpbDatosPersonales.ResumeLayout(false);
            this.gpbDatosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEmpleados)).EndInit();
            this.paneFechaHora.ResumeLayout(false);
            this.paneFechaHora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbEmpleados;
        private System.Windows.Forms.GroupBox gpbBuscarEmpleados;
        private System.Windows.Forms.Button btnVerEmpleados;
        private System.Windows.Forms.TextBox txtApeMatBuscar;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.Label lblApeMatBuscar;
        private System.Windows.Forms.Label lblApPatBuscar;
        private System.Windows.Forms.TextBox txtApPatBuscar;
        private System.Windows.Forms.Label lblNomBuscar;
        private System.Windows.Forms.TextBox txtNombreBuscar;
        private System.Windows.Forms.Button btnBorrarEmpleados;
        private System.Windows.Forms.Button btnActualizarEmpleados;
        public System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnBuscarEmpleados;
        private System.Windows.Forms.GroupBox gpbDatosPersonales;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label lblRFC;
        private System.Windows.Forms.TextBox txtIdDomicilioEmpleado;
        private System.Windows.Forms.TextBox txtTelefonoEmpleado;
        private System.Windows.Forms.Button btnRegistrarEmpleados;
        private System.Windows.Forms.DateTimePicker dtpFechaNacEmpleado;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblIdDomicilio;
        private System.Windows.Forms.Label lblApeMat;
        private System.Windows.Forms.TextBox txtApeMatEmpleado;
        private System.Windows.Forms.Label lblApePat;
        private System.Windows.Forms.TextBox txtApePatEmpleado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Panel paneFechaHora;
        private System.Windows.Forms.Label lblMostrarHora;
        private System.Windows.Forms.Label lblMostrarFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer tmrFechaHora;
        private System.Windows.Forms.ToolTip tltBuscar;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.TextBox txtIdPuesto;
        private System.Windows.Forms.Label lblIdPuesto;
        private System.Windows.Forms.ErrorProvider erpEmpleados;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.Label lblEstatus;
    }
}