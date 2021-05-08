
namespace DATABASES.PL
{
    partial class frmOracle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCorrelativo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtParcialUno = new System.Windows.Forms.TextBox();
            this.txtParcialDos = new System.Windows.Forms.TextBox();
            this.txtParcialTres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCSV = new System.Windows.Forms.Button();
            this.btnConexion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCorrelativo
            // 
            this.txtCorrelativo.Location = new System.Drawing.Point(49, 54);
            this.txtCorrelativo.Name = "txtCorrelativo";
            this.txtCorrelativo.Size = new System.Drawing.Size(68, 20);
            this.txtCorrelativo.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(123, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(247, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtParcialUno
            // 
            this.txtParcialUno.Location = new System.Drawing.Point(389, 54);
            this.txtParcialUno.Name = "txtParcialUno";
            this.txtParcialUno.Size = new System.Drawing.Size(51, 20);
            this.txtParcialUno.TabIndex = 5;
            // 
            // txtParcialDos
            // 
            this.txtParcialDos.Location = new System.Drawing.Point(467, 54);
            this.txtParcialDos.Name = "txtParcialDos";
            this.txtParcialDos.Size = new System.Drawing.Size(51, 20);
            this.txtParcialDos.TabIndex = 6;
            // 
            // txtParcialTres
            // 
            this.txtParcialTres.Location = new System.Drawing.Point(549, 54);
            this.txtParcialTres.Name = "txtParcialTres";
            this.txtParcialTres.Size = new System.Drawing.Size(51, 20);
            this.txtParcialTres.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Correlativo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Parcial Uno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Parcial Dos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Parcial Tres";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(551, 205);
            this.dataGridView1.TabIndex = 13;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::DATABASES.Properties.Resources.iconfinder_Add_132335;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(463, 95);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(137, 58);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCSV
            // 
            this.btnCSV.Image = global::DATABASES.Properties.Resources.iconfinder_logo_brand_brands_logos_excel_2993694;
            this.btnCSV.Location = new System.Drawing.Point(464, 395);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(136, 36);
            this.btnCSV.TabIndex = 1;
            this.btnCSV.Text = "Cargar CSV";
            this.btnCSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCSV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCSV.UseVisualStyleBackColor = true;
            this.btnCSV.Click += new System.EventHandler(this.btnCSV_Click);
            // 
            // btnConexion
            // 
            this.btnConexion.Image = global::DATABASES.Properties.Resources.iconfinder_Download_132283;
            this.btnConexion.Location = new System.Drawing.Point(312, 395);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Size = new System.Drawing.Size(136, 36);
            this.btnConexion.TabIndex = 0;
            this.btnConexion.Text = "Probar Conexion";
            this.btnConexion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConexion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConexion.UseVisualStyleBackColor = true;
            this.btnConexion.Click += new System.EventHandler(this.btnConexion_Click);
            // 
            // frmOracle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 454);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtParcialTres);
            this.Controls.Add(this.txtParcialDos);
            this.Controls.Add(this.txtParcialUno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCorrelativo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCSV);
            this.Controls.Add(this.btnConexion);
            this.Name = "frmOracle";
            this.Text = "frmOracle";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConexion;
        private System.Windows.Forms.Button btnCSV;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCorrelativo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtParcialUno;
        private System.Windows.Forms.TextBox txtParcialDos;
        private System.Windows.Forms.TextBox txtParcialTres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}