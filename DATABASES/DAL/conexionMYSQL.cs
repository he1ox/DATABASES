using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DATABASES.DAL
{
    class conexionMYSQL
    {
        static string sv = "127.0.0.1";
        static string puerto = "3306";
        static string user = "root";
        static string psswd = "elmaspro123";
        static string db = "jorgedb";

        private string cadenaConexion = $"server={sv}; port={puerto}; userid={user}; password={psswd}; database={db}";

        MySqlConnection conexion;


        public MySqlConnection EstablecerConexion()
        {
            this.conexion = new MySqlConnection(this.cadenaConexion);
            return this.conexion;
        }

        /// <summary>
        /// METODO INSERT, DELETE, UPDATE.
        /// </summary>
        /// <param name="strComando"></param>
        /// <returns></returns>
        public bool ejecutarComandoSinRetornoDatos(string strComando)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();

                comando.CommandText = strComando;
                comando.Connection = this.EstablecerConexion();

                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// select (retorna datos) 
        /// </summary>
        /// <param name="sqlComando"></param>
        /// <returns></returns>
        public DataSet EjecutarSentencia(MySqlCommand sqlComando)
        {
            DataSet DS = new DataSet();
            MySqlDataAdapter adaptador = new MySqlDataAdapter();


            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando = sqlComando;
                comando.Connection = EstablecerConexion();
                adaptador.SelectCommand = comando;
                conexion.Open();
                adaptador.Fill(DS);
                conexion.Close();
                return DS;
            }
            catch (Exception)
            {
                return DS;
            }
        }







        /// <summary>
        /// REGRESA TRUE O FALSE, DEPENDE SI SE LOGRA CONECTAR.
        /// </summary>
        /// <returns></returns>
        public bool testBD()
        {
            try
            {
                EstablecerConexion();
                return true;
            }
            catch 
            {
                return false;
            }

        }

    }
}
