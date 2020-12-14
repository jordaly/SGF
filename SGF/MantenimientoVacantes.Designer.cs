namespace SGF
{
    partial class MantenimientoVacantes
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            // 
            // btnBorrar
            // 
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnNuevo.Text = "Nueva Persona";
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            // 
            // cbxBuscar
            // 
            this.cbxBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.cbxBuscar.Size = new System.Drawing.Size(157, 24);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Enabled = true;
            this.btnSeleccionar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSeleccionar.Text = "Seleccionar Persona";
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(707, 67);
            // 
            // MantenimientoVacantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 435);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "MantenimientoVacantes";
            this.Text = "Rgistro Contratacion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}