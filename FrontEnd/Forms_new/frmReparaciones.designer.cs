using FrontEnd.DataSources_Forms;

namespace FrontEnd.Forms_new
{
    partial class frmReparaciones
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
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.tablaReparaciones = new System.Windows.Forms.DataGridView();
            this.idReparacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idActivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codActivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicialReparacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechafinalReparacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spRetornaReparacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_RetornaReparacionesDS = new FrontEnd.DataSources_Forms.sp_RetornaReparacionesDS();
            this.lblReparaciones = new System.Windows.Forms.Label();
            this.sp_RetornaReparacionTableAdapter = new FrontEnd.DataSources_Forms.sp_RetornaReparacionesDSTableAdapters.sp_RetornaReparacionTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReparacionModificar = new System.Windows.Forms.Button();
            this.btnReparacionEliminar = new System.Windows.Forms.Button();
            this.btnReparacionAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaReparaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRetornaReparacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_RetornaReparacionesDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtBusqueda.Location = new System.Drawing.Point(265, 56);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(228, 20);
            this.txtBusqueda.TabIndex = 2;
            this.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // tablaReparaciones
            // 
            this.tablaReparaciones.AllowUserToAddRows = false;
            this.tablaReparaciones.AllowUserToDeleteRows = false;
            this.tablaReparaciones.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaReparaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaReparaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaReparaciones.AutoGenerateColumns = false;
            this.tablaReparaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaReparaciones.BackgroundColor = System.Drawing.Color.White;
            this.tablaReparaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaReparaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaReparaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaReparaciones.ColumnHeadersHeight = 35;
            this.tablaReparaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaReparaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReparacionDataGridViewTextBoxColumn,
            this.idActivoDataGridViewTextBoxColumn,
            this.codActivoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.nombreProveedorDataGridViewTextBoxColumn,
            this.fechaInicialReparacionDataGridViewTextBoxColumn,
            this.fechafinalReparacionDataGridViewTextBoxColumn});
            this.tablaReparaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablaReparaciones.DataSource = this.spRetornaReparacionBindingSource;
            this.tablaReparaciones.EnableHeadersVisualStyles = false;
            this.tablaReparaciones.Location = new System.Drawing.Point(47, 89);
            this.tablaReparaciones.Margin = new System.Windows.Forms.Padding(2);
            this.tablaReparaciones.Name = "tablaReparaciones";
            this.tablaReparaciones.ReadOnly = true;
            this.tablaReparaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaReparaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaReparaciones.RowHeadersVisible = false;
            this.tablaReparaciones.RowTemplate.Height = 24;
            this.tablaReparaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaReparaciones.Size = new System.Drawing.Size(703, 326);
            this.tablaReparaciones.TabIndex = 28;
            this.tablaReparaciones.SelectionChanged += new System.EventHandler(this.tablaReparaciones_SelectionChanged);
            // 
            // idReparacionDataGridViewTextBoxColumn
            // 
            this.idReparacionDataGridViewTextBoxColumn.DataPropertyName = "IdReparacion";
            this.idReparacionDataGridViewTextBoxColumn.HeaderText = "Reparación";
            this.idReparacionDataGridViewTextBoxColumn.Name = "idReparacionDataGridViewTextBoxColumn";
            this.idReparacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idActivoDataGridViewTextBoxColumn
            // 
            this.idActivoDataGridViewTextBoxColumn.DataPropertyName = "IdActivo";
            this.idActivoDataGridViewTextBoxColumn.HeaderText = "Id del Activo";
            this.idActivoDataGridViewTextBoxColumn.Name = "idActivoDataGridViewTextBoxColumn";
            this.idActivoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codActivoDataGridViewTextBoxColumn
            // 
            this.codActivoDataGridViewTextBoxColumn.DataPropertyName = "CodActivo";
            this.codActivoDataGridViewTextBoxColumn.HeaderText = "Código del Activo";
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
            // nombreProveedorDataGridViewTextBoxColumn
            // 
            this.nombreProveedorDataGridViewTextBoxColumn.DataPropertyName = "NombreProveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.Name = "nombreProveedorDataGridViewTextBoxColumn";
            this.nombreProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaInicialReparacionDataGridViewTextBoxColumn
            // 
            this.fechaInicialReparacionDataGridViewTextBoxColumn.DataPropertyName = "FechaInicialReparacion";
            this.fechaInicialReparacionDataGridViewTextBoxColumn.HeaderText = "Fecha Inicial";
            this.fechaInicialReparacionDataGridViewTextBoxColumn.Name = "fechaInicialReparacionDataGridViewTextBoxColumn";
            this.fechaInicialReparacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechafinalReparacionDataGridViewTextBoxColumn
            // 
            this.fechafinalReparacionDataGridViewTextBoxColumn.DataPropertyName = "FechafinalReparacion";
            this.fechafinalReparacionDataGridViewTextBoxColumn.HeaderText = "Fecha Final";
            this.fechafinalReparacionDataGridViewTextBoxColumn.Name = "fechafinalReparacionDataGridViewTextBoxColumn";
            this.fechafinalReparacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spRetornaReparacionBindingSource
            // 
            this.spRetornaReparacionBindingSource.DataMember = "sp_RetornaReparacion";
            this.spRetornaReparacionBindingSource.DataSource = this.sp_RetornaReparacionesDS;
            // 
            // sp_RetornaReparacionesDS
            // 
            this.sp_RetornaReparacionesDS.DataSetName = "sp_RetornaReparacionesDS";
            this.sp_RetornaReparacionesDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblReparaciones
            // 
            this.lblReparaciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReparaciones.AutoSize = true;
            this.lblReparaciones.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReparaciones.ForeColor = System.Drawing.Color.DimGray;
            this.lblReparaciones.Location = new System.Drawing.Point(292, 9);
            this.lblReparaciones.Name = "lblReparaciones";
            this.lblReparaciones.Size = new System.Drawing.Size(175, 34);
            this.lblReparaciones.TabIndex = 25;
            this.lblReparaciones.Text = "Reparaciones";
            // 
            // sp_RetornaReparacionTableAdapter
            // 
            this.sp_RetornaReparacionTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::FrontEnd.Properties.Resources.big_loupe1;
            this.pictureBox1.Location = new System.Drawing.Point(503, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 25);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btnReparacionModificar
            // 
            this.btnReparacionModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReparacionModificar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnReparacionModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReparacionModificar.FlatAppearance.BorderSize = 0;
            this.btnReparacionModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReparacionModificar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReparacionModificar.ForeColor = System.Drawing.Color.White;
            this.btnReparacionModificar.Image = global::FrontEnd.Properties.Resources.curved_arrows;
            this.btnReparacionModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReparacionModificar.Location = new System.Drawing.Point(343, 438);
            this.btnReparacionModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnReparacionModificar.Name = "btnReparacionModificar";
            this.btnReparacionModificar.Size = new System.Drawing.Size(110, 36);
            this.btnReparacionModificar.TabIndex = 32;
            this.btnReparacionModificar.Text = "Modificar";
            this.btnReparacionModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReparacionModificar.UseVisualStyleBackColor = false;
            this.btnReparacionModificar.Click += new System.EventHandler(this.btnUsuarioModificar_Click);
            // 
            // btnReparacionEliminar
            // 
            this.btnReparacionEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReparacionEliminar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnReparacionEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReparacionEliminar.FlatAppearance.BorderSize = 0;
            this.btnReparacionEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReparacionEliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReparacionEliminar.ForeColor = System.Drawing.Color.White;
            this.btnReparacionEliminar.Image = global::FrontEnd.Properties.Resources.minus_button;
            this.btnReparacionEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReparacionEliminar.Location = new System.Drawing.Point(485, 438);
            this.btnReparacionEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnReparacionEliminar.Name = "btnReparacionEliminar";
            this.btnReparacionEliminar.Size = new System.Drawing.Size(110, 36);
            this.btnReparacionEliminar.TabIndex = 31;
            this.btnReparacionEliminar.Text = "Eliminar";
            this.btnReparacionEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReparacionEliminar.UseVisualStyleBackColor = false;
            this.btnReparacionEliminar.Click += new System.EventHandler(this.btnUsuarioEliminar_Click);
            // 
            // btnReparacionAgregar
            // 
            this.btnReparacionAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReparacionAgregar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnReparacionAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReparacionAgregar.FlatAppearance.BorderSize = 0;
            this.btnReparacionAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReparacionAgregar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReparacionAgregar.ForeColor = System.Drawing.Color.White;
            this.btnReparacionAgregar.Image = global::FrontEnd.Properties.Resources.plus_button;
            this.btnReparacionAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReparacionAgregar.Location = new System.Drawing.Point(201, 438);
            this.btnReparacionAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnReparacionAgregar.Name = "btnReparacionAgregar";
            this.btnReparacionAgregar.Size = new System.Drawing.Size(110, 36);
            this.btnReparacionAgregar.TabIndex = 30;
            this.btnReparacionAgregar.Text = "Agregar";
            this.btnReparacionAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReparacionAgregar.UseVisualStyleBackColor = false;
            this.btnReparacionAgregar.Click += new System.EventHandler(this.btnUsuarioAgregar_Click);
            // 
            // frmReparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(797, 496);
            this.Controls.Add(this.btnReparacionModificar);
            this.Controls.Add(this.btnReparacionEliminar);
            this.Controls.Add(this.btnReparacionAgregar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.tablaReparaciones);
            this.Controls.Add(this.lblReparaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReparaciones";
            this.Text = "frmReparaciones";
            this.Load += new System.EventHandler(this.frmReparaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaReparaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRetornaReparacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_RetornaReparacionesDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView tablaReparaciones;
        private System.Windows.Forms.Label lblReparaciones;
        private System.Windows.Forms.BindingSource spRetornaReparacionBindingSource;
        private sp_RetornaReparacionesDS sp_RetornaReparacionesDS;
        private DataSources_Forms.sp_RetornaReparacionesDSTableAdapters.sp_RetornaReparacionTableAdapter sp_RetornaReparacionTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReparacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idActivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codActivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicialReparacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechafinalReparacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnReparacionModificar;
        private System.Windows.Forms.Button btnReparacionEliminar;
        private System.Windows.Forms.Button btnReparacionAgregar;
    }
}