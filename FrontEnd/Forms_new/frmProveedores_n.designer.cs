namespace Frontend
{
    partial class FrmProveedores_n
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
            this.lblProveedores = new System.Windows.Forms.Label();
            this.tblDatosProveedores = new System.Windows.Forms.DataGridView();
            this.idProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEGTRANSADataSource_PROVEEDORES = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_PROVEEDORES();
            this.btnProveedorModificar = new System.Windows.Forms.Button();
            this.btnProveedorEliminar = new System.Windows.Forms.Button();
            this.btnProveedorAgregar = new System.Windows.Forms.Button();
            this.proveedoresTableAdapter = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_PROVEEDORESTableAdapters.ProveedoresTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblDatosProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_PROVEEDORES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProveedores
            // 
            this.lblProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedores.ForeColor = System.Drawing.Color.DimGray;
            this.lblProveedores.Location = new System.Drawing.Point(42, 18);
            this.lblProveedores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(158, 34);
            this.lblProveedores.TabIndex = 2;
            this.lblProveedores.Text = "Proveedores";
            this.lblProveedores.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tblDatosProveedores
            // 
            this.tblDatosProveedores.AllowUserToAddRows = false;
            this.tblDatosProveedores.AllowUserToDeleteRows = false;
            this.tblDatosProveedores.AllowUserToOrderColumns = true;
            this.tblDatosProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblDatosProveedores.AutoGenerateColumns = false;
            this.tblDatosProveedores.BackgroundColor = System.Drawing.Color.White;
            this.tblDatosProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblDatosProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblDatosProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblDatosProveedores.ColumnHeadersHeight = 35;
            this.tblDatosProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblDatosProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProveedorDataGridViewTextBoxColumn,
            this.nombreProveedorDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn});
            this.tblDatosProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tblDatosProveedores.DataSource = this.proveedoresBindingSource;
            this.tblDatosProveedores.EnableHeadersVisualStyles = false;
            this.tblDatosProveedores.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.tblDatosProveedores.Location = new System.Drawing.Point(116, 99);
            this.tblDatosProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.tblDatosProveedores.Name = "tblDatosProveedores";
            this.tblDatosProveedores.ReadOnly = true;
            this.tblDatosProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblDatosProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tblDatosProveedores.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.tblDatosProveedores.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tblDatosProveedores.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.tblDatosProveedores.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.tblDatosProveedores.RowTemplate.Height = 25;
            this.tblDatosProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblDatosProveedores.Size = new System.Drawing.Size(501, 326);
            this.tblDatosProveedores.TabIndex = 4;
            // 
            // idProveedorDataGridViewTextBoxColumn
            // 
            this.idProveedorDataGridViewTextBoxColumn.DataPropertyName = "IdProveedor";
            this.idProveedorDataGridViewTextBoxColumn.HeaderText = "Id Proveedor";
            this.idProveedorDataGridViewTextBoxColumn.Name = "idProveedorDataGridViewTextBoxColumn";
            this.idProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreProveedorDataGridViewTextBoxColumn
            // 
            this.nombreProveedorDataGridViewTextBoxColumn.DataPropertyName = "NombreProveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.HeaderText = "Nombre del Proveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.Name = "nombreProveedorDataGridViewTextBoxColumn";
            this.nombreProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.sEGTRANSADataSource_PROVEEDORES;
            // 
            // sEGTRANSADataSource_PROVEEDORES
            // 
            this.sEGTRANSADataSource_PROVEEDORES.DataSetName = "SEGTRANSADataSource_PROVEEDORES";
            this.sEGTRANSADataSource_PROVEEDORES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnProveedorModificar
            // 
            this.btnProveedorModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProveedorModificar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnProveedorModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedorModificar.FlatAppearance.BorderSize = 0;
            this.btnProveedorModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedorModificar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedorModificar.ForeColor = System.Drawing.Color.White;
            this.btnProveedorModificar.Image = global::FrontEnd.Properties.Resources.curved_arrows;
            this.btnProveedorModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedorModificar.Location = new System.Drawing.Point(310, 446);
            this.btnProveedorModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnProveedorModificar.Name = "btnProveedorModificar";
            this.btnProveedorModificar.Size = new System.Drawing.Size(110, 36);
            this.btnProveedorModificar.TabIndex = 6;
            this.btnProveedorModificar.Text = "Modificar";
            this.btnProveedorModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProveedorModificar.UseVisualStyleBackColor = false;
            this.btnProveedorModificar.Click += new System.EventHandler(this.btnProveedorModificar_Click);
            // 
            // btnProveedorEliminar
            // 
            this.btnProveedorEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProveedorEliminar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnProveedorEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedorEliminar.FlatAppearance.BorderSize = 0;
            this.btnProveedorEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedorEliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedorEliminar.ForeColor = System.Drawing.Color.White;
            this.btnProveedorEliminar.Image = global::FrontEnd.Properties.Resources.minus_button;
            this.btnProveedorEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedorEliminar.Location = new System.Drawing.Point(456, 446);
            this.btnProveedorEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnProveedorEliminar.Name = "btnProveedorEliminar";
            this.btnProveedorEliminar.Size = new System.Drawing.Size(110, 36);
            this.btnProveedorEliminar.TabIndex = 5;
            this.btnProveedorEliminar.Text = "Eliminar";
            this.btnProveedorEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProveedorEliminar.UseVisualStyleBackColor = false;
            this.btnProveedorEliminar.Click += new System.EventHandler(this.btnProveedorEliminar_Click);
            // 
            // btnProveedorAgregar
            // 
            this.btnProveedorAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProveedorAgregar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnProveedorAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedorAgregar.FlatAppearance.BorderSize = 0;
            this.btnProveedorAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedorAgregar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedorAgregar.ForeColor = System.Drawing.Color.White;
            this.btnProveedorAgregar.Image = global::FrontEnd.Properties.Resources.plus_button;
            this.btnProveedorAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedorAgregar.Location = new System.Drawing.Point(161, 446);
            this.btnProveedorAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnProveedorAgregar.Name = "btnProveedorAgregar";
            this.btnProveedorAgregar.Size = new System.Drawing.Size(110, 36);
            this.btnProveedorAgregar.TabIndex = 1;
            this.btnProveedorAgregar.Text = "Agregar";
            this.btnProveedorAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProveedorAgregar.UseVisualStyleBackColor = false;
            this.btnProveedorAgregar.Click += new System.EventHandler(this.btnProveedorAgregar_Click);
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrontEnd.Properties.Resources.big_loupe1;
            this.pictureBox1.Location = new System.Drawing.Point(727, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBusqueda.Location = new System.Drawing.Point(481, 21);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(237, 23);
            this.txtBusqueda.TabIndex = 8;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // FrmProveedores_n
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(797, 513);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnProveedorModificar);
            this.Controls.Add(this.btnProveedorEliminar);
            this.Controls.Add(this.tblDatosProveedores);
            this.Controls.Add(this.lblProveedores);
            this.Controls.Add(this.btnProveedorAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmProveedores_n";
            this.Load += new System.EventHandler(this.frmProveedores_n_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblDatosProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_PROVEEDORES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProveedorAgregar;
        private System.Windows.Forms.Label lblProveedores;
        private System.Windows.Forms.DataGridView tblDatosProveedores;
        private System.Windows.Forms.Button btnProveedorEliminar;
        private System.Windows.Forms.Button btnProveedorModificar;
        private FrontEnd.DataSources_Forms.SEGTRANSADataSource_PROVEEDORES sEGTRANSADataSource_PROVEEDORES;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private FrontEnd.DataSources_Forms.SEGTRANSADataSource_PROVEEDORESTableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
    }
}