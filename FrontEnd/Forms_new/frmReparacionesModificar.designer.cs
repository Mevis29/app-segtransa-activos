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
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtDescripcion.Location = new System.Drawing.Point(41, 206);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(209, 27);
            this.txtDescripcion.TabIndex = 47;
            // 
            // txtActivo
            // 
            this.txtActivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtActivo.Location = new System.Drawing.Point(41, 102);
            this.txtActivo.Name = "txtActivo";
            this.txtActivo.ReadOnly = true;
            this.txtActivo.Size = new System.Drawing.Size(209, 27);
            this.txtActivo.TabIndex = 46;
            // 
            // lblDescActivo
            // 
            this.lblDescActivo.AutoSize = true;
            this.lblDescActivo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescActivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDescActivo.Location = new System.Drawing.Point(38, 171);
            this.lblDescActivo.Name = "lblDescActivo";
            this.lblDescActivo.Size = new System.Drawing.Size(101, 18);
            this.lblDescActivo.TabIndex = 45;
            this.lblDescActivo.Text = "Descripción:";
            // 
            // lblCodActivo
            // 
            this.lblCodActivo.AutoSize = true;
            this.lblCodActivo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodActivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCodActivo.Location = new System.Drawing.Point(38, 69);
            this.lblCodActivo.Name = "lblCodActivo";
            this.lblCodActivo.Size = new System.Drawing.Size(132, 18);
            this.lblCodActivo.TabIndex = 44;
            this.lblCodActivo.Text = "Activo a reparar:";
            // 
            // dpFechaFinal
            // 
            this.dpFechaFinal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFechaFinal.Location = new System.Drawing.Point(375, 207);
            this.dpFechaFinal.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dpFechaFinal.Name = "dpFechaFinal";
            this.dpFechaFinal.Size = new System.Drawing.Size(257, 26);
            this.dpFechaFinal.TabIndex = 38;
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinal.Location = new System.Drawing.Point(372, 171);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(204, 18);
            this.lblFechaFinal.TabIndex = 43;
            this.lblFechaFinal.Text = "Fecha final de reparación:";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(288, 308);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(145, 46);
            this.btnModificar.TabIndex = 39;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(586, 355);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 27);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dpFechaInicial
            // 
            this.dpFechaInicial.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFechaInicial.Location = new System.Drawing.Point(375, 101);
            this.dpFechaInicial.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dpFechaInicial.Name = "dpFechaInicial";
            this.dpFechaInicial.Size = new System.Drawing.Size(258, 26);
            this.dpFechaInicial.TabIndex = 37;
            // 
            // fechaInicio
            // 
            this.fechaInicio.AutoSize = true;
            this.fechaInicio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaInicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fechaInicio.Location = new System.Drawing.Point(372, 69);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(218, 18);
            this.fechaInicio.TabIndex = 42;
            this.fechaInicio.Text = "Fecha inicial de reparación:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitulo.Location = new System.Drawing.Point(254, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(208, 22);
            this.lblTitulo.TabIndex = 41;
            this.lblTitulo.Text = "Modificar Reparación";
            // 
            // frmReparacionesModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 407);
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