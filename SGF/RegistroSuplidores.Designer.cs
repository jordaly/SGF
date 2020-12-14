namespace SGF
{
    partial class RegistroSuplidores
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
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxRNC = new System.Windows.Forms.TextBox();
            this.lbRNC = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Location = new System.Drawing.Point(111, 173);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre :";
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCodigo.Location = new System.Drawing.Point(111, 31);
            this.tbxCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.ReadOnly = true;
            this.tbxCodigo.Size = new System.Drawing.Size(182, 22);
            this.tbxCodigo.TabIndex = 4;
            this.tbxCodigo.Text = "Nuevo";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNombre.Location = new System.Drawing.Point(111, 75);
            this.tbxNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(182, 22);
            this.tbxNombre.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 7;
            this.button1.Text = "Por RNC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxRNC
            // 
            this.tbxRNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRNC.Location = new System.Drawing.Point(111, 122);
            this.tbxRNC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxRNC.Name = "tbxRNC";
            this.tbxRNC.ReadOnly = true;
            this.tbxRNC.Size = new System.Drawing.Size(182, 22);
            this.tbxRNC.TabIndex = 9;
            // 
            // lbRNC
            // 
            this.lbRNC.AutoSize = true;
            this.lbRNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRNC.Location = new System.Drawing.Point(32, 123);
            this.lbRNC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRNC.Name = "lbRNC";
            this.lbRNC.Size = new System.Drawing.Size(48, 16);
            this.lbRNC.TabIndex = 8;
            this.lbRNC.Text = "RNC :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 125);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 10;
            this.button2.Text = "Quitar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RegistroSuplidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(401, 239);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbxRNC);
            this.Controls.Add(this.lbRNC);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegistroSuplidores";
            this.Text = "Registro de Suplidores";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tbxCodigo, 0);
            this.Controls.SetChildIndex(this.tbxNombre, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.lbRNC, 0);
            this.Controls.SetChildIndex(this.tbxRNC, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbxCodigo;
        public System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox tbxRNC;
        public System.Windows.Forms.Label lbRNC;
        private System.Windows.Forms.Button button2;
    }
}