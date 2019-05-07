namespace Frontend
{
    partial class FrmMisActivos_n
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMiPerfil = new System.Windows.Forms.Label();
            this.tblMisActivos = new System.Windows.Forms.DataGridView();
            this.btnSolicitarRep = new System.Windows.Forms.Button();
            this.sEGTRANSADataSource_spActivosPorIdUsuario = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_spActivosPorIdUsuario();
            this.spAsignUsuarioRetornaListaIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spAsignUsuarioRetornaListaIdTableAdapter = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_spActivosPorIdUsuarioTableAdapters.spAsignUsuarioRetornaListaIdTableAdapter();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechafinAsignDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicialAsignDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblMisActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_spActivosPorIdUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAsignUsuarioRetornaListaIdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMiPerfil
            // 
            this.lblMiPerfil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMiPerfil.AutoSize = true;
            this.lblMiPerfil.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiPerfil.ForeColor = System.Drawing.Color.DimGray;
            this.lblMiPerfil.Location = new System.Drawing.Point(42, 18);
            this.lblMiPerfil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMiPerfil.Name = "lblMiPerfil";
            this.lblMiPerfil.Size = new System.Drawing.Size(146, 34);
            this.lblMiPerfil.TabIndex = 2;
            this.lblMiPerfil.Text = "Mis Activos";
            this.lblMiPerfil.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tblMisActivos
            // 
            this.tblMisActivos.AllowUserToAddRows = false;
            this.tblMisActivos.AllowUserToDeleteRows = false;
            this.tblMisActivos.AllowUserToOrderColumns = true;
            this.tblMisActivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblMisActivos.AutoGenerateColumns = false;
            this.tblMisActivos.BackgroundColor = System.Drawing.Color.White;
            this.tblMisActivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblMisActivos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblMisActivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblMisActivos.ColumnHeadersHeight = 35;
            this.tblMisActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblMisActivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedulaDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.activoDataGridViewTextBoxColumn,
            this.fechafinAsignDataGridViewTextBoxColumn,
            this.fechaInicialAsignDataGridViewTextBoxColumn});
            this.tblMisActivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tblMisActivos.DataSource = this.spAsignUsuarioRetornaListaIdBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblMisActivos.DefaultCellStyle = dataGridViewCellStyle2;
            this.tblMisActivos.EnableHeadersVisualStyles = false;
            this.tblMisActivos.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.tblMisActivos.Location = new System.Drawing.Point(38, 89);
            this.tblMisActivos.Margin = new System.Windows.Forms.Padding(2);
            this.tblMisActivos.Name = "tblMisActivos";
            this.tblMisActivos.ReadOnly = true;
            this.tblMisActivos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblMisActivos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tblMisActivos.RowHeadersVisible = false;
            this.tblMisActivos.RowHeadersWidth = 49;
            this.tblMisActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblMisActivos.Size = new System.Drawing.Size(695, 326);
            this.tblMisActivos.TabIndex = 3;
            // 
            // btnSolicitarRep
            // 
            this.btnSolicitarRep.Location = new System.Drawing.Point(601, 445);
            this.btnSolicitarRep.Name = "btnSolicitarRep";
            this.btnSolicitarRep.Size = new System.Drawing.Size(132, 37);
            this.btnSolicitarRep.TabIndex = 4;
            this.btnSolicitarRep.Text = "Solicitar Reparación";
            this.btnSolicitarRep.UseVisualStyleBackColor = true;
            // 
            // sEGTRANSADataSource_spActivosPorIdUsuario
            // 
            this.sEGTRANSADataSource_spActivosPorIdUsuario.DataSetName = "SEGTRANSADataSource_spActivosPorIdUsuario";
            this.sEGTRANSADataSource_spActivosPorIdUsuario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spAsignUsuarioRetornaListaIdBindingSource
            // 
            this.spAsignUsuarioRetornaListaIdBindingSource.DataMember = "spAsignUsuarioRetornaListaId";
            this.spAsignUsuarioRetornaListaIdBindingSource.DataSource = this.sEGTRANSADataSource_spActivosPorIdUsuario;
            // 
            // spAsignUsuarioRetornaListaIdTableAdapter
            // 
            this.spAsignUsuarioRetornaListaIdTableAdapter.ClearBeforeFill = true;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cédula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activoDataGridViewTextBoxColumn
            // 
            this.activoDataGridViewTextBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewTextBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewTextBoxColumn.Name = "activoDataGridViewTextBoxColumn";
            this.activoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechafinAsignDataGridViewTextBoxColumn
            // 
            this.fechafinAsignDataGridViewTextBoxColumn.DataPropertyName = "FechafinAsign";
            this.fechafinAsignDataGridViewTextBoxColumn.HeaderText = "Fin de Asignación";
            this.fechafinAsignDataGridViewTextBoxColumn.Name = "fechafinAsignDataGridViewTextBoxColumn";
            this.fechafinAsignDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaInicialAsignDataGridViewTextBoxColumn
            // 
            this.fechaInicialAsignDataGridViewTextBoxColumn.DataPropertyName = "FechaInicialAsign";
            this.fechaInicialAsignDataGridViewTextBoxColumn.HeaderText = "Inicio de Asignación";
            this.fechaInicialAsignDataGridViewTextBoxColumn.Name = "fechaInicialAsignDataGridViewTextBoxColumn";
            this.fechaInicialAsignDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmMisActivos_n
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(797, 513);
            this.Controls.Add(this.btnSolicitarRep);
            this.Controls.Add(this.tblMisActivos);
            this.Controls.Add(this.lblMiPerfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMisActivos_n";
            this.Load += new System.EventHandler(this.FrmMisActivos_n_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblMisActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_spActivosPorIdUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAsignUsuarioRetornaListaIdBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMiPerfil;
        private System.Windows.Forms.DataGridView tblMisActivos;
        private System.Windows.Forms.Button btnSolicitarRep;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAsignDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource spAsignUsuarioRetornaListaIdBindingSource;
        private FrontEnd.DataSources_Forms.SEGTRANSADataSource_spActivosPorIdUsuario sEGTRANSADataSource_spActivosPorIdUsuario;
        private FrontEnd.DataSources_Forms.SEGTRANSADataSource_spActivosPorIdUsuarioTableAdapters.spAsignUsuarioRetornaListaIdTableAdapter spAsignUsuarioRetornaListaIdTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechafinAsignDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicialAsignDataGridViewTextBoxColumn;
    }
}