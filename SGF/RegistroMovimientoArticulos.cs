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
        public string articuloP, almacenP,idArticulo,total,idAlmacen,sinAsignar,Asignado;
        
        public RegistroMovimientoArticulos(string IdArticulo)
        {
            
            
            
            InitializeComponent();

            //string cmdArticulo = "Select * from articulo";

            //Almacen
            //string cmdAlmacen = "Select * from almacen";
            this.idArticulo = IdArticulo;
            //ds = Utilidades.EjecutarDS(cmdAlmacen);
            //cbxAlmacen.DisplayMember = "nombre_almacen";
            //cbxAlmacen.DataSource = ds.Tables[0].DefaultView;
        }


        public bool ComprobarCampos()
        {
            
            ErrorProvider.Clear();
            bool ok = true;
            if (tbxCodigoAlmacen.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxCodigoAlmacen, "Este campo no puede estar vasio.");
            }
            if (tbxCodigoArticulo.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxCodigoArticulo, "Este campo no puede estar vasio.");
            }
            if (rtbxIndicaciones.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(rtbxIndicaciones, "Este campo no puede estar vasio.");
            }


            return ok;
        }


        public override void Guardar()
        {

            if (ComprobarCampos())
            {
                cmd = "select * from articulo_vs_almacen where idArticulo='" + idArticulo + "'and idAlmacen='" + idAlmacen + "'";
                ds = Utilidades.EjecutarDS(cmd);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmd = "update articulo_vs_almacen set cantidad='" + tkbCantidad.Value.ToString() + "',indicaciones='" + rtbxIndicaciones.Text + "' where idArticulo='" + idArticulo + "' and idAlmacen='" + idAlmacen + "';";
                    ds = Utilidades.EjecutarDS(cmd);
                    MessageBox.Show("Se ha actualizado exitosamente.");
                    this.Close();
                }
                else
                {
                    cmd = "insert into articulo_vs_almacen(idAlmacen,idArticulo,cantidad,indicaciones)values('" + idAlmacen + "','" + idArticulo + "','" + tkbCantidad.Value.ToString() + "','" + rtbxIndicaciones.Text + "');";
                    ds = Utilidades.EjecutarDS(cmd);
                    MessageBox.Show("Se ha Guardado exitosamente.");
                    this.Close();
                }
            }






            //if (tbxCantidad.Text.Trim() == "" || rtbxIndicaciones.Text.Trim() == "")
            //{
            //    MessageBox.Show("Faltan campos por reyenar");

            //}
            //else if (!(ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0))
            //{
            //    int productos_en_almacenes, total, i;
            //    //cmd = "begin declare @idArticulo uniqueidentifier;select @idArticulo=ar.id from articulo_vs_almacen as ava,articulo as ar, almacen as al where ar.nombre_articulo='" + cbxArticulo.Text + "';select sum(cantidad)as suma from articulo_vs_almacen where idArticulo=@idArticulo;end";
            //    //ds = Utilidades.EjecutarDS(cmd);
            //    productos_en_almacenes = 0;
            //    cmd = "begin " +
            //        "declare @idArticulo uniqueidentifier;" +
            //        "select @idArticulo=ar.id from articulo_vs_almacen as ava,articulo as ar, almacen as al where ar.nombre_articulo='" + cbxArticulo.Text + "';" +
            //        "select existencia from articulo where id=@idArticulo;" +
            //    "end";
            //    ds = Utilidades.EjecutarDS(cmd);
            //    total = Convert.ToInt32(ds.Tables[0].Rows[0]["existencia"].ToString());
            //    i = Convert.ToInt32(tbxCantidad.Text.Trim());
            //if (productos_en_almacenes + i > total)
            //{
            //    MessageBox.Show("Cantidad de productos sin asignacion exedida, solo hay :" + (total - productos_en_almacenes));
            //}
            //else
            //{
            //    cmd = "begin " +
            //        "declare @idArticulo uniqueidentifier;" +
            //        "declare @idAlmacen uniqueidentifier;" +
            //        "select @idArticulo=ar.id from articulo_vs_almacen as ava,articulo as ar, almacen as al where ar.nombre_articulo='" + cbxArticulo.Text + "';" +
            //        "select @idAlmacen=al.id from articulo_vs_almacen as ava,articulo as ar, almacen as al where al.nombre_almacen='" + cbxAlmacen.Text + "';" +
            //        "insert into articulo_vs_almacen(idArticulo,idAlmacen,cantidad,indicaciones)values(@idArticulo,@idAlmacen,'" + tbxCantidad.Text.Trim() + "','" + rtbxIndicaciones.Text.Trim() + "');" +
            //        "end";
            //    ds = Utilidades.EjecutarDS(cmd);
            //    MessageBox.Show("Guardado exitosamente");
            //    ////Limpiar();
            //    this.Close();
            //}
            //}
            //else
            //{
            //DataSet dst = new DataSet();
            //int productos_en_almacenes, total, i;
            //cmd = "begin " +
            //        "declare @idArticulo uniqueidentifier;" +
            //        "select @idArticulo=ar.id from articulo_vs_almacen as ava,articulo as ar, almacen as al where ar.nombre_articulo='" + cbxArticulo.Text + "';" +
            //        "select sum(cantidad) as cantidad from articulo_vs_almacen where idArticulo=@idArticulo and idAlmacen!='"++"';" +
            //    "end";
            //dst = Utilidades.EjecutarDS(cmd);
            //productos_en_almacenes = Convert.ToInt32(dst.Tables[0].Rows[0]["cantidad"].ToString());
            //cmd = "begin declare @idArticulo uniqueidentifier;select @idArticulo=ar.id from articulo_vs_almacen as ava,articulo as ar, almacen as al where ar.nombre_articulo='" + cbxArticulo.Text + "';select existencia from articulo where id=@idArticulo;end";
            //dst = Utilidades.EjecutarDS(cmd);
            //total = Convert.ToInt32(dst.Tables[0].Rows[0]["existencia"].ToString());
            //i = Convert.ToInt32(tbxCantidad.Text.Trim());
            //if (productos_en_almacenes + i > total)
            //{
            //    MessageBox.Show("Cantidad de productos sin asignacion exedida, solo hay :" + (total - productos_en_almacenes));
            //}
            //else
            //{
            //    DialogResult result = MessageBox.Show("Seguro que quiere actualizar la existencia de: " + cbxArticulo.Text + " del almacen: " + cbxAlmacen.Text + " de " + ds.Tables[0].Rows[0]["cantidad"].ToString() + " a " + tbxCantidad.Text, "Atención", MessageBoxButtons.YesNo);
            //    if (result == DialogResult.Yes)
            //    {
            //        cmd = "begin " +
            //       "declare @idArticulo uniqueidentifier;" +
            //       "declare @idAlmacen uniqueidentifier;" +
            //       "select @idArticulo=ar.id from articulo_vs_almacen as ava,articulo as ar, almacen as al where ar.nombre_articulo='" + cbxArticulo.Text + "';" +
            //       "select @idAlmacen=al.id from articulo_vs_almacen as ava,articulo as ar, almacen as al where al.nombre_almacen='" + cbxAlmacen.Text + "';" +
            //       "update articulo_vs_almacen set cantidad='" + tbxCantidad.Text.Trim() + "',indicaciones='" + rtbxIndicaciones.Text.Trim() + "' where idAlmacen=@idAlmacen and idArticulo=@idArticulo;" +
            //       "end";
            //        //rtbxIndicaciones.Text = cmd;
            //        ds = Utilidades.EjecutarDS(cmd);
            //        MessageBox.Show("Actualizado exitosamente");
            //        //Limpiar();
            //        this.Close();
            //    }
            //    else
            //    {
            //        this.Close();
            //    }
            //}

            //}

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegistroMovimientoArticulos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MantenimientoAlmacenes rc = new MantenimientoAlmacenes();
            rc.btnSeleccionar.Enabled = true;
            rc.btnBorrar.Enabled = false;
            rc.btnModificar.Enabled = false;
            rc.btnNuevo.Enabled = false;
            rc.ShowDialog();
            
            tbxCodigoAlmacen.Text = rc.nombre_almacen;
            idAlmacen = rc.codigo_almacen;
            //MessageBox.Show(idAlmacen);
            if (idAlmacen != "")
            {
                cmd = "select * from articulo_vs_almacen where idArticulo='" + tbxCodigoArticulo.Text + "'and idAlmacen='" + idAlmacen + "'";
                //rtbxIndicaciones.Text = cmd;
                ds = Utilidades.EjecutarDS(cmd);
                //MessageBox.Show(ds.Tables[0].Rows[0]["cantidad"].ToString());
                if (ds.Tables[0].Rows.Count>0) 
                {
                    tkbCantidad.Maximum += Convert.ToInt32(ds.Tables[0].Rows[0]["cantidad"].ToString());
                    tkbCantidad.Value = Convert.ToInt32(ds.Tables[0].Rows[0]["cantidad"].ToString());
                    lbCantidad.Text = "(" + tkbCantidad.Value + ")";
                    rtbxIndicaciones.Text = ds.Tables[0].Rows[0]["indicaciones"].ToString();
                }
                
            }
            
        }

        private void tkbCantidad_Scroll(object sender, EventArgs e)
        {
            lbCantidad.Text = "(" + tkbCantidad.Value + ")";
        }

        private void cbxAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmd= "select id from almacen where nombre_almacen='"+cbxAlmacen.Text+"';";
            //ds = Utilidades.EjecutarDS(cmd);
            //cmd = "select sum(cantidad) as cantidad, indicaciones from articulo_vs_almacen where idArticulo='"+idArticulo+"'and idAlmacen='" + ds.Tables[0].Rows[0]["id"].ToString() + "'";
            //ds = Utilidades.EjecutarDS(cmd);
            //tkbCantidad.Value =Convert.ToInt32( ds.Tables[0].Rows[0]["cantidad"].ToString());
        }

        private void RegistroMovimientoArticulos_Shown(object sender, EventArgs e)
        {
            //MessageBox.Show("funcionando");
            //cbxArticulo.Text = this.articuloP;
            //cbxAlmacen.Text = this.almacenP;
        }
    }
}
