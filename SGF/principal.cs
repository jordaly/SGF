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
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SGF.MantenimientoUsuarios vj = new SGF.MantenimientoUsuarios();
            this.Hide();
            vj.Show();
            this.Visible = false;
        }

        private void principal_Load(object sender, EventArgs e)
        {

        }
    }
}
