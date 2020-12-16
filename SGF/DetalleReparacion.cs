using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGF
{
    public partial class DetalleReparacion : FormBase
    {
        public string idReparacion = "";
        public DetalleReparacion()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (ComprobarCamposFactura())
            {
               


                    foreach (DataGridViewRow fila in gridarticulosuplidor.Rows)
                    {
                        cmd = "begin " +
                            "insert into detalle_reparacion(idReparacion,reparacion,cantidad,costo)values('"+idReparacion+"','"+ fila.Cells[0].Value.ToString() + "','"+ fila.Cells[2].Value.ToString() + "','"+ fila.Cells[1].Value.ToString().Replace(",", ".") + "');" +
                            "end";
                        ds = Utilidades.EjecutarDS(cmd);
                    }
                    this.Close();
        
            }
            
        }

            public bool ComprobarCamposArticulos()
            {

                ErrorProvider.Clear();
                bool ok = true;
                if (txtcantidad.Text == "")
                {
                    ok = false;

                    ErrorProvider.SetError(txtcantidad, "Este campo no puede estar vasio.");
                }
                if (tbxreparacion.Text == "")
                {
                    ok = false;

                    ErrorProvider.SetError(tbxreparacion, "Este campo no puede estar vasio.");

                }
                if (tbxcosto.Text == "")
                {
                    ok = false;

                    ErrorProvider.SetError(tbxcosto, "Este campo no puede estar vasio.");
                }



                return ok;
            }

            public bool ComprobarCamposFactura()
            {
                ErrorProvider.Clear();
                bool ok = true;
            if (gridarticulosuplidor.Rows.Count < 1)
            {
                ok = false;

                ErrorProvider.SetError(gridarticulosuplidor, "Debe haber al menos un articulo para poder facturar.");
            }



                return ok;
            }

        public static int cont_fila = 0;
        public static double total;
        public string codigo_empleado;
        public string codigo_usuario;
        private void btnagregararticulo_Click(object sender, EventArgs e)
        {
            if (ComprobarCamposArticulos())
            {

                bool existe = false;
                int num_fila = 0;

                if (cont_fila == 0)
                {
                    gridarticulosuplidor.Rows.Add( tbxreparacion.Text, tbxcosto.Text, txtcantidad.Text);
                    double importe = (Convert.ToDouble(gridarticulosuplidor.Rows[cont_fila].Cells[1].Value) * Convert.ToDouble(gridarticulosuplidor.Rows[cont_fila].Cells[2].Value));
                    gridarticulosuplidor.Rows[cont_fila].Cells[3].Value = importe;

                    cont_fila++;
                }
                else
                {
                    foreach (DataGridViewRow fila in gridarticulosuplidor.Rows)
                    {
                        if (fila.Cells[0].Value.ToString() == tbxreparacion.Text.Trim())
                        {
                            existe = true;
                            num_fila = fila.Index;
                        }
                    }
                    if (existe == true)
                    {
                        //MessageBox.Show(""+num_fila);
                        gridarticulosuplidor.Rows[num_fila].Cells[2].Value = Convert.ToDouble(txtcantidad.Text) + (Convert.ToDouble(gridarticulosuplidor.Rows[num_fila].Cells[2].Value));

                        double importe = (Convert.ToDouble(gridarticulosuplidor.Rows[cont_fila].Cells[1].Value) * Convert.ToDouble(gridarticulosuplidor.Rows[cont_fila].Cells[2].Value));

                        gridarticulosuplidor.Rows[num_fila].Cells[3].Value = importe;

                    }
                    else
                    {

                        gridarticulosuplidor.Rows.Add(tbxreparacion.Text, tbxcosto.Text, txtcantidad.Text);
                        double importe = (Convert.ToDouble(gridarticulosuplidor.Rows[cont_fila].Cells[1].Value) * Convert.ToDouble(gridarticulosuplidor.Rows[cont_fila].Cells[2].Value));
                        gridarticulosuplidor.Rows[cont_fila].Cells[3].Value = importe;

                        cont_fila++;
                    }
                   
                }
                total = 0;

                foreach (DataGridViewRow fila in gridarticulosuplidor.Rows)
                {
                    total += Convert.ToDouble(fila.Cells[3].Value);
                }
                txttotal.Text = "RD$ " + total.ToString();


                txtcantidad.Text = "";
            }
        }

        private void btnquitararticulo_Click(object sender, EventArgs e)
        {
            if (cont_fila > 0)
            {
                total = total - (Convert.ToDouble(gridarticulosuplidor.Rows[gridarticulosuplidor.CurrentRow.Index].Cells[3].Value));
                txttotal.Text = "RD$ " + total.ToString();

                gridarticulosuplidor.Rows.RemoveAt(gridarticulosuplidor.CurrentRow.Index);

                cont_fila--;
            }
        }

        private void btnagregararticulo_Click_1(object sender, EventArgs e)
        {
            btnagregararticulo_Click(sender, e);
        }

        private void btnquitararticulo_Click_1(object sender, EventArgs e)
        {
            if (cont_fila > 0)
            {
                total = total - (Convert.ToDouble(gridarticulosuplidor.Rows[gridarticulosuplidor.CurrentRow.Index].Cells[3].Value));
                txttotal.Text = "RD$ " + total.ToString();

                gridarticulosuplidor.Rows.RemoveAt(gridarticulosuplidor.CurrentRow.Index);

                cont_fila--;
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            gridarticulosuplidor.Rows.Clear();
            tbxcosto.Text = "";
            tbxreparacion.Text = "";
            txtcantidad.Text = "";
            tbxreparacion.Focus();
        }

        private void tbxcosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.SoloNumeros(e, sender);
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.SoloNumerosEnteros(e, sender);
        }
    }
    
}
