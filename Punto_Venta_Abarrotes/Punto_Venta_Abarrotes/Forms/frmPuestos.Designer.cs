namespace Punto_Venta_Abarrotes
{
    partial class frmPuestos
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
            this.gpbTurnos = new System.Windows.Forms.GroupBox();
            this.gpbBuscarTurnos = new System.Windows.Forms.GroupBox();
            this.btnVerTurnos = new System.Windows.Forms.Button();
            this.btnTurnoBuscar = new System.Windows.Forms.Button();
            this.btnBorarTurno = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnActualizarTurno = new System.Windows.Forms.Button();
            this.lblNombreTurnoBuscar = new System.Windows.Forms.Label();
            this.txtNombreTurnoBuscar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gpbRegistrarTurnos = new System.Windows.Forms.GroupBox();
            this.lblDescripcionTurno = new System.Windows.Forms.Label();
            this.txtDescripción = new System.Windows.Forms.TextBox();
            this.dtpDia = new System.Windows.Forms.DateTimePicker();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblEstatusTurno = new System.Windows.Forms.Label();
            this.dtpHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrarTurno = new System.Windows.Forms.Button();
            this.lblHoraSalida = new System.Windows.Forms.Label();
            this.lblNombreTurno = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.txtEstatusTurno = new System.Windows.Forms.TextBox();
            this.lblHoraEntrada = new System.Windows.Forms.Label();
            this.ptbPuestos = new System.Windows.Forms.PictureBox();
            this.gpbPuesto = new System.Windows.Forms.GroupBox();
            this.gpbBuscarPuestos = new System.Windows.Forms.GroupBox();
            this.btnVerPuestos = new System.Windows.Forms.Button();
            this.btnBuscarPuestos = new System.Windows.Forms.Button();
            this.btnBorrarPuestos = new System.Windows.Forms.Button();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.btnActualizarPuestos = new System.Windows.Forms.Button();
            this.lblNomBuscar = new System.Windows.Forms.Label();
            this.txtNombrePuestoBuscar = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.gpbRegistrarPuesto = new System.Windows.Forms.GroupBox();
            this.txtEstatusPuesto = new System.Windows.Forms.TextBox();
            this.lblEstatusPuesto = new System.Windows.Forms.Label();
            this.btnRegistrarPuestos = new System.Windows.Forms.Button();
            this.txtDescripcionTurno = new System.Windows.Forms.TextBox();
            this.lblDescripcionPuesto = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.cmbPuestos = new System.Windows.Forms.ComboBox();
            this.paneFechaHora = new System.Windows.Forms.Panel();
            this.lblMostrarHora = new System.Windows.Forms.Label();
            this.lblMostrarFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.tmrFechaHora = new System.Windows.Forms.Timer(this.components);
            this.erpPuestosTurnos = new System.Windows.Forms.ErrorProvider(this.components);
            this.tltBuscar = new System.Windows.Forms.ToolTip(this.components);
            this.gpbTurnos.SuspendLayout();
            this.gpbBuscarTurnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpbRegistrarTurnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPuestos)).BeginInit();
            this.gpbPuesto.SuspendLayout();
            this.gpbBuscarPuestos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.gpbRegistrarPuesto.SuspendLayout();
            this.paneFechaHora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpPuestosTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbTurnos
            // 
            this.gpbTurnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbTurnos.Controls.Add(this.gpbBuscarTurnos);
            this.gpbTurnos.Controls.Add(this.gpbRegistrarTurnos);
            this.gpbTurnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTurnos.ForeColor = System.Drawing.Color.White;
            this.gpbTurnos.Location = new System.Drawing.Point(12, 313);
            this.gpbTurnos.Name = "gpbTurnos";
            this.gpbTurnos.Size = new System.Drawing.Size(1056, 253);
            this.gpbTurnos.TabIndex = 70;
            this.gpbTurnos.TabStop = false;
            this.gpbTurnos.Text = "Turnos";
            // 
            // gpbBuscarTurnos
            // 
            this.gpbBuscarTurnos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbBuscarTurnos.Controls.Add(this.btnVerTurnos);
            this.gpbBuscarTurnos.Controls.Add(this.btnTurnoBuscar);
            this.gpbBuscarTurnos.Controls.Add(this.btnBorarTurno);
            this.gpbBuscarTurnos.Controls.Add(this.lblBuscar);
            this.gpbBuscarTurnos.Controls.Add(this.btnActualizarTurno);
            this.gpbBuscarTurnos.Controls.Add(this.lblNombreTurnoBuscar);
            this.gpbBuscarTurnos.Controls.Add(this.txtNombreTurnoBuscar);
            this.gpbBuscarTurnos.Controls.Add(this.dataGridView1);
            this.gpbBuscarTurnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBuscarTurnos.ForeColor = System.Drawing.Color.White;
            this.gpbBuscarTurnos.Location = new System.Drawing.Point(415, 25);
            this.gpbBuscarTurnos.Name = "gpbBuscarTurnos";
            this.gpbBuscarTurnos.Size = new System.Drawing.Size(624, 215);
            this.gpbBuscarTurnos.TabIndex = 79;
            this.gpbBuscarTurnos.TabStop = false;
            this.gpbBuscarTurnos.Text = "Buscar Turnos";
            // 
            // btnVerTurnos
            // 
            this.btnVerTurnos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerTurnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnVerTurnos.FlatAppearance.BorderSize = 0;
            this.btnVerTurnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btnVerTurnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnVerTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTurnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTurnos.ForeColor = System.Drawing.Color.White;
            this.btnVerTurnos.Location = new System.Drawing.Point(503, 176);
            this.btnVerTurnos.Name = "btnVerTurnos";
            this.btnVerTurnos.Size = new System.Drawing.Size(115, 31);
            this.btnVerTurnos.TabIndex = 86;
            this.btnVerTurnos.Text = "Ver Turnos";
            this.btnVerTurnos.UseVisualStyleBackColor = false;
            // 
            // btnTurnoBuscar
            // 
            this.btnTurnoBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnTurnoBuscar.FlatAppearance.BorderSize = 0;
            this.btnTurnoBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.btnTurnoBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnTurnoBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurnoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnoBuscar.ForeColor = System.Drawing.Color.White;
            this.btnTurnoBuscar.Location = new System.Drawing.Point(64, 119);
            this.btnTurnoBuscar.Name = "btnTurnoBuscar";
            this.btnTurnoBuscar.Size = new System.Drawing.Size(106, 26);
            this.btnTurnoBuscar.TabIndex = 90;
            this.btnTurnoBuscar.Text = "Buscar ";
            this.btnTurnoBuscar.UseVisualStyleBackColor = false;
            this.btnTurnoBuscar.Click += new System.EventHandler(this.btnTurnoBuscar_Click);
            // 
            // btnBorarTurno
            // 
            this.btnBorarTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorarTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBorarTurno.FlatAppearance.BorderSize = 0;
            this.btnBorarTurno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBorarTurno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnBorarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorarTurno.ForeColor = System.Drawing.Color.White;
            this.btnBorarTurno.Location = new System.Drawing.Point(509, 106);
            this.btnBorarTurno.Name = "btnBorarTurno";
            this.btnBorarTurno.Size = new System.Drawing.Size(109, 31);
            this.btnBorarTurno.TabIndex = 83;
            this.btnBorarTurno.Text = "Borrar";
            this.btnBorarTurno.UseVisualStyleBackColor = false;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(15, 34);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(76, 16);
            this.lblBuscar.TabIndex = 89;
            this.lblBuscar.Text = "Buscar por:";
            // 
            // btnActualizarTurno
            // 
            this.btnActualizarTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnActualizarTurno.FlatAppearance.BorderSize = 0;
            this.btnActualizarTurno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnActualizarTurno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnActualizarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarTurno.ForeColor = System.Drawing.Color.White;
            this.btnActualizarTurno.Location = new System.Drawing.Point(509, 26);
            this.btnActualizarTurno.Name = "btnActualizarTurno";
            this.btnActualizarTurno.Size = new System.Drawing.Size(109, 31);
            this.btnActualizarTurno.TabIndex = 84;
            this.btnActualizarTurno.Text = "Actualizar";
            this.btnActualizarTurno.UseVisualStyleBackColor = false;
            // 
            // lblNombreTurnoBuscar
            // 
            this.lblNombreTurnoBuscar.AutoSize = true;
            this.lblNombreTurnoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTurnoBuscar.ForeColor = System.Drawing.Color.White;
            this.lblNombreTurnoBuscar.Location = new System.Drawing.Point(15, 74);
            this.lblNombreTurnoBuscar.Name = "lblNombreTurnoBuscar";
            this.lblNombreTurnoBuscar.Size = new System.Drawing.Size(57, 16);
            this.lblNombreTurnoBuscar.TabIndex = 88;
            this.lblNombreTurnoBuscar.Text = "Nombre";
            // 
            // txtNombreTurnoBuscar
            // 
            this.txtNombreTurnoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreTurnoBuscar.Location = new System.Drawing.Point(78, 71);
            this.txtNombreTurnoBuscar.Name = "txtNombreTurnoBuscar";
            this.txtNombreTurnoBuscar.Size = new System.Drawing.Size(121, 22);
            this.txtNombreTurnoBuscar.TabIndex = 87;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(213, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(284, 182);
            this.dataGridView1.TabIndex = 85;
            // 
            // gpbRegistrarTurnos
            // 
            this.gpbRegistrarTurnos.Controls.Add(this.lblDescripcionTurno);
            this.gpbRegistrarTurnos.Controls.Add(this.txtDescripción);
            this.gpbRegistrarTurnos.Controls.Add(this.dtpDia);
            this.gpbRegistrarTurnos.Controls.Add(this.lblDia);
            this.gpbRegistrarTurnos.Controls.Add(this.lblEstatusTurno);
            this.gpbRegistrarTurnos.Controls.Add(this.dtpHoraSalida);
            this.gpbRegistrarTurnos.Controls.Add(this.dtpHoraEntrada);
            this.gpbRegistrarTurnos.Controls.Add(this.btnRegistrarTurno);
            this.gpbRegistrarTurnos.Controls.Add(this.lblHoraSalida);
            this.gpbRegistrarTurnos.Controls.Add(this.lblNombreTurno);
            this.gpbRegistrarTurnos.Controls.Add(this.cmbTurno);
            this.gpbRegistrarTurnos.Controls.Add(this.txtEstatusTurno);
            this.gpbRegistrarTurnos.Controls.Add(this.lblHoraEntrada);
            this.gpbRegistrarTurnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbRegistrarTurnos.ForeColor = System.Drawing.Color.White;
            this.gpbRegistrarTurnos.Location = new System.Drawing.Point(6, 25);
            this.gpbRegistrarTurnos.Name = "gpbRegistrarTurnos";
            this.gpbRegistrarTurnos.Size = new System.Drawing.Size(403, 215);
            this.gpbRegistrarTurnos.TabIndex = 0;
            this.gpbRegistrarTurnos.TabStop = false;
            this.gpbRegistrarTurnos.Text = "Registrar Turnos";
            // 
            // lblDescripcionTurno
            // 
            this.lblDescripcionTurno.AutoSize = true;
            this.lblDescripcionTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionTurno.ForeColor = System.Drawing.Color.White;
            this.lblDescripcionTurno.Location = new System.Drawing.Point(15, 177);
            this.lblDescripcionTurno.Name = "lblDescripcionTurno";
            this.lblDescripcionTurno.Size = new System.Drawing.Size(87, 18);
            this.lblDescripcionTurno.TabIndex = 74;
            this.lblDescripcionTurno.Text = "Descripción";
            // 
            // txtDescripción
            // 
            this.txtDescripción.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripción.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripción.Location = new System.Drawing.Point(155, 176);
            this.txtDescripción.Name = "txtDescripción";
            this.txtDescripción.Size = new System.Drawing.Size(118, 23);
            this.txtDescripción.TabIndex = 73;
            // 
            // dtpDia
            // 
            this.dtpDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDia.Location = new System.Drawing.Point(155, 116);
            this.dtpDia.Name = "dtpDia";
            this.dtpDia.Size = new System.Drawing.Size(118, 23);
            this.dtpDia.TabIndex = 72;
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.ForeColor = System.Drawing.Color.White;
            this.lblDia.Location = new System.Drawing.Point(15, 119);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(103, 18);
            this.lblDia.TabIndex = 71;
            this.lblDia.Text = "Hora de salida";
            // 
            // lblEstatusTurno
            // 
            this.lblEstatusTurno.AutoSize = true;
            this.lblEstatusTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatusTurno.ForeColor = System.Drawing.Color.White;
            this.lblEstatusTurno.Location = new System.Drawing.Point(15, 146);
            this.lblEstatusTurno.Name = "lblEstatusTurno";
            this.lblEstatusTurno.Size = new System.Drawing.Size(58, 18);
            this.lblEstatusTurno.TabIndex = 70;
            this.lblEstatusTurno.Text = "Estatus";
            // 
            // dtpHoraSalida
            // 
            this.dtpHoraSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraSalida.Location = new System.Drawing.Point(155, 87);
            this.dtpHoraSalida.Name = "dtpHoraSalida";
            this.dtpHoraSalida.Size = new System.Drawing.Size(118, 23);
            this.dtpHoraSalida.TabIndex = 69;
            // 
            // dtpHoraEntrada
            // 
            this.dtpHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraEntrada.Location = new System.Drawing.Point(155, 56);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.Size = new System.Drawing.Size(118, 23);
            this.dtpHoraEntrada.TabIndex = 68;
            // 
            // btnRegistrarTurno
            // 
            this.btnRegistrarTurno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRegistrarTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRegistrarTurno.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegistrarTurno.FlatAppearance.BorderSize = 0;
            this.btnRegistrarTurno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRegistrarTurno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnRegistrarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarTurno.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarTurno.Location = new System.Drawing.Point(279, 90);
            this.btnRegistrarTurno.Name = "btnRegistrarTurno";
            this.btnRegistrarTurno.Size = new System.Drawing.Size(119, 31);
            this.btnRegistrarTurno.TabIndex = 31;
            this.btnRegistrarTurno.Text = "Registrar";
            this.btnRegistrarTurno.UseVisualStyleBackColor = false;
            this.btnRegistrarTurno.Click += new System.EventHandler(this.btnRegistrarTurno_Click);
            // 
            // lblHoraSalida
            // 
            this.lblHoraSalida.AutoSize = true;
            this.lblHoraSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraSalida.ForeColor = System.Drawing.Color.White;
            this.lblHoraSalida.Location = new System.Drawing.Point(15, 90);
            this.lblHoraSalida.Name = "lblHoraSalida";
            this.lblHoraSalida.Size = new System.Drawing.Size(103, 18);
            this.lblHoraSalida.TabIndex = 32;
            this.lblHoraSalida.Text = "Hora de salida";
            // 
            // lblNombreTurno
            // 
            this.lblNombreTurno.AutoSize = true;
            this.lblNombreTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTurno.ForeColor = System.Drawing.Color.White;
            this.lblNombreTurno.Location = new System.Drawing.Point(15, 25);
            this.lblNombreTurno.Name = "lblNombreTurno";
            this.lblNombreTurno.Size = new System.Drawing.Size(123, 18);
            this.lblNombreTurno.TabIndex = 20;
            this.lblNombreTurno.Text = "Nombre del turno";
            // 
            // cmbTurno
            // 
            this.cmbTurno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Completo"});
            this.cmbTurno.Location = new System.Drawing.Point(155, 22);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(118, 24);
            this.cmbTurno.TabIndex = 19;
            // 
            // txtEstatusTurno
            // 
            this.txtEstatusTurno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstatusTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstatusTurno.Location = new System.Drawing.Point(155, 145);
            this.txtEstatusTurno.Name = "txtEstatusTurno";
            this.txtEstatusTurno.Size = new System.Drawing.Size(118, 23);
            this.txtEstatusTurno.TabIndex = 18;
            // 
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.AutoSize = true;
            this.lblHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraEntrada.ForeColor = System.Drawing.Color.White;
            this.lblHoraEntrada.Location = new System.Drawing.Point(15, 59);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.Size = new System.Drawing.Size(114, 18);
            this.lblHoraEntrada.TabIndex = 22;
            this.lblHoraEntrada.Text = "Hora de entrada";
            // 
            // ptbPuestos
            // 
            this.ptbPuestos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbPuestos.Image = global::Punto_Venta_Abarrotes.Properties.Resources.ptbPuestos;
            this.ptbPuestos.Location = new System.Drawing.Point(449, 17);
            this.ptbPuestos.Name = "ptbPuestos";
            this.ptbPuestos.Size = new System.Drawing.Size(318, 75);
            this.ptbPuestos.TabIndex = 69;
            this.ptbPuestos.TabStop = false;
            // 
            // gpbPuesto
            // 
            this.gpbPuesto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbPuesto.Controls.Add(this.gpbBuscarPuestos);
            this.gpbPuesto.Controls.Add(this.gpbRegistrarPuesto);
            this.gpbPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPuesto.ForeColor = System.Drawing.Color.White;
            this.gpbPuesto.Location = new System.Drawing.Point(12, 88);
            this.gpbPuesto.Name = "gpbPuesto";
            this.gpbPuesto.Size = new System.Drawing.Size(1056, 214);
            this.gpbPuesto.TabIndex = 68;
            this.gpbPuesto.TabStop = false;
            this.gpbPuesto.Text = "Puestos";
            // 
            // gpbBuscarPuestos
            // 
            this.gpbBuscarPuestos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbBuscarPuestos.Controls.Add(this.btnVerPuestos);
            this.gpbBuscarPuestos.Controls.Add(this.btnBuscarPuestos);
            this.gpbBuscarPuestos.Controls.Add(this.btnBorrarPuestos);
            this.gpbBuscarPuestos.Controls.Add(this.lblBuscarPor);
            this.gpbBuscarPuestos.Controls.Add(this.btnActualizarPuestos);
            this.gpbBuscarPuestos.Controls.Add(this.lblNomBuscar);
            this.gpbBuscarPuestos.Controls.Add(this.txtNombrePuestoBuscar);
            this.gpbBuscarPuestos.Controls.Add(this.dgvProductos);
            this.gpbBuscarPuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBuscarPuestos.ForeColor = System.Drawing.Color.White;
            this.gpbBuscarPuestos.Location = new System.Drawing.Point(320, 25);
            this.gpbBuscarPuestos.Name = "gpbBuscarPuestos";
            this.gpbBuscarPuestos.Size = new System.Drawing.Size(719, 183);
            this.gpbBuscarPuestos.TabIndex = 79;
            this.gpbBuscarPuestos.TabStop = false;
            this.gpbBuscarPuestos.Text = "Buscar Puestos";
            // 
            // btnVerPuestos
            // 
            this.btnVerPuestos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerPuestos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnVerPuestos.FlatAppearance.BorderSize = 0;
            this.btnVerPuestos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btnVerPuestos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnVerPuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPuestos.ForeColor = System.Drawing.Color.White;
            this.btnVerPuestos.Location = new System.Drawing.Point(582, 133);
            this.btnVerPuestos.Name = "btnVerPuestos";
            this.btnVerPuestos.Size = new System.Drawing.Size(118, 31);
            this.btnVerPuestos.TabIndex = 79;
            this.btnVerPuestos.Text = "Ver Puestos";
            this.btnVerPuestos.UseVisualStyleBackColor = false;
            // 
            // btnBuscarPuestos
            // 
            this.btnBuscarPuestos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBuscarPuestos.FlatAppearance.BorderSize = 0;
            this.btnBuscarPuestos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.btnBuscarPuestos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnBuscarPuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPuestos.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPuestos.Location = new System.Drawing.Point(33, 112);
            this.btnBuscarPuestos.Name = "btnBuscarPuestos";
            this.btnBuscarPuestos.Size = new System.Drawing.Size(161, 34);
            this.btnBuscarPuestos.TabIndex = 82;
            this.btnBuscarPuestos.Text = "Buscar ";
            this.btnBuscarPuestos.UseVisualStyleBackColor = false;
            this.btnBuscarPuestos.Click += new System.EventHandler(this.btnBuscarPuestos_Click);
            // 
            // btnBorrarPuestos
            // 
            this.btnBorrarPuestos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrarPuestos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBorrarPuestos.FlatAppearance.BorderSize = 0;
            this.btnBorrarPuestos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBorrarPuestos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnBorrarPuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarPuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarPuestos.ForeColor = System.Drawing.Color.White;
            this.btnBorrarPuestos.Location = new System.Drawing.Point(582, 77);
            this.btnBorrarPuestos.Name = "btnBorrarPuestos";
            this.btnBorrarPuestos.Size = new System.Drawing.Size(118, 31);
            this.btnBorrarPuestos.TabIndex = 77;
            this.btnBorrarPuestos.Text = "Borrar";
            this.btnBorrarPuestos.UseVisualStyleBackColor = false;
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPor.Location = new System.Drawing.Point(80, 29);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(76, 16);
            this.lblBuscarPor.TabIndex = 81;
            this.lblBuscarPor.Text = "Buscar por:";
            // 
            // btnActualizarPuestos
            // 
            this.btnActualizarPuestos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarPuestos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnActualizarPuestos.FlatAppearance.BorderSize = 0;
            this.btnActualizarPuestos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnActualizarPuestos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnActualizarPuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarPuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPuestos.ForeColor = System.Drawing.Color.White;
            this.btnActualizarPuestos.Location = new System.Drawing.Point(582, 23);
            this.btnActualizarPuestos.Name = "btnActualizarPuestos";
            this.btnActualizarPuestos.Size = new System.Drawing.Size(118, 31);
            this.btnActualizarPuestos.TabIndex = 78;
            this.btnActualizarPuestos.Text = "Actualizar";
            this.btnActualizarPuestos.UseVisualStyleBackColor = false;
            // 
            // lblNomBuscar
            // 
            this.lblNomBuscar.AutoSize = true;
            this.lblNomBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomBuscar.ForeColor = System.Drawing.Color.White;
            this.lblNomBuscar.Location = new System.Drawing.Point(10, 71);
            this.lblNomBuscar.Name = "lblNomBuscar";
            this.lblNomBuscar.Size = new System.Drawing.Size(57, 16);
            this.lblNomBuscar.TabIndex = 80;
            this.lblNomBuscar.Text = "Nombre";
            // 
            // txtNombrePuestoBuscar
            // 
            this.txtNombrePuestoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePuestoBuscar.Location = new System.Drawing.Point(73, 68);
            this.txtNombrePuestoBuscar.Name = "txtNombrePuestoBuscar";
            this.txtNombrePuestoBuscar.Size = new System.Drawing.Size(121, 22);
            this.txtNombrePuestoBuscar.TabIndex = 79;
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(233, 25);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(331, 139);
            this.dgvProductos.TabIndex = 78;
            // 
            // gpbRegistrarPuesto
            // 
            this.gpbRegistrarPuesto.Controls.Add(this.txtEstatusPuesto);
            this.gpbRegistrarPuesto.Controls.Add(this.lblEstatusPuesto);
            this.gpbRegistrarPuesto.Controls.Add(this.btnRegistrarPuestos);
            this.gpbRegistrarPuesto.Controls.Add(this.txtDescripcionTurno);
            this.gpbRegistrarPuesto.Controls.Add(this.lblDescripcionPuesto);
            this.gpbRegistrarPuesto.Controls.Add(this.lblNombre);
            this.gpbRegistrarPuesto.Controls.Add(this.txtSalario);
            this.gpbRegistrarPuesto.Controls.Add(this.lblSalario);
            this.gpbRegistrarPuesto.Controls.Add(this.cmbPuestos);
            this.gpbRegistrarPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbRegistrarPuesto.ForeColor = System.Drawing.Color.White;
            this.gpbRegistrarPuesto.Location = new System.Drawing.Point(6, 25);
            this.gpbRegistrarPuesto.Name = "gpbRegistrarPuesto";
            this.gpbRegistrarPuesto.Size = new System.Drawing.Size(308, 183);
            this.gpbRegistrarPuesto.TabIndex = 0;
            this.gpbRegistrarPuesto.TabStop = false;
            this.gpbRegistrarPuesto.Text = "Registrar puesto";
            // 
            // txtEstatusPuesto
            // 
            this.txtEstatusPuesto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstatusPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstatusPuesto.Location = new System.Drawing.Point(155, 115);
            this.txtEstatusPuesto.Name = "txtEstatusPuesto";
            this.txtEstatusPuesto.Size = new System.Drawing.Size(147, 23);
            this.txtEstatusPuesto.TabIndex = 35;
            // 
            // lblEstatusPuesto
            // 
            this.lblEstatusPuesto.AutoSize = true;
            this.lblEstatusPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatusPuesto.ForeColor = System.Drawing.Color.White;
            this.lblEstatusPuesto.Location = new System.Drawing.Point(15, 120);
            this.lblEstatusPuesto.Name = "lblEstatusPuesto";
            this.lblEstatusPuesto.Size = new System.Drawing.Size(58, 18);
            this.lblEstatusPuesto.TabIndex = 34;
            this.lblEstatusPuesto.Text = "Estatus";
            // 
            // btnRegistrarPuestos
            // 
            this.btnRegistrarPuestos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarPuestos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRegistrarPuestos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegistrarPuestos.FlatAppearance.BorderSize = 0;
            this.btnRegistrarPuestos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRegistrarPuestos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnRegistrarPuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPuestos.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarPuestos.Location = new System.Drawing.Point(74, 144);
            this.btnRegistrarPuestos.Name = "btnRegistrarPuestos";
            this.btnRegistrarPuestos.Size = new System.Drawing.Size(162, 31);
            this.btnRegistrarPuestos.TabIndex = 31;
            this.btnRegistrarPuestos.Text = "Registrar";
            this.btnRegistrarPuestos.UseVisualStyleBackColor = false;
            this.btnRegistrarPuestos.Click += new System.EventHandler(this.btnRegistrarPuestos_Click);
            // 
            // txtDescripcionTurno
            // 
            this.txtDescripcionTurno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcionTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionTurno.Location = new System.Drawing.Point(155, 85);
            this.txtDescripcionTurno.Name = "txtDescripcionTurno";
            this.txtDescripcionTurno.Size = new System.Drawing.Size(147, 23);
            this.txtDescripcionTurno.TabIndex = 33;
            // 
            // lblDescripcionPuesto
            // 
            this.lblDescripcionPuesto.AutoSize = true;
            this.lblDescripcionPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionPuesto.ForeColor = System.Drawing.Color.White;
            this.lblDescripcionPuesto.Location = new System.Drawing.Point(15, 90);
            this.lblDescripcionPuesto.Name = "lblDescripcionPuesto";
            this.lblDescripcionPuesto.Size = new System.Drawing.Size(87, 18);
            this.lblDescripcionPuesto.TabIndex = 32;
            this.lblDescripcionPuesto.Text = "Descripción";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(15, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(134, 18);
            this.lblNombre.TabIndex = 20;
            this.lblNombre.Text = "Nombre del puesto";
            // 
            // txtSalario
            // 
            this.txtSalario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(155, 54);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(147, 23);
            this.txtSalario.TabIndex = 18;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.ForeColor = System.Drawing.Color.White;
            this.lblSalario.Location = new System.Drawing.Point(15, 59);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(54, 18);
            this.lblSalario.TabIndex = 22;
            this.lblSalario.Text = "Salario";
            // 
            // cmbPuestos
            // 
            this.cmbPuestos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPuestos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPuestos.FormattingEnabled = true;
            this.cmbPuestos.Items.AddRange(new object[] {
            "Administrador",
            "Cajero"});
            this.cmbPuestos.Location = new System.Drawing.Point(155, 24);
            this.cmbPuestos.Name = "cmbPuestos";
            this.cmbPuestos.Size = new System.Drawing.Size(147, 21);
            this.cmbPuestos.TabIndex = 19;
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
            // erpPuestosTurnos
            // 
            this.erpPuestosTurnos.ContainerControl = this;
            // 
            // frmPuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1080, 615);
            this.Controls.Add(this.paneFechaHora);
            this.Controls.Add(this.gpbTurnos);
            this.Controls.Add(this.ptbPuestos);
            this.Controls.Add(this.gpbPuesto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPuestos";
            this.Text = "frmPuestos";
            this.gpbTurnos.ResumeLayout(false);
            this.gpbBuscarTurnos.ResumeLayout(false);
            this.gpbBuscarTurnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpbRegistrarTurnos.ResumeLayout(false);
            this.gpbRegistrarTurnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPuestos)).EndInit();
            this.gpbPuesto.ResumeLayout(false);
            this.gpbBuscarPuestos.ResumeLayout(false);
            this.gpbBuscarPuestos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.gpbRegistrarPuesto.ResumeLayout(false);
            this.gpbRegistrarPuesto.PerformLayout();
            this.paneFechaHora.ResumeLayout(false);
            this.paneFechaHora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpPuestosTurnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbTurnos;
        private System.Windows.Forms.GroupBox gpbBuscarTurnos;
        private System.Windows.Forms.Button btnVerTurnos;
        private System.Windows.Forms.Button btnTurnoBuscar;
        private System.Windows.Forms.Button btnBorarTurno;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnActualizarTurno;
        private System.Windows.Forms.Label lblNombreTurnoBuscar;
        private System.Windows.Forms.TextBox txtNombreTurnoBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gpbRegistrarTurnos;
        private System.Windows.Forms.Label lblDescripcionTurno;
        private System.Windows.Forms.TextBox txtDescripción;
        private System.Windows.Forms.DateTimePicker dtpDia;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblEstatusTurno;
        private System.Windows.Forms.DateTimePicker dtpHoraSalida;
        private System.Windows.Forms.DateTimePicker dtpHoraEntrada;
        private System.Windows.Forms.Button btnRegistrarTurno;
        private System.Windows.Forms.Label lblHoraSalida;
        private System.Windows.Forms.Label lblNombreTurno;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.TextBox txtEstatusTurno;
        private System.Windows.Forms.Label lblHoraEntrada;
        private System.Windows.Forms.PictureBox ptbPuestos;
        private System.Windows.Forms.GroupBox gpbPuesto;
        private System.Windows.Forms.GroupBox gpbBuscarPuestos;
        private System.Windows.Forms.Button btnVerPuestos;
        private System.Windows.Forms.Button btnBuscarPuestos;
        private System.Windows.Forms.Button btnBorrarPuestos;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.Button btnActualizarPuestos;
        private System.Windows.Forms.Label lblNomBuscar;
        private System.Windows.Forms.TextBox txtNombrePuestoBuscar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.GroupBox gpbRegistrarPuesto;
        private System.Windows.Forms.TextBox txtEstatusPuesto;
        private System.Windows.Forms.Label lblEstatusPuesto;
        private System.Windows.Forms.Button btnRegistrarPuestos;
        private System.Windows.Forms.TextBox txtDescripcionTurno;
        private System.Windows.Forms.Label lblDescripcionPuesto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.ComboBox cmbPuestos;
        private System.Windows.Forms.Panel paneFechaHora;
        private System.Windows.Forms.Label lblMostrarHora;
        private System.Windows.Forms.Label lblMostrarFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer tmrFechaHora;
        private System.Windows.Forms.ErrorProvider erpPuestosTurnos;
        private System.Windows.Forms.ToolTip tltBuscar;
    }
}