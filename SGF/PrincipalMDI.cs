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
            if (!salir)
            {
                ControlAcceso();
            }
            
            

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
            MantenimientoSuplidores rc = new MantenimientoSuplidores();
            rc.MdiParent = this;
            rc.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            SalirAplicacion(salir);
            if (!salir)
            {
                ControlAcceso();
            }
            

            //contratacionesToolStripMenuItem.Visible = false;
            
        }
        public DataSet ds,ds2 = new DataSet();
        public string cmd = "";


        public void ControlAcceso()
        {
            //"modificar_articulos," +                    //1*
            //"recursos_humanos," +                       //2*
            //"modificar_clientes," +                     //3*
            //"modificar_suplidores," +                   //4*
            //"modificar_usuarios," +                     //5*
            //"ingresar_compras," +                       //6*
            //"ingresar_ventas," +                        //7*
            //"despacho_transporte," +                    //8*
            //"consulta_ventas," +                        //9*
            //"consultar_reportes," +                     //10*
            //"realizar_pagos," +                         //11*
            //"actualizar_caja," +                        //12*
            //"realizar_permisos," +                      //13*

            ds = Utilidades.EjecutarDS("select * from usuario where id='"+codigo_usuario+"'");
            //inventario
            if (Convert.ToBoolean(ds.Tables[0].Rows[0]["modificar_articulos"].ToString()))
            {
                inventarioToolStripMenuItem.Visible = true;
                alertaStockBajoArticulo();
            }
            else
            {
                inventarioToolStripMenuItem.Visible = false;
            }

            //empleado y contrataciones
            if (Convert.ToBoolean(ds.Tables[0].Rows[0]["recursos_humanos"].ToString()))
            {
                empleadosToolStripMenuItem.Visible = true;
                contratacionesToolStripMenuItem.Visible = true;
            }
            else
            {
                empleadosToolStripMenuItem.Visible = false;
                contratacionesToolStripMenuItem.Visible = false;
            }

            //cliente
            if (Convert.ToBoolean(ds.Tables[0].Rows[0]["modificar_clientes"].ToString()))
            {
                clientesToolStripMenuItem.Visible = true;
            }
            else
            {
                clientesToolStripMenuItem.Visible = false;
            }

            //suplidores
            if (Convert.ToBoolean(ds.Tables[0].Rows[0]["modificar_suplidores"].ToString()))
            {
                suplidoresToolStripMenuItem.Visible = true;
            }
            else
            {
                suplidoresToolStripMenuItem.Visible = false;
            }
            //usuario
            if (Convert.ToBoolean(ds.Tables[0].Rows[0]["modificar_usuarios"].ToString()))
            {
                usuariosToolStripMenuItem.Visible = true;
            }
            else
            {
                usuariosToolStripMenuItem.Visible = false;
            }

            //compras
            if (Convert.ToBoolean(ds.Tables[0].Rows[0]["ingresar_compras"].ToString()))
            {
                compraToolStripMenuItem.Visible = true;
            }
            else
            {
                compraToolStripMenuItem.Visible = false;
            }

            //ventas
            if (Convert.ToBoolean(ds.Tables[0].Rows[0]["ingresar_ventas"].ToString()))
            {
                ventaToolStripMenuItem.Visible = true;
            }
            else
            {
                ventaToolStripMenuItem.Visible = false;
            }

            //trasnporte ***
            if (Convert.ToBoolean(ds.Tables[0].Rows[0]["despacho_transporte"].ToString()))
            {

            }
            else
            {

            }


            //consulta ventas ***
            if (Convert.ToBoolean(ds.Tables[0].Rows[0]["consulta_ventas"].ToString()))
            {

            }
            else
            {

            }


            //consulta reportes ***
            if (Convert.ToBoolean(ds.Tables[0].Rows[0]["consultar_reportes"].ToString()))
            {

            }
            else
            {

            }

            //realizar pagos
            if (Convert.ToBoolean(ds.Tables[0].Rows[0]["realizar_pagos"].ToString()))
            {
                pagosNominaToolStripMenuItem.Visible = true;
            }
            else
            {
                pagosNominaToolStripMenuItem.Visible = false;
            }

            //actualizar caja ***
            if (Convert.ToBoolean(ds.Tables[0].Rows[0]["actualizar_caja"].ToString()))
            {

            }
            else
            {

            }

            //realizar permisos ***
            if (Convert.ToBoolean(ds.Tables[0].Rows[0]["realizar_permisos"].ToString()))
            {

            }
            else
            {

            }



        }
        public void alertaStockBajoArticulo()
        {
            cmd = "select * from articulo  as a where a.existencia<a.cantidad_minima";
            ds2 = Utilidades.EjecutarDS(cmd);
            if (ds2.Tables[0].Rows.Count>0)
            {
                cmd = "";
                foreach (DataRow fila in ds2.Tables[0].Rows)
                {
                    cmd +="Codigo: "+ fila["id"].ToString() +"     |    Nombre del articulo: "+ fila["nombre_articulo"].ToString()+ "    |        stock actual:" + fila["existencia"].ToString()+ "           |    stock minimo: " + fila["cantidad_minima"].ToString()+"\r\n";

                }
                principal rc = new principal();
                rc.richTextBox1.Text = cmd;
                rc.Text = "Alerta de inventaria bajo";
                rc.ShowDialog();
            }
        }
        public void alertaFechaRenovacionArticulo()
        {
            cmd = "select * from articulo  as a where  fecha_renovacion<getdate()";
            ds = Utilidades.EjecutarDS(cmd);
            if (ds.Tables[0].Rows.Count > 0)
            {
                cmd = "";
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    cmd += fila["nombre"].ToString();
                }
            }
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
            rc.btnNuevo.Enabled = false;
            rc.btnBorrar.Enabled = false;
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
            ControlVacasiones rc = new ControlVacasiones();
            rc.MdiParent = this;
            rc.Show();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentas rc = new FrmVentas();
            rc.MdiParent = this;
            rc.codigo_usuario=this.codigo_usuario;
            rc.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsslhora.Text= "Hora: " + DateTime.Now.ToString("hh:mm:ss") + "   Fecha: " + DateTime.Now.ToLongDateString();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            principal rc = new principal();
            rc.MdiParent = this;
            rc.Show();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompra rc = new FrmCompra();
            rc.MdiParent = this;
            rc.codigo_usuario = this.codigo_usuario;
            rc.Show();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoMarca rc = new MantenimientoMarca();
            rc.MdiParent = this;
            rc.Show();
        }

        private void cajaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MantenimientoCaja rc = new MantenimientoCaja();
            rc.MdiParent = this;
            rc.Show();
        }

        private void contratacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoContrataciones rc = new MantenimientoContrataciones();
            rc.MdiParent = this;
            rc.Show();
        }
    }
}
