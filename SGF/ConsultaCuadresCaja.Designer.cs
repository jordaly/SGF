namespace SGF
{
    partial class ConsultaCuadresCaja
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
            this.dtDesde = new System.Windows.Forms.DateTimePicker();
            this.dtHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(119, 15);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(890, 13);
            this.btnBorrar.Visible = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(890, 15);
            this.btnNuevo.Visible = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(890, 13);
            this.btnModificar.Visible = false;
            // 
            // cbxBuscar
            // 
            this.cbxBuscar.Location = new System.Drawing.Point(1007, 36);
            this.cbxBuscar.Size = new System.Drawing.Size(160, 24);
            this.cbxBuscar.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1007, 13);
            this.label1.Visible = false;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Enabled = true;
            this.btnSeleccionar.Location = new System.Drawing.Point(15, 15);
            this.btnSeleccionar.Text = "Refrescar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtHasta);
            this.panel1.Controls.Add(this.dtDesde);
            this.panel1.Size = new System.Drawing.Size(848, 82);
            this.panel1.Controls.SetChildIndex(this.btnModificar, 0);
            this.panel1.Controls.SetChildIndex(this.btnNuevo, 0);
            this.panel1.Controls.SetChildIndex(this.btnBorrar, 0);
            this.panel1.Controls.SetChildIndex(this.btnBuscar, 0);
            this.panel1.Controls.SetChildIndex(this.cbxBuscar, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.btnSeleccionar, 0);
            this.panel1.Controls.SetChildIndex(this.dtDesde, 0);
            this.panel1.Controls.SetChildIndex(this.dtHasta, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.label3, 0);
            // 
            // dtDesde
            // 
            this.dtDesde.Location = new System.Drawing.Point(246, 42);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(268, 22);
            this.dtDesde.TabIndex = 7;
            // 
            // dtHasta
            // 
            this.dtHasta.Location = new System.Drawing.Point(536, 42);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(268, 22);
            this.dtHasta.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(636, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Desde:";
            // 
            // ConsultaCuadresCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 450);
            this.Name = "ConsultaCuadresCaja";
            this.Text = "ConsultaCuadresCaja";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dtHasta;
        public System.Windows.Forms.DateTimePicker dtDesde;
    }
}