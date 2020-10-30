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
    public partial class FormProcesos : FormBase
    {
        
        public FormProcesos()
        {
            InitializeComponent();
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
            Modificar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Borrar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
