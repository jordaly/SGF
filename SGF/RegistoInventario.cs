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
        public string idMarca = "";
        public RegistoInventario()
        {
            InitializeComponent();
            //string cmdMarca = "Select * from marca";
            string cmdMedida = "Select * from medida";
            string cmdTipo = "Select * from tipo_articulo";

            //Marca
            //ds = Utilidades.EjecutarDS(cmdMarca);
            //cbxMarca.DisplayMember = "marca";
            //cbxMarca.DataSource = ds.Tables[0].DefaultView;

            //Medida
            ds = Utilidades.EjecutarDS(cmdMedida);
            cbxMedida.DisplayMember = "medida";
            cbxMedida.DataSource = ds.Tables[0].DefaultView;

            //Tipo
            ds = Utilidades.EjecutarDS(cmdTipo);
            cbxTipo.DisplayMember = "categoria";
            cbxTipo.DataSource = ds.Tables[0].DefaultView;

        }
        public bool ComprobarCampos()
        {
            
            ErrorProvider.Clear();
            bool ok = true;

            if (tbxMarca.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxMarca, "Este campo no puede estar vasio.");
            }
            if (tbxPrecio_compra.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxPrecio_compra, "Este campo no puede estar vasio.");
            }
            if (tbxPrecio_venta.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxExistencia, "Este campo no puede estar vasio.");
            }
            if (tbxDescripcion.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxDescripcion, "Este campo no puede estar vasio.");
            }
            if (tbxCantidad_maxima.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxCantidad_maxima, "Este campo no puede estar vasio.");
            }
            if (tbxCantidad_minima.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxCantidad_minima, "Este campo no puede estar vasio.");
            }
            return ok;
        }
        public override void Guardar()
        {
            if (ComprobarCampos())
            {
                double itebis = tkbItebis.Value;
                itebis /= 100;
                
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
                            "select @idMedida = m.id from medida as m where m.medida = '" + cbxMedida.Text.Trim() + "';" +
                            "select @idTipo_articulo = t.id from tipo_articulo as t where t.categoria = '" + cbxTipo.Text.Trim() + "';" +
                            "update articulo set nombre_articulo = '" + tbxNombre.Text.Trim()
                            + "', precio_compra = '" + tbxPrecio_compra.Text.Trim()
                            + "', precio_venta = '" + tbxPrecio_venta.Text.Trim()
                            + "', existencia = '" + tbxExistencia.Text.Trim()
                            + "', descripcion = '" + tbxDescripcion.Text.Trim()
                            + "', cantidad_maxima = '" + tbxCantidad_maxima.Text.Trim()
                            + "', cantidad_minima = '" + tbxCantidad_minima.Text.Trim()
                            + "', fecha_renovacion = '" + dtFecha_renovacion.Value.Day + "/" + dtFecha_renovacion.Value.Month + "/" + dtFecha_renovacion.Value.Year
                            + "', idMedida = @idMedida, idMarca = '"+idMarca
                            +"', idTipo_articulo = @idTipo_articulo, estado = '1',ITEBIs='"+ itebis.ToString().Replace(",", ".") 
                            + "' where id = '" + tbxCodigo.Text.Trim() + "';" +
                            "update cantidad_caja set cantidad_caja='"+tbxCantidad_caja.Text.Trim()
                            +"' where idArticulo='"+tbxCodigo.Text.Trim()+"';"+
                            "end";

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
                            "declare @idArticulo uniqueidentifier = newid();" +
                            "select @idMedida = m.id from medida as m where m.medida = '" + cbxMedida.Text.Trim() + "';" +
                            "select @idTipo_articulo = t.id from tipo_articulo as t where t.categoria = '" + cbxTipo.Text.Trim() + "';" +
                            "insert into articulo(id, nombre_articulo, precio_compra, precio_venta, existencia, descripcion, cantidad_maxima, cantidad_minima, fecha_renovacion, idMedida, idMarca, idTipo_articulo,ITEBIs, estado)" +
                            "values(@idArticulo, '" + tbxNombre.Text.Trim() 
                            + "', '" + tbxPrecio_compra.Text.Trim() 
                            + "', '" + tbxPrecio_venta.Text.Trim() 
                            + "', '" + tbxExistencia.Text.Trim() 
                            + "', '" + tbxDescripcion.Text.Trim() 
                            + "', '" + tbxCantidad_maxima.Text.Trim() 
                            + "', '" + tbxCantidad_minima.Text.Trim() 
                            + "', '" + dtFecha_renovacion.Value.Day + "/" + dtFecha_renovacion.Value.Month + "/" + dtFecha_renovacion.Value.Year 
                            + "', @idMedida, '"+idMarca
                            +"', @idTipo_articulo,"+ itebis.ToString().Replace(",", ".") + ", '1');" +
                            "insert into cantidad_caja(idArticulo,cantidad_caja)values(@idArticulo,'"+tbxCantidad_caja.Text.Trim()+"');"+
                            "end";

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
                            "select @idMedida = m.id from medida as m where m.medida = '" + cbxMedida.Text.Trim() + "';" +
                            "select @idTipo_articulo = t.id from tipo_articulo as t where t.categoria = '" + cbxTipo.Text.Trim() + "';" +
                            "update articulo set nombre_articulo = '" + tbxNombre.Text.Trim()
                            + "', precio_compra = '" + tbxPrecio_compra.Text.Trim()
                            + "', precio_venta = '" + tbxPrecio_venta.Text.Trim()
                            + "', existencia = '" + tbxExistencia.Text.Trim() 
                            + "', descripcion = '" + tbxDescripcion.Text.Trim() 
                            + "', cantidad_maxima = '" + tbxCantidad_maxima.Text.Trim() 
                            + "', cantidad_minima = '" + tbxCantidad_minima.Text.Trim() 
                            + "', fecha_renovacion = '" + dtFecha_renovacion.Value.Day + "/" + dtFecha_renovacion.Value.Month + "/" + dtFecha_renovacion.Value.Year 
                            + "', idMedida = @idMedida, idMarca = '"+idMarca+"', idTipo_articulo = @idTipo_articulo, estado = '1', ITEBIs='" + itebis.ToString().Replace(",", ".") + "' " +
                            "where id = '" + tbxCodigo.Text.Trim() + "';" +
                            "delete from cantidad_caja where idArticulo='"+tbxCodigo.Text.Trim()+"'" +
                            "end";

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
                            "select @idMedida = m.id from medida as m where m.medida = '" + cbxMedida.Text.Trim() + "';" +
                            "select @idTipo_articulo = t.id from tipo_articulo as t where t.categoria = '" + cbxTipo.Text.Trim() + "';" +
                            "insert into articulo(id, nombre_articulo, precio_compra, precio_venta, existencia, descripcion, cantidad_maxima, cantidad_minima, fecha_renovacion, idMedida, idMarca, idTipo_articulo, estado, ITEBIs)" +
                            "values(newid(), '" + tbxNombre.Text.Trim() 
                            + "', '" + tbxPrecio_compra.Text.Trim() 
                            + "', '" + tbxPrecio_venta.Text.Trim() 
                            + "', '" + tbxExistencia.Text.Trim() 
                            + "', '" + tbxDescripcion.Text.Trim() 
                            + "', '" + tbxCantidad_maxima.Text.Trim() 
                            + "', '" + tbxCantidad_minima.Text.Trim() 
                            + "', '" + dtFecha_renovacion.Value.Day + "/" + dtFecha_renovacion.Value.Month + "/" + dtFecha_renovacion.Value.Year 
                            + "', @idMedida, '"+idMarca
                            +"', @idTipo_articulo, '1','"+ itebis.ToString().Replace(",", ".") + "');" +
                            "end";

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

        private void tkbItebis_Scroll(object sender, EventArgs e)
        {
            lbItebis.Text = "(" +tkbItebis.Value+ "%)";
        }

        private void btnSeleccionarMarca_Click(object sender, EventArgs e)
        {
            MantenimientoMarca rc = new MantenimientoMarca();
            
            rc.btnBorrar.Enabled = false;
            rc.btnModificar.Enabled = false;
            rc.btnSeleccionar.Enabled = true;

            rc.ShowDialog();

            idMarca = rc.codigo_marca;
            //MessageBox.Show(idMarca);
            tbxMarca.Text = rc.nombre_marca;
        }

        private void tbxPrecio_compra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.SoloNumeros(e,sender);
        }

        private void tbxPrecio_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.SoloNumeros(e, sender);
        }

        private void tbxExistencia_TextChanged(object sender, EventArgs e)
        {
            //Utilidades.SoloNumeros(e, sender);
        }

        private void tbxExistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.SoloNumeros(e, sender);
        }

        private void tbxCantidad_maxima_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbxCantidad_minima_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbxCantidad_maxima_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.SoloNumeros(e, sender);
        }

        private void tbxCantidad_minima_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.SoloNumeros(e, sender);
        }

        private void cbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
