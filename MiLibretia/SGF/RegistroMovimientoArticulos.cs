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
    public partial class RegistroMovimientoArticulos : FormRegistros
    {
        public string articuloP, almacenP;
        public RegistroMovimientoArticulos(string articulo,string almacen)
        {
            InitializeComponent();
            string cmdAlmacen = "Select * from almacen";
            string cmdArticulo = "Select * from articulo";

            //Almacen
            ds = Utilidades.EjecutarDS(cmdAlmacen);
            cbxAlmacen.DisplayMember = "nombre_almacen";
            cbxAlmacen.DataSource = ds.Tables[0].DefaultView;

            //Articulo
            ds = Utilidades.EjecutarDS(cmdArticulo);
            cbxArticulo.DisplayMember = "nombre_articulo";
            cbxArticulo.DataSource = ds.Tables[0].DefaultView;
            //MessageBox.Show(articulo+" "+almacen);
            this.articuloP = articulo;
            this.almacenP = almacen;
            



        }
        public override void Guardar()
        {
            
                cmd = "begin " +
                    "declare @idArticulo uniqueidentifier;" +
                    "declare @idAlmacen uniqueidentifier;" +
                    "select @idArticulo=ar.id from articulo_vs_almacen as ava,articulo as ar, almacen as al where ar.nombre_articulo='" + cbxArticulo.Text + "';" +
                    "select @idAlmacen=al.id from articulo_vs_almacen as ava,articulo as ar, almacen as al where al.nombre_almacen='" + cbxAlmacen.Text + "';" +
                    "select * from articulo_vs_almacen where idArticulo=@idArticulo and idAlmacen=@idAlmacen;" +
                    "end";
                ds = Utilidades.EjecutarDS(cmd);
                if (tbxCantidad.Text.Trim() == "" || rtbxIndicaciones.Text.Trim() == "")
                {
                    MessageBox.Show("Faltan campos por reyenar");

                }
                else if (!(ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0))
                {
                int productos_en_almacenes, total, i;
                //cmd = "begin declare @idArticulo uniqueidentifier;select @idArticulo=ar.id from articulo_vs_almacen as ava,articulo as ar, almacen as al where ar.nombre_articulo='" + cbxArticulo.Text + "';select sum(cantidad)as suma from articulo_vs_almacen where idArticulo=@idArticulo;end";
                //ds = Utilidades.EjecutarDS(cmd);
                productos_en_almacenes = 0;
                cmd = "begin declare @idArticulo uniqueidentifier;select @idArticulo=ar.id from articulo_vs_almacen as ava,articulo as ar, almacen as al where ar.nombre_articulo='" + cbxArticulo.Text + "';select existencia from articulo where id=@idArticulo;end";
                ds = Utilidades.EjecutarDS(cmd);
                total = Convert.ToInt32(ds.Tables[0].Rows[0]["existencia"].ToString());
                i = Convert.ToInt32(tbxCantidad.Text.Trim());
                if (productos_en_almacenes + i > total)
                {
                    MessageBox.Show("Cantidad de productos sin asignacion exedida, solo hay :" + (total - productos_en_almacenes));
                }
                else
                {
                    cmd = "begin " +
                        "declare @idArticulo uniqueidentifier;" +
                        "declare @idAlmacen uniqueidentifier;" +
                        "select @idArticulo=ar.id from articulo_vs_almacen as ava,articulo as ar, almacen as al where ar.nombre_articulo='" + cbxArticulo.Text + "';" +
                        "select @idAlmacen=al.id from articulo_vs_almacen as ava,articulo as ar, almacen as al where al.nombre_almacen='" + cbxAlmacen.Text + "';" +
                        "insert into articulo_vs_almacen(idArticulo,idAlmacen,cantidad,indicaciones)values(@idArticulo,@idAlmacen,'" + tbxCantidad.Text.Trim() + "','" + rtbxIndicaciones.Text.Trim() + "');" +
                        "end";
                    ds = Utilidades.EjecutarDS(cmd);
                    MessageBox.Show("Guardado exitosamente");
                    ////Limpiar();
                    this.Close();
                }
                }
                else
                {
                DataSet dst = new DataSet();
                int productos_en_almacenes, total, i;
                cmd = "begin declare @idArticulo uniqueidentifier;select @idArticulo=ar.id from articulo_vs_almacen as ava,articulo as ar, almacen as al where ar.nombre_articulo='" + cbxArticulo.Text + "';select sum(cantidad) as cantidad from articulo_vs_almacen where idArticulo=@idArticulo;end";
                dst = Utilidades.EjecutarDS(cmd);
                productos_en_almacenes = Convert.ToInt32(dst.Tables[0].Rows[0]["cantidad"].ToString());
                cmd = "begin declare @idArticulo uniqueidentifier;select @idArticulo=ar.id from articulo_vs_almacen as ava,articulo as ar, almacen as al where ar.nombre_articulo='" + cbxArticulo.Text + "';select existencia from articulo where id=@idArticulo;end";
                dst = Utilidades.EjecutarDS(cmd);
                total = Convert.ToInt32(dst.Tables[0].Rows[0]["existencia"].ToString());
                i = Convert.ToInt32(tbxCantidad.Text.Trim());
                if (productos_en_almacenes + i > total)
                {
                    MessageBox.Show("Cantidad de productos sin asignacion exedida, solo hay :" + (total - productos_en_almacenes));
                }
                else
                {
                    DialogResult result = MessageBox.Show("Seguro que quiere actualizar la existencia de: " + cbxArticulo.Text + " del almacen: " + cbxAlmacen.Text + " de " + ds.Tables[0].Rows[0]["cantidad"].ToString() + " a " + tbxCantidad.Text, "Atención", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        cmd = "begin " +
                       "declare @idArticulo uniqueidentifier;" +
                       "declare @idAlmacen uniqueidentifier;" +
                       "select @idArticulo=ar.id from articulo_vs_almacen as ava,articulo as ar, almacen as al where ar.nombre_articulo='" + cbxArticulo.Text + "';" +
                       "select @idAlmacen=al.id from articulo_vs_almacen as ava,articulo as ar, almacen as al where al.nombre_almacen='" + cbxAlmacen.Text + "';" +
                       "update articulo_vs_almacen set cantidad='" + tbxCantidad.Text.Trim() + "',indicaciones='" + rtbxIndicaciones.Text.Trim() + "' where idAlmacen=@idAlmacen and idArticulo=@idArticulo;" +
                       "end";
                        //rtbxIndicaciones.Text = cmd;
                        ds = Utilidades.EjecutarDS(cmd);
                        MessageBox.Show("Actualizado exitosamente");
                        //Limpiar();
                        this.Close();
                    }
                    else
                    {
                        this.Close();
                    }
                }

                }
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegistroMovimientoArticulos_Load(object sender, EventArgs e)
        {

        }

        private void RegistroMovimientoArticulos_Shown(object sender, EventArgs e)
        {
            //MessageBox.Show("funcionando");
            cbxArticulo.Text = this.articuloP;
            cbxAlmacen.Text = this.almacenP;
        }
    }
}
