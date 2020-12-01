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
    public partial class RegistroEmpleados : FormRegistros
    {
        public RegistroEmpleados()
        {
            InitializeComponent();
            string cmdPuesto = "Select * from puesto";
            string cmdHorario = "Select * from horario";

            //Horario
            ds = Utilidades.EjecutarDS(cmdHorario);
            cbxHorario.DisplayMember = "descripcion";
            cbxHorario.DataSource = ds.Tables[0].DefaultView;

            //Puesto
            ds = Utilidades.EjecutarDS(cmdPuesto);
            cbxPuesto.DisplayMember = "puesto";
            cbxPuesto.DataSource = ds.Tables[0].DefaultView;

            cbxSexo.SelectedIndex = 0;
        }
        public override void Guardar()
        {
            //(ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            //cmd = "";
            //string cmdCliente = string.Format("select * from cliente where idTercero='{0}'",
            //    tbxCodigo.Text.Trim());
            //ds = Utilidades.EjecutarDS(cmdCliente);
            if (tbxNombre.Text == "" || tbxApellido.Text == "" || tbxCedula.Text == "" || tbxCorreo.Text == "" || tbxTelefono.Text == "" )
            {
                MessageBox.Show("Faltan campos por reyenar");
            }
            else
            {
                if (tbxCodigo.Text != "Nuevo")
                {
                    cmd = "begin " +
                            "declare @idPuesto uniqueidentifier;" +
                            "declare @idHorario uniqueidentifier;" +
                            "declare @idCorreo uniqueidentifier;" +
                            "declare @idTelefono uniqueidentifier;" +
                            "select @idCorreo=idCorreo from correo_vs_tercero where idTercero='" + tbxCodigo.Text.Trim() + "';" +
                            "select @idTelefono=idTelefono from telefono_vs_tercero where idTercero='" + tbxCodigo.Text.Trim() + "';" +
                            "select @idPuesto=id from puesto where puesto='" + cbxPuesto.Text.Trim() + "';" +
                            "select @idHorario=id from horario where descripcion='" + cbxHorario.Text.Trim() + "';" +
                            "update empleado set idPuesto=@idPuesto,idHorario=@idHorario,estado='" + chxEstado.Checked + "' where idTercero='" + tbxCodigo.Text.Trim() + "';" +
                            "update tercero set nombre='" + tbxNombre.Text.Trim() + "' where id='" + tbxCodigo.Text.Trim() + "';" +
                            "update persona set cedula='" + tbxCedula.Text.Trim() + "',apellido='" + tbxApellido.Text.Trim() + "', fecha_nacimiento='" + dtFecha.Value.Day + "/" + dtFecha.Value.Month + "/" + dtFecha.Value.Year + "',sexo='" + cbxSexo.Text.Trim() + "',estado='" + chxEstado.Checked + "' where idTercero='" + tbxCodigo.Text.Trim() + "';" +
                            "update correo set correo_electronico='" + tbxCorreo.Text.Trim() + "' where id=@idCorreo;" +
                            "update telefono set numero='" + tbxTelefono.Text.Trim() + "' where id=@idTelefono;" +
                        "end";
                    //MessageBox.Show(cmd);
                    //rtbxIndicaciones.Text = cmd;
                    //Console.Out(cmd);
                    ds = Utilidades.EjecutarDS(cmd);
                    MessageBox.Show("Modificado exitosamente");
                    //Limpiar();
                    this.Close();


                }
                else
                {
                    

                    cmd = "begin " +
                            "declare @idTelefono uniqueidentifier= newid();" +
                            "declare @idCorreo uniqueidentifier= newid();" +
                            "declare @idTercero uniqueidentifier=newid();" +
                            "declare @idPuesto uniqueidentifier;" +
                            "declare @idHorario uniqueidentifier;" +
                            "select @idPuesto=id from puesto where puesto='" + cbxPuesto.Text.Trim() + "';" +
                            "select @idHorario=id from horario where descripcion='" + cbxHorario.Text.Trim() + "';" +
                            "insert into tercero (id, nombre, fecha_in,estado) values(@idTercero, '" + tbxNombre.Text.Trim() + "',GETDATE(),'1');" +
                            "insert into persona(idTercero, apellido, fecha_nacimiento, sexo, estado,cedula)values(@idTercero, '" + tbxApellido.Text.Trim() + "','" + dtFecha.Value.Day + "/" + dtFecha.Value.Month + "/" + dtFecha.Value.Year + "', '" + cbxSexo.Text.Trim() + "','1','"+tbxCedula.Text.Trim()+"');" +
                            "insert into empleado(idTercero,idPuesto,idHorario,fecha,estado)values(@idTercero,@idPuesto,@idHorario,getdate(),'" + chxEstado.Checked + "');" +
                            "insert into telefono(id,numero) values(@idTelefono,'" + tbxTelefono.Text.Trim() + "');" +
                            "insert into telefono_vs_tercero(idTelefono,idTercero,estado)values(@idTelefono,@idTercero,'1');" +
                            "insert into correo(id,correo_electronico) values(@idCorreo,'" + tbxCorreo.Text.Trim() + "');" +
                            "insert into correo_vs_tercero(idCorreo,idTercero)values(@idCorreo,@idTercero);" +
                        "end";
                    //rtbxIndicaciones.Text = cmd;
                    //MessageBox.Show(cmd);
                    ds = Utilidades.EjecutarDS(cmd);
                    MessageBox.Show("Guardado exitosamente");
                    //Limpiar();
                    this.Close();
                }
            }
        }

        private void RegistroEmpleados_Load(object sender, EventArgs e)
        {

        }
    }
}
