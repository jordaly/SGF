namespace SGF
{
    partial class RegistroUsuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.tbxContraseña = new System.Windows.Forms.TextBox();
            this.cbxNivel = new System.Windows.Forms.ComboBox();
            this.chxEstado = new System.Windows.Forms.CheckBox();
            this.btnGuardar1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.chxConsultaVentas = new System.Windows.Forms.CheckBox();
            this.chxModificarArticulos = new System.Windows.Forms.CheckBox();
            this.chxAjusteStock = new System.Windows.Forms.CheckBox();
            this.chxModificarClientes = new System.Windows.Forms.CheckBox();
            this.chxModificarSuplidores = new System.Windows.Forms.CheckBox();
            this.chxModificarVendedores = new System.Windows.Forms.CheckBox();
            this.chxIngresarCompras = new System.Windows.Forms.CheckBox();
            this.chxIngresarVentas = new System.Windows.Forms.CheckBox();
            this.chxDespachoTransporte = new System.Windows.Forms.CheckBox();
            this.chxActualizarCaja = new System.Windows.Forms.CheckBox();
            this.chxConsultaReportes = new System.Windows.Forms.CheckBox();
            this.chxReimprimirFacturas = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxLimiteDescuento = new System.Windows.Forms.TextBox();
            this.tbxEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(152, 455);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nivel de acceso";
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.Location = new System.Drawing.Point(152, 48);
            this.tbxUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(352, 22);
            this.tbxUsuario.TabIndex = 4;
            // 
            // tbxContraseña
            // 
            this.tbxContraseña.Location = new System.Drawing.Point(152, 78);
            this.tbxContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.tbxContraseña.Name = "tbxContraseña";
            this.tbxContraseña.PasswordChar = '*';
            this.tbxContraseña.Size = new System.Drawing.Size(352, 22);
            this.tbxContraseña.TabIndex = 7;
            // 
            // cbxNivel
            // 
            this.cbxNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNivel.FormattingEnabled = true;
            this.cbxNivel.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cbxNivel.Location = new System.Drawing.Point(152, 108);
            this.cbxNivel.Margin = new System.Windows.Forms.Padding(4);
            this.cbxNivel.Name = "cbxNivel";
            this.cbxNivel.Size = new System.Drawing.Size(352, 24);
            this.cbxNivel.TabIndex = 8;
            // 
            // chxEstado
            // 
            this.chxEstado.AutoSize = true;
            this.chxEstado.Location = new System.Drawing.Point(152, 394);
            this.chxEstado.Margin = new System.Windows.Forms.Padding(4);
            this.chxEstado.Name = "chxEstado";
            this.chxEstado.Size = new System.Drawing.Size(74, 21);
            this.chxEstado.TabIndex = 9;
            this.chxEstado.Text = "Estado";
            this.chxEstado.UseVisualStyleBackColor = true;
            // 
            // btnGuardar1
            // 
            this.btnGuardar1.Location = new System.Drawing.Point(273, 455);
            this.btnGuardar1.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar1.Name = "btnGuardar1";
            this.btnGuardar1.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar1.TabIndex = 10;
            this.btnGuardar1.Text = "Guardar";
            this.btnGuardar1.UseVisualStyleBackColor = true;
            this.btnGuardar1.Visible = false;
            this.btnGuardar1.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Código";
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Location = new System.Drawing.Point(152, 18);
            this.tbxCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.ReadOnly = true;
            this.tbxCodigo.Size = new System.Drawing.Size(352, 22);
            this.tbxCodigo.TabIndex = 11;
            this.tbxCodigo.Text = "Nuevo";
            // 
            // chxConsultaVentas
            // 
            this.chxConsultaVentas.AutoSize = true;
            this.chxConsultaVentas.Location = new System.Drawing.Point(336, 252);
            this.chxConsultaVentas.Margin = new System.Windows.Forms.Padding(4);
            this.chxConsultaVentas.Name = "chxConsultaVentas";
            this.chxConsultaVentas.Size = new System.Drawing.Size(133, 21);
            this.chxConsultaVentas.TabIndex = 13;
            this.chxConsultaVentas.Text = "Consulta Ventas";
            this.chxConsultaVentas.UseVisualStyleBackColor = true;
            // 
            // chxModificarArticulos
            // 
            this.chxModificarArticulos.AutoSize = true;
            this.chxModificarArticulos.Location = new System.Drawing.Point(152, 196);
            this.chxModificarArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.chxModificarArticulos.Name = "chxModificarArticulos";
            this.chxModificarArticulos.Size = new System.Drawing.Size(145, 21);
            this.chxModificarArticulos.TabIndex = 14;
            this.chxModificarArticulos.Text = "Modificar Articulos";
            this.chxModificarArticulos.UseVisualStyleBackColor = true;
            // 
            // chxAjusteStock
            // 
            this.chxAjusteStock.AutoSize = true;
            this.chxAjusteStock.Location = new System.Drawing.Point(152, 224);
            this.chxAjusteStock.Margin = new System.Windows.Forms.Padding(4);
            this.chxAjusteStock.Name = "chxAjusteStock";
            this.chxAjusteStock.Size = new System.Drawing.Size(108, 21);
            this.chxAjusteStock.TabIndex = 15;
            this.chxAjusteStock.Text = "Ajuste Stock";
            this.chxAjusteStock.UseVisualStyleBackColor = true;
            // 
            // chxModificarClientes
            // 
            this.chxModificarClientes.AutoSize = true;
            this.chxModificarClientes.Location = new System.Drawing.Point(152, 252);
            this.chxModificarClientes.Margin = new System.Windows.Forms.Padding(4);
            this.chxModificarClientes.Name = "chxModificarClientes";
            this.chxModificarClientes.Size = new System.Drawing.Size(141, 21);
            this.chxModificarClientes.TabIndex = 16;
            this.chxModificarClientes.Text = "Modificar Clientes";
            this.chxModificarClientes.UseVisualStyleBackColor = true;
            // 
            // chxModificarSuplidores
            // 
            this.chxModificarSuplidores.AutoSize = true;
            this.chxModificarSuplidores.Location = new System.Drawing.Point(152, 281);
            this.chxModificarSuplidores.Margin = new System.Windows.Forms.Padding(4);
            this.chxModificarSuplidores.Name = "chxModificarSuplidores";
            this.chxModificarSuplidores.Size = new System.Drawing.Size(158, 21);
            this.chxModificarSuplidores.TabIndex = 17;
            this.chxModificarSuplidores.Text = "Modificar Suplidores";
            this.chxModificarSuplidores.UseVisualStyleBackColor = true;
            // 
            // chxModificarVendedores
            // 
            this.chxModificarVendedores.AutoSize = true;
            this.chxModificarVendedores.Location = new System.Drawing.Point(152, 309);
            this.chxModificarVendedores.Margin = new System.Windows.Forms.Padding(4);
            this.chxModificarVendedores.Name = "chxModificarVendedores";
            this.chxModificarVendedores.Size = new System.Drawing.Size(168, 21);
            this.chxModificarVendedores.TabIndex = 18;
            this.chxModificarVendedores.Text = "Modificar Vendedores";
            this.chxModificarVendedores.UseVisualStyleBackColor = true;
            // 
            // chxIngresarCompras
            // 
            this.chxIngresarCompras.AutoSize = true;
            this.chxIngresarCompras.Location = new System.Drawing.Point(152, 337);
            this.chxIngresarCompras.Margin = new System.Windows.Forms.Padding(4);
            this.chxIngresarCompras.Name = "chxIngresarCompras";
            this.chxIngresarCompras.Size = new System.Drawing.Size(142, 21);
            this.chxIngresarCompras.TabIndex = 19;
            this.chxIngresarCompras.Text = "Ingresar Compras";
            this.chxIngresarCompras.UseVisualStyleBackColor = true;
            // 
            // chxIngresarVentas
            // 
            this.chxIngresarVentas.AutoSize = true;
            this.chxIngresarVentas.Location = new System.Drawing.Point(336, 196);
            this.chxIngresarVentas.Margin = new System.Windows.Forms.Padding(4);
            this.chxIngresarVentas.Name = "chxIngresarVentas";
            this.chxIngresarVentas.Size = new System.Drawing.Size(130, 21);
            this.chxIngresarVentas.TabIndex = 20;
            this.chxIngresarVentas.Text = "Ingresar Ventas";
            this.chxIngresarVentas.UseVisualStyleBackColor = true;
            // 
            // chxDespachoTransporte
            // 
            this.chxDespachoTransporte.AutoSize = true;
            this.chxDespachoTransporte.Location = new System.Drawing.Point(336, 224);
            this.chxDespachoTransporte.Margin = new System.Windows.Forms.Padding(4);
            this.chxDespachoTransporte.Name = "chxDespachoTransporte";
            this.chxDespachoTransporte.Size = new System.Drawing.Size(168, 21);
            this.chxDespachoTransporte.TabIndex = 21;
            this.chxDespachoTransporte.Text = "Despacho Transporte";
            this.chxDespachoTransporte.UseVisualStyleBackColor = true;
            // 
            // chxActualizarCaja
            // 
            this.chxActualizarCaja.AutoSize = true;
            this.chxActualizarCaja.Location = new System.Drawing.Point(336, 337);
            this.chxActualizarCaja.Margin = new System.Windows.Forms.Padding(4);
            this.chxActualizarCaja.Name = "chxActualizarCaja";
            this.chxActualizarCaja.Size = new System.Drawing.Size(124, 21);
            this.chxActualizarCaja.TabIndex = 23;
            this.chxActualizarCaja.Text = "Actualizar Caja";
            this.chxActualizarCaja.UseVisualStyleBackColor = true;
            // 
            // chxConsultaReportes
            // 
            this.chxConsultaReportes.AutoSize = true;
            this.chxConsultaReportes.Location = new System.Drawing.Point(336, 280);
            this.chxConsultaReportes.Margin = new System.Windows.Forms.Padding(4);
            this.chxConsultaReportes.Name = "chxConsultaReportes";
            this.chxConsultaReportes.Size = new System.Drawing.Size(147, 21);
            this.chxConsultaReportes.TabIndex = 24;
            this.chxConsultaReportes.Text = "Consulta Reportes";
            this.chxConsultaReportes.UseVisualStyleBackColor = true;
            // 
            // chxReimprimirFacturas
            // 
            this.chxReimprimirFacturas.AutoSize = true;
            this.chxReimprimirFacturas.Location = new System.Drawing.Point(336, 309);
            this.chxReimprimirFacturas.Margin = new System.Windows.Forms.Padding(4);
            this.chxReimprimirFacturas.Name = "chxReimprimirFacturas";
            this.chxReimprimirFacturas.Size = new System.Drawing.Size(156, 21);
            this.chxReimprimirFacturas.TabIndex = 25;
            this.chxReimprimirFacturas.Text = "Reimprimir Facturas";
            this.chxReimprimirFacturas.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Limite Descuento";
            // 
            // tbxLimiteDescuento
            // 
            this.tbxLimiteDescuento.Location = new System.Drawing.Point(152, 139);
            this.tbxLimiteDescuento.Name = "tbxLimiteDescuento";
            this.tbxLimiteDescuento.Size = new System.Drawing.Size(352, 22);
            this.tbxLimiteDescuento.TabIndex = 27;
            // 
            // tbxEmpleado
            // 
            this.tbxEmpleado.Location = new System.Drawing.Point(152, 167);
            this.tbxEmpleado.Name = "tbxEmpleado";
            this.tbxEmpleado.ReadOnly = true;
            this.tbxEmpleado.Size = new System.Drawing.Size(272, 22);
            this.tbxEmpleado.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Empleado";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(430, 167);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // RegistroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 499);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbxEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxLimiteDescuento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chxReimprimirFacturas);
            this.Controls.Add(this.chxConsultaReportes);
            this.Controls.Add(this.chxActualizarCaja);
            this.Controls.Add(this.chxDespachoTransporte);
            this.Controls.Add(this.chxIngresarVentas);
            this.Controls.Add(this.chxIngresarCompras);
            this.Controls.Add(this.chxModificarVendedores);
            this.Controls.Add(this.chxModificarSuplidores);
            this.Controls.Add(this.chxModificarClientes);
            this.Controls.Add(this.chxAjusteStock);
            this.Controls.Add(this.chxModificarArticulos);
            this.Controls.Add(this.chxConsultaVentas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.btnGuardar1);
            this.Controls.Add(this.chxEstado);
            this.Controls.Add(this.cbxNivel);
            this.Controls.Add(this.tbxContraseña);
            this.Controls.Add(this.tbxUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "RegistroUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.tbxUsuario, 0);
            this.Controls.SetChildIndex(this.tbxContraseña, 0);
            this.Controls.SetChildIndex(this.cbxNivel, 0);
            this.Controls.SetChildIndex(this.chxEstado, 0);
            this.Controls.SetChildIndex(this.btnGuardar1, 0);
            this.Controls.SetChildIndex(this.tbxCodigo, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.chxConsultaVentas, 0);
            this.Controls.SetChildIndex(this.chxModificarArticulos, 0);
            this.Controls.SetChildIndex(this.chxAjusteStock, 0);
            this.Controls.SetChildIndex(this.chxModificarClientes, 0);
            this.Controls.SetChildIndex(this.chxModificarSuplidores, 0);
            this.Controls.SetChildIndex(this.chxModificarVendedores, 0);
            this.Controls.SetChildIndex(this.chxIngresarCompras, 0);
            this.Controls.SetChildIndex(this.chxIngresarVentas, 0);
            this.Controls.SetChildIndex(this.chxDespachoTransporte, 0);
            this.Controls.SetChildIndex(this.chxActualizarCaja, 0);
            this.Controls.SetChildIndex(this.chxConsultaReportes, 0);
            this.Controls.SetChildIndex(this.chxReimprimirFacturas, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.tbxLimiteDescuento, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.tbxEmpleado, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar1;
        public System.Windows.Forms.TextBox tbxUsuario;
        public System.Windows.Forms.TextBox tbxContraseña;
        public System.Windows.Forms.ComboBox cbxNivel;
        public System.Windows.Forms.CheckBox chxEstado;
        public System.Windows.Forms.TextBox tbxCodigo;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.CheckBox chxConsultaVentas;
        public System.Windows.Forms.CheckBox chxModificarArticulos;
        public System.Windows.Forms.CheckBox chxAjusteStock;
        public System.Windows.Forms.CheckBox chxModificarClientes;
        public System.Windows.Forms.CheckBox chxModificarSuplidores;
        public System.Windows.Forms.CheckBox chxModificarVendedores;
        public System.Windows.Forms.CheckBox chxIngresarCompras;
        public System.Windows.Forms.CheckBox chxIngresarVentas;
        public System.Windows.Forms.CheckBox chxDespachoTransporte;
        public System.Windows.Forms.CheckBox chxActualizarCaja;
        public System.Windows.Forms.CheckBox chxConsultaReportes;
        public System.Windows.Forms.CheckBox chxReimprimirFacturas;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbxLimiteDescuento;
        public System.Windows.Forms.TextBox tbxEmpleado;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
    }
}