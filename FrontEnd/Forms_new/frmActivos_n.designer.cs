namespace Frontend
{
    partial class frmMenuPrincipal_n
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
            this.lblActivos = new System.Windows.Forms.Label();
            this.tblDatosActivos = new System.Windows.Forms.DataGridView();
            this.idActivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codActivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioInicialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioActualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.garantiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MesesDepreciacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEGTRANSADataSource_ACTIVOS = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_ACTIVOS();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEGTRANSADataSource_USUARIOS = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_USUARIOS();
            this.sEGTRANSADataSourceUSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_USUARIOSTableAdapters.UsuariosTableAdapter();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnActivoModificar = new System.Windows.Forms.Button();
            this.btnActivoEliminar = new System.Windows.Forms.Button();
            this.btnActivoAgregar = new System.Windows.Forms.Button();
            this.activosTableAdapter = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_ACTIVOSTableAdapters.ActivosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblDatosActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_ACTIVOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_USUARIOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSourceUSUARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblActivos
            // 
            this.lblActivos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblActivos.AutoSize = true;
            this.lblActivos.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivos.ForeColor = System.Drawing.Color.DimGray;
            this.lblActivos.Location = new System.Drawing.Point(378, 3);
            this.lblActivos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActivos.Name = "lblActivos";
            this.lblActivos.Size = new System.Drawing.Size(98, 34);
            this.lblActivos.TabIndex = 2;
            this.lblActivos.Text = "Activos";
            this.lblActivos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tblDatosActivos
            // 
            this.tblDatosActivos.AllowUserToAddRows = false;
            this.tblDatosActivos.AllowUserToDeleteRows = false;
            this.tblDatosActivos.AllowUserToOrderColumns = true;
            this.tblDatosActivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblDatosActivos.AutoGenerateColumns = false;
            this.tblDatosActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblDatosActivos.BackgroundColor = System.Drawing.Color.White;
            this.tblDatosActivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblDatosActivos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblDatosActivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblDatosActivos.ColumnHeadersHeight = 35;
            this.tblDatosActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblDatosActivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idActivoDataGridViewTextBoxColumn,
            this.codActivoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.precioInicialDataGridViewTextBoxColumn,
            this.precioActualDataGridViewTextBoxColumn,
            this.fechaCompraDataGridViewTextBoxColumn,
            this.garantiaDataGridViewTextBoxColumn,
            this.MesesDepreciacion});
            this.tblDatosActivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tblDatosActivos.DataSource = this.activosBindingSource;
            this.tblDatosActivos.EnableHeadersVisualStyles = false;
            this.tblDatosActivos.GridColor = System.Drawing.Color.MidnightBlue;
            this.tblDatosActivos.Location = new System.Drawing.Point(24, 84);
            this.tblDatosActivos.Margin = new System.Windows.Forms.Padding(2);
            this.tblDatosActivos.MultiSelect = false;
            this.tblDatosActivos.Name = "tblDatosActivos";
            this.tblDatosActivos.ReadOnly = true;
            this.tblDatosActivos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblDatosActivos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tblDatosActivos.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.tblDatosActivos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tblDatosActivos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.tblDatosActivos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.tblDatosActivos.RowTemplate.Height = 25;
            this.tblDatosActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblDatosActivos.Size = new System.Drawing.Size(852, 326);
            this.tblDatosActivos.TabIndex = 4;
            // 
            // idActivoDataGridViewTextBoxColumn
            // 
            this.idActivoDataGridViewTextBoxColumn.DataPropertyName = "IdActivo";
            this.idActivoDataGridViewTextBoxColumn.HeaderText = "Id Activo";
            this.idActivoDataGridViewTextBoxColumn.Name = "idActivoDataGridViewTextBoxColumn";
            this.idActivoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codActivoDataGridViewTextBoxColumn
            // 
            this.codActivoDataGridViewTextBoxColumn.DataPropertyName = "CodActivo";
            this.codActivoDataGridViewTextBoxColumn.HeaderText = "Codigo del Activo";
            this.codActivoDataGridViewTextBoxColumn.Name = "codActivoDataGridViewTextBoxColumn";
            this.codActivoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioInicialDataGridViewTextBoxColumn
            // 
            this.precioInicialDataGridViewTextBoxColumn.DataPropertyName = "PrecioInicial";
            this.precioInicialDataGridViewTextBoxColumn.HeaderText = "Precio Inicial";
            this.precioInicialDataGridViewTextBoxColumn.Name = "precioInicialDataGridViewTextBoxColumn";
            this.precioInicialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioActualDataGridViewTextBoxColumn
            // 
            this.precioActualDataGridViewTextBoxColumn.DataPropertyName = "PrecioActual";
            this.precioActualDataGridViewTextBoxColumn.HeaderText = "Precio Actual";
            this.precioActualDataGridViewTextBoxColumn.Name = "precioActualDataGridViewTextBoxColumn";
            this.precioActualDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaCompraDataGridViewTextBoxColumn
            // 
            this.fechaCompraDataGridViewTextBoxColumn.DataPropertyName = "FechaCompra";
            this.fechaCompraDataGridViewTextBoxColumn.HeaderText = "Fecha de Compra";
            this.fechaCompraDataGridViewTextBoxColumn.Name = "fechaCompraDataGridViewTextBoxColumn";
            this.fechaCompraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // garantiaDataGridViewTextBoxColumn
            // 
            this.garantiaDataGridViewTextBoxColumn.DataPropertyName = "Garantia";
            this.garantiaDataGridViewTextBoxColumn.HeaderText = "Garantía";
            this.garantiaDataGridViewTextBoxColumn.Name = "garantiaDataGridViewTextBoxColumn";
            this.garantiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MesesDepreciacion
            // 
            this.MesesDepreciacion.DataPropertyName = "MesesDepreciacion";
            this.MesesDepreciacion.HeaderText = "Meses Depreciacion";
            this.MesesDepreciacion.Name = "MesesDepreciacion";
            this.MesesDepreciacion.ReadOnly = true;
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
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBusqueda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBusqueda.Location = new System.Drawing.Point(308, 49);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(237, 23);
            this.txtBusqueda.TabIndex = 0;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::FrontEnd.Properties.Resources.big_loupe1;
            this.pictureBox1.Location = new System.Drawing.Point(551, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 24);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnActivoModificar
            // 
            this.btnActivoModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnActivoModificar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnActivoModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivoModificar.FlatAppearance.BorderSize = 0;
            this.btnActivoModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivoModificar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivoModificar.ForeColor = System.Drawing.Color.White;
            this.btnActivoModificar.Image = global::FrontEnd.Properties.Resources.update;
            this.btnActivoModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivoModificar.Location = new System.Drawing.Point(395, 443);
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
            this.btnActivoEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnActivoEliminar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnActivoEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivoEliminar.FlatAppearance.BorderSize = 0;
            this.btnActivoEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivoEliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivoEliminar.ForeColor = System.Drawing.Color.White;
            this.btnActivoEliminar.Image = global::FrontEnd.Properties.Resources.minus_button;
            this.btnActivoEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivoEliminar.Location = new System.Drawing.Point(542, 443);
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
            this.btnActivoAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnActivoAgregar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnActivoAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivoAgregar.FlatAppearance.BorderSize = 0;
            this.btnActivoAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivoAgregar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivoAgregar.ForeColor = System.Drawing.Color.White;
            this.btnActivoAgregar.Image = global::FrontEnd.Properties.Resources.add;
            this.btnActivoAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivoAgregar.Location = new System.Drawing.Point(248, 442);
            this.btnActivoAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActivoAgregar.Name = "btnActivoAgregar";
            this.btnActivoAgregar.Size = new System.Drawing.Size(110, 36);
            this.btnActivoAgregar.TabIndex = 1;
            this.btnActivoAgregar.Text = "Agregar";
            this.btnActivoAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActivoAgregar.UseVisualStyleBackColor = false;
            this.btnActivoAgregar.Click += new System.EventHandler(this.btnActivoAgregar_Click);
            // 
            // activosTableAdapter
            // 
            this.activosTableAdapter.ClearBeforeFill = true;
            // 
            // frmMenuPrincipal_n
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(901, 513);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnActivoModificar);
            this.Controls.Add(this.btnActivoEliminar);
            this.Controls.Add(this.tblDatosActivos);
            this.Controls.Add(this.lblActivos);
            this.Controls.Add(this.btnActivoAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMenuPrincipal_n";
            this.Load += new System.EventHandler(this.frmActivos_n_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblDatosActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_ACTIVOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_USUARIOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSourceUSUARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnActivoAgregar;
        private System.Windows.Forms.Label lblActivos;
        private System.Windows.Forms.DataGridView tblDatosActivos;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idActivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codActivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioInicialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioActualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn garantiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MesesDepreciacion;
    }
}