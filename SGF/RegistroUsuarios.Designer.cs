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
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Location = new System.Drawing.Point(178, 464);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de usuario :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 549);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nivel de acceso";
            this.label4.Visible = false;
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsuario.Location = new System.Drawing.Point(171, 62);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(265, 22);
            this.tbxUsuario.TabIndex = 4;
            // 
            // tbxContraseña
            // 
            this.tbxContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxContraseña.Location = new System.Drawing.Point(171, 102);
            this.tbxContraseña.Name = "tbxContraseña";
            this.tbxContraseña.PasswordChar = '*';
            this.tbxContraseña.Size = new System.Drawing.Size(265, 22);
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
            this.cbxNivel.Location = new System.Drawing.Point(129, 549);
            this.cbxNivel.Name = "cbxNivel";
            this.cbxNivel.Size = new System.Drawing.Size(265, 21);
            this.cbxNivel.TabIndex = 8;
            this.cbxNivel.Visible = false;
            // 
            // btnGuardar1
            // 
            this.btnGuardar1.Location = new System.Drawing.Point(269, 464);
            this.btnGuardar1.Name = "btnGuardar1";
            this.btnGuardar1.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar1.TabIndex = 10;
            this.btnGuardar1.Text = "Guardar";
            this.btnGuardar1.UseVisualStyleBackColor = true;
            this.btnGuardar1.Visible = false;
            this.btnGuardar1.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Código :";
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCodigo.Location = new System.Drawing.Point(171, 18);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.ReadOnly = true;
            this.tbxCodigo.Size = new System.Drawing.Size(265, 22);
            this.tbxCodigo.TabIndex = 11;
            this.tbxCodigo.Text = "Nuevo";
            // 
            // chxConsultaVentas
            // 
            this.chxConsultaVentas.AutoSize = true;
            this.chxConsultaVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxConsultaVentas.Location = new System.Drawing.Point(307, 318);
            this.chxConsultaVentas.Name = "chxConsultaVentas";
            this.chxConsultaVentas.Size = new System.Drawing.Size(124, 20);
            this.chxConsultaVentas.TabIndex = 13;
            this.chxConsultaVentas.Text = "Consulta Ventas";
            this.chxConsultaVentas.UseVisualStyleBackColor = true;
            // 
            // chxModificarArticulos
            // 
            this.chxModificarArticulos.AutoSize = true;
            this.chxModificarArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxModificarArticulos.Location = new System.Drawing.Point(153, 273);
            this.chxModificarArticulos.Name = "chxModificarArticulos";
            this.chxModificarArticulos.Size = new System.Drawing.Size(136, 20);
            this.chxModificarArticulos.TabIndex = 14;
            this.chxModificarArticulos.Text = "Modificar Articulos";
            this.chxModificarArticulos.UseVisualStyleBackColor = true;
            // 
            // chxRecursosHumanos
            // 
            this.chxRecursosHumanos.AutoSize = true;
            this.chxRecursosHumanos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxRecursosHumanos.Location = new System.Drawing.Point(153, 296);
            this.chxRecursosHumanos.Name = "chxRecursosHumanos";
            this.chxRecursosHumanos.Size = new System.Drawing.Size(146, 20);
            this.chxRecursosHumanos.TabIndex = 15;
            this.chxRecursosHumanos.Text = "Recursos Humanos";
            this.chxRecursosHumanos.UseVisualStyleBackColor = true;
            // 
            // chxModificarClientes
            // 
            this.chxModificarClientes.AutoSize = true;
            this.chxModificarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxModificarClientes.Location = new System.Drawing.Point(153, 318);
            this.chxModificarClientes.Name = "chxModificarClientes";
            this.chxModificarClientes.Size = new System.Drawing.Size(133, 20);
            this.chxModificarClientes.TabIndex = 16;
            this.chxModificarClientes.Text = "Modificar Clientes";
            this.chxModificarClientes.UseVisualStyleBackColor = true;
            // 
            // chxModificarSuplidores
            // 
            this.chxModificarSuplidores.AutoSize = true;
            this.chxModificarSuplidores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxModificarSuplidores.Location = new System.Drawing.Point(153, 342);
            this.chxModificarSuplidores.Name = "chxModificarSuplidores";
            this.chxModificarSuplidores.Size = new System.Drawing.Size(150, 20);
            this.chxModificarSuplidores.TabIndex = 17;
            this.chxModificarSuplidores.Text = "Modificar Suplidores";
            this.chxModificarSuplidores.UseVisualStyleBackColor = true;
            // 
            // chxModificarUsuarios
            // 
            this.chxModificarUsuarios.AutoSize = true;
            this.chxModificarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxModificarUsuarios.Location = new System.Drawing.Point(153, 365);
            this.chxModificarUsuarios.Name = "chxModificarUsuarios";
            this.chxModificarUsuarios.Size = new System.Drawing.Size(139, 20);
            this.chxModificarUsuarios.TabIndex = 18;
            this.chxModificarUsuarios.Text = "Modificar Usuarios";
            this.chxModificarUsuarios.UseVisualStyleBackColor = true;
            // 
            // chxIngresarCompras
            // 
            this.chxIngresarCompras.AutoSize = true;
            this.chxIngresarCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxIngresarCompras.Location = new System.Drawing.Point(153, 387);
            this.chxIngresarCompras.Name = "chxIngresarCompras";
            this.chxIngresarCompras.Size = new System.Drawing.Size(134, 20);
            this.chxIngresarCompras.TabIndex = 19;
            this.chxIngresarCompras.Text = "Ingresar Compras";
            this.chxIngresarCompras.UseVisualStyleBackColor = true;
            // 
            // chxIngresarVentas
            // 
            this.chxIngresarVentas.AutoSize = true;
            this.chxIngresarVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxIngresarVentas.Location = new System.Drawing.Point(307, 273);
            this.chxIngresarVentas.Name = "chxIngresarVentas";
            this.chxIngresarVentas.Size = new System.Drawing.Size(121, 20);
            this.chxIngresarVentas.TabIndex = 20;
            this.chxIngresarVentas.Text = "Ingresar Ventas";
            this.chxIngresarVentas.UseVisualStyleBackColor = true;
            // 
            // chxDespachoTransporte
            // 
            this.chxDespachoTransporte.AutoSize = true;
            this.chxDespachoTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxDespachoTransporte.Location = new System.Drawing.Point(307, 296);
            this.chxDespachoTransporte.Name = "chxDespachoTransporte";
            this.chxDespachoTransporte.Size = new System.Drawing.Size(159, 20);
            this.chxDespachoTransporte.TabIndex = 21;
            this.chxDespachoTransporte.Text = "Despacho Transporte";
            this.chxDespachoTransporte.UseVisualStyleBackColor = true;
            // 
            // chxActualizarCaja
            // 
            this.chxActualizarCaja.AutoSize = true;
            this.chxActualizarCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxActualizarCaja.Location = new System.Drawing.Point(307, 387);
            this.chxActualizarCaja.Name = "chxActualizarCaja";
            this.chxActualizarCaja.Size = new System.Drawing.Size(116, 20);
            this.chxActualizarCaja.TabIndex = 23;
            this.chxActualizarCaja.Text = "Actualizar Caja";
            this.chxActualizarCaja.UseVisualStyleBackColor = true;
            // 
            // chxConsultaReportes
            // 
            this.chxConsultaReportes.AutoSize = true;
            this.chxConsultaReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxConsultaReportes.Location = new System.Drawing.Point(307, 341);
            this.chxConsultaReportes.Name = "chxConsultaReportes";
            this.chxConsultaReportes.Size = new System.Drawing.Size(138, 20);
            this.chxConsultaReportes.TabIndex = 24;
            this.chxConsultaReportes.Text = "Consulta Reportes";
            this.chxConsultaReportes.UseVisualStyleBackColor = true;
            // 
            // chxRealizarPagos
            // 
            this.chxRealizarPagos.AutoSize = true;
            this.chxRealizarPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxRealizarPagos.Location = new System.Drawing.Point(307, 365);
            this.chxRealizarPagos.Name = "chxRealizarPagos";
            this.chxRealizarPagos.Size = new System.Drawing.Size(120, 20);
            this.chxRealizarPagos.TabIndex = 25;
            this.chxRealizarPagos.Text = "Realizar Pagos";
            this.chxRealizarPagos.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 161);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Limite Descuento :";
            // 
            // tbxEmpleado
            // 
            this.tbxEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmpleado.Location = new System.Drawing.Point(174, 235);
            this.tbxEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.tbxEmpleado.Name = "tbxEmpleado";
            this.tbxEmpleado.ReadOnly = true;
            this.tbxEmpleado.Size = new System.Drawing.Size(205, 22);
            this.tbxEmpleado.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Empleado :";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::SGF.Properties.Resources.buscar__1_1;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Location = new System.Drawing.Point(385, 235);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(31, 24);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // chxRealizarPermisos
            // 
            this.chxRealizarPermisos.AutoSize = true;
            this.chxRealizarPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxRealizarPermisos.Location = new System.Drawing.Point(307, 411);
            this.chxRealizarPermisos.Name = "chxRealizarPermisos";
            this.chxRealizarPermisos.Size = new System.Drawing.Size(137, 20);
            this.chxRealizarPermisos.TabIndex = 31;
            this.chxRealizarPermisos.Text = "Realizar Permisos";
            this.chxRealizarPermisos.UseVisualStyleBackColor = true;
            // 
            // tkbDescuento
            // 
            this.tkbDescuento.Location = new System.Drawing.Point(171, 161);
            this.tkbDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.tkbDescuento.Maximum = 100;
            this.tkbDescuento.Name = "tkbDescuento";
            this.tkbDescuento.Size = new System.Drawing.Size(264, 45);
            this.tkbDescuento.TabIndex = 32;
            this.tkbDescuento.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lbDescuento
            // 
            this.lbDescuento.AutoSize = true;
            this.lbDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescuento.Location = new System.Drawing.Point(439, 164);
            this.lbDescuento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDescuento.Name = "lbDescuento";
            this.lbDescuento.Size = new System.Drawing.Size(35, 16);
            this.lbDescuento.TabIndex = 33;
            this.lbDescuento.Text = "(0%)";
            // 
            // RegistroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(510, 521);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
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