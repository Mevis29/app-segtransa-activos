namespace FrontEnd.Forms_new
{
    partial class frmRptActivo
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
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sEGTRANSADataSource_ACTIVOS = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_ACTIVOS();
            this.sEGTRANSADataSourceACTIVOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activosTableAdapter = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_ACTIVOSTableAdapters.ActivosTableAdapter();
            this.sEGTRANSADataSetActivo = new FrontEnd.DataSources_Reportes.SEGTRANSADataSetActivo();
            this.sEGTRANSADataSetActivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spobtenerActivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_obtenerActivosTableAdapter = new FrontEnd.DataSources_Reportes.SEGTRANSADataSetActivoTableAdapters.sp_obtenerActivosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_ACTIVOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSourceACTIVOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSetActivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSetActivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spobtenerActivosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(401, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Reporte de Activos";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spobtenerActivosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FrontEnd.Reportes.rptActivo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 62);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1047, 537);
            this.reportViewer1.TabIndex = 26;
            // 
            // sEGTRANSADataSource_ACTIVOS
            // 
            this.sEGTRANSADataSource_ACTIVOS.DataSetName = "SEGTRANSADataSource_ACTIVOS";
            this.sEGTRANSADataSource_ACTIVOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sEGTRANSADataSourceACTIVOSBindingSource
            // 
            this.sEGTRANSADataSourceACTIVOSBindingSource.DataSource = this.sEGTRANSADataSource_ACTIVOS;
            this.sEGTRANSADataSourceACTIVOSBindingSource.Position = 0;
            // 
            // activosBindingSource
            // 
            this.activosBindingSource.DataMember = "Activos";
            this.activosBindingSource.DataSource = this.sEGTRANSADataSourceACTIVOSBindingSource;
            // 
            // activosTableAdapter
            // 
            this.activosTableAdapter.ClearBeforeFill = true;
            // 
            // sEGTRANSADataSetActivo
            // 
            this.sEGTRANSADataSetActivo.DataSetName = "SEGTRANSADataSetActivo";
            this.sEGTRANSADataSetActivo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sEGTRANSADataSetActivoBindingSource
            // 
            this.sEGTRANSADataSetActivoBindingSource.DataSource = this.sEGTRANSADataSetActivo;
            this.sEGTRANSADataSetActivoBindingSource.Position = 0;
            // 
            // spobtenerActivosBindingSource
            // 
            this.spobtenerActivosBindingSource.DataMember = "sp_obtenerActivos";
            this.spobtenerActivosBindingSource.DataSource = this.sEGTRANSADataSetActivoBindingSource;
            // 
            // sp_obtenerActivosTableAdapter
            // 
            this.sp_obtenerActivosTableAdapter.ClearBeforeFill = true;
            // 
            // frmRptActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 619);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRptActivo";
            this.Text = "frmRptActivo";
            this.Load += new System.EventHandler(this.frmRptActivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_ACTIVOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSourceACTIVOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSetActivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSetActivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spobtenerActivosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sEGTRANSADataSourceACTIVOSBindingSource;
        private DataSources_Forms.SEGTRANSADataSource_ACTIVOS sEGTRANSADataSource_ACTIVOS;
        private System.Windows.Forms.BindingSource activosBindingSource;
        private DataSources_Forms.SEGTRANSADataSource_ACTIVOSTableAdapters.ActivosTableAdapter activosTableAdapter;
        private DataSources_Reportes.SEGTRANSADataSetActivo sEGTRANSADataSetActivo;
        private System.Windows.Forms.BindingSource sEGTRANSADataSetActivoBindingSource;
        private System.Windows.Forms.BindingSource spobtenerActivosBindingSource;
        private DataSources_Reportes.SEGTRANSADataSetActivoTableAdapters.sp_obtenerActivosTableAdapter sp_obtenerActivosTableAdapter;
    }
}