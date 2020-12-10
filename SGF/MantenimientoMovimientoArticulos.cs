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
    public partial class MantenimientoMovimientoArticulos : FormProcesos
    {
        public string BuscarDatos = "select a.id,a.descripcion,(a.existencia-(select sum(cantidad)  from articulo_vs_almacen where idArticulo=a.id)) cantidad_sin_asignar,(select sum(cantidad)  from articulo_vs_almacen where idArticulo=a.id) as cantidad_asignada,a.existencia as total from articulo as a  where a.estado!='0' ";
        public MantenimientoMovimientoArticulos()
        {
            InitializeComponent();
            cbxBuscar.SelectedIndex = 0;
            refrescarDatos(BuscarDatos);
        }

        public override void Borrar()
        {
            DialogResult result = MessageBox.Show("Seguro que quiere eliminar este articulo: " + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + " del almacen: " + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString(), "Atención", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                cmd = "begin " +
               "declare @idArticulo uniqueidentifier;" +
               "declare @idAlmacen uniqueidentifier;" +
               "select @idArticulo=ar.id from articulo_vs_almacen as ava,articulo as ar, almacen as al where ar.nombre_articulo='"+ dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "';" +
               "select @idAlmacen=al.id from articulo_vs_almacen as ava,articulo as ar, almacen as al where ar.nombre_almacen='" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString() + "';" +
               "delete from articulo_vs_almacen where idArticulo = @idArticulo and idAlmacen = @idAlmacen;" +
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

        public override void Nuevo()
        {
            RegistroMovimientoArticulos rc = new RegistroMovimientoArticulos("");
            rc.ShowDialog();


            refrescarDatos(BuscarDatos);
        }

        public override void Modificar()
        {

            RegistroMovimientoArticulos rc = new RegistroMovimientoArticulos(dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString());
            //rc.cbxArticulo.SelectedItem = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString();
            //rc.cbxAlmacen.SelectedItem = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString();
            rc.tbxCodigoArticulo.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString();
            //rc.idArticulo= dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString();
            //rc.rtbxIndicaciones.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[3].Value.ToString();
            //ds = Utilidades.EjecutarDS(cmd);
            rc.tkbCantidad.Maximum =Convert.ToInt32( dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[2].Value.ToString());
            rc.sinAsignar = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[2].Value.ToString();
            rc.Asignado = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[3].Value.ToString();
            rc.total = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[4].Value.ToString();
            rc.ShowDialog();


            refrescarDatos(BuscarDatos);

        }

        public override void Buscar()
        {
            FormBarraBusqueda bb = new FormBarraBusqueda();
            bb.ShowDialog();
            string parametro = bb.parametro;
            string v = "";
            if (cbxBuscar.Text=="cantidad" || cbxBuscar.Text=="indicaciones")
            {
                v = "ava.";
            }
            else if (cbxBuscar.Text == "nombre_articulo")
            {
                v = "ar.";
            }
            else
            {
                v = "al.";
            }
            

            cmd = BuscarDatos;
            //MessageBox.Show("se esta ejecuetando");
            if (!String.IsNullOrEmpty(parametro.Trim()))
            {
                cmd += "and " + v + cbxBuscar.Text + " like('%" + parametro.Trim() + "%')";
            }
            ds = Utilidades.EjecutarDS(cmd);
            //MessageBox.Show(cmd);
            if (ds.Tables.Count > 0)
            {
                dgvPadre.DataSource = ds.Tables[0];
            }
        }
    }
}
