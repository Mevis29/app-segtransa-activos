namespace Frontend
{
    partial class FrmUsuarios_n
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
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.tblDatosUsuarios = new System.Windows.Forms.DataGridView();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEGTRANSADataSource_USUARIOS = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_USUARIOS();
            this.sEGTRANSADataSourceUSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_USUARIOSTableAdapters.UsuariosTableAdapter();
            this.txtBusquedaU = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUsuarioModificar = new System.Windows.Forms.Button();
            this.btnUsuarioEliminar = new System.Windows.Forms.Button();
            this.btnUsuarioAgregar = new System.Windows.Forms.Button();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaUltLoginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblDatosUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_USUARIOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSourceUSUARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.ForeColor = System.Drawing.Color.Navy;
            this.lblUsuarios.Location = new System.Drawing.Point(32, 21);
            this.lblUsuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(118, 33);
            this.lblUsuarios.TabIndex = 2;
            this.lblUsuarios.Text = "Usuarios";
            this.lblUsuarios.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tblDatosUsuarios
            // 
            this.tblDatosUsuarios.AllowUserToAddRows = false;
            this.tblDatosUsuarios.AllowUserToDeleteRows = false;
            this.tblDatosUsuarios.AllowUserToOrderColumns = true;
            this.tblDatosUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblDatosUsuarios.AutoGenerateColumns = false;
            this.tblDatosUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.tblDatosUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblDatosUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblDatosUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblDatosUsuarios.ColumnHeadersHeight = 35;
            this.tblDatosUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblDatosUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuarioDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.cedulaDataGridViewTextBoxColumn,
            this.contrasenaDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.fechaCreacionDataGridViewTextBoxColumn,
            this.fechaUltLoginDataGridViewTextBoxColumn});
            this.tblDatosUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tblDatosUsuarios.DataSource = this.usuariosBindingSource;
            this.tblDatosUsuarios.EnableHeadersVisualStyles = false;
            this.tblDatosUsuarios.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.tblDatosUsuarios.Location = new System.Drawing.Point(38, 89);
            this.tblDatosUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.tblDatosUsuarios.Name = "tblDatosUsuarios";
            this.tblDatosUsuarios.ReadOnly = true;
            this.tblDatosUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblDatosUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tblDatosUsuarios.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.tblDatosUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tblDatosUsuarios.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.tblDatosUsuarios.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.tblDatosUsuarios.RowTemplate.Height = 25;
            this.tblDatosUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblDatosUsuarios.Size = new System.Drawing.Size(703, 326);
            this.tblDatosUsuarios.TabIndex = 4;
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
            // txtBusquedaU
            // 
            this.txtBusquedaU.Location = new System.Drawing.Point(489, 33);
            this.txtBusquedaU.Name = "txtBusquedaU";
            this.txtBusquedaU.Size = new System.Drawing.Size(189, 20);
            this.txtBusquedaU.TabIndex = 10;
            this.txtBusquedaU.TextChanged += new System.EventHandler(this.txtBusquedaU_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrontEnd.Properties.Resources.big_loupe1;
            this.pictureBox1.Location = new System.Drawing.Point(697, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnUsuarioModificar
            // 
            this.btnUsuarioModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsuarioModificar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUsuarioModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarioModificar.FlatAppearance.BorderSize = 0;
            this.btnUsuarioModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarioModificar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarioModificar.ForeColor = System.Drawing.Color.White;
            this.btnUsuarioModificar.Image = global::FrontEnd.Properties.Resources.curved_arrows;
            this.btnUsuarioModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarioModificar.Location = new System.Drawing.Point(310, 446);
            this.btnUsuarioModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsuarioModificar.Name = "btnUsuarioModificar";
            this.btnUsuarioModificar.Size = new System.Drawing.Size(110, 36);
            this.btnUsuarioModificar.TabIndex = 6;
            this.btnUsuarioModificar.Text = "Modificar";
            this.btnUsuarioModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuarioModificar.UseVisualStyleBackColor = false;
            this.btnUsuarioModificar.Click += new System.EventHandler(this.btnUsuarioModificar_Click);
            // 
            // btnUsuarioEliminar
            // 
            this.btnUsuarioEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsuarioEliminar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUsuarioEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarioEliminar.FlatAppearance.BorderSize = 0;
            this.btnUsuarioEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarioEliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarioEliminar.ForeColor = System.Drawing.Color.White;
            this.btnUsuarioEliminar.Image = global::FrontEnd.Properties.Resources.minus_button;
            this.btnUsuarioEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarioEliminar.Location = new System.Drawing.Point(453, 446);
            this.btnUsuarioEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsuarioEliminar.Name = "btnUsuarioEliminar";
            this.btnUsuarioEliminar.Size = new System.Drawing.Size(110, 36);
            this.btnUsuarioEliminar.TabIndex = 5;
            this.btnUsuarioEliminar.Text = "Eliminar";
            this.btnUsuarioEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuarioEliminar.UseVisualStyleBackColor = false;
            this.btnUsuarioEliminar.Click += new System.EventHandler(this.btnUsuarioEliminar_Click);
            // 
            // btnUsuarioAgregar
            // 
            this.btnUsuarioAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsuarioAgregar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUsuarioAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarioAgregar.FlatAppearance.BorderSize = 0;
            this.btnUsuarioAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarioAgregar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarioAgregar.ForeColor = System.Drawing.Color.White;
            this.btnUsuarioAgregar.Image = global::FrontEnd.Properties.Resources.plus_button;
            this.btnUsuarioAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarioAgregar.Location = new System.Drawing.Point(161, 446);
            this.btnUsuarioAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsuarioAgregar.Name = "btnUsuarioAgregar";
            this.btnUsuarioAgregar.Size = new System.Drawing.Size(110, 36);
            this.btnUsuarioAgregar.TabIndex = 1;
            this.btnUsuarioAgregar.Text = "Agregar";
            this.btnUsuarioAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuarioAgregar.UseVisualStyleBackColor = false;
            this.btnUsuarioAgregar.Click += new System.EventHandler(this.btnUsuarioAgregar_Click);
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "Id Usuario";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cédula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contrasenaDataGridViewTextBoxColumn
            // 
            this.contrasenaDataGridViewTextBoxColumn.DataPropertyName = "Contrasena";
            this.contrasenaDataGridViewTextBoxColumn.HeaderText = "Contraseña";
            this.contrasenaDataGridViewTextBoxColumn.Name = "contrasenaDataGridViewTextBoxColumn";
            this.contrasenaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // fechaCreacionDataGridViewTextBoxColumn
            // 
            this.fechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "FechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.HeaderText = "Fecha de Creación";
            this.fechaCreacionDataGridViewTextBoxColumn.Name = "fechaCreacionDataGridViewTextBoxColumn";
            this.fechaCreacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaUltLoginDataGridViewTextBoxColumn
            // 
            this.fechaUltLoginDataGridViewTextBoxColumn.DataPropertyName = "FechaUltLogin";
            this.fechaUltLoginDataGridViewTextBoxColumn.HeaderText = "Última Visita";
            this.fechaUltLoginDataGridViewTextBoxColumn.Name = "fechaUltLoginDataGridViewTextBoxColumn";
            this.fechaUltLoginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmUsuarios_n
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(797, 513);
            this.Controls.Add(this.txtBusquedaU);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUsuarioModificar);
            this.Controls.Add(this.btnUsuarioEliminar);
            this.Controls.Add(this.tblDatosUsuarios);
            this.Controls.Add(this.lblUsuarios);
            this.Controls.Add(this.btnUsuarioAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmUsuarios_n";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblDatosUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_USUARIOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSourceUSUARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUsuarioAgregar;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.DataGridView tblDatosUsuarios;
        private System.Windows.Forms.Button btnUsuarioEliminar;
        private System.Windows.Forms.BindingSource sEGTRANSADataSourceUSUARIOSBindingSource;
        private FrontEnd.DataSources_Forms.SEGTRANSADataSource_USUARIOS sEGTRANSADataSource_USUARIOS;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private FrontEnd.DataSources_Forms.SEGTRANSADataSource_USUARIOSTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.Button btnUsuarioModificar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBusquedaU;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaUltLoginDataGridViewTextBoxColumn;
    }
}