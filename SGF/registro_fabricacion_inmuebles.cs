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
    public partial class registro_fabricacion_inmuebles : FormRegistros
    {
        public registro_fabricacion_inmuebles()
        {
            InitializeComponent();
            this.Enabled = true;
            lbNumero_tabla.Text = "Días: 1";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lbNumero_tabla.Text = "Días: " + trackBar1.Value.ToString();
        }
    }
}
