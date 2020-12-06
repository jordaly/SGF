namespace SGF
{
    partial class MantenimientoInventario
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
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxBuscar
            // 
            this.cbxBuscar.Items.AddRange(new object[] {
            "id",
            "nombre_articulo",
            "precio_compra",
            "precio_venta",
            "existencia",
            "descripcion",
            "cantidad_maxima",
            "cantidad_minima",
            "fecha_renovacion",
            "medida",
            "categoria",
            "marca",
            "estado"});
            this.cbxBuscar.Size = new System.Drawing.Size(160, 24);
            // 
            // MantenimientoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "MantenimientoInventario";
            this.Text = "MantenimientoInventario";
            this.Load += new System.EventHandler(this.MantenimientoInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}