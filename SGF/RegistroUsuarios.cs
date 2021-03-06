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
    public partial class RegistroUsuarios : FormRegistros
    {
        public string usuarioViejo="";
        public RegistroUsuarios()
        {
            InitializeComponent();
            cbxNivel.SelectedIndex = 0;
        }
        public bool ComprobarCampos()
        {
            ErrorProvider.Clear();
            bool ok = true;
            if (tbxUsuario.Text=="")
            {
                ok = false;
                
                ErrorProvider.SetError(tbxUsuario, "Este campo no puede estar vasio.");
            }
            if (tbxContraseña.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxContraseña, "Este campo no puede estar vasio.");
            }
            if (tbxEmpleado.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxEmpleado, "Este campo no puede estar vasio.");
            }
            return ok;
        }
        public override void Guardar()
        {
            DataSet ds = new DataSet();

            if (ComprobarCampos())
            {
                double limiteDescuento = tkbDescuento.Value;
                limiteDescuento /= 100;


                if (tbxCodigo.Text.Trim() == "Nuevo")
                {
                    string cmdUsuario = string.Format("select * from usuario where usuario='{0}'",
                    tbxUsuario.Text.Trim());
                    ds = Utilidades.EjecutarDS(cmdUsuario);
                    if (!(ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0))
                    {
                        string cmd = "insert into usuario(" +
                            "id," +
                            "usuario," +
                            "password," +
                            "modificar_articulos," +                    //1
                            "recursos_humanos," +                       //2
                            "modificar_clientes," +                     //3
                            "modificar_suplidores," +                   //4
                            "modificar_usuarios," +                     //5
                            "ingresar_compras," +                       //6
                            "ingresar_ventas," +                        //7
                            "despacho_transporte," +                    //8
                            "consulta_ventas," +                        //9
                            "consultar_reportes," +                     //10
                            "realizar_pagos," +                         //11
                            "actualizar_caja," +                        //12
                            "realizar_permisos," +                      //13
                            "limite_descuento," +
                            "estado," +
                            "idEmpleado)" +
                            "values(newid(),'" + tbxUsuario.Text.Trim() 
                            + "','" + tbxContraseña.Text.Trim()         
                            + "','" + chxModificarArticulos.Checked     //1
                            + "','" + chxRecursosHumanos.Checked        //2
                            + "','" + chxModificarClientes.Checked      //3
                            + "','" + chxModificarSuplidores.Checked    //4
                            + "','" + chxModificarUsuarios.Checked      //5
                            + "','" + chxIngresarCompras.Checked        //6
                            + "','" + chxIngresarVentas.Checked         //7
                            + "','" + chxDespachoTransporte.Checked     //8
                            + "','" + chxConsultaVentas.Checked         //9
                            + "','" + chxConsultaReportes.Checked       //10
                            + "','" + chxRealizarPagos.Checked          //11
                            + "','" + chxActualizarCaja.Checked         //12
                            + "','" + chxRealizarPermisos.Checked       //13
                            + "','" + limiteDescuento.ToString().Replace(",", ".")
                            + "','1','" + tbxEmpleado.Text
                            + "');";
                        //MessageBox.Show(cmd);
                        ds = Utilidades.EjecutarDS(cmd);
                        //tbxLimiteDescuento.Text = cmd;
                        //Limpiar();
                        this.Close();


                    }
                    else
                    {
                        MessageBox.Show("El nombre de usuario " + tbxUsuario.Text + " ya esta en uso.");
                        //Limpiar();
                    }
                }
                else
                {
                    string cmdUsuario = string.Format("select * from usuario where usuario='{0}'",
                    tbxUsuario.Text.Trim());
                    ds = Utilidades.EjecutarDS(cmdUsuario);
                    if (!(ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0) || tbxUsuario.Text.Trim() == usuarioViejo)
                    {
                        string cmd = "update usuario " +
                        "set usuario='" + tbxUsuario.Text.Trim() + "', password='" + tbxContraseña.Text.Trim() + "'," +
                        "modificar_articulos='" + chxModificarArticulos.Checked + "'," +
                        "recursos_humanos='" + chxRecursosHumanos.Checked + "'," +
                        "modificar_clientes='" + chxModificarClientes.Checked + "'," +
                        "modificar_suplidores='" + chxModificarSuplidores.Checked + "'," +
                        "modificar_usuarios='" + chxModificarUsuarios.Checked + "'," +
                        "ingresar_compras='" + chxIngresarCompras.Checked + "'," +
                        "ingresar_ventas='" + chxIngresarVentas.Checked + "'," +
                        "despacho_transporte='" + chxDespachoTransporte.Checked + "'," +
                        "consulta_ventas='" + chxConsultaVentas.Checked + "'," +
                        "consultar_reportes='" + chxConsultaReportes.Checked + "'," +
                        "realizar_pagos='" + chxRealizarPagos.Checked + "'," +
                        "actualizar_caja='" + chxActualizarCaja.Checked + "'," +
                        "limite_descuento='" + limiteDescuento.ToString().Replace(",", ".") + "'," +
                        "realizar_permisos='" + chxRealizarPermisos.Checked + "'," +
                        "estado='1' " +
                        "where id='" + tbxCodigo.Text.Trim() + "';";
                        MessageBox.Show(cmd);
                        ds = Utilidades.EjecutarDS(cmd);
                        //Limpiar();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El nombre de usuario " + tbxUsuario.Text + " ya esta en uso.");
                        //Limpiar();
                    }
                }
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            //DataSet ds = new DataSet();


            //string cmdUsuario = string.Format("select * from usuario where usuario='{0}'",
            //    tbxUsuario.Text.Trim()) ;
            //ds = Utilidades.EjecutarDS(cmdUsuario);
            //if (!(ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0))
            //{
            //    string cmd = "insert into usuario(id,usuario,password,modificar_articulos,ajuste_stock,modificar_clientes,modificar_suplidores,modificar_vendedores,ingresar_compras,ingresar_ventas,despacho_transporte,consulta_ventas,consultar_reportes,reimprimir_facturas,actualizar_caja,limite_descuento,estado)" +
            //        "values(newid(),'"+tbxUsuario.Text.Trim()+"','"+tbxContraseña.Text.Trim()+"','"+chxModificarArticulos.Checked+"','"+chxAjusteStock.Checked+"','"+chxModificarClientes.Checked+"','"+chxModificarSuplidores.Checked+"','"+chxModificarVendedores.Checked+"','"+chxIngresarCompras+"','"+chxIngresarVentas.Checked+"','"+chxDespachoTransporte.Checked+"','"+chxConsultaVentas.Checked+"','"+chxConsultaReportes.Checked+"','"+chxReimprimirFacturas.Checked+"','"+chxActualizarCaja.Checked+"','"+tbxLimiteDescuento+"','"+chxEstado.Checked+"');";
            //    //MessageBox.Show(cmd);
            //    ds = Utilidades.EjecutarDS(cmd);
            //    Limpiar();

                
            //}
            //else
            //{
            //    MessageBox.Show("El nombre de usuario "+tbxUsuario.Text +" ya esta en uso.");
            //    Limpiar();
            //}
            

        }
        public void Limpiar()
        {
            tbxUsuario.Text = "";
            tbxContraseña.Text = "";
            //tbxLimiteDescuento.Text = "";
            cbxNivel.SelectedIndex = 0;
            //chxEstado.Checked = false;
            tbxUsuario.Focus();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbxNivel.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MantenimientoEmpleados rc = new MantenimientoEmpleados();
            rc.btnBorrar.Enabled = false;
            rc.btnModificar.Enabled = false;
            rc.btnNuevo.Enabled = false;
            rc.btnSeleccionar.Enabled = true;
            rc.ShowDialog();
            this.tbxEmpleado.Text = rc.codigo_empleado;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lbDescuento.Text = "(" + tkbDescuento.Value + "%)";
        }
    }
    
}
