﻿using System;
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
        public bool nuevoEmpleado = false;
        public string idTelefono, idPersona, idCorreo, idVacante;
        public bool ComprobarCampos()
        {

            //tbxNombre.Text == "" ||
            //tbxApellido.Text == "" ||
            //tbxCedula.Text == "" ||
            //tbxCorreo.Text == "" ||
            //tbxTelefono.Text == ""
            ErrorProvider.Clear();
            bool ok = true;
            if (tbxNombre.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxNombre, "Este campo no puede estar vasio.");
            }
            if (tbxApellido.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxApellido, "Este campo no puede estar vasio.");
            }
            if (tbxCedula.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxCedula, "Este campo no puede estar vasio.");
            }
            if (tbxCorreo.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxCorreo, "Este campo no puede estar vasio.");
            }
            if (tbxTelefono.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxTelefono, "Este campo no puede estar vasio.");
            }
            return ok;
        }
        public override void Guardar()
        {
            //(ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            //cmd = "";
            //string cmdCliente = string.Format("select * from cliente where idTercero='{0}'",
            //    tbxCodigo.Text.Trim());
            //ds = Utilidades.EjecutarDS(cmdCliente);
            if (ComprobarCampos())
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
                            "update empleado set idPuesto=@idPuesto,idHorario=@idHorario,estado='1' where idTercero='" + tbxCodigo.Text.Trim() + "';" +
                            "update tercero set nombre='" + tbxNombre.Text.Trim() + "' where id='" + tbxCodigo.Text.Trim() + "';" +
                            "update persona set cedula='" + tbxCedula.Text.Trim() + "',apellido='" + tbxApellido.Text.Trim() + "', fecha_nacimiento='" + dtFecha.Value.Day + "/" + dtFecha.Value.Month + "/" + dtFecha.Value.Year + "',sexo='" + cbxSexo.Text.Trim() + "',estado='1' where idTercero='" + tbxCodigo.Text.Trim() + "';" +
                            "update correo set correo_electronico='" + tbxCorreo.Text.Trim() + "' where id=@idCorreo;" +
                            "update telefono set numero='" + tbxTelefono.Text.Trim() + "' where id=@idTelefono;" +
                        "end";
                    MessageBox.Show(cmd);
                    //rtbxIndicaciones.Text = cmd;
                    //Console.Out(cmd);
                    ds = Utilidades.EjecutarDS(cmd);
                    MessageBox.Show("Modificado exitosamente");
                    //Limpiar();
                    this.Close();


                }
                else
                {

                    if (nuevoEmpleado)
                    {
                        cmd = "begin " +
                                "declare @idPuesto uniqueidentifier;" +
                                "declare @idHorario uniqueidentifier;" +
                                "select @idPuesto=id from puesto where puesto='" + cbxPuesto.Text.Trim() + "';" +
                                "select @idHorario=id from horario where descripcion='" + cbxHorario.Text.Trim() + "';" +
                                "insert into empleado(idTercero,idPuesto,idHorario,fecha,estado)values('"+idPersona+"',@idPuesto,@idHorario,getdate(),'1');" +
                                "insert into vacaciones(idEmpleado,fecha_inicio,fecha_fin,estado)values('"+idPersona+"','24/12/" + DateTime.Now.Year + "','1/1/" + (DateTime.Now.Year + 1) + "','1');" +
                                "insert into pagos(idEmpleado,fecha_ultimo_pago,estado)values('"+idPersona+"',getdate(),'1');" +
                                "update vacante set estado='0' where numero_vacante='"+idVacante+"';" +
                            "end";
                        //rtbxIndicaciones.Text = cmd;
                        //MessageBox.Show(idPersona);
                        ds = Utilidades.EjecutarDS(cmd);
                        MessageBox.Show("Guardado exitosamente.");
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
                                "insert into persona(idTercero, apellido, fecha_nacimiento, sexo, estado,cedula)values(@idTercero, '" + tbxApellido.Text.Trim() + "','" + dtFecha.Value.Day + "/" + dtFecha.Value.Month + "/" + dtFecha.Value.Year + "', '" + cbxSexo.Text.Trim() + "','1','" + tbxCedula.Text.Trim() + "');" +
                                "insert into empleado(idTercero,idPuesto,idHorario,fecha,estado)values(@idTercero,@idPuesto,@idHorario,getdate(),'1');" +
                                "insert into telefono(id,numero) values(@idTelefono,'" + tbxTelefono.Text.Trim() + "');" +
                                "insert into telefono_vs_tercero(idTelefono,idTercero,estado)values(@idTelefono,@idTercero,'1');" +
                                "insert into correo(id,correo_electronico) values(@idCorreo,'" + tbxCorreo.Text.Trim() + "');" +
                                "insert into correo_vs_tercero(idCorreo,idTercero)values(@idCorreo,@idTercero);" +
                                "insert into vacaciones(idEmpleado,fecha_inicio,fecha_fin,estado)values(@idTercero,'24/12/" + DateTime.Now.Year + "','1/1/" + (DateTime.Now.Year + 1) + "','1');" +
                                "insert into pagos(idEmpleado,fecha_ultimo_pago,estado)values(@idTercero,getdate(),'1');" +
                                "update vacante set estado='0' where numero_vacante='" + idVacante + "';" +
                            "end";
                        //rtbxIndicaciones.Text = cmd;
                        //MessageBox.Show(cmd);
                        ds = Utilidades.EjecutarDS(cmd);
                        MessageBox.Show("Guardado exitosamente.");
                        //Limpiar();
                        this.Close();
                    }
                }
            }
        }

        private void RegistroEmpleados_Load(object sender, EventArgs e)
        {

        }
    }
}
