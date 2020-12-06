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
    public partial class FrmCompra : Form
    {
        public FrmCompra()
        {
            InitializeComponent();
        }

        public string codigo_suplidor = "";

        private void btnbuscarsuplidor_Click(object sender, EventArgs e)
        {

            MantenimientoSuplidores frm = new MantenimientoSuplidores();
            frm.btnBorrar.Enabled = false;
            frm.btnModificar.Enabled = false;
            frm.btnNuevo.Enabled = true;
            frm.btnSeleccionar.Enabled = true;
            frm.ShowDialog();

            txtsuplidor.Text = frm.nombre_suplidor_apellido_suplidor;
            lbcodigosuplidor.Text = "Codigo Cliente: " + frm.codigo_suplidor;
        }

        public string codigo_cliente = "";
        public string nombre_suplidor_apellido_suplidor = "";

        public string codigo_articulo = "";
        public string nombre_articulo = "";
        public string stock_articulo = "";
        public string precio_articulo_compra = "";
        public string itebis = "";
        private void btnbuscararticulo_Click(object sender, EventArgs e)
        {
            MantenimientoInventario frm = new MantenimientoInventario();

            frm.btnBorrar.Enabled = false;
            frm.btnModificar.Enabled = false;
            frm.btnNuevo.Enabled = false;
            frm.btnSeleccionar.Enabled = true;
            frm.ShowDialog();

            codigo_articulo = frm.codigo_articulo;
            nombre_articulo = frm.nombre_articulo;
            stock_articulo = frm.stock_articulo;
            precio_articulo_compra = frm.precio_articulo_compra;
            itebis = frm.itebis;

            lbcodigoarticulo.Text = " Codigo Articulo: " + codigo_articulo;
            txtarticulo.Text = nombre_articulo;
            lbstock.Text = "STOCK: " + stock_articulo;
            txtpreciocompra.Text = precio_articulo_compra;
            txtitebis.Text = itebis;
        }

        public static int cont_fila = 0;
        public static double total;
        private void btnagregararticulo_Click(object sender, EventArgs e)
        {
            if (lbnumfactura.Text == "" || cbxsucursal.Text == "" || cbxtipofactura.Text == "" || txtsuplidor.Text == "" || txtrnc.Text == "" || cbxtipopago.Text == "" || cbxdivisa.Text == "" || txtarticulo.Text == "" || txtcantidad.Text == "")
            {
                bool existe = false;
                int num_fila = 0;

                if (cont_fila == 0)
                {
                    gridarticulosuplidor.Rows.Add(codigo_articulo, txtarticulo.Text, txtpreciocompra.Text, txtitebis.Text, txtcantidad.Text);
                    double importe = (Convert.ToDouble(gridarticulosuplidor.Rows[cont_fila].Cells[2].Value) + (Convert.ToDouble(gridarticulosuplidor.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(gridarticulosuplidor.Rows[cont_fila].Cells[3].Value))) * Convert.ToDouble(gridarticulosuplidor.Rows[cont_fila].Cells[4].Value);
                    gridarticulosuplidor.Rows[cont_fila].Cells[5].Value = importe;

                    cont_fila++;
                }
                else
                {
                    foreach (DataGridViewRow fila in gridarticulosuplidor.Rows)
                    {
                        if (fila.Cells[0].Value.ToString() == codigo_articulo)
                        {
                            existe = true;
                            num_fila = fila.Index;
                        }
                    }

                    if (existe == true)
                    {
                        //MessageBox.Show(""+num_fila);
                        gridarticulosuplidor.Rows[num_fila].Cells[4].Value = Convert.ToDouble(txtcantidad.Text) + (Convert.ToDouble(gridarticulosuplidor.Rows[num_fila].Cells[4].Value));

                        double importe = (Convert.ToDouble(gridarticulosuplidor.Rows[num_fila].Cells[2].Value) + (Convert.ToDouble(gridarticulosuplidor.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(gridarticulosuplidor.Rows[num_fila].Cells[3].Value))) * (Convert.ToDouble(gridarticulosuplidor.Rows[num_fila].Cells[4].Value));

                        gridarticulosuplidor.Rows[num_fila].Cells[5].Value = importe;

                    }
                    else
                    {
                        gridarticulosuplidor.Rows.Add(codigo_articulo, txtarticulo.Text, txtpreciocompra.Text, txtitebis.Text, txtcantidad.Text);
                        double importe = (Convert.ToDouble(gridarticulosuplidor.Rows[cont_fila].Cells[2].Value) + (Convert.ToDouble(gridarticulosuplidor.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(gridarticulosuplidor.Rows[cont_fila].Cells[3].Value))) * Convert.ToDouble(gridarticulosuplidor.Rows[cont_fila].Cells[4].Value);
                        gridarticulosuplidor.Rows[cont_fila].Cells[5].Value = importe;

                        cont_fila++;
                    }
                }
                total = 0;

                foreach (DataGridViewRow fila in gridarticulosuplidor.Rows)
                {
                    total += Convert.ToDouble(fila.Cells[5].Value);
                }
                txttotal.Text = "RD$ " + total.ToString();
            }

            txtcantidad.Text = "";

        }

        private void btnquitararticulo_Click(object sender, EventArgs e)
        {
            if (cont_fila > 0)
            {
                total = total - (Convert.ToDouble(gridarticulosuplidor.Rows[gridarticulosuplidor.CurrentRow.Index].Cells[5].Value));
                txttotal.Text = "RD$ " + total.ToString();

                gridarticulosuplidor.Rows.RemoveAt(gridarticulosuplidor.CurrentRow.Index);

                cont_fila--;
            }
        }
    }
}
