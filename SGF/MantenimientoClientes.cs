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
    public partial class MantenimientoClientes : Form
    {
        public DataSet ds = new DataSet();
        public MantenimientoClientes()
        {
            
            InitializeComponent();
            cbxSexo.SelectedIndex = 0;
            cbxProvincia.SelectedIndex = 0;
            //try
            //{
            //    string cmdDepartamentos = String.Format("Select * from ");
            //    string cmdSuplidores = String.Format("Select * from Suplidores");
            //    string cmdUnidades = String.Format("Select * from Unidades");
            //    string cmdGrupo = String.Format("Select * from GrupoArticulo");
            //    //Departamentos
            //    ds = UTILIDADES1.utilidades.EjecutarDS(cmdDepartamentos);
            //    cbxCodigoDepartamento.DisplayMember = "Nombre_Departamento";
            //    cbxCodigoDepartamento.DataSource = ds.Tables[0].DefaultView;
            //    //Suplidores
            //    ds = UTILIDADES1.utilidades.EjecutarDS(cmdSuplidores);
            //    cbxCodigoSuplidor.DisplayMember = "Nombre_Suplidor";
            //    cbxCodigoSuplidor.DataSource = ds.Tables[0].DefaultView;
            //    //Unidades
            //    ds = UTILIDADES1.utilidades.EjecutarDS(cmdUnidades);
            //    cbxCodigoUnidad.DisplayMember = "Codigo_Unidad";//Tengo que averiguar que es lo que hace el displaymember
            //    cbxCodigoUnidad.DataSource = ds.Tables[0].DefaultView;//Tengo que averiguar que es lo que hace el defaultview
            //    //Grupo
            //    ds = UTILIDADES1.utilidades.EjecutarDS(cmdGrupo);
            //    cbxGrupo.DisplayMember = "Nombre";//Tengo que averiguar que es lo que hace el displaymember
            //    cbxGrupo.DataSource = ds.Tables[0].DefaultView;//Tengo que averiguar que es lo que hace el defaultview
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MantenimientoClientes_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            
                string cmd = String.Format("exec crearCliente '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}'",
                   tbxNombre.Text.Trim(),tbxApellido.Text.Trim(), dtFecha.Value.Day+"/"+dtFecha.Value.Month+"/"+dtFecha.Value.Year, cbxSexo.Text.Trim(),cbxProvincia.Text.Trim(), 
                   tbxLocalidad.Text.Trim(), tbxDireccion.Text.Trim(), rtbxIndicaciones.Text.Trim(), tbxCodigo_postal.Text.Trim(), chxEstado.Checked);
                //MessageBox.Show(cmd);
                ds = Utilidades.EjecutarDS(cmd);
                MessageBox.Show(cmd);
                //Limpiar();


            
        }

        //public void Limpiar()
        //{
        //    tbxUsuario.Text = "";
        //    tbxContraseña.Text = "";
        //    cbxNivel.SelectedIndex = 0;
        //    chxEstado.Checked = false;
        //    tbxUsuario.Focus();
        //}
    }
}
