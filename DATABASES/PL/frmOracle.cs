using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OracleClient; //SGBD ORACLE
using DATABASES.DAL;
using System.Data;


namespace DATABASES.PL
{
    public partial class frmOracle : Form
    {
        OracleConnection conexion;
        clsCSV archivoCSV;
        conexionDAL ora;
        AlumnosDAL oAlumnosDal;


        public frmOracle()
        {
            InitializeComponent();
            conexion = new OracleConnection("DATA SOURCE = xe ; PASSWORD = elmaspro123 ; USER ID = System");
            archivoCSV = new clsCSV();
            ora = new conexionDAL();
            oAlumnosDal = new AlumnosDAL();
            UpdateGrid();
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Conexion {TestConexion()}");
            MessageBox.Show($"Conexion : {ora.TestConexion()}");


            //DataTable dt = ora.consultaTablaDirecta("SELECT * FROM tb_alumnos");

            //foreach (DataRow dr in dt.Rows)
            //{
            //    listBox1.Items.Add(dr[1].ToString());
            //}


        }



        private void btnCSV_Click(object sender, EventArgs e)
        {
            string[,] csvAlumnos = archivoCSV.buscarCSV();
            string nombre;
            int correlativo = 0;
            int parcialUno = 0;
            int parcialDos = 0;
            int parcialTres = 0;
            

            for (int i = 1; i < csvAlumnos.GetLength(0); i++)
            {
                correlativo = Convert.ToInt32(csvAlumnos[i, 0]);
                nombre = csvAlumnos[i, 1];
                parcialUno = Convert.ToInt32(csvAlumnos[i, 2]);
                parcialDos= Convert.ToInt32(csvAlumnos[i, 3]);
                parcialTres = Convert.ToInt32(csvAlumnos[i, 4]);

                ora.EjecutarSQLDirecto($"INSERT INTO tb_alumnos VALUES({correlativo},'{nombre}',{parcialUno},{parcialDos},{parcialTres})");
            }
            UpdateGrid();
        }





        //Funcion que checa la conexion a BD.
        public bool TestConexion()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }


       

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }




        public void UpdateGrid()
        {
            dataGridView1.DataSource = oAlumnosDal.MostrarAlumnos().Tables[0];
            dataGridView1.Columns[0].HeaderText = "Correlativo";
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[2].HeaderText = "Parcial Uno";
            dataGridView1.Columns[3].HeaderText = "Parcial Dos";
            dataGridView1.Columns[4].HeaderText = "Parcial Tres";
        }
    }
}
