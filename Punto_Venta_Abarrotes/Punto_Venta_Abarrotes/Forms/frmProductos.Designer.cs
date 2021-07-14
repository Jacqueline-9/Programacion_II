namespace Punto_Venta_Abarrotes
{
    partial class frmProductos
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
            this.gpbRegistrarPuestos = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dtpFechaCaduci = new System.Windows.Forms.DateTimePicker();
            this.lblFechaCaduci = new System.Windows.Forms.Label();
            this.nudExistencia = new System.Windows.Forms.NumericUpDown();
            this.lblExistencia = new System.Windows.Forms.Label();
            this.cmbUnidad = new System.Windows.Forms.ComboBox();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.lblContenidoNeto = new System.Windows.Forms.Label();
            this.txtContenidoNeto = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.gpbProductos = new System.Windows.Forms.GroupBox();
            this.btnBuscarPrecio = new System.Windows.Forms.Button();
            this.btnBuscarNombre = new System.Windows.Forms.Button();
            this.btnCambiarModoBusqueda = new System.Windows.Forms.Button();
            this.cmbTipoBuscar = new System.Windows.Forms.ComboBox();
            this.lblTipoBuscar = new System.Windows.Forms.Label();
            this.nudExistenciaBuscar = new System.Windows.Forms.NumericUpDown();
            this.lblExistenciaBuscar = new System.Windows.Forms.Label();
            this.lblPrecioBuscar = new System.Windows.Forms.Label();
            this.txtPrecioBuscar = new System.Windows.Forms.TextBox();
            this.lblNomBuscar = new System.Windows.Forms.Label();
            this.txtNombreBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscarTipo = new System.Windows.Forms.Button();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.gpbBuscar = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.rdbTipoProducto = new System.Windows.Forms.RadioButton();
            this.rdbExistencia = new System.Windows.Forms.RadioButton();
            this.rdbPrecio = new System.Windows.Forms.RadioButton();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.btnBuscarExistencia = new System.Windows.Forms.Button();
            this.btnVerProductos = new System.Windows.Forms.Button();
            this.paneFechaHora = new System.Windows.Forms.Panel();
            this.lblMostrarHora = new System.Windows.Forms.Label();
            this.lblMostrarFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.tmrHoraFecha = new System.Windows.Forms.Timer(this.components);
            this.tltBuscar = new System.Windows.Forms.ToolTip(this.components);
            this.erpProductos = new System.Windows.Forms.ErrorProvider(this.components);
            this.ptbProductos = new System.Windows.Forms.PictureBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.gpbRegistrarPuestos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistencia)).BeginInit();
            this.gpbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistenciaBuscar)).BeginInit();
            this.gpbBuscar.SuspendLayout();
            this.paneFechaHora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbRegistrarPuestos
            // 
            this.gpbRegistrarPuestos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gpbRegistrarPuestos.Controls.Add(this.txtDescripcion);
            this.gpbRegistrarPuestos.Controls.Add(this.lblDescripcion);
            this.gpbRegistrarPuestos.Controls.Add(this.btnRegistrar);
            this.gpbRegistrarPuestos.Controls.Add(this.dtpFechaCaduci);
            this.gpbRegistrarPuestos.Controls.Add(this.lblFechaCaduci);
            this.gpbRegistrarPuestos.Controls.Add(this.nudExistencia);
            this.gpbRegistrarPuestos.Controls.Add(this.lblExistencia);
            this.gpbRegistrarPuestos.Controls.Add(this.cmbUnidad);
            this.gpbRegistrarPuestos.Controls.Add(this.lblUnidad);
            this.gpbRegistrarPuestos.Controls.Add(this.lblContenidoNeto);
            this.gpbRegistrarPuestos.Controls.Add(this.txtContenidoNeto);
            this.gpbRegistrarPuestos.Controls.Add(this.lblPrecio);
            this.gpbRegistrarPuestos.Controls.Add(this.txtPrecio);
            this.gpbRegistrarPuestos.Controls.Add(this.lblNombre);
            this.gpbRegistrarPuestos.Controls.Add(this.cmbTipo);
            this.gpbRegistrarPuestos.Controls.Add(this.txtNombre);
            this.gpbRegistrarPuestos.Controls.Add(this.lblTipo);
            this.gpbRegistrarPuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbRegistrarPuestos.ForeColor = System.Drawing.Color.White;
            this.gpbRegistrarPuestos.Location = new System.Drawing.Point(12, 120);
            this.gpbRegistrarPuestos.Name = "gpbRegistrarPuestos";
            this.gpbRegistrarPuestos.Size = new System.Drawing.Size(460, 446);
            this.gpbRegistrarPuestos.TabIndex = 62;
            this.gpbRegistrarPuestos.TabStop = false;
            this.gpbRegistrarPuestos.Text = "Registrar Producto";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(255, 139);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(178, 23);
            this.txtDescripcion.TabIndex = 33;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(18, 139);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(110, 24);
            this.lblDescripcion.TabIndex = 32;
            this.lblDescripcion.Text = "Descripción";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(157, 401);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(171, 31);
            this.btnRegistrar.TabIndex = 31;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dtpFechaCaduci
            // 
            this.dtpFechaCaduci.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaCaduci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCaduci.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaCaduci.Location = new System.Drawing.Point(255, 354);
            this.dtpFechaCaduci.Name = "dtpFechaCaduci";
            this.dtpFechaCaduci.Size = new System.Drawing.Size(178, 26);
            this.dtpFechaCaduci.TabIndex = 30;
            // 
            // lblFechaCaduci
            // 
            this.lblFechaCaduci.AutoSize = true;
            this.lblFechaCaduci.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCaduci.ForeColor = System.Drawing.Color.White;
            this.lblFechaCaduci.Location = new System.Drawing.Point(18, 356);
            this.lblFechaCaduci.Name = "lblFechaCaduci";
            this.lblFechaCaduci.Size = new System.Drawing.Size(184, 24);
            this.lblFechaCaduci.TabIndex = 29;
            this.lblFechaCaduci.Text = "Fecha de caducidad";
            // 
            // nudExistencia
            // 
            this.nudExistencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudExistencia.Location = new System.Drawing.Point(255, 310);
            this.nudExistencia.Name = "nudExistencia";
            this.nudExistencia.Size = new System.Drawing.Size(178, 26);
            this.nudExistencia.TabIndex = 28;
            // 
            // lblExistencia
            // 
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistencia.ForeColor = System.Drawing.Color.White;
            this.lblExistencia.Location = new System.Drawing.Point(18, 312);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(96, 24);
            this.lblExistencia.TabIndex = 27;
            this.lblExistencia.Text = "Existencia";
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnidad.FormattingEnabled = true;
            this.cmbUnidad.Items.AddRange(new object[] {
            "attogramos",
            "centigramos",
            "decigramos",
            "Exagramos",
            "femptogramos",
            "Gigagramos",
            "Gramos",
            "Hectogramo",
            "Kilogramo",
            "microgramo",
            "miligramo",
            "Miriagramo",
            "nanogramo",
            "Petagramo",
            "picogramo",
            "Teragramo",
            "yoctogramo ",
            "Yottagramo",
            "zeptogramo",
            "zettagramo",
            "Galón",
            "Litro",
            "Mililitro"});
            this.cmbUnidad.Location = new System.Drawing.Point(255, 266);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(178, 24);
            this.cmbUnidad.TabIndex = 26;
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.ForeColor = System.Drawing.Color.White;
            this.lblUnidad.Location = new System.Drawing.Point(18, 266);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(186, 24);
            this.lblUnidad.TabIndex = 25;
            this.lblUnidad.Text = "Unidad de contenido";
            // 
            // lblContenidoNeto
            // 
            this.lblContenidoNeto.AutoSize = true;
            this.lblContenidoNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContenidoNeto.ForeColor = System.Drawing.Color.White;
            this.lblContenidoNeto.Location = new System.Drawing.Point(18, 224);
            this.lblContenidoNeto.Name = "lblContenidoNeto";
            this.lblContenidoNeto.Size = new System.Drawing.Size(156, 24);
            this.lblContenidoNeto.TabIndex = 24;
            this.lblContenidoNeto.Text = "Contenido NETO";
            // 
            // txtContenidoNeto
            // 
            this.txtContenidoNeto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContenidoNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContenidoNeto.Location = new System.Drawing.Point(255, 224);
            this.txtContenidoNeto.Name = "txtContenidoNeto";
            this.txtContenidoNeto.Size = new System.Drawing.Size(178, 23);
            this.txtContenidoNeto.TabIndex = 23;
            this.txtContenidoNeto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContenidoNeto_KeyPress);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(18, 184);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(175, 24);
            this.lblPrecio.TabIndex = 22;
            this.lblPrecio.Text = "Precio del producto";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(255, 184);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(178, 23);
            this.txtPrecio.TabIndex = 21;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(18, 92);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(190, 24);
            this.lblNombre.TabIndex = 20;
            this.lblNombre.Text = "Nombre del producto";
            // 
            // cmbTipo
            // 
            this.cmbTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Abarrotes",
            "Carnes",
            "Lácteos"});
            this.cmbTipo.Location = new System.Drawing.Point(255, 49);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(178, 24);
            this.cmbTipo.TabIndex = 19;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(255, 92);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(178, 23);
            this.txtNombre.TabIndex = 18;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(18, 46);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(155, 24);
            this.lblTipo.TabIndex = 17;
            this.lblTipo.Text = "Tipo de producto";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(478, 535);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(180, 31);
            this.btnBorrar.TabIndex = 64;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(689, 535);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(174, 31);
            this.btnActualizar.TabIndex = 65;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // gpbProductos
            // 
            this.gpbProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbProductos.Controls.Add(this.gpbBuscar);
            this.gpbProductos.Controls.Add(this.btnBuscarExistencia);
            this.gpbProductos.Controls.Add(this.btnBuscarPrecio);
            this.gpbProductos.Controls.Add(this.btnBuscarNombre);
            this.gpbProductos.Controls.Add(this.btnCambiarModoBusqueda);
            this.gpbProductos.Controls.Add(this.cmbTipoBuscar);
            this.gpbProductos.Controls.Add(this.lblTipoBuscar);
            this.gpbProductos.Controls.Add(this.nudExistenciaBuscar);
            this.gpbProductos.Controls.Add(this.lblExistenciaBuscar);
            this.gpbProductos.Controls.Add(this.lblPrecioBuscar);
            this.gpbProductos.Controls.Add(this.txtPrecioBuscar);
            this.gpbProductos.Controls.Add(this.lblNomBuscar);
            this.gpbProductos.Controls.Add(this.txtNombreBuscar);
            this.gpbProductos.Controls.Add(this.btnBuscarTipo);
            this.gpbProductos.Controls.Add(this.lblBuscarPor);
            this.gpbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbProductos.ForeColor = System.Drawing.Color.White;
            this.gpbProductos.Location = new System.Drawing.Point(478, 143);
            this.gpbProductos.Name = "gpbProductos";
            this.gpbProductos.Size = new System.Drawing.Size(566, 173);
            this.gpbProductos.TabIndex = 63;
            this.gpbProductos.TabStop = false;
            this.gpbProductos.Text = "Productos";
            // 
            // btnBuscarPrecio
            // 
            this.btnBuscarPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBuscarPrecio.FlatAppearance.BorderSize = 0;
            this.btnBuscarPrecio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.btnBuscarPrecio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnBuscarPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPrecio.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPrecio.Location = new System.Drawing.Point(393, 116);
            this.btnBuscarPrecio.Name = "btnBuscarPrecio";
            this.btnBuscarPrecio.Size = new System.Drawing.Size(151, 26);
            this.btnBuscarPrecio.TabIndex = 98;
            this.btnBuscarPrecio.Text = "Buscar ";
            this.btnBuscarPrecio.UseVisualStyleBackColor = false;
            this.btnBuscarPrecio.Visible = false;
            this.btnBuscarPrecio.Click += new System.EventHandler(this.btnBuscarPrecio_Click);
            // 
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBuscarNombre.FlatAppearance.BorderSize = 0;
            this.btnBuscarNombre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.btnBuscarNombre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnBuscarNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarNombre.ForeColor = System.Drawing.Color.White;
            this.btnBuscarNombre.Location = new System.Drawing.Point(393, 114);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(151, 26);
            this.btnBuscarNombre.TabIndex = 97;
            this.btnBuscarNombre.Text = "Buscar ";
            this.btnBuscarNombre.UseVisualStyleBackColor = false;
            this.btnBuscarNombre.Visible = false;
            this.btnBuscarNombre.Click += new System.EventHandler(this.btnBuscarNombre_Click);
            // 
            // btnCambiarModoBusqueda
            // 
            this.btnCambiarModoBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCambiarModoBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCambiarModoBusqueda.FlatAppearance.BorderSize = 0;
            this.btnCambiarModoBusqueda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.btnCambiarModoBusqueda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnCambiarModoBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarModoBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarModoBusqueda.ForeColor = System.Drawing.Color.White;
            this.btnCambiarModoBusqueda.Location = new System.Drawing.Point(17, 132);
            this.btnCambiarModoBusqueda.Name = "btnCambiarModoBusqueda";
            this.btnCambiarModoBusqueda.Size = new System.Drawing.Size(269, 26);
            this.btnCambiarModoBusqueda.TabIndex = 96;
            this.btnCambiarModoBusqueda.Text = "Cambiar modo de busqueda";
            this.btnCambiarModoBusqueda.UseVisualStyleBackColor = false;
            this.btnCambiarModoBusqueda.Visible = false;
            this.btnCambiarModoBusqueda.Click += new System.EventHandler(this.btnCambiarModoBusqueda_Click);
            // 
            // cmbTipoBuscar
            // 
            this.cmbTipoBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoBuscar.FormattingEnabled = true;
            this.cmbTipoBuscar.Items.AddRange(new object[] {
            "Abarrotes",
            "Carnes",
            "Lácteos"});
            this.cmbTipoBuscar.Location = new System.Drawing.Point(237, 66);
            this.cmbTipoBuscar.Name = "cmbTipoBuscar";
            this.cmbTipoBuscar.Size = new System.Drawing.Size(233, 23);
            this.cmbTipoBuscar.TabIndex = 95;
            this.cmbTipoBuscar.Visible = false;
            // 
            // lblTipoBuscar
            // 
            this.lblTipoBuscar.AutoSize = true;
            this.lblTipoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoBuscar.ForeColor = System.Drawing.Color.White;
            this.lblTipoBuscar.Location = new System.Drawing.Point(120, 69);
            this.lblTipoBuscar.Name = "lblTipoBuscar";
            this.lblTipoBuscar.Size = new System.Drawing.Size(111, 16);
            this.lblTipoBuscar.TabIndex = 94;
            this.lblTipoBuscar.Text = "Tipo de producto";
            this.lblTipoBuscar.Visible = false;
            // 
            // nudExistenciaBuscar
            // 
            this.nudExistenciaBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudExistenciaBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudExistenciaBuscar.Location = new System.Drawing.Point(237, 67);
            this.nudExistenciaBuscar.Name = "nudExistenciaBuscar";
            this.nudExistenciaBuscar.Size = new System.Drawing.Size(154, 22);
            this.nudExistenciaBuscar.TabIndex = 93;
            this.nudExistenciaBuscar.Visible = false;
            // 
            // lblExistenciaBuscar
            // 
            this.lblExistenciaBuscar.AutoSize = true;
            this.lblExistenciaBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistenciaBuscar.ForeColor = System.Drawing.Color.White;
            this.lblExistenciaBuscar.Location = new System.Drawing.Point(147, 70);
            this.lblExistenciaBuscar.Name = "lblExistenciaBuscar";
            this.lblExistenciaBuscar.Size = new System.Drawing.Size(69, 16);
            this.lblExistenciaBuscar.TabIndex = 92;
            this.lblExistenciaBuscar.Text = "Existencia";
            this.lblExistenciaBuscar.Visible = false;
            // 
            // lblPrecioBuscar
            // 
            this.lblPrecioBuscar.AutoSize = true;
            this.lblPrecioBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioBuscar.ForeColor = System.Drawing.Color.White;
            this.lblPrecioBuscar.Location = new System.Drawing.Point(147, 70);
            this.lblPrecioBuscar.Name = "lblPrecioBuscar";
            this.lblPrecioBuscar.Size = new System.Drawing.Size(47, 16);
            this.lblPrecioBuscar.TabIndex = 91;
            this.lblPrecioBuscar.Text = "Precio";
            this.lblPrecioBuscar.Visible = false;
            // 
            // txtPrecioBuscar
            // 
            this.txtPrecioBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioBuscar.Location = new System.Drawing.Point(207, 67);
            this.txtPrecioBuscar.Name = "txtPrecioBuscar";
            this.txtPrecioBuscar.Size = new System.Drawing.Size(246, 22);
            this.txtPrecioBuscar.TabIndex = 90;
            this.txtPrecioBuscar.Visible = false;
            // 
            // lblNomBuscar
            // 
            this.lblNomBuscar.AutoSize = true;
            this.lblNomBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomBuscar.ForeColor = System.Drawing.Color.White;
            this.lblNomBuscar.Location = new System.Drawing.Point(33, 70);
            this.lblNomBuscar.Name = "lblNomBuscar";
            this.lblNomBuscar.Size = new System.Drawing.Size(57, 16);
            this.lblNomBuscar.TabIndex = 89;
            this.lblNomBuscar.Text = "Nombre";
            this.lblNomBuscar.Visible = false;
            // 
            // txtNombreBuscar
            // 
            this.txtNombreBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreBuscar.Location = new System.Drawing.Point(101, 67);
            this.txtNombreBuscar.Name = "txtNombreBuscar";
            this.txtNombreBuscar.Size = new System.Drawing.Size(426, 22);
            this.txtNombreBuscar.TabIndex = 88;
            this.txtNombreBuscar.Visible = false;
            // 
            // btnBuscarTipo
            // 
            this.btnBuscarTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBuscarTipo.FlatAppearance.BorderSize = 0;
            this.btnBuscarTipo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.btnBuscarTipo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnBuscarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTipo.ForeColor = System.Drawing.Color.White;
            this.btnBuscarTipo.Location = new System.Drawing.Point(393, 116);
            this.btnBuscarTipo.Name = "btnBuscarTipo";
            this.btnBuscarTipo.Size = new System.Drawing.Size(151, 26);
            this.btnBuscarTipo.TabIndex = 87;
            this.btnBuscarTipo.Text = "Buscar ";
            this.btnBuscarTipo.UseVisualStyleBackColor = false;
            this.btnBuscarTipo.Visible = false;
            this.btnBuscarTipo.Click += new System.EventHandler(this.btnBuscarTipo_Click);
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPor.Location = new System.Drawing.Point(264, 26);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(87, 16);
            this.lblBuscarPor.TabIndex = 72;
            this.lblBuscarPor.Text = "Buscar por:";
            // 
            // gpbBuscar
            // 
            this.gpbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbBuscar.Controls.Add(this.btnAceptar);
            this.gpbBuscar.Controls.Add(this.rdbTipoProducto);
            this.gpbBuscar.Controls.Add(this.rdbExistencia);
            this.gpbBuscar.Controls.Add(this.rdbPrecio);
            this.gpbBuscar.Controls.Add(this.rdbNombre);
            this.gpbBuscar.Location = new System.Drawing.Point(6, 54);
            this.gpbBuscar.Name = "gpbBuscar";
            this.gpbBuscar.Size = new System.Drawing.Size(554, 104);
            this.gpbBuscar.TabIndex = 87;
            this.gpbBuscar.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(206, 66);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(151, 26);
            this.btnAceptar.TabIndex = 87;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // rdbTipoProducto
            // 
            this.rdbTipoProducto.AutoSize = true;
            this.rdbTipoProducto.Location = new System.Drawing.Point(230, 22);
            this.rdbTipoProducto.Name = "rdbTipoProducto";
            this.rdbTipoProducto.Size = new System.Drawing.Size(177, 29);
            this.rdbTipoProducto.TabIndex = 79;
            this.rdbTipoProducto.TabStop = true;
            this.rdbTipoProducto.Text = "Tipo de producto";
            this.rdbTipoProducto.UseVisualStyleBackColor = true;
            // 
            // rdbExistencia
            // 
            this.rdbExistencia.AutoSize = true;
            this.rdbExistencia.Location = new System.Drawing.Point(426, 22);
            this.rdbExistencia.Name = "rdbExistencia";
            this.rdbExistencia.Size = new System.Drawing.Size(119, 29);
            this.rdbExistencia.TabIndex = 78;
            this.rdbExistencia.TabStop = true;
            this.rdbExistencia.Text = "Existencia";
            this.rdbExistencia.UseVisualStyleBackColor = true;
            // 
            // rdbPrecio
            // 
            this.rdbPrecio.AutoSize = true;
            this.rdbPrecio.Location = new System.Drawing.Point(125, 22);
            this.rdbPrecio.Name = "rdbPrecio";
            this.rdbPrecio.Size = new System.Drawing.Size(85, 29);
            this.rdbPrecio.TabIndex = 77;
            this.rdbPrecio.TabStop = true;
            this.rdbPrecio.Text = "Precio";
            this.rdbPrecio.UseVisualStyleBackColor = true;
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Location = new System.Drawing.Point(6, 22);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(99, 29);
            this.rdbNombre.TabIndex = 76;
            this.rdbNombre.TabStop = true;
            this.rdbNombre.Text = "Nombre";
            this.rdbNombre.UseVisualStyleBackColor = true;
            // 
            // btnBuscarExistencia
            // 
            this.btnBuscarExistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarExistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBuscarExistencia.FlatAppearance.BorderSize = 0;
            this.btnBuscarExistencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.btnBuscarExistencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnBuscarExistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarExistencia.ForeColor = System.Drawing.Color.White;
            this.btnBuscarExistencia.Location = new System.Drawing.Point(393, 113);
            this.btnBuscarExistencia.Name = "btnBuscarExistencia";
            this.btnBuscarExistencia.Size = new System.Drawing.Size(151, 26);
            this.btnBuscarExistencia.TabIndex = 99;
            this.btnBuscarExistencia.Text = "Buscar ";
            this.btnBuscarExistencia.UseVisualStyleBackColor = false;
            this.btnBuscarExistencia.Visible = false;
            // 
            // btnVerProductos
            // 
            this.btnVerProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnVerProductos.FlatAppearance.BorderSize = 0;
            this.btnVerProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btnVerProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnVerProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerProductos.ForeColor = System.Drawing.Color.White;
            this.btnVerProductos.Location = new System.Drawing.Point(878, 535);
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Size = new System.Drawing.Size(166, 31);
            this.btnVerProductos.TabIndex = 76;
            this.btnVerProductos.Text = "Ver Productos";
            this.btnVerProductos.UseVisualStyleBackColor = false;
            this.btnVerProductos.Click += new System.EventHandler(this.btnVerProductos_Click);
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
            this.paneFechaHora.TabIndex = 64;
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
            // tmrHoraFecha
            // 
            this.tmrHoraFecha.Enabled = true;
            this.tmrHoraFecha.Tick += new System.EventHandler(this.tmrHoraFecha_Tick);
            // 
            // erpProductos
            // 
            this.erpProductos.ContainerControl = this;
            // 
            // ptbProductos
            // 
            this.ptbProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbProductos.Image = global::Punto_Venta_Abarrotes.Properties.Resources.NomProductos;
            this.ptbProductos.Location = new System.Drawing.Point(412, 43);
            this.ptbProductos.Name = "ptbProductos";
            this.ptbProductos.Size = new System.Drawing.Size(327, 61);
            this.ptbProductos.TabIndex = 65;
            this.ptbProductos.TabStop = false;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.Location = new System.Drawing.Point(478, 322);
            this.dgvProductos.Name = "dgvProductos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.Size = new System.Drawing.Size(566, 207);
            this.dgvProductos.TabIndex = 77;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1056, 615);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnVerProductos);
            this.Controls.Add(this.ptbProductos);
            this.Controls.Add(this.paneFechaHora);
            this.Controls.Add(this.gpbProductos);
            this.Controls.Add(this.gpbRegistrarPuestos);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBorrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.gpbRegistrarPuestos.ResumeLayout(false);
            this.gpbRegistrarPuestos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistencia)).EndInit();
            this.gpbProductos.ResumeLayout(false);
            this.gpbProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistenciaBuscar)).EndInit();
            this.gpbBuscar.ResumeLayout(false);
            this.gpbBuscar.PerformLayout();
            this.paneFechaHora.ResumeLayout(false);
            this.paneFechaHora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbRegistrarPuestos;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox gpbProductos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Panel paneFechaHora;
        private System.Windows.Forms.Label lblMostrarHora;
        private System.Windows.Forms.Label lblMostrarFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer tmrHoraFecha;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.ToolTip tltBuscar;
        private System.Windows.Forms.Button btnVerProductos;
        private System.Windows.Forms.ErrorProvider erpProductos;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.PictureBox ptbProductos;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.DateTimePicker dtpFechaCaduci;
        private System.Windows.Forms.Label lblFechaCaduci;
        private System.Windows.Forms.NumericUpDown nudExistencia;
        private System.Windows.Forms.Label lblExistencia;
        private System.Windows.Forms.ComboBox cmbUnidad;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.Label lblContenidoNeto;
        private System.Windows.Forms.TextBox txtContenidoNeto;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.GroupBox gpbBuscar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.RadioButton rdbTipoProducto;
        private System.Windows.Forms.RadioButton rdbExistencia;
        private System.Windows.Forms.RadioButton rdbPrecio;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.ComboBox cmbTipoBuscar;
        private System.Windows.Forms.Label lblTipoBuscar;
        private System.Windows.Forms.NumericUpDown nudExistenciaBuscar;
        private System.Windows.Forms.Label lblExistenciaBuscar;
        private System.Windows.Forms.Label lblPrecioBuscar;
        private System.Windows.Forms.TextBox txtPrecioBuscar;
        private System.Windows.Forms.Label lblNomBuscar;
        private System.Windows.Forms.TextBox txtNombreBuscar;
        private System.Windows.Forms.Button btnBuscarTipo;
        private System.Windows.Forms.Button btnCambiarModoBusqueda;
        private System.Windows.Forms.Button btnBuscarExistencia;
        private System.Windows.Forms.Button btnBuscarPrecio;
        private System.Windows.Forms.Button btnBuscarNombre;
        private System.Windows.Forms.DataGridView dgvProductos;
    }
}