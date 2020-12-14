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
    public partial class RegistroSucursal : FormRegistros
    {
        public string codigoAlmacen = "";
        public RegistroSucursal()
        {
            InitializeComponent();
        }
        public override void Guardar()
        {
            if (ComprobarCampos())
            {


                if (tbxCodigo.Text == "Nuevo")
                {
                    cmd =
                        "begin " +
                            "declare @idTerceroSistema uniqueidentifier;" +
                            "declare @idSucursal uniqueidentifier = newid();" +
                            "select @idTerceroSistema=terceroSistema from EmpresaDelSistema where id='1';" +
                            "insert into sucursal(id,idTercero,nombre_sucursal,estado)values(@idSucursal,@idTerceroSistema,'" + tbxNombre.Text.Trim() + "','1');" +
                            "insert into sucursal_vs_almacen(idSucursal,idAlmacen)values(@idSucursal,'" + codigoAlmacen + "');" +
                        "end";
                    ds = Utilidades.EjecutarDS(cmd);
                    MessageBox.Show("Guardado Exitosamente.");
                    this.Close();
                }
                else
                {
                    cmd =
                        "begin " +
                        "declare @idTerceroSistema uniqueidentifier;" +
                        "select @idTerceroSistema=terceroSistema from EmpresaDelSistema where id='1';" +
                        "update sucursal set nombre_sucursal='" + tbxNombre.Text.Trim() + "' where id = '" + tbxCodigo.Text + "';" +
                        "update sucursal_vs_almacen set idAlmacen='" + codigoAlmacen + "' where  idSucursal='" + tbxCodigo.Text + "';" +
                        "end";
                    ds = Utilidades.EjecutarDS(cmd);
                    MessageBox.Show("Guardado Exitosamente.");
                    this.Close();
                }
            }
        }

        private void btnSeleccionarAlmacen_Click(object sender, EventArgs e)
        {
            MantenimientoAlmacenes rc = new MantenimientoAlmacenes();
            rc.btnBorrar.Enabled = false;
            rc.btnModificar.Enabled = false;
            rc.btnSeleccionar.Enabled = true;
            rc.almacenSucursal = true;
            rc.ShowDialog();
            tbxAlmacen.Text = rc.nombre_almacen;
            codigoAlmacen = rc.codigo_almacen;

        }
        public bool ComprobarCampos()
        {
            bool ok = true;
            if (tbxNombre.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxNombre, "Este campo no puede estar vasio.");
            }
            if (tbxAlmacen.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxAlmacen, "Este campo no puede estar vasio.");
            }
            return ok;
        }
    }
}
