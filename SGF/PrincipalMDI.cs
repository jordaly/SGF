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
    public partial class FrmMenu : Form
    {
        private int childFormNumber = 0;
        public string codigo_usuario="";
        public bool salir = false;
        public FrmMenu()
        {
            
            
            InitializeComponent();
            this.Visible=false;
            login lg = new login();
            lg.ShowDialog();
            codigo_usuario = lg.codigo_usuario;
            this.tsslUsuario.Text = "Usuario Actual: " + lg.tbNombre.Text;
            this.salir = lg.salir;
            //SalirAplicacion(lg.salir);
            


        }
        public void SalirAplicacion(bool ok)
        {
            if (ok)
            {
                this.Close();
            }
            else
            {
                this.Visible = true;
            }
        }
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }

            this.Visible = false;
            login lg = new login();
            lg.ShowDialog();
            codigo_usuario = lg.codigo_usuario;
            this.tsslUsuario.Text = lg.tbNombre.Text;
            this.salir = lg.salir;
            SalirAplicacion(salir);
            

        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoUsuarios rc = new MantenimientoUsuarios();
            rc.MdiParent = this;
            rc.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoClientes rc = new MantenimientoClientes();
            rc.MdiParent = this;
            rc.Show();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoEmpleados rc = new MantenimientoEmpleados();
            rc.MdiParent = this;
            rc.Show();
        }

        private void suplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            SalirAplicacion(salir);
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoInventario rc = new MantenimientoInventario();
            rc.MdiParent = this;
            rc.Show();

        }

        private void movimientoInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoMovimientoArticulos rc = new MantenimientoMovimientoArticulos();
            rc.MdiParent = this;
            rc.Show();
        }

        private void almacenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoAlmacenes rc = new MantenimientoAlmacenes();
            rc.MdiParent = this;
            rc.Show();
        }

        private void pagosNominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlPagos rc = new ControlPagos();
            rc.MdiParent = this;
            rc.Show();
        }

        private void vacacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarVacaciones rc = new ModificarVacaciones();
            rc.MdiParent = this;
            rc.Show();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentas rc = new FrmVentas();
            rc.MdiParent = this;
            rc.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsslhora.Text= "Hora: " + DateTime.Now.ToString("hh:mm:ss") + "   Fecha: " + DateTime.Now.ToLongDateString();
        }
    }
}
