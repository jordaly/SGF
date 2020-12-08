namespace SGF
{
    partial class FrmVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.lbcodigo = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.gridarticulo = new System.Windows.Forms.DataGridView();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clitebis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtitebis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbcodigoarticulo = new System.Windows.Forms.Label();
            this.btnquitararticulo = new System.Windows.Forms.Button();
            this.btnagregararticulo = new System.Windows.Forms.Button();
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lbstock = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnbuscararticulo = new System.Windows.Forms.Button();
            this.txtarticulo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxsucursal = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxdivisa = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxtipopago = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnbuscarcliente = new System.Windows.Forms.Button();
            this.lbnumfactura = new System.Windows.Forms.Label();
            this.txtrnc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxtipofactura = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbfecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxtipo_ncf = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridarticulo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(757, 626);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 57;
            this.btnguardar.Text = "guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(757, 568);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 56;
            this.btnnuevo.Text = "nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.Color.White;
            this.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttotal.Location = new System.Drawing.Point(573, 663);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(130, 13);
            this.txttotal.TabIndex = 55;
            this.txttotal.Text = "total";
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbcodigo
            // 
            this.lbcodigo.AutoSize = true;
            this.lbcodigo.Location = new System.Drawing.Point(131, 159);
            this.lbcodigo.Name = "lbcodigo";
            this.lbcodigo.Size = new System.Drawing.Size(75, 13);
            this.lbcodigo.TabIndex = 54;
            this.lbcodigo.Text = "Codigo Cliente";
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(129, 178);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.ReadOnly = true;
            this.txtcliente.Size = new System.Drawing.Size(200, 20);
            this.txtcliente.TabIndex = 53;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(530, 663);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 52;
            this.label15.Text = "Total :";
            // 
            // gridarticulo
            // 
            this.gridarticulo.AllowUserToAddRows = false;
            this.gridarticulo.AllowUserToDeleteRows = false;
            this.gridarticulo.AllowUserToResizeColumns = false;
            this.gridarticulo.AllowUserToResizeRows = false;
            this.gridarticulo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridarticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridarticulo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColDescripcion,
            this.ColPrecio,
            this.clitebis,
            this.ColCantidad,
            this.ColImporte});
            this.gridarticulo.Location = new System.Drawing.Point(26, 438);
            this.gridarticulo.Name = "gridarticulo";
            this.gridarticulo.ReadOnly = true;
            this.gridarticulo.RowHeadersVisible = false;
            this.gridarticulo.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridarticulo.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridarticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridarticulo.Size = new System.Drawing.Size(725, 211);
            this.gridarticulo.TabIndex = 51;
            // 
            // ColCodigo
            // 
            this.ColCodigo.HeaderText = "Codigo";
            this.ColCodigo.MinimumWidth = 6;
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.ReadOnly = true;
            this.ColCodigo.Width = 110;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.HeaderText = "Descripcion";
            this.ColDescripcion.MinimumWidth = 6;
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.ReadOnly = true;
            this.ColDescripcion.Width = 200;
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.MinimumWidth = 6;
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            this.ColPrecio.Width = 110;
            // 
            // clitebis
            // 
            this.clitebis.HeaderText = "ITEBIS";
            this.clitebis.MinimumWidth = 6;
            this.clitebis.Name = "clitebis";
            this.clitebis.ReadOnly = true;
            this.clitebis.Width = 125;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.MinimumWidth = 6;
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.ReadOnly = true;
            this.ColCantidad.Width = 110;
            // 
            // ColImporte
            // 
            this.ColImporte.HeaderText = "Importe";
            this.ColImporte.MinimumWidth = 6;
            this.ColImporte.Name = "ColImporte";
            this.ColImporte.ReadOnly = true;
            this.ColImporte.Width = 110;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtitebis);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbcodigoarticulo);
            this.panel1.Controls.Add(this.btnquitararticulo);
            this.panel1.Controls.Add(this.btnagregararticulo);
            this.panel1.Controls.Add(this.txtprecioventa);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.lbstock);
            this.panel1.Controls.Add(this.txtcantidad);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnbuscararticulo);
            this.panel1.Controls.Add(this.txtarticulo);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(26, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 118);
            this.panel1.TabIndex = 50;
            // 
            // txtitebis
            // 
            this.txtitebis.BackColor = System.Drawing.Color.White;
            this.txtitebis.Location = new System.Drawing.Point(416, 74);
            this.txtitebis.Name = "txtitebis";
            this.txtitebis.ReadOnly = true;
            this.txtitebis.Size = new System.Drawing.Size(154, 20);
            this.txtitebis.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "ITEBIS :";
            // 
            // lbcodigoarticulo
            // 
            this.lbcodigoarticulo.AutoSize = true;
            this.lbcodigoarticulo.Location = new System.Drawing.Point(64, 18);
            this.lbcodigoarticulo.Name = "lbcodigoarticulo";
            this.lbcodigoarticulo.Size = new System.Drawing.Size(78, 13);
            this.lbcodigoarticulo.TabIndex = 59;
            this.lbcodigoarticulo.Text = "Codigo Articulo";
            // 
            // btnquitararticulo
            // 
            this.btnquitararticulo.Location = new System.Drawing.Point(635, 69);
            this.btnquitararticulo.Name = "btnquitararticulo";
            this.btnquitararticulo.Size = new System.Drawing.Size(75, 23);
            this.btnquitararticulo.TabIndex = 33;
            this.btnquitararticulo.Text = "Quitar";
            this.btnquitararticulo.UseVisualStyleBackColor = true;
            this.btnquitararticulo.Click += new System.EventHandler(this.btnquitararticulo_Click);
            // 
            // btnagregararticulo
            // 
            this.btnagregararticulo.Location = new System.Drawing.Point(635, 27);
            this.btnagregararticulo.Name = "btnagregararticulo";
            this.btnagregararticulo.Size = new System.Drawing.Size(75, 23);
            this.btnagregararticulo.TabIndex = 32;
            this.btnagregararticulo.Text = "Agregar";
            this.btnagregararticulo.UseVisualStyleBackColor = true;
            this.btnagregararticulo.Click += new System.EventHandler(this.btnagregararticulo_Click);
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.BackColor = System.Drawing.Color.White;
            this.txtprecioventa.Location = new System.Drawing.Point(416, 34);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.ReadOnly = true;
            this.txtprecioventa.Size = new System.Drawing.Size(154, 20);
            this.txtprecioventa.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(328, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Precio Venta :";
            // 
            // lbstock
            // 
            this.lbstock.AutoSize = true;
            this.lbstock.Location = new System.Drawing.Point(227, 74);
            this.lbstock.Name = "lbstock";
            this.lbstock.Size = new System.Drawing.Size(35, 13);
            this.lbstock.TabIndex = 27;
            this.lbstock.Text = "Stock";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(67, 71);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(154, 20);
            this.txtcantidad.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Cantidad :";
            // 
            // btnbuscararticulo
            // 
            this.btnbuscararticulo.Location = new System.Drawing.Point(228, 30);
            this.btnbuscararticulo.Name = "btnbuscararticulo";
            this.btnbuscararticulo.Size = new System.Drawing.Size(75, 23);
            this.btnbuscararticulo.TabIndex = 24;
            this.btnbuscararticulo.Text = "Buscar";
            this.btnbuscararticulo.UseVisualStyleBackColor = true;
            this.btnbuscararticulo.Click += new System.EventHandler(this.btnbuscararticulo_Click);
            // 
            // txtarticulo
            // 
            this.txtarticulo.BackColor = System.Drawing.Color.White;
            this.txtarticulo.Location = new System.Drawing.Point(67, 34);
            this.txtarticulo.Name = "txtarticulo";
            this.txtarticulo.ReadOnly = true;
            this.txtarticulo.Size = new System.Drawing.Size(154, 20);
            this.txtarticulo.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Articulo :";
            // 
            // cbxsucursal
            // 
            this.cbxsucursal.BackColor = System.Drawing.Color.White;
            this.cbxsucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxsucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxsucursal.FormattingEnabled = true;
            this.cbxsucursal.Items.AddRange(new object[] {
            "Cliente Final (Contado)",
            "Comprabante Fiscal"});
            this.cbxsucursal.Location = new System.Drawing.Point(427, 73);
            this.cbxsucursal.Name = "cbxsucursal";
            this.cbxsucursal.Size = new System.Drawing.Size(204, 21);
            this.cbxsucursal.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(348, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Sucursal :";
            // 
            // cbxdivisa
            // 
            this.cbxdivisa.FormattingEnabled = true;
            this.cbxdivisa.Items.AddRange(new object[] {
            "Cliente Final (Contado)",
            "Comprabante Fiscal"});
            this.cbxdivisa.Location = new System.Drawing.Point(397, 249);
            this.cbxdivisa.Name = "cbxdivisa";
            this.cbxdivisa.Size = new System.Drawing.Size(141, 21);
            this.cbxdivisa.TabIndex = 47;
            this.cbxdivisa.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(349, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Divisa :";
            this.label8.Visible = false;
            // 
            // cbxtipopago
            // 
            this.cbxtipopago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxtipopago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxtipopago.FormattingEnabled = true;
            this.cbxtipopago.Items.AddRange(new object[] {
            "Cliente Final (Contado)",
            "Comprabante Fiscal"});
            this.cbxtipopago.Location = new System.Drawing.Point(130, 246);
            this.cbxtipopago.Name = "cbxtipopago";
            this.cbxtipopago.Size = new System.Drawing.Size(199, 21);
            this.cbxtipopago.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Tipo de Pago :";
            // 
            // btnbuscarcliente
            // 
            this.btnbuscarcliente.Location = new System.Drawing.Point(335, 176);
            this.btnbuscarcliente.Name = "btnbuscarcliente";
            this.btnbuscarcliente.Size = new System.Drawing.Size(75, 23);
            this.btnbuscarcliente.TabIndex = 43;
            this.btnbuscarcliente.Text = "Buscar";
            this.btnbuscarcliente.UseVisualStyleBackColor = true;
            this.btnbuscarcliente.Click += new System.EventHandler(this.btnbuscarcliente_Click);
            // 
            // lbnumfactura
            // 
            this.lbnumfactura.AutoSize = true;
            this.lbnumfactura.Location = new System.Drawing.Point(127, 70);
            this.lbnumfactura.Name = "lbnumfactura";
            this.lbnumfactura.Size = new System.Drawing.Size(61, 13);
            this.lbnumfactura.TabIndex = 42;
            this.lbnumfactura.Text = "000000001";
            // 
            // txtrnc
            // 
            this.txtrnc.Location = new System.Drawing.Point(130, 209);
            this.txtrnc.Name = "txtrnc";
            this.txtrnc.ReadOnly = true;
            this.txtrnc.Size = new System.Drawing.Size(200, 20);
            this.txtrnc.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "RNC (NCF) :";
            // 
            // cbxtipofactura
            // 
            this.cbxtipofactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxtipofactura.FormattingEnabled = true;
            this.cbxtipofactura.Location = new System.Drawing.Point(130, 116);
            this.cbxtipofactura.Name = "cbxtipofactura";
            this.cbxtipofactura.Size = new System.Drawing.Size(199, 21);
            this.cbxtipofactura.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tipo de Factura :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Cliente :";
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Location = new System.Drawing.Point(21, 25);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(43, 13);
            this.lbfecha.TabIndex = 34;
            this.lbfecha.Text = "Fecha :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Numero Factura :";
            // 
            // cbxtipo_ncf
            // 
            this.cbxtipo_ncf.BackColor = System.Drawing.Color.White;
            this.cbxtipo_ncf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxtipo_ncf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxtipo_ncf.FormattingEnabled = true;
            this.cbxtipo_ncf.Location = new System.Drawing.Point(427, 116);
            this.cbxtipo_ncf.Name = "cbxtipo_ncf";
            this.cbxtipo_ncf.Size = new System.Drawing.Size(204, 21);
            this.cbxtipo_ncf.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Tipo de RNC :";
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(873, 729);
            this.Controls.Add(this.cbxtipo_ncf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.lbcodigo);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.gridarticulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbxsucursal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxdivisa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxtipopago);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnbuscarcliente);
            this.Controls.Add(this.lbnumfactura);
            this.Controls.Add(this.txtrnc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxtipofactura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbfecha);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridarticulo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label lbcodigo;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView gridarticulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnquitararticulo;
        private System.Windows.Forms.Button btnagregararticulo;
        private System.Windows.Forms.TextBox txtprecioventa;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbstock;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnbuscararticulo;
        private System.Windows.Forms.TextBox txtarticulo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxsucursal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxdivisa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxtipopago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnbuscarcliente;
        private System.Windows.Forms.Label lbnumfactura;
        private System.Windows.Forms.TextBox txtrnc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxtipofactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbcodigoarticulo;
        private System.Windows.Forms.TextBox txtitebis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clitebis;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColImporte;
        private System.Windows.Forms.ComboBox cbxtipo_ncf;
        private System.Windows.Forms.Label label2;
    }
}