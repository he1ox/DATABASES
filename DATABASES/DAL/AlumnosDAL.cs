using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OracleClient;

namespace DATABASES.DAL
{
    class AlumnosDAL
    {
        conexionDAL conexion;

        public AlumnosDAL()
        {
            conexion = new conexionDAL();
        }


        //INFO DATA GRID VIEW
        public DataSet MostrarAlumnos()
        {
            OracleCommand comando = new OracleCommand("SELECT * FROM tb_alumnos");


            return conexion.EjecutarSentencia(comando);
        }


    }
}
