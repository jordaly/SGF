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
    public partial class RegistroQuejas : FormRegistros
    {
        public string codigoEmpleado = "",codigoCliente="",codigoArticulo="";
        public bool resolver = false;

        private void tbnSeleccionarArticulos_Click(object sender, EventArgs e)
        {
            MantenimientoInventario rc = new MantenimientoInventario();
            rc.btnBorrar.Enabled = false;
            rc.btnModificar.Enabled = false;
            rc.btnNuevo.Enabled = false;
            rc.btnSeleccionar.Enabled = true;
            rc.ShowDialog();
            tbxArticulo.Text = rc.nombre_articulo;
            codigoArticulo = rc.codigo_articulo;
        }

        public RegistroQuejas()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MantenimientoClientes rc = new MantenimientoClientes();
            rc.btnBorrar.Enabled = false;
            rc.btnModificar.Enabled = false;
            rc.btnNuevo.Enabled = false;
            rc.btnSeleccionar.Enabled = true;
            rc.ShowDialog();
            tbxCliente.Text = rc.nombre_cliente_apellido_cliente;
            codigoCliente = rc.codigo_cliente;

            
        }

        public bool ComprobarCampos()
        {
            ErrorProvider.Clear();
            bool ok = true;
            if (tbxArticulo.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxArticulo, "Este campo no puede estar vasio.");
            }
            if (tbxCliente.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxCliente, "Este campo no puede estar vasio.");
            }
            if (rtbxParrafo.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(rtbxParrafo, "Este campo no puede estar vasio.");
            }

            return ok;
        }

        public override void Guardar()
        {
            if (resolver)
            {
                cmd = "update quejas set resolucion='" + rtbxParrafo.Text + "',fecha_re = getdate(),estado='0' where id='" + tbxCodigo.Text + "';";
                ds = Utilidades.EjecutarDS(cmd);
                MessageBox.Show("Modificada exitosamente");
                this.Close();
            }
            else
            {
                if (tbxCodigo.Text == "Nuevo")
                {
                    cmd = "insert into quejas(queja,idEmpleado,idCliente,idArticulo,fecha_in,estado)values('"+rtbxParrafo.Text.Trim()+"','" + codigoEmpleado + "','" + codigoCliente + "','"+codigoArticulo+"',getdate(),'1')";
                    ds = Utilidades.EjecutarDS(cmd);
                    MessageBox.Show("Guardada Exitosamente");
                    //rtbxParrafo.Text = cmd;
                    this.Close();
                }
                else
                {
                    cmd = "update quejas set queja='" + rtbxParrafo.Text + "' where id='" + tbxCodigo.Text + "';";
                    ds = Utilidades.EjecutarDS(cmd);
                    MessageBox.Show("Modificada exitosamente");
                    this.Close();
                }
            }
            
        }
    }
}
