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
    public partial class Mantenimiento_transporte : FormProcesos
    {
        public string BuscarDatos = "select f.numero_factura,f.idcliente,(select nombre from tercero where id=f.idcliente) as nombre,(select apellido from persona where idTercero=f.idcliente)as apellido,f.NCF,f.fecha from factura as f where transporte='1' and estado='Normal'";
        public Mantenimiento_transporte()
        {
            InitializeComponent();
            refrescarDatos(BuscarDatos);
            cbxBuscar.SelectedIndex = 0;
        }
        public override void Nuevo()
        {
            RegistroTransporte rc = new RegistroTransporte();
            rc.txtcliente.Text = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[2].Value.ToString()+" "+ dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[3].Value.ToString();
            rc.numeroFactura = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString();
            rc.codigoCliente = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString();
            rc.ShowDialog();

            refrescarDatos(BuscarDatos);
        }
        
    }
}
