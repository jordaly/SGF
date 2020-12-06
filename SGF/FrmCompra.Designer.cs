namespace SGF
{
    partial class FrmCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbcodigosuplidor = new System.Windows.Forms.Label();
            this.txtsuplidor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtitebis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbcodigoarticulo = new System.Windows.Forms.Label();
            this.btnquitararticulo = new System.Windows.Forms.Button();
            this.btnagregararticulo = new System.Windows.Forms.Button();
            this.txtpreciocompra = new System.Windows.Forms.TextBox();
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
            this.btnbuscarsuplidor = new System.Windows.Forms.Button();
            this.lbnumfactura = new System.Windows.Forms.Label();
            this.txtrnc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxtipofactura = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnagregarrnc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbfecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.gridarticulosuplidor = new System.Windows.Forms.DataGridView();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clitebis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridarticulosuplidor)).BeginInit();
            this.SuspendLayout();
            // 
            // lbcodigosuplidor
            // 
            this.lbcodigosuplidor.AutoSize = true;
            this.lbcodigosuplidor.Location = new System.Drawing.Point(146, 162);
            this.lbcodigosuplidor.Name = "lbcodigosuplidor";
            this.lbcodigosuplidor.Size = new System.Drawing.Size(81, 13);
            this.lbcodigosuplidor.TabIndex = 73;
            this.lbcodigosuplidor.Text = "Codigo Suplidor";
            // 
            // txtsuplidor
            // 
            this.txtsuplidor.Location = new System.Drawing.Point(144, 181);
            this.txtsuplidor.Name = "txtsuplidor";
            this.txtsuplidor.Size = new System.Drawing.Size(200, 20);
            this.txtsuplidor.TabIndex = 72;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtitebis);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbcodigoarticulo);
            this.panel1.Controls.Add(this.btnquitararticulo);
            this.panel1.Controls.Add(this.btnagregararticulo);
            this.panel1.Controls.Add(this.txtpreciocompra);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.lbstock);
            this.panel1.Controls.Add(this.txtcantidad);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnbuscararticulo);
            this.panel1.Controls.Add(this.txtarticulo);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(41, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 118);
            this.panel1.TabIndex = 71;
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
            // txtpreciocompra
            // 
            this.txtpreciocompra.BackColor = System.Drawing.Color.White;
            this.txtpreciocompra.Location = new System.Drawing.Point(416, 34);
            this.txtpreciocompra.Name = "txtpreciocompra";
            this.txtpreciocompra.ReadOnly = true;
            this.txtpreciocompra.Size = new System.Drawing.Size(154, 20);
            this.txtpreciocompra.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(328, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Precio Compra :";
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
            this.cbxsucursal.FormattingEnabled = true;
            this.cbxsucursal.Items.AddRange(new object[] {
            "Cliente Final (Contado)",
            "Comprabante Fiscal"});
            this.cbxsucursal.Location = new System.Drawing.Point(422, 73);
            this.cbxsucursal.Name = "cbxsucursal";
            this.cbxsucursal.Size = new System.Drawing.Size(130, 21);
            this.cbxsucursal.TabIndex = 70;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(363, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 69;
            this.label9.Text = "Sucursal :";
            // 
            // cbxdivisa
            // 
            this.cbxdivisa.FormattingEnabled = true;
            this.cbxdivisa.Items.AddRange(new object[] {
            "Cliente Final (Contado)",
            "Comprabante Fiscal"});
            this.cbxdivisa.Location = new System.Drawing.Point(412, 252);
            this.cbxdivisa.Name = "cbxdivisa";
            this.cbxdivisa.Size = new System.Drawing.Size(141, 21);
            this.cbxdivisa.TabIndex = 68;
            this.cbxdivisa.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(364, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Divisa :";
            this.label8.Visible = false;
            // 
            // cbxtipopago
            // 
            this.cbxtipopago.FormattingEnabled = true;
            this.cbxtipopago.Items.AddRange(new object[] {
            "Cliente Final (Contado)",
            "Comprabante Fiscal"});
            this.cbxtipopago.Location = new System.Drawing.Point(145, 249);
            this.cbxtipopago.Name = "cbxtipopago";
            this.cbxtipopago.Size = new System.Drawing.Size(199, 21);
            this.cbxtipopago.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Tipo de Pago :";
            // 
            // btnbuscarsuplidor
            // 
            this.btnbuscarsuplidor.Location = new System.Drawing.Point(350, 179);
            this.btnbuscarsuplidor.Name = "btnbuscarsuplidor";
            this.btnbuscarsuplidor.Size = new System.Drawing.Size(75, 23);
            this.btnbuscarsuplidor.TabIndex = 64;
            this.btnbuscarsuplidor.Text = "Buscar";
            this.btnbuscarsuplidor.UseVisualStyleBackColor = true;
            this.btnbuscarsuplidor.Click += new System.EventHandler(this.btnbuscarsuplidor_Click);
            // 
            // lbnumfactura
            // 
            this.lbnumfactura.AutoSize = true;
            this.lbnumfactura.Location = new System.Drawing.Point(142, 73);
            this.lbnumfactura.Name = "lbnumfactura";
            this.lbnumfactura.Size = new System.Drawing.Size(61, 13);
            this.lbnumfactura.TabIndex = 63;
            this.lbnumfactura.Text = "000000001";
            // 
            // txtrnc
            // 
            this.txtrnc.Location = new System.Drawing.Point(145, 212);
            this.txtrnc.Name = "txtrnc";
            this.txtrnc.Size = new System.Drawing.Size(200, 20);
            this.txtrnc.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "RNC (NCF) :";
            // 
            // cbxtipofactura
            // 
            this.cbxtipofactura.FormattingEnabled = true;
            this.cbxtipofactura.Items.AddRange(new object[] {
            "Cliente Final (Contado)",
            "Comprabante Fiscal"});
            this.cbxtipofactura.Location = new System.Drawing.Point(145, 119);
            this.cbxtipofactura.Name = "cbxtipofactura";
            this.cbxtipofactura.Size = new System.Drawing.Size(199, 21);
            this.cbxtipofactura.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Tipo de Factura :";
            // 
            // btnagregarrnc
            // 
            this.btnagregarrnc.Location = new System.Drawing.Point(350, 209);
            this.btnagregarrnc.Name = "btnagregarrnc";
            this.btnagregarrnc.Size = new System.Drawing.Size(75, 23);
            this.btnagregarrnc.TabIndex = 58;
            this.btnagregarrnc.Text = "Agregar";
            this.btnagregarrnc.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Suplidor :";
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Location = new System.Drawing.Point(36, 28);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(43, 13);
            this.lbfecha.TabIndex = 56;
            this.lbfecha.Text = "Fecha :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Numero Factura :";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(772, 617);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 78;
            this.btnguardar.Text = "guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(772, 559);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 77;
            this.btnnuevo.Text = "nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.Color.White;
            this.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttotal.Location = new System.Drawing.Point(636, 655);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(130, 13);
            this.txttotal.TabIndex = 76;
            this.txttotal.Text = "total";
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(603, 655);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 75;
            this.label15.Text = "Total :";
            // 
            // gridarticulosuplidor
            // 
            this.gridarticulosuplidor.AllowUserToAddRows = false;
            this.gridarticulosuplidor.AllowUserToDeleteRows = false;
            this.gridarticulosuplidor.AllowUserToResizeColumns = false;
            this.gridarticulosuplidor.AllowUserToResizeRows = false;
            this.gridarticulosuplidor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridarticulosuplidor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridarticulosuplidor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColDescripcion,
            this.ColPrecio,
            this.clitebis,
            this.ColCantidad,
            this.ColImporte});
            this.gridarticulosuplidor.Location = new System.Drawing.Point(41, 429);
            this.gridarticulosuplidor.Name = "gridarticulosuplidor";
            this.gridarticulosuplidor.ReadOnly = true;
            this.gridarticulosuplidor.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridarticulosuplidor.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridarticulosuplidor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridarticulosuplidor.Size = new System.Drawing.Size(725, 211);
            this.gridarticulosuplidor.TabIndex = 74;
            // 
            // ColCodigo
            // 
            this.ColCodigo.HeaderText = "Codigo";
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.ReadOnly = true;
            this.ColCodigo.Width = 110;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.HeaderText = "Descripcion";
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.ReadOnly = true;
            this.ColDescripcion.Width = 200;
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio Compra";
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            this.ColPrecio.Width = 110;
            // 
            // clitebis
            // 
            this.clitebis.HeaderText = "ITEBIS";
            this.clitebis.Name = "clitebis";
            this.clitebis.ReadOnly = true;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.ReadOnly = true;
            this.ColCantidad.Width = 110;
            // 
            // ColImporte
            // 
            this.ColImporte.HeaderText = "Importe";
            this.ColImporte.Name = "ColImporte";
            this.ColImporte.ReadOnly = true;
            this.ColImporte.Width = 110;
            // 
            // FrmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 732);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.gridarticulosuplidor);
            this.Controls.Add(this.lbcodigosuplidor);
            this.Controls.Add(this.txtsuplidor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbxsucursal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxdivisa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxtipopago);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnbuscarsuplidor);
            this.Controls.Add(this.lbnumfactura);
            this.Controls.Add(this.txtrnc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxtipofactura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnagregarrnc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbfecha);
            this.Controls.Add(this.label1);
            this.Name = "FrmCompra";
            this.Text = "FrmCompra";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridarticulosuplidor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbcodigosuplidor;
        private System.Windows.Forms.TextBox txtsuplidor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtitebis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbcodigoarticulo;
        private System.Windows.Forms.Button btnquitararticulo;
        private System.Windows.Forms.Button btnagregararticulo;
        private System.Windows.Forms.TextBox txtpreciocompra;
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
        private System.Windows.Forms.Button btnbuscarsuplidor;
        private System.Windows.Forms.Label lbnumfactura;
        private System.Windows.Forms.TextBox txtrnc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxtipofactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnagregarrnc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView gridarticulosuplidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clitebis;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColImporte;
    }
}