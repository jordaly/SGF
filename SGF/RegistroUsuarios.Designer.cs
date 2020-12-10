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
            this.btnGuardar1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.chxConsultaVentas = new System.Windows.Forms.CheckBox();
            this.chxModificarArticulos = new System.Windows.Forms.CheckBox();
            this.chxRecursosHumanos = new System.Windows.Forms.CheckBox();
            this.chxModificarClientes = new System.Windows.Forms.CheckBox();
            this.chxModificarSuplidores = new System.Windows.Forms.CheckBox();
            this.chxModificarUsuarios = new System.Windows.Forms.CheckBox();
            this.chxIngresarCompras = new System.Windows.Forms.CheckBox();
            this.chxIngresarVentas = new System.Windows.Forms.CheckBox();
            this.chxDespachoTransporte = new System.Windows.Forms.CheckBox();
            this.chxActualizarCaja = new System.Windows.Forms.CheckBox();
            this.chxConsultaReportes = new System.Windows.Forms.CheckBox();
            this.chxRealizarPagos = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.chxRealizarPermisos = new System.Windows.Forms.CheckBox();
            this.tkbDescuento = new System.Windows.Forms.TrackBar();
            this.lbDescuento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbDescuento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(152, 424);
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
            this.label4.Location = new System.Drawing.Point(40, 568);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nivel de acceso";
            this.label4.Visible = false;
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
            this.cbxNivel.Location = new System.Drawing.Point(176, 568);
            this.cbxNivel.Margin = new System.Windows.Forms.Padding(4);
            this.cbxNivel.Name = "cbxNivel";
            this.cbxNivel.Size = new System.Drawing.Size(352, 24);
            this.cbxNivel.TabIndex = 8;
            this.cbxNivel.Visible = false;
            // 
            // btnGuardar1
            // 
            this.btnGuardar1.Location = new System.Drawing.Point(273, 424);
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
            this.chxConsultaVentas.Location = new System.Drawing.Point(336, 254);
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
            this.chxModificarArticulos.Location = new System.Drawing.Point(152, 198);
            this.chxModificarArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.chxModificarArticulos.Name = "chxModificarArticulos";
            this.chxModificarArticulos.Size = new System.Drawing.Size(145, 21);
            this.chxModificarArticulos.TabIndex = 14;
            this.chxModificarArticulos.Text = "Modificar Articulos";
            this.chxModificarArticulos.UseVisualStyleBackColor = true;
            // 
            // chxRecursosHumanos
            // 
            this.chxRecursosHumanos.AutoSize = true;
            this.chxRecursosHumanos.Location = new System.Drawing.Point(152, 226);
            this.chxRecursosHumanos.Margin = new System.Windows.Forms.Padding(4);
            this.chxRecursosHumanos.Name = "chxRecursosHumanos";
            this.chxRecursosHumanos.Size = new System.Drawing.Size(154, 21);
            this.chxRecursosHumanos.TabIndex = 15;
            this.chxRecursosHumanos.Text = "Recursos Humanos";
            this.chxRecursosHumanos.UseVisualStyleBackColor = true;
            // 
            // chxModificarClientes
            // 
            this.chxModificarClientes.AutoSize = true;
            this.chxModificarClientes.Location = new System.Drawing.Point(152, 254);
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
            this.chxModificarSuplidores.Location = new System.Drawing.Point(152, 283);
            this.chxModificarSuplidores.Margin = new System.Windows.Forms.Padding(4);
            this.chxModificarSuplidores.Name = "chxModificarSuplidores";
            this.chxModificarSuplidores.Size = new System.Drawing.Size(158, 21);
            this.chxModificarSuplidores.TabIndex = 17;
            this.chxModificarSuplidores.Text = "Modificar Suplidores";
            this.chxModificarSuplidores.UseVisualStyleBackColor = true;
            // 
            // chxModificarUsuarios
            // 
            this.chxModificarUsuarios.AutoSize = true;
            this.chxModificarUsuarios.Location = new System.Drawing.Point(152, 311);
            this.chxModificarUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.chxModificarUsuarios.Name = "chxModificarUsuarios";
            this.chxModificarUsuarios.Size = new System.Drawing.Size(147, 21);
            this.chxModificarUsuarios.TabIndex = 18;
            this.chxModificarUsuarios.Text = "Modificar Usuarios";
            this.chxModificarUsuarios.UseVisualStyleBackColor = true;
            // 
            // chxIngresarCompras
            // 
            this.chxIngresarCompras.AutoSize = true;
            this.chxIngresarCompras.Location = new System.Drawing.Point(152, 339);
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
            this.chxIngresarVentas.Location = new System.Drawing.Point(336, 198);
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
            this.chxDespachoTransporte.Location = new System.Drawing.Point(336, 226);
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
            this.chxActualizarCaja.Location = new System.Drawing.Point(336, 339);
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
            this.chxConsultaReportes.Location = new System.Drawing.Point(336, 282);
            this.chxConsultaReportes.Margin = new System.Windows.Forms.Padding(4);
            this.chxConsultaReportes.Name = "chxConsultaReportes";
            this.chxConsultaReportes.Size = new System.Drawing.Size(147, 21);
            this.chxConsultaReportes.TabIndex = 24;
            this.chxConsultaReportes.Text = "Consulta Reportes";
            this.chxConsultaReportes.UseVisualStyleBackColor = true;
            // 
            // chxRealizarPagos
            // 
            this.chxRealizarPagos.AutoSize = true;
            this.chxRealizarPagos.Location = new System.Drawing.Point(336, 311);
            this.chxRealizarPagos.Margin = new System.Windows.Forms.Padding(4);
            this.chxRealizarPagos.Name = "chxRealizarPagos";
            this.chxRealizarPagos.Size = new System.Drawing.Size(126, 21);
            this.chxRealizarPagos.TabIndex = 25;
            this.chxRealizarPagos.Text = "Realizar Pagos";
            this.chxRealizarPagos.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Limite Descuento";
            // 
            // tbxEmpleado
            // 
            this.tbxEmpleado.Location = new System.Drawing.Point(152, 169);
            this.tbxEmpleado.Name = "tbxEmpleado";
            this.tbxEmpleado.ReadOnly = true;
            this.tbxEmpleado.Size = new System.Drawing.Size(272, 22);
            this.tbxEmpleado.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Empleado";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(430, 169);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // chxRealizarPermisos
            // 
            this.chxRealizarPermisos.AutoSize = true;
            this.chxRealizarPermisos.Location = new System.Drawing.Point(336, 368);
            this.chxRealizarPermisos.Margin = new System.Windows.Forms.Padding(4);
            this.chxRealizarPermisos.Name = "chxRealizarPermisos";
            this.chxRealizarPermisos.Size = new System.Drawing.Size(144, 21);
            this.chxRealizarPermisos.TabIndex = 31;
            this.chxRealizarPermisos.Text = "Realizar Permisos";
            this.chxRealizarPermisos.UseVisualStyleBackColor = true;
            // 
            // tkbDescuento
            // 
            this.tkbDescuento.Location = new System.Drawing.Point(152, 107);
            this.tkbDescuento.Maximum = 100;
            this.tkbDescuento.Name = "tkbDescuento";
            this.tkbDescuento.Size = new System.Drawing.Size(352, 56);
            this.tkbDescuento.TabIndex = 32;
            this.tkbDescuento.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lbDescuento
            // 
            this.lbDescuento.AutoSize = true;
            this.lbDescuento.Location = new System.Drawing.Point(510, 107);
            this.lbDescuento.Name = "lbDescuento";
            this.lbDescuento.Size = new System.Drawing.Size(38, 17);
            this.lbDescuento.TabIndex = 33;
            this.lbDescuento.Text = "(0%)";
            // 
            // RegistroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 494);
            this.Controls.Add(this.lbDescuento);
            this.Controls.Add(this.tkbDescuento);
            this.Controls.Add(this.chxRealizarPermisos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbxEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chxRealizarPagos);
            this.Controls.Add(this.chxConsultaReportes);
            this.Controls.Add(this.chxActualizarCaja);
            this.Controls.Add(this.chxDespachoTransporte);
            this.Controls.Add(this.chxIngresarVentas);
            this.Controls.Add(this.chxIngresarCompras);
            this.Controls.Add(this.chxModificarUsuarios);
            this.Controls.Add(this.chxModificarSuplidores);
            this.Controls.Add(this.chxModificarClientes);
            this.Controls.Add(this.chxRecursosHumanos);
            this.Controls.Add(this.chxModificarArticulos);
            this.Controls.Add(this.chxConsultaVentas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.btnGuardar1);
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
            this.Controls.SetChildIndex(this.btnGuardar1, 0);
            this.Controls.SetChildIndex(this.tbxCodigo, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.chxConsultaVentas, 0);
            this.Controls.SetChildIndex(this.chxModificarArticulos, 0);
            this.Controls.SetChildIndex(this.chxRecursosHumanos, 0);
            this.Controls.SetChildIndex(this.chxModificarClientes, 0);
            this.Controls.SetChildIndex(this.chxModificarSuplidores, 0);
            this.Controls.SetChildIndex(this.chxModificarUsuarios, 0);
            this.Controls.SetChildIndex(this.chxIngresarCompras, 0);
            this.Controls.SetChildIndex(this.chxIngresarVentas, 0);
            this.Controls.SetChildIndex(this.chxDespachoTransporte, 0);
            this.Controls.SetChildIndex(this.chxActualizarCaja, 0);
            this.Controls.SetChildIndex(this.chxConsultaReportes, 0);
            this.Controls.SetChildIndex(this.chxRealizarPagos, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.tbxEmpleado, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.chxRealizarPermisos, 0);
            this.Controls.SetChildIndex(this.tkbDescuento, 0);
            this.Controls.SetChildIndex(this.lbDescuento, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbDescuento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar1;
        public System.Windows.Forms.TextBox tbxUsuario;
        public System.Windows.Forms.TextBox tbxContraseña;
        public System.Windows.Forms.ComboBox cbxNivel;
        public System.Windows.Forms.TextBox tbxCodigo;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.CheckBox chxConsultaVentas;
        public System.Windows.Forms.CheckBox chxModificarArticulos;
        public System.Windows.Forms.CheckBox chxRecursosHumanos;
        public System.Windows.Forms.CheckBox chxModificarClientes;
        public System.Windows.Forms.CheckBox chxModificarSuplidores;
        public System.Windows.Forms.CheckBox chxModificarUsuarios;
        public System.Windows.Forms.CheckBox chxIngresarCompras;
        public System.Windows.Forms.CheckBox chxIngresarVentas;
        public System.Windows.Forms.CheckBox chxDespachoTransporte;
        public System.Windows.Forms.CheckBox chxActualizarCaja;
        public System.Windows.Forms.CheckBox chxConsultaReportes;
        public System.Windows.Forms.CheckBox chxRealizarPagos;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbxEmpleado;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.CheckBox chxRealizarPermisos;
        public System.Windows.Forms.Label lbDescuento;
        public System.Windows.Forms.TrackBar tkbDescuento;
    }
}