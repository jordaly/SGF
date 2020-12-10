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
    public partial class MantenimientoSuplidores : FormProcesos
    {
        
        public MantenimientoSuplidores()
        {
            InitializeComponent();
            cbxBuscar.SelectedIndex = 0;
            refrescarDatos(BuscarDatos);
        }
        public string BuscarDatos = "select s.idTercero,t.nombre,t.RNC from suplidor as s, tercero as t where t.id=s.idTercero and s.estado!='0' ";



        public override void Borrar()
        {
            DialogResult result = MessageBox.Show("Seguro que quiere eliminar la marca: " + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString() + " Codigo: " + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString(), "Atención", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                cmd = "update suplidor set estado='0' where idTercero = '" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "';";
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
            RegistroSuplidores rc = new RegistroSuplidores();
            rc.ShowDialog();


            refrescarDatos(BuscarDatos);
        }

        public override void Modificar()
        {

            RegistroSuplidores rc = new RegistroSuplidores();
            rc.tbxCodigo.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString();
            rc.tbxNombre.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString();
            if (dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString()!=null)
            {
                rc.tbxRNC.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[2].Value.ToString();
            }
            //rc.chxEstado.Checked = Convert.ToBoolean(dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[3].Value.ToString());
            rc.ShowDialog();


            refrescarDatos(BuscarDatos);

        }

        public string codigo_suplidor = "";
        public string nombre_suplidor = "";
        public string RNC = "";
        public override void Seleccionar()
        {

            if (dgvPadre.Rows.Count != 0)
            {
                codigo_suplidor = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString();
                nombre_suplidor = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString();
             
                this.Close();
            }


            
        }

        public override void Buscar()
        {
            FormBarraBusqueda bb = new FormBarraBusqueda();
            bb.ShowDialog();
            string parametro = bb.parametro;
            string v = "";
            if (cbxBuscar.Text=="nombre" || cbxBuscar.Text=="RNC")
            {
                v = "t.";
            }
            else
            {
                v = "s.";
            }
           

            cmd = BuscarDatos;
            //MessageBox.Show("se esta ejecuetando");
            if (!String.IsNullOrEmpty(parametro.Trim()))
            {
                cmd += " and " +v+ cbxBuscar.Text + " like('%" + parametro.Trim() + "%')";
            }
            ds = Utilidades.EjecutarDS(cmd);
            //MessageBox.Show(cmd);
            if (ds.Tables.Count > 0)
            {
                dgvPadre.DataSource = ds.Tables[0];
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

        }
    }
}
