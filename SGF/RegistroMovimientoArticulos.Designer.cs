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
            this.cbxAlmacen = new System.Windows.Forms.ComboBox();
            this.rtbxIndicaciones = new System.Windows.Forms.RichTextBox();
            this.tbxCodigoArticulo = new System.Windows.Forms.TextBox();
            this.tkbCantidad = new System.Windows.Forms.TrackBar();
            this.lbCantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(140, 294);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Almacen";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Articulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Indicaciones";
            // 
            // cbxAlmacen
            // 
            this.cbxAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAlmacen.FormattingEnabled = true;
            this.cbxAlmacen.Location = new System.Drawing.Point(140, 15);
            this.cbxAlmacen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxAlmacen.Name = "cbxAlmacen";
            this.cbxAlmacen.Size = new System.Drawing.Size(345, 24);
            this.cbxAlmacen.TabIndex = 0;
            this.cbxAlmacen.SelectedIndexChanged += new System.EventHandler(this.cbxAlmacen_SelectedIndexChanged);
            // 
            // rtbxIndicaciones
            // 
            this.rtbxIndicaciones.Location = new System.Drawing.Point(140, 139);
            this.rtbxIndicaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbxIndicaciones.Name = "rtbxIndicaciones";
            this.rtbxIndicaciones.Size = new System.Drawing.Size(345, 146);
            this.rtbxIndicaciones.TabIndex = 3;
            this.rtbxIndicaciones.Text = "";
            // 
            // tbxCodigoArticulo
            // 
            this.tbxCodigoArticulo.Location = new System.Drawing.Point(140, 47);
            this.tbxCodigoArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCodigoArticulo.Name = "tbxCodigoArticulo";
            this.tbxCodigoArticulo.ReadOnly = true;
            this.tbxCodigoArticulo.Size = new System.Drawing.Size(345, 22);
            this.tbxCodigoArticulo.TabIndex = 5;
            // 
            // tkbCantidad
            // 
            this.tkbCantidad.Location = new System.Drawing.Point(140, 76);
            this.tkbCantidad.Name = "tkbCantidad";
            this.tkbCantidad.Size = new System.Drawing.Size(345, 56);
            this.tkbCantidad.TabIndex = 6;
            this.tkbCantidad.Scroll += new System.EventHandler(this.tkbCantidad_Scroll);
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(492, 85);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(26, 17);
            this.lbCantidad.TabIndex = 7;
            this.lbCantidad.Text = "(0)";
            // 
            // RegistroMovimientoArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 369);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.tkbCantidad);
            this.Controls.Add(this.tbxCodigoArticulo);
            this.Controls.Add(this.rtbxIndicaciones);
            this.Controls.Add(this.cbxAlmacen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "RegistroMovimientoArticulos";
            this.Text = "RegistroMovimientoArticulos";
            this.Load += new System.EventHandler(this.RegistroMovimientoArticulos_Load);
            this.Shown += new System.EventHandler(this.RegistroMovimientoArticulos_Shown);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cbxAlmacen, 0);
            this.Controls.SetChildIndex(this.rtbxIndicaciones, 0);
            this.Controls.SetChildIndex(this.tbxCodigoArticulo, 0);
            this.Controls.SetChildIndex(this.tkbCantidad, 0);
            this.Controls.SetChildIndex(this.lbCantidad, 0);
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
        public System.Windows.Forms.ComboBox cbxAlmacen;
        public System.Windows.Forms.RichTextBox rtbxIndicaciones;
        public System.Windows.Forms.TextBox tbxCodigoArticulo;
        public System.Windows.Forms.TrackBar tkbCantidad;
        public System.Windows.Forms.Label lbCantidad;
    }
}