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
    public partial class MantenimientoVehiculos : FormProcesos
    {
        public string BuscarDatos = "select v.Matricula,v.idMarca,ma.marca, v.idModelo, mo.modelo from vehiculo as v, marca as ma, modelo as mo where ma.id=v.idMarca and mo.id=v.idModelo and v.estado='1'  ";
        public MantenimientoVehiculos()
        {
            InitializeComponent();
            refrescarDatos(BuscarDatos);
            cbxBuscar.SelectedIndex = 0;
            
        }





        public override void Nuevo()
        {
            RegistroVehiculo rc = new RegistroVehiculo();
            rc.ShowDialog();

            refrescarDatos(BuscarDatos);
        }







        public override void Modificar()
        {
            RegistroVehiculo rc = new RegistroVehiculo();
            rc.tbxMatricula.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString();
            rc.tbxMatricula.Enabled = false;
            rc.nuevo = false;
            rc.idMarca = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString();
            rc.tbxMarca.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[2].Value.ToString();
            rc.idModelo = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[3].Value.ToString();
            rc.tbxModelo.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[4].Value.ToString();
            //rc.tbxValor.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[5].Value.ToString();
            //rc.tbxCantidad.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[6].Value.ToString();
            //rc.tbxConsumo.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[7].Value.ToString();

            rc.ShowDialog();



            refrescarDatos(BuscarDatos);
        }







        public override void Borrar()
        {
            DialogResult result = MessageBox.Show("Seguro que quiere eliminar el vehiculo: " + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() , "Atención", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                cmd = "begin " +
               "update vehiculo set estado='0' where Matricula='" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "';" +
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





        public override void Buscar()
        {
            FormBarraBusqueda bb = new FormBarraBusqueda();
            bb.ShowDialog();
            string parametro = bb.parametro;
            string v = "";
            if (cbxBuscar.Text == "Matricula" || cbxBuscar.Text == "idMarca" || cbxBuscar.Text=="idModelo" || cbxBuscar.Text == "Valor" || cbxBuscar.Text == "capacidad" || cbxBuscar.Text == "consumoKpG")
            {
                v = "v.";
            }
            else if (cbxBuscar.Text == "marca" )
            {
                v = "ma.";
            }
            else
            {
                v = "mo.";
            }
            
            cmd = BuscarDatos;
            //MessageBox.Show("se esta ejecuetando");
            if (!String.IsNullOrEmpty(parametro.Trim()))
            {
                cmd += " and " + v + cbxBuscar.Text + " like('%" + parametro.Trim() + "%')";
            }
            ds = Utilidades.EjecutarDS(cmd);
            //MessageBox.Show(cmd);
            if (ds.Tables.Count > 0)
            {
                dgvPadre.DataSource = ds.Tables[0];
            }
        }
        public string matricula = "";
        public override void Seleccionar()
        {
            matricula = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString();
            this.Close();
        }

        public bool transporte = false;
        private void MantenimientoVehiculos_Load(object sender, EventArgs e)
        {
            if (transporte)
            {
                BuscarDatos = "select v.Matricula,v.idMarca,ma.marca, v.idModelo, mo.modelo from vehiculo as v, marca as ma, modelo as mo where ma.id=v.idMarca and mo.id=v.idModelo and v.estado='1' and v.reparacion='0' and v.transporte='0'  ";
                refrescarDatos(BuscarDatos);
            }
            
        }
    }
}
