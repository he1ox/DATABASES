using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OracleClient;
using DATABASES.BLL;
using MySql.Data.MySqlClient;

namespace DATABASES.DAL
{
    class AlumnosDAL
    {
        conexionDAL conexion;
        conexionMYSQL mysqlconexion;

        public AlumnosDAL()
        {
            conexion = new conexionDAL();
            mysqlconexion = new conexionMYSQL();
        }


        //INFO DATA GRID VIEW
        public DataSet MostrarAlumnos()
        {
            OracleCommand comando = new OracleCommand("SELECT * FROM tb_alumnos");

            return conexion.EjecutarSentencia(comando);
        }


        public bool Agregar(AlumnosBLL oAlumnoBLL)
        {
            OracleCommand comando = new OracleCommand("INSERT INTO tb_alumnos VALUES(@Correlativo,@Nombre,@p1,@p2,@p3)");

            comando.Parameters.Add("@Correlativo", OracleType.Number).Value = oAlumnoBLL.ID;
            comando.Parameters.Add("@Nombre", OracleType.VarChar).Value = oAlumnoBLL.nombre;
            comando.Parameters.Add("@p1", OracleType.Number).Value = oAlumnoBLL.parcialUno;
            comando.Parameters.Add("@p2", OracleType.Number).Value = oAlumnoBLL.parcialDos;
            comando.Parameters.Add("@p3", OracleType.Number).Value = oAlumnoBLL.parcialTres;

            return conexion.ejecutarComandoSinRetornoDatos(comando);
        }


        //MySQL
        public DataSet MostrarDGV()
        {
            MySqlCommand comando = new MySqlCommand("SELECT * FROM tb_alumnos");

            return mysqlconexion.EjecutarSentencia(comando);
        }

        public bool EliminarRegistros()
        {
            return mysqlconexion.ejecutarComandoSinRetornoDatos("DELETE FROM tb_alumnos");
        }

    }
}
