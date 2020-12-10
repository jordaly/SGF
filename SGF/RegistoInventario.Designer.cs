﻿namespace SGF
{
    partial class RegistoInventario
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
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxPrecio_compra = new System.Windows.Forms.TextBox();
            this.tbxPrecio_venta = new System.Windows.Forms.TextBox();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.tbxCantidad_maxima = new System.Windows.Forms.TextBox();
            this.tbxCantidad_minima = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.dtFecha_renovacion = new System.Windows.Forms.DateTimePicker();
            this.cbxMedida = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxExistencia = new System.Windows.Forms.TextBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxCantidad_caja = new System.Windows.Forms.TextBox();
            this.etCantidad = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tkbItebis = new System.Windows.Forms.TrackBar();
            this.lbItebis = new System.Windows.Forms.Label();
            this.tbxMarca = new System.Windows.Forms.TextBox();
            this.btnSeleccionarMarca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbItebis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(274, 552);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Location = new System.Drawing.Point(273, 25);
            this.tbxCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.ReadOnly = true;
            this.tbxCodigo.Size = new System.Drawing.Size(319, 22);
            this.tbxCodigo.TabIndex = 0;
            this.tbxCodigo.Text = "Nuevo";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(273, 57);
            this.tbxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(319, 22);
            this.tbxNombre.TabIndex = 1;
            // 
            // tbxPrecio_compra
            // 
            this.tbxPrecio_compra.Location = new System.Drawing.Point(273, 89);
            this.tbxPrecio_compra.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPrecio_compra.Name = "tbxPrecio_compra";
            this.tbxPrecio_compra.Size = new System.Drawing.Size(319, 22);
            this.tbxPrecio_compra.TabIndex = 2;
            // 
            // tbxPrecio_venta
            // 
            this.tbxPrecio_venta.Location = new System.Drawing.Point(273, 121);
            this.tbxPrecio_venta.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPrecio_venta.Name = "tbxPrecio_venta";
            this.tbxPrecio_venta.Size = new System.Drawing.Size(319, 22);
            this.tbxPrecio_venta.TabIndex = 3;
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.Location = new System.Drawing.Point(273, 153);
            this.tbxDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(319, 22);
            this.tbxDescripcion.TabIndex = 6;
            // 
            // tbxCantidad_maxima
            // 
            this.tbxCantidad_maxima.Location = new System.Drawing.Point(273, 214);
            this.tbxCantidad_maxima.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCantidad_maxima.Name = "tbxCantidad_maxima";
            this.tbxCantidad_maxima.Size = new System.Drawing.Size(319, 22);
            this.tbxCantidad_maxima.TabIndex = 7;
            // 
            // tbxCantidad_minima
            // 
            this.tbxCantidad_minima.Location = new System.Drawing.Point(273, 246);
            this.tbxCantidad_minima.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCantidad_minima.Name = "tbxCantidad_minima";
            this.tbxCantidad_minima.Size = new System.Drawing.Size(319, 22);
            this.tbxCantidad_minima.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Código";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Precio de venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cantidad maxima";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cantidad minima";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 347);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Fecha de renovación";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 376);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Medida";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 408);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Departamento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 92);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Precio de Compra";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(60, 156);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Descripción";
            // 
            // cbxTipo
            // 
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Bienes de consumo",
            "Servicios",
            "Bienes de uso común",
            "Bienes de emergencia",
            "Bienes durables",
            "Bienes de especialidad"});
            this.cbxTipo.Location = new System.Drawing.Point(274, 405);
            this.cbxTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(319, 24);
            this.cbxTipo.TabIndex = 23;
            // 
            // dtFecha_renovacion
            // 
            this.dtFecha_renovacion.Location = new System.Drawing.Point(273, 343);
            this.dtFecha_renovacion.Margin = new System.Windows.Forms.Padding(4);
            this.dtFecha_renovacion.Name = "dtFecha_renovacion";
            this.dtFecha_renovacion.Size = new System.Drawing.Size(319, 22);
            this.dtFecha_renovacion.TabIndex = 24;
            // 
            // cbxMedida
            // 
            this.cbxMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMedida.FormattingEnabled = true;
            this.cbxMedida.Location = new System.Drawing.Point(274, 373);
            this.cbxMedida.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMedida.Name = "cbxMedida";
            this.cbxMedida.Size = new System.Drawing.Size(319, 24);
            this.cbxMedida.TabIndex = 26;
            this.cbxMedida.SelectedIndexChanged += new System.EventHandler(this.cbxMedida_SelectedIndexChanged);
            this.cbxMedida.Leave += new System.EventHandler(this.cbxMedida_Leave);
            this.cbxMedida.Validating += new System.ComponentModel.CancelEventHandler(this.cbxMedida_Validating);
            this.cbxMedida.Validated += new System.EventHandler(this.cbxMedida_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 188);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Existencia";
            // 
            // tbxExistencia
            // 
            this.tbxExistencia.Location = new System.Drawing.Point(273, 185);
            this.tbxExistencia.Margin = new System.Windows.Forms.Padding(4);
            this.tbxExistencia.Name = "tbxExistencia";
            this.tbxExistencia.Size = new System.Drawing.Size(319, 22);
            this.tbxExistencia.TabIndex = 27;
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(273, 467);
            this.cbxMarca.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(319, 24);
            this.cbxMarca.TabIndex = 30;
            this.cbxMarca.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(61, 440);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Marca";
            // 
            // tbxCantidad_caja
            // 
            this.tbxCantidad_caja.Location = new System.Drawing.Point(604, 373);
            this.tbxCantidad_caja.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCantidad_caja.Name = "tbxCantidad_caja";
            this.tbxCantidad_caja.Size = new System.Drawing.Size(96, 22);
            this.tbxCantidad_caja.TabIndex = 31;
            this.tbxCantidad_caja.Visible = false;
            // 
            // etCantidad
            // 
            this.etCantidad.AutoSize = true;
            this.etCantidad.Location = new System.Drawing.Point(604, 349);
            this.etCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.etCantidad.Name = "etCantidad";
            this.etCantidad.Size = new System.Drawing.Size(96, 17);
            this.etCantidad.TabIndex = 32;
            this.etCantidad.Text = "Cantidad Caja";
            this.etCantidad.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(60, 292);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 17);
            this.label14.TabIndex = 34;
            this.label14.Text = "ITEBIs";
            // 
            // tkbItebis
            // 
            this.tkbItebis.Location = new System.Drawing.Point(273, 281);
            this.tkbItebis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tkbItebis.Maximum = 100;
            this.tkbItebis.Name = "tkbItebis";
            this.tkbItebis.Size = new System.Drawing.Size(320, 56);
            this.tkbItebis.TabIndex = 35;
            this.tkbItebis.Scroll += new System.EventHandler(this.tkbItebis_Scroll);
            // 
            // lbItebis
            // 
            this.lbItebis.AutoSize = true;
            this.lbItebis.Location = new System.Drawing.Point(599, 292);
            this.lbItebis.Name = "lbItebis";
            this.lbItebis.Size = new System.Drawing.Size(26, 17);
            this.lbItebis.TabIndex = 36;
            this.lbItebis.Text = "(0)";
            // 
            // tbxMarca
            // 
            this.tbxMarca.Location = new System.Drawing.Point(274, 437);
            this.tbxMarca.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMarca.Name = "tbxMarca";
            this.tbxMarca.ReadOnly = true;
            this.tbxMarca.Size = new System.Drawing.Size(319, 22);
            this.tbxMarca.TabIndex = 37;
            // 
            // btnSeleccionarMarca
            // 
            this.btnSeleccionarMarca.Location = new System.Drawing.Point(604, 437);
            this.btnSeleccionarMarca.Name = "btnSeleccionarMarca";
            this.btnSeleccionarMarca.Size = new System.Drawing.Size(96, 23);
            this.btnSeleccionarMarca.TabIndex = 38;
            this.btnSeleccionarMarca.Text = "Seleccionar";
            this.btnSeleccionarMarca.UseVisualStyleBackColor = true;
            this.btnSeleccionarMarca.Click += new System.EventHandler(this.btnSeleccionarMarca_Click);
            // 
            // RegistoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 677);
            this.Controls.Add(this.btnSeleccionarMarca);
            this.Controls.Add(this.tbxMarca);
            this.Controls.Add(this.lbItebis);
            this.Controls.Add(this.tkbItebis);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.etCantidad);
            this.Controls.Add(this.tbxCantidad_caja);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxExistencia);
            this.Controls.Add(this.cbxMedida);
            this.Controls.Add(this.dtFecha_renovacion);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxCantidad_minima);
            this.Controls.Add(this.tbxCantidad_maxima);
            this.Controls.Add(this.tbxDescripcion);
            this.Controls.Add(this.tbxPrecio_venta);
            this.Controls.Add(this.tbxPrecio_compra);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.tbxCodigo);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "RegistoInventario";
            this.Text = "RegistoInventario";
            this.Controls.SetChildIndex(this.tbxCodigo, 0);
            this.Controls.SetChildIndex(this.tbxNombre, 0);
            this.Controls.SetChildIndex(this.tbxPrecio_compra, 0);
            this.Controls.SetChildIndex(this.tbxPrecio_venta, 0);
            this.Controls.SetChildIndex(this.tbxDescripcion, 0);
            this.Controls.SetChildIndex(this.tbxCantidad_maxima, 0);
            this.Controls.SetChildIndex(this.tbxCantidad_minima, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.cbxTipo, 0);
            this.Controls.SetChildIndex(this.dtFecha_renovacion, 0);
            this.Controls.SetChildIndex(this.cbxMedida, 0);
            this.Controls.SetChildIndex(this.tbxExistencia, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.cbxMarca, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.tbxCantidad_caja, 0);
            this.Controls.SetChildIndex(this.etCantidad, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.tkbItebis, 0);
            this.Controls.SetChildIndex(this.lbItebis, 0);
            this.Controls.SetChildIndex(this.tbxMarca, 0);
            this.Controls.SetChildIndex(this.btnSeleccionarMarca, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbItebis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox tbxCodigo;
        public System.Windows.Forms.TextBox tbxNombre;
        public System.Windows.Forms.TextBox tbxPrecio_compra;
        public System.Windows.Forms.TextBox tbxPrecio_venta;
        public System.Windows.Forms.TextBox tbxDescripcion;
        public System.Windows.Forms.TextBox tbxCantidad_maxima;
        public System.Windows.Forms.TextBox tbxCantidad_minima;
        public System.Windows.Forms.ComboBox cbxTipo;
        public System.Windows.Forms.DateTimePicker dtFecha_renovacion;
        public System.Windows.Forms.ComboBox cbxMedida;
        public System.Windows.Forms.TextBox tbxExistencia;
        public System.Windows.Forms.ComboBox cbxMarca;
        public System.Windows.Forms.TextBox tbxCantidad_caja;
        public System.Windows.Forms.Label etCantidad;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TrackBar tkbItebis;
        public System.Windows.Forms.Label lbItebis;
        public System.Windows.Forms.TextBox tbxMarca;
        private System.Windows.Forms.Button btnSeleccionarMarca;
    }
}