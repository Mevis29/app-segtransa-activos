namespace Frontend
{
    partial class FrmAsignaciones_n
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
            this.lblAsignaciones = new System.Windows.Forms.Label();
            this.tblDatosAsignaciones = new System.Windows.Forms.DataGridView();
            this.idAsignacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idActivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicialAsignacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechafinalAsignacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHAsignacionesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sEGTRANSADataSourceASIGNACIONESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEGTRANSADataSource_ASIGNACIONES = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_ASIGNACIONES();
            this.spAsignUsuarioRetornaListaTotalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEGTRANSADataSource_spListaTotalAsignaciones = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_spListaTotalAsignaciones();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAsignModificar = new System.Windows.Forms.Button();
            this.btnAsignEliminar = new System.Windows.Forms.Button();
            this.btnAsignAgregar = new System.Windows.Forms.Button();
            this.spAsignUsuarioRetornaListaTotalTableAdapter = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_spListaTotalAsignacionesTableAdapters.spAsignUsuarioRetornaListaTotalTableAdapter();
            this.tHAsignacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHAsignacionesTableAdapter = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_ASIGNACIONESTableAdapters.THAsignacionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblDatosAsignaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHAsignacionesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSourceASIGNACIONESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_ASIGNACIONES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAsignUsuarioRetornaListaTotalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_spListaTotalAsignaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHAsignacionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAsignaciones
            // 
            this.lblAsignaciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAsignaciones.AutoSize = true;
            this.lblAsignaciones.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignaciones.ForeColor = System.Drawing.Color.Navy;
            this.lblAsignaciones.Location = new System.Drawing.Point(32, 36);
            this.lblAsignaciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAsignaciones.Name = "lblAsignaciones";
            this.lblAsignaciones.Size = new System.Drawing.Size(205, 36);
            this.lblAsignaciones.TabIndex = 2;
            this.lblAsignaciones.Text = "Asignaciones";
            this.lblAsignaciones.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tblDatosAsignaciones
            // 
            this.tblDatosAsignaciones.AllowUserToAddRows = false;
            this.tblDatosAsignaciones.AllowUserToDeleteRows = false;
            this.tblDatosAsignaciones.AllowUserToOrderColumns = true;
            this.tblDatosAsignaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblDatosAsignaciones.AutoGenerateColumns = false;
            this.tblDatosAsignaciones.BackgroundColor = System.Drawing.Color.White;
            this.tblDatosAsignaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblDatosAsignaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblDatosAsignaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblDatosAsignaciones.ColumnHeadersHeight = 35;
            this.tblDatosAsignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblDatosAsignaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAsignacionDataGridViewTextBoxColumn,
            this.idUsuarioDataGridViewTextBoxColumn,
            this.idActivoDataGridViewTextBoxColumn,
            this.fechaInicialAsignacionDataGridViewTextBoxColumn,
            this.fechafinalAsignacionDataGridViewTextBoxColumn});
            this.tblDatosAsignaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tblDatosAsignaciones.DataSource = this.tHAsignacionesBindingSource1;
            this.tblDatosAsignaciones.EnableHeadersVisualStyles = false;
            this.tblDatosAsignaciones.GridColor = System.Drawing.Color.MidnightBlue;
            this.tblDatosAsignaciones.Location = new System.Drawing.Point(38, 99);
            this.tblDatosAsignaciones.Margin = new System.Windows.Forms.Padding(2);
            this.tblDatosAsignaciones.Name = "tblDatosAsignaciones";
            this.tblDatosAsignaciones.ReadOnly = true;
            this.tblDatosAsignaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblDatosAsignaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tblDatosAsignaciones.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.tblDatosAsignaciones.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tblDatosAsignaciones.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.tblDatosAsignaciones.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.tblDatosAsignaciones.RowTemplate.Height = 25;
            this.tblDatosAsignaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblDatosAsignaciones.Size = new System.Drawing.Size(703, 326);
            this.tblDatosAsignaciones.TabIndex = 4;
            // 
            // idAsignacionDataGridViewTextBoxColumn
            // 
            this.idAsignacionDataGridViewTextBoxColumn.DataPropertyName = "IdAsignacion";
            this.idAsignacionDataGridViewTextBoxColumn.HeaderText = "IdAsignacion";
            this.idAsignacionDataGridViewTextBoxColumn.Name = "idAsignacionDataGridViewTextBoxColumn";
            this.idAsignacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idActivoDataGridViewTextBoxColumn
            // 
            this.idActivoDataGridViewTextBoxColumn.DataPropertyName = "IdActivo";
            this.idActivoDataGridViewTextBoxColumn.HeaderText = "IdActivo";
            this.idActivoDataGridViewTextBoxColumn.Name = "idActivoDataGridViewTextBoxColumn";
            this.idActivoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaInicialAsignacionDataGridViewTextBoxColumn
            // 
            this.fechaInicialAsignacionDataGridViewTextBoxColumn.DataPropertyName = "FechaInicialAsignacion";
            this.fechaInicialAsignacionDataGridViewTextBoxColumn.HeaderText = "FechaInicialAsignacion";
            this.fechaInicialAsignacionDataGridViewTextBoxColumn.Name = "fechaInicialAsignacionDataGridViewTextBoxColumn";
            this.fechaInicialAsignacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechafinalAsignacionDataGridViewTextBoxColumn
            // 
            this.fechafinalAsignacionDataGridViewTextBoxColumn.DataPropertyName = "FechafinalAsignacion";
            this.fechafinalAsignacionDataGridViewTextBoxColumn.HeaderText = "FechafinalAsignacion";
            this.fechafinalAsignacionDataGridViewTextBoxColumn.Name = "fechafinalAsignacionDataGridViewTextBoxColumn";
            this.fechafinalAsignacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tHAsignacionesBindingSource1
            // 
            this.tHAsignacionesBindingSource1.DataMember = "THAsignaciones";
            this.tHAsignacionesBindingSource1.DataSource = this.sEGTRANSADataSourceASIGNACIONESBindingSource;
            // 
            // sEGTRANSADataSourceASIGNACIONESBindingSource
            // 
            this.sEGTRANSADataSourceASIGNACIONESBindingSource.DataSource = this.sEGTRANSADataSource_ASIGNACIONES;
            this.sEGTRANSADataSourceASIGNACIONESBindingSource.Position = 0;
            // 
            // sEGTRANSADataSource_ASIGNACIONES
            // 
            this.sEGTRANSADataSource_ASIGNACIONES.DataSetName = "SEGTRANSADataSource_ASIGNACIONES";
            this.sEGTRANSADataSource_ASIGNACIONES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBusqueda.Location = new System.Drawing.Point(459, 36);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(237, 23);
            this.txtBusqueda.TabIndex = 0;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrontEnd.Properties.Resources.big_loupe1;
            this.pictureBox1.Location = new System.Drawing.Point(705, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnAsignModificar
            // 
            this.btnAsignModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAsignModificar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAsignModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignModificar.FlatAppearance.BorderSize = 0;
            this.btnAsignModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignModificar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignModificar.ForeColor = System.Drawing.Color.White;
            this.btnAsignModificar.Image = global::FrontEnd.Properties.Resources.update;
            this.btnAsignModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignModificar.Location = new System.Drawing.Point(310, 446);
            this.btnAsignModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsignModificar.Name = "btnAsignModificar";
            this.btnAsignModificar.Size = new System.Drawing.Size(110, 36);
            this.btnAsignModificar.TabIndex = 6;
            this.btnAsignModificar.Text = "Modificar";
            this.btnAsignModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsignModificar.UseVisualStyleBackColor = false;
            this.btnAsignModificar.Click += new System.EventHandler(this.btnAsignModificar_Click);
            // 
            // btnAsignEliminar
            // 
            this.btnAsignEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAsignEliminar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAsignEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignEliminar.FlatAppearance.BorderSize = 0;
            this.btnAsignEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignEliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignEliminar.ForeColor = System.Drawing.Color.White;
            this.btnAsignEliminar.Image = global::FrontEnd.Properties.Resources.minus_button;
            this.btnAsignEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignEliminar.Location = new System.Drawing.Point(456, 446);
            this.btnAsignEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsignEliminar.Name = "btnAsignEliminar";
            this.btnAsignEliminar.Size = new System.Drawing.Size(110, 36);
            this.btnAsignEliminar.TabIndex = 5;
            this.btnAsignEliminar.Text = "Eliminar";
            this.btnAsignEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsignEliminar.UseVisualStyleBackColor = false;
            this.btnAsignEliminar.Click += new System.EventHandler(this.btnAsignEliminar_Click);
            // 
            // btnAsignAgregar
            // 
            this.btnAsignAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAsignAgregar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAsignAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignAgregar.FlatAppearance.BorderSize = 0;
            this.btnAsignAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignAgregar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAsignAgregar.Image = global::FrontEnd.Properties.Resources.add;
            this.btnAsignAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignAgregar.Location = new System.Drawing.Point(161, 446);
            this.btnAsignAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsignAgregar.Name = "btnAsignAgregar";
            this.btnAsignAgregar.Size = new System.Drawing.Size(110, 36);
            this.btnAsignAgregar.TabIndex = 1;
            this.btnAsignAgregar.Text = "Agregar";
            this.btnAsignAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsignAgregar.UseVisualStyleBackColor = false;
            this.btnAsignAgregar.Click += new System.EventHandler(this.btnAsignAgregar_Click);
            // 
            // spAsignUsuarioRetornaListaTotalTableAdapter
            // 
            this.spAsignUsuarioRetornaListaTotalTableAdapter.ClearBeforeFill = true;
            // 
            // tHAsignacionesBindingSource
            // 
            this.tHAsignacionesBindingSource.DataMember = "THAsignaciones";
            this.tHAsignacionesBindingSource.DataSource = this.sEGTRANSADataSourceASIGNACIONESBindingSource;
            // 
            // tHAsignacionesTableAdapter
            // 
            this.tHAsignacionesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAsignaciones_n
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(797, 513);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnAsignModificar);
            this.Controls.Add(this.btnAsignEliminar);
            this.Controls.Add(this.tblDatosAsignaciones);
            this.Controls.Add(this.lblAsignaciones);
            this.Controls.Add(this.btnAsignAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAsignaciones_n";
            this.Load += new System.EventHandler(this.frmAsignaciones_n_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblDatosAsignaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHAsignacionesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSourceASIGNACIONESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_ASIGNACIONES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAsignUsuarioRetornaListaTotalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_spListaTotalAsignaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHAsignacionesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAsignAgregar;
        private System.Windows.Forms.Label lblAsignaciones;
        private System.Windows.Forms.DataGridView tblDatosAsignaciones;
        private System.Windows.Forms.Button btnAsignEliminar;
        private System.Windows.Forms.Button btnAsignModificar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource sEGTRANSADataSourceASIGNACIONESBindingSource;
        private FrontEnd.DataSources_Forms.SEGTRANSADataSource_ASIGNACIONES sEGTRANSADataSource_ASIGNACIONES;
        private FrontEnd.DataSources_Forms.SEGTRANSADataSource_spListaTotalAsignaciones sEGTRANSADataSource_spListaTotalAsignaciones;
        private System.Windows.Forms.BindingSource spAsignUsuarioRetornaListaTotalBindingSource;
        private FrontEnd.DataSources_Forms.SEGTRANSADataSource_spListaTotalAsignacionesTableAdapters.spAsignUsuarioRetornaListaTotalTableAdapter spAsignUsuarioRetornaListaTotalTableAdapter;
        private System.Windows.Forms.BindingSource tHAsignacionesBindingSource;
        private FrontEnd.DataSources_Forms.SEGTRANSADataSource_ASIGNACIONESTableAdapters.THAsignacionesTableAdapter tHAsignacionesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAsignacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idActivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicialAsignacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechafinalAsignacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tHAsignacionesBindingSource1;
    }
}