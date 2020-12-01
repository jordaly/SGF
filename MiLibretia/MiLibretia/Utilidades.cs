using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace MiLibretia
{
    public class Utilidades
    {
        //Esta es la cadena de conexión a la base de datos en mi computador, en el tuyo puede que sea diferente 
        //Para saber cual es la tuya mira este vídeo (minuto 7:28) :  https://www.youtube.com/watch?v=UYHdpAzshqQ&pbjreload=101
        public static SqlConnection coneccion = new SqlConnection("Data Source=.;Initial Catalog=SGF;Integrated Security=True");

        //Esta clase dice si un numero mandado por parametros es o no es primo y debuelve true o false
        public static bool Primo(int n)
        {
            //Declaramos una variable entera iniciada en dos porque ya sabemos que el numero 1 es primo
            int i = 2;
            for (; i < n; i++)//Hacemos un for que recorra el numero
            {
                if (n % i == 0)//Hacemos una sentencia if para ver si el numero es divisible entre otro numero que no sea el mismo y 1
                {
                    return false;//En dado caso de que sea verdad retornamos false
                }
            }
            return true;//Si no tiene ningun divisor debuelve true
        }

        //Este metodo convierte los numeros del 1 al 999 a letras, es llamapo por otro metodo llamado numberToText y resive un parametro de tipo entero
        public static String Conv999(int N)
        {
            if (N <= 0 || N > 999) return "";//Si el numero no esta comprendido entre el interbalo se retorna una cadena basia
            if (N == 100) return "cien";//Si el numero es exactamente igual a 100 debuelve "cien"

            //Esta Matriz contiene los numeros desde el uno hasta el treinta
            string[] vu = new string[] { null, " uno ", " dos ", " tres ", " cuatro ", " cinco ", "seis ",
                "siete ", " ocho ", " nueve ", " diez ", " once ", " doce ", " trece ", " catorce ",
                " quince ", " diesiseis ", " diesisiete ", " diesiocho ", " diesinueve ", " veinte ",
                " veintiuno ", " veintidos ", " veintitres ", " veinticuatro ", " veinticinco ", " veintiseis ",
                " veintisiete ", " veintiocho ", " veintinueve " };

            //Esta cadena contiene las sentenas desde el diez hasta el noventa
            string[] vd = new string[] { null, " diez", " veinte", " treinta ", " cuarenta ", " cincuenta ",
                " sesenta ", " setenta ", " ochenta ", " noventa " };

            string CN = N.ToString().PadLeft(3, '0');//Decharamos la cadena que va a conrener el numero con los ceros a la izquierda
            string letras = "";//Declaramos la cadena letras que va a contener el resultado 
            //Dividimos el numero CN
            int C = Convert.ToInt16(CN.Substring(0, 1));
            int D = Convert.ToInt16(CN.Substring(1, 1));
            int U = Convert.ToInt16(CN.Substring(2, 1));
            int U2 = Convert.ToInt16(CN.Substring(1, 2));

            //A partir de aqui empieza el metodo de combertir de numeros a letras.
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
            //Arreglitos al resultado letras
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

        //Este es el metodo de convertir de numeros a letras para numeros mayores de 999, este programa pone los prefijos de los numeros
        //resive como parametro de entrada una cadena de caracteres
        public static string numberToText(string test)
        {
            //se declara una variable N que contenga el valor del numero
            long N = Convert.ToInt64(test);
            //Se declara una cadena que contenga el valor con los ceros a la izquierda
            string CN = N.ToString().PadLeft(15, '0');
            //Se divide dicho valor en numero  de tres en tres
            int N1 = Convert.ToInt16(CN.Substring(0, 3));
            int N2 = Convert.ToInt16(CN.Substring(3, 3));
            int N3 = Convert.ToInt16(CN.Substring(6, 3));
            int N4 = Convert.ToInt16(CN.Substring(9, 3));
            int N5 = Convert.ToInt16(CN.Substring(12, 3));
            //Se declara la variable letras para contener el resultado
            string letras = "";
            //Preguntar por cada uno de los numeros.
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
            //Arreglitos del resultado
            letras = letras.Replace("uno  millones ", "un millon ");
            letras = letras.Replace("uno  billones ", "un billon ");
            letras = letras.Replace("uno  mil ", "mil ");
            letras = letras.Replace("  ", " ");
            //Retornar letras
            return letras;
        }



        //Este metodo lee la ubicasion de un archivo cualquiera y resive como parametro una cadena con la direccion del archivo.
        //Esta direccion tiene que tener las dos varras invertidad o el signo de @ delante de las comillas.
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

        //Este metodo crea un archivo en una direccion pasada por parametros.
        //Esta direccion tiene que tener las dos barras invertidas o el signo de @ delante de las comillas.
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

        //Este metodo elimina un archivo en una ubicacion dada
        //Esta ubicasion se pasa como parametro de entrada y tiene que contener las dos barras invertidas(\\) o el signo de arroba delante de las comillas(@"c:\usuarios")
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

        //Este metodo devuelbe el formato para la imprecion de un richTextBox
        //Tiene un parametro de entrada que es una matriz entera de [5,5]
        public static string Imprimir(int[,] Matriz)
        {
            //Declaro la variable de retorno cm y la inicializo en vacia
            string cm = "";

            //Hago un ciclo for anidado con filas y columnas para [5,5]
            for (int Fila = 0; Fila < 5; Fila++)
            {
                for (int Columna = 0; Columna < 5; Columna++)
                {
                    //Le sumo a al resultado el valor de la matriz en la pocision dada [Fila,Columna] mas una tabulacion "\t"
                    cm += Matriz[Fila, Columna] + "\t";
                }

                //Cuando llega al final de las columnas le sumo una tabulacion "\n"
                cm += "\n";
            }
            //Retorno el resultado
            return cm;
        }

        //Este metodo va a generar la segunda matriz que el profesor hiso en la pisarra
        //Este metodo retorna una matriz entera y no tiene parametros de entrada
        public static int[,] GenerarM2()
        {
            //Declaro la matriz 
            int[,] m = new int[5, 5];
            //Dos bucles for para regorrer la matirz y ir asignandole los valores
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
            //Retorno el resultado
            return m;
        }

        //Este metodo devuelbe los primero 100 numeros primos
        public static string Primeros100NumerosPrimos()
        {
            //Declaro la variable resultado
            string Resultado = "";

            //Declaro dos variables de tipo entero, una para que sea el contador de los numeros y otra para el numero en si
            int contador = 0, numero = 1;

            //Declaro un bucle mientras para buscar los numeros
            while (contador < 100)
            {
                //Llamo al metodo de primo que me devuelbe true o false si el numero es primo
                if (utilidades.Primo(numero))
                {
                    //Incremento el contador 
                    contador++;
                    //Sumo el numero primo encontrado en la variable resultado mas un salto de linea "\n"
                    Resultado += numero + "\n";
                }
                //Incremento la variable numero
                numero++;

            }
            //Retorno la variable resultado
            return Resultado;
        }

        //Este metodo genera la tercera matriz que el profesor hiso en la pizarra
        //Este metodo devuelve una matris de [5,5]
        public static int[,] GenerarM3()
        {
            //Inicializamos una matriz de [5,5]
            int[,] Matriz = new int[5, 5];
            //Hacemos dos bucles for para recorrer la matriz
            for (int Filas = 0; Filas < 5; Filas++)
            {
                for (int Columnas = 0; Columnas < 5; Columnas++)
                {
                    //Comprovamos si el numero de las filas es par
                    if (Filas % 2 == 0)
                    {
                        //Si es par asignamos la siguiente ecuacion matematica a la pocision [Filas, Columnas]
                        Matriz[Filas, Columnas] = Filas * (Columnas + Columnas);
                    }
                    else
                    {
                        //En caso contrario asignamos la siguiente funcion matematica a la pocision[Filas, Columnas]
                        Matriz[Filas, Columnas] = Columnas - Filas;
                    }
                }
            }
            return Matriz;
        }


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
        public static string SoloNumeros(KeyPressEventArgs e)
        {
            char tecla = e.KeyChar;

            if (!Char.IsDigit(tecla) && (tecla != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return "Solo se permiten números";
            }
            else
                return "";
        }
    }
}
