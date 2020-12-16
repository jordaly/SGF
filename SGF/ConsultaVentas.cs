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
    public partial class ConsultaVentas : ConsultaCuadresCaja
    {
        
        public ConsultaVentas()
        {
            InitializeComponent();
            refrescarDatos(BuscarDatos);
            btnBorrar.Visible = false;
            btnModificar.Visible = false;

        }
        public string BuscarDatos = "select * from factura ";
        public override void Buscar()
        {
            DateTime desde = dtDesde.Value;
            DateTime hasta = dtHasta.Value;
            cmd = BuscarDatos;
            string fdesde = desde.Day + "/" + desde.Month + "/" + desde.Year;
            string fhasta = hasta.Day + "/" + hasta.Month + "/" + hasta.Year;
            cmd += " where fecha>='" + fdesde + "' and fecha<='" + fhasta + "'";
            //MessageBox.Show(cmd);
            refrescarDatos(cmd);
        }
        public override void Seleccionar()
        {
            refrescarDatos(BuscarDatos);
        }
        private void ConsultaVentas_Load(object sender, EventArgs e)
        {
            
        }
    }
}
