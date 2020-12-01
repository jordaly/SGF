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
    public partial class RegistroUsuarios : FormRegistros
    {
        public string usuarioViejo="";
        public RegistroUsuarios()
        {
            InitializeComponent();
            cbxNivel.SelectedIndex = 0;
        }
        public override void Guardar()
        {
            DataSet ds = new DataSet();

            if (tbxCodigo.Text.Trim()=="Nuevo")
            {
                string cmdUsuario = string.Format("select * from usuario where usuario='{0}'",
                tbxUsuario.Text.Trim());
                ds = Utilidades.EjecutarDS(cmdUsuario);
                if (!(ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0))
                {
                    string cmd = "insert into usuario(id,usuario,password,modificar_articulos,ajuste_stock,modificar_clientes,modificar_suplidores,modificar_vendedores,ingresar_compras,ingresar_ventas,despacho_transporte,consulta_ventas,consultar_reportes,reimprimir_facturas,actualizar_caja,limite_descuento,estado)" +
                        "values(newid(),'" + tbxUsuario.Text.Trim() + "','" + tbxContraseña.Text.Trim() + "','" + chxModificarArticulos.Checked + "','" + chxAjusteStock.Checked + "','" + chxModificarClientes.Checked + "','" + chxModificarSuplidores.Checked + "','" + chxModificarVendedores.Checked + "','" + chxIngresarCompras.Checked + "','" + chxIngresarVentas.Checked + "','" + chxDespachoTransporte.Checked + "','" + chxConsultaVentas.Checked + "','" + chxConsultaReportes.Checked + "','" + chxReimprimirFacturas.Checked + "','" + chxActualizarCaja.Checked + "','" + tbxLimiteDescuento.Text.Trim() + "','" + chxEstado.Checked + "');";
                    //MessageBox.Show(cmd);
                    ds = Utilidades.EjecutarDS(cmd);
                    tbxLimiteDescuento.Text = cmd;
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
                if (!(ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)||tbxUsuario.Text.Trim()==usuarioViejo)
                {
                    string cmd = "update usuario " +
                    "set usuario='"+tbxUsuario.Text.Trim()+"', password='"+tbxContraseña.Text.Trim()+"',modificar_articulos='"+chxModificarArticulos.Checked+"',ajuste_stock='"+chxAjusteStock.Checked+"',modificar_clientes='"+chxModificarClientes.Checked+"',modificar_suplidores='"+chxModificarSuplidores.Checked+"',modificar_vendedores='"+chxModificarVendedores.Checked+"',ingresar_compras='"+chxIngresarCompras.Checked+"',ingresar_ventas='"+chxIngresarVentas.Checked+"',despacho_transporte='"+chxDespachoTransporte.Checked+"',consulta_ventas='"+chxConsultaVentas.Checked+"',consultar_reportes='"+chxConsultaReportes.Checked+"',reimprimir_facturas='"+chxReimprimirFacturas.Checked+"',actualizar_caja='"+chxActualizarCaja.Checked+"',limite_descuento='"+tbxLimiteDescuento.Text.Trim()+"',estado='"+chxEstado.Checked+"' " +
                    "where id='"+tbxCodigo.Text.Trim()+"';";
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
            tbxLimiteDescuento.Text = "";
            cbxNivel.SelectedIndex = 0;
            chxEstado.Checked = false;
            tbxUsuario.Focus();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbxNivel.SelectedIndex = 0;
        }
    }
    
}
