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
    public partial class MantenimientoMarca : FormProcesos
    {
        public MantenimientoMarca()
        {
            InitializeComponent();
            cbxBuscar.SelectedIndex = 0;
            refrescarDatos(BuscarDatos);
        }
        public string BuscarDatos = "select * from marca where estado!='0' ";



        public override void Borrar()
        {
            DialogResult result = MessageBox.Show("Seguro que quiere eliminar el suplidor: " + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString() + " Codigo: " + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString(), "Atención", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                cmd = "update marca set estado='0' where id = '" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "';";
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
            RegistroMarca rc = new RegistroMarca();
            rc.ShowDialog();


            refrescarDatos(BuscarDatos);
        }

        public override void Modificar()
        {

            RegistroMarca rc = new RegistroMarca();
            rc.tbxCodigo.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString();
            rc.tbxMarca.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString();
            //rc.chxEstado.Checked = Convert.ToBoolean(dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[2].Value.ToString());
            rc.ShowDialog();


            refrescarDatos(BuscarDatos);

        }

        public string codigo_marca = "";
        public string nombre_marca = "";
        public override void Seleccionar()
        {
                codigo_marca = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString();
                nombre_marca = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString();
                this.Close();
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
                cmd += "where " + cbxBuscar.Text + " like('%" + parametro.Trim() + "%')";
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
