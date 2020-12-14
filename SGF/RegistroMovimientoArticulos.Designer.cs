namespace SGF
{
    partial class RegistroMovimientoArticulos
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
            this.rtbxIndicaciones = new System.Windows.Forms.RichTextBox();
            this.tbxCodigoArticulo = new System.Windows.Forms.TextBox();
            this.tkbCantidad = new System.Windows.Forms.TrackBar();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxCodigoAlmacen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Location = new System.Drawing.Point(126, 343);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Almacen :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Articulo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Indicaciones :";
            // 
            // rtbxIndicaciones
            // 
            this.rtbxIndicaciones.Location = new System.Drawing.Point(126, 197);
            this.rtbxIndicaciones.Name = "rtbxIndicaciones";
            this.rtbxIndicaciones.Size = new System.Drawing.Size(260, 119);
            this.rtbxIndicaciones.TabIndex = 3;
            this.rtbxIndicaciones.Text = "";
            // 
            // tbxCodigoArticulo
            // 
            this.tbxCodigoArticulo.Location = new System.Drawing.Point(127, 61);
            this.tbxCodigoArticulo.Name = "tbxCodigoArticulo";
            this.tbxCodigoArticulo.ReadOnly = true;
            this.tbxCodigoArticulo.Size = new System.Drawing.Size(260, 20);
            this.tbxCodigoArticulo.TabIndex = 5;
            // 
            // tkbCantidad
            // 
            this.tkbCantidad.Location = new System.Drawing.Point(126, 124);
            this.tkbCantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tkbCantidad.Name = "tkbCantidad";
            this.tkbCantidad.Size = new System.Drawing.Size(259, 45);
            this.tkbCantidad.TabIndex = 6;
            this.tkbCantidad.Scroll += new System.EventHandler(this.tkbCantidad_Scroll);
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.Location = new System.Drawing.Point(389, 129);
            this.lbCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(23, 16);
            this.lbCantidad.TabIndex = 7;
            this.lbCantidad.Text = "(0)";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::SGF.Properties.Resources.taconeador;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(406, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Seleccionar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxCodigoAlmacen
            // 
            this.tbxCodigoAlmacen.Location = new System.Drawing.Point(127, 17);
            this.tbxCodigoAlmacen.Name = "tbxCodigoAlmacen";
            this.tbxCodigoAlmacen.ReadOnly = true;
            this.tbxCodigoAlmacen.Size = new System.Drawing.Size(260, 20);
            this.tbxCodigoAlmacen.TabIndex = 9;
            // 
            // RegistroMovimientoArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(543, 409);
            this.Controls.Add(this.tbxCodigoAlmacen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.tkbCantidad);
            this.Controls.Add(this.tbxCodigoArticulo);
            this.Controls.Add(this.rtbxIndicaciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "RegistroMovimientoArticulos";
            this.Text = "Registro de Movimiento de Articulos";
            this.Load += new System.EventHandler(this.RegistroMovimientoArticulos_Load);
            this.Shown += new System.EventHandler(this.RegistroMovimientoArticulos_Shown);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.rtbxIndicaciones, 0);
            this.Controls.SetChildIndex(this.tbxCodigoArticulo, 0);
            this.Controls.SetChildIndex(this.tkbCantidad, 0);
            this.Controls.SetChildIndex(this.lbCantidad, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.tbxCodigoAlmacen, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.RichTextBox rtbxIndicaciones;
        public System.Windows.Forms.TextBox tbxCodigoArticulo;
        public System.Windows.Forms.TrackBar tkbCantidad;
        public System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox tbxCodigoAlmacen;
    }
}