namespace SGF
{
    partial class FrmCotizacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbcodigo = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbstock = new System.Windows.Forms.Label();
            this.txtitebis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lbcodigoarticulo = new System.Windows.Forms.Label();
            this.btnquitararticulo = new System.Windows.Forms.Button();
            this.btnagregararticulo = new System.Windows.Forms.Button();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnbuscararticulo = new System.Windows.Forms.Button();
            this.txtarticulo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnbuscarcliente = new System.Windows.Forms.Button();
            this.txtrnc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxtipofactura = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbfecha = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.gridcotizacion = new System.Windows.Forms.DataGridView();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clItebis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxsucursal = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcotizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lbcodigo
            // 
            this.lbcodigo.AutoSize = true;
            this.lbcodigo.Location = new System.Drawing.Point(140, 122);
            this.lbcodigo.Name = "lbcodigo";
            this.lbcodigo.Size = new System.Drawing.Size(75, 13);
            this.lbcodigo.TabIndex = 89;
            this.lbcodigo.Text = "Codigo Cliente";
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(138, 141);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(200, 20);
            this.txtcliente.TabIndex = 88;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbstock);
            this.panel1.Controls.Add(this.txtitebis);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtprecioventa);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.lbcodigoarticulo);
            this.panel1.Controls.Add(this.btnquitararticulo);
            this.panel1.Controls.Add(this.btnagregararticulo);
            this.panel1.Controls.Add(this.txtcantidad);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnbuscararticulo);
            this.panel1.Controls.Add(this.txtarticulo);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(34, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 118);
            this.panel1.TabIndex = 87;
            // 
            // lbstock
            // 
            this.lbstock.AutoSize = true;
            this.lbstock.Location = new System.Drawing.Point(227, 76);
            this.lbstock.Name = "lbstock";
            this.lbstock.Size = new System.Drawing.Size(35, 13);
            this.lbstock.TabIndex = 66;
            this.lbstock.Text = "Stock";
            // 
            // txtitebis
            // 
            this.txtitebis.BackColor = System.Drawing.Color.White;
            this.txtitebis.Location = new System.Drawing.Point(426, 73);
            this.txtitebis.Name = "txtitebis";
            this.txtitebis.ReadOnly = true;
            this.txtitebis.Size = new System.Drawing.Size(154, 20);
            this.txtitebis.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "ITEBIS :";
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.BackColor = System.Drawing.Color.White;
            this.txtprecioventa.Location = new System.Drawing.Point(426, 33);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.ReadOnly = true;
            this.txtprecioventa.Size = new System.Drawing.Size(154, 20);
            this.txtprecioventa.TabIndex = 63;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(338, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 62;
            this.label14.Text = "Precio Venta :";
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
            // btnbuscarcliente
            // 
            this.btnbuscarcliente.Location = new System.Drawing.Point(344, 139);
            this.btnbuscarcliente.Name = "btnbuscarcliente";
            this.btnbuscarcliente.Size = new System.Drawing.Size(75, 23);
            this.btnbuscarcliente.TabIndex = 82;
            this.btnbuscarcliente.Text = "Buscar";
            this.btnbuscarcliente.UseVisualStyleBackColor = true;
            this.btnbuscarcliente.Click += new System.EventHandler(this.btnbuscarcliente_Click);
            // 
            // txtrnc
            // 
            this.txtrnc.BackColor = System.Drawing.Color.White;
            this.txtrnc.Location = new System.Drawing.Point(139, 172);
            this.txtrnc.Name = "txtrnc";
            this.txtrnc.ReadOnly = true;
            this.txtrnc.Size = new System.Drawing.Size(200, 20);
            this.txtrnc.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "RNC (NCF) :";
            // 
            // cbxtipofactura
            // 
            this.cbxtipofactura.FormattingEnabled = true;
            this.cbxtipofactura.Items.AddRange(new object[] {
            "Cliente Final (Contado)",
            "Comprabante Fiscal"});
            this.cbxtipofactura.Location = new System.Drawing.Point(139, 79);
            this.cbxtipofactura.Name = "cbxtipofactura";
            this.cbxtipofactura.Size = new System.Drawing.Size(199, 21);
            this.cbxtipofactura.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Tipo de Factura :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Cliente :";
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Location = new System.Drawing.Point(36, 28);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(43, 13);
            this.lbfecha.TabIndex = 75;
            this.lbfecha.Text = "Fecha :";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(765, 559);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 94;
            this.btnguardar.Text = "guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(765, 501);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 93;
            this.btnnuevo.Text = "nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.Color.White;
            this.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttotal.Location = new System.Drawing.Point(629, 597);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(130, 13);
            this.txttotal.TabIndex = 92;
            this.txttotal.Text = "total";
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(596, 597);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 91;
            this.label15.Text = "Total :";
            // 
            // gridcotizacion
            // 
            this.gridcotizacion.AllowUserToAddRows = false;
            this.gridcotizacion.AllowUserToDeleteRows = false;
            this.gridcotizacion.AllowUserToResizeColumns = false;
            this.gridcotizacion.AllowUserToResizeRows = false;
            this.gridcotizacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridcotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridcotizacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColDescripcion,
            this.ColPrecio,
            this.clItebis,
            this.ColCantidad,
            this.ColImporte});
            this.gridcotizacion.Location = new System.Drawing.Point(34, 371);
            this.gridcotizacion.Name = "gridcotizacion";
            this.gridcotizacion.ReadOnly = true;
            this.gridcotizacion.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridcotizacion.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridcotizacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridcotizacion.Size = new System.Drawing.Size(725, 211);
            this.gridcotizacion.TabIndex = 90;
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
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            this.ColPrecio.Width = 110;
            // 
            // clItebis
            // 
            this.clItebis.HeaderText = "ITEBIS";
            this.clItebis.Name = "clItebis";
            this.clItebis.ReadOnly = true;
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
            // cbxsucursal
            // 
            this.cbxsucursal.BackColor = System.Drawing.Color.White;
            this.cbxsucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxsucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxsucursal.FormattingEnabled = true;
            this.cbxsucursal.Items.AddRange(new object[] {
            "Cliente Final (Contado)",
            "Comprabante Fiscal"});
            this.cbxsucursal.Location = new System.Drawing.Point(411, 79);
            this.cbxsucursal.Name = "cbxsucursal";
            this.cbxsucursal.Size = new System.Drawing.Size(204, 21);
            this.cbxsucursal.TabIndex = 96;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(351, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 95;
            this.label9.Text = "Sucursal :";
            // 
            // FrmCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 642);
            this.Controls.Add(this.cbxsucursal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.gridcotizacion);
            this.Controls.Add(this.lbcodigo);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnbuscarcliente);
            this.Controls.Add(this.txtrnc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxtipofactura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbfecha);
            this.Name = "FrmCotizacion";
            this.Text = "FrmCotizacion";
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcotizacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbcodigo;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbcodigoarticulo;
        private System.Windows.Forms.Button btnquitararticulo;
        private System.Windows.Forms.Button btnagregararticulo;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnbuscararticulo;
        private System.Windows.Forms.TextBox txtarticulo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnbuscarcliente;
        private System.Windows.Forms.TextBox txtrnc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxtipofactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView gridcotizacion;
        private System.Windows.Forms.ComboBox cbxsucursal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtitebis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtprecioventa;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clItebis;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColImporte;
        private System.Windows.Forms.Label lbstock;
    }
}