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
    public partial class MantenimientoAlmacenes : FormProcesos
    {
        public bool almacenSucursal = false;
        
        public MantenimientoAlmacenes()
        {
            InitializeComponent();
            cbxBuscar.SelectedIndex = 0;
            refrescarDatos(BuscarDatos);
        }
        public string BuscarDatos = "select * from almacen where estado!='0'";


        public string codigo_almacen = "";
        public string nombre_almacen = "";
        public override void Seleccionar()
        {

            
                codigo_almacen = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString();
                nombre_almacen = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString();
                
                this.Close();
            


        }
        public override void Modificar()
        {
            
                RegistroAlmanenes rc = new RegistroAlmanenes();
                rc.tbxCodigo.Text = (dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString());
                rc.tbxDescripcion.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString();
                rc.tbxCapacidad.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[2].Value.ToString();
                //rc.chxEstado.Checked = Convert.ToBoolean(dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[3].Value.ToString());
                rc.ShowDialog();


                refrescarDatos(BuscarDatos);
            
        }
        public override void Borrar()
        {
            DialogResult result = MessageBox.Show("Seguro que quiere eliminar el almacen: " + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString() +  " Codigo: " + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString(), "Atención", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                cmd = "begin " +
               "update almacen set estado='0' where id = '" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "';" +
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
            RegistroAlmanenes rc = new RegistroAlmanenes();
            rc.ShowDialog();

            if (almacenSucursal)
            {
                cmd = "select * from almacen as al, sucursal_vs_almacen as sva where al.id!=sva.idAlmacen and al.estado='1'";
                refrescarDatos(cmd);
            }
            else
            {
                refrescarDatos(BuscarDatos);
            }
            
        }
        public override void Buscar()
        {
            FormBarraBusqueda bb = new FormBarraBusqueda();
            bb.ShowDialog();
            string parametro = bb.parametro;
            string v = "";

            if (almacenSucursal)
            {
                cmd = "select * from almacen as al, sucursal_vs_almacen as sva where al.id!=sva.idAlmacen and al.estado='1' ";
                v = "al.";
            }
            else
            {
                cmd = BuscarDatos;
            }
            //MessageBox.Show("se esta ejecuetando");
            if (!String.IsNullOrEmpty(parametro.Trim()))
            {
                cmd +=" and "+  v + cbxBuscar.Text.Trim() + " like('%" + parametro.Trim() + "%')";
            }
            ds = Utilidades.EjecutarDS(cmd);
            //MessageBox.Show(cmd);
            if (ds.Tables.Count > 0)
            {
                dgvPadre.DataSource = ds.Tables[0];
            }
        }

        private void MantenimientoAlmacenes_Load(object sender, EventArgs e)
        {
            if (almacenSucursal)
            {
                cmd = "select * from almacen as al, sucursal_vs_almacen as sva where al.id!=sva.idAlmacen and al.estado='1'";
                refrescarDatos(cmd);
            }
        }
    }
}
