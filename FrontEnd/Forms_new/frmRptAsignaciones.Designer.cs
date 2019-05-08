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
            this.spAsignUsuarioRetornaListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.segtransaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.segtransaDataSet = new FrontEnd.DataSources_Reportes.SegtransaDataSet();
            this.spAsignUsuarioRetornaListaTotalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sEGTRANSADataSourcespListaTotalAsignacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEGTRANSADataSource_spListaTotalAsignaciones = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_spListaTotalAsignaciones();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spAsignUsuarioRetornaListaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.spAsignUsuarioRetornaListaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.spAsignUsuarioRetornaListaTotalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spAsignUsuarioRetornaListaTotalTableAdapter = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_spListaTotalAsignacionesTableAdapters.spAsignUsuarioRetornaListaTotalTableAdapter();
            this.spAsignUsuarioRetornaListaTableAdapter = new FrontEnd.DataSources_Reportes.SegtransaDataSetTableAdapters.spAsignUsuarioRetornaListaTableAdapter();
            this.spAsignUsuarioRetornaListaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.segtransaDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spAsignUsuarioRetornaListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segtransaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segtransaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAsignUsuarioRetornaListaTotalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSourcespListaTotalAsignacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_spListaTotalAsignaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAsignUsuarioRetornaListaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAsignUsuarioRetornaListaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAsignUsuarioRetornaListaTotalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAsignUsuarioRetornaListaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segtransaDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // spAsignUsuarioRetornaListaBindingSource
            // 
            this.spAsignUsuarioRetornaListaBindingSource.DataMember = "spAsignUsuarioRetornaLista";
            this.spAsignUsuarioRetornaListaBindingSource.DataSource = this.segtransaDataSetBindingSource;
            // 
            // segtransaDataSetBindingSource
            // 
            this.segtransaDataSetBindingSource.DataSource = this.segtransaDataSet;
            this.segtransaDataSetBindingSource.Position = 0;
            // 
            // segtransaDataSet
            // 
            this.segtransaDataSet.DataSetName = "SegtransaDataSet";
            this.segtransaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spAsignUsuarioRetornaListaTotalBindingSource1
            // 
            this.spAsignUsuarioRetornaListaTotalBindingSource1.DataMember = "spAsignUsuarioRetornaListaTotal";
            this.spAsignUsuarioRetornaListaTotalBindingSource1.DataSource = this.sEGTRANSADataSourcespListaTotalAsignacionesBindingSource;
            // 
            // sEGTRANSADataSourcespListaTotalAsignacionesBindingSource
            // 
            this.sEGTRANSADataSourcespListaTotalAsignacionesBindingSource.DataSource = this.sEGTRANSADataSource_spListaTotalAsignaciones;
            this.sEGTRANSADataSourcespListaTotalAsignacionesBindingSource.Position = 0;
            // 
            // sEGTRANSADataSource_spListaTotalAsignaciones
            // 
            this.sEGTRANSADataSource_spListaTotalAsignaciones.DataSetName = "SEGTRANSADataSource_spListaTotalAsignaciones";
            this.sEGTRANSADataSource_spListaTotalAsignaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Reporte de Asignaciones";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "spAsignUsuarioRetornaListaDS";
            reportDataSource1.Value = this.spAsignUsuarioRetornaListaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FrontEnd.Reportes.rptAsignaciones.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 50);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(786, 437);
            this.reportViewer1.TabIndex = 25;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // spAsignUsuarioRetornaListaBindingSource1
            // 
            this.spAsignUsuarioRetornaListaBindingSource1.DataMember = "spAsignUsuarioRetornaLista";
            this.spAsignUsuarioRetornaListaBindingSource1.DataSource = this.segtransaDataSetBindingSource;
            // 
            // spAsignUsuarioRetornaListaBindingSource3
            // 
            this.spAsignUsuarioRetornaListaBindingSource3.DataMember = "spAsignUsuarioRetornaLista";
            this.spAsignUsuarioRetornaListaBindingSource3.DataSource = this.segtransaDataSetBindingSource;
            // 
            // spAsignUsuarioRetornaListaTotalBindingSource
            // 
            this.spAsignUsuarioRetornaListaTotalBindingSource.DataMember = "spAsignUsuarioRetornaListaTotal";
            this.spAsignUsuarioRetornaListaTotalBindingSource.DataSource = this.sEGTRANSADataSource_spListaTotalAsignaciones;
            // 
            // spAsignUsuarioRetornaListaTotalTableAdapter
            // 
            this.spAsignUsuarioRetornaListaTotalTableAdapter.ClearBeforeFill = true;
            // 
            // spAsignUsuarioRetornaListaTableAdapter
            // 
            this.spAsignUsuarioRetornaListaTableAdapter.ClearBeforeFill = true;
            // 
            // spAsignUsuarioRetornaListaBindingSource2
            // 
            this.spAsignUsuarioRetornaListaBindingSource2.DataMember = "spAsignUsuarioRetornaLista";
            this.spAsignUsuarioRetornaListaBindingSource2.DataSource = this.segtransaDataSet;
            // 
            // segtransaDataSetBindingSource1
            // 
            this.segtransaDataSetBindingSource1.DataSource = this.segtransaDataSet;
            this.segtransaDataSetBindingSource1.Position = 0;
            // 
            // frmRptAsignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRptAsignaciones";
            this.Text = "frmRptAsignaciones";
            this.Load += new System.EventHandler(this.frmRptAsignaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spAsignUsuarioRetornaListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segtransaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segtransaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAsignUsuarioRetornaListaTotalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSourcespListaTotalAsignacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_spListaTotalAsignaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAsignUsuarioRetornaListaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAsignUsuarioRetornaListaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAsignUsuarioRetornaListaTotalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAsignUsuarioRetornaListaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segtransaDataSetBindingSource1)).EndInit();
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
        private System.Windows.Forms.BindingSource segtransaDataSetBindingSource;
        private DataSources_Reportes.SegtransaDataSet segtransaDataSet;
        private System.Windows.Forms.BindingSource spAsignUsuarioRetornaListaBindingSource;
        private DataSources_Reportes.SegtransaDataSetTableAdapters.spAsignUsuarioRetornaListaTableAdapter spAsignUsuarioRetornaListaTableAdapter;
        private System.Windows.Forms.BindingSource spAsignUsuarioRetornaListaBindingSource1;
        private System.Windows.Forms.BindingSource spAsignUsuarioRetornaListaBindingSource2;
        private System.Windows.Forms.BindingSource spAsignUsuarioRetornaListaBindingSource3;
        private System.Windows.Forms.BindingSource segtransaDataSetBindingSource1;
    }
}