using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DATABASES.PL;


namespace DATABASES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //Form no cambia de tamaño.
        }

        private void btnOracle_Click(object sender, EventArgs e)
        {
            frmOracle formularioOracle = new frmOracle();
            formularioOracle.Show();
        }

        private void btnMysql_Click(object sender, EventArgs e)
        {
            MySQL sqlform = new MySQL();
            sqlform.Show();
        }
    }
}
