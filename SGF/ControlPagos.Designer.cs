namespace SGF
{
    partial class ControlPagos
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
            this.tbxp = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Location = new System.Drawing.Point(148, 11);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            // 
            // btnBorrar
            // 
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnBorrar.Location = new System.Drawing.Point(896, 11);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Visible = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnNuevo.Location = new System.Drawing.Point(857, 7);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Visible = false;
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnModificar.Location = new System.Drawing.Point(10, 11);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Text = "Pagar";
            // 
            // cbxBuscar
            // 
            this.cbxBuscar.Items.AddRange(new object[] {
            "id",
            "nombre",
            "apellido",
            "puesto",
            "salario"});
            this.cbxBuscar.Location = new System.Drawing.Point(224, 30);
            this.cbxBuscar.Margin = new System.Windows.Forms.Padding(2);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSeleccionar.Location = new System.Drawing.Point(835, 11);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccionar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1005, 67);
            // 
            // tbxp
            // 
            this.tbxp.Location = new System.Drawing.Point(134, 28);
            this.tbxp.Name = "tbxp";
            this.tbxp.Size = new System.Drawing.Size(100, 20);
            this.tbxp.TabIndex = 6;
            // 
            // ControlPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 501);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "ControlPagos";
            this.Text = "Control de Pagos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxp;
    }
}