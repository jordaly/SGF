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
            this.chxEstado = new System.Windows.Forms.CheckBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(112, 492);
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
            this.cbxProvincia.Location = new System.Drawing.Point(128, 145);
            this.cbxProvincia.Name = "cbxProvincia";
            this.cbxProvincia.Size = new System.Drawing.Size(268, 21);
            this.cbxProvincia.TabIndex = 4;
            this.cbxProvincia.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(128, 41);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(268, 20);
            this.tbxNombre.TabIndex = 0;
            this.tbxNombre.TextChanged += new System.EventHandler(this.tbxNombre_TextChanged);
            // 
            // rtbxIndicaciones
            // 
            this.rtbxIndicaciones.Location = new System.Drawing.Point(128, 275);
            this.rtbxIndicaciones.Name = "rtbxIndicaciones";
            this.rtbxIndicaciones.Size = new System.Drawing.Size(268, 121);
            this.rtbxIndicaciones.TabIndex = 7;
            this.rtbxIndicaciones.Text = "";
            this.rtbxIndicaciones.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // chxEstado
            // 
            this.chxEstado.AutoSize = true;
            this.chxEstado.Location = new System.Drawing.Point(128, 428);
            this.chxEstado.Name = "chxEstado";
            this.chxEstado.Size = new System.Drawing.Size(59, 17);
            this.chxEstado.TabIndex = 9;
            this.chxEstado.Text = "Estado";
            this.chxEstado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha de nac.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Apellido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Dirección";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Localidad";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Indicaciones";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Província";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // tbxApellido
            // 
            this.tbxApellido.Location = new System.Drawing.Point(128, 67);
            this.tbxApellido.Name = "tbxApellido";
            this.tbxApellido.Size = new System.Drawing.Size(268, 20);
            this.tbxApellido.TabIndex = 1;
            // 
            // tbxDireccion
            // 
            this.tbxDireccion.Location = new System.Drawing.Point(128, 197);
            this.tbxDireccion.Name = "tbxDireccion";
            this.tbxDireccion.Size = new System.Drawing.Size(268, 20);
            this.tbxDireccion.TabIndex = 6;
            this.tbxDireccion.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(128, 93);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(268, 20);
            this.dtFecha.TabIndex = 2;
            // 
            // cbxSexo
            // 
            this.cbxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.cbxSexo.Location = new System.Drawing.Point(128, 119);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(121, 21);
            this.cbxSexo.TabIndex = 3;
            // 
            // tbxLocalidad
            // 
            this.tbxLocalidad.Location = new System.Drawing.Point(128, 171);
            this.tbxLocalidad.Name = "tbxLocalidad";
            this.tbxLocalidad.Size = new System.Drawing.Size(268, 20);
            this.tbxLocalidad.TabIndex = 5;
            // 
            // tbxCodigo_postal
            // 
            this.tbxCodigo_postal.Location = new System.Drawing.Point(128, 402);
            this.tbxCodigo_postal.Name = "tbxCodigo_postal";
            this.tbxCodigo_postal.Size = new System.Drawing.Size(121, 20);
            this.tbxCodigo_postal.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Código Postal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Código";
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Location = new System.Drawing.Point(128, 15);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.ReadOnly = true;
            this.tbxCodigo.Size = new System.Drawing.Size(268, 20);
            this.tbxCodigo.TabIndex = 30;
            this.tbxCodigo.Text = "Nuevo";
            // 
            // tbxTelefono
            // 
            this.tbxTelefono.Location = new System.Drawing.Point(128, 223);
            this.tbxTelefono.Name = "tbxTelefono";
            this.tbxTelefono.Size = new System.Drawing.Size(268, 20);
            this.tbxTelefono.TabIndex = 32;
            // 
            // tbxCorreo
            // 
            this.tbxCorreo.Location = new System.Drawing.Point(128, 249);
            this.tbxCorreo.Name = "tbxCorreo";
            this.tbxCorreo.Size = new System.Drawing.Size(268, 20);
            this.tbxCorreo.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Telefono";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 252);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Correo";
            // 
            // btnGuardar1
            // 
            this.btnGuardar1.Location = new System.Drawing.Point(224, 492);
            this.btnGuardar1.Name = "btnGuardar1";
            this.btnGuardar1.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar1.TabIndex = 10;
            this.btnGuardar1.Text = "Guardar";
            this.btnGuardar1.UseVisualStyleBackColor = true;
            this.btnGuardar1.Visible = false;
            this.btnGuardar1.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // RegistroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 534);
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
            this.Controls.Add(this.chxEstado);
            this.Controls.Add(this.rtbxIndicaciones);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.cbxProvincia);
            this.Name = "RegistroClientes";
            this.Text = "MantenimientoClientes";
            this.Load += new System.EventHandler(this.MantenimientoClientes_Load);
            this.Controls.SetChildIndex(this.cbxProvincia, 0);
            this.Controls.SetChildIndex(this.tbxNombre, 0);
            this.Controls.SetChildIndex(this.rtbxIndicaciones, 0);
            this.Controls.SetChildIndex(this.chxEstado, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cbxProvincia;
        public System.Windows.Forms.TextBox tbxNombre;
        public System.Windows.Forms.RichTextBox rtbxIndicaciones;
        public System.Windows.Forms.CheckBox chxEstado;
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
    }
}