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
    public partial class ListadoArticulosSucursal : FormProcesos
    {
        public string BuscarDatos = "",idSucursal="";
        public ListadoArticulosSucursal()
        {
            InitializeComponent();
            

        }

        public string numeroFactura = "";
        public string codigo_articulo = "";
        public string nombre_articulo = "";
        public string stock_articulo = "";
        public string precio_articulo_compra = "";
        public string precio_articulo = "";
        public string itebis = "";
        public bool transporte = false;
        private void ListadoArticulosSucursal_Load(object sender, EventArgs e)
        {
            if (transporte)
            {
                BuscarDatos =
                "select df.idArticulo,a.nombre_articulo,(df.cantidad-df.cantidadTransportada) as cantidad_sin_transportar from detalle_factura as df, articulo as a where cantidad-cantidadTransportada>0 and a.id=df.idArticulo and df.idFactura='"+numeroFactura+"' ";
            }
            else
            {
                BuscarDatos =
                "begin " +
                    "declare @idAlmacen uniqueidentifier;" +
                    "select @idAlmacen=sva.idAlmacen from sucursal_vs_almacen as sva where sva.idSucursal='"+idSucursal+"';" +
                    "select a.id,a.nombre_articulo,ava.cantidad,a.precio_venta,a.precio_compra,a.ITEBIs from articulo_vs_almacen as ava, articulo as a where idAlmacen=@idAlmacen and a.id=ava.idArticulo;" +
                "end";
            }
            
            refrescarDatos(BuscarDatos);
        }

        public override void Seleccionar()
        {

            if (transporte)
            {
                codigo_articulo = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString();
                nombre_articulo = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString();
                stock_articulo = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[2].Value.ToString();
            }
            else
            {
                codigo_articulo = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString();
                nombre_articulo = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString();
                stock_articulo = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[2].Value.ToString();
                precio_articulo = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[3].Value.ToString();
                precio_articulo_compra = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[4].Value.ToString();
                itebis = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[5].Value.ToString();
            }
            this.Close();





        }
    }
}
