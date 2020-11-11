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
    public partial class MantenimientoUsuarios : FormProcesos
    {
        public string BuscarDatos = "select id, usuario, limite_descuento, estado from usuarios;";
        public MantenimientoUsuarios()
        {
            InitializeComponent();
            cbxBuscar.SelectedIndex = 0;
            refrescarDatos(BuscarDatos);
        }

        public override void Borrar()
        {
            DialogResult result = MessageBox.Show("Seguro que quiere eliminar el usuario: " + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString() + " Codigo: " + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString(), "Atención", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                cmd = "begin " +
               "delete from usuario where id = '" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "';" +
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
            RegistroUsuarios rc = new RegistroUsuarios();
            rc.ShowDialog();


            refrescarDatos(BuscarDatos);
        }

        public override void Modificar()
        {

            RegistoInventario rc = new RegistoInventario();
            rc.tbxCodigo.Text = (dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString());
            rc.tbxNombre.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString();
            rc.tbxPrecio_compra.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[2].Value.ToString();
            rc.tbxPrecio_venta.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[3].Value.ToString();
            rc.tbxExistencia.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[4].Value.ToString();
            rc.tbxDescripcion.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[5].Value.ToString();
            rc.tbxCantidad_maxima.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[6].Value.ToString();
            rc.tbxCantidad_minima.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[7].Value.ToString();
            rc.dtFecha_renovacion.Value = Convert.ToDateTime(dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[8].Value.ToString());
            rc.cbxMedida.SelectedItem = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[9].Value.ToString();
            rc.cbxMarca.SelectedItem = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[10].Value.ToString();
            rc.cbxTipo.SelectedItem = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[11].Value.ToString();
            rc.chxEstado.Checked = Convert.ToBoolean(dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[12].Value.ToString());
            cmd = "select * from cantidad_caja where idArticulo='" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "';";
            ds = Utilidades.EjecutarDS(cmd);
            //if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            //{
            //    rc.tbxCantidad_caja.Visible = true;
            //    rc.tbxCantidad_caja.Text = ds.Tables[0].Rows[0]["cantidad_caja"].ToString();
            //    //MessageBox.Show("errror: "+ds.Tables[0].Rows[0]["cantidad_caja"].ToString());
            //    rc.etCantidad.Visible = true;
            //}
            rc.ShowDialog();


            refrescarDatos(BuscarDatos);

        }

        public override void Buscar()
        {
            FormBarraBusqueda bb = new FormBarraBusqueda();
            bb.ShowDialog();
            string parametro = bb.parametro;
            

            cmd = BuscarDatos;
            //MessageBox.Show("se esta ejecuetando");
            if (!String.IsNullOrEmpty(parametro.Trim()))
            {
                cmd += "and "+ cbxBuscar.Text + " like('%" + parametro.Trim() + "%')";
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
