using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SGF
{
    class Utilidades
    {
        //Esta es la cadena de conexión para mi base de datos local, en tu computadora puede que sea diferente
        //Para saber cual es la cadena de conexión en tu coputadora mira en sigiente vídeo (minuto 7:28) : https://www.youtube.com/watch?v=wzA5ZEJ6lvk
        public static SqlConnection coneccion = new SqlConnection("Data Source=.;Initial Catalog=SGF;Integrated Security=True");

        public static void AbrirFormEnPanel(object Formhijo, Panel panelContenedor, PictureBox picture)
        {
            panelContenedor.Controls.Clear();

            Form formulario = Formhijo as Form;
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(picture);
            panelContenedor.Controls.Add(formulario);
            //this.panelContenedor.Tag = formulario;
            formulario.BringToFront();
            formulario.Show();
        }
        public static bool Primo(int n)
        {

            int i = 2;
            for (; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }


        public static String Conv999(int N)
        {
            if (N <= 0 || N > 999) return "";
            if (N == 100) return "cien";


            string[] vu = new string[] { null, " uno ", " dos ", " tres ", " cuatro ", " cinco ", "seis ",
                "siete ", " ocho ", " nueve ", " diez ", " once ", " doce ", " trece ", " catorce ",
                " quince ", " diesiseis ", " diesisiete ", " diesiocho ", " diesinueve ", " veinte ",
                " veintiuno ", " veintidos ", " veintitres ", " veinticuatro ", " veinticinco ", " veintiseis ",
                " veintisiete ", " veintiocho ", " veintinueve " };


            string[] vd = new string[] { null, " diez", " veinte", " treinta ", " cuarenta ", " cincuenta ",
                " sesenta ", " setenta ", " ochenta ", " noventa " };

            string CN = N.ToString().PadLeft(3, '0');
            string letras = "";

            int C = Convert.ToInt16(CN.Substring(0, 1));
            int D = Convert.ToInt16(CN.Substring(1, 1));
            int U = Convert.ToInt16(CN.Substring(2, 1));
            int U2 = Convert.ToInt16(CN.Substring(1, 2));


            if (C > 0) letras += vu[C] + "cientos";
            if (U2 > 0)
            {
                if (U2 < 30)
                {
                    letras += vu[U2];
                }
                else
                {
                    letras += vd[D];
                    if (U > 0)
                        letras += "y " + vu[U];

                }
            }

            letras = letras.ToLower().Replace("  ", " ");
            letras = letras.Replace("cinco cientos", "quinientos");
            letras = letras.Replace("uno cientos", "ciento");
            letras = letras.Replace("nueve cientos", "novecientos");
            letras = letras.Replace("siete cientos", "setecientos ");
            //debolver letras
            return letras;
        }

        internal static void numberToText(short v)
        {
            throw new NotImplementedException();
        }


        public static string numberToText(string test)
        {

            long N = Convert.ToInt64(test);

            string CN = N.ToString().PadLeft(15, '0');

            int N1 = Convert.ToInt16(CN.Substring(0, 3));
            int N2 = Convert.ToInt16(CN.Substring(3, 3));
            int N3 = Convert.ToInt16(CN.Substring(6, 3));
            int N4 = Convert.ToInt16(CN.Substring(9, 3));
            int N5 = Convert.ToInt16(CN.Substring(12, 3));

            string letras = "";

            if (N1 > 0)
            {
                letras += Conv999(N1) + " billones ";

            }
            if (N2 > 0)
            {

                letras += Conv999(N2) + " mil ";

            }
            if (N3 > 0 || (test.Length > 6 && test.Length < 13))
            {
                letras += Conv999(N3) + " millones ";

            }
            if (N4 > 0)
            {
                letras += Conv999(N4) + " mil ";
            }
            if (N5 > 0)
            {
                letras += Conv999(N5);
            }

            letras = letras.Replace("uno  millones ", "un millon ");
            letras = letras.Replace("uno  billones ", "un billon ");
            letras = letras.Replace("uno  mil ", "mil ");
            letras = letras.Replace("  ", " ");

            return letras;
        }


        public static void Reproducir(String cadena)
        {
            String[] arreglo = cadena.Split();
            SoundPlayer sonido;
            try
            {
                for (int i = 0; i < arreglo.Length; i++)
                {

                    sonido = new SoundPlayer("C:\\Users\\Jorda\\OneDrive\\Documents\\archivos que entaban en el escritorio\\AudioNumeros\\" + arreglo[i] + ".wav");
                    sonido.PlaySync();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }


        public static String LeerArchivo(String direccion)
        {
            String Resultado = "";
            try
            {
                if (File.Exists(direccion))
                {
                    StreamReader Leer = new StreamReader(direccion);
                    while (!Leer.EndOfStream)
                    {
                        Resultado = Leer.ReadLine() + "\n\r";

                    }

                }
                else
                {
                    MessageBox.Show("El archivo " + direccion + " no existe.");
                }
            }
            catch (Exception)
            {

                throw;
            }


            return Resultado;
        }


        public static void CrearArchivo(String direccion)
        {
            try
            {
                if (File.Exists(direccion))
                {
                    MessageBox.Show("El archivo " + direccion + " Ya exsiste.");
                }
                else
                {
                    File.Create(direccion);
                    MessageBox.Show("El archivo ha sido creado.");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public static void EliminarArchivo(String direccion)
        {
            try
            {
                if (File.Exists(direccion))
                {
                    File.Delete(direccion);
                    MessageBox.Show("El archivo " + direccion + " ha sido eliminado");
                }
                else
                {
                    MessageBox.Show("El archivo " + direccion + " no existe.");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public static string Imprimir(int[,] Matriz)
        {

            string cm = "";


            for (int Fila = 0; Fila < 5; Fila++)
            {
                for (int Columna = 0; Columna < 5; Columna++)
                {

                    cm += Matriz[Fila, Columna] + "\t";
                }


                cm += "\n";
            }

            return cm;
        }


        public static int[,] GenerarM2()
        {

            int[,] m = new int[5, 5];

            for (int Filas = 0; Filas < 5; Filas++)
            {
                for (int Columnas = 0; Columnas < 5; Columnas++)
                {
                    if (Filas == Columnas)
                    {
                        m[Filas, Columnas] = 1;
                    }
                    else if (Filas + Columnas == 4)
                    {
                        m[Filas, Columnas] = 2;
                    }
                    else if (Filas < Columnas)
                    {
                        if (Filas + Columnas < 5)
                        {
                            m[Filas, Columnas] = 3;
                        }
                        else
                        {
                            m[Filas, Columnas] = 4;
                        }
                    }
                    else if (Filas < Columnas)
                    {
                        if (Filas + Columnas <= 3)
                        {
                            m[Filas, Columnas] = 6;
                        }
                        else
                        {
                            m[Filas, Columnas] = 5;
                        }
                    }
                }
            }

            return m;
        }


        public static string Primeros100NumerosPrimos()
        {

            string Resultado = "";


            int contador = 0, numero = 1;


            while (contador < 100)
            {

                if (Utilidades.Primo(numero))
                {

                    contador++;

                    Resultado += numero + "\n";
                }

                numero++;

            }

            return Resultado;
        }


        public static int[,] GenerarM3()
        {

            int[,] Matriz = new int[5, 5];

            for (int Filas = 0; Filas < 5; Filas++)
            {
                for (int Columnas = 0; Columnas < 5; Columnas++)
                {

                    if (Filas % 2 == 0)
                    {

                        Matriz[Filas, Columnas] = Filas * (Columnas + Columnas);
                    }
                    else
                    {

                        Matriz[Filas, Columnas] = Columnas - Filas;
                    }
                }
            }
            return Matriz;
        }
        //public static int ValidarForm(Control objForm, ErrorProvider errorProvider1)
        //{
        //    int Errores = 0;
        //    foreach (Control item in objForm.Controls)
        //    {
        //        if (item.Controls.Count > 0)
        //            ValidarForm(item, errorProvider1);

        //        if (item is MiTextbox)
        //        {
        //            MiTextbox obj = (MiTextbox)item;

        //            if (obj.Validar)
        //            {
        //                if (String.IsNullOrEmpty(obj.Text.Trim()))
        //                {
        //                    errorProvider1.SetError(obj, "Campo obligatorio!");
        //                    Errores++;
        //                }
        //                else
        //                    errorProvider1.SetError(obj, "");
        //            }
        //        }
        //    }
        //    return Errores;
        //}

        public static void ModificarArchivo(string datos, string rarchivo)
        {
            string rtemporal = @"C:\temporal.txt";

            using (StreamWriter temporal = new StreamWriter(rtemporal))
            {
                using (StreamReader archivo = new StreamReader(rarchivo))
                {
                    String linea;

                    while ((linea = archivo.ReadLine()) != null)
                    {
                        //Condicion para modificar
                        /*string[] datos = linea.Split(',');
                        if (datos[0] != "w")
                        {
                            temporal.WriteLine(linea);
                        }*/
                    }
                }
            }
        }
        public static void CrearArchivo(string nombre, string datos)
        {
            TextWriter archivo;
            string rarchivo = @"C:\" + nombre + ".txt";

            if (File.Exists(rarchivo))
            {
                archivo = File.AppendText(rarchivo);
                archivo.WriteLine(datos);
                archivo.Close();
            }
            else
            {
                archivo = new StreamWriter(rarchivo);
                archivo.WriteLine(datos);
                archivo.Close();
            }
        }
        public static string ConectarBD()
        {
            try
            {
                if (coneccion.State != ConnectionState.Open)
                {
                    coneccion.Open();
                    return "la coneccion ha establesido";
                }
                else
                    return "La coneccion ya esta establesida";
            }
            catch (Exception ex)
            {
                return ex + "";
            }
        }
        public static string DesconectarBD()
        {

            try
            {
                if (coneccion.State != ConnectionState.Open)
                {
                    return "la coneccion ya esta cerrada";
                }
                else
                {
                    coneccion.Close();
                    return "La coneccion se ha cerrado";
                }
            }
            catch (Exception ex)
            {
                return ex + "";
            }
        }
        public static DataSet EjecutarDS(string comando)
        {
            try
            {
                ConectarBD();
                DataSet DS = new DataSet();
                SqlDataAdapter Adaptador = new SqlDataAdapter(comando, coneccion);
                Adaptador.Fill(DS);
                return DS;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static void SoloNumeros(KeyPressEventArgs e,object sender)
        {
            //char tecla = e.KeyChar;
            if ((char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) ||  ((e.KeyChar == '.')&&((sender as TextBox).Text.IndexOf('.') == -1)))
            {
                //MessageBox.Show("" + (sender as TextBox).Text.IndexOf('.'));
                //e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }


            //// If you want, you can allow decimal (float) numbers
            //if (((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)))
            //{
            //    e.Handled = true;
            //}

            //if (!Char.IsDigit(tecla) && (tecla != Convert.ToChar(Keys.Back)))
            //{
            //    e.Handled = true;
            //    return "Solo se permiten números";
            //}
            //else
            //    return "";
        }

        public static void SoloNumerosEnteros(KeyPressEventArgs e, object sender)
        {
            //char tecla = e.KeyChar;
            if ((char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)))
            {
                //MessageBox.Show("" + (sender as TextBox).Text.IndexOf('.'));
                //e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }


            //// If you want, you can allow decimal (float) numbers
            //if (((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)))
            //{
            //    e.Handled = true;
            //}

            //if (!Char.IsDigit(tecla) && (tecla != Convert.ToChar(Keys.Back)))
            //{
            //    e.Handled = true;
            //    return "Solo se permiten números";
            //}
            //else
            //    return "";
        }


        public static int ValarCheckBox(bool i)
        {
            if (i)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
