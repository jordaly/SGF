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
    public partial class RegistroAlmanenes : FormRegistros
    {
        public RegistroAlmanenes()
        {
            InitializeComponent();
        }



        public bool ComprobarCampos()
        {
            bool ok = true;
            if (tbxDescripcion.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxDescripcion, "Este campo no puede estar vasio.");
            }
            if (tbxCapacidad.Text == "")
            {
                ok = false;

                ErrorProvider.SetError(tbxCapacidad, "Este campo no puede estar vasio.");
            }
            return ok;
        }



        public override void Guardar()
        {
            if (ComprobarCampos())
            {


                if (tbxCodigo.Text.Trim() == "Nuevo")
                {
                    cmd = "insert into almacen(id,nombre_almacen,capacidad,estado)values(newid(),'" + tbxDescripcion.Text.Trim() + "','" + tbxCapacidad.Text.Trim() + "','1');";
                    ds = Utilidades.EjecutarDS(cmd);
                    MessageBox.Show("Guardado exitosamente");
                    ////Limpiar();
                    this.Close();
                }
                else
                {
                    cmd = "update almacen set nombre_almacen='" + tbxDescripcion.Text.Trim() + "',capacidad='" + tbxCapacidad.Text.Trim() + "' where id='" + tbxCodigo.Text.Trim() + "';";
                    ds = Utilidades.EjecutarDS(cmd);
                    MessageBox.Show("Guardado exitosamente");
                    ////Limpiar();
                    this.Close();
                }
            }
        }
    }
}
