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
    public partial class MantenimientoCotizacion : FormProcesos
    {
        public string BuscarDatos = "select c.id,t.id as idCliente, t.nombre,p.apellido,c.fecha_in,s.nombre_sucursal,c.total from persona as p, cotizacion as c,sucursal as s, tercero as t where t.id=c.idCliente and s.id=c.idSucursal and p.idTercero=c.idCliente";
        public MantenimientoCotizacion()
        {
            InitializeComponent();
            cbxBuscar.SelectedIndex = 0;
            refrescarDatos(BuscarDatos);
        }

        public override void Borrar()
        {
            DialogResult result = MessageBox.Show("Seguro que quiere eliminar la Cotizacion : " + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString() + " Codigo: " + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString(), "Atención", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                cmd = "delete from cotizacion where id = '" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "';";
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
            RegistroSuplidores rc = new RegistroSuplidores();
            rc.ShowDialog();


            refrescarDatos(BuscarDatos);
        }


        public override void Modificar()
        {
            FrmCotizacion rc = new FrmCotizacion();
            cmd = "select d.idArticulo, a.descripcion, d.cantidadCotizada, a.ITEBIs,a.precio_venta from detalle_cotizacion as d,articulo as a where idCotizacion='" + dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString() + "'and a.id=d.idArticulo";
            ds = Utilidades.EjecutarDS(cmd);



            int cont_fila = 0;
            double total;
            string codigo_empleado;
            string codigo_usuario;

            string codigo_cliente = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string nombre_cliente = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string apellido_cliente = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[3].Value.ToString();
            string sucursal = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[5].Value.ToString();

            rc.lbcodigo.Text = codigo_cliente;
            rc.txtcliente.Text = nombre_cliente + " " + apellido_cliente;
            rc.cbxsucursal.Text = sucursal;

            foreach (DataRow filas in ds.Tables[0].Rows)
            {
                filas[""].ToString();
                
                    bool existe = false;
                    int num_fila = 0;

                    if (cont_fila == 0)
                    {
                        rc.gridcotizacion.Rows.Add(filas["idArticulo"].ToString(), filas["descripcion"].ToString(),filas["precio_venta"].ToString(),  filas["ITEBIs"].ToString(),  filas["cantidadCotizada"].ToString());
                        double importe = (Convert.ToDouble(rc.gridcotizacion.Rows[cont_fila].Cells[2].Value) + (Convert.ToDouble(rc.gridcotizacion.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(rc.gridcotizacion.Rows[cont_fila].Cells[3].Value))) * Convert.ToDouble(rc.gridcotizacion.Rows[cont_fila].Cells[4].Value);
                        rc.gridcotizacion.Rows[cont_fila].Cells[5].Value = importe;

                        cont_fila++;
                    }
                    else
                    {
                        foreach (DataGridViewRow fila in rc.gridcotizacion.Rows)
                        {
                            if (fila.Cells[0].Value.ToString() == filas["idArticulo"].ToString())
                            {
                                existe = true;
                                num_fila = fila.Index;
                            }
                        }

                        if (existe == true)
                        {
                        //MessageBox.Show(""+num_fila);
                        rc.gridcotizacion.Rows[num_fila].Cells[4].Value = Convert.ToDouble( filas["cantidadCotizada"].ToString()) + (Convert.ToDouble(rc.gridcotizacion.Rows[num_fila].Cells[4].Value));

                            double importe = (Convert.ToDouble(rc.gridcotizacion.Rows[num_fila].Cells[2].Value) + (Convert.ToDouble(rc.gridcotizacion.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(rc.gridcotizacion.Rows[num_fila].Cells[3].Value))) * (Convert.ToDouble(rc.gridcotizacion.Rows[num_fila].Cells[4].Value));

                            rc.gridcotizacion.Rows[num_fila].Cells[5].Value = importe;

                        }
                        else
                        {
                        rc.gridcotizacion.Rows.Add(filas["idArticulo"].ToString(), filas["descripcion"].ToString(),  filas["precio_venta"].ToString(),  filas["ITEBIs"].ToString(),  filas["cantidadCotizada"].ToString());
                            double importe = (Convert.ToDouble(rc.gridcotizacion.Rows[cont_fila].Cells[2].Value) + (Convert.ToDouble(rc.gridcotizacion.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(rc.gridcotizacion.Rows[cont_fila].Cells[3].Value))) * Convert.ToDouble(rc.gridcotizacion.Rows[cont_fila].Cells[4].Value);
                        rc.gridcotizacion.Rows[cont_fila].Cells[5].Value = importe;

                            cont_fila++;
                        }
                    }
                    total = 0;

                    foreach (DataGridViewRow fila in rc.gridcotizacion.Rows)
                    {
                        total += Convert.ToDouble(fila.Cells[5].Value);
                    }
                    rc.txttotal.Text = "RD$ " + total.ToString();
            }
        }

        public string codigo_suplidor = "";
        public string nombre_suplidor = "";
        public string RNC = "";
        public override void Seleccionar()
        {

            if (dgvPadre.Rows.Count != 0)
            {
                codigo_suplidor = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString();
                nombre_suplidor = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString();

                this.Close();
            }



        }

        public override void Buscar()
        {
            FormBarraBusqueda bb = new FormBarraBusqueda();
            bb.ShowDialog();
            string parametro = bb.parametro;
            string v = "";
            if (cbxBuscar.Text == "id" || cbxBuscar.Text == "estado")
            {
                v = "s.";
            }
            else
            {
                v = "t.";
            }


            cmd = BuscarDatos;
            //MessageBox.Show("se esta ejecuetando");
            if (!String.IsNullOrEmpty(parametro.Trim()))
            {
                cmd += "and " + v + cbxBuscar.Text + " like('%" + parametro.Trim() + "%')";
            }
            ds = Utilidades.EjecutarDS(cmd);
            //MessageBox.Show(cmd);
            if (ds.Tables.Count > 0)
            {
                dgvPadre.DataSource = ds.Tables[0];
            }
        }
    }
}
