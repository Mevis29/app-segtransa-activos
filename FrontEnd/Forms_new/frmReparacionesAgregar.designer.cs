using FrontEnd.DataSources_Forms;

namespace FrontEnd.Forms_new
{
    partial class frmReparacionesAgregar
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
            this.tablaActivos = new System.Windows.Forms.DataGridView();
            this.idActivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codActivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.garantiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.activosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activosDataSet = new FrontEnd.DataSources_Forms.ActivosDataSet();
            this.sEGTRANSADataSourceACTIVOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEGTRANSADataSource_ACTIVOS = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_ACTIVOS();
            this.activosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.dpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.fechaInicio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.activosTableAdapter = new FrontEnd.DataSources_Forms.SEGTRANSADataSource_ACTIVOSTableAdapters.ActivosTableAdapter();
            this.activosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.activosTableAdapter1 = new FrontEnd.DataSources_Forms.ActivosDataSetTableAdapters.ActivosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tablaActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSourceACTIVOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_ACTIVOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).BeginInit();
            this.grpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaActivos
            // 
            this.tablaActivos.AllowUserToAddRows = false;
            this.tablaActivos.AllowUserToDeleteRows = false;
            this.tablaActivos.AllowUserToResizeColumns = false;
            this.tablaActivos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaActivos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaActivos.AutoGenerateColumns = false;
            this.tablaActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaActivos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaActivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaActivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idActivoDataGridViewTextBoxColumn,
            this.codActivoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.fechaCompraDataGridViewTextBoxColumn,
            this.proveedorDataGridViewTextBoxColumn,
            this.garantiaDataGridViewTextBoxColumn});
            this.tablaActivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablaActivos.DataSource = this.activosBindingSource2;
            this.tablaActivos.EnableHeadersVisualStyles = false;
            this.tablaActivos.Location = new System.Drawing.Point(25, 155);
            this.tablaActivos.Margin = new System.Windows.Forms.Padding(2);
            this.tablaActivos.MultiSelect = false;
            this.tablaActivos.Name = "tablaActivos";
            this.tablaActivos.ReadOnly = true;
            this.tablaActivos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaActivos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaActivos.RowHeadersVisible = false;
            this.tablaActivos.RowTemplate.Height = 24;
            this.tablaActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaActivos.Size = new System.Drawing.Size(803, 196);
            this.tablaActivos.TabIndex = 34;
            this.tablaActivos.SelectionChanged += new System.EventHandler(this.tablaActivos_SelectionChanged);
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
            this.codActivoDataGridViewTextBoxColumn.HeaderText = "Código Activo";
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
            // fechaCompraDataGridViewTextBoxColumn
            // 
            this.fechaCompraDataGridViewTextBoxColumn.DataPropertyName = "FechaCompra";
            this.fechaCompraDataGridViewTextBoxColumn.HeaderText = "Fecha de Compra";
            this.fechaCompraDataGridViewTextBoxColumn.Name = "fechaCompraDataGridViewTextBoxColumn";
            this.fechaCompraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proveedorDataGridViewTextBoxColumn
            // 
            this.proveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.Name = "proveedorDataGridViewTextBoxColumn";
            this.proveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // garantiaDataGridViewTextBoxColumn
            // 
            this.garantiaDataGridViewTextBoxColumn.DataPropertyName = "Garantia";
            this.garantiaDataGridViewTextBoxColumn.HeaderText = "Garantía";
            this.garantiaDataGridViewTextBoxColumn.Name = "garantiaDataGridViewTextBoxColumn";
            this.garantiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activosBindingSource2
            // 
            this.activosBindingSource2.DataMember = "Activos";
            this.activosBindingSource2.DataSource = this.activosDataSetBindingSource;
            // 
            // activosDataSetBindingSource
            // 
            this.activosDataSetBindingSource.DataSource = this.activosDataSet;
            this.activosDataSetBindingSource.Position = 0;
            // 
            // activosDataSet
            // 
            this.activosDataSet.DataSetName = "ActivosDataSet";
            this.activosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sEGTRANSADataSourceACTIVOSBindingSource
            // 
            this.sEGTRANSADataSourceACTIVOSBindingSource.DataSource = this.sEGTRANSADataSource_ACTIVOS;
            this.sEGTRANSADataSourceACTIVOSBindingSource.Position = 0;
            // 
            // sEGTRANSADataSource_ACTIVOS
            // 
            this.sEGTRANSADataSource_ACTIVOS.DataSetName = "SEGTRANSADataSource_ACTIVOS";
            this.sEGTRANSADataSource_ACTIVOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpBuscar
            // 
            this.grpBuscar.Controls.Add(this.txtBusqueda);
            this.grpBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBuscar.Location = new System.Drawing.Point(10, 75);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Size = new System.Drawing.Size(195, 64);
            this.grpBuscar.TabIndex = 33;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Buscar:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtBusqueda.Location = new System.Drawing.Point(15, 29);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(165, 23);
            this.txtBusqueda.TabIndex = 2;
            this.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // dpFechaFinal
            // 
            this.dpFechaFinal.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFechaFinal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFechaFinal.Location = new System.Drawing.Point(516, 101);
            this.dpFechaFinal.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dpFechaFinal.Name = "dpFechaFinal";
            this.dpFechaFinal.Size = new System.Drawing.Size(257, 23);
            this.dpFechaFinal.TabIndex = 27;
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinal.Location = new System.Drawing.Point(513, 75);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(204, 18);
            this.lblFechaFinal.TabIndex = 32;
            this.lblFechaFinal.Text = "Fecha final de reparación:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(355, 374);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(145, 46);
            this.btnAgregar.TabIndex = 28;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(731, 393);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 27);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dpFechaInicial
            // 
            this.dpFechaInicial.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFechaInicial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFechaInicial.Location = new System.Drawing.Point(227, 101);
            this.dpFechaInicial.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dpFechaInicial.Name = "dpFechaInicial";
            this.dpFechaInicial.Size = new System.Drawing.Size(242, 23);
            this.dpFechaInicial.TabIndex = 26;
            // 
            // fechaInicio
            // 
            this.fechaInicio.AutoSize = true;
            this.fechaInicio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaInicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fechaInicio.Location = new System.Drawing.Point(224, 75);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(218, 18);
            this.fechaInicio.TabIndex = 31;
            this.fechaInicio.Text = "Fecha inicial de reparación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(325, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "Agregar Reparación";
            // 
            // activosTableAdapter
            // 
            this.activosTableAdapter.ClearBeforeFill = true;
            // 
            // activosBindingSource1
            // 
            this.activosBindingSource1.DataMember = "Activos";
            this.activosBindingSource1.DataSource = this.activosDataSet;
            // 
            // activosTableAdapter1
            // 
            this.activosTableAdapter1.ClearBeforeFill = true;
            // 
            // frmReparacionesAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 432);
            this.Controls.Add(this.tablaActivos);
            this.Controls.Add(this.grpBuscar);
            this.Controls.Add(this.dpFechaFinal);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dpFechaInicial);
            this.Controls.Add(this.fechaInicio);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReparacionesAgregar";
            this.Text = "FrmReparacionesAgregar";
            this.Load += new System.EventHandler(this.FrmReparacionesAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSourceACTIVOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGTRANSADataSource_ACTIVOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).EndInit();
            this.grpBuscar.ResumeLayout(false);
            this.grpBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaActivos;
        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DateTimePicker dpFechaFinal;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dpFechaInicial;
        private System.Windows.Forms.Label fechaInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource activosBindingSource;
        private DataSources_Forms.SEGTRANSADataSource_ACTIVOSTableAdapters.ActivosTableAdapter activosTableAdapter;
        private ActivosDataSet activosDataSet;
        private System.Windows.Forms.BindingSource activosBindingSource1;
        private DataSources_Forms.ActivosDataSetTableAdapters.ActivosTableAdapter activosTableAdapter1;
        private System.Windows.Forms.BindingSource sEGTRANSADataSourceACTIVOSBindingSource;
        private DataSources_Forms.SEGTRANSADataSource_ACTIVOS sEGTRANSADataSource_ACTIVOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn idActivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codActivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn garantiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource activosBindingSource2;
        private System.Windows.Forms.BindingSource activosDataSetBindingSource;
    }
}