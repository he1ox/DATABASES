using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DATABASES.DAL
{
    class clsCSV
    {

        OpenFileDialog ventana;
        string titulo = "Selecciona un archivo .CSV";
        string dir = @"C:\Users\georg\source\repos\";
        string filtro = "Archivo plano (*.csv)|*.csv";
        private string[] alumnosArray;
        private string[,] arregloDosDimensiones;



        public string[,] buscarCSV() {

            clsArchivo ar = new clsArchivo();

            this.ventana = new OpenFileDialog();

            this.ventana.Title = titulo;
            this.ventana.InitialDirectory = dir;
            this.ventana.Filter = filtro;

            if (this.ventana.ShowDialog() == DialogResult.OK)
            {
                var archivo = this.ventana.FileName;
                MessageBox.Show($"CSV Cargado: {this.ventana.FileName}");


                 alumnosArray = ar.LeerArchivo(archivo);
            }

            string[,] arregloDosDimensiones = new string[alumnosArray.Length, 5];

            int NumeroLinea = 0;

            foreach (string linea in alumnosArray)
            {
                string[] datosUnitarios = linea.Split(';');
                arregloDosDimensiones[NumeroLinea, 0] = datosUnitarios[0]; //CORRELATIVO
                arregloDosDimensiones[NumeroLinea, 1] = datosUnitarios[1]; //NOMBRE
                arregloDosDimensiones[NumeroLinea, 2] = datosUnitarios[2]; //PARCIAL 1 
                arregloDosDimensiones[NumeroLinea, 3] = datosUnitarios[3];  //PARCIAL 2
                arregloDosDimensiones[NumeroLinea, 4] = datosUnitarios[4];  //PARCIAL 3 

                NumeroLinea++;
            }


            return arregloDosDimensiones;
        }
    }
}
