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
    public partial class ConsultaCuadresCaja : FormProcesos
    {
        public string BuscarDatos = "select * from caja where estado='0' ";
        public ConsultaCuadresCaja()
        {
            InitializeComponent();
            refrescarDatos(BuscarDatos);
            btnBorrar.Visible = false;
            btnModificar.Visible = false;

        }
        public override void Buscar()
        {
            DateTime desde = dtDesde.Value;
            DateTime hasta = dtHasta.Value;
            cmd = BuscarDatos;
            string fdesde = desde.Day + "/" + desde.Month + "/" + desde.Year;
            string fhasta = hasta.Day + "/" + hasta.Month + "/" + hasta.Year;
            cmd += " and fecha_fin>='" + fdesde + "' and fecha_fin<='" + fhasta+"'";
            //MessageBox.Show(cmd);
            refrescarDatos(cmd);
        }
        public override void Seleccionar()
        {
            refrescarDatos(BuscarDatos);
        }
    }
}
