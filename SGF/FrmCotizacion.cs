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
    public partial class FrmCotizacion : FormBase
    {
        public FrmCotizacion()
        {
            InitializeComponent();

            if (lbcodigo.Text == "Nuevo")
            {
                lbfecha.Text += " " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            }

            //string cmdtipo_factura = "Select * from tipo_factura";
            string cmdsucursal = "Select * from sucursal";

            //ds = Utilidades.EjecutarDS(cmdtipo_factura);
            //cbxtipofactura.DisplayMember = "descripcion";
            //cbxtipofactura.DataSource = ds.Tables[0].DefaultView;


            string cmdsucursal = "Select * from sucursal";

            ds = Utilidades.EjecutarDS(cmdsucursal);
            cbxsucursal.DisplayMember = "nombre_sucursal";
            cbxsucursal.DataSource = ds.Tables[0].DefaultView;
            cbxsucursal.SelectedIndex = 1;

        }
        public string codigo_cliente = "";
        private void btnbuscarcliente_Click(object sender, EventArgs e)
        {
            MantenimientoClientes frm = new MantenimientoClientes();
            frm.btnBorrar.Enabled = false;
            frm.btnModificar.Enabled = false;
            frm.btnNuevo.Enabled = true;
            frm.btnSeleccionar.Enabled = true;
            frm.ShowDialog();

            txtcliente.Text = frm.nombre_cliente_apellido_cliente;
            lbcodigo.Text = "Codigo Cliente: " + frm.codigo_cliente;
            codigo_cliente = frm.codigo_cliente;
        }

        public string codigo_articulo = "";
        public string nombre_articulo = "";
        public string stock_articulo = "";
        public string precio_articulo = "";
        public string itebis = "";

        private void btnbuscararticulo_Click(object sender, EventArgs e)
        {

            ListadoArticulosSucursal frm = new ListadoArticulosSucursal();
            cmd = "select * from sucursal where nombre_sucursal='" + cbxsucursal.Text + "'";
            ds = Utilidades.EjecutarDS(cmd);
            frm.idSucursal = ds.Tables[0].Rows[0]["id"].ToString();


            frm.btnBorrar.Enabled = false;
            frm.btnModificar.Enabled = false;
            frm.btnNuevo.Enabled = false;
            frm.btnSeleccionar.Enabled = true;
            frm.ShowDialog();

            codigo_articulo = frm.codigo_articulo;
            nombre_articulo = frm.nombre_articulo;
            stock_articulo = frm.stock_articulo;
            precio_articulo = frm.precio_articulo;
            itebis = frm.itebis;

            lbcodigoarticulo.Text = " Codigo Articulo: " + codigo_articulo;
            txtarticulo.Text = nombre_articulo;
            lbstock.Text = "STOCK: " + stock_articulo;
            txtprecioventa.Text = precio_articulo;
            txtitebis.Text = itebis;
        }

        public void validar()
        {
            cbxsucursal.Text = "";

            //cbxtipofactura.Text = "";

            txtcliente.Text = "";
            txtrnc.Text = "";
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
            if (txtprecioventa.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(txtprecioventa, "Este campo no puede estar vasio.");
            }
            if (txtitebis.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(txtitebis, "Este campo no puede estar vacio.");
            }


            return ok;
        }

        public bool ComprobarCamposFactura()
        {
            ErrorProvider.Clear();
            bool ok = true;
            if (gridcotizacion.Rows.Count < 1)
            {
                ok = false;

                ErrorProvider.SetError(gridcotizacion, "Debe haber al menos un articulo para poder facturar.");
            }
            if (txtcliente.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(txtcliente, "Este campo no puede estar vacio.");
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
                cbxsucursal.Enabled = false;
                if (Convert.ToInt32(stock_articulo) >= Convert.ToInt32(txtcantidad.Text))
                {
                    bool existe = false;
                    int num_fila = 0;

                    if (cont_fila == 0)
                    {
                        gridcotizacion.Rows.Add(codigo_articulo, txtarticulo.Text, txtprecioventa.Text, txtitebis.Text, txtcantidad.Text);
                        double importe = (Convert.ToDouble(gridcotizacion.Rows[cont_fila].Cells[2].Value) + (Convert.ToDouble(gridcotizacion.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(gridcotizacion.Rows[cont_fila].Cells[3].Value))) * Convert.ToDouble(gridcotizacion.Rows[cont_fila].Cells[4].Value);
                        gridcotizacion.Rows[cont_fila].Cells[5].Value = importe;

                        cont_fila++;
                    }
                    else
                    {
                        foreach (DataGridViewRow fila in gridcotizacion.Rows)
                        {
                            if (fila.Cells[0].Value.ToString() == codigo_articulo)
                            {
                                existe = true;
                                num_fila = fila.Index;

                                if (Convert.ToInt32(fila.Cells[4].Value.ToString()) + Convert.ToInt32(txtcantidad.Text) > Convert.ToInt32(stock_articulo))
                                {
                                    MessageBox.Show("La cantidad total es mayor que el STOCK!");
                                    ErrorProvider.SetError(txtcantidad, "La cantidad COTIZADA es mayor que el STOCK actual!");

                                    return;
                                }
                            }
                        }

                        if (existe == true)
                        {
                            //MessageBox.Show(""+num_fila);
                            gridcotizacion.Rows[num_fila].Cells[4].Value = Convert.ToDouble(txtcantidad.Text) + (Convert.ToDouble(gridcotizacion.Rows[num_fila].Cells[4].Value));

                            double importe = (Convert.ToDouble(gridcotizacion.Rows[num_fila].Cells[2].Value) + (Convert.ToDouble(gridcotizacion.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(gridcotizacion.Rows[num_fila].Cells[3].Value))) * (Convert.ToDouble(gridcotizacion.Rows[num_fila].Cells[4].Value));

                            gridcotizacion.Rows[num_fila].Cells[5].Value = importe;

                        }
                        else
                        {
                            gridcotizacion.Rows.Add(codigo_articulo, txtarticulo.Text, txtprecioventa.Text, txtitebis.Text, txtcantidad.Text);
                            double importe = (Convert.ToDouble(gridcotizacion.Rows[cont_fila].Cells[2].Value) + (Convert.ToDouble(gridcotizacion.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(gridcotizacion.Rows[cont_fila].Cells[3].Value))) * Convert.ToDouble(gridcotizacion.Rows[cont_fila].Cells[4].Value);
                            gridcotizacion.Rows[cont_fila].Cells[5].Value = importe;

                            cont_fila++;
                        }
                    }
                    total = 0;

                    foreach (DataGridViewRow fila in gridcotizacion.Rows)
                    {
                        total += Convert.ToDouble(fila.Cells[5].Value);
                    }
                    txttotal.Text = "RD$ " + total.ToString();
                }
                else
                {
                    MessageBox.Show("La cantidad es mayor que el stock disponible.");
                }


                txtcantidad.Text = "";
            }
        }

        private void btnquitararticulo_Click(object sender, EventArgs e)
        {
            if (cont_fila > 0)
            {
                total = total - (Convert.ToDouble(gridcotizacion.Rows[gridcotizacion.CurrentRow.Index].Cells[5].Value));
                txttotal.Text = "RD$ " + total.ToString();

                gridcotizacion.Rows.RemoveAt(gridcotizacion.CurrentRow.Index);

                cont_fila--;
            }

            if (gridcotizacion.Rows.Count == 0)
            {
                cbxsucursal.Enabled = true;
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //insertar
            if (ComprobarCamposFactura())
            {


                //cmd = "select * from tipo_factura where descripcion='" + cbxtipofactura.Text + "'";
                //ds = Utilidades.EjecutarDS(cmd);
                //string idTipo_factura = ds.Tables[0].Rows[0]["id"].ToString();



                cmd = "select * from sucursal where nombre_sucursal='" + cbxsucursal.Text + "'";
                ds = Utilidades.EjecutarDS(cmd);
                string idsucursal = ds.Tables[0].Rows[0]["id"].ToString();

               
                cmd = "begin  declare @idCotizacion uniqueidentifier= newid(); " +
                    "insert into cotizacion(id,idcliente,fecha_in,total,idSucursal)values(@idCotizacion,'"+codigo_cliente+ "',getdate(),'" + total.ToString().Replace(",", ".") + "','"+idsucursal+ "'); " +
                    "select id from cotizacion where id=@idCotizacion; " +
                    "end";
                MessageBox.Show("guardado exitosamente");
                //txtcantidad.Text = cmd;
                //MessageBox.Show(cmd);
                ds = Utilidades.EjecutarDS(cmd);
                if (ds != null)

                {
                    cmd = "select * from sucursal where nombre_sucursal='" + cbxsucursal.Text + "'";
                    ds = Utilidades.EjecutarDS(cmd);
                    string idsucursal = ds.Tables[0].Rows[0]["id"].ToString();


                    cmd = "begin  declare @idCotizacion uniqueidentifier= newid(); " +
                        "insert into cotizacion(id,idcliente,fecha_in,total,idSucursal)values(@idCotizacion,'" + codigo_cliente + "',getdate(),'" + total.ToString().Replace(",", ".") + "','" + idsucursal + "'); " +
                        "select id from cotizacion where id=@idCotizacion; " +
                        "end";
                    MessageBox.Show("guardado exitosamente");
                    //txtcantidad.Text = cmd;
                    //MessageBox.Show(cmd);
                    ds = Utilidades.EjecutarDS(cmd);
                    if (ds != null)
                    {
                        string idcotizacion = ds.Tables[0].Rows[0]["id"].ToString();

                        foreach (DataGridViewRow fila in gridcotizacion.Rows)
                        {
                            cmd = "begin " +
                                "insert into detalle_cotizacion(idArticulo,idCotizacion,cantidadCotizada,importe)values('" + fila.Cells[0].Value.ToString() + "','" + idcotizacion + "','" + fila.Cells[4].Value.ToString() + "','" + fila.Cells[5].Value.ToString().Replace(",", ".") + "'); " +
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
                else
                {
                    //actualizar (hacer cambios)

                    cmd = "select * from sucursal where nombre_sucursal='" + cbxsucursal.Text + "'";
                    ds = Utilidades.EjecutarDS(cmd);
                    string idsucursal = ds.Tables[0].Rows[0]["id"].ToString();


                    cmd = "begin  declare @idCotizacion uniqueidentifier= newid(); " +
                        "insert into cotizacion(id,idcliente,fecha_in,total,idSucursal)values(@idCotizacion,'" + codigo_cliente + "',getdate(),'" + total.ToString().Replace(",", ".") + "','" + idsucursal + "'); " +
                        "select id from cotizacion where id=@idCotizacion; " +
                        "end";
                    MessageBox.Show("guardado exitosamente");
                    //txtcantidad.Text = cmd;
                    //MessageBox.Show(cmd);
                    ds = Utilidades.EjecutarDS(cmd);
                    if (ds != null)
                    {
                        string idcotizacion = ds.Tables[0].Rows[0]["id"].ToString();

                        foreach (DataGridViewRow fila in gridcotizacion.Rows)
                        {
                            cmd = "begin " +
                                "insert into detalle_cotizacion(idArticulo,idCotizacion,cantidadCotizada,importe)values('" + fila.Cells[0].Value.ToString() + "','" + idcotizacion + "','" + fila.Cells[4].Value.ToString() + "','" + fila.Cells[5].Value.ToString().Replace(",", ".") + "'); " +
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
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtarticulo.Text = "";
            txtcantidad.Text = "";
            txtitebis.Text = "";
            lbstock.Text = "STOCK: ";
        }
    }
}
