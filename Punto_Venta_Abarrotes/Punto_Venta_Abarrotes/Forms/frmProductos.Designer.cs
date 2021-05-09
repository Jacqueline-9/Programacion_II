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
            this.gpbRegistrarPuestos = new System.Windows.Forms.GroupBox();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.lblEstatus = new System.Windows.Forms.Label();
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnVerProductos = new System.Windows.Forms.Button();
            this.cmbTipoBuscar = new System.Windows.Forms.ComboBox();
            this.lblTipoBuscar = new System.Windows.Forms.Label();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.nudExistenciaBuscar = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrecioBuscar = new System.Windows.Forms.Label();
            this.txtPrecioBuscar = new System.Windows.Forms.TextBox();
            this.lblNomBuscar = new System.Windows.Forms.Label();
            this.txtNombreBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.paneFechaHora = new System.Windows.Forms.Panel();
            this.lblMostrarHora = new System.Windows.Forms.Label();
            this.lblMostrarFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.tmrHoraFecha = new System.Windows.Forms.Timer(this.components);
            this.tltBuscar = new System.Windows.Forms.ToolTip(this.components);
            this.erpProductos = new System.Windows.Forms.ErrorProvider(this.components);
            this.ptbProductos = new System.Windows.Forms.PictureBox();
            this.gpbRegistrarPuestos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistencia)).BeginInit();
            this.gpbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistenciaBuscar)).BeginInit();
            this.paneFechaHora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbRegistrarPuestos
            // 
            this.gpbRegistrarPuestos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gpbRegistrarPuestos.Controls.Add(this.txtEstatus);
            this.gpbRegistrarPuestos.Controls.Add(this.lblEstatus);
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
            // txtEstatus
            // 
            this.txtEstatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstatus.Location = new System.Drawing.Point(255, 356);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(178, 23);
            this.txtEstatus.TabIndex = 35;
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatus.ForeColor = System.Drawing.Color.White;
            this.lblEstatus.Location = new System.Drawing.Point(18, 353);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(70, 24);
            this.lblEstatus.TabIndex = 34;
            this.lblEstatus.Text = "Estatus";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(255, 115);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(178, 23);
            this.txtDescripcion.TabIndex = 33;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(18, 115);
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
            this.dtpFechaCaduci.Location = new System.Drawing.Point(255, 318);
            this.dtpFechaCaduci.Name = "dtpFechaCaduci";
            this.dtpFechaCaduci.Size = new System.Drawing.Size(178, 26);
            this.dtpFechaCaduci.TabIndex = 30;
            // 
            // lblFechaCaduci
            // 
            this.lblFechaCaduci.AutoSize = true;
            this.lblFechaCaduci.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCaduci.ForeColor = System.Drawing.Color.White;
            this.lblFechaCaduci.Location = new System.Drawing.Point(18, 320);
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
            this.nudExistencia.Location = new System.Drawing.Point(255, 277);
            this.nudExistencia.Name = "nudExistencia";
            this.nudExistencia.Size = new System.Drawing.Size(178, 26);
            this.nudExistencia.TabIndex = 28;
            // 
            // lblExistencia
            // 
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistencia.ForeColor = System.Drawing.Color.White;
            this.lblExistencia.Location = new System.Drawing.Point(18, 279);
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
            this.cmbUnidad.Location = new System.Drawing.Point(255, 236);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(178, 24);
            this.cmbUnidad.TabIndex = 26;
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.ForeColor = System.Drawing.Color.White;
            this.lblUnidad.Location = new System.Drawing.Point(18, 236);
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
            this.lblContenidoNeto.Location = new System.Drawing.Point(18, 195);
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
            this.txtContenidoNeto.Location = new System.Drawing.Point(255, 195);
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
            this.lblPrecio.Location = new System.Drawing.Point(18, 154);
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
            this.txtPrecio.Location = new System.Drawing.Point(255, 154);
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
            this.lblNombre.Location = new System.Drawing.Point(18, 77);
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
            this.cmbTipo.Location = new System.Drawing.Point(255, 39);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(178, 24);
            this.cmbTipo.TabIndex = 19;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(255, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(178, 23);
            this.txtNombre.TabIndex = 18;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(18, 39);
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
            this.btnBorrar.Location = new System.Drawing.Point(191, 355);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(118, 31);
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
            this.btnActualizar.Location = new System.Drawing.Point(17, 355);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(118, 31);
            this.btnActualizar.TabIndex = 65;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // gpbProductos
            // 
            this.gpbProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbProductos.Controls.Add(this.dgvProductos);
            this.gpbProductos.Controls.Add(this.btnVerProductos);
            this.gpbProductos.Controls.Add(this.cmbTipoBuscar);
            this.gpbProductos.Controls.Add(this.lblTipoBuscar);
            this.gpbProductos.Controls.Add(this.lblBuscarPor);
            this.gpbProductos.Controls.Add(this.nudExistenciaBuscar);
            this.gpbProductos.Controls.Add(this.label1);
            this.gpbProductos.Controls.Add(this.lblPrecioBuscar);
            this.gpbProductos.Controls.Add(this.txtPrecioBuscar);
            this.gpbProductos.Controls.Add(this.lblNomBuscar);
            this.gpbProductos.Controls.Add(this.txtNombreBuscar);
            this.gpbProductos.Controls.Add(this.btnBorrar);
            this.gpbProductos.Controls.Add(this.btnActualizar);
            this.gpbProductos.Controls.Add(this.btnBuscar);
            this.gpbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbProductos.ForeColor = System.Drawing.Color.White;
            this.gpbProductos.Location = new System.Drawing.Point(498, 145);
            this.gpbProductos.Name = "gpbProductos";
            this.gpbProductos.Size = new System.Drawing.Size(570, 407);
            this.gpbProductos.TabIndex = 63;
            this.gpbProductos.TabStop = false;
            this.gpbProductos.Text = "Productos";
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(17, 174);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(526, 150);
            this.dgvProductos.TabIndex = 77;
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
            this.btnVerProductos.Location = new System.Drawing.Point(353, 355);
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Size = new System.Drawing.Size(190, 31);
            this.btnVerProductos.TabIndex = 76;
            this.btnVerProductos.Text = "Ver Productos";
            this.btnVerProductos.UseVisualStyleBackColor = false;
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
            this.cmbTipoBuscar.Location = new System.Drawing.Point(131, 110);
            this.cmbTipoBuscar.Name = "cmbTipoBuscar";
            this.cmbTipoBuscar.Size = new System.Drawing.Size(178, 23);
            this.cmbTipoBuscar.TabIndex = 75;
            // 
            // lblTipoBuscar
            // 
            this.lblTipoBuscar.AutoSize = true;
            this.lblTipoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoBuscar.ForeColor = System.Drawing.Color.White;
            this.lblTipoBuscar.Location = new System.Drawing.Point(14, 114);
            this.lblTipoBuscar.Name = "lblTipoBuscar";
            this.lblTipoBuscar.Size = new System.Drawing.Size(111, 16);
            this.lblTipoBuscar.TabIndex = 74;
            this.lblTipoBuscar.Text = "Tipo de producto";
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
            // nudExistenciaBuscar
            // 
            this.nudExistenciaBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudExistenciaBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudExistenciaBuscar.Location = new System.Drawing.Point(482, 64);
            this.nudExistenciaBuscar.Name = "nudExistenciaBuscar";
            this.nudExistenciaBuscar.Size = new System.Drawing.Size(61, 22);
            this.nudExistenciaBuscar.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(394, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 70;
            this.label1.Text = "Existencia";
            // 
            // lblPrecioBuscar
            // 
            this.lblPrecioBuscar.AutoSize = true;
            this.lblPrecioBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioBuscar.ForeColor = System.Drawing.Color.White;
            this.lblPrecioBuscar.Location = new System.Drawing.Point(209, 67);
            this.lblPrecioBuscar.Name = "lblPrecioBuscar";
            this.lblPrecioBuscar.Size = new System.Drawing.Size(47, 16);
            this.lblPrecioBuscar.TabIndex = 69;
            this.lblPrecioBuscar.Text = "Precio";
            // 
            // txtPrecioBuscar
            // 
            this.txtPrecioBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioBuscar.Location = new System.Drawing.Point(262, 64);
            this.txtPrecioBuscar.Name = "txtPrecioBuscar";
            this.txtPrecioBuscar.Size = new System.Drawing.Size(103, 22);
            this.txtPrecioBuscar.TabIndex = 68;
            this.txtPrecioBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioBuscar_KeyPress);
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
            this.txtNombreBuscar.Size = new System.Drawing.Size(103, 22);
            this.txtNombreBuscar.TabIndex = 66;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(388, 133);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(155, 26);
            this.btnBuscar.TabIndex = 62;
            this.btnBuscar.Text = "Buscar ";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.ptbProductos.Size = new System.Drawing.Size(351, 61);
            this.ptbProductos.TabIndex = 65;
            this.ptbProductos.TabStop = false;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1080, 615);
            this.Controls.Add(this.ptbProductos);
            this.Controls.Add(this.paneFechaHora);
            this.Controls.Add(this.gpbProductos);
            this.Controls.Add(this.gpbRegistrarPuestos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.gpbRegistrarPuestos.ResumeLayout(false);
            this.gpbRegistrarPuestos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistencia)).EndInit();
            this.gpbProductos.ResumeLayout(false);
            this.gpbProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistenciaBuscar)).EndInit();
            this.paneFechaHora.ResumeLayout(false);
            this.paneFechaHora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProductos)).EndInit();
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
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.NumericUpDown nudExistenciaBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrecioBuscar;
        private System.Windows.Forms.TextBox txtPrecioBuscar;
        private System.Windows.Forms.Label lblNomBuscar;
        private System.Windows.Forms.TextBox txtNombreBuscar;
        private System.Windows.Forms.Panel paneFechaHora;
        private System.Windows.Forms.Label lblMostrarHora;
        private System.Windows.Forms.Label lblMostrarFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer tmrHoraFecha;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.ToolTip tltBuscar;
        private System.Windows.Forms.ComboBox cmbTipoBuscar;
        private System.Windows.Forms.Label lblTipoBuscar;
        private System.Windows.Forms.Button btnVerProductos;
        private System.Windows.Forms.ErrorProvider erpProductos;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.PictureBox ptbProductos;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.Label lblEstatus;
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
    }
}