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
    public partial class EmpresaSistema : FormRegistros
    {
        public EmpresaSistema()
        {
            InitializeComponent();
            cmd = "select t.id,t.nombre,t.RNC from tercero as t,EmpresaDelSistema as e where t.id=e.terceroEmpresa";
            ds = Utilidades.EjecutarDS(cmd);
            if (ds.Tables[0].Rows.Count > 0)
            {
                tbxNombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                tbxRNC.Text = ds.Tables[0].Rows[0]["RNC"].ToString();
            }
        }



        public override void Guardar()
        {
            cmd = "select t.id,t.nombre,t.RNC from tercero as t,EmpresaDelSistema as e where t.id=e.terceroEmpresa";
            ds = Utilidades.EjecutarDS(cmd);
            if (ds.Tables[0].Rows.Count>0)
            {
                string idTercero=ds.Tables[0].Rows[0]["id"].ToString();
                string nombre = ds.Tables[0].Rows[0]["nombre"].ToString();
                string rnc = ds.Tables[0].Rows[0]["RNC"].ToString();
                DialogResult result = MessageBox.Show("Seguro que quiere cambiar a la empresa del sistema: " + nombre + " " + " RNC: " +rnc, "Atención", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    cmd = "update tercero set nombre='"+tbxNombre.Text.Trim()+"',RNC='"+tbxRNC.Text+"' where id='"+idTercero+"'";
                    ds = Utilidades.EjecutarDS(cmd);
                    MessageBox.Show("Se ha cambiado Exitosamente");

                }
                else
                {
                    // No hacer nada
                }
            }
            else
            {
                cmd = 
                    "begin " +
                        "declare @idTercero uniqueidentifier=newid();" +
                        "insert into tercero(id,nombre,RNC,fecha_in,estado)values(@idTercero,'"+tbxNombre.Text+"','"+tbxRNC.Text+"',getdate(),'1');" +
                        "insert into EmpresaDelSistema(id,terceroEmpresa)values('1',@idTercero);" +
                    "end";
                ds = Utilidades.EjecutarDS(cmd);
                MessageBox.Show("Se ha Guardado Exitosamente");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListadoDGII rc = new ListadoDGII();
            rc.btnBorrar.Enabled = false;
            rc.btnModificar.Enabled = false;
            rc.btnNuevo.Enabled = false;
            rc.btnSeleccionar.Enabled = true;
            rc.ShowDialog();
            
            tbxNombre.Text = rc.nombre;
            tbxRNC.Text = rc.rnc;
            
        }
    }
}
