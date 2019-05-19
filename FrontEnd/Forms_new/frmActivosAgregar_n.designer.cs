namespace FronEnd
{
    partial class FrmActivosAgregar_n
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
            this.lblAgregarActivo = new System.Windows.Forms.Label();
            this.txtCodActivo = new System.Windows.Forms.TextBox();
            this.lblCodActivo = new System.Windows.Forms.Label();
            this.btnAgregaActivo = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.errorLbl = new System.Windows.Forms.Label();
            this.cmbBoxProveedor = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.groupBoxDatosPers = new System.Windows.Forms.GroupBox();
            this.dateFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.cmbBoxEstadoActivos = new System.Windows.Forms.ComboBox();
            this.lblFechaCompra = new System.Windows.Forms.Label();
            this.cmbBoxCategorias = new System.Windows.Forms.ComboBox();
            this.lblErrorCodigo = new System.Windows.Forms.Label();
            this.lblErrorCategoria = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblEstadoActivo = new System.Windows.Forms.Label();
            this.groupBoxDatosProveedor = new System.Windows.Forms.GroupBox();
            this.txtMesesDepreciacion = new System.Windows.Forms.TextBox();
            this.lblMesesDepreciacion = new System.Windows.Forms.Label();
            this.lblErrorPrecio = new System.Windows.Forms.Label();
            this.txtGarantia = new System.Windows.Forms.TextBox();
            this.lblGarantia = new System.Windows.Forms.Label();
            this.groupBoxDatosPers.SuspendLayout();
            this.groupBoxDatosProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAgregarActivo
            // 
            this.lblAgregarActivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAgregarActivo.AutoSize = true;
            this.lblAgregarActivo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarActivo.ForeColor = System.Drawing.Color.Black;
            this.lblAgregarActivo.Location = new System.Drawing.Point(222, 18);
            this.lblAgregarActivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAgregarActivo.Name = "lblAgregarActivo";
            this.lblAgregarActivo.Size = new System.Drawing.Size(223, 22);
            this.lblAgregarActivo.TabIndex = 3;
            this.lblAgregarActivo.Text = "Agregar Nuevo Activo";
            this.lblAgregarActivo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCodActivo
            // 
            this.txtCodActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodActivo.BackColor = System.Drawing.Color.White;
            this.txtCodActivo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodActivo.Location = new System.Drawing.Point(108, 37);
            this.txtCodActivo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodActivo.Name = "txtCodActivo";
            this.txtCodActivo.Size = new System.Drawing.Size(239, 22);
            this.txtCodActivo.TabIndex = 4;
            // 
            // lblCodActivo
            // 
            this.lblCodActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodActivo.AutoSize = true;
            this.lblCodActivo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodActivo.ForeColor = System.Drawing.Color.Black;
            this.lblCodActivo.Location = new System.Drawing.Point(19, 37);
            this.lblCodActivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodActivo.Name = "lblCodActivo";
            this.lblCodActivo.Size = new System.Drawing.Size(55, 17);
            this.lblCodActivo.TabIndex = 5;
            this.lblCodActivo.Text = "Codigo:";
            // 
            // btnAgregaActivo
            // 
            this.btnAgregaActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregaActivo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregaActivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregaActivo.FlatAppearance.BorderSize = 0;
            this.btnAgregaActivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregaActivo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregaActivo.ForeColor = System.Drawing.Color.White;
            this.btnAgregaActivo.Image = global::FrontEnd.Properties.Resources.plus_button;
            this.btnAgregaActivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregaActivo.Location = new System.Drawing.Point(480, 294);
            this.btnAgregaActivo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregaActivo.Name = "btnAgregaActivo";
            this.btnAgregaActivo.Size = new System.Drawing.Size(145, 46);
            this.btnAgregaActivo.TabIndex = 6;
            this.btnAgregaActivo.Text = "Agregar";
            this.btnAgregaActivo.UseVisualStyleBackColor = false;
            this.btnAgregaActivo.Click += new System.EventHandler(this.btnAgregaActivo_Click);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelarBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.cancelarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarBtn.FlatAppearance.BorderSize = 0;
            this.cancelarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBtn.ForeColor = System.Drawing.Color.White;
            this.cancelarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelarBtn.Location = new System.Drawing.Point(480, 355);
            this.cancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(145, 51);
            this.cancelarBtn.TabIndex = 7;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = false;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // errorLbl
            // 
            this.errorLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorLbl.AutoSize = true;
            this.errorLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(420, 251);
            this.errorLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(269, 17);
            this.errorLbl.TabIndex = 8;
            this.errorLbl.Text = "Por favor ingrese los valores requeridos";
            this.errorLbl.Visible = false;
            // 
            // cmbBoxProveedor
            // 
            this.cmbBoxProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxProveedor.FormattingEnabled = true;
            this.cmbBoxProveedor.Location = new System.Drawing.Point(150, 32);
            this.cmbBoxProveedor.Name = "cmbBoxProveedor";
            this.cmbBoxProveedor.Size = new System.Drawing.Size(140, 24);
            this.cmbBoxProveedor.TabIndex = 9;
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.Black;
            this.lblCategoria.Location = new System.Drawing.Point(19, 89);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(72, 17);
            this.lblCategoria.TabIndex = 10;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblProveedor
            // 
            this.lblProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.ForeColor = System.Drawing.Color.Black;
            this.lblProveedor.Location = new System.Drawing.Point(14, 32);
            this.lblProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(74, 17);
            this.lblProveedor.TabIndex = 12;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.Black;
            this.lblPrecio.Location = new System.Drawing.Point(14, 79);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(108, 17);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "Precio (colones):";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(150, 79);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(140, 22);
            this.txtPrecio.TabIndex = 14;
            this.txtPrecio.Text = "0";
            // 
            // groupBoxDatosPers
            // 
            this.groupBoxDatosPers.Controls.Add(this.dateFechaCompra);
            this.groupBoxDatosPers.Controls.Add(this.cmbBoxEstadoActivos);
            this.groupBoxDatosPers.Controls.Add(this.lblFechaCompra);
            this.groupBoxDatosPers.Controls.Add(this.cmbBoxCategorias);
            this.groupBoxDatosPers.Controls.Add(this.lblErrorCodigo);
            this.groupBoxDatosPers.Controls.Add(this.lblErrorCategoria);
            this.groupBoxDatosPers.Controls.Add(this.txtDescripcion);
            this.groupBoxDatosPers.Controls.Add(this.lblDescripcion);
            this.groupBoxDatosPers.Controls.Add(this.lblEstadoActivo);
            this.groupBoxDatosPers.Controls.Add(this.lblCodActivo);
            this.groupBoxDatosPers.Controls.Add(this.txtCodActivo);
            this.groupBoxDatosPers.Controls.Add(this.lblCategoria);
            this.groupBoxDatosPers.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatosPers.ForeColor = System.Drawing.Color.Black;
            this.groupBoxDatosPers.Location = new System.Drawing.Point(12, 62);
            this.groupBoxDatosPers.Name = "groupBoxDatosPers";
            this.groupBoxDatosPers.Size = new System.Drawing.Size(373, 300);
            this.groupBoxDatosPers.TabIndex = 15;
            this.groupBoxDatosPers.TabStop = false;
            this.groupBoxDatosPers.Text = "Datos Activo";
            // 
            // dateFechaCompra
            // 
            this.dateFechaCompra.Location = new System.Drawing.Point(151, 244);
            this.dateFechaCompra.Name = "dateFechaCompra";
            this.dateFechaCompra.Size = new System.Drawing.Size(196, 21);
            this.dateFechaCompra.TabIndex = 25;
            // 
            // cmbBoxEstadoActivos
            // 
            this.cmbBoxEstadoActivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxEstadoActivos.FormattingEnabled = true;
            this.cmbBoxEstadoActivos.Location = new System.Drawing.Point(108, 141);
            this.cmbBoxEstadoActivos.Name = "cmbBoxEstadoActivos";
            this.cmbBoxEstadoActivos.Size = new System.Drawing.Size(239, 24);
            this.cmbBoxEstadoActivos.TabIndex = 27;
            // 
            // lblFechaCompra
            // 
            this.lblFechaCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaCompra.AutoSize = true;
            this.lblFechaCompra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCompra.ForeColor = System.Drawing.Color.Black;
            this.lblFechaCompra.Location = new System.Drawing.Point(19, 248);
            this.lblFechaCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaCompra.Name = "lblFechaCompra";
            this.lblFechaCompra.Size = new System.Drawing.Size(118, 17);
            this.lblFechaCompra.TabIndex = 24;
            this.lblFechaCompra.Text = "Fecha de Compra:";
            // 
            // cmbBoxCategorias
            // 
            this.cmbBoxCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxCategorias.FormattingEnabled = true;
            this.cmbBoxCategorias.Location = new System.Drawing.Point(108, 87);
            this.cmbBoxCategorias.Name = "cmbBoxCategorias";
            this.cmbBoxCategorias.Size = new System.Drawing.Size(239, 24);
            this.cmbBoxCategorias.TabIndex = 26;
            // 
            // lblErrorCodigo
            // 
            this.lblErrorCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorCodigo.AutoSize = true;
            this.lblErrorCodigo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCodigo.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCodigo.Location = new System.Drawing.Point(5, 34);
            this.lblErrorCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorCodigo.Name = "lblErrorCodigo";
            this.lblErrorCodigo.Size = new System.Drawing.Size(14, 17);
            this.lblErrorCodigo.TabIndex = 22;
            this.lblErrorCodigo.Text = "*";
            this.lblErrorCodigo.Visible = false;
            // 
            // lblErrorCategoria
            // 
            this.lblErrorCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorCategoria.AutoSize = true;
            this.lblErrorCategoria.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCategoria.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCategoria.Location = new System.Drawing.Point(5, 90);
            this.lblErrorCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorCategoria.Name = "lblErrorCategoria";
            this.lblErrorCategoria.Size = new System.Drawing.Size(14, 17);
            this.lblErrorCategoria.TabIndex = 21;
            this.lblErrorCategoria.Text = "*";
            this.lblErrorCategoria.Visible = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(108, 190);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(239, 22);
            this.txtDescripcion.TabIndex = 19;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(19, 190);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 17);
            this.lblDescripcion.TabIndex = 18;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblEstadoActivo
            // 
            this.lblEstadoActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstadoActivo.AutoSize = true;
            this.lblEstadoActivo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoActivo.ForeColor = System.Drawing.Color.Black;
            this.lblEstadoActivo.Location = new System.Drawing.Point(19, 143);
            this.lblEstadoActivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstadoActivo.Name = "lblEstadoActivo";
            this.lblEstadoActivo.Size = new System.Drawing.Size(51, 17);
            this.lblEstadoActivo.TabIndex = 14;
            this.lblEstadoActivo.Text = "Estado:";
            // 
            // groupBoxDatosProveedor
            // 
            this.groupBoxDatosProveedor.Controls.Add(this.txtMesesDepreciacion);
            this.groupBoxDatosProveedor.Controls.Add(this.lblMesesDepreciacion);
            this.groupBoxDatosProveedor.Controls.Add(this.lblErrorPrecio);
            this.groupBoxDatosProveedor.Controls.Add(this.txtGarantia);
            this.groupBoxDatosProveedor.Controls.Add(this.lblGarantia);
            this.groupBoxDatosProveedor.Controls.Add(this.lblProveedor);
            this.groupBoxDatosProveedor.Controls.Add(this.cmbBoxProveedor);
            this.groupBoxDatosProveedor.Controls.Add(this.txtPrecio);
            this.groupBoxDatosProveedor.Controls.Add(this.lblPrecio);
            this.groupBoxDatosProveedor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatosProveedor.ForeColor = System.Drawing.Color.Black;
            this.groupBoxDatosProveedor.Location = new System.Drawing.Point(391, 62);
            this.groupBoxDatosProveedor.Name = "groupBoxDatosProveedor";
            this.groupBoxDatosProveedor.Size = new System.Drawing.Size(310, 186);
            this.groupBoxDatosProveedor.TabIndex = 16;
            this.groupBoxDatosProveedor.TabStop = false;
            this.groupBoxDatosProveedor.Text = "Datos Proveedor";
            // 
            // txtMesesDepreciacion
            // 
            this.txtMesesDepreciacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMesesDepreciacion.BackColor = System.Drawing.Color.White;
            this.txtMesesDepreciacion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesesDepreciacion.Location = new System.Drawing.Point(150, 163);
            this.txtMesesDepreciacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtMesesDepreciacion.Name = "txtMesesDepreciacion";
            this.txtMesesDepreciacion.Size = new System.Drawing.Size(142, 22);
            this.txtMesesDepreciacion.TabIndex = 30;
            this.txtMesesDepreciacion.Text = "0";
            // 
            // lblMesesDepreciacion
            // 
            this.lblMesesDepreciacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMesesDepreciacion.AutoSize = true;
            this.lblMesesDepreciacion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesesDepreciacion.ForeColor = System.Drawing.Color.Black;
            this.lblMesesDepreciacion.Location = new System.Drawing.Point(9, 166);
            this.lblMesesDepreciacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMesesDepreciacion.Name = "lblMesesDepreciacion";
            this.lblMesesDepreciacion.Size = new System.Drawing.Size(132, 17);
            this.lblMesesDepreciacion.TabIndex = 29;
            this.lblMesesDepreciacion.Text = "Meses depreciación:";
            // 
            // lblErrorPrecio
            // 
            this.lblErrorPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorPrecio.AutoSize = true;
            this.lblErrorPrecio.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPrecio.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPrecio.Location = new System.Drawing.Point(147, 103);
            this.lblErrorPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorPrecio.Name = "lblErrorPrecio";
            this.lblErrorPrecio.Size = new System.Drawing.Size(151, 17);
            this.lblErrorPrecio.TabIndex = 28;
            this.lblErrorPrecio.Text = "Ingrese solo numeros";
            this.lblErrorPrecio.Visible = false;
            // 
            // txtGarantia
            // 
            this.txtGarantia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGarantia.BackColor = System.Drawing.Color.White;
            this.txtGarantia.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGarantia.Location = new System.Drawing.Point(150, 126);
            this.txtGarantia.Margin = new System.Windows.Forms.Padding(2);
            this.txtGarantia.Name = "txtGarantia";
            this.txtGarantia.Size = new System.Drawing.Size(142, 22);
            this.txtGarantia.TabIndex = 23;
            this.txtGarantia.Text = "0";
            // 
            // lblGarantia
            // 
            this.lblGarantia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGarantia.AutoSize = true;
            this.lblGarantia.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGarantia.ForeColor = System.Drawing.Color.Black;
            this.lblGarantia.Location = new System.Drawing.Point(9, 126);
            this.lblGarantia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGarantia.Name = "lblGarantia";
            this.lblGarantia.Size = new System.Drawing.Size(113, 17);
            this.lblGarantia.TabIndex = 22;
            this.lblGarantia.Text = "Garantia (meses):";
            // 
            // FrmActivosAgregar_n
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(713, 407);
            this.Controls.Add(this.groupBoxDatosProveedor);
            this.Controls.Add(this.groupBoxDatosPers);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.btnAgregaActivo);
            this.Controls.Add(this.lblAgregarActivo);
            this.Controls.Add(this.errorLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmActivosAgregar_n";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.groupBoxDatosPers.ResumeLayout(false);
            this.groupBoxDatosPers.PerformLayout();
            this.groupBoxDatosProveedor.ResumeLayout(false);
            this.groupBoxDatosProveedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarActivo;
        private System.Windows.Forms.TextBox txtCodActivo;
        private System.Windows.Forms.Label lblCodActivo;
        private System.Windows.Forms.Button btnAgregaActivo;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.ComboBox cmbBoxProveedor;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.GroupBox groupBoxDatosPers;
        private System.Windows.Forms.GroupBox groupBoxDatosProveedor;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblErrorCategoria;
        private System.Windows.Forms.Label lblErrorCodigo;
        private System.Windows.Forms.TextBox txtGarantia;
        private System.Windows.Forms.Label lblGarantia;
        private System.Windows.Forms.DateTimePicker dateFechaCompra;
        private System.Windows.Forms.Label lblFechaCompra;
        private System.Windows.Forms.ComboBox cmbBoxEstadoActivos;
        private System.Windows.Forms.ComboBox cmbBoxCategorias;
        private System.Windows.Forms.Label lblEstadoActivo;
        private System.Windows.Forms.Label lblErrorPrecio;
        private System.Windows.Forms.TextBox txtMesesDepreciacion;
        private System.Windows.Forms.Label lblMesesDepreciacion;
    }
}