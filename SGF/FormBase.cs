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
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }
        public string cmd = "";
        public string BuscarDatos = "";
        public virtual void Modificar() { }
        public virtual void Nuevo() { }
        public virtual void Borrar() { }
        public virtual void Buscar() { }
        public virtual void Guardar() { }


        public DataSet ds = new DataSet();
        public bool PuedeModificar { set; get; }
        public bool PuedeNuevo { set; get; }
        public bool PuedeBorrar { set; get; }
        public bool PuedeBuscar { set; get; }
        private void FormBase_Load(object sender, EventArgs e)
        {

        }
    }
}
