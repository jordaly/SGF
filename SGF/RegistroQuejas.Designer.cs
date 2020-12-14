namespace SGF
{
    partial class RegistroQuejas
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
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbxParrafo = new System.Windows.Forms.RichTextBox();
            this.tbxCliente = new System.Windows.Forms.TextBox();
            this.btnSeleccionarCliente = new System.Windows.Forms.Button();
            this.lbTituloRTBX = new System.Windows.Forms.Label();
            this.tbnSeleccionarArticulos = new System.Windows.Forms.Button();
            this.tbxArticulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(164, 399);
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Location = new System.Drawing.Point(164, 86);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.ReadOnly = true;
            this.tbxCodigo.Size = new System.Drawing.Size(300, 22);
            this.tbxCodigo.TabIndex = 1;
            this.tbxCodigo.Text = "Nuevo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Codigo";
            // 
            // rtbxParrafo
            // 
            this.rtbxParrafo.Location = new System.Drawing.Point(63, 205);
            this.rtbxParrafo.MaxLength = 200;
            this.rtbxParrafo.Name = "rtbxParrafo";
            this.rtbxParrafo.Size = new System.Drawing.Size(482, 156);
            this.rtbxParrafo.TabIndex = 7;
            this.rtbxParrafo.Text = "";
            // 
            // tbxCliente
            // 
            this.tbxCliente.Location = new System.Drawing.Point(164, 114);
            this.tbxCliente.Name = "tbxCliente";
            this.tbxCliente.ReadOnly = true;
            this.tbxCliente.Size = new System.Drawing.Size(300, 22);
            this.tbxCliente.TabIndex = 8;
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(470, 113);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(90, 23);
            this.btnSeleccionarCliente.TabIndex = 9;
            this.btnSeleccionarCliente.Text = "Seleccionar";
            this.btnSeleccionarCliente.UseVisualStyleBackColor = true;
            this.btnSeleccionarCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbTituloRTBX
            // 
            this.lbTituloRTBX.AutoSize = true;
            this.lbTituloRTBX.Location = new System.Drawing.Point(61, 185);
            this.lbTituloRTBX.Name = "lbTituloRTBX";
            this.lbTituloRTBX.Size = new System.Drawing.Size(46, 17);
            this.lbTituloRTBX.TabIndex = 10;
            this.lbTituloRTBX.Text = "Queja";
            // 
            // tbnSeleccionarArticulos
            // 
            this.tbnSeleccionarArticulos.Location = new System.Drawing.Point(470, 141);
            this.tbnSeleccionarArticulos.Name = "tbnSeleccionarArticulos";
            this.tbnSeleccionarArticulos.Size = new System.Drawing.Size(90, 23);
            this.tbnSeleccionarArticulos.TabIndex = 13;
            this.tbnSeleccionarArticulos.Text = "Seleccionar";
            this.tbnSeleccionarArticulos.UseVisualStyleBackColor = true;
            this.tbnSeleccionarArticulos.Click += new System.EventHandler(this.tbnSeleccionarArticulos_Click);
            // 
            // tbxArticulo
            // 
            this.tbxArticulo.Location = new System.Drawing.Point(164, 142);
            this.tbxArticulo.Name = "tbxArticulo";
            this.tbxArticulo.ReadOnly = true;
            this.tbxArticulo.Size = new System.Drawing.Size(300, 22);
            this.tbxArticulo.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Articulo";
            // 
            // RegistroQuejas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 474);
            this.Controls.Add(this.tbnSeleccionarArticulos);
            this.Controls.Add(this.tbxArticulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTituloRTBX);
            this.Controls.Add(this.btnSeleccionarCliente);
            this.Controls.Add(this.tbxCliente);
            this.Controls.Add(this.rtbxParrafo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxCodigo);
            this.Name = "RegistroQuejas";
            this.Text = "RegistroQuejas";
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.tbxCodigo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.rtbxParrafo, 0);
            this.Controls.SetChildIndex(this.tbxCliente, 0);
            this.Controls.SetChildIndex(this.btnSeleccionarCliente, 0);
            this.Controls.SetChildIndex(this.lbTituloRTBX, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.tbxArticulo, 0);
            this.Controls.SetChildIndex(this.tbnSeleccionarArticulos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbxCodigo;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.RichTextBox rtbxParrafo;
        public System.Windows.Forms.TextBox tbxCliente;
        public System.Windows.Forms.Button btnSeleccionarCliente;
        public System.Windows.Forms.Label lbTituloRTBX;
        public System.Windows.Forms.Button tbnSeleccionarArticulos;
        public System.Windows.Forms.TextBox tbxArticulo;
        public System.Windows.Forms.Label label4;
    }
}