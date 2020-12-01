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
    public partial class MantenimientoUsuarios : FormProcesos
    {
        public string BuscarDatos = "select id, usuario, limite_descuento, estado from usuario ";
        public MantenimientoUsuarios()
        {
            InitializeComponent();
            cbxBuscar.SelectedIndex = 0;
            refrescarDatos(BuscarDatos);
        }

        public override void Borrar()
        {
            DialogResult result = MessageBox.Show("Seguro que quiere eliminar el usuario: " + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString() + " Codigo: " + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString(), "Atención", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                cmd = "begin " +
               "delete from usuario where id = '" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "';" +
               "end";
                ds = Utilidades.EjecutarDS(cmd);
                MessageBox.Show("Se ha eliminado Exitosamente");
                refrescarDatos(BuscarDatos);
            }
            else
            {
                // No hacer nada
            }

        }

        public override void Nuevo()
        {
            RegistroUsuarios rc = new RegistroUsuarios();
            rc.ShowDialog();


            refrescarDatos(BuscarDatos);
        }

        public override void Modificar()
        {

            RegistroUsuarios rc = new RegistroUsuarios();
            rc.tbxCodigo.Text = (dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString());
            rc.tbxUsuario.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString();
            rc.tbxContraseña.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[2].Value.ToString();
            //rc.cbxNivel.SelectedItem = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[3].Value.ToString();
            //rc.tbxExistencia.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[4].Value.ToString();
            //rc.tbxDescripcion.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[5].Value.ToString();
            //rc.tbxCantidad_maxima.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[6].Value.ToString();
            //rc.tbxCantidad_minima.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[7].Value.ToString();
            //rc.dtFecha_renovacion.Value = Convert.ToDateTime(dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[8].Value.ToString());
            //rc.cbxMedida.SelectedItem = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[9].Value.ToString();
            //rc.cbxMarca.SelectedItem = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[10].Value.ToString();
            //rc.cbxTipo.SelectedItem = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[11].Value.ToString();
            rc.chxEstado.Checked = Convert.ToBoolean(dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[3].Value.ToString());
            rc.usuarioViejo = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString();
            cmd = "select * from usuario where id='" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "';";
            ds = Utilidades.EjecutarDS(cmd);
            ////id,
            ////usuario,
            ////    password,
            ////    nivel,
            ////    modificar_articulos[
            ////    ajuste_stock[
            ////    modificar_clientes[
            ////    modificar_suplidores[
            ////    modificar_vendedores[
            ////    ingresar_compras[
            ////    ingresar_ventas[
            ////    despacho_transporte[
            ////    consulta_ventas[
            ////    consultar_reportes[
            ////    reimprimir_facturas[
            ////    actualizar_caja[
            ////    limite_descuento[
            ////    estado
            rc.chxModificarArticulos.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["modificar_articulos"].ToString());
            rc.chxAjusteStock.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["ajuste_stock"].ToString());
            rc.chxModificarClientes.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["modificar_clientes"].ToString());
            rc.chxModificarSuplidores.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["modificar_suplidores"].ToString());
            rc.chxModificarVendedores.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["modificar_vendedores"].ToString());
            rc.chxIngresarCompras.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["ingresar_compras"].ToString());
            rc.chxIngresarVentas.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["ingresar_ventas"].ToString());
            rc.chxDespachoTransporte.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["despacho_transporte"].ToString());
            rc.chxConsultaVentas.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["consulta_ventas"].ToString());
            rc.chxConsultaReportes.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["consultar_reportes"].ToString());
            rc.chxReimprimirFacturas.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["reimprimir_facturas"].ToString());
            rc.chxActualizarCaja.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["actualizar_caja"].ToString());
            rc.tbxLimiteDescuento.Text = ds.Tables[0].Rows[0]["limite_descuento"].ToString();

            //if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            //{
            //    //rc.tbxCantidad_caja.Visible = true;
            //    //rc.tbxCantidad_caja.Text = ds.Tables[0].Rows[0]["cantidad_caja"].ToString();
            //    //MessageBox.Show("errror: "+ds.Tables[0].Rows[0]["cantidad_caja"].ToString());
            //    //rc.etCantidad.Visible = true;
            //}
            rc.ShowDialog();


            refrescarDatos(BuscarDatos);

        }

        public override void Buscar()
        {
            FormBarraBusqueda bb = new FormBarraBusqueda();
            bb.ShowDialog();
            string parametro = bb.parametro;
            

            cmd = BuscarDatos;
            //MessageBox.Show("se esta ejecuetando");
            if (!String.IsNullOrEmpty(parametro.Trim()))
            {
                cmd += "where "+ cbxBuscar.Text.Trim() + " like('%" + parametro.Trim() + "%')";
            }
            ds = Utilidades.EjecutarDS(cmd);
            //MessageBox.Show(cmd);
            if (ds!=null)
            {
                if (ds.Tables.Count > 0)
                {
                    dgvPadre.DataSource = ds.Tables[0];
                }
                
            }
        }
    }
}
