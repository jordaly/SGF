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
    public partial class RegistroTalleres : FormRegistros
    {
        public RegistroTalleres()
        {
            InitializeComponent();
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

            return ok;
        }
        public override void Guardar()
        {
            if (ComprobarCampos())
            {
                if (tbxCodigo.Text != "Nuevo")
                {
                    cmd = "update talleres set taller='" + tbxNombre.Text + "' where id='" + tbxCodigo.Text + "';";

                    ds = Utilidades.EjecutarDS(cmd);
                    MessageBox.Show("Sin Modificaciones.");
                    //Limpiar();
                    this.Close();


                }
                else
                {
                    cmd = "insert into talleres(taller,estado)values('"+ tbxNombre.Text + "','1');";

                    ds = Utilidades.EjecutarDS(cmd);
                    MessageBox.Show("Guardado exitosamente");
                    this.Close();
                }
            }
        }
    }
}
