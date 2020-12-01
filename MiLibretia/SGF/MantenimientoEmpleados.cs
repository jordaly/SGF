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
    public partial class MantenimientoEmpleados : FormProcesos
    {
        public string BuscarDatos = "select t.id,t.nombre,p.apellido,pu.puesto,pu.salario,h.hora_entrada,h.hora_salida,e.estado from tercero as t, persona as p, empleado as e, puesto as pu,departamento as d, horario as h where p.idTercero=t.id and p.idTercero=t.id and e.idTercero=t.id and e.idPuesto=pu.id and  e.idHorario=h.id and pu.idDepartamento=d.id ";
        public MantenimientoEmpleados()
        {
            InitializeComponent();
            refrescarDatos(BuscarDatos);
            cbxBuscar.SelectedIndex = 0;
        }


        public override void Borrar()
        {
            DialogResult result = MessageBox.Show("Seguro que quiere eliminar el empleado: " + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString() + " " + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[2].Value.ToString() + " Codigo: " + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString(), "Atención", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                cmd = "begin " +
               "delete from empleado where idTercero = '" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "';" +
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
            RegistroEmpleados rc = new RegistroEmpleados();
            rc.ShowDialog();


            refrescarDatos(BuscarDatos);
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
            else if (cbxBuscar.Text == "hora_entrada" || cbxBuscar.Text == "hora_salida")
            {
                v = "h.";
            }
            else if (cbxBuscar.Text == "estado") 
            {
                v = "e.";
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
            cmd = "select p.fecha_nacimiento,h.descripcion,te.numero,c.correo_electronico,p.cedula,p.sexo " +
                "from telefono as te,telefono_vs_tercero as tev,correo as c,correo_vs_tercero as cv, tercero as t, persona as p, empleado as e, puesto as pu,departamento as d, horario as h " +
                "where p.idTercero='" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "' and p.idTercero='" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "' and e.idTercero='" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "' and e.idPuesto=pu.id and  e.idHorario=h.id and pu.idDepartamento=d.id and te.id=tev.idTelefono and c.id=cv.idCorreo and tev.idTercero='" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "' and cv.idTercero='" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "';";
            //MessageBox.Show(cmd);
            ds = Utilidades.EjecutarDS(cmd);
            RegistroEmpleados rc = new RegistroEmpleados();
            rc.tbxCodigo.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString();
            rc.tbxNombre.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString();
            rc.tbxApellido.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[2].Value.ToString();
            rc.dtFecha.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["fecha_nacimiento"].ToString() );
            rc.cbxSexo.Text = ds.Tables[0].Rows[0]["sexo"].ToString();
            rc.cbxPuesto.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[3].Value.ToString();
            rc.cbxHorario.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
            rc.tbxTelefono.Text = ds.Tables[0].Rows[0]["numero"].ToString(); 
            rc.tbxCorreo.Text = ds.Tables[0].Rows[0]["correo_electronico"].ToString();
            rc.tbxCedula.Text = ds.Tables[0].Rows[0]["cedula"].ToString(); 
            rc.chxEstado.Checked = Convert.ToBoolean(dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[7].Value.ToString());
            rc.ShowDialog();



            //rc.tbxLocalidad.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[7].Value.ToString();
            //rc.tbxDireccion.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[8].Value.ToString();
            //rc.tbxCodigo_postal.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[9].Value.ToString();
            //rc.rtbxIndicaciones.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[10].Value.ToString();

            refrescarDatos(BuscarDatos);
        }
    }
}
