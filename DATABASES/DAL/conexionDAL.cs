using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OracleClient;//SGBD ORACLE
using System.Data;



namespace DATABASES.DAL
{
    class conexionDAL
    {
        public OracleConnection conexion;
        private string __conexion;

        public conexionDAL()
        {
            __conexion = "DATA SOURCE = xe ; PASSWORD = elmaspro123 ; USER ID = System";
        }


        /// <summary>
        /// Abre la conexion con la BD.
        /// </summary>
        public void abrirConexion()
        {
            conexion = new OracleConnection(__conexion);
            conexion.Open();
        }

        public void cerrarConexion()
        {
            conexion.Close();
        }


        /// <summary>
        /// metodo que ejecuta una consulta, esta clase maneja la apertura y clausura a la base de datos
        /// </summary>
        /// <param name="strComando"></param>
        /// <returns></returns>
        public DataTable consultaTablaDirecta(string strComando)
        {
            abrirConexion();
            OracleDataReader dr;
            OracleCommand comando = new OracleCommand(strComando,conexion);

            dr = comando.ExecuteReader();

            var dataTable = new DataTable();

            dataTable.Load(dr);

            cerrarConexion();
            return dataTable;

        }

        /// <summary>
        /// ejecuta una instrucción de insersion, eliminación y actualización,
        /// esta clase se encarga de manejar las aperturas y clausuras de la conexion.
        /// </summary>
        /// <param name="strComando"></param>
        public void EjecutarSQLDirecto(string strComando)
        {
            abrirConexion();
            try
            {
                OracleCommand comando = new OracleCommand(strComando,conexion);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                cerrarConexion();
            }
        }


        public bool ejecutarComandoSinRetornoDatos(string strComando)
        {
            try
            {
                OracleCommand comando = new OracleCommand();

                comando.CommandText = strComando;
                comando.Connection = conexion;

                abrirConexion();
                comando.ExecuteNonQuery();
                cerrarConexion();

                return true;
            }
            catch
            {
                return false;
            }
        }



        /// <summary>
        /// Hace una prueba de conexion a la BD.
        /// Si se conecta devuelve true, de lo contrario false.
        /// </summary>
        /// <returns></returns>
        public bool TestConexion()
        {
            try
            {
                abrirConexion();
                return true;
            }
            catch 
            {
                return false;
            }
        }


        public DataSet EjecutarSentencia(OracleCommand oraComando)
        {
            DataSet DS = new DataSet();
            OracleDataAdapter adapdator = new OracleDataAdapter();
            conexion = new OracleConnection(__conexion);

            try
            {
                OracleCommand comando = new OracleCommand();
                comando = oraComando;
                comando.Connection = conexion;
                adapdator.SelectCommand = comando;
                conexion.Open();
                adapdator.Fill(DS);
                conexion.Close();
                return DS;
            }
            catch (Exception)
            {
                return DS;
            }
        }



    }
}
