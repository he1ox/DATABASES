
namespace DATABASES
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOracle = new System.Windows.Forms.Button();
            this.btnMysql = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOracle
            // 
            this.btnOracle.Image = global::DATABASES.Properties.Resources.iconfinder_oracle_294664;
            this.btnOracle.Location = new System.Drawing.Point(39, 67);
            this.btnOracle.Name = "btnOracle";
            this.btnOracle.Size = new System.Drawing.Size(169, 120);
            this.btnOracle.TabIndex = 0;
            this.btnOracle.UseVisualStyleBackColor = true;
            this.btnOracle.Click += new System.EventHandler(this.btnOracle_Click);
            // 
            // btnMysql
            // 
            this.btnMysql.Image = global::DATABASES.Properties.Resources.iconfinder_MySQL_1012821;
            this.btnMysql.Location = new System.Drawing.Point(217, 67);
            this.btnMysql.Name = "btnMysql";
            this.btnMysql.Size = new System.Drawing.Size(169, 120);
            this.btnMysql.TabIndex = 0;
            this.btnMysql.UseVisualStyleBackColor = true;
            this.btnMysql.Click += new System.EventHandler(this.btnMysql_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elije un Gestor de BD";
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 211);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMysql);
            this.Controls.Add(this.btnOracle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Databases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOracle;
        private System.Windows.Forms.Button btnMysql;
        private System.Windows.Forms.Label label1;
    }
}

