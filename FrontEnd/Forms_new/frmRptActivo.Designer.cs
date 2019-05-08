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
            this.spobtenerActivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEGTRANSADataSetActivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEGTRANSADataSetActivo = new FrontEnd.DataSources_Reportes.SEGTRANSADataSetActivo();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sEGTRANSADataSource_ACTIVOS = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_ACTIVOS();
            this.sEGTRANSADataSourceACTIVOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activosTableAdapter = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_ACTIVOSTableAdapters.ActivosTableAdapter();
            this.sp_obtenerActivosTableAdapter = new FrontEnd.DataSources_Reportes.SEGTRANSADataSetActivoTableAdapters.sp_obtenerActivosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spobtenerActivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSetActivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSetActivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_ACTIVOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSourceACTIVOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spobtenerActivosBindingSource
            // 
            this.spobtenerActivosBindingSource.DataMember = "sp_obtenerActivos";
            this.spobtenerActivosBindingSource.DataSource = this.sEGTRANSADataSetActivoBindingSource;
            // 
            // sEGTRANSADataSetActivoBindingSource
            // 
            this.sEGTRANSADataSetActivoBindingSource.DataSource = this.sEGTRANSADataSetActivo;
            this.sEGTRANSADataSetActivoBindingSource.Position = 0;
            // 
            // sEGTRANSADataSetActivo
            // 
            this.sEGTRANSADataSetActivo.DataSetName = "SEGTRANSADataSetActivo";
            this.sEGTRANSADataSetActivo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Reporte de Activos";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spobtenerActivosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FrontEnd.Reportes.rptActivo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 50);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(786, 437);
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
            // sp_obtenerActivosTableAdapter
            // 
            this.sp_obtenerActivosTableAdapter.ClearBeforeFill = true;
            // 
            // frmRptActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRptActivo";
            this.Text = "frmRptActivo";
            this.Load += new System.EventHandler(this.frmRptActivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spobtenerActivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSetActivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSetActivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_ACTIVOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSourceACTIVOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).EndInit();
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