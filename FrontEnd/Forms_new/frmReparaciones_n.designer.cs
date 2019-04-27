namespace Frontend
{
    partial class FrmReparaciones_n
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
            this.lblReparaciones = new System.Windows.Forms.Label();
            this.activosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEGTRANSADataSource_ACTIVOS = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_ACTIVOS();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEGTRANSADataSource_USUARIOS = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_USUARIOS();
            this.sEGTRANSADataSourceUSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_USUARIOSTableAdapters.UsuariosTableAdapter();
            this.activosTableAdapter = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_ACTIVOSTableAdapters.ActivosTableAdapter();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnActivoModificar = new System.Windows.Forms.Button();
            this.btnActivoEliminar = new System.Windows.Forms.Button();
            this.btnActivoAgregar = new System.Windows.Forms.Button();
            this.tblReparaciones = new System.Windows.Forms.DataGridView();
            this.idReparacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idActivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicialReparacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechafinalReparacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHReparacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEGTRANSADataSource_REPARACIONES = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_REPARACIONES();
            this.tHReparacionesTableAdapter = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_REPARACIONESTableAdapters.THReparacionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_ACTIVOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_USUARIOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSourceUSUARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReparaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHReparacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_REPARACIONES)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReparaciones
            // 
            this.lblReparaciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReparaciones.AutoSize = true;
            this.lblReparaciones.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReparaciones.ForeColor = System.Drawing.Color.Navy;
            this.lblReparaciones.Location = new System.Drawing.Point(32, 26);
            this.lblReparaciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReparaciones.Name = "lblReparaciones";
            this.lblReparaciones.Size = new System.Drawing.Size(214, 36);
            this.lblReparaciones.TabIndex = 2;
            this.lblReparaciones.Text = "Reparaciones";
            this.lblReparaciones.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // activosBindingSource
            // 
            this.activosBindingSource.DataMember = "Activos";
            this.activosBindingSource.DataSource = this.sEGTRANSADataSource_ACTIVOS;
            // 
            // sEGTRANSADataSource_ACTIVOS
            // 
            this.sEGTRANSADataSource_ACTIVOS.DataSetName = "SEGTRANSADataSource_ACTIVOS";
            this.sEGTRANSADataSource_ACTIVOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.sEGTRANSADataSource_USUARIOS;
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
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // activosTableAdapter
            // 
            this.activosTableAdapter.ClearBeforeFill = true;
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
            // btnActivoModificar
            // 
            this.btnActivoModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActivoModificar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnActivoModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivoModificar.FlatAppearance.BorderSize = 0;
            this.btnActivoModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivoModificar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivoModificar.ForeColor = System.Drawing.Color.White;
            this.btnActivoModificar.Image = global::FrontEnd.Properties.Resources.update;
            this.btnActivoModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivoModificar.Location = new System.Drawing.Point(310, 446);
            this.btnActivoModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActivoModificar.Name = "btnActivoModificar";
            this.btnActivoModificar.Size = new System.Drawing.Size(110, 36);
            this.btnActivoModificar.TabIndex = 6;
            this.btnActivoModificar.Text = "Modificar";
            this.btnActivoModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActivoModificar.UseVisualStyleBackColor = false;
            this.btnActivoModificar.Click += new System.EventHandler(this.btnActivoModificar_Click);
            // 
            // btnActivoEliminar
            // 
            this.btnActivoEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActivoEliminar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnActivoEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivoEliminar.FlatAppearance.BorderSize = 0;
            this.btnActivoEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivoEliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivoEliminar.ForeColor = System.Drawing.Color.White;
            this.btnActivoEliminar.Image = global::FrontEnd.Properties.Resources.minus_button;
            this.btnActivoEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivoEliminar.Location = new System.Drawing.Point(456, 446);
            this.btnActivoEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActivoEliminar.Name = "btnActivoEliminar";
            this.btnActivoEliminar.Size = new System.Drawing.Size(110, 36);
            this.btnActivoEliminar.TabIndex = 5;
            this.btnActivoEliminar.Text = "Eliminar";
            this.btnActivoEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActivoEliminar.UseVisualStyleBackColor = false;
            this.btnActivoEliminar.Click += new System.EventHandler(this.btnActivoEliminar_Click);
            // 
            // btnActivoAgregar
            // 
            this.btnActivoAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActivoAgregar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnActivoAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivoAgregar.FlatAppearance.BorderSize = 0;
            this.btnActivoAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivoAgregar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivoAgregar.ForeColor = System.Drawing.Color.White;
            this.btnActivoAgregar.Image = global::FrontEnd.Properties.Resources.add;
            this.btnActivoAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivoAgregar.Location = new System.Drawing.Point(161, 446);
            this.btnActivoAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActivoAgregar.Name = "btnActivoAgregar";
            this.btnActivoAgregar.Size = new System.Drawing.Size(110, 36);
            this.btnActivoAgregar.TabIndex = 1;
            this.btnActivoAgregar.Text = "Agregar";
            this.btnActivoAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActivoAgregar.UseVisualStyleBackColor = false;
            this.btnActivoAgregar.Click += new System.EventHandler(this.btnActivoAgregar_Click);
            // 
            // tblReparaciones
            // 
            this.tblReparaciones.AutoGenerateColumns = false;
            this.tblReparaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblReparaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReparacionDataGridViewTextBoxColumn,
            this.idActivoDataGridViewTextBoxColumn,
            this.fechaInicialReparacionDataGridViewTextBoxColumn,
            this.fechafinalReparacionDataGridViewTextBoxColumn});
            this.tblReparaciones.DataSource = this.tHReparacionesBindingSource;
            this.tblReparaciones.Location = new System.Drawing.Point(38, 103);
            this.tblReparaciones.Name = "tblReparaciones";
            this.tblReparaciones.Size = new System.Drawing.Size(674, 315);
            this.tblReparaciones.TabIndex = 8;
            // 
            // idReparacionDataGridViewTextBoxColumn
            // 
            this.idReparacionDataGridViewTextBoxColumn.DataPropertyName = "IdReparacion";
            this.idReparacionDataGridViewTextBoxColumn.HeaderText = "IdReparacion";
            this.idReparacionDataGridViewTextBoxColumn.Name = "idReparacionDataGridViewTextBoxColumn";
            this.idReparacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idActivoDataGridViewTextBoxColumn
            // 
            this.idActivoDataGridViewTextBoxColumn.DataPropertyName = "IdActivo";
            this.idActivoDataGridViewTextBoxColumn.HeaderText = "IdActivo";
            this.idActivoDataGridViewTextBoxColumn.Name = "idActivoDataGridViewTextBoxColumn";
            // 
            // fechaInicialReparacionDataGridViewTextBoxColumn
            // 
            this.fechaInicialReparacionDataGridViewTextBoxColumn.DataPropertyName = "FechaInicialReparacion";
            this.fechaInicialReparacionDataGridViewTextBoxColumn.HeaderText = "FechaInicialReparacion";
            this.fechaInicialReparacionDataGridViewTextBoxColumn.Name = "fechaInicialReparacionDataGridViewTextBoxColumn";
            // 
            // fechafinalReparacionDataGridViewTextBoxColumn
            // 
            this.fechafinalReparacionDataGridViewTextBoxColumn.DataPropertyName = "FechafinalReparacion";
            this.fechafinalReparacionDataGridViewTextBoxColumn.HeaderText = "FechafinalReparacion";
            this.fechafinalReparacionDataGridViewTextBoxColumn.Name = "fechafinalReparacionDataGridViewTextBoxColumn";
            // 
            // tHReparacionesBindingSource
            // 
            this.tHReparacionesBindingSource.DataMember = "THReparaciones";
            this.tHReparacionesBindingSource.DataSource = this.sEGTRANSADataSource_REPARACIONES;
            // 
            // sEGTRANSADataSource_REPARACIONES
            // 
            this.sEGTRANSADataSource_REPARACIONES.DataSetName = "SEGTRANSADataSource_REPARACIONES";
            this.sEGTRANSADataSource_REPARACIONES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tHReparacionesTableAdapter
            // 
            this.tHReparacionesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReparaciones_n
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(797, 513);
            this.Controls.Add(this.tblReparaciones);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnActivoModificar);
            this.Controls.Add(this.btnActivoEliminar);
            this.Controls.Add(this.lblReparaciones);
            this.Controls.Add(this.btnActivoAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmReparaciones_n";
            this.Load += new System.EventHandler(this.frmActivos_n_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_ACTIVOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_USUARIOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSourceUSUARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReparaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHReparacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_REPARACIONES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnActivoAgregar;
        private System.Windows.Forms.Label lblReparaciones;
        private System.Windows.Forms.Button btnActivoEliminar;
        private System.Windows.Forms.BindingSource sEGTRANSADataSourceUSUARIOSBindingSource;
        private FrontEnd.DataSources_Forms.SEGTRANSADataSource_USUARIOS sEGTRANSADataSource_USUARIOS;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private FrontEnd.DataSources_Forms.SEGTRANSADataSource_USUARIOSTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.Button btnActivoModificar;
        private FrontEnd.DataSources_Forms.SEGTRANSADataSource_ACTIVOS sEGTRANSADataSource_ACTIVOS;
        private System.Windows.Forms.BindingSource activosBindingSource;
        private FrontEnd.DataSources_Forms.SEGTRANSADataSource_ACTIVOSTableAdapters.ActivosTableAdapter activosTableAdapter;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView tblReparaciones;
        private FrontEnd.DataSources_Forms.SEGTRANSADataSource_REPARACIONES sEGTRANSADataSource_REPARACIONES;
        private System.Windows.Forms.BindingSource tHReparacionesBindingSource;
        private FrontEnd.DataSources_Forms.SEGTRANSADataSource_REPARACIONESTableAdapters.THReparacionesTableAdapter tHReparacionesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReparacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idActivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicialReparacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechafinalReparacionDataGridViewTextBoxColumn;
    }
}