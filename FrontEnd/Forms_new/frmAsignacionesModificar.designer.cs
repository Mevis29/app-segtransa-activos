namespace FronEnd
{
    partial class FrmAsignacionesModificar_n
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
            this.btnAgregaAsignacion = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.groupBoxDatosPers = new System.Windows.Forms.GroupBox();
            this.dateFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.cmbBoxActivos = new System.Windows.Forms.ComboBox();
            this.lblFechaCompra = new System.Windows.Forms.Label();
            this.cmbBoxEmpleados = new System.Windows.Forms.ComboBox();
            this.lblEstadoActivo = new System.Windows.Forms.Label();
            this.dateFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDatosPers.SuspendLayout();
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
            // btnAgregaAsignacion
            // 
            this.btnAgregaAsignacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregaAsignacion.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregaAsignacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregaAsignacion.FlatAppearance.BorderSize = 0;
            this.btnAgregaAsignacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregaAsignacion.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregaAsignacion.ForeColor = System.Drawing.Color.White;
            this.btnAgregaAsignacion.Image = global::FrontEnd.Properties.Resources.plus_button;
            this.btnAgregaAsignacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregaAsignacion.Location = new System.Drawing.Point(269, 336);
            this.btnAgregaAsignacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregaAsignacion.Name = "btnAgregaAsignacion";
            this.btnAgregaAsignacion.Size = new System.Drawing.Size(145, 46);
            this.btnAgregaAsignacion.TabIndex = 6;
            this.btnAgregaAsignacion.Text = "Agregar";
            this.btnAgregaAsignacion.UseVisualStyleBackColor = false;
            this.btnAgregaAsignacion.Click += new System.EventHandler(this.btnAgregaAsignacion_Click);
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
            this.cancelarBtn.Location = new System.Drawing.Point(586, 355);
            this.cancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(97, 27);
            this.cancelarBtn.TabIndex = 7;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = false;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.Black;
            this.lblCategoria.Location = new System.Drawing.Point(19, 37);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(144, 17);
            this.lblCategoria.TabIndex = 10;
            this.lblCategoria.Text = "Nombre del Empleado:";
            // 
            // groupBoxDatosPers
            // 
            this.groupBoxDatosPers.Controls.Add(this.label1);
            this.groupBoxDatosPers.Controls.Add(this.dateFechaFin);
            this.groupBoxDatosPers.Controls.Add(this.dateFechaInicio);
            this.groupBoxDatosPers.Controls.Add(this.cmbBoxActivos);
            this.groupBoxDatosPers.Controls.Add(this.lblFechaCompra);
            this.groupBoxDatosPers.Controls.Add(this.cmbBoxEmpleados);
            this.groupBoxDatosPers.Controls.Add(this.lblEstadoActivo);
            this.groupBoxDatosPers.Controls.Add(this.lblCategoria);
            this.groupBoxDatosPers.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatosPers.ForeColor = System.Drawing.Color.Black;
            this.groupBoxDatosPers.Location = new System.Drawing.Point(81, 58);
            this.groupBoxDatosPers.Name = "groupBoxDatosPers";
            this.groupBoxDatosPers.Size = new System.Drawing.Size(498, 259);
            this.groupBoxDatosPers.TabIndex = 15;
            this.groupBoxDatosPers.TabStop = false;
            this.groupBoxDatosPers.Text = "Datos Activo";
            // 
            // dateFechaInicio
            // 
            this.dateFechaInicio.Location = new System.Drawing.Point(188, 162);
            this.dateFechaInicio.Name = "dateFechaInicio";
            this.dateFechaInicio.Size = new System.Drawing.Size(239, 21);
            this.dateFechaInicio.TabIndex = 25;
            // 
            // cmbBoxActivos
            // 
            this.cmbBoxActivos.FormattingEnabled = true;
            this.cmbBoxActivos.Location = new System.Drawing.Point(188, 96);
            this.cmbBoxActivos.Name = "cmbBoxActivos";
            this.cmbBoxActivos.Size = new System.Drawing.Size(239, 24);
            this.cmbBoxActivos.TabIndex = 27;
            // 
            // lblFechaCompra
            // 
            this.lblFechaCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaCompra.AutoSize = true;
            this.lblFechaCompra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCompra.ForeColor = System.Drawing.Color.Black;
            this.lblFechaCompra.Location = new System.Drawing.Point(19, 162);
            this.lblFechaCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaCompra.Name = "lblFechaCompra";
            this.lblFechaCompra.Size = new System.Drawing.Size(136, 17);
            this.lblFechaCompra.TabIndex = 24;
            this.lblFechaCompra.Text = "Fecha de Asignacion:";
            // 
            // cmbBoxEmpleados
            // 
            this.cmbBoxEmpleados.FormattingEnabled = true;
            this.cmbBoxEmpleados.Location = new System.Drawing.Point(188, 35);
            this.cmbBoxEmpleados.Name = "cmbBoxEmpleados";
            this.cmbBoxEmpleados.Size = new System.Drawing.Size(239, 24);
            this.cmbBoxEmpleados.TabIndex = 26;
            // 
            // lblEstadoActivo
            // 
            this.lblEstadoActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstadoActivo.AutoSize = true;
            this.lblEstadoActivo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoActivo.ForeColor = System.Drawing.Color.Black;
            this.lblEstadoActivo.Location = new System.Drawing.Point(19, 96);
            this.lblEstadoActivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstadoActivo.Name = "lblEstadoActivo";
            this.lblEstadoActivo.Size = new System.Drawing.Size(109, 17);
            this.lblEstadoActivo.TabIndex = 14;
            this.lblEstadoActivo.Text = "Activo a asignar:";
            // 
            // dateFechaFin
            // 
            this.dateFechaFin.Location = new System.Drawing.Point(188, 219);
            this.dateFechaFin.Name = "dateFechaFin";
            this.dateFechaFin.Size = new System.Drawing.Size(239, 21);
            this.dateFechaFin.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 223);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Fecha Final:";
            // 
            // FrmAsignacionesAgregar_n
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(713, 407);
            this.Controls.Add(this.groupBoxDatosPers);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.btnAgregaAsignacion);
            this.Controls.Add(this.lblAgregarActivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAsignacionesAgregar_n";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.groupBoxDatosPers.ResumeLayout(false);
            this.groupBoxDatosPers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarActivo;
        private System.Windows.Forms.Button btnAgregaAsignacion;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.GroupBox groupBoxDatosPers;
        private System.Windows.Forms.DateTimePicker dateFechaInicio;
        private System.Windows.Forms.Label lblFechaCompra;
        private System.Windows.Forms.ComboBox cmbBoxActivos;
        private System.Windows.Forms.ComboBox cmbBoxEmpleados;
        private System.Windows.Forms.Label lblEstadoActivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateFechaFin;
    }
}