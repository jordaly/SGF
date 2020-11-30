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
    public partial class ControlVacasiones : FormProcesos
    {
        public ControlVacasiones()
        {
            InitializeComponent();
        }
        public override void Nuevo()
        {
            //RegistroEmpleados rc = new RegistroEmpleados();
            //rc.ShowDialog();


            //refrescarDatos(BuscarDatos);
            //cmd = "";
            //MessageBox.Show(cmd);
            //rtbxIndicaciones.Text = cmd;
            //Console.Out(cmd);
            //ds = Utilidades.EjecutarDS(cmd);
            DateTime hoy = DateTime.Now;
            DateTime FechaFinal = Convert.ToDateTime("1/11/2020");
            TimeSpan t = FechaFinal - hoy;
            double NrOfDays = t.TotalDays;
            MessageBox.Show(""+NrOfDays);
        }
    }
}
