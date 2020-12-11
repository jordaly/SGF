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
    public partial class MantenimientoCaja : Form
    {
        public MantenimientoCaja()
        {
            InitializeComponent();
        }
        public string idCaja="";

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public DataSet ds = new DataSet();
        private void button1_Click(object sender, EventArgs e)
        {
            string v = DateTime.Now.TimeOfDay.ToString();
            v = v.Substring(0, DateTime.Now.TimeOfDay.ToString().Length - 4);
            string cmd = "insert into caja(fecha_in,cantidad_inicial,cantidad_actual,ventas_totales,Ganancias,estado)values" +
                "('"+ DateTime.Now.Year + "-" + DateTime.Now.Day + "-" + DateTime.Now.Month + " " + v + "','"+tbxCantidadInicial.Text.Trim()+"','"+tbxCantidadInicial.Text.Trim()+"','0','0','1');";

            ds = Utilidades.EjecutarDS(cmd);
            MessageBox.Show("Caja abierta exitosamente");
            tbxCantidadInicial.Enabled = false;
            btnInicio.Enabled = false;
            btnFinalizar.Enabled = true;
            

            ///MessageBox.Show(DateTime.Now.Year+"-"+ DateTime.Now.Day + "-" + DateTime.Now.Month + " " + v);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            string v = DateTime.Now.TimeOfDay.ToString();
            v = v.Substring(0, DateTime.Now.TimeOfDay.ToString().Length - 4);
            string cmd = "update caja set estado='0', fecha_fin='"+ DateTime.Now.Year + "-" + DateTime.Now.Day + "-" + DateTime.Now.Month + " " + v + "' where id='" + idCaja + "';";
            ds = Utilidades.EjecutarDS(cmd);
            MessageBox.Show("Caja cerrada exitosamente");
            tbxCantidadInicial.Text = "";
            tbxCantidadActual.Text = "0";
            tbxVentasTotales.Text = "0";
            tbxGanancias.Text = "0";
            lbFechaInicio.Text = "Fecha Inicio: ";
        }

        private void tbxCantidadInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.SoloNumeros(e, sender);
        }
    }
}
