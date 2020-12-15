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
    public partial class MantenimientoVacantes : FormProcesos
    {
        public string Puesto = "",idVacante="";
        
        string BuscarDatos = "select top(200) p.idTercero,t.nombre,p.apellido,p.sexo,p.fecha_nacimiento,p.cedula,tl.numero as numero_telefono,cr.correo_electronico from persona as p, tercero as t, telefono as tl,telefono_vs_tercero as tvt,correo as cr,correo_vs_tercero as cvt   where  t.id=p.idTercero and tl.id=tvt.idTelefono and tvt.idTercero=p.idTercero and cr.id=cvt.idCorreo and cvt.idTercero=p.idTercero and t.nombre!='Consumidor Final' and not exists(select idTercero from empleado as e where p.idTercero=e.idTercero) ";
        public MantenimientoVacantes()
        {
            InitializeComponent();
            refrescarDatos(BuscarDatos);
        }
        public override void Seleccionar()
        {
            //cmd = "select p.fecha_nacimiento,h.descripcion,te.numero,c.correo_electronico,p.cedula,p.sexo " +
            //    "from telefono as te,telefono_vs_tercero as tev,correo as c,correo_vs_tercero as cv, tercero as t, persona as p, empleado as e, puesto as pu,departamento as d, horario as h " +
            //    "where p.idTercero='" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "' and p.idTercero='" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "' and e.idTercero='" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "' and e.idPuesto=pu.id and  e.idHorario=h.id and pu.idDepartamento=d.id and te.id=tev.idTelefono and c.id=cv.idCorreo and tev.idTercero='" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "' and cv.idTercero='" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "';";
            ////MessageBox.Show(cmd);
            //ds = Utilidades.EjecutarDS(cmd);
            
            RegistroEmpleados rc = new RegistroEmpleados();
            //rc.tbxCodigo.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString();
            //rc.tbxCodigo.Enabled = false;
            rc.tbxNombre.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString();
            rc.tbxNombre.Enabled = false;
            rc.tbxApellido.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[2].Value.ToString();
            rc.tbxApellido.Enabled = false;
            rc.dtFecha.Value = Convert.ToDateTime(dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[4].Value.ToString());
            rc.dtFecha.Enabled = false;
            rc.cbxSexo.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[3].Value.ToString();
            rc.cbxSexo.Enabled = false;
            //rc.cbxPuesto.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[3].Value.ToString();
            //rc.cbxHorario.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
            if (dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[6].Value.ToString()!="")
            {
                rc.tbxTelefono.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[6].Value.ToString();
                rc.tbxTelefono.Enabled = false;
                //ds = Utilidades.EjecutarDS("select id form telefono where numero='"+ dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[6].Value.ToString() + "'");
                //rc.idTelefono = ds.Tables[0].Rows[0]["id"].ToString();
            }
            if (dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[7].Value.ToString()!="")
            {
                rc.tbxCorreo.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[7].Value.ToString();
                rc.tbxCorreo.Enabled = false;
                //ds = Utilidades.EjecutarDS("select id form correo where correo_electronico='" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[4].Value.ToString() + "'");
                //rc.idCorreo = ds.Tables[0].Rows[0]["id"].ToString();
            }
            if (dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[5].Value.ToString()!="")
            {
                rc.tbxCedula.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[5].Value.ToString();
                rc.tbxCedula.Enabled = false;
            }
            rc.cbxPuesto.Text = Puesto;
            rc.idPersona = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString();
            rc.idVacante = idVacante;
            //MessageBox.Show(Puesto);
            rc.cbxPuesto.Enabled = false;
            //rc.chxEstado.Checked = Convert.ToBoolean(dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[7].Value.ToString());
            rc.nuevoEmpleado = true;
            rc.ShowDialog();
            this.Close();
            

        }
        public override void Nuevo()
        {
            RegistroEmpleados rc = new RegistroEmpleados();
            rc.cbxPuesto.Text = Puesto;
            rc.cbxPuesto.Enabled = false;
            //rc.idPersona = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString();
            rc.idVacante = idVacante;
            rc.ShowDialog();
            this.Close();
            
        }

    }
}
