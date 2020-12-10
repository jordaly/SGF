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
    public partial class RegistroMarca : FormRegistros
    {
        public RegistroMarca()
        {
            InitializeComponent();
        }

        public bool ComprobarCampos()
        {
            ErrorProvider.Clear();
            bool ok = true;
            if (tbxMarca.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxMarca, "Este campo no puede estar vasio.");
            }

            return ok;
        }
        public override void Guardar()
        {
            if (ComprobarCampos())
            {
                
                    if (tbxCodigo.Text != "Nuevo")
                    {
                        cmd = "update marca set marca='"+tbxMarca.Text+"' where id='"+tbxCodigo.Text+"';";

                        ds = Utilidades.EjecutarDS(cmd);
                        MessageBox.Show("Sin Modificaciones.");
                        //Limpiar();
                        this.Close();


                    }
                    else
                    {
                        cmd = "insert into marca(id,marca,estado)values(newid(), '"+tbxMarca.Text+"','1');";

                        ds = Utilidades.EjecutarDS(cmd);
                        MessageBox.Show("Guardado exitosamente");
                        this.Close();
                    }

            }
        }
    }
}
