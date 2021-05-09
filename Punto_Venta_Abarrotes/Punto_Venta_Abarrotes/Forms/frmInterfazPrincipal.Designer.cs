namespace Punto_Venta_Abarrotes
{
    partial class frmInterfazPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInterfazPrincipal));
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelSubmenuRepor = new System.Windows.Forms.Panel();
            this.brnReportesVentas = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnPerdidas = new System.Windows.Forms.Button();
            this.ibtnDomicilio = new FontAwesome.Sharp.IconButton();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnPuestosHoararios = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.ptbRestaurar = new System.Windows.Forms.PictureBox();
            this.ptbCerrar = new System.Windows.Forms.PictureBox();
            this.ptbMinimizar = new System.Windows.Forms.PictureBox();
            this.ptbMaximizar = new System.Windows.Forms.PictureBox();
            this.panelBarraTitulo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelSubmenuRepor.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.panelBarraTitulo.Controls.Add(this.ptbRestaurar);
            this.panelBarraTitulo.Controls.Add(this.ptbCerrar);
            this.panelBarraTitulo.Controls.Add(this.ptbMinimizar);
            this.panelBarraTitulo.Controls.Add(this.ptbMaximizar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1300, 35);
            this.panelBarraTitulo.TabIndex = 0;
            this.panelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseDown);
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelMenu.Controls.Add(this.panelSubmenuRepor);
            this.panelMenu.Controls.Add(this.btnReportes);
            this.panelMenu.Controls.Add(this.btnPerdidas);
            this.panelMenu.Controls.Add(this.ibtnDomicilio);
            this.panelMenu.Controls.Add(this.btnUsuario);
            this.panelMenu.Controls.Add(this.btnPuestosHoararios);
            this.panelMenu.Controls.Add(this.btnCompras);
            this.panelMenu.Controls.Add(this.btnProveedores);
            this.panelMenu.Controls.Add(this.btnVentas);
            this.panelMenu.Controls.Add(this.btnEmpleados);
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Controls.Add(this.btnProductos);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 35);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(244, 615);
            this.panelMenu.TabIndex = 1;
            // 
            // panelSubmenuRepor
            // 
            this.panelSubmenuRepor.Controls.Add(this.brnReportesVentas);
            this.panelSubmenuRepor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenuRepor.Location = new System.Drawing.Point(0, 585);
            this.panelSubmenuRepor.Name = "panelSubmenuRepor";
            this.panelSubmenuRepor.Size = new System.Drawing.Size(227, 53);
            this.panelSubmenuRepor.TabIndex = 61;
            // 
            // brnReportesVentas
            // 
            this.brnReportesVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.brnReportesVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.brnReportesVentas.FlatAppearance.BorderSize = 0;
            this.brnReportesVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnReportesVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnReportesVentas.ForeColor = System.Drawing.Color.LightGray;
            this.brnReportesVentas.Location = new System.Drawing.Point(0, 0);
            this.brnReportesVentas.Name = "brnReportesVentas";
            this.brnReportesVentas.Padding = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.brnReportesVentas.Size = new System.Drawing.Size(227, 44);
            this.brnReportesVentas.TabIndex = 3;
            this.brnReportesVentas.Text = "Reporte Ventas";
            this.brnReportesVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnReportesVentas.UseVisualStyleBackColor = false;
            this.brnReportesVentas.Click += new System.EventHandler(this.brnReportesVentas_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.ptbLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(227, 93);
            this.panelLogo.TabIndex = 0;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(244, 35);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1056, 615);
            this.panelContenedor.TabIndex = 2;
            // 
            // btnReportes
            // 
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 540);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(227, 45);
            this.btnReportes.TabIndex = 60;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnPerdidas
            // 
            this.btnPerdidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerdidas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerdidas.FlatAppearance.BorderSize = 0;
            this.btnPerdidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerdidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerdidas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPerdidas.Image = global::Punto_Venta_Abarrotes.Properties.Resources.perdida__1_;
            this.btnPerdidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerdidas.Location = new System.Drawing.Point(0, 496);
            this.btnPerdidas.Name = "btnPerdidas";
            this.btnPerdidas.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnPerdidas.Size = new System.Drawing.Size(227, 44);
            this.btnPerdidas.TabIndex = 59;
            this.btnPerdidas.Text = "Perdidas";
            this.btnPerdidas.UseVisualStyleBackColor = true;
            this.btnPerdidas.Click += new System.EventHandler(this.btnPerdidas_Click);
            // 
            // ibtnDomicilio
            // 
            this.ibtnDomicilio.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnDomicilio.FlatAppearance.BorderSize = 0;
            this.ibtnDomicilio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnDomicilio.ForeColor = System.Drawing.Color.White;
            this.ibtnDomicilio.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.ibtnDomicilio.IconColor = System.Drawing.Color.White;
            this.ibtnDomicilio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnDomicilio.IconSize = 45;
            this.ibtnDomicilio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnDomicilio.Location = new System.Drawing.Point(0, 451);
            this.ibtnDomicilio.Name = "ibtnDomicilio";
            this.ibtnDomicilio.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.ibtnDomicilio.Size = new System.Drawing.Size(227, 45);
            this.ibtnDomicilio.TabIndex = 58;
            this.ibtnDomicilio.Text = "Domicilio";
            this.ibtnDomicilio.UseVisualStyleBackColor = true;
            this.ibtnDomicilio.Click += new System.EventHandler(this.ibtnDomicilio_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUsuario.Image = global::Punto_Venta_Abarrotes.Properties.Resources.usuario;
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(0, 407);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnUsuario.Size = new System.Drawing.Size(227, 44);
            this.btnUsuario.TabIndex = 57;
            this.btnUsuario.Text = "Usuarios";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnPuestosHoararios
            // 
            this.btnPuestosHoararios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPuestosHoararios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPuestosHoararios.FlatAppearance.BorderSize = 0;
            this.btnPuestosHoararios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPuestosHoararios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuestosHoararios.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPuestosHoararios.Image = global::Punto_Venta_Abarrotes.Properties.Resources.estacion_de_trabajo;
            this.btnPuestosHoararios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPuestosHoararios.Location = new System.Drawing.Point(0, 363);
            this.btnPuestosHoararios.Name = "btnPuestosHoararios";
            this.btnPuestosHoararios.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnPuestosHoararios.Size = new System.Drawing.Size(227, 44);
            this.btnPuestosHoararios.TabIndex = 56;
            this.btnPuestosHoararios.Text = "Puestos";
            this.btnPuestosHoararios.UseVisualStyleBackColor = true;
            this.btnPuestosHoararios.Click += new System.EventHandler(this.btnPuestosHoararios_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCompras.Image = ((System.Drawing.Image)(resources.GetObject("btnCompras.Image")));
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.Location = new System.Drawing.Point(0, 318);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnCompras.Size = new System.Drawing.Size(227, 45);
            this.btnCompras.TabIndex = 55;
            this.btnCompras.Text = "Compras";
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedores.Image")));
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(0, 273);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnProveedores.Size = new System.Drawing.Size(227, 45);
            this.btnProveedores.TabIndex = 54;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 228);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnVentas.Size = new System.Drawing.Size(227, 45);
            this.btnVentas.TabIndex = 53;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Image")));
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 183);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnEmpleados.Size = new System.Drawing.Size(227, 45);
            this.btnEmpleados.TabIndex = 52;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 138);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(227, 45);
            this.btnClientes.TabIndex = 51;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(0, 93);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnProductos.Size = new System.Drawing.Size(227, 45);
            this.btnProductos.TabIndex = 50;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = global::Punto_Venta_Abarrotes.Properties.Resources._4891328874_8fa2d91b_78f1_4a00_8da8_33624cb14079;
            this.ptbLogo.Location = new System.Drawing.Point(22, 22);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(202, 56);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogo.TabIndex = 0;
            this.ptbLogo.TabStop = false;
            this.ptbLogo.Click += new System.EventHandler(this.ptbLogo_Click);
            // 
            // ptbRestaurar
            // 
            this.ptbRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("ptbRestaurar.Image")));
            this.ptbRestaurar.Location = new System.Drawing.Point(1232, 4);
            this.ptbRestaurar.Name = "ptbRestaurar";
            this.ptbRestaurar.Size = new System.Drawing.Size(25, 25);
            this.ptbRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbRestaurar.TabIndex = 7;
            this.ptbRestaurar.TabStop = false;
            this.ptbRestaurar.Visible = false;
            this.ptbRestaurar.Click += new System.EventHandler(this.ptbRestaurar_Click);
            // 
            // ptbCerrar
            // 
            this.ptbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("ptbCerrar.Image")));
            this.ptbCerrar.Location = new System.Drawing.Point(1263, 4);
            this.ptbCerrar.Name = "ptbCerrar";
            this.ptbCerrar.Size = new System.Drawing.Size(25, 25);
            this.ptbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCerrar.TabIndex = 4;
            this.ptbCerrar.TabStop = false;
            this.ptbCerrar.Click += new System.EventHandler(this.ptbCerrar_Click);
            // 
            // ptbMinimizar
            // 
            this.ptbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("ptbMinimizar.Image")));
            this.ptbMinimizar.Location = new System.Drawing.Point(1201, 4);
            this.ptbMinimizar.Name = "ptbMinimizar";
            this.ptbMinimizar.Size = new System.Drawing.Size(25, 25);
            this.ptbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMinimizar.TabIndex = 6;
            this.ptbMinimizar.TabStop = false;
            this.ptbMinimizar.Click += new System.EventHandler(this.ptbMinimizar_Click);
            // 
            // ptbMaximizar
            // 
            this.ptbMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("ptbMaximizar.Image")));
            this.ptbMaximizar.Location = new System.Drawing.Point(1232, 4);
            this.ptbMaximizar.Name = "ptbMaximizar";
            this.ptbMaximizar.Size = new System.Drawing.Size(25, 25);
            this.ptbMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMaximizar.TabIndex = 5;
            this.ptbMaximizar.TabStop = false;
            this.ptbMaximizar.Click += new System.EventHandler(this.ptbMaximizar_Click);
            // 
            // frmInterfazPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInterfazPrincipal";
            this.Text = "InterfazPrincipal";
            this.Load += new System.EventHandler(this.InterfazPrincipal_Load);
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelSubmenuRepor.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.PictureBox ptbRestaurar;
        private System.Windows.Forms.PictureBox ptbCerrar;
        private System.Windows.Forms.PictureBox ptbMinimizar;
        private System.Windows.Forms.PictureBox ptbMaximizar;
        private FontAwesome.Sharp.IconButton ibtnDomicilio;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnPuestosHoararios;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnPerdidas;
        private System.Windows.Forms.Panel panelSubmenuRepor;
        private System.Windows.Forms.Button brnReportesVentas;
        private System.Windows.Forms.Button btnReportes;
    }
}