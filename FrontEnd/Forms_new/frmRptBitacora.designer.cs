namespace FrontEnd.Forms_new
{
    partial class frmRptBitacora
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bitacoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEGTRANSADataSetBitacora = new FrontEnd.DataSources_Reportes.SEGTRANSADataSetBitacora();
            this.spRetornaBitacoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEGTRANSADataSetSp_RetornaBitacora = new FrontEnd.DataSources_Reportes.SEGTRANSADataSetSp_RetornaBitacora();
            this.label2 = new System.Windows.Forms.Label();
            this.rpvBitacora = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sEGTRANSADataSetSpRetornaBitacoraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sEGTRANSADataSetSpRetornaBitacoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_RetornaBitacoraTableAdapter = new FrontEnd.DataSources_Reportes.SEGTRANSADataSetSp_RetornaBitacoraTableAdapters.sp_RetornaBitacoraTableAdapter();
            this.bitacoraTableAdapter = new FrontEnd.DataSources_Reportes.SEGTRANSADataSetBitacoraTableAdapters.BitacoraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSetBitacora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRetornaBitacoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSetSp_RetornaBitacora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSetSpRetornaBitacoraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSetSpRetornaBitacoraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bitacoraBindingSource
            // 
            this.bitacoraBindingSource.DataMember = "Bitacora";
            this.bitacoraBindingSource.DataSource = this.sEGTRANSADataSetBitacora;
            // 
            // sEGTRANSADataSetBitacora
            // 
            this.sEGTRANSADataSetBitacora.DataSetName = "SEGTRANSADataSetBitacora";
            this.sEGTRANSADataSetBitacora.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spRetornaBitacoraBindingSource
            // 
            this.spRetornaBitacoraBindingSource.DataMember = "sp_RetornaBitacora";
            this.spRetornaBitacoraBindingSource.DataSource = this.sEGTRANSADataSetSp_RetornaBitacora;
            // 
            // sEGTRANSADataSetSp_RetornaBitacora
            // 
            this.sEGTRANSADataSetSp_RetornaBitacora.DataSetName = "SEGTRANSADataSetSp_RetornaBitacora";
            this.sEGTRANSADataSetSp_RetornaBitacora.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Reporte de Bitácora";
            // 
            // rpvBitacora
            // 
            this.rpvBitacora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rpvBitacora.AutoSize = true;
            this.rpvBitacora.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "DataSourceBitacora";
            reportDataSource1.Value = this.bitacoraBindingSource;
            reportDataSource2.Name = "sp_RetornaBitacoraDataSet";
            reportDataSource2.Value = this.spRetornaBitacoraBindingSource;
            this.rpvBitacora.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvBitacora.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvBitacora.LocalReport.ReportEmbeddedResource = "FrontEnd.Reportes.rtpBitacora.rdlc";
            this.rpvBitacora.Location = new System.Drawing.Point(2, 50);
            this.rpvBitacora.Name = "rpvBitacora";
            this.rpvBitacora.ServerReport.BearerToken = null;
            this.rpvBitacora.Size = new System.Drawing.Size(786, 413);
            this.rpvBitacora.TabIndex = 24;
            // 
            // sEGTRANSADataSetSpRetornaBitacoraBindingSource1
            // 
            this.sEGTRANSADataSetSpRetornaBitacoraBindingSource1.DataSource = this.sEGTRANSADataSetSp_RetornaBitacora;
            this.sEGTRANSADataSetSpRetornaBitacoraBindingSource1.Position = 0;
            // 
            // sEGTRANSADataSetSpRetornaBitacoraBindingSource
            // 
            this.sEGTRANSADataSetSpRetornaBitacoraBindingSource.DataSource = this.sEGTRANSADataSetSp_RetornaBitacora;
            this.sEGTRANSADataSetSpRetornaBitacoraBindingSource.Position = 0;
            // 
            // sp_RetornaBitacoraTableAdapter
            // 
            this.sp_RetornaBitacoraTableAdapter.ClearBeforeFill = true;
            // 
            // bitacoraTableAdapter
            // 
            this.bitacoraTableAdapter.ClearBeforeFill = true;
            // 
            // frmRptBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rpvBitacora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRptBitacora";
            this.Text = "frmRptBitacora";
            this.Load += new System.EventHandler(this.frmRptBitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSetBitacora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRetornaBitacoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSetSp_RetornaBitacora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSetSpRetornaBitacoraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSetSpRetornaBitacoraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer rpvBitacora;
        private System.Windows.Forms.BindingSource sEGTRANSADataSetSpRetornaBitacoraBindingSource1;
        private DataSources_Reportes.SEGTRANSADataSetSp_RetornaBitacora sEGTRANSADataSetSp_RetornaBitacora;
        private System.Windows.Forms.BindingSource sEGTRANSADataSetSpRetornaBitacoraBindingSource;
        private System.Windows.Forms.BindingSource spRetornaBitacoraBindingSource;
        private DataSources_Reportes.SEGTRANSADataSetSp_RetornaBitacoraTableAdapters.sp_RetornaBitacoraTableAdapter sp_RetornaBitacoraTableAdapter;
        private DataSources_Reportes.SEGTRANSADataSetBitacora sEGTRANSADataSetBitacora;
        private System.Windows.Forms.BindingSource bitacoraBindingSource;
        private DataSources_Reportes.SEGTRANSADataSetBitacoraTableAdapters.BitacoraTableAdapter bitacoraTableAdapter;
    }
}