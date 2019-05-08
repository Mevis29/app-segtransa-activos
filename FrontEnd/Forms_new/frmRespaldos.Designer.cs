namespace FrontEnd.Forms_new
{
    partial class frmRespaldos
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
            this.txtDirectorio = new System.Windows.Forms.TextBox();
            this.btnExplorar = new System.Windows.Forms.Button();
            this.btnRespaldarDatos = new System.Windows.Forms.Button();
            this.lblDirectorio = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblProveedores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDirectorio
            // 
            this.txtDirectorio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectorio.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDirectorio.Location = new System.Drawing.Point(13, 65);
            this.txtDirectorio.Multiline = true;
            this.txtDirectorio.Name = "txtDirectorio";
            this.txtDirectorio.ReadOnly = true;
            this.txtDirectorio.Size = new System.Drawing.Size(317, 20);
            this.txtDirectorio.TabIndex = 1;
            // 
            // btnExplorar
            // 
            this.btnExplorar.Location = new System.Drawing.Point(13, 94);
            this.btnExplorar.Name = "btnExplorar";
            this.btnExplorar.Size = new System.Drawing.Size(126, 23);
            this.btnExplorar.TabIndex = 2;
            this.btnExplorar.Text = "Explorar";
            this.btnExplorar.UseVisualStyleBackColor = true;
            this.btnExplorar.Click += new System.EventHandler(this.btnExplorar_Click);
            // 
            // btnRespaldarDatos
            // 
            this.btnRespaldarDatos.Location = new System.Drawing.Point(208, 94);
            this.btnRespaldarDatos.Name = "btnRespaldarDatos";
            this.btnRespaldarDatos.Size = new System.Drawing.Size(121, 23);
            this.btnRespaldarDatos.TabIndex = 3;
            this.btnRespaldarDatos.Text = "Respaldar datos";
            this.btnRespaldarDatos.UseVisualStyleBackColor = true;
            this.btnRespaldarDatos.Click += new System.EventHandler(this.btnRespaldarDatos_Click);
            // 
            // lblDirectorio
            // 
            this.lblDirectorio.AutoSize = true;
            this.lblDirectorio.Location = new System.Drawing.Point(14, 46);
            this.lblDirectorio.Name = "lblDirectorio";
            this.lblDirectorio.Size = new System.Drawing.Size(228, 13);
            this.lblDirectorio.TabIndex = 4;
            this.lblDirectorio.Text = "Seleccione una ruta donde guardar el respaldo";
            // 
            // lblProveedores
            // 
            this.lblProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedores.ForeColor = System.Drawing.Color.Black;
            this.lblProveedores.Location = new System.Drawing.Point(11, 0);
            this.lblProveedores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(148, 33);
            this.lblProveedores.TabIndex = 5;
            this.lblProveedores.Text = "Respaldos";
            this.lblProveedores.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmRespaldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 155);
            this.Controls.Add(this.lblProveedores);
            this.Controls.Add(this.lblDirectorio);
            this.Controls.Add(this.btnRespaldarDatos);
            this.Controls.Add(this.btnExplorar);
            this.Controls.Add(this.txtDirectorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRespaldos";
            this.Text = "frmRespaldos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDirectorio;
        private System.Windows.Forms.Button btnExplorar;
        private System.Windows.Forms.Button btnRespaldarDatos;
        private System.Windows.Forms.Label lblDirectorio;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblProveedores;
    }
}