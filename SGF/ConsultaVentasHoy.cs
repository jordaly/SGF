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
    public partial class ConsultaVentasHoy : FormBase
    {
        public ConsultaVentasHoy()
        {
            InitializeComponent();
            cmd = "select sum(ganancias) as gananciahoy,sum(ventas_totales) as ventashoy from caja where fecha_in<getdate() and fecha_fin>getdate();";
            ds = Utilidades.EjecutarDS(cmd);
            if (ds.Tables[0].Rows.Count>0)
            {
                lbVentas.Text = ds.Tables[0].Rows[0]["ventashoy"].ToString();
                lbGanancias.Text = ds.Tables[0].Rows[0]["gananciahoy"].ToString();
            }
            
            
        }
    }
}
