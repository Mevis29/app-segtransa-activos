namespace FrontEnd.Forms_new
{
    partial class frmMenuReportes
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionRptBitacora = new System.Windows.Forms.ToolStripMenuItem();
            this.optionRptReparaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeActivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.contentPnl = new System.Windows.Forms.Panel();
            this.lblReportes = new System.Windows.Forms.Label();
            this.reporteDeDepreciadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contentPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionRptBitacora,
            this.optionRptReparaciones,
            this.reporteDeToolStripMenuItem,
            this.reporteDeActivosToolStripMenuItem,
            this.reporteDeUsuariosToolStripMenuItem,
            this.reporteDeDepreciadosToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionRptBitacora
            // 
            this.opcionRptBitacora.Name = "opcionRptBitacora";
            this.opcionRptBitacora.Size = new System.Drawing.Size(122, 20);
            this.opcionRptBitacora.Text = "Reporte de bitácora";
            this.opcionRptBitacora.Click += new System.EventHandler(this.opcionRptBitacora_Click);
            // 
            // optionRptReparaciones
            // 
            this.optionRptReparaciones.Name = "optionRptReparaciones";
            this.optionRptReparaciones.Size = new System.Drawing.Size(146, 20);
            this.optionRptReparaciones.Text = "Reporte de reparaciones";
            this.optionRptReparaciones.Click += new System.EventHandler(this.optionRptReparaciones_Click);
            // 
            // reporteDeToolStripMenuItem
            // 
            this.reporteDeToolStripMenuItem.Name = "reporteDeToolStripMenuItem";
            this.reporteDeToolStripMenuItem.Size = new System.Drawing.Size(150, 20);
            this.reporteDeToolStripMenuItem.Text = "Reporte de asignaciones ";
            this.reporteDeToolStripMenuItem.Click += new System.EventHandler(this.optionRptAsignaciones_Click);
            // 
            // reporteDeActivosToolStripMenuItem
            // 
            this.reporteDeActivosToolStripMenuItem.Name = "reporteDeActivosToolStripMenuItem";
            this.reporteDeActivosToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.reporteDeActivosToolStripMenuItem.Text = "Reporte de activos";
            this.reporteDeActivosToolStripMenuItem.Click += new System.EventHandler(this.optionRptActivos_Click);
            // 
            // reporteDeUsuariosToolStripMenuItem
            // 
            this.reporteDeUsuariosToolStripMenuItem.Name = "reporteDeUsuariosToolStripMenuItem";
            this.reporteDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.reporteDeUsuariosToolStripMenuItem.Text = "Reporte de usuarios";
            this.reporteDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.optionRptUsuarios_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitulo.Location = new System.Drawing.Point(366, 201);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(129, 37);
            this.lblTitulo.TabIndex = 29;
            this.lblTitulo.Text = "Reportes";
            // 
            // contentPnl
            // 
            this.contentPnl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contentPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contentPnl.Controls.Add(this.lblReportes);
            this.contentPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPnl.Location = new System.Drawing.Point(0, 24);
            this.contentPnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contentPnl.Name = "contentPnl";
            this.contentPnl.Size = new System.Drawing.Size(800, 426);
            this.contentPnl.TabIndex = 30;
            // 
            // lblReportes
            // 
            this.lblReportes.AutoSize = true;
            this.lblReportes.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportes.ForeColor = System.Drawing.Color.DimGray;
            this.lblReportes.Location = new System.Drawing.Point(365, 176);
            this.lblReportes.Name = "lblReportes";
            this.lblReportes.Size = new System.Drawing.Size(129, 37);
            this.lblReportes.TabIndex = 0;
            this.lblReportes.Text = "Reportes";
            // 
            // reporteDeDepreciadosToolStripMenuItem
            // 
            this.reporteDeDepreciadosToolStripMenuItem.Name = "reporteDeDepreciadosToolStripMenuItem";
            this.reporteDeDepreciadosToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.reporteDeDepreciadosToolStripMenuItem.Text = "Depreciados";
            this.reporteDeDepreciadosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeDepreciadosToolStripMenuItem_Click);
            // 
            // frmMenuReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contentPnl);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuReportes";
            this.Text = "frmMenuReportes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contentPnl.ResumeLayout(false);
            this.contentPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionRptBitacora;
        private System.Windows.Forms.ToolStripMenuItem optionRptReparaciones;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel contentPnl;
        private System.Windows.Forms.Label lblReportes;
        private System.Windows.Forms.ToolStripMenuItem reporteDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeActivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeDepreciadosToolStripMenuItem;
    }
}