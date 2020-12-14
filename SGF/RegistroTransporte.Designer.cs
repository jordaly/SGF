namespace SGF
{
    partial class RegistroTransporte
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.gridarticulo = new System.Windows.Forms.DataGridView();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbcodigoarticulo = new System.Windows.Forms.Label();
            this.btnquitararticulo = new System.Windows.Forms.Button();
            this.btnagregararticulo = new System.Windows.Forms.Button();
            this.lbstock = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnbuscararticulo = new System.Windows.Forms.Button();
            this.txtarticulo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbfecha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCodigo_postal = new System.Windows.Forms.TextBox();
            this.tbxLocalidad = new System.Windows.Forms.TextBox();
            this.tbxDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rtbxIndicaciones = new System.Windows.Forms.RichTextBox();
            this.cbxProvincia = new System.Windows.Forms.ComboBox();
            this.chxDireccion = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVehiculo = new System.Windows.Forms.Button();
            this.tbxVehiculo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridarticulo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(37, 718);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(100, 28);
            this.btnguardar.TabIndex = 83;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(155, 718);
            this.btnnuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(100, 28);
            this.btnnuevo.TabIndex = 82;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(145, 86);
            this.txtcliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.ReadOnly = true;
            this.txtcliente.Size = new System.Drawing.Size(356, 22);
            this.txtcliente.TabIndex = 79;
            // 
            // gridarticulo
            // 
            this.gridarticulo.AllowUserToAddRows = false;
            this.gridarticulo.AllowUserToDeleteRows = false;
            this.gridarticulo.AllowUserToResizeColumns = false;
            this.gridarticulo.AllowUserToResizeRows = false;
            this.gridarticulo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridarticulo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridarticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridarticulo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColDescripcion,
            this.clCantidad});
            this.gridarticulo.Location = new System.Drawing.Point(37, 447);
            this.gridarticulo.Margin = new System.Windows.Forms.Padding(4);
            this.gridarticulo.Name = "gridarticulo";
            this.gridarticulo.ReadOnly = true;
            this.gridarticulo.RowHeadersVisible = false;
            this.gridarticulo.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridarticulo.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridarticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridarticulo.Size = new System.Drawing.Size(967, 260);
            this.gridarticulo.TabIndex = 77;
            // 
            // ColCodigo
            // 
            this.ColCodigo.HeaderText = "Codigo";
            this.ColCodigo.MinimumWidth = 6;
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.ReadOnly = true;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.HeaderText = "Nombre";
            this.ColDescripcion.MinimumWidth = 6;
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.ReadOnly = true;
            // 
            // clCantidad
            // 
            this.clCantidad.HeaderText = "Cantidad";
            this.clCantidad.MinimumWidth = 6;
            this.clCantidad.Name = "clCantidad";
            this.clCantidad.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbcodigoarticulo);
            this.panel1.Controls.Add(this.btnquitararticulo);
            this.panel1.Controls.Add(this.btnagregararticulo);
            this.panel1.Controls.Add(this.lbstock);
            this.panel1.Controls.Add(this.txtcantidad);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnbuscararticulo);
            this.panel1.Controls.Add(this.txtarticulo);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(37, 280);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 145);
            this.panel1.TabIndex = 76;
            // 
            // lbcodigoarticulo
            // 
            this.lbcodigoarticulo.AutoSize = true;
            this.lbcodigoarticulo.Location = new System.Drawing.Point(86, 12);
            this.lbcodigoarticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcodigoarticulo.Name = "lbcodigoarticulo";
            this.lbcodigoarticulo.Size = new System.Drawing.Size(103, 17);
            this.lbcodigoarticulo.TabIndex = 59;
            this.lbcodigoarticulo.Text = "Codigo Articulo";
            // 
            // btnquitararticulo
            // 
            this.btnquitararticulo.Location = new System.Drawing.Point(555, 86);
            this.btnquitararticulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnquitararticulo.Name = "btnquitararticulo";
            this.btnquitararticulo.Size = new System.Drawing.Size(100, 28);
            this.btnquitararticulo.TabIndex = 33;
            this.btnquitararticulo.Text = "Quitar";
            this.btnquitararticulo.UseVisualStyleBackColor = true;
            this.btnquitararticulo.Click += new System.EventHandler(this.btnquitararticulo_Click);
            // 
            // btnagregararticulo
            // 
            this.btnagregararticulo.Location = new System.Drawing.Point(555, 37);
            this.btnagregararticulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnagregararticulo.Name = "btnagregararticulo";
            this.btnagregararticulo.Size = new System.Drawing.Size(100, 28);
            this.btnagregararticulo.TabIndex = 32;
            this.btnagregararticulo.Text = "Agregar";
            this.btnagregararticulo.UseVisualStyleBackColor = true;
            this.btnagregararticulo.Click += new System.EventHandler(this.btnagregararticulo_Click);
            // 
            // lbstock
            // 
            this.lbstock.AutoSize = true;
            this.lbstock.Location = new System.Drawing.Point(302, 94);
            this.lbstock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbstock.Name = "lbstock";
            this.lbstock.Size = new System.Drawing.Size(68, 17);
            this.lbstock.TabIndex = 27;
            this.lbstock.Text = "Cantidad:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(88, 90);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(204, 22);
            this.txtcantidad.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 93);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Cantidad :";
            // 
            // btnbuscararticulo
            // 
            this.btnbuscararticulo.Location = new System.Drawing.Point(304, 37);
            this.btnbuscararticulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnbuscararticulo.Name = "btnbuscararticulo";
            this.btnbuscararticulo.Size = new System.Drawing.Size(100, 28);
            this.btnbuscararticulo.TabIndex = 24;
            this.btnbuscararticulo.Text = "Buscar";
            this.btnbuscararticulo.UseVisualStyleBackColor = true;
            this.btnbuscararticulo.Click += new System.EventHandler(this.btnbuscararticulo_Click);
            // 
            // txtarticulo
            // 
            this.txtarticulo.BackColor = System.Drawing.Color.White;
            this.txtarticulo.Location = new System.Drawing.Point(89, 42);
            this.txtarticulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtarticulo.Name = "txtarticulo";
            this.txtarticulo.ReadOnly = true;
            this.txtarticulo.Size = new System.Drawing.Size(204, 22);
            this.txtarticulo.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 46);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Articulo :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 63;
            this.label4.Text = "Cliente :";
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Location = new System.Drawing.Point(34, 22);
            this.lbfecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(55, 17);
            this.lbfecha.TabIndex = 62;
            this.lbfecha.Text = "Fecha :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 93;
            this.label2.Text = "Código Postal";
            // 
            // tbxCodigo_postal
            // 
            this.tbxCodigo_postal.Enabled = false;
            this.tbxCodigo_postal.Location = new System.Drawing.Point(145, 237);
            this.tbxCodigo_postal.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCodigo_postal.MaxLength = 20;
            this.tbxCodigo_postal.Name = "tbxCodigo_postal";
            this.tbxCodigo_postal.Size = new System.Drawing.Size(356, 22);
            this.tbxCodigo_postal.TabIndex = 88;
            // 
            // tbxLocalidad
            // 
            this.tbxLocalidad.Enabled = false;
            this.tbxLocalidad.Location = new System.Drawing.Point(145, 175);
            this.tbxLocalidad.Margin = new System.Windows.Forms.Padding(4);
            this.tbxLocalidad.MaxLength = 100;
            this.tbxLocalidad.Name = "tbxLocalidad";
            this.tbxLocalidad.Size = new System.Drawing.Size(356, 22);
            this.tbxLocalidad.TabIndex = 85;
            // 
            // tbxDireccion
            // 
            this.tbxDireccion.Enabled = false;
            this.tbxDireccion.Location = new System.Drawing.Point(145, 207);
            this.tbxDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDireccion.MaxLength = 100;
            this.tbxDireccion.Name = "tbxDireccion";
            this.tbxDireccion.Size = new System.Drawing.Size(356, 22);
            this.tbxDireccion.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 92;
            this.label1.Text = "Província";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 91;
            this.label3.Text = "Indicaciones";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 178);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 90;
            this.label9.Text = "Localidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 210);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 89;
            this.label8.Text = "Dirección";
            // 
            // rtbxIndicaciones
            // 
            this.rtbxIndicaciones.Enabled = false;
            this.rtbxIndicaciones.Location = new System.Drawing.Point(593, 140);
            this.rtbxIndicaciones.Margin = new System.Windows.Forms.Padding(4);
            this.rtbxIndicaciones.MaxLength = 500;
            this.rtbxIndicaciones.Name = "rtbxIndicaciones";
            this.rtbxIndicaciones.Size = new System.Drawing.Size(411, 117);
            this.rtbxIndicaciones.TabIndex = 87;
            this.rtbxIndicaciones.Text = "";
            // 
            // cbxProvincia
            // 
            this.cbxProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProvincia.Enabled = false;
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
            this.cbxProvincia.Location = new System.Drawing.Point(145, 143);
            this.cbxProvincia.Margin = new System.Windows.Forms.Padding(4);
            this.cbxProvincia.Name = "cbxProvincia";
            this.cbxProvincia.Size = new System.Drawing.Size(356, 24);
            this.cbxProvincia.TabIndex = 84;
            // 
            // chxDireccion
            // 
            this.chxDireccion.AutoSize = true;
            this.chxDireccion.Location = new System.Drawing.Point(145, 115);
            this.chxDireccion.Name = "chxDireccion";
            this.chxDireccion.Size = new System.Drawing.Size(153, 21);
            this.chxDireccion.TabIndex = 94;
            this.chxDireccion.Text = "Usar Otra direccion";
            this.chxDireccion.UseVisualStyleBackColor = true;
            this.chxDireccion.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(659, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 98;
            this.label5.Text = "Codigo Vehiculo:";
            // 
            // btnVehiculo
            // 
            this.btnVehiculo.Location = new System.Drawing.Point(904, 53);
            this.btnVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.btnVehiculo.Name = "btnVehiculo";
            this.btnVehiculo.Size = new System.Drawing.Size(100, 28);
            this.btnVehiculo.TabIndex = 97;
            this.btnVehiculo.Text = "Buscar";
            this.btnVehiculo.UseVisualStyleBackColor = true;
            this.btnVehiculo.Click += new System.EventHandler(this.btnVehiculo_Click);
            // 
            // tbxVehiculo
            // 
            this.tbxVehiculo.BackColor = System.Drawing.Color.White;
            this.tbxVehiculo.Location = new System.Drawing.Point(662, 53);
            this.tbxVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.tbxVehiculo.Name = "tbxVehiculo";
            this.tbxVehiculo.ReadOnly = true;
            this.tbxVehiculo.Size = new System.Drawing.Size(233, 22);
            this.tbxVehiculo.TabIndex = 96;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(590, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 95;
            this.label6.Text = "Vehiculo :";
            // 
            // RegistroTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 762);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVehiculo);
            this.Controls.Add(this.tbxVehiculo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chxDireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxCodigo_postal);
            this.Controls.Add(this.tbxLocalidad);
            this.Controls.Add(this.tbxDireccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rtbxIndicaciones);
            this.Controls.Add(this.cbxProvincia);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.gridarticulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbfecha);
            this.Name = "RegistroTransporte";
            this.Text = "RegistroTransporte";
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridarticulo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbcodigoarticulo;
        private System.Windows.Forms.Button btnquitararticulo;
        private System.Windows.Forms.Button btnagregararticulo;
        private System.Windows.Forms.Label lbstock;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnbuscararticulo;
        private System.Windows.Forms.TextBox txtarticulo;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbxCodigo_postal;
        public System.Windows.Forms.TextBox tbxLocalidad;
        public System.Windows.Forms.TextBox tbxDireccion;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.RichTextBox rtbxIndicaciones;
        public System.Windows.Forms.ComboBox cbxProvincia;
        public System.Windows.Forms.Button btnguardar;
        public System.Windows.Forms.Button btnnuevo;
        public System.Windows.Forms.TextBox txtcliente;
        public System.Windows.Forms.DataGridView gridarticulo;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCantidad;
        private System.Windows.Forms.CheckBox chxDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVehiculo;
        private System.Windows.Forms.TextBox tbxVehiculo;
        private System.Windows.Forms.Label label6;
    }
}