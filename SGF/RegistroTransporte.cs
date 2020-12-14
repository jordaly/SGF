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
    public partial class RegistroTransporte : FormBase
    {
        public string numeroFactura = "",codigoCliente="";
        public RegistroTransporte()
        {
            InitializeComponent();
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



            return ok;
        }
        public bool ComprobarCamposTransporte()
        {
            ErrorProvider.Clear();
            bool ok = true;
            if (gridarticulo.Rows.Count < 1)
            {
                ok = false;

                ErrorProvider.SetError(gridarticulo, "Debe haber al menos un articulo para poder facturar.");
            }
            if (txtcliente.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(txtcliente, "Este campo no puede estar vacio.");
            }



            return ok;
        }


        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            MantenimientoVehiculos rc = new MantenimientoVehiculos();
            rc.btnBorrar.Enabled = false;
            rc.btnModificar.Enabled = false;
            rc.btnSeleccionar.Enabled = true;
            rc.transporte = true;
            rc.ShowDialog();
            tbxVehiculo.Text = rc.matricula;
        }

        public string codigo_articulo, nombre_articulo, cantidad;


        public static int cont_fila = 0;
        public static double total;
        public string codigo_empleado;
        public string codigo_usuario;

        private void btnquitararticulo_Click(object sender, EventArgs e)
        {
            if (cont_fila > 0)
            {
                //total = total - (Convert.ToDouble(gridarticulo.Rows[gridarticulo.CurrentRow.Index].Cells[5].Value));
                //txttotal.Text = "RD$ " + total.ToString();

                gridarticulo.Rows.RemoveAt(gridarticulo.CurrentRow.Index);

                cont_fila--;
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (ComprobarCamposTransporte())
            {
                //cmd = "select * from divisa where descripcion='" + cbxdivisa.Text + "'";
                //ds = Utilidades.EjecutarDS(cmd);
                //string idDivisa = ds.Tables[0].Rows[0]["id"].ToString();

                //cmd = "select * from usuario where id='" + codigo_usuario + "'";
                //ds = Utilidades.EjecutarDS(cmd);
                //string idEmpleado = ds.Tables[0].Rows[0]["idEmpleado"].ToString();

                //cmd = "select * from tipo_factura where descripcion='" + cbxtipofactura.Text + "'";
                //ds = Utilidades.EjecutarDS(cmd);
                //string idTipo_factura = ds.Tables[0].Rows[0]["id"].ToString();

                //cmd = "select * from tipo_NCF where tipo='" + cbxtipo_ncf.Text + "'";
                //ds = Utilidades.EjecutarDS(cmd);
                //string idTipo_NCF = ds.Tables[0].Rows[0]["numero"].ToString();

                //cmd = "select * from tipo_pago where descripcion='" + cbxtipopago.Text + "'";
                //ds = Utilidades.EjecutarDS(cmd);
                //string idTipo_pago = ds.Tables[0].Rows[0]["id"].ToString();
                string idDireccion = "";
                if (chxDireccion.Checked)
                {
                    cmd= 
                        "begin " +
                            "declare @idDireccion uniqueidentifier=newid();" +
                            "insert into direccion_cliente(id,idPais,provincia,localidad,direccion,indicaciones,codigo_postal)values(@idDireccion,'6FE23F75-A07C-44F3-8245-84BEB077CF1F','"+cbxProvincia.Text+"','"+tbxLocalidad.Text.Trim()+"','"+tbxDireccion.Text.Trim()+"','"+rtbxIndicaciones.Text.Trim()+"','"+tbxCodigo_postal.Text.Trim()+"');" +
                            "select @idDireccion as id;" +
                        "end";
                    ds = Utilidades.EjecutarDS(cmd);
                    idDireccion = ds.Tables[0].Rows[0]["id"].ToString();
                }
                else
                {
                    cmd = "select idDireccion_cleinte from cliente where idTercero='" + codigoCliente + "'";
                    ds = Utilidades.EjecutarDS(cmd);
                    idDireccion = ds.Tables[0].Rows[0]["idDireccion_cleinte"].ToString();
                }
                

                //cmd = "select * from NCF";
                //ds = Utilidades.EjecutarDS(cmd);
                //string ncf = ds.Tables[0].Rows[0]["serie"].ToString() + idTipo_NCF + ds.Tables[0].Rows[0]["secuencia"].ToString().PadLeft((9 - ds.Tables[0].Rows[0]["secuencia"].ToString().Length), '0');
                //string idNCF = ds.Tables[0].Rows[0]["id"].ToString();
                cmd = 
                    "begin " +
                        "insert into transporte(numero_factura,matricula_vehiculo,hora_salida,idCliente,idDireccion,estado)values('"+numeroFactura+"','"+tbxVehiculo.Text+"',getdate(),'"+codigoCliente+"','"+idDireccion+"','1');" +
                        "update vehiculo set transporte='1' where Matricula='"+tbxVehiculo.Text+"';" +
                        "select top(1) id from transporte order by id desc;" +
                    "end";
                //txtcantidad.Text = cmd;
                //MessageBox.Show(cmd);
                ds = Utilidades.EjecutarDS(cmd);
                if (ds != null)
                {
                    string idTransporte = ds.Tables[0].Rows[0]["id"].ToString();

                    foreach (DataGridViewRow fila in gridarticulo.Rows)
                    {
                        cmd = 
                            "begin " +
                                "insert into detalle_transporte(idTransporte,idproducto,cantidad,estado)values('"+idTransporte+"','"+ fila.Cells[0].Value.ToString() + "','"+ fila.Cells[2].Value.ToString() + "','1');" +
                                "update detalle_factura set cantidadTransportada+='"+fila.Cells[2].Value.ToString()+"' where idArticulo='"+ fila.Cells[0].Value.ToString() + "' and idFactura='"+numeroFactura+"';" +
                            "end";
                        ds = Utilidades.EjecutarDS(cmd);
                    }




                    cmd =
                        "begin " +
                            "declare @SumaC int;" +
                            "declare @SumaCT int;" +
                            "select @SumaC =sum(cantidad),@SumaCT = sum(cantidadTransportada) from detalle_factura where idFactura='"+numeroFactura+"';" +
                            "if(@SumaC=@SumaCT) " +
                            "begin " +
                                "update factura set estado='Entregado' where numero_factura='"+numeroFactura+"';" +
                            "end " +
                        "end";
                    ds = Utilidades.EjecutarDS(cmd);

                    //cmd = "update NCF set secuencia+=1 where id='" + idNCF + "'";
                    //ds = Utilidades.EjecutarDS(cmd);

                    //C:\Users\Jorda\source\repos\SGF\SGF\Reportes\Factura con su detalle3.rpt
                    //string RutaReporte = root + @"Reportes\Factura con su detalle.rpt";
                    ////MessageBox.Show(RutaReporte);
                    //VisorDeReportes form = new VisorDeReportes();
                    //ReportDocument oRep = new ReportDocument();
                    //ParameterField pf = new ParameterField();
                    //ParameterFields pfs = new ParameterFields();
                    //ParameterDiscreteValue pdv = new ParameterDiscreteValue();
                    //pf.Name = "@numFact"; // variable del store procedure
                    //pdv.Value = idfactura; // variable donde se  guarda el numero de factura
                    //pf.CurrentValues.Add(pdv);
                    //pfs.Add(pf);
                    //form.crvVisor.ParameterFieldInfo = pfs;
                    //oRep.Load(RutaReporte);
                    //form.crvVisor.ReportSource = oRep;
                    //form.Show();
                    MessageBox.Show("Despacho de tranporte exitoso.");
                    this.Close();
                }
            }
        }

        private void btnagregararticulo_Click(object sender, EventArgs e)
        {
            if (ComprobarCamposArticulos())
            {
                if (Convert.ToInt32(cantidad) >= Convert.ToInt32(txtcantidad.Text))
                {
                    bool existe = false;
                    int num_fila = 0;

                    if (cont_fila == 0)
                    {
                        gridarticulo.Rows.Add(codigo_articulo, txtarticulo.Text, txtcantidad.Text);
                        //double importe = (Convert.ToDouble(gridarticulo.Rows[cont_fila].Cells[2].Value) + (Convert.ToDouble(gridarticulo.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(gridarticulo.Rows[cont_fila].Cells[3].Value))) * Convert.ToDouble(gridarticulo.Rows[cont_fila].Cells[4].Value);
                        //gridarticulo.Rows[cont_fila].Cells[5].Value = importe;

                        cont_fila++;
                    }
                    else
                    {
                        foreach (DataGridViewRow fila in gridarticulo.Rows)
                        {
                            if (fila.Cells[0].Value.ToString() == codigo_articulo)
                            {
                                existe = true;
                                num_fila = fila.Index;
                                if ((Convert.ToInt32( fila.Cells[2].Value)-Convert.ToInt32(txtcantidad.Text.Trim()))>Convert.ToInt32( cantidad))
                                {
                                    MessageBox.Show("La cantidad es mayor que el stock de la factura.");
                                    return;
                                }
                            }
                        }

                        if (existe == true)
                        {
                            //MessageBox.Show(""+ (Convert.ToInt32(gridarticulo.Rows[num_fila].Cells[2].Value.ToString()) + Convert.ToInt32(txtcantidad.Text)));
                            //MessageBox.Show(cantidad);

                            if ((Convert.ToInt32(gridarticulo.Rows[num_fila].Cells[2].Value.ToString()) + Convert.ToInt32(txtcantidad.Text)) <= Convert.ToInt32(cantidad))
                            {
                                gridarticulo.Rows[num_fila].Cells[2].Value = Convert.ToDouble(txtcantidad.Text) + (Convert.ToDouble(gridarticulo.Rows[num_fila].Cells[2].Value));
                            }
                            else
                            {
                                MessageBox.Show("La cantidad es mayor que la cantidad de la factura.");
                            }
                            //gridarticulo.Rows[num_fila].Cells[2].Value = Convert.ToDouble(txtcantidad.Text) + (Convert.ToDouble(gridarticulo.Rows[num_fila].Cells[2].Value));

                            //double importe = (Convert.ToDouble(gridarticulo.Rows[num_fila].Cells[2].Value) + (Convert.ToDouble(gridarticulo.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(gridarticulo.Rows[num_fila].Cells[3].Value))) * (Convert.ToDouble(gridarticulo.Rows[num_fila].Cells[4].Value));

                            //gridarticulo.Rows[num_fila].Cells[5].Value = importe;

                        }
                        else
                        {
                            gridarticulo.Rows.Add(codigo_articulo, txtarticulo.Text, txtcantidad.Text);
                            //double importe = (Convert.ToDouble(gridarticulo.Rows[cont_fila].Cells[2].Value) + (Convert.ToDouble(gridarticulo.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(gridarticulo.Rows[cont_fila].Cells[3].Value))) * Convert.ToDouble(gridarticulo.Rows[cont_fila].Cells[4].Value);
                            //gridarticulo.Rows[cont_fila].Cells[5].Value = importe;

                            cont_fila++;
                        }
                    }
                    //total = 0;

                    //foreach (DataGridViewRow fila in gridarticulo.Rows)
                    //{
                    //    total += Convert.ToDouble(fila.Cells[5].Value);
                    //}
                    //txttotal.Text = "RD$ " + total.ToString();
                }
                else
                {
                    MessageBox.Show("La cantidad es mayor que el stock de la factura.");
                }


                //txtcantidad.Text = "";
            }
        }

        private void btnbuscararticulo_Click(object sender, EventArgs e)
        {
            ListadoArticulosSucursal frm = new ListadoArticulosSucursal();
            frm.Text = "Listado de productos por entregar";
            frm.numeroFactura = numeroFactura;
            frm.transporte = true;
            frm.btnBorrar.Enabled = false;
            frm.btnModificar.Enabled = false;
            frm.btnNuevo.Enabled = false;
            frm.btnSeleccionar.Enabled = true;
            frm.ShowDialog();

            codigo_articulo = frm.codigo_articulo;
            nombre_articulo = frm.nombre_articulo;
            cantidad = frm.stock_articulo;
            //cantidad

            lbcodigoarticulo.Text = " Codigo Articulo: " + codigo_articulo;
            txtarticulo.Text = nombre_articulo;
            lbstock.Text = "cantidad: " + cantidad;
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chxDireccion.Checked)
            {
                cbxProvincia.Enabled = true;
                cbxProvincia.SelectedIndex = 0;
                tbxLocalidad.Enabled = true;
                tbxLocalidad.Text = "";
                tbxDireccion.Enabled = true;
                tbxDireccion.Text = "";
                tbxCodigo_postal.Enabled = true;
                tbxCodigo_postal.Text = "";
                rtbxIndicaciones.Enabled = true;
                rtbxIndicaciones.Text = "";
            }
            else
            {
                cbxProvincia.Enabled = false;
                cbxProvincia.SelectedIndex = 0;
                tbxLocalidad.Enabled = false;
                tbxLocalidad.Text = "";
                tbxDireccion.Enabled = false;
                tbxDireccion.Text = "";
                tbxCodigo_postal.Enabled = false;
                tbxCodigo_postal.Text = "";
                rtbxIndicaciones.Enabled = false;
                rtbxIndicaciones.Text = "";
            }
        }
    }
}
