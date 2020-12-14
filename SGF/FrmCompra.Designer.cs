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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbcodigoarticulo = new System.Windows.Forms.Label();
            this.txtpreciocompra = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtarticulo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.gridarticulosuplidor = new System.Windows.Forms.DataGridView();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbcodigosuplidor = new System.Windows.Forms.Label();
            this.txtsuplidor = new System.Windows.Forms.TextBox();
            this.cbxdivisa = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxtipopago = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbnumfactura = new System.Windows.Forms.Label();
            this.txtrnc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxtipofactura = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbfecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbuscarsuplidor = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnquitararticulo = new System.Windows.Forms.Button();
            this.btnagregararticulo = new System.Windows.Forms.Button();
            this.btnbuscararticulo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridarticulosuplidor)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbcodigoarticulo);
            this.panel1.Controls.Add(this.btnquitararticulo);
            this.panel1.Controls.Add(this.btnagregararticulo);
            this.panel1.Controls.Add(this.txtpreciocompra);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtcantidad);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnbuscararticulo);
            this.panel1.Controls.Add(this.txtarticulo);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(12, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 118);
            this.panel1.TabIndex = 71;
            // 
            // lbcodigoarticulo
            // 
            this.lbcodigoarticulo.AutoSize = true;
            this.lbcodigoarticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcodigoarticulo.Location = new System.Drawing.Point(94, 9);
            this.lbcodigoarticulo.Name = "lbcodigoarticulo";
            this.lbcodigoarticulo.Size = new System.Drawing.Size(99, 16);
            this.lbcodigoarticulo.TabIndex = 59;
            this.lbcodigoarticulo.Text = "Codigo Articulo";
            // 
            // txtpreciocompra
            // 
            this.txtpreciocompra.BackColor = System.Drawing.Color.White;
            this.txtpreciocompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpreciocompra.Location = new System.Drawing.Point(443, 37);
            this.txtpreciocompra.Name = "txtpreciocompra";
            this.txtpreciocompra.ReadOnly = true;
            this.txtpreciocompra.Size = new System.Drawing.Size(154, 22);
            this.txtpreciocompra.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(319, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 16);
            this.label14.TabIndex = 30;
            this.label14.Text = "Precio Compra :";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Location = new System.Drawing.Point(97, 70);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(154, 22);
            this.txtcantidad.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Cantidad :";
            // 
            // txtarticulo
            // 
            this.txtarticulo.BackColor = System.Drawing.Color.White;
            this.txtarticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtarticulo.Location = new System.Drawing.Point(97, 37);
            this.txtarticulo.Name = "txtarticulo";
            this.txtarticulo.ReadOnly = true;
            this.txtarticulo.Size = new System.Drawing.Size(154, 22);
            this.txtarticulo.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Articulo :";
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(588, 592);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(130, 22);
            this.txttotal.TabIndex = 76;
            this.txttotal.Text = "total";
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(523, 592);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 20);
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
            this.gridarticulosuplidor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridarticulosuplidor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridarticulosuplidor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridarticulosuplidor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColDescripcion,
            this.ColPrecio,
            this.ColCantidad,
            this.ColImporte});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridarticulosuplidor.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridarticulosuplidor.Location = new System.Drawing.Point(12, 366);
            this.gridarticulosuplidor.Name = "gridarticulosuplidor";
            this.gridarticulosuplidor.ReadOnly = true;
            this.gridarticulosuplidor.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridarticulosuplidor.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridarticulosuplidor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridarticulosuplidor.Size = new System.Drawing.Size(706, 211);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.lbcodigosuplidor);
            this.panel2.Controls.Add(this.txtsuplidor);
            this.panel2.Controls.Add(this.cbxdivisa);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cbxtipopago);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnbuscarsuplidor);
            this.panel2.Controls.Add(this.lbnumfactura);
            this.panel2.Controls.Add(this.txtrnc);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbxtipofactura);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbfecha);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 196);
            this.panel2.TabIndex = 79;
            // 
            // lbcodigosuplidor
            // 
            this.lbcodigosuplidor.AutoSize = true;
            this.lbcodigosuplidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcodigosuplidor.Location = new System.Drawing.Point(487, 39);
            this.lbcodigosuplidor.Name = "lbcodigosuplidor";
            this.lbcodigosuplidor.Size = new System.Drawing.Size(120, 16);
            this.lbcodigosuplidor.TabIndex = 88;
            this.lbcodigosuplidor.Text = "Codigo Suplidor";
            // 
            // txtsuplidor
            // 
            this.txtsuplidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsuplidor.Location = new System.Drawing.Point(485, 58);
            this.txtsuplidor.Name = "txtsuplidor";
            this.txtsuplidor.Size = new System.Drawing.Size(200, 22);
            this.txtsuplidor.TabIndex = 87;
            // 
            // cbxdivisa
            // 
            this.cbxdivisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxdivisa.FormattingEnabled = true;
            this.cbxdivisa.Items.AddRange(new object[] {
            "Cliente Final (Contado)",
            "Comprabante Fiscal"});
            this.cbxdivisa.Location = new System.Drawing.Point(485, 150);
            this.cbxdivisa.Name = "cbxdivisa";
            this.cbxdivisa.Size = new System.Drawing.Size(141, 24);
            this.cbxdivisa.TabIndex = 86;
            this.cbxdivisa.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(380, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 85;
            this.label8.Text = "Divisa :";
            this.label8.Visible = false;
            // 
            // cbxtipopago
            // 
            this.cbxtipopago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxtipopago.FormattingEnabled = true;
            this.cbxtipopago.Items.AddRange(new object[] {
            "Cliente Final (Contado)",
            "Comprabante Fiscal"});
            this.cbxtipopago.Location = new System.Drawing.Point(159, 150);
            this.cbxtipopago.Name = "cbxtipopago";
            this.cbxtipopago.Size = new System.Drawing.Size(199, 24);
            this.cbxtipopago.TabIndex = 84;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 83;
            this.label7.Text = "Tipo de Pago :";
            // 
            // lbnumfactura
            // 
            this.lbnumfactura.AutoSize = true;
            this.lbnumfactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnumfactura.Location = new System.Drawing.Point(156, 58);
            this.lbnumfactura.Name = "lbnumfactura";
            this.lbnumfactura.Size = new System.Drawing.Size(80, 16);
            this.lbnumfactura.TabIndex = 81;
            this.lbnumfactura.Text = "000000001";
            // 
            // txtrnc
            // 
            this.txtrnc.BackColor = System.Drawing.Color.White;
            this.txtrnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrnc.Location = new System.Drawing.Point(485, 110);
            this.txtrnc.Name = "txtrnc";
            this.txtrnc.ReadOnly = true;
            this.txtrnc.Size = new System.Drawing.Size(200, 22);
            this.txtrnc.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(375, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 79;
            this.label5.Text = "RNC (NCF) :";
            // 
            // cbxtipofactura
            // 
            this.cbxtipofactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxtipofactura.FormattingEnabled = true;
            this.cbxtipofactura.Items.AddRange(new object[] {
            "Cliente Final (Contado)",
            "Comprabante Fiscal"});
            this.cbxtipofactura.Location = new System.Drawing.Point(159, 106);
            this.cbxtipofactura.Name = "cbxtipofactura";
            this.cbxtipofactura.Size = new System.Drawing.Size(199, 24);
            this.cbxtipofactura.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 77;
            this.label3.Text = "Tipo de Factura :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(378, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 76;
            this.label4.Text = "Suplidor :";
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfecha.Location = new System.Drawing.Point(27, 17);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(59, 16);
            this.lbfecha.TabIndex = 75;
            this.lbfecha.Text = "Fecha :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 74;
            this.label1.Text = "Numero Factura :";
            // 
            // btnbuscarsuplidor
            // 
            this.btnbuscarsuplidor.BackgroundImage = global::SGF.Properties.Resources.buscar__1_;
            this.btnbuscarsuplidor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnbuscarsuplidor.FlatAppearance.BorderSize = 0;
            this.btnbuscarsuplidor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbuscarsuplidor.Location = new System.Drawing.Point(691, 56);
            this.btnbuscarsuplidor.Name = "btnbuscarsuplidor";
            this.btnbuscarsuplidor.Size = new System.Drawing.Size(31, 24);
            this.btnbuscarsuplidor.TabIndex = 82;
            this.btnbuscarsuplidor.UseVisualStyleBackColor = true;
            this.btnbuscarsuplidor.Click += new System.EventHandler(this.btnbuscarsuplidor_Click_1);
            // 
            // btnguardar
            // 
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Image = global::SGF.Properties.Resources.diskette_save_saveas_1514;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(141, 583);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(107, 42);
            this.btnguardar.TabIndex = 78;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnnuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnuevo.FlatAppearance.BorderSize = 0;
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Image = global::SGF.Properties.Resources.new_file_40454;
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnuevo.Location = new System.Drawing.Point(12, 585);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(92, 42);
            this.btnnuevo.TabIndex = 77;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnquitararticulo
            // 
            this.btnquitararticulo.BackgroundImage = global::SGF.Properties.Resources.minuslinear_106174;
            this.btnquitararticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnquitararticulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnquitararticulo.FlatAppearance.BorderSize = 0;
            this.btnquitararticulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnquitararticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquitararticulo.ForeColor = System.Drawing.Color.Red;
            this.btnquitararticulo.Location = new System.Drawing.Point(634, 65);
            this.btnquitararticulo.Name = "btnquitararticulo";
            this.btnquitararticulo.Size = new System.Drawing.Size(59, 39);
            this.btnquitararticulo.TabIndex = 33;
            this.btnquitararticulo.UseVisualStyleBackColor = true;
            this.btnquitararticulo.Click += new System.EventHandler(this.btnquitararticulo_Click);
            // 
            // btnagregararticulo
            // 
            this.btnagregararticulo.FlatAppearance.BorderSize = 0;
            this.btnagregararticulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnagregararticulo.Image = global::SGF.Properties.Resources.plus_40632;
            this.btnagregararticulo.Location = new System.Drawing.Point(634, 18);
            this.btnagregararticulo.Name = "btnagregararticulo";
            this.btnagregararticulo.Size = new System.Drawing.Size(59, 41);
            this.btnagregararticulo.TabIndex = 32;
            this.btnagregararticulo.UseVisualStyleBackColor = true;
            this.btnagregararticulo.Click += new System.EventHandler(this.btnagregararticulo_Click);
            // 
            // btnbuscararticulo
            // 
            this.btnbuscararticulo.BackgroundImage = global::SGF.Properties.Resources.buscar__1_;
            this.btnbuscararticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnbuscararticulo.FlatAppearance.BorderSize = 0;
            this.btnbuscararticulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbuscararticulo.Location = new System.Drawing.Point(257, 36);
            this.btnbuscararticulo.Name = "btnbuscararticulo";
            this.btnbuscararticulo.Size = new System.Drawing.Size(31, 24);
            this.btnbuscararticulo.TabIndex = 24;
            this.btnbuscararticulo.UseVisualStyleBackColor = true;
            this.btnbuscararticulo.Click += new System.EventHandler(this.btnbuscararticulo_Click);
            // 
            // FrmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(770, 651);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.gridarticulosuplidor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCompra";
            this.Text = "Realizar Compra";
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridarticulosuplidor)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbcodigoarticulo;
        private System.Windows.Forms.Button btnquitararticulo;
        private System.Windows.Forms.Button btnagregararticulo;
        private System.Windows.Forms.TextBox txtpreciocompra;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnbuscararticulo;
        private System.Windows.Forms.TextBox txtarticulo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView gridarticulosuplidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColImporte;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbcodigosuplidor;
        private System.Windows.Forms.TextBox txtsuplidor;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Label label1;
    }
}