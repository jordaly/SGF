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
    public partial class FormProcesos : FormBase
    {
        
        public FormProcesos()
        {
            InitializeComponent();
            dgvPadre.Focus();
            btnBuscar.BackColor = Color.White;
            cbxBuscar.BackColor = Color.White;
        }
        public void refrescarDatos(string Buscar)
        {
            ds = Utilidades.EjecutarDS(Buscar);
            dgvPadre.DataSource = ds.Tables[0];
        }

        private void FormProcesos_Load(object sender, EventArgs e)
        {

        }
        //abstract class botones
        //{
        //    public abstract void Modificar();
        //    public abstract void Nuevo();
        //    public abstract void Borrar();
        //    public abstract void buscar();
        //}
        
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPadre.Rows.Count > 0)
            {
                Modificar();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvPadre.Rows.Count > 0)
            {
                Borrar();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvPadre.Rows.Count > 0)
            {
                Seleccionar();
            }
        }
    }
}
