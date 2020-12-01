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
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(117, 13);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(1194, 13);
            this.btnBorrar.Visible = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(1148, 12);
            this.btnNuevo.Visible = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(13, 13);
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
            this.cbxBuscar.Location = new System.Drawing.Point(221, 39);
            this.cbxBuscar.Size = new System.Drawing.Size(160, 24);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(221, 13);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(1044, 13);
            this.btnSeleccionar.Visible = false;
            // 
            // tbxp
            // 
            this.tbxp.Location = new System.Drawing.Point(134, 28);
            this.tbxp.Name = "tbxp";
            this.tbxp.Size = new System.Drawing.Size(100, 22);
            this.tbxp.TabIndex = 6;
            // 
            // ControlPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 617);
            this.Name = "ControlPagos";
            this.Text = "ControlPagos";
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxp;
    }
}