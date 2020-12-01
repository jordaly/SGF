namespace SGF
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
            this.label12 = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.dtFecha_renovacion = new System.Windows.Forms.DateTimePicker();
            this.chxEstado = new System.Windows.Forms.CheckBox();
            this.cbxMedida = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxExistencia = new System.Windows.Forms.TextBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxCantidad_caja = new System.Windows.Forms.TextBox();
            this.etCantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(205, 407);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Location = new System.Drawing.Point(205, 20);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.ReadOnly = true;
            this.tbxCodigo.Size = new System.Drawing.Size(200, 20);
            this.tbxCodigo.TabIndex = 0;
            this.tbxCodigo.Text = "Nuevo";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(205, 46);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(200, 20);
            this.tbxNombre.TabIndex = 1;
            // 
            // tbxPrecio_compra
            // 
            this.tbxPrecio_compra.Location = new System.Drawing.Point(205, 72);
            this.tbxPrecio_compra.Name = "tbxPrecio_compra";
            this.tbxPrecio_compra.Size = new System.Drawing.Size(200, 20);
            this.tbxPrecio_compra.TabIndex = 2;
            // 
            // tbxPrecio_venta
            // 
            this.tbxPrecio_venta.Location = new System.Drawing.Point(205, 98);
            this.tbxPrecio_venta.Name = "tbxPrecio_venta";
            this.tbxPrecio_venta.Size = new System.Drawing.Size(200, 20);
            this.tbxPrecio_venta.TabIndex = 3;
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.Location = new System.Drawing.Point(205, 124);
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(200, 20);
            this.tbxDescripcion.TabIndex = 6;
            // 
            // tbxCantidad_maxima
            // 
            this.tbxCantidad_maxima.Location = new System.Drawing.Point(205, 174);
            this.tbxCantidad_maxima.Name = "tbxCantidad_maxima";
            this.tbxCantidad_maxima.Size = new System.Drawing.Size(200, 20);
            this.tbxCantidad_maxima.TabIndex = 7;
            // 
            // tbxCantidad_minima
            // 
            this.tbxCantidad_minima.Location = new System.Drawing.Point(205, 200);
            this.tbxCantidad_minima.Name = "tbxCantidad_minima";
            this.tbxCantidad_minima.Size = new System.Drawing.Size(200, 20);
            this.tbxCantidad_minima.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Código";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Precio de venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cantidad maxima";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cantidad minima";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Fecha de renovación";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Medida";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Departamento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Precio de Compra";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Descripción";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Estado";
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
            this.cbxTipo.Location = new System.Drawing.Point(205, 305);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(200, 21);
            this.cbxTipo.TabIndex = 23;
            // 
            // dtFecha_renovacion
            // 
            this.dtFecha_renovacion.Location = new System.Drawing.Point(205, 226);
            this.dtFecha_renovacion.Name = "dtFecha_renovacion";
            this.dtFecha_renovacion.Size = new System.Drawing.Size(200, 20);
            this.dtFecha_renovacion.TabIndex = 24;
            // 
            // chxEstado
            // 
            this.chxEstado.AutoSize = true;
            this.chxEstado.Location = new System.Drawing.Point(205, 332);
            this.chxEstado.Name = "chxEstado";
            this.chxEstado.Size = new System.Drawing.Size(59, 17);
            this.chxEstado.TabIndex = 25;
            this.chxEstado.Text = "Estado";
            this.chxEstado.UseVisualStyleBackColor = true;
            // 
            // cbxMedida
            // 
            this.cbxMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMedida.FormattingEnabled = true;
            this.cbxMedida.Location = new System.Drawing.Point(205, 279);
            this.cbxMedida.Name = "cbxMedida";
            this.cbxMedida.Size = new System.Drawing.Size(200, 21);
            this.cbxMedida.TabIndex = 26;
            this.cbxMedida.SelectedIndexChanged += new System.EventHandler(this.cbxMedida_SelectedIndexChanged);
            this.cbxMedida.Leave += new System.EventHandler(this.cbxMedida_Leave);
            this.cbxMedida.Validating += new System.ComponentModel.CancelEventHandler(this.cbxMedida_Validating);
            this.cbxMedida.Validated += new System.EventHandler(this.cbxMedida_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Existencia";
            // 
            // tbxExistencia
            // 
            this.tbxExistencia.Location = new System.Drawing.Point(205, 150);
            this.tbxExistencia.Name = "tbxExistencia";
            this.tbxExistencia.Size = new System.Drawing.Size(200, 20);
            this.tbxExistencia.TabIndex = 27;
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(205, 252);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(200, 21);
            this.cbxMarca.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(45, 255);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Marca";
            // 
            // tbxCantidad_caja
            // 
            this.tbxCantidad_caja.Location = new System.Drawing.Point(411, 279);
            this.tbxCantidad_caja.Name = "tbxCantidad_caja";
            this.tbxCantidad_caja.Size = new System.Drawing.Size(73, 20);
            this.tbxCantidad_caja.TabIndex = 31;
            this.tbxCantidad_caja.Visible = false;
            // 
            // etCantidad
            // 
            this.etCantidad.AutoSize = true;
            this.etCantidad.Location = new System.Drawing.Point(411, 260);
            this.etCantidad.Name = "etCantidad";
            this.etCantidad.Size = new System.Drawing.Size(73, 13);
            this.etCantidad.TabIndex = 32;
            this.etCantidad.Text = "Cantidad Caja";
            this.etCantidad.Visible = false;
            // 
            // RegistoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 453);
            this.Controls.Add(this.etCantidad);
            this.Controls.Add(this.tbxCantidad_caja);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxExistencia);
            this.Controls.Add(this.cbxMedida);
            this.Controls.Add(this.chxEstado);
            this.Controls.Add(this.dtFecha_renovacion);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.label12);
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
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.cbxTipo, 0);
            this.Controls.SetChildIndex(this.dtFecha_renovacion, 0);
            this.Controls.SetChildIndex(this.chxEstado, 0);
            this.Controls.SetChildIndex(this.cbxMedida, 0);
            this.Controls.SetChildIndex(this.tbxExistencia, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.cbxMarca, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.tbxCantidad_caja, 0);
            this.Controls.SetChildIndex(this.etCantidad, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
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
        private System.Windows.Forms.Label label12;
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
        public System.Windows.Forms.CheckBox chxEstado;
        public System.Windows.Forms.ComboBox cbxMedida;
        public System.Windows.Forms.TextBox tbxExistencia;
        public System.Windows.Forms.ComboBox cbxMarca;
        public System.Windows.Forms.TextBox tbxCantidad_caja;
        public System.Windows.Forms.Label etCantidad;
    }
}