namespace Punto_Venta_Abarrotes
{
    partial class frmPerdidas
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
            this.ptbCompras = new System.Windows.Forms.PictureBox();
            this.gpbRegistrarPerdida = new System.Windows.Forms.GroupBox();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.txtCausa = new System.Windows.Forms.TextBox();
            this.lblCausa = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecioPerdida = new System.Windows.Forms.Label();
            this.txtPrecioPerdida = new System.Windows.Forms.TextBox();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.paneFechaHora = new System.Windows.Forms.Panel();
            this.lblMostrarHora = new System.Windows.Forms.Label();
            this.lblMostrarFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.tmrFechaHora = new System.Windows.Forms.Timer(this.components);
            this.gpbPerdidas = new System.Windows.Forms.GroupBox();
            this.dgvPerdidas = new System.Windows.Forms.DataGridView();
            this.btnVerPerdidas = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.erpPerdidas = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCompras)).BeginInit();
            this.gpbRegistrarPerdida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.paneFechaHora.SuspendLayout();
            this.gpbPerdidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerdidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPerdidas)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbCompras
            // 
            this.ptbCompras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbCompras.Image = global::Punto_Venta_Abarrotes.Properties.Resources.ptbPerdida;
            this.ptbCompras.Location = new System.Drawing.Point(382, 28);
            this.ptbCompras.Name = "ptbCompras";
            this.ptbCompras.Size = new System.Drawing.Size(400, 76);
            this.ptbCompras.TabIndex = 72;
            this.ptbCompras.TabStop = false;
            // 
            // gpbRegistrarPerdida
            // 
            this.gpbRegistrarPerdida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gpbRegistrarPerdida.Controls.Add(this.txtEstatus);
            this.gpbRegistrarPerdida.Controls.Add(this.lblEstatus);
            this.gpbRegistrarPerdida.Controls.Add(this.txtCausa);
            this.gpbRegistrarPerdida.Controls.Add(this.lblCausa);
            this.gpbRegistrarPerdida.Controls.Add(this.btnRegistrar);
            this.gpbRegistrarPerdida.Controls.Add(this.dtpFechaRegistro);
            this.gpbRegistrarPerdida.Controls.Add(this.lblFechaRegistro);
            this.gpbRegistrarPerdida.Controls.Add(this.nudCantidad);
            this.gpbRegistrarPerdida.Controls.Add(this.lblCantidad);
            this.gpbRegistrarPerdida.Controls.Add(this.lblPrecioPerdida);
            this.gpbRegistrarPerdida.Controls.Add(this.txtPrecioPerdida);
            this.gpbRegistrarPerdida.Controls.Add(this.lblIdProducto);
            this.gpbRegistrarPerdida.Controls.Add(this.txtIdProducto);
            this.gpbRegistrarPerdida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbRegistrarPerdida.ForeColor = System.Drawing.Color.White;
            this.gpbRegistrarPerdida.Location = new System.Drawing.Point(22, 127);
            this.gpbRegistrarPerdida.Name = "gpbRegistrarPerdida";
            this.gpbRegistrarPerdida.Size = new System.Drawing.Size(460, 384);
            this.gpbRegistrarPerdida.TabIndex = 73;
            this.gpbRegistrarPerdida.TabStop = false;
            this.gpbRegistrarPerdida.Text = "Registrar Pérdida";
            // 
            // txtEstatus
            // 
            this.txtEstatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstatus.Location = new System.Drawing.Point(255, 264);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(178, 23);
            this.txtEstatus.TabIndex = 35;
            this.txtEstatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstatus_KeyPress);
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatus.ForeColor = System.Drawing.Color.White;
            this.lblEstatus.Location = new System.Drawing.Point(18, 261);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(70, 24);
            this.lblEstatus.TabIndex = 34;
            this.lblEstatus.Text = "Estatus";
            // 
            // txtCausa
            // 
            this.txtCausa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCausa.Location = new System.Drawing.Point(255, 176);
            this.txtCausa.Name = "txtCausa";
            this.txtCausa.Size = new System.Drawing.Size(178, 23);
            this.txtCausa.TabIndex = 33;
            // 
            // lblCausa
            // 
            this.lblCausa.AutoSize = true;
            this.lblCausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCausa.ForeColor = System.Drawing.Color.White;
            this.lblCausa.Location = new System.Drawing.Point(18, 176);
            this.lblCausa.Name = "lblCausa";
            this.lblCausa.Size = new System.Drawing.Size(63, 24);
            this.lblCausa.TabIndex = 32;
            this.lblCausa.Text = "Causa";
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
            this.btnRegistrar.Location = new System.Drawing.Point(157, 329);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(171, 31);
            this.btnRegistrar.TabIndex = 31;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(255, 218);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(178, 26);
            this.dtpFechaRegistro.TabIndex = 30;
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRegistro.ForeColor = System.Drawing.Color.White;
            this.lblFechaRegistro.Location = new System.Drawing.Point(18, 220);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(158, 24);
            this.lblFechaRegistro.TabIndex = 29;
            this.lblFechaRegistro.Text = "Fecha de registro";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(255, 133);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(178, 26);
            this.nudCantidad.TabIndex = 28;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(18, 135);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(84, 24);
            this.lblCantidad.TabIndex = 27;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblPrecioPerdida
            // 
            this.lblPrecioPerdida.AutoSize = true;
            this.lblPrecioPerdida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioPerdida.ForeColor = System.Drawing.Color.White;
            this.lblPrecioPerdida.Location = new System.Drawing.Point(18, 94);
            this.lblPrecioPerdida.Name = "lblPrecioPerdida";
            this.lblPrecioPerdida.Size = new System.Drawing.Size(179, 24);
            this.lblPrecioPerdida.TabIndex = 22;
            this.lblPrecioPerdida.Text = "Precio de la pérdida";
            // 
            // txtPrecioPerdida
            // 
            this.txtPrecioPerdida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecioPerdida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioPerdida.Location = new System.Drawing.Point(255, 94);
            this.txtPrecioPerdida.Name = "txtPrecioPerdida";
            this.txtPrecioPerdida.Size = new System.Drawing.Size(178, 23);
            this.txtPrecioPerdida.TabIndex = 21;
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProducto.ForeColor = System.Drawing.Color.White;
            this.lblIdProducto.Location = new System.Drawing.Point(18, 53);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(108, 24);
            this.lblIdProducto.TabIndex = 20;
            this.lblIdProducto.Text = "ID Producto";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProducto.Location = new System.Drawing.Point(255, 53);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(178, 23);
            this.txtIdProducto.TabIndex = 18;
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
            // gpbPerdidas
            // 
            this.gpbPerdidas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbPerdidas.Controls.Add(this.dgvPerdidas);
            this.gpbPerdidas.Controls.Add(this.btnVerPerdidas);
            this.gpbPerdidas.Controls.Add(this.btnBorrar);
            this.gpbPerdidas.Controls.Add(this.btnActualizar);
            this.gpbPerdidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPerdidas.ForeColor = System.Drawing.Color.White;
            this.gpbPerdidas.Location = new System.Drawing.Point(499, 127);
            this.gpbPerdidas.Name = "gpbPerdidas";
            this.gpbPerdidas.Size = new System.Drawing.Size(545, 384);
            this.gpbPerdidas.TabIndex = 75;
            this.gpbPerdidas.TabStop = false;
            this.gpbPerdidas.Text = "Pérdidas";
            // 
            // dgvPerdidas
            // 
            this.dgvPerdidas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPerdidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerdidas.Location = new System.Drawing.Point(17, 53);
            this.dgvPerdidas.Name = "dgvPerdidas";
            this.dgvPerdidas.Size = new System.Drawing.Size(501, 232);
            this.dgvPerdidas.TabIndex = 77;
            // 
            // btnVerPerdidas
            // 
            this.btnVerPerdidas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerPerdidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnVerPerdidas.FlatAppearance.BorderSize = 0;
            this.btnVerPerdidas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btnVerPerdidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnVerPerdidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPerdidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPerdidas.ForeColor = System.Drawing.Color.White;
            this.btnVerPerdidas.Location = new System.Drawing.Point(353, 329);
            this.btnVerPerdidas.Name = "btnVerPerdidas";
            this.btnVerPerdidas.Size = new System.Drawing.Size(165, 31);
            this.btnVerPerdidas.TabIndex = 76;
            this.btnVerPerdidas.Text = "Ver Pérdidas";
            this.btnVerPerdidas.UseVisualStyleBackColor = false;
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
            this.btnBorrar.Location = new System.Drawing.Point(190, 329);
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
            this.btnActualizar.Location = new System.Drawing.Point(17, 329);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(118, 31);
            this.btnActualizar.TabIndex = 65;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // erpPerdidas
            // 
            this.erpPerdidas.ContainerControl = this;
            // 
            // frmPerdidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1056, 615);
            this.Controls.Add(this.gpbPerdidas);
            this.Controls.Add(this.paneFechaHora);
            this.Controls.Add(this.gpbRegistrarPerdida);
            this.Controls.Add(this.ptbCompras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPerdidas";
            this.Text = "frmPerdidas";
            ((System.ComponentModel.ISupportInitialize)(this.ptbCompras)).EndInit();
            this.gpbRegistrarPerdida.ResumeLayout(false);
            this.gpbRegistrarPerdida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.paneFechaHora.ResumeLayout(false);
            this.paneFechaHora.PerformLayout();
            this.gpbPerdidas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerdidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPerdidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbCompras;
        private System.Windows.Forms.GroupBox gpbRegistrarPerdida;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.TextBox txtCausa;
        private System.Windows.Forms.Label lblCausa;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecioPerdida;
        private System.Windows.Forms.TextBox txtPrecioPerdida;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Panel paneFechaHora;
        private System.Windows.Forms.Label lblMostrarHora;
        private System.Windows.Forms.Label lblMostrarFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer tmrFechaHora;
        private System.Windows.Forms.GroupBox gpbPerdidas;
        private System.Windows.Forms.DataGridView dgvPerdidas;
        private System.Windows.Forms.Button btnVerPerdidas;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ErrorProvider erpPerdidas;
    }
}