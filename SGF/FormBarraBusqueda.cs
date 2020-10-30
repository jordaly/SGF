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
    public partial class FormBarraBusqueda : FormBase
    {
        public string parametro;
        
        public FormBarraBusqueda()
        {
            InitializeComponent();
        }

        private void FormBarraBusqueda_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            parametro = tbxBuscar.Text.Trim();
            this.Close();
        }
    }
}
