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
    public partial class RegistroVehiculo : FormRegistros
    {
        public string idMarca = "", idModelo = "";
        public bool nuevo=true;
        public RegistroVehiculo()
        {
            InitializeComponent();
        }


        public override void Guardar()
        {
            if (ComprobarCampos())
            {
                if (nuevo)
                {
                    cmd = "select * from vehiculo where Matricula='" + tbxMatricula.Text.Trim() + "'";
                    ds = Utilidades.EjecutarDS(cmd);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("Ya hay un vehiculo con esta matricula: " + tbxMatricula.Text);
                    }
                    else
                    {
                        cmd = "insert into vehiculo(Matricula,idMarca,idModelo,reparacion,transporte,estado)" +
                            "values('" + tbxMatricula.Text.Trim() + "','" + idMarca + "','" + idModelo + "','0','0','1');";
                        ds = Utilidades.EjecutarDS(cmd);
                        MessageBox.Show("Se ha guardado exitosamente.");
                        //MessageBox.Show(cmd);
                        //tbxMatricula.Text = cmd;
                        this.Close();
                    }
                }
                else
                {
                    cmd = "update vehiculo set idMarca='" + idMarca + "',idModelo='" + idModelo + "' where Matricula='" + tbxMatricula.Text + "';";
                    ds = Utilidades.EjecutarDS(cmd);
                    MessageBox.Show("Se ha modificado exitosamente.");
                    //MessageBox.Show(cmd);
                    this.Close();
                }
            }
        }



        public bool ComprobarCampos()
        {

            ErrorProvider.Clear();
            bool ok = true;
            if (tbxMarca.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxMarca, "Este campo no puede estar vasio.");
            }
            if (tbxMarca.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxMarca, "Este campo no puede estar vasio.");
            }
            if (tbxModelo.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxModelo, "Este campo no puede estar vasio.");
            }
            

            return ok;
        }



        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.SoloNumeros(e, sender);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Utilidades.SoloNumeros(e, sender);
        }

        private void btnSeleccionarMarca_Click(object sender, EventArgs e)
        {
            MantenimientoMarca rc = new MantenimientoMarca();
            rc.btnBorrar.Enabled = false;
            rc.btnModificar.Enabled = false;
            rc.btnSeleccionar.Enabled = true;
            rc.ShowDialog();
            idMarca = rc.codigo_marca;
            tbxMarca.Text = rc.nombre_marca;
        }

        private void btnSeleccionarModelo_Click(object sender, EventArgs e)
        {
            MantenimientoModelo rc = new MantenimientoModelo();
            rc.btnBorrar.Enabled = false;
            rc.btnModificar.Enabled = false;
            rc.btnSeleccionar.Enabled = true;
            rc.ShowDialog();
            idModelo = rc.codigo_modelo;
            tbxModelo.Text = rc.nombre_modelo;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.SoloNumeros(e, sender);
        }
    }
}
