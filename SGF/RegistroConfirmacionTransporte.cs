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
    public partial class RegistroConfirmacionTransporte : FormRegistros
    {
        public string matriculaVehiculo = "";
        public RegistroConfirmacionTransporte()
        {
            InitializeComponent();
        }
        
        public override void Guardar()
        {
            cmd = 
                "begin " +
                    "update transporte set hora_llegada=getdate(), confirmacion_cliente='"+rtbxConfirmacion.Text.Trim()+"', estado='0' where id='"+tbxCodigo.Text+"'; " +
                    "update vehiculo set transporte='0' where Matricula='"+matriculaVehiculo+"'; " +
                "end";

            ds = Utilidades.EjecutarDS(cmd);

            MessageBox.Show("Confirmacion de llegada exitosa.");

            this.Close();
        }
    }
}
