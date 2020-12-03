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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            this.tbNombre.Focus();
            nombre = tbNombre.Text;
        }
        public int intentos = 10;
        public string nombre;
        public bool salir = false;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(tbNombre.Text.Trim()) || String.IsNullOrEmpty(tbContraseña.Text.Trim()))
                return;

            DataSet ds = new DataSet();
            string cmd = string.Format("select * from usuario where usuario = '{0}'",
                tbNombre.Text.Trim());
            ds = Utilidades.EjecutarDS(cmd);

            //MessageBox.Show(ds.Tables[0].Rows[0]["Estatus"].ToString());
            //nombre = tbNombre.Text;

            if (Convert.ToBoolean(ds.Tables[0].Rows[0]["estado"]))
            {

                cmd = string.Format("select * from usuario where usuario = '{0}' and password = '{1}'",
                tbNombre.Text.Trim(), tbContraseña.Text.Trim());
                //MessageBox.Show(cmd);

                ds = Utilidades.EjecutarDS(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    //SGF.FrmMenu vj = new SGF.FrmMenu();
                    //this.Hide();
                    //vj.toolStripStatusLabel.Text = tbNombre.Text.Trim();
                    //vj.nivelUsuario = Convert.ToInt16(ds.Tables[0].Rows[0]["Nivel"].ToString().Trim());
                    //MessageBox.Show(ds.Tables[0].Rows[0]["Nivel"].ToString().Trim());
                    //vj.cambiarNiveles();
                    //MessageBox.Show("Bienvenido " + tbNombre.Text);
                    //vj.Show();
                    codigo_usuario = ds.Tables[0].Rows[0]["id"].ToString();
                    this.Close();
                    //MessageBox.Show("Felicidades, has iniciado seción correctamente");


                    //this.Visible = false;
                }
                else
                {
                    string mensaje = "El usuario o la contraseña son incorrectos.";
                    if (nombre == tbNombre.Text)
                    {
                        intentos--;
                    }
                    else
                    {
                        nombre = tbNombre.Text;
                        intentos = 9;
                    }
                    if (intentos <= 3)
                    {
                        mensaje += "\nSolo quedan " + intentos + " intentos antes de bloquear la cuenta.";
                        if (intentos == 0)
                        {
                            cmd = string.Format("select * from usuario where usuario = '{0}'", tbNombre.Text.Trim());
                            ds = Utilidades.EjecutarDS(cmd);
                            if (ds.Tables[0].Rows[0]["Nivel"].ToString().Trim() != "0")
                            {
                                cmd = string.Format("Update usuarios Set usuario = '0' where id = '{0}'", ds.Tables[0].Rows[0]["id"].ToString().Trim());
                                ds = Utilidades.EjecutarDS(cmd);
                            }
                            else
                            {
                                MessageBox.Show("El usuario " + ds.Tables[0].Rows[0]["usuario"].ToString().Trim() + " no puede ser bloqueado.");
                            }

                        }
                    }
                    MessageBox.Show(mensaje);

                }
            }
            else
            {
                MessageBox.Show("El usuario " + tbNombre.Text.Trim() + " esta inabilitado por motivos de seguridad," +
                    "\npara reactivarlo Contacte con el usuario administrador");
            }

        }

        public string codigo_usuario= "";
        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbNombre.Text.Trim()) || String.IsNullOrEmpty(tbContraseña.Text.Trim()))
                return;

            DataSet ds = new DataSet();
            string cmd = string.Format("select * from usuario where usuario = '{0}'",
                tbNombre.Text.Trim());
            ds = Utilidades.EjecutarDS(cmd);

            //MessageBox.Show(ds.Tables[0].Rows[0]["Estatus"].ToString());
            //nombre = tbNombre.Text;

            if (Convert.ToBoolean(ds.Tables[0].Rows[0]["estado"]))
            {

                cmd = string.Format("select * from usuario where usuario = '{0}' and password = '{1}'",
                tbNombre.Text.Trim(), tbContraseña.Text.Trim());
                //MessageBox.Show(cmd);

                ds = Utilidades.EjecutarDS(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    //SGF.FrmMenu vj = new SGF.FrmMenu();
                    //this.Hide();
                    //vj.toolStripStatusLabel.Text = tbNombre.Text.Trim();
                    //vj.nivelUsuario = Convert.ToInt16(ds.Tables[0].Rows[0]["Nivel"].ToString().Trim());
                    //MessageBox.Show(ds.Tables[0].Rows[0]["Nivel"].ToString().Trim());
                    //vj.cambiarNiveles();
                    codigo_usuario = ds.Tables[0].Rows[0]["id"].ToString();
                    MessageBox.Show("Bienvenido " + tbNombre.Text);
                    this.Close();
                    //vj.Show();
                    //MessageBox.Show("Felicidades, has iniciado seción correctamente");


                    //this.Visible = false;
                }
                else
                {
                    string mensaje = "El usuario o la contraseña son incorrectos.";
                    if (nombre == tbNombre.Text)
                    {
                        intentos--;
                    }
                    else
                    {
                        nombre = tbNombre.Text;
                        intentos = 9;
                    }
                    if (intentos <= 3)
                    {
                        mensaje += "\nSolo quedan " + intentos + " intentos antes de bloquear la cuenta.";
                        if (intentos == 0)
                        {
                            cmd = string.Format("select * from usuario where usuario = '{0}'", tbNombre.Text.Trim());
                            ds = Utilidades.EjecutarDS(cmd);
                            if (ds.Tables[0].Rows[0]["Nivel"].ToString().Trim() != "0")
                            {
                                cmd = string.Format("Update usuarios Set usuario = '0' where id = '{0}'", ds.Tables[0].Rows[0]["id"].ToString().Trim());
                                ds = Utilidades.EjecutarDS(cmd);
                            }
                            else
                            {
                                MessageBox.Show("El usuario " + ds.Tables[0].Rows[0]["usuario"].ToString().Trim() + " no puede ser bloqueado.");
                            }

                        }
                    }
                    MessageBox.Show(mensaje);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salir = true;
            this.Close();
        }
    }
}
