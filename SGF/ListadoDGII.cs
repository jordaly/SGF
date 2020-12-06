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
    public partial class ListadoDGII : FormProcesos
    {
        
        public ListadoDGII()
        {
            InitializeComponent();
            cbxBuscar.SelectedIndex = 0;
        }
        public string BuscarDatos = "select top(100) RNC,nombre,razon_social,servicio,fecha,estado from RNC_DGII where vijencia='ACTIVO'";
        public string rnc="";
        public string nombre = "";
        public override void Seleccionar()
        {
            if (dgvPadre.Rows.Count!=0)
            {
                rnc = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[0].Value.ToString();
                nombre = dgvPadre.Rows[dgvPadre.CurrentCell.RowIndex].Cells[1].Value.ToString();
                this.Close();
            }
            
        }


        public override void Buscar()
        {
            FormBarraBusqueda bb = new FormBarraBusqueda();
            bb.ShowDialog();
            string parametro = bb.parametro;


            cmd = BuscarDatos;
            //MessageBox.Show("se esta ejecuetando");
            if (!String.IsNullOrEmpty(parametro.Trim()))
            {
                cmd += "and "  + cbxBuscar.Text + " like('%" + parametro.Trim() + "%')";
                ds = Utilidades.EjecutarDS(cmd);
                //MessageBox.Show(cmd);
                if (ds.Tables.Count > 0)
                {
                    dgvPadre.DataSource = ds.Tables[0];
                }
            }
            
        }
    }
}
