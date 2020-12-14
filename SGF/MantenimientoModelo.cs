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
    public partial class MantenimientoModelo : FormProcesos
    {
        public string BuscarDatos = "select * from modelo ";
        public MantenimientoModelo()
        {
            InitializeComponent();
            refrescarDatos(BuscarDatos);
        }

        public override void Nuevo()
        {
            RegistroModelo rc = new RegistroModelo();
            rc.ShowDialog();

            refrescarDatos(BuscarDatos);
        }
        public override void Modificar()
        {
            RegistroModelo rc = new RegistroModelo();
            rc.tbxCodigo.Text= dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString();
            rc.tbxNombre.Text= dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString();
            rc.tbxConsumo.Text= dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[2].Value.ToString();
            rc.tbxCantidad.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[3].Value.ToString();
            rc.tbxValor.Text= dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[4].Value.ToString();
            rc.ShowDialog();

            refrescarDatos(BuscarDatos);
        }

        public string nombre_modelo = "", codigo_modelo = "";
        public override void Seleccionar()
        {
            codigo_modelo= dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString();
            nombre_modelo = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString();
            this.Close();
        }

        public override void Borrar()
        {
            DialogResult result = MessageBox.Show("Seguro que quiere eliminar el Modelo: " + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString(), "Atención", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                cmd = "begin " +
               "update modelo set estado='0' where id='" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "';" +
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
