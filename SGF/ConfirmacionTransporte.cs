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
    public partial class ConfirmacionTransporte : FormProcesos
    {
        public string BuscarDatos = "select id,numero_factura,matricula_vehiculo,hora_salida from transporte where estado='1'";
        public ConfirmacionTransporte()
        {
            InitializeComponent();
            refrescarDatos(BuscarDatos);
        }
        public override void Modificar()
        {
            RegistroConfirmacionTransporte rc = new RegistroConfirmacionTransporte();

            rc.matriculaVehiculo = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[2].Value.ToString();
            rc.tbxCodigo.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString();

            rc.ShowDialog();

            refrescarDatos(BuscarDatos);
        }
    }
}
