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
        public override void Guardar()
        {
            if (tbxCapacidad.Text.Trim()=="" || tbxDescripcion.Text.Trim()=="")
            {
                MessageBox.Show("Faltan campos por reyenar");

            }
            else if (tbxCodigo.Text.Trim()=="Nuevo")
            {
                cmd = "insert into almacen(id,descripcion,capacidad,estado)values(newid(),'"+tbxDescripcion.Text.Trim()+"','"+tbxCapacidad.Text.Trim()+"','"+chxEstado.Checked+"');";
                ds = Utilidades.EjecutarDS(cmd);
                MessageBox.Show("Guardado exitosamente");
                ////Limpiar();
                this.Close();
            }
            else
            {
                cmd = "update from almacen set descripcion='"+tbxDescripcion.Text.Trim()+"',capacidad='"+tbxCapacidad.Text.Trim()+"',estado='"+chxEstado.Checked+"' where id='"+tbxCodigo.Text.Trim()+"';";
                ds = Utilidades.EjecutarDS(cmd);
                MessageBox.Show("Guardado exitosamente");
                ////Limpiar();
                this.Close();
            }
        }
    }
}
