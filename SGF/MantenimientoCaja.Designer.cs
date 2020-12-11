namespace SGF
{
    partial class MantenimientoCaja
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxCantidadInicial = new System.Windows.Forms.TextBox();
            this.tbxCantidadActual = new System.Windows.Forms.TextBox();
            this.tbxGanancias = new System.Windows.Forms.TextBox();
            this.tbxVentasTotales = new System.Windows.Forms.TextBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lbFechaInicio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad actual";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ventas totales";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ganancias";
            // 
            // tbxCantidadInicial
            // 
            this.tbxCantidadInicial.Location = new System.Drawing.Point(187, 61);
            this.tbxCantidadInicial.Name = "tbxCantidadInicial";
            this.tbxCantidadInicial.Size = new System.Drawing.Size(221, 22);
            this.tbxCantidadInicial.TabIndex = 4;
            this.tbxCantidadInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCantidadInicial_KeyPress);
            // 
            // tbxCantidadActual
            // 
            this.tbxCantidadActual.Location = new System.Drawing.Point(187, 89);
            this.tbxCantidadActual.Name = "tbxCantidadActual";
            this.tbxCantidadActual.ReadOnly = true;
            this.tbxCantidadActual.Size = new System.Drawing.Size(221, 22);
            this.tbxCantidadActual.TabIndex = 5;
            this.tbxCantidadActual.Text = "0";
            // 
            // tbxGanancias
            // 
            this.tbxGanancias.Location = new System.Drawing.Point(187, 145);
            this.tbxGanancias.Name = "tbxGanancias";
            this.tbxGanancias.ReadOnly = true;
            this.tbxGanancias.Size = new System.Drawing.Size(221, 22);
            this.tbxGanancias.TabIndex = 6;
            this.tbxGanancias.Text = "0";
            // 
            // tbxVentasTotales
            // 
            this.tbxVentasTotales.Location = new System.Drawing.Point(187, 117);
            this.tbxVentasTotales.Name = "tbxVentasTotales";
            this.tbxVentasTotales.ReadOnly = true;
            this.tbxVentasTotales.Size = new System.Drawing.Size(221, 22);
            this.tbxVentasTotales.TabIndex = 7;
            this.tbxVentasTotales.Text = "0";
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(187, 197);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 23);
            this.btnInicio.TabIndex = 8;
            this.btnInicio.Text = "Iniciar";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Location = new System.Drawing.Point(268, 197);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 9;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lbFechaInicio
            // 
            this.lbFechaInicio.AutoSize = true;
            this.lbFechaInicio.Location = new System.Drawing.Point(12, 9);
            this.lbFechaInicio.Name = "lbFechaInicio";
            this.lbFechaInicio.Size = new System.Drawing.Size(91, 17);
            this.lbFechaInicio.TabIndex = 10;
            this.lbFechaInicio.Text = "Fecha inicio: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "DOP$";
            // 
            // MantenimientoCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 293);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbFechaInicio);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.tbxVentasTotales);
            this.Controls.Add(this.tbxGanancias);
            this.Controls.Add(this.tbxCantidadActual);
            this.Controls.Add(this.tbxCantidadInicial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MantenimientoCaja";
            this.Text = "MantenimientoCaja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox tbxCantidadActual;
        public System.Windows.Forms.TextBox tbxGanancias;
        public System.Windows.Forms.TextBox tbxVentasTotales;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbxCantidadInicial;
        public System.Windows.Forms.Button btnInicio;
        public System.Windows.Forms.Button btnFinalizar;
        public System.Windows.Forms.Label lbFechaInicio;
        public System.Windows.Forms.Label label5;
    }
}