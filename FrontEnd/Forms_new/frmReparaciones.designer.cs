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
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarReparacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarReparacionSeleccionadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarVentanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.grpBuscar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaReparaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRetornaReparacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_RetornaReparacionesDS)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBuscar
            // 
            this.grpBuscar.Controls.Add(this.txtBusqueda);
            this.grpBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBuscar.Location = new System.Drawing.Point(5, 105);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Size = new System.Drawing.Size(290, 68);
            this.grpBuscar.TabIndex = 26;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Buscar:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtBusqueda.Location = new System.Drawing.Point(17, 28);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(267, 26);
            this.txtBusqueda.TabIndex = 2;
            this.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.cerrarVentanaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(810, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarReparacionToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarReparacionSeleccionadoToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // agregarReparacionToolStripMenuItem
            // 
            this.agregarReparacionToolStripMenuItem.Name = "agregarReparacionToolStripMenuItem";
            this.agregarReparacionToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.agregarReparacionToolStripMenuItem.Text = "Agregar Nueva Reparacion";
            this.agregarReparacionToolStripMenuItem.Click += new System.EventHandler(this.agregarReparacionToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.modificarToolStripMenuItem.Text = "Modificar Reparación Seleccionada";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarReparacionSeleccionadoToolStripMenuItem
            // 
            this.eliminarReparacionSeleccionadoToolStripMenuItem.Name = "eliminarReparacionSeleccionadoToolStripMenuItem";
            this.eliminarReparacionSeleccionadoToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.eliminarReparacionSeleccionadoToolStripMenuItem.Text = "Eliminar Reparación Seleccionada";
            this.eliminarReparacionSeleccionadoToolStripMenuItem.Click += new System.EventHandler(this.eliminarReparacionSeleccionadoToolStripMenuItem_Click);
            // 
            // cerrarVentanaToolStripMenuItem
            // 
            this.cerrarVentanaToolStripMenuItem.Name = "cerrarVentanaToolStripMenuItem";
            this.cerrarVentanaToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.cerrarVentanaToolStripMenuItem.Text = "Cerrar Ventana";
            this.cerrarVentanaToolStripMenuItem.Click += new System.EventHandler(this.cerrarVentanaToolStripMenuItem_Click);
            // 
            // tablaReparaciones
            // 
            this.tablaReparaciones.AllowUserToAddRows = false;
            this.tablaReparaciones.AllowUserToDeleteRows = false;
            this.tablaReparaciones.AllowUserToResizeColumns = false;
            this.tablaReparaciones.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaReparaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaReparaciones.AutoGenerateColumns = false;
            this.tablaReparaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaReparaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.tablaReparaciones.Location = new System.Drawing.Point(5, 178);
            this.tablaReparaciones.Margin = new System.Windows.Forms.Padding(2);
            this.tablaReparaciones.Name = "tablaReparaciones";
            this.tablaReparaciones.ReadOnly = true;
            this.tablaReparaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaReparaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaReparaciones.RowHeadersVisible = false;
            this.tablaReparaciones.RowHeadersWidth = 45;
            this.tablaReparaciones.RowTemplate.Height = 24;
            this.tablaReparaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaReparaciones.Size = new System.Drawing.Size(794, 223);
            this.tablaReparaciones.TabIndex = 28;
            this.tablaReparaciones.SelectionChanged += new System.EventHandler(this.tablaReparaciones_SelectionChanged);
            // 
            // idReparacionDataGridViewTextBoxColumn
            // 
            this.idReparacionDataGridViewTextBoxColumn.DataPropertyName = "IdReparacion";
            this.idReparacionDataGridViewTextBoxColumn.HeaderText = "Reparacion";
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
            this.lblReparaciones.AutoSize = true;
            this.lblReparaciones.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F);
            this.lblReparaciones.ForeColor = System.Drawing.Color.DimGray;
            this.lblReparaciones.Location = new System.Drawing.Point(12, 39);
            this.lblReparaciones.Name = "lblReparaciones";
            this.lblReparaciones.Size = new System.Drawing.Size(189, 37);
            this.lblReparaciones.TabIndex = 25;
            this.lblReparaciones.Text = "Reparaciones";
            // 
            // sp_RetornaReparacionTableAdapter
            // 
            this.sp_RetornaReparacionTableAdapter.ClearBeforeFill = true;
            // 
            // frmReparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 392);
            this.Controls.Add(this.grpBuscar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tablaReparaciones);
            this.Controls.Add(this.lblReparaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReparaciones";
            this.Text = "frmReparaciones";
            this.Load += new System.EventHandler(this.frmReparaciones_Load);
            this.grpBuscar.ResumeLayout(false);
            this.grpBuscar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaReparaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRetornaReparacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_RetornaReparacionesDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarReparacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarReparacionSeleccionadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarVentanaToolStripMenuItem;
        private System.Windows.Forms.DataGridView tablaReparaciones;
        private System.Windows.Forms.Label lblReparaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReparacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idActivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codActivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicialReparacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechafinalReparacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource spRetornaReparacionBindingSource;
        private sp_RetornaReparacionesDS sp_RetornaReparacionesDS;
        private DataSources_Forms.sp_RetornaReparacionesDSTableAdapters.sp_RetornaReparacionTableAdapter sp_RetornaReparacionTableAdapter;
    }
}