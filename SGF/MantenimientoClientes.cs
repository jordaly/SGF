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
    public partial class MantenimientoClientes : FormProcesos
    {

        public MantenimientoClientes()
        {
            InitializeComponent();
            refrescarDatos();
            cbxBuscar.SelectedIndex = 0;

        }
        public string BuscarDatos = "select t.id, t.nombre,p.apellido,p.fecha_nacimiento,p.sexo,pais.pais,d.provincia,d.localidad,d.direccion,d.codigo_postal,d.indicaciones,telefono.numero,correo.correo_electronico,p.estado from persona as p,tercero as t, cliente as c,direccion_cliente as d,pais,telefono,correo,correo_vs_tercero,telefono_vs_tercero where c.idTercero = t.id and c.idTercero = p.idtercero and d.idPais=pais.id and d.id=c.idDireccion_cleinte and telefono_vs_tercero.idTelefono=telefono.id and telefono_vs_tercero.idTercero=t.id and correo_vs_tercero.idCorreo=correo.id and correo_vs_tercero.idTercero=t.id";

        public void refrescarDatos()
        {
            ds = Utilidades.EjecutarDS(BuscarDatos);
            dgvPadre.DataSource = ds.Tables[0];
        }
        public override void Borrar()
        {
            DialogResult result = MessageBox.Show("Seguro que quiere eliminar el cliente: "+ dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString()+" "+ dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[2].Value.ToString()+" Codigo: "+ dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString(),"Atención", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                cmd = "begin " +
               "declare @idDireccion uniqueidentifier; " +
               "select @idDireccion = c.idDireccion_cleinte from cliente as c, direccion_cliente as d, tercero as t where c.idTercero = '" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "' and c.idTercero = t.id and c.idDireccion_cleinte = d.id;" +
               "delete from cliente where idTercero = '" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "';" +
               "delete from direccion_cliente where id = @idDireccion;" +
               "end";
                ds=Utilidades.EjecutarDS(cmd);
                MessageBox.Show("Se ha eliminado Exitosamente");
                refrescarDatos();
            }
            else
            {
                // No hacer nada
            }
            
        }
        public override void Buscar()
        {

            //String cmd = "select * from cliente";
            ////MessageBox.Show("se esta ejecuetando");
            //if (!String.IsNullOrEmpty(Mitextbox1.Text.Trim()))
            //{
            //    cmd += " where Nombre_Cliente like('%" + Mitextbox1.Text.Trim() + "%')";
            //}
            //ds = Utilidades.EjecutarDS(cmd);

            //if (ds.Tables.Count > 0)
            //{
            //    dgvPadre.DataSource = ds.Tables[0];
            //}

        }
        public override void Nuevo()
        {
            RegistroClientes rc = new RegistroClientes();
            rc.ShowDialog();


            refrescarDatos();
        }
        private void MantenimientoClientes_Load(object sender, EventArgs e)
        {

        }
        public override void Modificar()
        {
            RegistroClientes rc = new RegistroClientes();
            rc.canbiarCodigo(dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString());
            rc.tbxNombre.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString();
            rc.tbxApellido.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[2].Value.ToString();
            rc.dtFecha.Value= Convert.ToDateTime(dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[3].Value.ToString());
            rc.cbxSexo.SelectedItem = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[4].Value.ToString();
            rc.cbxProvincia.SelectedItem = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[6].Value.ToString();
            rc.tbxLocalidad.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[7].Value.ToString();
            rc.tbxDireccion.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[8].Value.ToString();
            rc.tbxCodigo_postal.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[9].Value.ToString();
            rc.rtbxIndicaciones.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[10].Value.ToString();
            rc.tbxTelefono.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[11].Value.ToString();
            rc.tbxCorreo.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[12].Value.ToString();
            rc.chxEstado.Checked=Convert.ToBoolean( dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[13].Value.ToString());
            rc.ShowDialog();


            refrescarDatos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            FormBarraBusqueda bb = new FormBarraBusqueda();
            bb.ShowDialog();
            string parametro = bb.parametro;
            string v = "";
            if (cbxBuscar.Text=="id"||cbxBuscar.Text=="nombre")
            {
                v = "t.";
            }
            else if (cbxBuscar.Text == "provincia" || cbxBuscar.Text == "localidad" || cbxBuscar.Text == "direccion" || cbxBuscar.Text == "codigo_postal" || cbxBuscar.Text == "indicaciones" )
            {
                v = "d.";
            }
            else
            {
                v = "p.";
            }

            cmd = BuscarDatos;
            //MessageBox.Show("se esta ejecuetando");
            if (!String.IsNullOrEmpty(parametro.Trim()))
            {
                cmd += "and "+v+cbxBuscar.Text+" like('%" + parametro.Trim() + "%')";
            }
            ds = Utilidades.EjecutarDS(cmd);
            //MessageBox.Show(cmd);
            if (ds.Tables.Count > 0)
            {
                dgvPadre.DataSource = ds.Tables[0];
            }
           

            //if (tbxBuscar.Text != "")
            //{
            //    dgvPadre.CurrentCell = null;
            //    foreach (DataGridViewRow r in dgvPadre.Rows)
            //    {
            //        r.Visible = false;
            //    }

            //    foreach (DataGridViewRow r in dgvPadre.Rows)
            //    {
            //        foreach (DataGridViewCell c in r.Cells)
            //        {
            //            if ((c.Value.ToString().ToUpper().IndexOf(tbxBuscar.Text.ToUpper())) == 0)
            //            {
            //                r.Visible = true;
            //                break;
            //            }
            //        }

            //    }
            //}
            //else
            //{
            //    dgvPadre.DataSource = ds.Tables[0];
            //    //DisplayData();
            //}


            //dgvPadre.CurrentCell = null;
            //foreach (DataGridViewRow r in dgvPadre.Rows)
            //{
            //    r.Visible = false;
            //}

            //foreach (DataGridViewRow r in dgvPadre.Rows)
            //{
            //    foreach (DataGridViewCell c in r.Cells)
            //    {
            //        if ((c.Value.ToString().ToUpper().IndexOf(parametro.ToUpper())) == 0)
            //        {
            //            r.Visible = true;
            //            break;
            //        }
            //    }

            //}
            //dgvPadre.DataSource = ds.Tables[0];
        }

    }
}
