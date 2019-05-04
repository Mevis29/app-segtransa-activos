namespace FrontEnd.Forms_new
{
    partial class frmRptAsignaciones
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
            this.spAsignUsuarioRetornaListaTotalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEGTRANSADataSource_spListaTotalAsignaciones = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_spListaTotalAsignaciones();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sEGTRANSADataSourcespListaTotalAsignacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spAsignUsuarioRetornaListaTotalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.spAsignUsuarioRetornaListaTotalTableAdapter = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_spListaTotalAsignacionesTableAdapters.spAsignUsuarioRetornaListaTotalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spAsignUsuarioRetornaListaTotalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_spListaTotalAsignaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSourcespListaTotalAsignacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAsignUsuarioRetornaListaTotalBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // spAsignUsuarioRetornaListaTotalBindingSource
            // 
            this.spAsignUsuarioRetornaListaTotalBindingSource.DataMember = "spAsignUsuarioRetornaListaTotal";
            this.spAsignUsuarioRetornaListaTotalBindingSource.DataSource = this.sEGTRANSADataSource_spListaTotalAsignaciones;
            // 
            // sEGTRANSADataSource_spListaTotalAsignaciones
            // 
            this.sEGTRANSADataSource_spListaTotalAsignaciones.DataSetName = "SEGTRANSADataSource_spListaTotalAsignaciones";
            this.sEGTRANSADataSource_spListaTotalAsignaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(401, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Reporte de Asignaciones";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Asignaciones";
            reportDataSource1.Value = this.spAsignUsuarioRetornaListaTotalBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FrontEnd.Reportes.rptAsignaciones.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 62);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1047, 537);
            this.reportViewer1.TabIndex = 25;
            // 
            // sEGTRANSADataSourcespListaTotalAsignacionesBindingSource
            // 
            this.sEGTRANSADataSourcespListaTotalAsignacionesBindingSource.DataSource = this.sEGTRANSADataSource_spListaTotalAsignaciones;
            this.sEGTRANSADataSourcespListaTotalAsignacionesBindingSource.Position = 0;
            // 
            // spAsignUsuarioRetornaListaTotalBindingSource1
            // 
            this.spAsignUsuarioRetornaListaTotalBindingSource1.DataMember = "spAsignUsuarioRetornaListaTotal";
            this.spAsignUsuarioRetornaListaTotalBindingSource1.DataSource = this.sEGTRANSADataSourcespListaTotalAsignacionesBindingSource;
            // 
            // spAsignUsuarioRetornaListaTotalTableAdapter
            // 
            this.spAsignUsuarioRetornaListaTotalTableAdapter.ClearBeforeFill = true;
            // 
            // frmRptAsignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 619);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRptAsignaciones";
            this.Text = "frmRptAsignaciones";
            this.Load += new System.EventHandler(this.frmRptAsignaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spAsignUsuarioRetornaListaTotalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_spListaTotalAsignaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSourcespListaTotalAsignacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAsignUsuarioRetornaListaTotalBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sEGTRANSADataSourcespListaTotalAsignacionesBindingSource;
        private DataSources_Forms.SEGTRANSADataSource_spListaTotalAsignaciones sEGTRANSADataSource_spListaTotalAsignaciones;
        private System.Windows.Forms.BindingSource spAsignUsuarioRetornaListaTotalBindingSource;
        private System.Windows.Forms.BindingSource spAsignUsuarioRetornaListaTotalBindingSource1;
        private DataSources_Forms.SEGTRANSADataSource_spListaTotalAsignacionesTableAdapters.spAsignUsuarioRetornaListaTotalTableAdapter spAsignUsuarioRetornaListaTotalTableAdapter;
    }
}