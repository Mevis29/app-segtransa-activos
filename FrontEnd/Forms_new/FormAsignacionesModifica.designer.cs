namespace FrontEnd.Formularios
{
    partial class FormAsignacionesModifica
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
            this.lblActivo = new System.Windows.Forms.Label();
            this.cboActivo = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.dtpFechInicialAsig = new System.Windows.Forms.DateTimePicker();
            this.lblFechInicioAsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.Location = new System.Drawing.Point(35, 145);
            this.lblActivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(183, 18);
            this.lblActivo.TabIndex = 36;
            this.lblActivo.Text = "Modificar Activo Asociado:";
            // 
            // cboActivo
            // 
            this.cboActivo.DisplayMember = "Activo";
            this.cboActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboActivo.FormattingEnabled = true;
            this.cboActivo.Location = new System.Drawing.Point(35, 185);
            this.cboActivo.Margin = new System.Windows.Forms.Padding(4);
            this.cboActivo.Name = "cboActivo";
            this.cboActivo.Size = new System.Drawing.Size(383, 26);
            this.cboActivo.TabIndex = 35;
            this.cboActivo.ValueMember = "Id";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(285, 341);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 33);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(49, 341);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 33);
            this.btnAceptar.TabIndex = 33;
            this.btnAceptar.Text = "Modificar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(35, 45);
            this.lblEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(157, 18);
            this.lblEmpleado.TabIndex = 32;
            this.lblEmpleado.Text = "Nombre de Empleado:";
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.DisplayMember = "Empleado";
            this.cboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(39, 82);
            this.cboEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(379, 26);
            this.cboEmpleado.TabIndex = 31;
            this.cboEmpleado.ValueMember = "Id";
            // 
            // dtpFechInicialAsig
            // 
            this.dtpFechInicialAsig.CustomFormat = "ddd dd-MMM-yyyy";
            this.dtpFechInicialAsig.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechInicialAsig.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechInicialAsig.Location = new System.Drawing.Point(171, 269);
            this.dtpFechInicialAsig.Name = "dtpFechInicialAsig";
            this.dtpFechInicialAsig.Size = new System.Drawing.Size(247, 24);
            this.dtpFechInicialAsig.TabIndex = 39;
            // 
            // lblFechInicioAsg
            // 
            this.lblFechInicioAsg.AutoSize = true;
            this.lblFechInicioAsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechInicioAsg.Location = new System.Drawing.Point(35, 269);
            this.lblFechInicioAsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechInicioAsg.Name = "lblFechInicioAsg";
            this.lblFechInicioAsg.Size = new System.Drawing.Size(91, 18);
            this.lblFechInicioAsg.TabIndex = 37;
            this.lblFechInicioAsg.Text = "Fecha Inicio:";
            // 
            // FormAsignacionesModifica
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(468, 389);
            this.Controls.Add(this.dtpFechInicialAsig);
            this.Controls.Add(this.lblFechInicioAsg);
            this.Controls.Add(this.lblActivo);
            this.Controls.Add(this.cboActivo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.cboEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormAsignacionesModifica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Asignacion";
            this.Load += new System.EventHandler(this.FormAsignacionesModifica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.ComboBox cboActivo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.DateTimePicker dtpFechInicialAsig;
        private System.Windows.Forms.Label lblFechInicioAsg;
    }
}