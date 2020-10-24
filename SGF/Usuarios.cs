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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            cbxNivel.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();


            string cmdUsuario = string.Format("select * from usuario where usuario='{0}'",
                tbxUsuario.Text.Trim()) ;
            ds = Utilidades.EjecutarDS(cmdUsuario);
            if (!(ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0))
            {
                string cmd = String.Format("insert into usuario(id,usuario,password,nivel,estado) values(newid(),'{0}','{1}','{2}','{3}')", 
                   tbxUsuario.Text.Trim(), tbxContraseña.Text.Trim(), cbxNivel.SelectedIndex, chxEstado.Checked);
                //MessageBox.Show(cmd);
                ds = Utilidades.EjecutarDS(cmd);
                Limpiar();

                
            }
            else
            {
                MessageBox.Show("El nombre de usuario "+tbxUsuario.Text +" ya esta en uso.");
                Limpiar();
            }
            

        }
        public void Limpiar()
        {
            tbxUsuario.Text = "";
            tbxContraseña.Text = "";
            cbxNivel.SelectedIndex = 0;
            chxEstado.Checked = false;
            tbxUsuario.Focus();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbxNivel.SelectedIndex = 0;
        }
    }
    
}
