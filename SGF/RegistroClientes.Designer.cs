namespace SGF
{
    partial class RegistroClientes
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
            this.cbxProvincia = new System.Windows.Forms.ComboBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.rtbxIndicaciones = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxApellido = new System.Windows.Forms.TextBox();
            this.tbxDireccion = new System.Windows.Forms.TextBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.tbxLocalidad = new System.Windows.Forms.TextBox();
            this.tbxCodigo_postal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.tbxTelefono = new System.Windows.Forms.TextBox();
            this.tbxCorreo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGuardar1 = new System.Windows.Forms.Button();
            this.tbxCedula = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(280, 624);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // cbxProvincia
            // 
            this.cbxProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProvincia.FormattingEnabled = true;
            this.cbxProvincia.Items.AddRange(new object[] {
            "Azua",
            "Bahoruco",
            "Barahona",
            "Dajabón",
            "Distrito Nacional",
            "Duarte",
            "Elías Piña",
            "El Seibo",
            "Espaillat",
            "Hato Mayor",
            "Hermanas Mirabal",
            "Independencia",
            "La Altagracia",
            "La Romana",
            "La Vega",
            "María Trinidad Sánchez",
            "Monseñor Nouel",
            "Monte Cristi",
            "Monte Plata",
            "Pedernales",
            "Peravia",
            "Puerto Plata",
            "Samaná",
            "San Cristóbal",
            "San José de Ocoa",
            "San Juan",
            "San Pedro de Macorís",
            "Sánchez Ramírez",
            "Santiago",
            "Santiago Rodríguez",
            "Santo Domingo",
            "Valverde"});
            this.cbxProvincia.Location = new System.Drawing.Point(171, 178);
            this.cbxProvincia.Margin = new System.Windows.Forms.Padding(4);
            this.cbxProvincia.Name = "cbxProvincia";
            this.cbxProvincia.Size = new System.Drawing.Size(356, 24);
            this.cbxProvincia.TabIndex = 4;
            this.cbxProvincia.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(171, 50);
            this.tbxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(356, 22);
            this.tbxNombre.TabIndex = 0;
            this.tbxNombre.TextChanged += new System.EventHandler(this.tbxNombre_TextChanged);
            // 
            // rtbxIndicaciones
            // 
            this.rtbxIndicaciones.Location = new System.Drawing.Point(171, 366);
            this.rtbxIndicaciones.Margin = new System.Windows.Forms.Padding(4);
            this.rtbxIndicaciones.Name = "rtbxIndicaciones";
            this.rtbxIndicaciones.Size = new System.Drawing.Size(356, 148);
            this.rtbxIndicaciones.TabIndex = 7;
            this.rtbxIndicaciones.Text = "";
            this.rtbxIndicaciones.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha de nac.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Apellido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 246);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Dirección";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 214);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Localidad";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 370);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Indicaciones";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 182);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Província";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // tbxApellido
            // 
            this.tbxApellido.Location = new System.Drawing.Point(171, 82);
            this.tbxApellido.Margin = new System.Windows.Forms.Padding(4);
            this.tbxApellido.Name = "tbxApellido";
            this.tbxApellido.Size = new System.Drawing.Size(356, 22);
            this.tbxApellido.TabIndex = 1;
            // 
            // tbxDireccion
            // 
            this.tbxDireccion.Location = new System.Drawing.Point(171, 242);
            this.tbxDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDireccion.Name = "tbxDireccion";
            this.tbxDireccion.Size = new System.Drawing.Size(356, 22);
            this.tbxDireccion.TabIndex = 6;
            this.tbxDireccion.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(171, 114);
            this.dtFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(356, 22);
            this.dtFecha.TabIndex = 2;
            // 
            // cbxSexo
            // 
            this.cbxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.cbxSexo.Location = new System.Drawing.Point(171, 146);
            this.cbxSexo.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(160, 24);
            this.cbxSexo.TabIndex = 3;
            // 
            // tbxLocalidad
            // 
            this.tbxLocalidad.Location = new System.Drawing.Point(171, 210);
            this.tbxLocalidad.Margin = new System.Windows.Forms.Padding(4);
            this.tbxLocalidad.Name = "tbxLocalidad";
            this.tbxLocalidad.Size = new System.Drawing.Size(356, 22);
            this.tbxLocalidad.TabIndex = 5;
            // 
            // tbxCodigo_postal
            // 
            this.tbxCodigo_postal.Location = new System.Drawing.Point(171, 523);
            this.tbxCodigo_postal.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCodigo_postal.MaxLength = 10;
            this.tbxCodigo_postal.Name = "tbxCodigo_postal";
            this.tbxCodigo_postal.Size = new System.Drawing.Size(160, 22);
            this.tbxCodigo_postal.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 526);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Código Postal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Código";
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Location = new System.Drawing.Point(171, 18);
            this.tbxCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.ReadOnly = true;
            this.tbxCodigo.Size = new System.Drawing.Size(356, 22);
            this.tbxCodigo.TabIndex = 30;
            this.tbxCodigo.Text = "Nuevo";
            // 
            // tbxTelefono
            // 
            this.tbxTelefono.Location = new System.Drawing.Point(171, 274);
            this.tbxTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTelefono.MaxLength = 11;
            this.tbxTelefono.Name = "tbxTelefono";
            this.tbxTelefono.Size = new System.Drawing.Size(356, 22);
            this.tbxTelefono.TabIndex = 32;
            // 
            // tbxCorreo
            // 
            this.tbxCorreo.Location = new System.Drawing.Point(171, 306);
            this.tbxCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCorreo.Name = "tbxCorreo";
            this.tbxCorreo.Size = new System.Drawing.Size(356, 22);
            this.tbxCorreo.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 278);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Telefono";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 310);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 34;
            this.label12.Text = "Correo";
            // 
            // btnGuardar1
            // 
            this.btnGuardar1.Location = new System.Drawing.Point(171, 624);
            this.btnGuardar1.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar1.Name = "btnGuardar1";
            this.btnGuardar1.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar1.TabIndex = 10;
            this.btnGuardar1.Text = "Guardar";
            this.btnGuardar1.UseVisualStyleBackColor = true;
            this.btnGuardar1.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbxCedula
            // 
            this.tbxCedula.Location = new System.Drawing.Point(171, 336);
            this.tbxCedula.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCedula.MaxLength = 11;
            this.tbxCedula.Name = "tbxCedula";
            this.tbxCedula.Size = new System.Drawing.Size(356, 22);
            this.tbxCedula.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 340);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 17);
            this.label13.TabIndex = 37;
            this.label13.Text = "Cedula";
            // 
            // RegistroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 695);
            this.Controls.Add(this.tbxCedula);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbxTelefono);
            this.Controls.Add(this.tbxCorreo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxCodigo_postal);
            this.Controls.Add(this.btnGuardar1);
            this.Controls.Add(this.tbxLocalidad);
            this.Controls.Add(this.cbxSexo);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.tbxDireccion);
            this.Controls.Add(this.tbxApellido);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbxIndicaciones);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.cbxProvincia);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "RegistroClientes";
            this.Text = "MantenimientoClientes";
            this.Load += new System.EventHandler(this.MantenimientoClientes_Load);
            this.Controls.SetChildIndex(this.cbxProvincia, 0);
            this.Controls.SetChildIndex(this.tbxNombre, 0);
            this.Controls.SetChildIndex(this.rtbxIndicaciones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.tbxApellido, 0);
            this.Controls.SetChildIndex(this.tbxDireccion, 0);
            this.Controls.SetChildIndex(this.dtFecha, 0);
            this.Controls.SetChildIndex(this.cbxSexo, 0);
            this.Controls.SetChildIndex(this.tbxLocalidad, 0);
            this.Controls.SetChildIndex(this.btnGuardar1, 0);
            this.Controls.SetChildIndex(this.tbxCodigo_postal, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tbxCodigo, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.tbxCorreo, 0);
            this.Controls.SetChildIndex(this.tbxTelefono, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.tbxCedula, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cbxProvincia;
        public System.Windows.Forms.TextBox tbxNombre;
        public System.Windows.Forms.RichTextBox rtbxIndicaciones;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox tbxApellido;
        public System.Windows.Forms.TextBox tbxDireccion;
        public System.Windows.Forms.DateTimePicker dtFecha;
        public System.Windows.Forms.ComboBox cbxSexo;
        public System.Windows.Forms.TextBox tbxLocalidad;
        public System.Windows.Forms.TextBox tbxCodigo_postal;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbxCodigo;
        public System.Windows.Forms.TextBox tbxTelefono;
        public System.Windows.Forms.TextBox tbxCorreo;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Button btnGuardar1;
        public System.Windows.Forms.TextBox tbxCedula;
        public System.Windows.Forms.Label label13;
    }
}