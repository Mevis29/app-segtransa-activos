using FrontEnd.DataSources_Forms;

namespace FrontEnd.Forms_new
{
    partial class frmRptReparaciones
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.spRetornaReparacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_RetornaReparacionesDS = new FrontEnd.DataSources_Forms.sp_RetornaReparacionesDS();
            this.label2 = new System.Windows.Forms.Label();
            this.rpvReparaciones = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_RetornaReparacionTableAdapter = new FrontEnd.DataSources_Forms.sp_RetornaReparacionesDSTableAdapters.sp_RetornaReparacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spRetornaReparacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_RetornaReparacionesDS)).BeginInit();
            this.SuspendLayout();
            // 
            // spRetornaReparacionBindingSource
            // 
            this.spRetornaReparacionBindingSource.DataMember = "sp_RetornaReparacion";
            this.spRetornaReparacionBindingSource.DataSource = this.sp_RetornaReparacionesDS;
            // 
            // sp_RetornaReparacionesDS
            // 
            this.sp_RetornaReparacionesDS.DataSetName = "sp_RetornaReparacionesDS";
            this.sp_RetornaReparacionesDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(301, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Reporte de Reparaciones";
            // 
            // rpvReparaciones
            // 
            this.rpvReparaciones.AutoSize = true;
            reportDataSource1.Name = "tblReparaciones";
            reportDataSource1.Value = this.spRetornaReparacionBindingSource;
            this.rpvReparaciones.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvReparaciones.LocalReport.ReportEmbeddedResource = "FrontEnd.Reportes.rptReparacion.rdlc";
            this.rpvReparaciones.Location = new System.Drawing.Point(2, 50);
            this.rpvReparaciones.Name = "rpvReparaciones";
            this.rpvReparaciones.ServerReport.BearerToken = null;
            this.rpvReparaciones.Size = new System.Drawing.Size(786, 437);
            this.rpvReparaciones.TabIndex = 21;
            // 
            // sp_RetornaReparacionTableAdapter
            // 
            this.sp_RetornaReparacionTableAdapter.ClearBeforeFill = true;
            // 
            // frmRptReparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rpvReparaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRptReparaciones";
            this.Text = "frmRptReparaciones";
            this.Load += new System.EventHandler(this.frmRptReparaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spRetornaReparacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_RetornaReparacionesDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer rpvReparaciones;
        private System.Windows.Forms.BindingSource spRetornaReparacionBindingSource;
        private sp_RetornaReparacionesDS sp_RetornaReparacionesDS;
        private DataSources_Forms.sp_RetornaReparacionesDSTableAdapters.sp_RetornaReparacionTableAdapter sp_RetornaReparacionTableAdapter;
    }
}