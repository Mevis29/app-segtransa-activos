namespace FrontEnd.Forms_new
{
    partial class frmRptDepreciados
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
            this.sp_RetornaDepreciadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depreciadosDS = new FrontEnd.DataSources_Reportes.DepreciadosDS();
            this.label2 = new System.Windows.Forms.Label();
            this.rpvDepreciados = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spRetornaDepreciadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_RetornaDepreciadosTableAdapter = new FrontEnd.DataSources_Reportes.DepreciadosDSTableAdapters.sp_RetornaDepreciadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_RetornaDepreciadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depreciadosDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRetornaDepreciadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_RetornaDepreciadosBindingSource
            // 
            this.sp_RetornaDepreciadosBindingSource.DataMember = "sp_RetornaDepreciados";
            this.sp_RetornaDepreciadosBindingSource.DataSource = this.depreciadosDS;
            // 
            // depreciadosDS
            // 
            this.depreciadosDS.DataSetName = "DepreciadosDS";
            this.depreciadosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(298, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Reporte de Depreciados";
            // 
            // rpvDepreciados
            // 
            this.rpvDepreciados.AutoSize = true;
            reportDataSource1.Name = "DepreciadosDS";
            reportDataSource1.Value = this.sp_RetornaDepreciadosBindingSource;
            this.rpvDepreciados.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvDepreciados.LocalReport.ReportEmbeddedResource = "FrontEnd.Reportes.rptDepreciados.rdlc";
            this.rpvDepreciados.Location = new System.Drawing.Point(2, 46);
            this.rpvDepreciados.Name = "rpvDepreciados";
            this.rpvDepreciados.ServerReport.BearerToken = null;
            this.rpvDepreciados.Size = new System.Drawing.Size(786, 437);
            this.rpvDepreciados.TabIndex = 24;
            // 
            // spRetornaDepreciadosBindingSource
            // 
            this.spRetornaDepreciadosBindingSource.DataMember = "sp_RetornaDepreciados";
            this.spRetornaDepreciadosBindingSource.DataSource = this.depreciadosDS;
            // 
            // sp_RetornaDepreciadosTableAdapter
            // 
            this.sp_RetornaDepreciadosTableAdapter.ClearBeforeFill = true;
            // 
            // frmRptDepreciados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rpvDepreciados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRptDepreciados";
            this.Text = "frmRptDepreciados";
            this.Load += new System.EventHandler(this.frmRptDepreciados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_RetornaDepreciadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depreciadosDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRetornaDepreciadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer rpvDepreciados;
        private DataSources_Reportes.DepreciadosDS depreciadosDS;
        private System.Windows.Forms.BindingSource spRetornaDepreciadosBindingSource;
        private DataSources_Reportes.DepreciadosDSTableAdapters.sp_RetornaDepreciadosTableAdapter sp_RetornaDepreciadosTableAdapter;
        private System.Windows.Forms.BindingSource sp_RetornaDepreciadosBindingSource;
    }
}