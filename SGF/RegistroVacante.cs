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
    public partial class RegistroVacante : FormRegistros
    {
        public RegistroVacante()
        {
            InitializeComponent();
            string cmdPuesto = "Select * from puesto";
            

            //Puesto
            ds = Utilidades.EjecutarDS(cmdPuesto);
            cbxPuesto.DisplayMember = "puesto";
            cbxPuesto.DataSource = ds.Tables[0].DefaultView;
            
        }
        public override void Guardar()
        {
            cmd = "begin " +
                "declare @idPuesto uniqueidentifier;" +
                "select @idPuesto=id from puesto where puesto='" + cbxPuesto.Text + "';" +
                "insert into vacante(idPuesto,fecha,estado)values(@idPuesto,getdate(),'1');" +
                "end";
            ds = Utilidades.EjecutarDS(cmd);
            MessageBox.Show("Guardado exitosamente.");
            this.Close();
        }
    }
}
