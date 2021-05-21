using MySql.Data.MySqlClient;
using Snake_Proyecto.Estructura_No._1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Proyecto.BaseDatos
{
    class ClsConexion_2
    {
        MySqlConnection conexionBD;
        private String cadenaConexion { get; }

        public ClsConexion_2()
        {
            string servidor = "localhost"; //Nombre o ip del servidor de MySQL
            string bd = "punteos"; //Nombre de la base de datos
            string usuario = "root"; //Usuario de acceso a MySQL
            string password = ""; //Contraseña de usuario de acceso a MySQL


            cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";
        }

        public void cerraConexion()
        {
            conexionBD.Close();
        }

        public void abrirConexion()
        {
            conexionBD = new MySqlConnection(cadenaConexion);
            conexionBD.Open();
        }

        public Object mostrarPunteo_1()
        {
            string servidor = "localhost"; //Nombre o ip del servidor de MySQL
            string bd = "punteos"; //Nombre de la base de datos
            string usuario = "root"; //Usuario de acceso a MySQL
            string password = ""; //Contraseña de usuario de acceso a MySQL
            string datos = null; //Variable para almacenar el resultado

            //Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

            //Instancia para conexión a MySQL, recibe la cadena de conexión
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            MySqlDataReader reader = null; //Variable para leer el resultado de la consulta
            try
            {
                string consulta = "SELECT * from point_2"; //Consulta a MySQL (Muestra las bases de datos que tiene el servidor)
                MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader

                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {

                    datos += " " + reader.GetString(1) + "\n";
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error Al mostrar los datos" + ex.Message); //Si existe un error aquí muestra el mensaje
            }

            return datos;
        }



        public DataTable consultaTablaDirecta(String sqll)
        {
            abrirConexion();
            MySqlDataReader dr;
            MySqlCommand comm = new MySqlCommand(sqll, conexionBD);
            dr = comm.ExecuteReader();

            var dataTable = new DataTable();
            dataTable.Load(dr);
            cerraConexion();
            return dataTable;
        }


        //insertar animales
        public void EjecutaSQLDirecto(String sqll)
        {
            abrirConexion();
            try
            {

                MySqlCommand comm = new MySqlCommand(sqll, conexionBD);
                comm.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                cerraConexion();
            }
        }

    }
}
