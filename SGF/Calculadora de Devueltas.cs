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
    public partial class Calculadora_de_Devueltas : FormBase
    {
        public Calculadora_de_Devueltas()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (tbxCantidadPagada.Text!="" && tbxTotalCobrar.Text!="")
            {
                double resultado = Convert.ToDouble(tbxCantidadPagada.Text.Replace('.', ',')) - Convert.ToDouble(tbxTotalCobrar.Text.Replace('.', ','));
                lbCalculo.Text = "" + resultado.ToString().Replace(',', '.');
            }
            
        }

        private void tbxCantidadPagada_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.SoloNumeros(e,sender);
        }

        private void tbxTotalCobrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.SoloNumeros(e,sender);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxTotalCobrar.Text = "";
            tbxCantidadPagada.Text = "";
            tbxCantidadPagada.Focus();
        }
    }
}
