namespace Punto_Venta_Abarrotes
{
    partial class frmReporteVentas
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
            this.gpbPeriodos = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gpbOrdenar = new System.Windows.Forms.GroupBox();
            this.rbnTotal = new System.Windows.Forms.RadioButton();
            this.rbnIVA = new System.Windows.Forms.RadioButton();
            this.rbnSubtotal = new System.Windows.Forms.RadioButton();
            this.paneFechaHora = new System.Windows.Forms.Panel();
            this.lblMostrarHora = new System.Windows.Forms.Label();
            this.lblMostrarFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.tmrFechaHora = new System.Windows.Forms.Timer(this.components);
            this.gpbProductos = new System.Windows.Forms.GroupBox();
            this.dgvReporteVentas = new System.Windows.Forms.DataGridView();
            this.btnVerReporte = new System.Windows.Forms.Button();
            this.btnGuardarReporte = new System.Windows.Forms.Button();
            this.ptbProveedor = new System.Windows.Forms.PictureBox();
            this.gpbPeriodos.SuspendLayout();
            this.gpbOrdenar.SuspendLayout();
            this.paneFechaHora.SuspendLayout();
            this.gpbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbPeriodos
            // 
            this.gpbPeriodos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbPeriodos.Controls.Add(this.dateTimePicker1);
            this.gpbPeriodos.Controls.Add(this.lblFechaFin);
            this.gpbPeriodos.Controls.Add(this.dtpFechaInicial);
            this.gpbPeriodos.Controls.Add(this.lblFechaInicial);
            this.gpbPeriodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPeriodos.ForeColor = System.Drawing.Color.White;
            this.gpbPeriodos.Location = new System.Drawing.Point(12, 132);
            this.gpbPeriodos.Name = "gpbPeriodos";
            this.gpbPeriodos.Size = new System.Drawing.Size(1014, 88);
            this.gpbPeriodos.TabIndex = 73;
            this.gpbPeriodos.TabStop = false;
            this.gpbPeriodos.Text = "Periodos";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(646, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(362, 27);
            this.dateTimePicker1.TabIndex = 44;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.ForeColor = System.Drawing.Color.White;
            this.lblFechaFin.Location = new System.Drawing.Point(521, 39);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(110, 24);
            this.lblFechaFin.TabIndex = 43;
            this.lblFechaFin.Text = "Fecha Final";
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicial.Location = new System.Drawing.Point(142, 39);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(330, 27);
            this.dtpFechaInicial.TabIndex = 42;
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicial.ForeColor = System.Drawing.Color.White;
            this.lblFechaInicial.Location = new System.Drawing.Point(20, 39);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(116, 24);
            this.lblFechaInicial.TabIndex = 20;
            this.lblFechaInicial.Text = "Fecha Inicial";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(6, 207);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(183, 31);
            this.btnConsultar.TabIndex = 31;
            this.btnConsultar.Text = "Consultar Reporte";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // gpbOrdenar
            // 
            this.gpbOrdenar.Controls.Add(this.rbnTotal);
            this.gpbOrdenar.Controls.Add(this.rbnIVA);
            this.gpbOrdenar.Controls.Add(this.rbnSubtotal);
            this.gpbOrdenar.Controls.Add(this.btnConsultar);
            this.gpbOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOrdenar.ForeColor = System.Drawing.Color.White;
            this.gpbOrdenar.Location = new System.Drawing.Point(12, 226);
            this.gpbOrdenar.Name = "gpbOrdenar";
            this.gpbOrdenar.Size = new System.Drawing.Size(195, 265);
            this.gpbOrdenar.TabIndex = 74;
            this.gpbOrdenar.TabStop = false;
            this.gpbOrdenar.Text = "Ordenar Ventas";
            // 
            // rbnTotal
            // 
            this.rbnTotal.AutoSize = true;
            this.rbnTotal.Location = new System.Drawing.Point(24, 149);
            this.rbnTotal.Name = "rbnTotal";
            this.rbnTotal.Size = new System.Drawing.Size(74, 29);
            this.rbnTotal.TabIndex = 7;
            this.rbnTotal.TabStop = true;
            this.rbnTotal.Text = "Total";
            this.rbnTotal.UseVisualStyleBackColor = true;
            // 
            // rbnIVA
            // 
            this.rbnIVA.AutoSize = true;
            this.rbnIVA.Location = new System.Drawing.Point(24, 100);
            this.rbnIVA.Name = "rbnIVA";
            this.rbnIVA.Size = new System.Drawing.Size(63, 29);
            this.rbnIVA.TabIndex = 6;
            this.rbnIVA.TabStop = true;
            this.rbnIVA.Text = "IVA";
            this.rbnIVA.UseVisualStyleBackColor = true;
            // 
            // rbnSubtotal
            // 
            this.rbnSubtotal.AutoSize = true;
            this.rbnSubtotal.Location = new System.Drawing.Point(24, 45);
            this.rbnSubtotal.Name = "rbnSubtotal";
            this.rbnSubtotal.Size = new System.Drawing.Size(102, 29);
            this.rbnSubtotal.TabIndex = 5;
            this.rbnSubtotal.TabStop = true;
            this.rbnSubtotal.Text = "Subtotal";
            this.rbnSubtotal.UseVisualStyleBackColor = true;
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
            this.paneFechaHora.TabIndex = 75;
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
            // gpbProductos
            // 
            this.gpbProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbProductos.Controls.Add(this.dgvReporteVentas);
            this.gpbProductos.Controls.Add(this.btnVerReporte);
            this.gpbProductos.Controls.Add(this.btnGuardarReporte);
            this.gpbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbProductos.ForeColor = System.Drawing.Color.White;
            this.gpbProductos.Location = new System.Drawing.Point(223, 226);
            this.gpbProductos.Name = "gpbProductos";
            this.gpbProductos.Size = new System.Drawing.Size(803, 318);
            this.gpbProductos.TabIndex = 76;
            this.gpbProductos.TabStop = false;
            this.gpbProductos.Text = "Productos";
            // 
            // dgvReporteVentas
            // 
            this.dgvReporteVentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReporteVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteVentas.Location = new System.Drawing.Point(17, 36);
            this.dgvReporteVentas.Name = "dgvReporteVentas";
            this.dgvReporteVentas.Size = new System.Drawing.Size(769, 216);
            this.dgvReporteVentas.TabIndex = 77;
            // 
            // btnVerReporte
            // 
            this.btnVerReporte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnVerReporte.FlatAppearance.BorderSize = 0;
            this.btnVerReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btnVerReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnVerReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerReporte.ForeColor = System.Drawing.Color.White;
            this.btnVerReporte.Location = new System.Drawing.Point(560, 281);
            this.btnVerReporte.Name = "btnVerReporte";
            this.btnVerReporte.Size = new System.Drawing.Size(226, 31);
            this.btnVerReporte.TabIndex = 76;
            this.btnVerReporte.Text = "Ver Reportes";
            this.btnVerReporte.UseVisualStyleBackColor = false;
            // 
            // btnGuardarReporte
            // 
            this.btnGuardarReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGuardarReporte.FlatAppearance.BorderSize = 0;
            this.btnGuardarReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnGuardarReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnGuardarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarReporte.ForeColor = System.Drawing.Color.White;
            this.btnGuardarReporte.Location = new System.Drawing.Point(6, 281);
            this.btnGuardarReporte.Name = "btnGuardarReporte";
            this.btnGuardarReporte.Size = new System.Drawing.Size(182, 31);
            this.btnGuardarReporte.TabIndex = 65;
            this.btnGuardarReporte.Text = "Guardar Reporte";
            this.btnGuardarReporte.UseVisualStyleBackColor = false;
            // 
            // ptbProveedor
            // 
            this.ptbProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbProveedor.Image = global::Punto_Venta_Abarrotes.Properties.Resources.pReporVentas;
            this.ptbProveedor.Location = new System.Drawing.Point(154, 26);
            this.ptbProveedor.Name = "ptbProveedor";
            this.ptbProveedor.Size = new System.Drawing.Size(709, 72);
            this.ptbProveedor.TabIndex = 67;
            this.ptbProveedor.TabStop = false;
            // 
            // frmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1056, 615);
            this.Controls.Add(this.gpbProductos);
            this.Controls.Add(this.paneFechaHora);
            this.Controls.Add(this.gpbOrdenar);
            this.Controls.Add(this.gpbPeriodos);
            this.Controls.Add(this.ptbProveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporteVentas";
            this.Text = "frmReporteVentas";
            this.gpbPeriodos.ResumeLayout(false);
            this.gpbPeriodos.PerformLayout();
            this.gpbOrdenar.ResumeLayout(false);
            this.gpbOrdenar.PerformLayout();
            this.paneFechaHora.ResumeLayout(false);
            this.paneFechaHora.PerformLayout();
            this.gpbProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbProveedor;
        private System.Windows.Forms.GroupBox gpbPeriodos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.GroupBox gpbOrdenar;
        private System.Windows.Forms.RadioButton rbnTotal;
        private System.Windows.Forms.RadioButton rbnIVA;
        private System.Windows.Forms.RadioButton rbnSubtotal;
        private System.Windows.Forms.Panel paneFechaHora;
        private System.Windows.Forms.Label lblMostrarHora;
        private System.Windows.Forms.Label lblMostrarFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer tmrFechaHora;
        private System.Windows.Forms.GroupBox gpbProductos;
        private System.Windows.Forms.DataGridView dgvReporteVentas;
        private System.Windows.Forms.Button btnVerReporte;
        private System.Windows.Forms.Button btnGuardarReporte;
    }
}