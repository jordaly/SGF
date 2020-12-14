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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad inicial :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad actual :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ventas totales :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ganancias :";
            // 
            // tbxCantidadInicial
            // 
            this.tbxCantidadInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCantidadInicial.Location = new System.Drawing.Point(145, 51);
            this.tbxCantidadInicial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxCantidadInicial.Name = "tbxCantidadInicial";
            this.tbxCantidadInicial.Size = new System.Drawing.Size(167, 22);
            this.tbxCantidadInicial.TabIndex = 4;
            this.tbxCantidadInicial.TextChanged += new System.EventHandler(this.tbxCantidadInicial_TextChanged);
            this.tbxCantidadInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCantidadInicial_KeyPress);
            // 
            // tbxCantidadActual
            // 
            this.tbxCantidadActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCantidadActual.Location = new System.Drawing.Point(145, 89);
            this.tbxCantidadActual.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxCantidadActual.Name = "tbxCantidadActual";
            this.tbxCantidadActual.ReadOnly = true;
            this.tbxCantidadActual.Size = new System.Drawing.Size(167, 22);
            this.tbxCantidadActual.TabIndex = 5;
            this.tbxCantidadActual.Text = "0";
            this.tbxCantidadActual.TextChanged += new System.EventHandler(this.tbxCantidadActual_TextChanged);
            // 
            // tbxGanancias
            // 
            this.tbxGanancias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGanancias.Location = new System.Drawing.Point(145, 166);
            this.tbxGanancias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxGanancias.Name = "tbxGanancias";
            this.tbxGanancias.ReadOnly = true;
            this.tbxGanancias.Size = new System.Drawing.Size(167, 22);
            this.tbxGanancias.TabIndex = 6;
            this.tbxGanancias.Text = "0";
            this.tbxGanancias.TextChanged += new System.EventHandler(this.tbxGanancias_TextChanged);
            // 
            // tbxVentasTotales
            // 
            this.tbxVentasTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxVentasTotales.Location = new System.Drawing.Point(145, 126);
            this.tbxVentasTotales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxVentasTotales.Name = "tbxVentasTotales";
            this.tbxVentasTotales.ReadOnly = true;
            this.tbxVentasTotales.Size = new System.Drawing.Size(167, 22);
            this.tbxVentasTotales.TabIndex = 7;
            this.tbxVentasTotales.Text = "0";
            this.tbxVentasTotales.TextChanged += new System.EventHandler(this.tbxVentasTotales_TextChanged);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(127, 205);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(88, 29);
            this.btnInicio.TabIndex = 8;
            this.btnInicio.Text = "Iniciar";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(231, 205);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(82, 29);
            this.btnFinalizar.TabIndex = 9;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lbFechaInicio
            // 
            this.lbFechaInicio.AutoSize = true;
            this.lbFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaInicio.Location = new System.Drawing.Point(18, 9);
            this.lbFechaInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFechaInicio.Name = "lbFechaInicio";
            this.lbFechaInicio.Size = new System.Drawing.Size(100, 16);
            this.lbFechaInicio.TabIndex = 10;
            this.lbFechaInicio.Text = "Fecha inicio: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(316, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "DOP$";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // MantenimientoCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(371, 254);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MantenimientoCaja";
            this.Text = "Mantenimiento de Caja";
            this.Load += new System.EventHandler(this.MantenimientoCaja_Load);
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