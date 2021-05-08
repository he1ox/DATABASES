using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using DATABASES.DAL;

namespace DATABASES.PL
{
    public partial class MySQL : Form
    {
        conexionMYSQL conexion;
        AlumnosDAL oAlumnosDAL;
        clsCSV archivoCSV;
        public MySQL()
        {
            InitializeComponent();
            conexion = new conexionMYSQL();
            oAlumnosDAL = new AlumnosDAL();
            MostrarGRID();
            archivoCSV = new clsCSV();
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"ESTADO: {conexion.testBD()}","CONEXION A BD");
        }



        public void MostrarGRID()
        {
            dgvMYSQL.DataSource = oAlumnosDAL.MostrarDGV().Tables[0];
            dgvMYSQL.Columns[0].HeaderText = "Correlativo";
            dgvMYSQL.Columns[1].HeaderText = "Nombre";
            dgvMYSQL.Columns[2].HeaderText = "Parcial 1";
            dgvMYSQL.Columns[3].HeaderText = "Parcial 2";
            dgvMYSQL.Columns[4].HeaderText = "Parcial 3";
        }

        private void btnCargarCSV_Click(object sender, EventArgs e)
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
                parcialDos = Convert.ToInt32(csvAlumnos[i, 3]);
                parcialTres = Convert.ToInt32(csvAlumnos[i, 4]);

                conexion.ejecutarComandoSinRetornoDatos($"INSERT INTO tb_alumnos VALUES({correlativo},'{nombre}',{parcialUno},{parcialDos},{parcialTres})");
            }
            MostrarGRID();
        }

        private void btnEliminarRegistros_Click(object sender, EventArgs e)
        {
            oAlumnosDAL.EliminarRegistros();
            MostrarGRID();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            MostrarGRID();
        }
    }
}
