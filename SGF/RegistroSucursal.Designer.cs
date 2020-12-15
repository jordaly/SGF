namespace SGF
{
    partial class RegistroSucursal
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
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.tbxAlmacen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.btnSeleccionarAlmacen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Location = new System.Drawing.Point(163, 173);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Location = new System.Drawing.Point(163, 26);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.ReadOnly = true;
            this.tbxCodigo.Size = new System.Drawing.Size(238, 22);
            this.tbxCodigo.TabIndex = 2;
            this.tbxCodigo.Text = "Nuevo";
            // 
            // tbxAlmacen
            // 
            this.tbxAlmacen.Location = new System.Drawing.Point(163, 82);
            this.tbxAlmacen.Name = "tbxAlmacen";
            this.tbxAlmacen.ReadOnly = true;
            this.tbxAlmacen.Size = new System.Drawing.Size(238, 22);
            this.tbxAlmacen.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Almacen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre Sucursal";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(163, 54);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(238, 22);
            this.tbxNombre.TabIndex = 8;
            // 
            // btnSeleccionarAlmacen
            // 
            this.btnSeleccionarAlmacen.Location = new System.Drawing.Point(416, 82);
            this.btnSeleccionarAlmacen.Name = "btnSeleccionarAlmacen";
            this.btnSeleccionarAlmacen.Size = new System.Drawing.Size(99, 23);
            this.btnSeleccionarAlmacen.TabIndex = 9;
            this.btnSeleccionarAlmacen.Text = "Seleccionar";
            this.btnSeleccionarAlmacen.UseVisualStyleBackColor = true;
            this.btnSeleccionarAlmacen.Click += new System.EventHandler(this.btnSeleccionarAlmacen_Click);
            // 
            // RegistroSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 277);
            this.Controls.Add(this.btnSeleccionarAlmacen);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxAlmacen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.label1);
            this.Name = "RegistroSucursal";
            this.Text = "RegistroSucursal";
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbxCodigo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tbxAlmacen, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.tbxNombre, 0);
            this.Controls.SetChildIndex(this.btnSeleccionarAlmacen, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbxCodigo;
        public System.Windows.Forms.TextBox tbxAlmacen;
        public System.Windows.Forms.TextBox tbxNombre;
        public System.Windows.Forms.Button btnSeleccionarAlmacen;
    }
}