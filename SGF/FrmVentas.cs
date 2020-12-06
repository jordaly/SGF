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
            string cmdtipo_factura = "Select * from tipo_factura";
            string cmdtipo_ncf = "Select * from tipo_NCF";
            string cmdtipo_pago = "Select * from tipo_pago";
            string cmddivisa = "Select * from divisa";
            string cmdsucursal = "Select * from sucursal";

            ds = Utilidades.EjecutarDS(cmdtipo_factura);
            cbxtipofactura.DisplayMember = "descripcion";
            cbxtipofactura.DataSource = ds.Tables[0].DefaultView;


            ds = Utilidades.EjecutarDS(cmdtipo_ncf);
            cbxtipo_ncf.DisplayMember = "tipo";
            cbxtipo_ncf.DataSource = ds.Tables[0].DefaultView;

            ds = Utilidades.EjecutarDS(cmdtipo_pago);
            cbxtipopago.DisplayMember = "descripcion";
            cbxtipopago.DataSource = ds.Tables[0].DefaultView;

            ds = Utilidades.EjecutarDS(cmddivisa);
            cbxdivisa.DisplayMember = "descripcion";
            cbxdivisa.DataSource = ds.Tables[0].DefaultView;

            ds = Utilidades.EjecutarDS(cmdsucursal);
            cbxsucursal.DisplayMember = "nombre_sucursal";
            cbxsucursal.DataSource = ds.Tables[0].DefaultView;
        }

       

        //Marca
       

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
            codigo_cliente = frm.codigo_cliente;
        }

        public string codigo_articulo = "";
        public string nombre_articulo = "";
        public string stock_articulo = "";
        public string precio_articulo = "";
        public string itebis = "";
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
            itebis = frm.itebis;

            lbcodigoarticulo.Text =" Codigo Articulo: " +codigo_articulo;
            txtarticulo.Text = nombre_articulo;
            lbstock.Text = "STOCK: "+stock_articulo;
            txtprecioventa.Text = precio_articulo;
            txtitebis.Text = itebis;
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
        public static  double total;
        public string codigo_empleado;
        public string codigo_usuario;
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
                        //MessageBox.Show(""+num_fila);
                        gridarticulo.Rows[num_fila].Cells[4].Value = Convert.ToDouble(txtcantidad.Text) + (Convert.ToDouble(gridarticulo.Rows[num_fila].Cells[4].Value));

                        double importe = (Convert.ToDouble(gridarticulo.Rows[num_fila].Cells[2].Value) + (Convert.ToDouble(gridarticulo.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(gridarticulo.Rows[num_fila].Cells[3].Value))) * (Convert.ToDouble(gridarticulo.Rows[num_fila].Cells[4].Value));

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
                total = 0;

                foreach (DataGridViewRow fila in gridarticulo.Rows)
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
                total = total - (Convert.ToDouble(gridarticulo.Rows[gridarticulo.CurrentRow.Index].Cells[5].Value));
                txttotal.Text = "RD$ " + total.ToString();

                gridarticulo.Rows.RemoveAt(gridarticulo.CurrentRow.Index);
                
                cont_fila--;
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            cmd = "select * from divisa where descripcion='"+cbxdivisa.Text+"'";
            ds = Utilidades.EjecutarDS(cmd);
            string idDivisa = ds.Tables[0].Rows[0]["id"].ToString();

            cmd = "select * from usuario where id='"+codigo_usuario+"'";
            ds = Utilidades.EjecutarDS(cmd);
            string idEmpleado = ds.Tables[0].Rows[0]["idEmpleado"].ToString();

            cmd = "select * from tipo_factura where descripcion='"+cbxtipofactura.Text+"'";
            ds = Utilidades.EjecutarDS(cmd);
            string idTipo_factura = ds.Tables[0].Rows[0]["id"].ToString();

            cmd = "select * from tipo_NCF where tipo='"+cbxtipo_ncf.Text+"'";
            ds = Utilidades.EjecutarDS(cmd);
            string idTipo_NCF = ds.Tables[0].Rows[0]["numero"].ToString();

            cmd = "select * from tipo_pago where descripcion='"+cbxtipopago.Text+"'";
            ds = Utilidades.EjecutarDS(cmd);
            string idTipo_pago = ds.Tables[0].Rows[0]["id"].ToString();

            cmd = "select * from sucursal where nombre_sucursal='"+cbxsucursal.Text+"'";
            ds = Utilidades.EjecutarDS(cmd);
            string idsucursal = ds.Tables[0].Rows[0]["id"].ToString();

            cmd = "select * from NCF";
            ds = Utilidades.EjecutarDS(cmd);
            string ncf = ds.Tables[0].Rows[0]["serie"].ToString() + idTipo_NCF + ds.Tables[0].Rows[0]["secuencia"].ToString().PadLeft((9 - ds.Tables[0].Rows[0]["secuencia"].ToString().Length), '0');
            string idNCF = ds.Tables[0].Rows[0]["id"].ToString();
            cmd = "update NCF set secuencia+=1 where id='" + idNCF + "'";
            ds = Utilidades.EjecutarDS(cmd);

            cmd = "begin" +
                 " declare @idFactura uniqueidentifier= newid();" +
                 "insert into factura(id,idTipo_factura,fecha,idcliente,NCF,idDivisa,idTipo_pago,idSucursal,idEmpleado,total)values(@idFactura,'"+idTipo_factura+"',getdate(),'"+codigo_cliente+"','"+ncf+"','"+idDivisa+"','"+idTipo_pago+"','"+ idsucursal + "','"+idEmpleado+"','"+total+"');" +
                 "select id from factura where id=@idFactura;" +
                 "end";

            ds = Utilidades.EjecutarDS(cmd);
            string idfactura = ds.Tables[0].Rows[0]["id"].ToString();

            foreach (DataGridViewRow fila in gridarticulo.Rows)
            {
                cmd = "begin "+
                "insert into detalle_factura(idFactura,idArticulo,cantidad,importe)values('"+idfactura+"','"+ fila.Cells[0].Value.ToString() + "','"+ fila.Cells[4].Value.ToString() + "','"+ fila.Cells[5].Value.ToString() + "');" +
                "end";
                ds = Utilidades.EjecutarDS(cmd);
            }
        }
    }
}
