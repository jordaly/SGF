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
    public partial class FrmVentas : FormBase
    {
        public FrmVentas()
        {
            InitializeComponent();
        }

        public string codigo_cliente;
        private void btnbuscarcliente_Click(object sender, EventArgs e)
        {
            MantenimientoClientes frm = new MantenimientoClientes();
            frm.btnBorrar.Enabled = false;
            frm.btnModificar.Enabled = false;
            frm.btnNuevo.Enabled = true;
            frm.btnSeleccionar.Enabled = true;
            frm.ShowDialog();

            codigo_cliente = frm.codigo_cliente;
            string cmd = " begin " +
                "select t.nombre, p.apellido, t.NCF from cliente as c, tercero as t, persona as p" +
                " where c.idTercero='"+codigo_cliente+"' and t.id=c.idTercero and p.idTercero=c.idTercero;" +
                " end";
            lbcodigo.Text = "Codigo Cliente: "+codigo_cliente;
            ds = Utilidades.EjecutarDS(cmd);
           //ds.Tables[0].Rows[0]["sexo"].ToString();
           txtcliente.Text= ds.Tables[0].Rows[0]["nombre"].ToString()+" " + ds.Tables[0].Rows[0]["apellido"].ToString();

            if (ds.Tables[0].Rows[0]["NCF"].ToString()!=null)
            {
                txtrnc.Text = ds.Tables[0].Rows[0]["NCF"].ToString();
            }
        }

        private void btnbuscararticulo_Click(object sender, EventArgs e)
        {
            MantenimientoInventario frm = new MantenimientoInventario();

            frm.btnBorrar.Enabled = false;
            frm.btnModificar.Enabled = false;
            frm.btnNuevo.Enabled = true;
            frm.btnSeleccionar.Enabled = true;
            frm.ShowDialog();
        }
    }
}
