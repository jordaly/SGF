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
    public partial class principal : FormBase
    {
        public principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cmd = "select * from tipo_NCF where tipo='Facturas de Crédito Fiscal'";
            //ds = Utilidades.EjecutarDS(cmd);
            //string idTipo_NCF = ds.Tables[0].Rows[0]["numero"].ToString();
            //cmd = "select * from NCF";
            //ds = Utilidades.EjecutarDS(cmd);
            //string ncf = ds.Tables[0].Rows[0]["serie"].ToString() + idTipo_NCF + ds.Tables[0].Rows[0]["secuencia"].ToString().PadLeft((9 - ds.Tables[0].Rows[0]["secuencia"].ToString().Length), '0');
            //string idNCF = ds.Tables[0].Rows[0]["id"].ToString();
            //cmd = "update NCF set secuencia+=1 where id='" + idNCF + "'";
            //ds = Utilidades.EjecutarDS(cmd);
            //MessageBox.Show(root);
            //richTextBox1.Text = root;
            //root=root.Replace(@"\bin\Debug\SGF.exe", @"\");
            richTextBox1.Text = root;
        }

        private void principal_Load(object sender, EventArgs e)
        {

        }
    }
}
