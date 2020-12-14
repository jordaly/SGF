namespace SGF
{
    partial class RegistroReparacionVehiculo
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
            this.lbTituloParrafo = new System.Windows.Forms.Label();
            this.tbxMatricula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxTaller = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSeleccionarTaller = new System.Windows.Forms.Button();
            this.btnSeleccionarMatricula = new System.Windows.Forms.Button();
            this.rtbxParrafo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(129, 291);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Location = new System.Drawing.Point(119, 28);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.ReadOnly = true;
            this.tbxCodigo.Size = new System.Drawing.Size(216, 22);
            this.tbxCodigo.TabIndex = 2;
            this.tbxCodigo.Text = "Nuevo";
            // 
            // lbTituloParrafo
            // 
            this.lbTituloParrafo.AutoSize = true;
            this.lbTituloParrafo.Location = new System.Drawing.Point(114, 128);
            this.lbTituloParrafo.Name = "lbTituloParrafo";
            this.lbTituloParrafo.Size = new System.Drawing.Size(126, 17);
            this.lbTituloParrafo.TabIndex = 3;
            this.lbTituloParrafo.Text = "Razon Reparacion";
            // 
            // tbxMatricula
            // 
            this.tbxMatricula.Location = new System.Drawing.Point(119, 84);
            this.tbxMatricula.Name = "tbxMatricula";
            this.tbxMatricula.ReadOnly = true;
            this.tbxMatricula.Size = new System.Drawing.Size(216, 22);
            this.tbxMatricula.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Matricula";
            // 
            // tbxTaller
            // 
            this.tbxTaller.Location = new System.Drawing.Point(119, 56);
            this.tbxTaller.Name = "tbxTaller";
            this.tbxTaller.ReadOnly = true;
            this.tbxTaller.Size = new System.Drawing.Size(216, 22);
            this.tbxTaller.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Taller";
            // 
            // btnSeleccionarTaller
            // 
            this.btnSeleccionarTaller.Location = new System.Drawing.Point(350, 56);
            this.btnSeleccionarTaller.Name = "btnSeleccionarTaller";
            this.btnSeleccionarTaller.Size = new System.Drawing.Size(95, 23);
            this.btnSeleccionarTaller.TabIndex = 9;
            this.btnSeleccionarTaller.Text = "Seleccionar";
            this.btnSeleccionarTaller.UseVisualStyleBackColor = true;
            this.btnSeleccionarTaller.Click += new System.EventHandler(this.btnSeleccionarTaller_Click);
            // 
            // btnSeleccionarMatricula
            // 
            this.btnSeleccionarMatricula.Location = new System.Drawing.Point(350, 84);
            this.btnSeleccionarMatricula.Name = "btnSeleccionarMatricula";
            this.btnSeleccionarMatricula.Size = new System.Drawing.Size(95, 23);
            this.btnSeleccionarMatricula.TabIndex = 10;
            this.btnSeleccionarMatricula.Text = "Seleccionar";
            this.btnSeleccionarMatricula.UseVisualStyleBackColor = true;
            this.btnSeleccionarMatricula.Click += new System.EventHandler(this.btnSeleccionarMatricula_Click);
            // 
            // rtbxParrafo
            // 
            this.rtbxParrafo.Location = new System.Drawing.Point(119, 148);
            this.rtbxParrafo.MaxLength = 200;
            this.rtbxParrafo.Name = "rtbxParrafo";
            this.rtbxParrafo.Size = new System.Drawing.Size(326, 93);
            this.rtbxParrafo.TabIndex = 11;
            this.rtbxParrafo.Text = "";
            // 
            // RegistroReparacionVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 352);
            this.Controls.Add(this.rtbxParrafo);
            this.Controls.Add(this.btnSeleccionarMatricula);
            this.Controls.Add(this.btnSeleccionarTaller);
            this.Controls.Add(this.tbxTaller);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxMatricula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTituloParrafo);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.label1);
            this.Name = "RegistroReparacionVehiculo";
            this.Text = "RegistroReparacionVehiculo";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbxCodigo, 0);
            this.Controls.SetChildIndex(this.lbTituloParrafo, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.tbxMatricula, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.tbxTaller, 0);
            this.Controls.SetChildIndex(this.btnSeleccionarTaller, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnSeleccionarMatricula, 0);
            this.Controls.SetChildIndex(this.rtbxParrafo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbxCodigo;
        public System.Windows.Forms.Label lbTituloParrafo;
        public System.Windows.Forms.TextBox tbxMatricula;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbxTaller;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnSeleccionarTaller;
        public System.Windows.Forms.Button btnSeleccionarMatricula;
        public System.Windows.Forms.RichTextBox rtbxParrafo;
    }
}