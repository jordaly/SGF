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
    public partial class FrmCompra : FormBase
    {
        public FrmCompra()
        {
            InitializeComponent();
            lbfecha.Text += " " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;

            string cmdtipo_factura = "Select * from tipo_factura";
            string cmdtipo_pago = "Select * from tipo_pago";
            string cmddivisa = "Select * from divisa";
            //string cmdNumeroFactura = "select top(1) numero_factura from factura order by fecha DESC";

            ds = Utilidades.EjecutarDS(cmdtipo_factura);
            cbxtipofactura.DisplayMember = "descripcion";
            cbxtipofactura.DataSource = ds.Tables[0].DefaultView;


            ds = Utilidades.EjecutarDS(cmdtipo_pago);
            cbxtipopago.DisplayMember = "descripcion";
            cbxtipopago.DataSource = ds.Tables[0].DefaultView;

            ds = Utilidades.EjecutarDS(cmddivisa);
            cbxdivisa.DisplayMember = "descripcion";
            cbxdivisa.DataSource = ds.Tables[0].DefaultView;



            //ds = Utilidades.EjecutarDS(cmdNumeroFactura);
            //lbnumfactura.Text = (Convert.ToInt32(ds.Tables[0].Rows[0]["numero_factura"].ToString()) + 1).ToString().PadLeft((20 - ds.Tables[0].Rows[0]["numero_factura"].ToString().Length), '0');
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

            txtsuplidor.Text = frm.nombre_suplidor;
            lbcodigosuplidor.Text = "Codigo Suplidor: " + frm.codigo_suplidor;
            txtrnc.Text = frm.RNC;
            codigo_suplidor = frm.codigo_suplidor;
        }


        public string codigo_articulo = "";
        public string nombre_articulo = "";
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
            precio_articulo_compra = frm.precio_articulo_compra;
            itebis = frm.itebis;

            lbcodigoarticulo.Text = " Codigo Articulo: " + codigo_articulo;
            txtarticulo.Text = nombre_articulo;
            txtpreciocompra.Text = precio_articulo_compra;
        }

        public void validar()
        {
            lbnumfactura.Text = "";
           // cbxsucursal.Text = "";
            cbxtipofactura.Text = "";
            txtsuplidor.Text = "";
            txtrnc.Text = "";
            cbxtipopago.Text = "";
            cbxdivisa.Text = "";
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
            if (txtarticulo.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(txtarticulo, "Este campo no puede estar vasio.");

            }
            if (txtpreciocompra.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(txtpreciocompra, "Este campo no puede estar vasio.");
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
            if (txtsuplidor.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(txtsuplidor, "Este campo no puede estar vacio.");
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
                if (lbnumfactura.Text == "" ||  cbxtipofactura.Text == "" || txtsuplidor.Text == "" || txtrnc.Text == "" || cbxtipopago.Text == "" || cbxdivisa.Text == "" || txtarticulo.Text == "" || txtcantidad.Text == "")
                {
                    bool existe = false;
                    int num_fila = 0;

                    if (cont_fila == 0)
                    {
                        gridarticulosuplidor.Rows.Add(codigo_articulo, txtarticulo.Text, txtpreciocompra.Text, txtcantidad.Text);
                        double importe = (Convert.ToDouble(gridarticulosuplidor.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(gridarticulosuplidor.Rows[cont_fila].Cells[3].Value));
                        gridarticulosuplidor.Rows[cont_fila].Cells[4].Value = importe;

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

                            double importe = (Convert.ToDouble(gridarticulosuplidor.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(gridarticulosuplidor.Rows[cont_fila].Cells[3].Value));

                            gridarticulosuplidor.Rows[num_fila].Cells[4].Value = importe;

                        }
                        else
                        {
                            gridarticulosuplidor.Rows.Add(codigo_articulo, txtarticulo.Text, txtpreciocompra.Text, txtcantidad.Text);
                            double importe = (Convert.ToDouble(gridarticulosuplidor.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(gridarticulosuplidor.Rows[cont_fila].Cells[3].Value));
                            gridarticulosuplidor.Rows[cont_fila].Cells[4].Value = importe;

                            cont_fila++;
                        }
                    }
                    total = 0;

                    foreach (DataGridViewRow fila in gridarticulosuplidor.Rows)
                    {
                        total += Convert.ToDouble(fila.Cells[4].Value);
                    }
                    txttotal.Text = "RD$ " + total.ToString();
                }

                txtcantidad.Text = "";
            }
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

        private void btnnuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (ComprobarCamposFactura())
            {
                cmd = "select * from divisa where descripcion='" + cbxdivisa.Text + "'";
                ds = Utilidades.EjecutarDS(cmd);
                string idDivisa = ds.Tables[0].Rows[0]["id"].ToString();

                cmd = "select * from tipo_pago where descripcion='" + cbxtipopago.Text + "'";
                ds = Utilidades.EjecutarDS(cmd);
                string idTipo_pago = ds.Tables[0].Rows[0]["id"].ToString();


                     cmd = "begin " +
                        "insert into Compra(fecha,idSuplidor,idTipopago,idDivisa,total)values(getdate(),'" + codigo_suplidor + "','" + idTipo_pago + "','" + idDivisa + "','" + total.ToString().Replace(",", ".") + "');" +
                        "select top(1) id as id from Compra order by id desc;" +
                    "end";
                //txtcantidad.Text = cmd;
                //MessageBox.Show(cmd);
                ds = Utilidades.EjecutarDS(cmd);
                if (ds != null)
                {
                    string idcompra = ds.Tables[0].Rows[0]["id"].ToString();

                    foreach (DataGridViewRow fila in gridarticulosuplidor.Rows)
                    {
                        cmd = "begin insert into detalle_compra(idCompra,idArticulo,cantidad,importe)values('"+idcompra+ "','" + fila.Cells[0].Value.ToString() + "','" + fila.Cells[3].Value.ToString() + "','" + fila.Cells[4].Value.ToString().Replace(",", ".") + "'); " +
                            "end";
                        ds = Utilidades.EjecutarDS(cmd);
                    }
                    /*
                    //C:\Users\Jorda\source\repos\SGF\SGF\Reportes\Factura con su detalle3.rpt
                    string RutaReporte = root + @"Reportes\Factura con su detalle.rpt";
                    //MessageBox.Show(RutaReporte);
                    VisorDeReportes form = new VisorDeReportes();
                    ReportDocument oRep = new ReportDocument();
                    ParameterField pf = new ParameterField();
                    ParameterFields pfs = new ParameterFields();
                    ParameterDiscreteValue pdv = new ParameterDiscreteValue();
                    pf.Name = "@numFact"; // variable del store procedure
                    pdv.Value = idfactura; // variable donde se  guarda el numero de factura
                    pf.CurrentValues.Add(pdv);
                    pfs.Add(pf);
                    form.crvVisor.ParameterFieldInfo = pfs;
                    oRep.Load(RutaReporte);
                    form.crvVisor.ReportSource = oRep;
                    form.Show();
                    this.Close();*/
                    //oRep.ExportToDisk(ExportFormatType.PortableDocFormat, @"C:\Users\Usuario\Documents\(" + idfactura + ") Factura.pdf");
                }
            }
        }

        private void btnbuscarsuplidor_Click_1(object sender, EventArgs e)
        {

        }
    }
}
