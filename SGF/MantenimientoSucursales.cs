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
    public partial class MantenimientoSucursales : FormProcesos
    {
        string BuscarDatos = "select s.id,s.nombre_sucursal from sucursal as s where s.estado='1' ";
        public MantenimientoSucursales()
        {
            InitializeComponent();
            refrescarDatos(BuscarDatos);
        }
        public override void Nuevo()
        {
            RegistroSucursal rc = new RegistroSucursal();
            rc.ShowDialog();
            refrescarDatos(BuscarDatos);
        }
        public override void Modificar()
        {
            RegistroSucursal rc = new RegistroSucursal();
            cmd = "select * from sucursal_vs_almacen as sva, almacen as al where al.id=sva.idAlmacen and sva.idSucursal='"+ dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "';";
            ds = Utilidades.EjecutarDS(cmd);
            rc.tbxAlmacen.Text = ds.Tables[0].Rows[0]["nombre_almacen"].ToString();
            rc.codigoAlmacen = ds.Tables[0].Rows[0]["idAlmacen"].ToString();
            rc.tbxCodigo.Text= dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString();
            rc.tbxNombre.Text= dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString();
            rc.ShowDialog();
            refrescarDatos(BuscarDatos);
        }
        public override void Buscar()
        {
            FormBarraBusqueda bb = new FormBarraBusqueda();
            bb.ShowDialog();
            string parametro = bb.parametro;
            string v = "s.";
            cmd = BuscarDatos;
            
            //MessageBox.Show("se esta ejecuetando");
            if (!String.IsNullOrEmpty(parametro.Trim()))
            {
                cmd += " and " + v + cbxBuscar.Text.Trim() + " like('%" + parametro.Trim() + "%')";
            }
            ds = Utilidades.EjecutarDS(cmd);
            //MessageBox.Show(cmd);
            if (ds.Tables.Count > 0)
            {
                dgvPadre.DataSource = ds.Tables[0];
            }
        }


        public override void Borrar()
        {
            DialogResult result = MessageBox.Show("Seguro que quiere eliminar la sucursal: " + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString() + " Codigo: " + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString(), "Atención", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                cmd = "begin " +
               "update sucursal set estado='0' where id = '" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "';" +
               "delete from sucursal_vs_almacen where idSucursal='"+ dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "';" +
               "end";
                ds = Utilidades.EjecutarDS(cmd);
                MessageBox.Show("Se ha eliminado Exitosamente");
                refrescarDatos(BuscarDatos);
            }
            else
            {
                // No hacer nada
            }
        }

    }
}
