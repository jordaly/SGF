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
        public string BuscarDatos = "select id, usuario, limite_descuento, estado from usuario where estado!='0' ";
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
               "update usuario set estado='0' where id = '" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "';" +
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
            //rc.chxEstado.Checked = Convert.ToBoolean(dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[3].Value.ToString());
            rc.usuarioViejo = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString();
            
            
            cmd = "select * from usuario where id='" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "';";            
            ds = Utilidades.EjecutarDS(cmd);

            rc.tbxContraseña.Text= ds.Tables[0].Rows[0]["password"].ToString();
            rc.tbxEmpleado.Text= ds.Tables[0].Rows[0]["idEmpleado"].ToString();
            rc.chxModificarArticulos.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["modificar_articulos"].ToString());
            rc.chxRecursosHumanos.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["recursos_humanos"].ToString());
            rc.chxModificarClientes.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["modificar_clientes"].ToString());
            rc.chxModificarSuplidores.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["modificar_suplidores"].ToString());
            rc.chxModificarUsuarios.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["modificar_usuarios"].ToString());
            rc.chxIngresarCompras.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["ingresar_compras"].ToString());
            rc.chxIngresarVentas.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["ingresar_ventas"].ToString());
            rc.chxDespachoTransporte.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["despacho_transporte"].ToString());
            rc.chxConsultaVentas.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["consulta_ventas"].ToString());
            rc.chxConsultaReportes.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["consultar_reportes"].ToString());
            rc.chxRealizarPagos.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["realizar_pagos"].ToString());
            rc.chxActualizarCaja.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["actualizar_caja"].ToString());
            rc.chxRealizarPermisos.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["realizar_permisos"].ToString());
            rc.tkbDescuento.Value =Convert.ToInt32( Convert.ToDouble( ds.Tables[0].Rows[0]["limite_descuento"].ToString()) * 100);
            rc.lbDescuento.Text="("+ Convert.ToInt32(Convert.ToDouble(ds.Tables[0].Rows[0]["limite_descuento"].ToString()) * 100) +"%)";

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
                cmd += " and "+ cbxBuscar.Text.Trim() + " like('%" + parametro.Trim() + "%')";
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
