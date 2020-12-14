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
    public partial class RegistroModelo : FormRegistros
    {
        public RegistroModelo()
        {
            InitializeComponent();
        }

        public override void Guardar()
        {
            if (ComprobarCampos())
            {
                if (tbxCodigo.Text=="Nuevo")
                {
                    cmd = "insert into modelo(modelo,consumoKpG,capacidad,valor,estado)values('"+tbxNombre.Text.Trim()+"','"+tbxConsumo.Text+"','"+tbxCantidad.Text+"','"+tbxValor.Text+"','1');";
                    ds = Utilidades.EjecutarDS(cmd);
                    MessageBox.Show("Se ha guardado exitosamente.");
                    this.Close();
                }
                else
                {
                    cmd = "update modelo set modelo='"+tbxNombre.Text.Trim()+"',consumoKpG='"+tbxConsumo.Text+"',capacidad='"+tbxCantidad.Text.Trim()+"',valor='"+tbxValor.Text+"' where id='"+tbxCodigo.Text+"';";
                    ds = Utilidades.EjecutarDS(cmd);
                    MessageBox.Show("Se ha modificado exitosamente.");
                    this.Close();
                }
            }
        }









        public bool ComprobarCampos()
        {

            ErrorProvider.Clear();
            bool ok = true;
            if (tbxNombre.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxNombre, "Este campo no puede estar vasio.");
            }
            if (tbxConsumo.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxConsumo, "Este campo no puede estar vasio.");
            }
            if (tbxCantidad.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxCantidad, "Este campo no puede estar vasio.");
            }
            if (tbxValor.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxValor, "Este campo no puede estar vasio.");
            }



            return ok;
        }

        private void tbxValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.SoloNumeros(e, sender);
        }

        private void tbxConsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.SoloNumeros(e, sender);
        }
    }
}
