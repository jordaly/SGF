﻿using System;
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
    public partial class RegistroReparacionVehiculo : FormRegistros
    {
        public RegistroReparacionVehiculo()
        {
            InitializeComponent();
        }

        public override void Guardar()
        {
            if (ComprobarCampos())
            {
                if (tbxCodigo.Text != "Nuevo")
                {
                    //cmd = "update reparacion set taller='" + tbxNombre.Text + "' where id='" + tbxCodigo.Text + "';";

                    ds = Utilidades.EjecutarDS(cmd);
                    MessageBox.Show("Sin Modificaciones.");
                    //Limpiar();
                    this.Close();


                }
                else
                {
                    //cmd = "insert into tallleres(taller,estado)values(" + tbxNombre.Text + "','1');";

                    ds = Utilidades.EjecutarDS(cmd);
                    MessageBox.Show("Guardado exitosamente");
                    this.Close();
                }
            }
        }




        public string idTaller = "";
        private void btnSeleccionarTaller_Click(object sender, EventArgs e)
        {
            MantenimientoTalleres rc = new MantenimientoTalleres();
            rc.btnBorrar.Enabled = false;
            rc.btnModificar.Enabled = false;
            rc.btnSeleccionar.Enabled = true;
            //rc.transporte = true;
            rc.ShowDialog();
            tbxTaller.Text = rc.nombre_taller;
            idTaller = rc.codigo_taller;
        }

        private void btnSeleccionarMatricula_Click(object sender, EventArgs e)
        {
            MantenimientoVehiculos rc = new MantenimientoVehiculos();
            rc.btnBorrar.Enabled = false;
            rc.btnModificar.Enabled = false;
            rc.btnSeleccionar.Enabled = true;
            //rc.transporte = true;
            rc.ShowDialog();
            tbxMatricula.Text = rc.matricula;
            //idTaller = rc.codigo_taller;
        }



        public bool ComprobarCampos()
        {
            ErrorProvider.Clear();
            bool ok = true;
            if (tbxMatricula.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxMatricula, "Este campo no puede estar vasio.");
            }
            if (tbxTaller.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxTaller, "Este campo no puede estar vasio.");
            }
            if (rtbxParrafo.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(rtbxParrafo, "Este campo no puede estar vasio.");
            }


            return ok;
        }
    }
}
