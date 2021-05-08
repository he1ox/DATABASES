
namespace DATABASES.PL
{
    partial class MySQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MySQL));
            this.btnConexion = new System.Windows.Forms.Button();
            this.dgvMYSQL = new System.Windows.Forms.DataGridView();
            this.btnEliminarRegistros = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnCargarCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMYSQL)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConexion
            // 
            this.btnConexion.Image = global::DATABASES.Properties.Resources.iconfinder_Download_132283;
            this.btnConexion.Location = new System.Drawing.Point(422, 399);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Size = new System.Drawing.Size(198, 39);
            this.btnConexion.TabIndex = 0;
            this.btnConexion.Text = "Probar Conexion";
            this.btnConexion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConexion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConexion.UseVisualStyleBackColor = true;
            this.btnConexion.Click += new System.EventHandler(this.btnConexion_Click);
            // 
            // dgvMYSQL
            // 
            this.dgvMYSQL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMYSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMYSQL.Location = new System.Drawing.Point(32, 31);
            this.dgvMYSQL.Name = "dgvMYSQL";
            this.dgvMYSQL.Size = new System.Drawing.Size(755, 341);
            this.dgvMYSQL.TabIndex = 2;
            // 
            // btnEliminarRegistros
            // 
            this.btnEliminarRegistros.Image = global::DATABASES.Properties.Resources.iconfinder_Delete_132192;
            this.btnEliminarRegistros.Location = new System.Drawing.Point(32, 399);
            this.btnEliminarRegistros.Name = "btnEliminarRegistros";
            this.btnEliminarRegistros.Size = new System.Drawing.Size(139, 39);
            this.btnEliminarRegistros.TabIndex = 3;
            this.btnEliminarRegistros.Text = "Eliminar Registros";
            this.btnEliminarRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarRegistros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarRegistros.UseVisualStyleBackColor = true;
            this.btnEliminarRegistros.Click += new System.EventHandler(this.btnEliminarRegistros_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Image = global::DATABASES.Properties.Resources.iconfinder_Refresh_132187;
            this.btnRefrescar.Location = new System.Drawing.Point(177, 399);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(139, 39);
            this.btnRefrescar.TabIndex = 4;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnCargarCSV
            // 
            this.btnCargarCSV.Image = global::DATABASES.Properties.Resources.iconfinder_logo_brand_brands_logos_excel_2993694;
            this.btnCargarCSV.Location = new System.Drawing.Point(627, 399);
            this.btnCargarCSV.Name = "btnCargarCSV";
            this.btnCargarCSV.Size = new System.Drawing.Size(161, 39);
            this.btnCargarCSV.TabIndex = 1;
            this.btnCargarCSV.Text = "CARGAR CSV";
            this.btnCargarCSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarCSV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargarCSV.UseVisualStyleBackColor = true;
            this.btnCargarCSV.Click += new System.EventHandler(this.btnCargarCSV_Click);
            // 
            // MySQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnEliminarRegistros);
            this.Controls.Add(this.dgvMYSQL);
            this.Controls.Add(this.btnCargarCSV);
            this.Controls.Add(this.btnConexion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MySQL";
            this.Text = "frmMySQL";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMYSQL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConexion;
        private System.Windows.Forms.Button btnCargarCSV;
        private System.Windows.Forms.DataGridView dgvMYSQL;
        private System.Windows.Forms.Button btnEliminarRegistros;
        private System.Windows.Forms.Button btnRefrescar;
    }
}