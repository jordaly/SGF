namespace SGF
{
    partial class MantenimientoReparacionVehiculo
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Location = new System.Drawing.Point(722, 16);
            // 
            // btnBorrar
            // 
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnBorrar.Location = new System.Drawing.Point(433, 16);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            // 
            // cbxBuscar
            // 
            this.cbxBuscar.Items.AddRange(new object[] {
            "id",
            "idTaller",
            "matricula_vehiculo",
            "razon_reparacion",
            "fecha_inicio"});
            this.cbxBuscar.Location = new System.Drawing.Point(826, 36);
            this.cbxBuscar.Size = new System.Drawing.Size(160, 28);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(826, 12);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Size = new System.Drawing.Size(1063, 82);
            this.panel1.Controls.SetChildIndex(this.btnModificar, 0);
            this.panel1.Controls.SetChildIndex(this.btnNuevo, 0);
            this.panel1.Controls.SetChildIndex(this.btnBorrar, 0);
            this.panel1.Controls.SetChildIndex(this.cbxBuscar, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.btnSeleccionar, 0);
            this.panel1.Controls.SetChildIndex(this.btnBuscar, 0);
            this.panel1.Controls.SetChildIndex(this.button1, 0);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(572, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MantenimientoReparacionVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 450);
            this.Name = "MantenimientoReparacionVehiculo";
            this.Text = "MantenimientoReparacionVehiculo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
    }
}