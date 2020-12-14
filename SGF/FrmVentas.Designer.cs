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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();

            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

            this.txttotal = new System.Windows.Forms.TextBox();
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
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lbstock = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtarticulo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxtipo_ncf = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbcodigo = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.cbxsucursal = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
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

            this.btnbuscarcliente = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnquitararticulo = new System.Windows.Forms.Button();
            this.btnagregararticulo = new System.Windows.Forms.Button();
            this.btnbuscararticulo = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridarticulo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 


            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.None;

            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(595, 663);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(130, 22);

            this.txttotal.TabIndex = 55;
            this.txttotal.Text = "total";
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 

            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(530, 663);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 20);

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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridarticulo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridarticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridarticulo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColDescripcion,
            this.ColPrecio,
            this.clitebis,
            this.ColCantidad,
            this.ColImporte});

            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridarticulo.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridarticulo.Location = new System.Drawing.Point(26, 435);

            this.gridarticulo.Name = "gridarticulo";
            this.gridarticulo.ReadOnly = true;
            this.gridarticulo.RowHeadersVisible = false;
            this.gridarticulo.RowHeadersWidth = 51;

            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridarticulo.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridarticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridarticulo.Size = new System.Drawing.Size(788, 211);

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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
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
            this.panel1.Location = new System.Drawing.Point(35, 372);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";

            this.panel1.Size = new System.Drawing.Size(788, 118);

            this.panel1.TabIndex = 50;
            // 
            // txtitebis
            // 
            this.txtitebis.BackColor = System.Drawing.Color.White;

            this.txtitebis.Location = new System.Drawing.Point(506, 74);

            this.txtitebis.Name = "txtitebis";
            this.txtitebis.ReadOnly = true;
            this.txtitebis.Size = new System.Drawing.Size(204, 22);
            this.txtitebis.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;

            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(396, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);

            this.label6.TabIndex = 60;
            this.label6.Text = "ITEBIS :";
            // 
            // lbcodigoarticulo
            // 
            this.lbcodigoarticulo.AutoSize = true;

            this.lbcodigoarticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcodigoarticulo.Location = new System.Drawing.Point(94, 14);
            this.lbcodigoarticulo.Name = "lbcodigoarticulo";
            this.lbcodigoarticulo.Size = new System.Drawing.Size(99, 16);
            this.lbcodigoarticulo.TabIndex = 59;
            this.lbcodigoarticulo.Text = "Codigo Articulo";
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.BackColor = System.Drawing.Color.White;
            this.txtprecioventa.Location = new System.Drawing.Point(506, 34);

            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.ReadOnly = true;
            this.txtprecioventa.Size = new System.Drawing.Size(204, 22);
            this.txtprecioventa.TabIndex = 31;
            this.txtprecioventa.TextChanged += new System.EventHandler(this.txtprecioventa_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;

            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(395, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 16);

            this.label14.TabIndex = 30;
            this.label14.Text = "Precio Venta :";
            // 
            // lbstock
            // 
            this.lbstock.AutoSize = true;

            this.lbstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstock.Location = new System.Drawing.Point(257, 75);
            this.lbstock.Name = "lbstock";
            this.lbstock.Size = new System.Drawing.Size(42, 16);

            this.lbstock.TabIndex = 27;
            this.lbstock.Text = "Stock";
            // 
            // txtcantidad
            // 

            this.txtcantidad.BackColor = System.Drawing.Color.White;
            this.txtcantidad.Location = new System.Drawing.Point(97, 72);

            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(204, 22);
            this.txtcantidad.TabIndex = 26;
            this.txtcantidad.TextChanged += new System.EventHandler(this.txtcantidad_TextChanged);
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
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
            this.txtarticulo.Location = new System.Drawing.Point(97, 35);

            this.txtarticulo.Name = "txtarticulo";
            this.txtarticulo.ReadOnly = true;
            this.txtarticulo.Size = new System.Drawing.Size(204, 22);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.cbxtipo_ncf);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbcodigo);
            this.panel2.Controls.Add(this.txtcliente);
            this.panel2.Controls.Add(this.cbxsucursal);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cbxdivisa);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cbxtipopago);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnbuscarcliente);
            this.panel2.Controls.Add(this.lbnumfactura);
            this.panel2.Controls.Add(this.txtrnc);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbxtipofactura);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbfecha);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(26, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 272);
            this.panel2.TabIndex = 60;
            // 
            // cbxtipo_ncf
            // 
            this.cbxtipo_ncf.BackColor = System.Drawing.Color.White;
            this.cbxtipo_ncf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxtipo_ncf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxtipo_ncf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxtipo_ncf.FormattingEnabled = true;
            this.cbxtipo_ncf.Location = new System.Drawing.Point(487, 104);
            this.cbxtipo_ncf.Name = "cbxtipo_ncf";
            this.cbxtipo_ncf.Size = new System.Drawing.Size(204, 24);
            this.cbxtipo_ncf.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(375, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 77;
            this.label2.Text = "Tipo de RNC :";
            // 
            // lbcodigo
            // 
            this.lbcodigo.AutoSize = true;
            this.lbcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcodigo.Location = new System.Drawing.Point(161, 145);
            this.lbcodigo.Name = "lbcodigo";
            this.lbcodigo.Size = new System.Drawing.Size(96, 16);
            this.lbcodigo.TabIndex = 76;
            this.lbcodigo.Text = "Codigo Cliente";
            // 
            // txtcliente
            // 
            this.txtcliente.BackColor = System.Drawing.Color.White;
            this.txtcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcliente.Location = new System.Drawing.Point(159, 164);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.ReadOnly = true;
            this.txtcliente.Size = new System.Drawing.Size(200, 22);
            this.txtcliente.TabIndex = 75;
            // 
            // cbxsucursal
            // 
            this.cbxsucursal.BackColor = System.Drawing.Color.White;
            this.cbxsucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxsucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxsucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxsucursal.FormattingEnabled = true;
            this.cbxsucursal.Items.AddRange(new object[] {
            "Cliente Final (Contado)",
            "Comprabante Fiscal"});

            this.cbxsucursal.Location = new System.Drawing.Point(487, 55);
            this.cbxsucursal.Name = "cbxsucursal";
            this.cbxsucursal.Size = new System.Drawing.Size(204, 24);
            this.cbxsucursal.TabIndex = 74;

            // 
            // label9
            // 
            this.label9.AutoSize = true;

            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(377, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 73;

            this.label9.Text = "Sucursal :";
            // 
            // cbxdivisa
            // 
            this.cbxdivisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxdivisa.FormattingEnabled = true;
            this.cbxdivisa.Items.AddRange(new object[] {
            "Cliente Final (Contado)",
            "Comprabante Fiscal"});

            this.cbxdivisa.Location = new System.Drawing.Point(448, 231);
            this.cbxdivisa.Name = "cbxdivisa";
            this.cbxdivisa.Size = new System.Drawing.Size(141, 24);
            this.cbxdivisa.TabIndex = 72;

            this.cbxdivisa.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;

            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(385, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 71;

            this.label8.Text = "Divisa :";
            this.label8.Visible = false;
            // 
            // cbxtipopago
            // 
            this.cbxtipopago.BackColor = System.Drawing.Color.White;
            this.cbxtipopago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxtipopago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxtipopago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxtipopago.FormattingEnabled = true;
            this.cbxtipopago.Items.AddRange(new object[] {
            "Cliente Final (Contado)",
            "Comprabante Fiscal"});

            this.cbxtipopago.Location = new System.Drawing.Point(159, 231);
            this.cbxtipopago.Name = "cbxtipopago";
            this.cbxtipopago.Size = new System.Drawing.Size(199, 24);
            this.cbxtipopago.TabIndex = 70;

            // 
            // label7
            // 
            this.label7.AutoSize = true;

            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 69;
            this.label7.Text = "Tipo de Pago :";
            // 
            // lbnumfactura
            // 
            this.lbnumfactura.AutoSize = true;
            this.lbnumfactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnumfactura.Location = new System.Drawing.Point(156, 57);
            this.lbnumfactura.Name = "lbnumfactura";
            this.lbnumfactura.Size = new System.Drawing.Size(71, 16);
            this.lbnumfactura.TabIndex = 67;

            this.lbnumfactura.Text = "000000001";
            // 
            // txtrnc
            // 

            this.txtrnc.BackColor = System.Drawing.Color.White;
            this.txtrnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrnc.Location = new System.Drawing.Point(160, 195);
            this.txtrnc.Name = "txtrnc";
            this.txtrnc.ReadOnly = true;
            this.txtrnc.Size = new System.Drawing.Size(200, 22);
            this.txtrnc.TabIndex = 66;

            // 
            // label5
            // 
            this.label5.AutoSize = true;

            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 65;

            this.label5.Text = "RNC (NCF) :";
            // 
            // cbxtipofactura
            // 
            this.cbxtipofactura.BackColor = System.Drawing.Color.White;
            this.cbxtipofactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxtipofactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxtipofactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxtipofactura.FormattingEnabled = true;

            this.cbxtipofactura.Location = new System.Drawing.Point(159, 101);
            this.cbxtipofactura.Name = "cbxtipofactura";
            this.cbxtipofactura.Size = new System.Drawing.Size(199, 24);
            this.cbxtipofactura.TabIndex = 64;

            // 
            // label3
            // 
            this.label3.AutoSize = true;

            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 63;

            this.label3.Text = "Tipo de Factura :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;

            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 62;

            this.label4.Text = "Cliente :";
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;

            this.lbfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfecha.Location = new System.Drawing.Point(26, 10);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(59, 16);
            this.lbfecha.TabIndex = 61;

            this.lbfecha.Text = "Fecha :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;

            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 60;

            this.label1.Text = "Numero Factura :";
            // 
            // btnbuscarcliente
            // 

            this.btnbuscarcliente.BackgroundImage = global::SGF.Properties.Resources.buscar__1_2;
            this.btnbuscarcliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnbuscarcliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarcliente.FlatAppearance.BorderSize = 0;
            this.btnbuscarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbuscarcliente.Location = new System.Drawing.Point(365, 162);
            this.btnbuscarcliente.Name = "btnbuscarcliente";
            this.btnbuscarcliente.Size = new System.Drawing.Size(31, 24);
            this.btnbuscarcliente.TabIndex = 68;
            this.btnbuscarcliente.UseVisualStyleBackColor = true;
            this.btnbuscarcliente.Click += new System.EventHandler(this.btnbuscarcliente_Click_1);

            // 
            // btnguardar
            // 

            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Image = global::SGF.Properties.Resources.diskette_save_saveas_15143;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(159, 663);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(107, 42);
            this.btnguardar.TabIndex = 57;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnuevo.FlatAppearance.BorderSize = 0;
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Image = global::SGF.Properties.Resources.new_file_404542;
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnuevo.Location = new System.Drawing.Point(26, 663);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(103, 42);
            this.btnnuevo.TabIndex = 56;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnquitararticulo
            // 
            this.btnquitararticulo.BackgroundImage = global::SGF.Properties.Resources.minuslinear_1061742;
            this.btnquitararticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnquitararticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnquitararticulo.FlatAppearance.BorderSize = 0;
            this.btnquitararticulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnquitararticulo.Location = new System.Drawing.Point(709, 65);
            this.btnquitararticulo.Name = "btnquitararticulo";
            this.btnquitararticulo.Size = new System.Drawing.Size(59, 41);
            this.btnquitararticulo.TabIndex = 33;
            this.btnquitararticulo.UseVisualStyleBackColor = true;
            this.btnquitararticulo.Click += new System.EventHandler(this.btnquitararticulo_Click);
            // 
            // btnagregararticulo
            // 
            this.btnagregararticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregararticulo.FlatAppearance.BorderSize = 0;
            this.btnagregararticulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnagregararticulo.Image = global::SGF.Properties.Resources.plus_40632;
            this.btnagregararticulo.Location = new System.Drawing.Point(709, 14);
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
            this.btnbuscararticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscararticulo.FlatAppearance.BorderSize = 0;
            this.btnbuscararticulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbuscararticulo.Location = new System.Drawing.Point(258, 31);
            this.btnbuscararticulo.Name = "btnbuscararticulo";
            this.btnbuscararticulo.Size = new System.Drawing.Size(31, 24);
            this.btnbuscararticulo.TabIndex = 24;
            this.btnbuscararticulo.UseVisualStyleBackColor = true;
            this.btnbuscararticulo.Click += new System.EventHandler(this.btnbuscararticulo_Click);

            // 
            // chxTransporte
            // 
            this.chxTransporte.AutoSize = true;
            this.chxTransporte.Location = new System.Drawing.Point(749, 305);
            this.chxTransporte.Name = "chxTransporte";
            this.chxTransporte.Size = new System.Drawing.Size(137, 21);
            this.chxTransporte.TabIndex = 60;
            this.chxTransporte.Text = "Lleva transporte.";
            this.chxTransporte.UseVisualStyleBackColor = true;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(873, 729);
            this.Controls.Add(this.panel2);

            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.gridarticulo);
            this.Controls.Add(this.panel1);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);

            this.Name = "FrmVentas";
            this.Text = "Realizar Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridarticulo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.TextBox txttotal;
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
        private System.Windows.Forms.Label lbcodigoarticulo;
        private System.Windows.Forms.TextBox txtitebis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clitebis;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColImporte;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxtipo_ncf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbcodigo;
        private System.Windows.Forms.TextBox txtcliente;
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


    }
}