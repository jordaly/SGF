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
    public partial class ControlVacasiones : FormProcesos
    {
        public string BuscarDatos = "select e.idTercero as idEmpleado, t.nombre, p.apellido, v.fecha_inicio, v.fecha_fin, v.estado from persona as p, tercero as t,vacaciones as v, empleado as e where v.idEmpleado=e.idTercero and e.idTercero=t.id and e.idTercero=p.idTercero ";
        public ControlVacasiones()
        {
            InitializeComponent();
            refrescarDatos(BuscarDatos);
            cbxBuscar.SelectedIndex = 0;

        }
        public override void Modificar()
        {
            ModificarVacaciones rc = new ModificarVacaciones();
            
            rc.tbxCodigo.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString();
            rc.lblNombre.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString()+" "+ dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[2].Value.ToString();
            rc.dtFechaInicio.Value = Convert.ToDateTime(dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[3].Value.ToString());
            rc.dtFechaFin.Value = Convert.ToDateTime(dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[4].Value.ToString());
            rc.chxEstado.Checked = Convert.ToBoolean(dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[5].Value.ToString());
            
            rc.ShowDialog();
            
            refrescarDatos(BuscarDatos);
        }
        public override void Nuevo()
        {
            ////RegistroEmpleados rc = new RegistroEmpleados();
            ////rc.ShowDialog();


            ////refrescarDatos(BuscarDatos);
            ////cmd = "";
            ////MessageBox.Show(cmd);
            ////rtbxIndicaciones.Text = cmd;
            ////Console.Out(cmd);
            ////ds = Utilidades.EjecutarDS(cmd);
            //DateTime hoy = DateTime.Now;
            //DateTime FechaFinal = Convert.ToDateTime("1/11/2020");
            //TimeSpan t = FechaFinal - hoy;
            //double NrOfDays = t.TotalDays;
            //MessageBox.Show(""+NrOfDays);
        }
    }
}
