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
    public partial class RegistoInventario : FormRegistros
    {
        public RegistoInventario()
        {
            InitializeComponent();
            string cmdMarca = "Select * from marca";
            string cmdMedida = "Select * from medida";
            string cmdTipo = "Select * from tipo_articulo";

            //Marca
            ds = Utilidades.EjecutarDS(cmdMarca);
            cbxMarca.DisplayMember = "marca";
            cbxMarca.DataSource = ds.Tables[0].DefaultView;

            //Medida
            ds = Utilidades.EjecutarDS(cmdMedida);
            cbxMedida.DisplayMember = "medida";
            cbxMedida.DataSource = ds.Tables[0].DefaultView;

            //Tipo
            ds = Utilidades.EjecutarDS(cmdTipo);
            cbxTipo.DisplayMember = "categoria";
            cbxTipo.DataSource = ds.Tables[0].DefaultView;

        }
        public override void Guardar()
        {
            if (tbxNombre.Text.Trim()==""||
                tbxPrecio_compra.Text.Trim() ==""||
                tbxPrecio_venta.Text.Trim() == ""||
                tbxExistencia.Text.Trim() == ""||
                tbxDescripcion.Text.Trim() == ""||
                tbxCantidad_maxima.Text.Trim() == ""||
                tbxCantidad_minima.Text.Trim() == ""
                )
            {
                MessageBox.Show("Faltan campos por reyenar");
            }
            else
            {
                if (etCantidad.Visible == true && tbxCantidad_caja.Text.Trim() == "")
                {
                    MessageBox.Show("Faltan la cantidad de caja por reyenar");
                }
                else if (etCantidad.Visible == true && tbxCantidad_caja.Text.Trim() != "")
                {
                    if (tbxCodigo.Text != "Nuevo")
                    {
                        cmd = "begin" +
                            " declare @idMedida uniqueidentifier;" +
                            "declare @idTipo_articulo uniqueidentifier;" +
                            "declare @idMarca uniqueidentifier;" +
                            "select @idMedida = m.id from medida as m where m.medida = '" + cbxMedida.Text.Trim() + "';" +
                            "select @idMarca = m.id from marca as m where m.marca = '" + cbxMarca.Text.Trim() + "';" +
                            "select @idTipo_articulo = t.id from tipo_articulo as t where t.categoria = '" + cbxTipo.Text.Trim() + "';" +
                            "update articulo set nombre = '" + tbxNombre.Text.Trim() + "', precio_compra = '" + tbxPrecio_compra.Text.Trim() + "', precio_venta = '" + tbxPrecio_venta.Text.Trim() + "', existencia = '" + tbxExistencia.Text.Trim() + "', descripcion = '" + tbxDescripcion.Text.Trim() + "', cantidad_maxima = '" + tbxCantidad_maxima.Text.Trim() + "', cantidad_minima = '" + tbxCantidad_minima.Text.Trim() + "', fecha_renovacion = '" + dtFecha_renovacion.Value.Day + "/" + dtFecha_renovacion.Value.Month + "/" + dtFecha_renovacion.Value.Year + "', idMedida = @idMedida, idMarca = @idMarca, idTipo_articulo = @idTipo_articulo, estado = '" + chxEstado.Checked + "' where id = '" + tbxCodigo.Text.Trim() + "';" +
                            "update cantidad_caja set cantidad_caja='"+tbxCantidad_caja.Text.Trim()+"' where idArticulo='"+tbxCodigo.Text.Trim()+"';"+
                            "end";
                        //MessageBox.Show(cmd);
                        //rtbxIndicaciones.Text = cmd;
                        //Console.Out(cmd);
                        //ds = Utilidades.EjecutarDS(cmd);
                        MessageBox.Show("Modificado exitosamente");
                        //Limpiar();
                        this.Close();


                    }
                    else
                    {
                        cmd = " begin" +
                            " declare @idMedida uniqueidentifier;" +
                            "declare @idTipo_articulo uniqueidentifier;" +
                            "declare @idMarca uniqueidentifier;" +
                            "declare @idArticulo uniqueidentifier = newid();" +
                            "select @idMedida = m.id from medida as m where m.medida = '" + cbxMedida.Text.Trim() + "';" +
                            "select @idMarca = m.id from marca as m where m.marca = '" + cbxMarca.Text.Trim() + "';" +
                            "select @idTipo_articulo = t.id from tipo_articulo as t where t.categoria = '" + cbxTipo.Text.Trim() + "';" +
                            "insert into articulo(id, nombre, precio_compra, precio_venta, existencia, descripcion, cantidad_maxima, cantidad_minima, fecha_renovacion, idMedida, idMarca, idTipo_articulo, estado)" +
                            "values(@idArticulo, '" + tbxNombre.Text.Trim() + "', '" + tbxPrecio_compra.Text.Trim() + "', '" + tbxPrecio_venta.Text.Trim() + "', '" + tbxExistencia.Text.Trim() + "', '" + tbxDescripcion.Text.Trim() + "', '" + tbxCantidad_maxima.Text.Trim() + "', '" + tbxCantidad_minima.Text.Trim() + "', '" + dtFecha_renovacion.Value.Day + "/" + dtFecha_renovacion.Value.Month + "/" + dtFecha_renovacion.Value.Year + "', @idMedida, @idMarca, @idTipo_articulo, '" + chxEstado.Checked + "');" +
                            "insert into cantidad_caja(idArticulo,cantidad_caja)values(@idArticulo,'"+tbxCantidad_caja.Text.Trim()+"');"+
                            "end";
                        //cmd = String.Format("exec crearCliente '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}'",
                        //   tbxNombre.Text.Trim(), tbxApellido.Text.Trim(), dtFecha.Value.Day + "/" + dtFecha.Value.Month + "/" + dtFecha.Value.Year,
                        //   cbxSexo.Text.Trim(), cbxProvincia.Text.Trim(), tbxLocalidad.Text.Trim(), tbxDireccion.Text.Trim(), rtbxIndicaciones.Text.Trim(),
                        //   tbxCodigo_postal.Text.Trim(), chxEstado.Checked, tbxCorreo.Text.Trim(), tbxTelefono.Text.Trim());
                        ////rtbxIndicaciones.Text = cmd;
                        //MessageBox.Show(cmd);
                        //tbxCantidad_minima.Text = cmd;
                        ds = Utilidades.EjecutarDS(cmd);
                        MessageBox.Show("Guardado exitosamente");
                        ////Limpiar();
                        this.Close();
                    }
                }
                else
                {
                    if (tbxCodigo.Text != "Nuevo")
                    {
                        cmd = "begin" +
                            " declare @idMedida uniqueidentifier;" +
                            "declare @idTipo_articulo uniqueidentifier;" +
                            "declare @idMarca uniqueidentifier;" +
                            "select @idMedida = m.id from medida as m where m.medida = '" + cbxMedida.Text.Trim() + "';" +
                            "select @idMarca = m.id from marca as m where m.marca = '" + cbxMarca.Text.Trim() + "';" +
                            "select @idTipo_articulo = t.id from tipo_articulo as t where t.categoria = '" + cbxTipo.Text.Trim() + "';" +
                            "update articulo set nombre = '" + tbxNombre.Text.Trim() + "', precio_compra = '" + tbxPrecio_compra.Text.Trim() + "', precio_venta = '" + tbxPrecio_venta.Text.Trim() + "', existencia = '" + tbxExistencia.Text.Trim() + "', descripcion = '" + tbxDescripcion.Text.Trim() + "', cantidad_maxima = '" + tbxCantidad_maxima.Text.Trim() + "', cantidad_minima = '" + tbxCantidad_minima.Text.Trim() + "', fecha_renovacion = '" + dtFecha_renovacion.Value.Day + "/" + dtFecha_renovacion.Value.Month + "/" + dtFecha_renovacion.Value.Year + "', idMedida = @idMedida, idMarca = @idMarca, idTipo_articulo = @idTipo_articulo, estado = '" + chxEstado.Checked + "' where id = '" + tbxCodigo.Text.Trim() + "';" +
                            "delete from cantidad_caja where idArticulo='"+tbxCodigo.Text.Trim()+"'" +
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
                        cmd = " begin" +
                            " declare @idMedida uniqueidentifier;" +
                            "declare @idTipo_articulo uniqueidentifier;" +
                            "declare @idMarca uniqueidentifier;" +
                            "select @idMedida = m.id from medida as m where m.medida = '" + cbxMedida.Text.Trim() + "';" +
                            "select @idMarca = m.id from marca as m where m.marca = '" + cbxMarca.Text.Trim() + "';" +
                            "select @idTipo_articulo = t.id from tipo_articulo as t where t.categoria = '" + cbxTipo.Text.Trim() + "';" +
                            "insert into articulo(id, nombre, precio_compra, precio_venta, existencia, descripcion, cantidad_maxima, cantidad_minima, fecha_renovacion, idMedida, idMarca, idTipo_articulo, estado)" +
                            "values(newid(), '" + tbxNombre.Text.Trim() + "', '" + tbxPrecio_compra.Text.Trim() + "', '" + tbxPrecio_venta.Text.Trim() + "', '" + tbxExistencia.Text.Trim() + "', '" + tbxDescripcion.Text.Trim() + "', '" + tbxCantidad_maxima.Text.Trim() + "', '" + tbxCantidad_minima.Text.Trim() + "', '" + dtFecha_renovacion.Value.Day + "/" + dtFecha_renovacion.Value.Month + "/" + dtFecha_renovacion.Value.Year + "', @idMedida, @idMarca, @idTipo_articulo, '" + chxEstado.Checked + "');" +
                            "end";
                        //cmd = String.Format("exec crearCliente '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}'",
                        //   tbxNombre.Text.Trim(), tbxApellido.Text.Trim(), dtFecha.Value.Day + "/" + dtFecha.Value.Month + "/" + dtFecha.Value.Year,
                        //   cbxSexo.Text.Trim(), cbxProvincia.Text.Trim(), tbxLocalidad.Text.Trim(), tbxDireccion.Text.Trim(), rtbxIndicaciones.Text.Trim(),
                        //   tbxCodigo_postal.Text.Trim(), chxEstado.Checked, tbxCorreo.Text.Trim(), tbxTelefono.Text.Trim());
                        ////rtbxIndicaciones.Text = cmd;
                        //MessageBox.Show(cmd);
                        //tbxCantidad_minima.Text = cmd;
                        ds = Utilidades.EjecutarDS(cmd);
                        MessageBox.Show("Guardado exitosamente");
                        ////Limpiar();
                        this.Close();
                    }
                }
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ////(ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            ////cmd = "";
            ////string cmdCliente = string.Format("select * from cliente where idTercero='{0}'",
            ////    tbxCodigo.Text.Trim());
            ////ds = Utilidades.EjecutarDS(cmdCliente);
            //if (tbxNombre.Text == "" || tbxApellido.Text == "" || tbxCodigo_postal.Text == "" || tbxDireccion.Text == "" || tbxLocalidad.Text == "" || tbxCodigo.Text == "" || tbxTelefono.Text == "" || rtbxIndicaciones.Text == "")
            //{
            //    MessageBox.Show("Faltan campos por reyenar");
            //}
            //else
            //{
            //if (tbxCodigo.Text != "Nuevo")
            //{
            //    cmd = " begin" +
            //        " declare @idMedida uniqueidentifier;" +
            //        "declare @idTipo_articulo uniqueidentifier;" +
            //        "declare @idMarca uniqueidentifier;" +
            //        "select @idMedida = m.id from medida as m where m.descripcion = '"++"';" +
            //        "select @idMarca = m.id from marca as m where m.nombre = '"++"';" +
            //        "select @idTipo_articulo = t.id from tipo_articulo as t where t.categoria = '"++"';" +
            //        "insert into articulo(id, nombre, precio_compra, precio_venta, existencia, descripcion, cantidad_maxima, cantidad_minima, fecha_renovacion, idMedida, idTipo_articulo, idMarca, estado)" +
            //        "values(newid(), '"++"', '"++"', '"++"', '"++"', '"++"', '"++"', '"++"', '"++"', '"++"', '"++"', '"++"', '"++"', @idMedida, @idMarca, @idTipo_articulo, '"++"');" +
            //        "end";
            //    //MessageBox.Show(cmd);
            //    //rtbxIndicaciones.Text = cmd;
            //    //Console.Out(cmd);
            //    ds = Utilidades.EjecutarDS(cmd);
            //    MessageBox.Show("Modificado exitosamente");
            //    //Limpiar();
            //    this.Close();


            //}
            //else
            //{
            //    cmd = String.Format("exec crearCliente '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}'",
            //       tbxNombre.Text.Trim(), tbxApellido.Text.Trim(), dtFecha.Value.Day + "/" + dtFecha.Value.Month + "/" + dtFecha.Value.Year,
            //       cbxSexo.Text.Trim(), cbxProvincia.Text.Trim(), tbxLocalidad.Text.Trim(), tbxDireccion.Text.Trim(), rtbxIndicaciones.Text.Trim(),
            //       tbxCodigo_postal.Text.Trim(), chxEstado.Checked, tbxCorreo.Text.Trim(), tbxTelefono.Text.Trim());
            //    //rtbxIndicaciones.Text = cmd;
            //    //MessageBox.Show(cmd);
            //    ds = Utilidades.EjecutarDS(cmd);
            //    MessageBox.Show("Guardado exitosamente");
            //    Limpiar();
            //    this.Close();
            //}
            //}
        }

        private void cbxMedida_Leave(object sender, EventArgs e)
        {
            
        }

        private void cbxMedida_Validated(object sender, EventArgs e)
        {
            
        }

        private void cbxMedida_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void cbxMedida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMedida.Text == "Caja")
            {
                tbxCantidad_caja.Visible = true;
                etCantidad.Visible = true;
            }
            else
            {
                tbxCantidad_caja.Visible = false;
                etCantidad.Visible = false;
            }
        }
    }
}
