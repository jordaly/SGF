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
    public partial class ControlPagos : FormProcesos
    {
        public DateTime hoy = DateTime.Now;
        public string BuscarDatos = "";
        public ControlPagos()
        {
            InitializeComponent();
            hoy = DateTime.Now;
            BuscarDatos = "select t.id,t.nombre,p.apellido,pu.puesto,pu.salario from pagos as pa, tercero as t, persona as p, empleado as e, puesto as pu,departamento as d, horario as h where p.idTercero=t.id and p.idTercero=t.id and e.idTercero=t.id and e.idPuesto=pu.id and  e.idHorario=h.id and pu.idDepartamento=d.id and e.estado='1' and pa.fecha_ultimo_pago not between '1/" + hoy.Month + "/" + hoy.Year + "' and '30/" + hoy.Month + "/" + hoy.Year + "' and e.idTercero=pa.idEmpleado ";
            //principal p = new principal();
            //p.richTextBox1.Text = BuscarDatos;
            //p.Show();
            //MessageBox.Show(BuscarDatos);
            refrescarDatos(BuscarDatos);
            cbxBuscar.SelectedIndex = 0;
        }



        public override void Buscar()
        {
            FormBarraBusqueda bb = new FormBarraBusqueda();
            bb.ShowDialog();
            string parametro = bb.parametro;
            string v = "";
            if (cbxBuscar.Text == "id" || cbxBuscar.Text == "nombre")
            {
                v = "t.";
            }
            else if (cbxBuscar.Text == "puesto" || cbxBuscar.Text == "salario")
            {
                v = "pu.";
            }
            else
            {
                v = "p.";
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



        public override void Modificar()
        {
            //cmd = "begin" +
            //        "select fecha_ultimo_pago from pagos where idEmpleado='"+ dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "';" +
            //    "end";
            //MessageBox.Show(""+dgvPadre.CurrentCell.RowIndex);
            if ((ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0))
            {
                hoy = DateTime.Now;
                //DateTime fechaPago = Convert.ToDateTime(ds.Tables[0].Rows[0]["fecha_ultimo_pago"].ToString());
                //dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString()
                //cmd = "select * from pagos where fecha_ultimo_pago between '1/" + hoy.Month + "/" + hoy.Year + "' and '30/" + hoy.Month + "/" + hoy.Year + "' and idEmpleado='" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "'";
                cmd = "select * from pagos where idEmpleado='"+ dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "'";
                ds = Utilidades.EjecutarDS(cmd);
                if (!(ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0))
                {
                    cmd = "insert into pagos(idEmpleado,fecha_ultimo_pago,estado)values('"+ dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "',getdate(),'1')";
                    ds = Utilidades.EjecutarDS(cmd);
                    MessageBox.Show("se a realizado el pago exitosamente");
                }
                else
                {
                    cmd = "update  pagos set idEmpleado='"+ dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "', fecha_ultimo_pago=getdate(), estado='1';";
                    ds = Utilidades.EjecutarDS(cmd);
                    MessageBox.Show("se a realizado el pago exitosamente");
                }
            }
            else
            {
                MessageBox.Show("No hay ningun empleado pendiente de pago");
            }
            
            refrescarDatos(BuscarDatos);
        }
    }
}
