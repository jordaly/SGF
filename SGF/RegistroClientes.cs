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
    public partial class RegistroClientes : FormRegistros
    {
        public void canbiarCodigo(string codigo)
        {
            tbxCodigo.Text = codigo;
        }
        public override void Guardar()
        {
            //(ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            //cmd = "";
            //string cmdCliente = string.Format("select * from cliente where idTercero='{0}'",
            //    tbxCodigo.Text.Trim());
            //ds = Utilidades.EjecutarDS(cmdCliente);
            if (tbxNombre.Text == "" || tbxApellido.Text == "" || tbxCodigo_postal.Text == "" || tbxDireccion.Text == "" || tbxLocalidad.Text == "" || tbxCodigo.Text == "" || tbxTelefono.Text == "" || rtbxIndicaciones.Text == "")
            {
                MessageBox.Show("Faltan campos por reyenar");
            }
            else
            {
                if (tbxCodigo.Text != "Nuevo")
                {
                    cmd = "begin" +
                        " declare @idDireccion uniqueidentifier;" +
                        "declare @idTelefono uniqueidentifier;" +
                        "declare @idCorreo uniqueidentifier;" +
                        "select @idTelefono=te.idTelefono from telefono_vs_tercero as te,tercero as t where t.id='" + tbxCodigo.Text.Trim() + "' and te.idTercero=t.id;" +
                        "select @idCorreo = c.idCorreo from correo_vs_tercero as c,tercero as t where t.id = '" + tbxCodigo.Text.Trim() + "' and c.idTercero = t.id; " +
                        "select @idDireccion=c.idDireccion_cleinte from cliente as c,tercero as t where t.id='" + tbxCodigo.Text.Trim() + "' and c.idTercero=t.id;" +
                        "update telefono set numero='" + tbxTelefono.Text.Trim() + "'where id=@idTelefono;" +
                        "update correo set correo_electronico='" + tbxCorreo.Text.Trim() + "'where id=@idCorreo;" +
                        "update tercero " +
                        "set nombre='" + tbxNombre.Text.Trim() + "',estado='" + chxEstado.Checked + "'" +
                        "where id='" + tbxCodigo.Text.Trim() + "';" +
                        "update persona " +
                        "set apellido='" + tbxApellido.Text.Trim() + "',fecha_nacimiento='" + dtFecha.Value.Day + "/" + dtFecha.Value.Month + "/" + dtFecha.Value.Year + "',sexo='" + cbxSexo.Text.Trim() + "'" +
                        "where idTercero='" + tbxCodigo.Text.Trim() + "';" +
                        "update direccion_cliente " +
                        "set provincia='" + cbxProvincia.Text.Trim() + "',localidad='" + tbxLocalidad.Text.Trim() + "',direccion='" + tbxDireccion.Text.Trim() + "',indicaciones='" + rtbxIndicaciones.Text.Trim() + "',codigo_postal='" + tbxCodigo_postal.Text.Trim() + "'" +
                        "where id=@idDireccion " +
                        "end";
                    //MessageBox.Show(cmd);
                    //rtbxIndicaciones.Text = cmd;
                    //Console.Out(cmd);
                    ds = Utilidades.EjecutarDS(cmd);
                    MessageBox.Show("Modificado exitosamente");
                    Limpiar();
                    this.Close();


                }
                else
                {
                    cmd = String.Format("exec crearCliente '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}'",
                       tbxNombre.Text.Trim(), tbxApellido.Text.Trim(), dtFecha.Value.Day + "/" + dtFecha.Value.Month + "/" + dtFecha.Value.Year,
                       cbxSexo.Text.Trim(), cbxProvincia.Text.Trim(), tbxLocalidad.Text.Trim(), tbxDireccion.Text.Trim(), rtbxIndicaciones.Text.Trim(),
                       tbxCodigo_postal.Text.Trim(), chxEstado.Checked, tbxCorreo.Text.Trim(), tbxTelefono.Text.Trim());
                    //rtbxIndicaciones.Text = cmd;
                    //MessageBox.Show(cmd);
                    ds = Utilidades.EjecutarDS(cmd);
                    MessageBox.Show("Guardado exitosamente");
                    Limpiar();
                    this.Close();
                }
            }
        }

        public RegistroClientes()
        {
            
            InitializeComponent();
            cbxSexo.SelectedIndex = 0;
            cbxProvincia.SelectedIndex = 0;
            //try
            //{
            //    string cmdDepartamentos = String.Format("Select * from ");
            //    string cmdSuplidores = String.Format("Select * from Suplidores");
            //    string cmdUnidades = String.Format("Select * from Unidades");
            //    string cmdGrupo = String.Format("Select * from GrupoArticulo");
            //    //Departamentos
            //    ds = UTILIDADES1.utilidades.EjecutarDS(cmdDepartamentos);
            //    cbxCodigoDepartamento.DisplayMember = "Nombre_Departamento";
            //    cbxCodigoDepartamento.DataSource = ds.Tables[0].DefaultView;
            //    //Suplidores
            //    ds = UTILIDADES1.utilidades.EjecutarDS(cmdSuplidores);
            //    cbxCodigoSuplidor.DisplayMember = "Nombre_Suplidor";
            //    cbxCodigoSuplidor.DataSource = ds.Tables[0].DefaultView;
            //    //Unidades
            //    ds = UTILIDADES1.utilidades.EjecutarDS(cmdUnidades);
            //    cbxCodigoUnidad.DisplayMember = "Codigo_Unidad";//Tengo que averiguar que es lo que hace el displaymember
            //    cbxCodigoUnidad.DataSource = ds.Tables[0].DefaultView;//Tengo que averiguar que es lo que hace el defaultview
            //    //Grupo
            //    ds = UTILIDADES1.utilidades.EjecutarDS(cmdGrupo);
            //    cbxGrupo.DisplayMember = "Nombre";//Tengo que averiguar que es lo que hace el displaymember
            //    cbxGrupo.DataSource = ds.Tables[0].DefaultView;//Tengo que averiguar que es lo que hace el defaultview
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MantenimientoClientes_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //(ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            //cmd = "";
            //string cmdCliente = string.Format("select * from cliente where idTercero='{0}'",
            //    tbxCodigo.Text.Trim());
            //ds = Utilidades.EjecutarDS(cmdCliente);
            if (tbxNombre.Text==""||tbxApellido.Text==""||tbxCodigo_postal.Text==""||tbxDireccion.Text==""||tbxLocalidad.Text==""||tbxCodigo.Text==""||tbxTelefono.Text==""||rtbxIndicaciones.Text=="")
            {
                MessageBox.Show("Faltan campos por reyenar");
            }
            else { 
            if (tbxCodigo.Text!="Nuevo")
            {
                 cmd="begin" +
                     " declare @idDireccion uniqueidentifier;" +
                     "declare @idTelefono uniqueidentifier;" +
                     "declare @idCorreo uniqueidentifier;" +
                     "select @idTelefono=te.idTelefono from telefono_vs_tercero as te,tercero as t where t.id='" + tbxCodigo.Text.Trim() + "' and te.idTercero=t.id;" +
                     "select @idCorreo = c.idCorreo from correo_vs_tercero as c,tercero as t where t.id = '" + tbxCodigo.Text.Trim()+"' and c.idTercero = t.id; " +
                     "select @idDireccion=c.idDireccion_cleinte from cliente as c,tercero as t where t.id='" + tbxCodigo.Text.Trim()+"' and c.idTercero=t.id;" +
                     "update telefono set numero='" + tbxTelefono.Text.Trim() + "'where id=@idTelefono;" +
                     "update correo set correo_electronico='" + tbxCorreo.Text.Trim() + "'where id=@idCorreo;" +
                     "update tercero " +
                     "set nombre='"+tbxNombre.Text.Trim()+ "',estado='" + chxEstado.Checked + "'" +
                     "where id='" + tbxCodigo.Text.Trim() + "';" +
                     "update persona " +
                     "set apellido='" + tbxApellido.Text.Trim() + "',fecha_nacimiento='"+ dtFecha.Value.Day + "/" + dtFecha.Value.Month + "/" + dtFecha.Value.Year + "',sexo='"+cbxSexo.Text.Trim()+"'" +
                     "where idTercero='" + tbxCodigo.Text.Trim() + "';" +
                     "update direccion_cliente " +
                     "set provincia='" + cbxProvincia.Text.Trim() + "',localidad='" + tbxLocalidad.Text.Trim() + "',direccion='" + tbxDireccion.Text.Trim() + "',indicaciones='" + rtbxIndicaciones.Text.Trim() + "',codigo_postal='" + tbxCodigo_postal.Text.Trim() + "'" +
                     "where id=@idDireccion " +
                     "end";
                //MessageBox.Show(cmd);
                //rtbxIndicaciones.Text = cmd;
                //Console.Out(cmd);
                ds = Utilidades.EjecutarDS(cmd);
                MessageBox.Show("Modificado exitosamente");
                Limpiar();
                this.Close();


            }
            else
            {
                 cmd = String.Format("exec crearCliente '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}'",
                    tbxNombre.Text.Trim(), tbxApellido.Text.Trim(), dtFecha.Value.Day + "/" + dtFecha.Value.Month + "/" + dtFecha.Value.Year,
                    cbxSexo.Text.Trim(),cbxProvincia.Text.Trim(),tbxLocalidad.Text.Trim(), tbxDireccion.Text.Trim(), rtbxIndicaciones.Text.Trim(),
                    tbxCodigo_postal.Text.Trim(), chxEstado.Checked,tbxCorreo.Text.Trim(),tbxTelefono.Text.Trim());
                //rtbxIndicaciones.Text = cmd;
                //MessageBox.Show(cmd);
                ds = Utilidades.EjecutarDS(cmd);
                MessageBox.Show("Guardado exitosamente");
                Limpiar();
                this.Close();
                }
            }
            
        }

        public void Limpiar()
        {
            tbxNombre.Text= ""; 
            tbxApellido.Text="";
            cbxSexo.Text="";
            cbxProvincia.Text="";
            tbxLocalidad.Text = "";
            tbxDireccion.Text = "";
            rtbxIndicaciones.Text = "";
            tbxCodigo_postal.Text = "";
            tbxTelefono.Text = "";
            tbxCorreo.Text = "";
            chxEstado.Checked = true;
        }

        private void tbxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        //public void Limpiar()
        //{
        //    tbxUsuario.Text = "";
        //    tbxContraseña.Text = "";
        //    cbxNivel.SelectedIndex = 0;
        //    chxEstado.Checked = false;
        //    tbxUsuario.Focus();
        //}
    }
}
