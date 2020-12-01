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
    public partial class ModificarVacaciones : FormRegistros
    {
        public ModificarVacaciones()
        {
            InitializeComponent();
        }
        public override void Guardar()
        {
            cmd = "update vacaciones set fecha_inicio='"+dtFechaInicio.Value+"', fecha_fin='"+dtFechaFin.Value+"',estado='"+chxEstado.Checked+"' where idEmpleado='"+tbxCodigo.Text+"';";
            ds = Utilidades.EjecutarDS(cmd);
            MessageBox.Show("Guardado exitosamente");
            //Limpiar();
            this.Close();
        }

        private void ModificarVacaciones_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
