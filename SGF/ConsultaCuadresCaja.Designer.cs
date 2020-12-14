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
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Location = new System.Drawing.Point(151, 12);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            // 
            // btnBorrar
            // 
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnBorrar.Location = new System.Drawing.Point(806, 11);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Visible = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnNuevo.Location = new System.Drawing.Point(806, 12);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Visible = false;
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnModificar.Location = new System.Drawing.Point(806, 11);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Visible = false;
            // 
            // cbxBuscar
            // 
            this.cbxBuscar.Location = new System.Drawing.Point(893, 29);
            this.cbxBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.cbxBuscar.Size = new System.Drawing.Size(121, 24);
            this.cbxBuscar.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(893, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Visible = false;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Enabled = true;
            this.btnSeleccionar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSeleccionar.Image = global::SGF.Properties.Resources.arrowreload_flecha_1318;
            this.btnSeleccionar.Location = new System.Drawing.Point(11, 12);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccionar.Size = new System.Drawing.Size(118, 42);
            this.btnSeleccionar.Text = "Refrescar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtHasta);
            this.panel1.Controls.Add(this.dtDesde);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(729, 67);
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
            this.dtDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDesde.Location = new System.Drawing.Point(232, 32);
            this.dtDesde.Margin = new System.Windows.Forms.Padding(2);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(242, 22);
            this.dtDesde.TabIndex = 7;
            // 
            // dtHasta
            // 
            this.dtHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHasta.Location = new System.Drawing.Point(478, 32);
            this.dtHasta.Margin = new System.Windows.Forms.Padding(2);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(242, 22);
            this.dtHasta.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(555, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Desde:";
            // 
            // ConsultaCuadresCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 366);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "ConsultaCuadresCaja";
            this.Text = "Consultar Cuadres de Caja";
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