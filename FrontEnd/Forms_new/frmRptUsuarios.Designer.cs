namespace FrontEnd.Forms_new
{
    partial class frmRptUsuarios
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
            this.sEGTRANSADataSetUsuarios = new FrontEnd.DataSources_Reportes.SEGTRANSADataSetUsuarios();
            this.sEGTRANSADataSetUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spUsuariosRetornaListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spUsuariosRetornaListaTableAdapter = new FrontEnd.DataSources_Reportes.SEGTRANSADataSetUsuariosTableAdapters.spUsuariosRetornaListaTableAdapter();
            this.sEGTRANSADataSource_USUARIOS = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_USUARIOS();
            this.sEGTRANSADataSourceUSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_USUARIOSTableAdapters.UsuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSetUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSetUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spUsuariosRetornaListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_USUARIOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSourceUSUARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
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
            this.label2.Size = new System.Drawing.Size(201, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Reporte de Usuarios";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.usuariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FrontEnd.Reportes.rptUsuario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 62);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1047, 537);
            this.reportViewer1.TabIndex = 27;
            // 
            // sEGTRANSADataSetUsuarios
            // 
            this.sEGTRANSADataSetUsuarios.DataSetName = "SEGTRANSADataSetUsuarios";
            this.sEGTRANSADataSetUsuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sEGTRANSADataSetUsuariosBindingSource
            // 
            this.sEGTRANSADataSetUsuariosBindingSource.DataSource = this.sEGTRANSADataSetUsuarios;
            this.sEGTRANSADataSetUsuariosBindingSource.Position = 0;
            // 
            // spUsuariosRetornaListaBindingSource
            // 
            this.spUsuariosRetornaListaBindingSource.DataMember = "spUsuariosRetornaLista";
            this.spUsuariosRetornaListaBindingSource.DataSource = this.sEGTRANSADataSetUsuarios;
            // 
            // spUsuariosRetornaListaTableAdapter
            // 
            this.spUsuariosRetornaListaTableAdapter.ClearBeforeFill = true;
            // 
            // sEGTRANSADataSource_USUARIOS
            // 
            this.sEGTRANSADataSource_USUARIOS.DataSetName = "SEGTRANSADataSource_USUARIOS";
            this.sEGTRANSADataSource_USUARIOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sEGTRANSADataSourceUSUARIOSBindingSource
            // 
            this.sEGTRANSADataSourceUSUARIOSBindingSource.DataSource = this.sEGTRANSADataSource_USUARIOS;
            this.sEGTRANSADataSourceUSUARIOSBindingSource.Position = 0;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.sEGTRANSADataSourceUSUARIOSBindingSource;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // frmRptUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 619);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRptUsuarios";
            this.Text = "frmRptUsuarios";
            this.Load += new System.EventHandler(this.frmRptUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSetUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSetUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spUsuariosRetornaListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_USUARIOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSourceUSUARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sEGTRANSADataSetUsuariosBindingSource;
        private DataSources_Reportes.SEGTRANSADataSetUsuarios sEGTRANSADataSetUsuarios;
        private System.Windows.Forms.BindingSource spUsuariosRetornaListaBindingSource;
        private DataSources_Reportes.SEGTRANSADataSetUsuariosTableAdapters.spUsuariosRetornaListaTableAdapter spUsuariosRetornaListaTableAdapter;
        private System.Windows.Forms.BindingSource sEGTRANSADataSourceUSUARIOSBindingSource;
        private DataSources_Forms.SEGTRANSADataSource_USUARIOS sEGTRANSADataSource_USUARIOS;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private DataSources_Forms.SEGTRANSADataSource_USUARIOSTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
    }
}