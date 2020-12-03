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
    public partial class FrmVentas : FormBase
    {
        public FrmVentas()
        {
            InitializeComponent();
            lbfecha.Text +=" "+ DateTime.Now.Day +"/"+DateTime.Now.Month +"/"+ DateTime.Now.Year;
        }

        public string codigo_cliente="";
        private void btnbuscarcliente_Click(object sender, EventArgs e)
        {
            MantenimientoClientes frm = new MantenimientoClientes();
            frm.btnBorrar.Enabled = false;
            frm.btnModificar.Enabled = false;
            frm.btnNuevo.Enabled = true;
            frm.btnSeleccionar.Enabled = true;
            frm.ShowDialog();

            txtcliente.Text = frm.nombre_cliente_apellido_cliente;
            lbcodigo.Text ="Codigo Cliente: " + frm.codigo_cliente;
        }

        public string codigo_articulo = "";
        public string nombre_articulo = "";
        public string stock_articulo = "";
        public string precio_articulo = "";
        private void btnbuscararticulo_Click(object sender, EventArgs e)
        {
            MantenimientoInventario frm = new MantenimientoInventario();

            frm.btnBorrar.Enabled = false;
            frm.btnModificar.Enabled = false;
            frm.btnNuevo.Enabled = false;
            frm.btnSeleccionar.Enabled = true;
            frm.ShowDialog();

            codigo_articulo =  frm.codigo_articulo;
            nombre_articulo = frm.nombre_articulo;
            stock_articulo = frm.stock_articulo;
            precio_articulo = frm.precio_articulo;

            lbcodigoarticulo.Text =" Codigo Articulo: " +codigo_articulo;
            txtarticulo.Text = nombre_articulo;
            lbstock.Text = stock_articulo;
            txtprecioventa.Text = precio_articulo;
        }

        public void validar()
        {
            lbnumfactura.Text = "";
            cbxsucursal.Text = "";
            cbxtipofactura.Text = "";
            txtcliente.Text = "";
            txtrnc.Text = "";
            cbxtipopago.Text = "";
            cbxdivisa.Text = "";
        }

        public static int cont_fila = 0;
        private void btnagregararticulo_Click(object sender, EventArgs e)
        {
            if ( lbnumfactura.Text == "" || cbxsucursal.Text == "" || cbxtipofactura.Text == "" ||txtcliente.Text == "" || txtrnc.Text == "" || cbxtipopago.Text == "" ||cbxdivisa.Text == "" || txtarticulo.Text=="" || txtcantidad.Text=="")
            {
                bool existe = false;
                int num_fila = 0;

                if (cont_fila == 0)
                {
                    gridarticulo.Rows.Add(codigo_articulo, txtarticulo.Text, txtprecioventa.Text,txtitebis.Text, txtcantidad.Text);
                    double importe= (Convert.ToDouble(gridarticulo.Rows[cont_fila].Cells[2].Value)+(Convert.ToDouble(gridarticulo.Rows[cont_fila].Cells[2].Value)* Convert.ToDouble(gridarticulo.Rows[cont_fila].Cells[3].Value))) * Convert.ToDouble(gridarticulo.Rows[cont_fila].Cells[4].Value);
                    gridarticulo.Rows[cont_fila].Cells[5].Value = importe;

                    cont_fila++;
                }
                else
                {
                    foreach (DataGridViewRow fila in gridarticulo.Rows)
                    {
                        if (fila.Cells[0].Value.ToString()==codigo_articulo)
                        {
                            existe = true;
                            num_fila = fila.Index;
                        }
                    }

                    if (existe == true)
                    {
                        gridarticulo.Rows[num_fila].Cells[4].Value = Convert.ToDouble(txtcantidad.Text) + (Convert.ToDouble(gridarticulo.Rows[num_fila].Cells[4].Value)).ToString();

                        double importe = (Convert.ToDouble(gridarticulo.Rows[cont_fila].Cells[2].Value) + (Convert.ToDouble(gridarticulo.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(gridarticulo.Rows[cont_fila].Cells[3].Value))) * Convert.ToDouble(gridarticulo.Rows[cont_fila].Cells[4].Value);

                        gridarticulo.Rows[num_fila].Cells[5].Value = importe;
                    }
                    else
                    {
                        gridarticulo.Rows.Add(codigo_articulo, txtarticulo.Text, txtprecioventa.Text,txtitebis.Text, txtcantidad.Text);
                        double importe = (Convert.ToDouble(gridarticulo.Rows[cont_fila].Cells[2].Value) + (Convert.ToDouble(gridarticulo.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(gridarticulo.Rows[cont_fila].Cells[3].Value))) * Convert.ToDouble(gridarticulo.Rows[cont_fila].Cells[4].Value);
                        gridarticulo.Rows[cont_fila].Cells[5].Value = importe;

                        cont_fila++;
                    }
                }
            }
           
        }
    }
}
