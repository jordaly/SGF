namespace SGF
{
    partial class RegistroVehiculo
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
            this.tbxMatricula = new System.Windows.Forms.TextBox();
            this.tbxModelo = new System.Windows.Forms.TextBox();
            this.tbxMarca = new System.Windows.Forms.TextBox();
            this.btnSeleccionarMarca = new System.Windows.Forms.Button();
            this.btnSeleccionarModelo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(147, 149);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Modelo";
            // 
            // tbxMatricula
            // 
            this.tbxMatricula.Location = new System.Drawing.Point(147, 26);
            this.tbxMatricula.MaxLength = 10;
            this.tbxMatricula.Name = "tbxMatricula";
            this.tbxMatricula.Size = new System.Drawing.Size(185, 22);
            this.tbxMatricula.TabIndex = 6;
            // 
            // tbxModelo
            // 
            this.tbxModelo.Location = new System.Drawing.Point(147, 82);
            this.tbxModelo.Name = "tbxModelo";
            this.tbxModelo.ReadOnly = true;
            this.tbxModelo.Size = new System.Drawing.Size(185, 22);
            this.tbxModelo.TabIndex = 9;
            // 
            // tbxMarca
            // 
            this.tbxMarca.Location = new System.Drawing.Point(147, 54);
            this.tbxMarca.Name = "tbxMarca";
            this.tbxMarca.ReadOnly = true;
            this.tbxMarca.Size = new System.Drawing.Size(185, 22);
            this.tbxMarca.TabIndex = 10;
            // 
            // btnSeleccionarMarca
            // 
            this.btnSeleccionarMarca.Location = new System.Drawing.Point(353, 54);
            this.btnSeleccionarMarca.Name = "btnSeleccionarMarca";
            this.btnSeleccionarMarca.Size = new System.Drawing.Size(99, 23);
            this.btnSeleccionarMarca.TabIndex = 11;
            this.btnSeleccionarMarca.Text = "Seleccionar";
            this.btnSeleccionarMarca.UseVisualStyleBackColor = true;
            this.btnSeleccionarMarca.Click += new System.EventHandler(this.btnSeleccionarMarca_Click);
            // 
            // btnSeleccionarModelo
            // 
            this.btnSeleccionarModelo.Location = new System.Drawing.Point(353, 82);
            this.btnSeleccionarModelo.Name = "btnSeleccionarModelo";
            this.btnSeleccionarModelo.Size = new System.Drawing.Size(99, 23);
            this.btnSeleccionarModelo.TabIndex = 12;
            this.btnSeleccionarModelo.Text = "Seleccionar";
            this.btnSeleccionarModelo.UseVisualStyleBackColor = true;
            this.btnSeleccionarModelo.Click += new System.EventHandler(this.btnSeleccionarModelo_Click);
            // 
            // RegistroVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 198);
            this.Controls.Add(this.btnSeleccionarModelo);
            this.Controls.Add(this.btnSeleccionarMarca);
            this.Controls.Add(this.tbxMarca);
            this.Controls.Add(this.tbxModelo);
            this.Controls.Add(this.tbxMatricula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroVehiculo";
            this.Text = "RegistroVehiculo";
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.tbxMatricula, 0);
            this.Controls.SetChildIndex(this.tbxModelo, 0);
            this.Controls.SetChildIndex(this.tbxMarca, 0);
            this.Controls.SetChildIndex(this.btnSeleccionarMarca, 0);
            this.Controls.SetChildIndex(this.btnSeleccionarModelo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbxMatricula;
        public System.Windows.Forms.TextBox tbxModelo;
        public System.Windows.Forms.TextBox tbxMarca;
        public System.Windows.Forms.Button btnSeleccionarMarca;
        public System.Windows.Forms.Button btnSeleccionarModelo;
    }
}