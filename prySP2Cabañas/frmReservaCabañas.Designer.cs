namespace prySP2Cabañas
{
    partial class frmReservaCabañas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservaCabañas));
            this.mrcCabaña = new System.Windows.Forms.GroupBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.cmbPersonas = new System.Windows.Forms.ComboBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.mrcAdicionales = new System.Windows.Forms.GroupBox();
            this.chkTelevision = new System.Windows.Forms.CheckBox();
            this.chkHeladera = new System.Windows.Forms.CheckBox();
            this.chkCocina = new System.Windows.Forms.CheckBox();
            this.mrcPago = new System.Windows.Forms.GroupBox();
            this.cmbTarjetas = new System.Windows.Forms.ComboBox();
            this.lblTarjetas = new System.Windows.Forms.Label();
            this.optTarjeta = new System.Windows.Forms.RadioButton();
            this.optEfectivo = new System.Windows.Forms.RadioButton();
            this.mrcReserva = new System.Windows.Forms.GroupBox();
            this.txtTelefonos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefonos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.mrcCabaña.SuspendLayout();
            this.mrcAdicionales.SuspendLayout();
            this.mrcPago.SuspendLayout();
            this.mrcReserva.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcCabaña
            // 
            this.mrcCabaña.Controls.Add(this.txtDias);
            this.mrcCabaña.Controls.Add(this.cmbPersonas);
            this.mrcCabaña.Controls.Add(this.lblDias);
            this.mrcCabaña.Controls.Add(this.lblPersonas);
            this.mrcCabaña.Controls.Add(this.cmbTipo);
            this.mrcCabaña.Controls.Add(this.lblTipo);
            this.mrcCabaña.Location = new System.Drawing.Point(12, 22);
            this.mrcCabaña.Name = "mrcCabaña";
            this.mrcCabaña.Size = new System.Drawing.Size(492, 100);
            this.mrcCabaña.TabIndex = 0;
            this.mrcCabaña.TabStop = false;
            this.mrcCabaña.Text = "Tipo de cabaña ";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(383, 44);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(56, 20);
            this.txtDias.TabIndex = 2;
            this.txtDias.TextChanged += new System.EventHandler(this.txtDias_TextChanged);
            this.txtDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDias_KeyPress);
            // 
            // cmbPersonas
            // 
            this.cmbPersonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonas.FormattingEnabled = true;
            this.cmbPersonas.Location = new System.Drawing.Point(257, 44);
            this.cmbPersonas.Name = "cmbPersonas";
            this.cmbPersonas.Size = new System.Drawing.Size(54, 21);
            this.cmbPersonas.TabIndex = 3;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(349, 48);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(30, 13);
            this.lblDias.TabIndex = 1;
            this.lblDias.Text = "Días";
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Location = new System.Drawing.Point(199, 48);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(51, 13);
            this.lblPersonas.TabIndex = 2;
            this.lblPersonas.Text = "Personas";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cmbTipo.Location = new System.Drawing.Point(56, 45);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(109, 21);
            this.cmbTipo.TabIndex = 1;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(22, 48);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo";
            // 
            // mrcAdicionales
            // 
            this.mrcAdicionales.Controls.Add(this.chkTelevision);
            this.mrcAdicionales.Controls.Add(this.chkHeladera);
            this.mrcAdicionales.Controls.Add(this.chkCocina);
            this.mrcAdicionales.Location = new System.Drawing.Point(37, 142);
            this.mrcAdicionales.Name = "mrcAdicionales";
            this.mrcAdicionales.Size = new System.Drawing.Size(140, 123);
            this.mrcAdicionales.TabIndex = 1;
            this.mrcAdicionales.TabStop = false;
            this.mrcAdicionales.Text = "Adicionales";
            // 
            // chkTelevision
            // 
            this.chkTelevision.AutoSize = true;
            this.chkTelevision.Location = new System.Drawing.Point(21, 73);
            this.chkTelevision.Name = "chkTelevision";
            this.chkTelevision.Size = new System.Drawing.Size(74, 17);
            this.chkTelevision.TabIndex = 2;
            this.chkTelevision.Text = "&Televisión";
            this.chkTelevision.UseVisualStyleBackColor = true;
            this.chkTelevision.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chkHeladera
            // 
            this.chkHeladera.AutoSize = true;
            this.chkHeladera.Location = new System.Drawing.Point(21, 50);
            this.chkHeladera.Name = "chkHeladera";
            this.chkHeladera.Size = new System.Drawing.Size(69, 17);
            this.chkHeladera.TabIndex = 1;
            this.chkHeladera.Text = "&Heladera";
            this.chkHeladera.UseVisualStyleBackColor = true;
            // 
            // chkCocina
            // 
            this.chkCocina.AutoSize = true;
            this.chkCocina.Location = new System.Drawing.Point(21, 27);
            this.chkCocina.Name = "chkCocina";
            this.chkCocina.Size = new System.Drawing.Size(59, 17);
            this.chkCocina.TabIndex = 0;
            this.chkCocina.Text = "&Cocina";
            this.chkCocina.UseVisualStyleBackColor = true;
            // 
            // mrcPago
            // 
            this.mrcPago.Controls.Add(this.cmbTarjetas);
            this.mrcPago.Controls.Add(this.lblTarjetas);
            this.mrcPago.Controls.Add(this.optTarjeta);
            this.mrcPago.Controls.Add(this.optEfectivo);
            this.mrcPago.Location = new System.Drawing.Point(214, 142);
            this.mrcPago.Name = "mrcPago";
            this.mrcPago.Size = new System.Drawing.Size(290, 123);
            this.mrcPago.TabIndex = 2;
            this.mrcPago.TabStop = false;
            this.mrcPago.Text = "Forma de pago";
            this.mrcPago.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // cmbTarjetas
            // 
            this.cmbTarjetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarjetas.Enabled = false;
            this.cmbTarjetas.FormattingEnabled = true;
            this.cmbTarjetas.Items.AddRange(new object[] {
            "Card Red",
            "Card Green",
            "Card Blue"});
            this.cmbTarjetas.Location = new System.Drawing.Point(100, 82);
            this.cmbTarjetas.Name = "cmbTarjetas";
            this.cmbTarjetas.Size = new System.Drawing.Size(173, 21);
            this.cmbTarjetas.TabIndex = 3;
            // 
            // lblTarjetas
            // 
            this.lblTarjetas.AutoSize = true;
            this.lblTarjetas.Location = new System.Drawing.Point(97, 59);
            this.lblTarjetas.Name = "lblTarjetas";
            this.lblTarjetas.Size = new System.Drawing.Size(45, 13);
            this.lblTarjetas.TabIndex = 2;
            this.lblTarjetas.Text = "Tarjetas";
            // 
            // optTarjeta
            // 
            this.optTarjeta.AutoSize = true;
            this.optTarjeta.Location = new System.Drawing.Point(19, 55);
            this.optTarjeta.Name = "optTarjeta";
            this.optTarjeta.Size = new System.Drawing.Size(58, 17);
            this.optTarjeta.TabIndex = 1;
            this.optTarjeta.Text = "&Tarjeta";
            this.optTarjeta.UseVisualStyleBackColor = true;
            this.optTarjeta.CheckedChanged += new System.EventHandler(this.optTarjeta_CheckedChanged);
            // 
            // optEfectivo
            // 
            this.optEfectivo.AutoSize = true;
            this.optEfectivo.Checked = true;
            this.optEfectivo.Location = new System.Drawing.Point(19, 31);
            this.optEfectivo.Name = "optEfectivo";
            this.optEfectivo.Size = new System.Drawing.Size(64, 17);
            this.optEfectivo.TabIndex = 0;
            this.optEfectivo.TabStop = true;
            this.optEfectivo.Text = "&Efectivo";
            this.optEfectivo.UseVisualStyleBackColor = true;
            this.optEfectivo.CheckedChanged += new System.EventHandler(this.optEfectivo_CheckedChanged);
            // 
            // mrcReserva
            // 
            this.mrcReserva.Controls.Add(this.txtTelefonos);
            this.mrcReserva.Controls.Add(this.txtNombre);
            this.mrcReserva.Controls.Add(this.lblTelefonos);
            this.mrcReserva.Controls.Add(this.lblNombre);
            this.mrcReserva.Location = new System.Drawing.Point(37, 288);
            this.mrcReserva.Name = "mrcReserva";
            this.mrcReserva.Size = new System.Drawing.Size(467, 100);
            this.mrcReserva.TabIndex = 3;
            this.mrcReserva.TabStop = false;
            this.mrcReserva.Text = "Titular de la reserva";
            // 
            // txtTelefonos
            // 
            this.txtTelefonos.Location = new System.Drawing.Point(118, 63);
            this.txtTelefonos.Name = "txtTelefonos";
            this.txtTelefonos.Size = new System.Drawing.Size(332, 20);
            this.txtTelefonos.TabIndex = 3;
            this.txtTelefonos.TextChanged += new System.EventHandler(this.txtTelefonos_TextChanged);
            this.txtTelefonos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonos_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(118, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(332, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblTelefonos
            // 
            this.lblTelefonos.AutoSize = true;
            this.lblTelefonos.Location = new System.Drawing.Point(36, 66);
            this.lblTelefonos.Name = "lblTelefonos";
            this.lblTelefonos.Size = new System.Drawing.Size(54, 13);
            this.lblTelefonos.TabIndex = 1;
            this.lblTelefonos.Text = "Teléfonos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(36, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(413, 411);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(91, 26);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmReservaCabañas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 458);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.mrcReserva);
            this.Controls.Add(this.mrcPago);
            this.Controls.Add(this.mrcAdicionales);
            this.Controls.Add(this.mrcCabaña);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReservaCabañas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva de Cabañas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mrcCabaña.ResumeLayout(false);
            this.mrcCabaña.PerformLayout();
            this.mrcAdicionales.ResumeLayout(false);
            this.mrcAdicionales.PerformLayout();
            this.mrcPago.ResumeLayout(false);
            this.mrcPago.PerformLayout();
            this.mrcReserva.ResumeLayout(false);
            this.mrcReserva.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcCabaña;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.ComboBox cmbPersonas;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblPersonas;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.GroupBox mrcAdicionales;
        private System.Windows.Forms.CheckBox chkTelevision;
        private System.Windows.Forms.CheckBox chkHeladera;
        private System.Windows.Forms.CheckBox chkCocina;
        private System.Windows.Forms.GroupBox mrcPago;
        private System.Windows.Forms.ComboBox cmbTarjetas;
        private System.Windows.Forms.Label lblTarjetas;
        private System.Windows.Forms.RadioButton optTarjeta;
        private System.Windows.Forms.RadioButton optEfectivo;
        private System.Windows.Forms.GroupBox mrcReserva;
        private System.Windows.Forms.TextBox txtTelefonos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefonos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAceptar;
    }
}

