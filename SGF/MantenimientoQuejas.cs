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
    public partial class MantenimientoQuejas : FormProcesos
    {
        public string codigoUsuario = "";
        public string BuscarDatos = "select q.id,(select nombre from tercero where id=q.idCliente) as nombre,(select apellido from persona where idTercero=q.idCliente) as apellido,q.queja,q.idCliente,q.idArticulo,q.fecha_in from quejas as q where q.estado='1' ";
        public MantenimientoQuejas()
        {
            InitializeComponent();
            refrescarDatos(BuscarDatos);
            cbxBuscar.SelectedIndex = 0;
        }
        public override void Nuevo()
        {
            RegistroQuejas rc = new RegistroQuejas();
            ds = Utilidades.EjecutarDS("select idEmpleado from usuario where id='"+codigoUsuario+"';");
            rc.codigoEmpleado = ds.Tables[0].Rows[0]["idEmpleado"].ToString();
            rc.ShowDialog();
            refrescarDatos(BuscarDatos);
        }
        public override void Modificar()
        {
            RegistroQuejas rc = new RegistroQuejas();
            ds = Utilidades.EjecutarDS("select idEmpleado from usuario where id='" + codigoUsuario + "';");
            rc.codigoEmpleado = ds.Tables[0].Rows[0]["idEmpleado"].ToString();

            rc.tbxCodigo.Text= dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString();

            rc.codigoCliente = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[4].Value.ToString();
            rc.tbxCliente.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString() + " " + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[2].Value.ToString();
            
            ds = Utilidades.EjecutarDS("select nombre_articulo from articulo where id='" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[5].Value.ToString() + "';");
            rc.tbxArticulo.Text = ds.Tables[0].Rows[0]["nombre_articulo"].ToString();
            rc.codigoArticulo = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[5].Value.ToString();

            rc.rtbxParrafo.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[3].Value.ToString();

            rc.tbnSeleccionarArticulos.Enabled = false;
            rc.btnSeleccionarCliente.Enabled = false;
            rc.ShowDialog();

            refrescarDatos(BuscarDatos);

        }
        public override void Borrar()
        {
            RegistroQuejas rc = new RegistroQuejas();
            rc.tbxCodigo.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString();
            ds = Utilidades.EjecutarDS("select idEmpleado from usuario where id='" + codigoUsuario + "';");
            rc.codigoEmpleado = ds.Tables[0].Rows[0]["idEmpleado"].ToString();
            rc.tbxCliente.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString() + " " + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[2].Value.ToString();
            ds = Utilidades.EjecutarDS("select nombre_articulo from articulo where id='" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[5].Value.ToString() + "';");
            rc.tbxArticulo.Text = ds.Tables[0].Rows[0]["nombre_articulo"].ToString();
            rc.codigoCliente = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[4].Value.ToString();
            rc.codigoArticulo = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[5].Value.ToString();
            rc.tbnSeleccionarArticulos.Enabled = false;
            rc.btnSeleccionarCliente.Enabled = false;
            rc.resolver = true;
            rc.lbTituloRTBX.Text = "Solucion";
            rc.ShowDialog();

            refrescarDatos(BuscarDatos);

        }
    }
}
