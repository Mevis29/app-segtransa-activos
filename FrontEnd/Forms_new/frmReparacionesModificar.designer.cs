namespace FrontEnd.Forms_new
{
    partial class frmReparacionesModificar
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtActivo = new System.Windows.Forms.TextBox();
            this.lblDescActivo = new System.Windows.Forms.Label();
            this.lblCodActivo = new System.Windows.Forms.Label();
            this.dpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.fechaInicio = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtDescripcion.Location = new System.Drawing.Point(26, 162);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(209, 26);
            this.txtDescripcion.TabIndex = 47;
            // 
            // txtActivo
            // 
            this.txtActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtActivo.Location = new System.Drawing.Point(25, 88);
            this.txtActivo.Name = "txtActivo";
            this.txtActivo.ReadOnly = true;
            this.txtActivo.Size = new System.Drawing.Size(209, 26);
            this.txtActivo.TabIndex = 46;
            // 
            // lblDescActivo
            // 
            this.lblDescActivo.AutoSize = true;
            this.lblDescActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescActivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDescActivo.Location = new System.Drawing.Point(23, 131);
            this.lblDescActivo.Name = "lblDescActivo";
            this.lblDescActivo.Size = new System.Drawing.Size(103, 18);
            this.lblDescActivo.TabIndex = 45;
            this.lblDescActivo.Text = "Descripción:";
            // 
            // lblCodActivo
            // 
            this.lblCodActivo.AutoSize = true;
            this.lblCodActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodActivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCodActivo.Location = new System.Drawing.Point(22, 57);
            this.lblCodActivo.Name = "lblCodActivo";
            this.lblCodActivo.Size = new System.Drawing.Size(132, 18);
            this.lblCodActivo.TabIndex = 44;
            this.lblCodActivo.Text = "Activo a reparar:";
            // 
            // dpFechaFinal
            // 
            this.dpFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFechaFinal.Location = new System.Drawing.Point(26, 303);
            this.dpFechaFinal.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dpFechaFinal.Name = "dpFechaFinal";
            this.dpFechaFinal.Size = new System.Drawing.Size(257, 26);
            this.dpFechaFinal.TabIndex = 38;
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinal.Location = new System.Drawing.Point(23, 277);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(203, 18);
            this.lblFechaFinal.TabIndex = 43;
            this.lblFechaFinal.Text = "Fecha final de reparación:";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(134, 357);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 39;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(29, 357);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dpFechaInicial
            // 
            this.dpFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFechaInicial.Location = new System.Drawing.Point(25, 226);
            this.dpFechaInicial.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dpFechaInicial.Name = "dpFechaInicial";
            this.dpFechaInicial.Size = new System.Drawing.Size(258, 26);
            this.dpFechaInicial.TabIndex = 37;
            // 
            // fechaInicio
            // 
            this.fechaInicio.AutoSize = true;
            this.fechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaInicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fechaInicio.Location = new System.Drawing.Point(22, 200);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(215, 18);
            this.fechaInicio.TabIndex = 42;
            this.fechaInicio.Text = "Fecha inicial de reparación:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitulo.Location = new System.Drawing.Point(21, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(169, 18);
            this.lblTitulo.TabIndex = 41;
            this.lblTitulo.Text = "Modificar Reparación";
            // 
            // frmReparacionesModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 393);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtActivo);
            this.Controls.Add(this.lblDescActivo);
            this.Controls.Add(this.lblCodActivo);
            this.Controls.Add(this.dpFechaFinal);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dpFechaInicial);
            this.Controls.Add(this.fechaInicio);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReparacionesModificar";
            this.Text = "frmReparacionesModificar";
            this.Load += new System.EventHandler(this.frmReparacionesModificar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtActivo;
        private System.Windows.Forms.Label lblDescActivo;
        private System.Windows.Forms.Label lblCodActivo;
        private System.Windows.Forms.DateTimePicker dpFechaFinal;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dpFechaInicial;
        private System.Windows.Forms.Label fechaInicio;
        private System.Windows.Forms.Label lblTitulo;
    }
}