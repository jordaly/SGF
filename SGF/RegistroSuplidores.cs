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
    public partial class RegistroSuplidores : FormRegistros
    {
        public RegistroSuplidores()
        {
            InitializeComponent();
        }
        public string rnc = "";
        public string nombre = "";

        private void button1_Click(object sender, EventArgs e)
        {
            ListadoDGII rc = new ListadoDGII();
            rc.btnBorrar.Enabled = false;
            rc.btnModificar.Enabled = false;
            rc.btnNuevo.Enabled = false;
            rc.btnSeleccionar.Enabled = true;
            rc.ShowDialog();
            if (rc.rnc!="")
            {
                rnc = rc.rnc;
                nombre = rc.nombre;
                tbxNombre.Text = nombre;
                tbxRNC.Text = rnc;
            }
        }

        public bool ComprobarCampos()
        {
            
            bool ok = true;
            if (tbxNombre.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxNombre, "Este campo no puede estar vasio.");
            }
            
            return ok;
        }
        public override void Guardar()
        {
            if (ComprobarCampos())
            {

                if (tbxCodigo.Text != "Nuevo")
                {
                    cmd = "begin " +
                            "update tercero set nombre='"+tbxNombre.Text.Trim()+"',estado='"+chxEstado.Checked+"',RNC='"+tbxRNC.Text+"' where id='"+tbxCodigo.Text+"';" +
                            "update suplidor set estado='"+chxEstado.Checked+"' where idTercero='"+tbxCodigo.Text+"';" +
                        "end";

                    ds = Utilidades.EjecutarDS(cmd);
                    MessageBox.Show("Sin Modificaciones.");
                    //Limpiar();
                    this.Close();


                }
                else
                {
                    cmd = "begin " +
                            "declare @id uniqueidentifier= newid();" +
                            "insert into tercero(id,nombre,fecha_in,RNC,estado)values(newid(),'" + tbxNombre.Text.Trim() + "',GETDATE(),'" + tbxRNC.Text + "','" + chxEstado.Checked + "');" +
                            "insert into suplidor(idTercero,estado)values(@id,'" + chxEstado.Checked + "');" +
                        "end";

                    ds = Utilidades.EjecutarDS(cmd);
                    MessageBox.Show("Guardado exitosamente");
                    this.Close();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbxRNC.Text = "";

        }
    }
}
