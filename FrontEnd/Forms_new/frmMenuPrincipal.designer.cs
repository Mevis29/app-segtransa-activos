﻿namespace FrontEnd
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.menuVertical = new System.Windows.Forms.Panel();
            this.btnFormRespaldos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnActivos = new System.Windows.Forms.Button();
            this.btnAsignaciones = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnMisActivos = new System.Windows.Forms.Button();
            this.btnReparaciones = new System.Windows.Forms.Button();
            this.btnMiPerfil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tituloPnl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.colapsarMenuIcon = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.minimizarIcon = new System.Windows.Forms.PictureBox();
            this.cerrarIcon = new System.Windows.Forms.PictureBox();
            this.menuIcon = new System.Windows.Forms.PictureBox();
            this.contentPnl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.menuVertical.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tituloPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colapsarMenuIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuIcon)).BeginInit();
            this.contentPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.menuVertical.Controls.Add(this.btnFormRespaldos);
            this.menuVertical.Controls.Add(this.btnSalir);
            this.menuVertical.Controls.Add(this.pnlAdmin);
            this.menuVertical.Controls.Add(this.btnReportes);
            this.menuVertical.Controls.Add(this.btnMisActivos);
            this.menuVertical.Controls.Add(this.btnReparaciones);
            this.menuVertical.Controls.Add(this.btnMiPerfil);
            this.menuVertical.Controls.Add(this.pictureBox1);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 0);
            this.menuVertical.Margin = new System.Windows.Forms.Padding(2);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(203, 570);
            this.menuVertical.TabIndex = 0;
            // 
            // btnFormRespaldos
            // 
            this.btnFormRespaldos.Location = new System.Drawing.Point(38, 481);
            this.btnFormRespaldos.Name = "btnFormRespaldos";
            this.btnFormRespaldos.Size = new System.Drawing.Size(120, 23);
            this.btnFormRespaldos.TabIndex = 11;
            this.btnFormRespaldos.Text = "Respaldar datos";
            this.btnFormRespaldos.UseVisualStyleBackColor = true;
            this.btnFormRespaldos.Click += new System.EventHandler(this.btnFormRespaldos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = global::FrontEnd.Properties.Resources.logout;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(6, 522);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(190, 37);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Controls.Add(this.label1);
            this.pnlAdmin.Controls.Add(this.btnUsuarios);
            this.pnlAdmin.Controls.Add(this.btnActivos);
            this.pnlAdmin.Controls.Add(this.btnAsignaciones);
            this.pnlAdmin.Controls.Add(this.btnProveedores);
            this.pnlAdmin.Location = new System.Drawing.Point(2, 251);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(194, 214);
            this.pnlAdmin.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(60, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "------------------";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = global::FrontEnd.Properties.Resources.followers;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(3, 30);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(190, 37);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnActivos
            // 
            this.btnActivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivos.FlatAppearance.BorderSize = 0;
            this.btnActivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivos.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivos.ForeColor = System.Drawing.Color.White;
            this.btnActivos.Image = global::FrontEnd.Properties.Resources.projector;
            this.btnActivos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivos.Location = new System.Drawing.Point(2, 71);
            this.btnActivos.Margin = new System.Windows.Forms.Padding(2);
            this.btnActivos.Name = "btnActivos";
            this.btnActivos.Size = new System.Drawing.Size(190, 37);
            this.btnActivos.TabIndex = 2;
            this.btnActivos.Text = "Activos";
            this.btnActivos.UseVisualStyleBackColor = true;
            this.btnActivos.Click += new System.EventHandler(this.btnActivos_Click);
            // 
            // btnAsignaciones
            // 
            this.btnAsignaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignaciones.FlatAppearance.BorderSize = 0;
            this.btnAsignaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignaciones.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignaciones.ForeColor = System.Drawing.Color.White;
            this.btnAsignaciones.Image = global::FrontEnd.Properties.Resources.coordination1;
            this.btnAsignaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignaciones.Location = new System.Drawing.Point(0, 112);
            this.btnAsignaciones.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsignaciones.Name = "btnAsignaciones";
            this.btnAsignaciones.Size = new System.Drawing.Size(190, 37);
            this.btnAsignaciones.TabIndex = 3;
            this.btnAsignaciones.Text = "    Asignaciones";
            this.btnAsignaciones.UseVisualStyleBackColor = true;
            this.btnAsignaciones.Click += new System.EventHandler(this.btnAsignaciones_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.Image = global::FrontEnd.Properties.Resources.interview;
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(3, 153);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(190, 37);
            this.btnProveedores.TabIndex = 4;
            this.btnProveedores.Text = "   Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Image = global::FrontEnd.Properties.Resources.strategy;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(1, 208);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(2);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(190, 37);
            this.btnReportes.TabIndex = 9;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMisActivos
            // 
            this.btnMisActivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMisActivos.FlatAppearance.BorderSize = 0;
            this.btnMisActivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisActivos.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisActivos.ForeColor = System.Drawing.Color.White;
            this.btnMisActivos.Image = global::FrontEnd.Properties.Resources.hd;
            this.btnMisActivos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMisActivos.Location = new System.Drawing.Point(3, 115);
            this.btnMisActivos.Margin = new System.Windows.Forms.Padding(2);
            this.btnMisActivos.Name = "btnMisActivos";
            this.btnMisActivos.Size = new System.Drawing.Size(190, 37);
            this.btnMisActivos.TabIndex = 8;
            this.btnMisActivos.Text = "Mis Activos";
            this.btnMisActivos.UseVisualStyleBackColor = true;
            this.btnMisActivos.Click += new System.EventHandler(this.btnMisActivos_Click);
            // 
            // btnReparaciones
            // 
            this.btnReparaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReparaciones.FlatAppearance.BorderSize = 0;
            this.btnReparaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReparaciones.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReparaciones.ForeColor = System.Drawing.Color.White;
            this.btnReparaciones.Image = global::FrontEnd.Properties.Resources.magnifying_glass;
            this.btnReparaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReparaciones.Location = new System.Drawing.Point(3, 162);
            this.btnReparaciones.Margin = new System.Windows.Forms.Padding(2);
            this.btnReparaciones.Name = "btnReparaciones";
            this.btnReparaciones.Size = new System.Drawing.Size(190, 37);
            this.btnReparaciones.TabIndex = 6;
            this.btnReparaciones.Text = "    Reparaciones";
            this.btnReparaciones.UseVisualStyleBackColor = true;
            this.btnReparaciones.Click += new System.EventHandler(this.btnReparaciones_Click);
            // 
            // btnMiPerfil
            // 
            this.btnMiPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMiPerfil.FlatAppearance.BorderSize = 0;
            this.btnMiPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiPerfil.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiPerfil.ForeColor = System.Drawing.Color.White;
            this.btnMiPerfil.Image = global::FrontEnd.Properties.Resources.user24;
            this.btnMiPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMiPerfil.Location = new System.Drawing.Point(4, 71);
            this.btnMiPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.btnMiPerfil.Name = "btnMiPerfil";
            this.btnMiPerfil.Size = new System.Drawing.Size(190, 37);
            this.btnMiPerfil.TabIndex = 5;
            this.btnMiPerfil.Text = "Mi Perfil";
            this.btnMiPerfil.UseVisualStyleBackColor = true;
            this.btnMiPerfil.Click += new System.EventHandler(this.btnMiPerfil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrontEnd.Properties.Resources.Picture1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tituloPnl
            // 
            this.tituloPnl.BackColor = System.Drawing.Color.Black;
            this.tituloPnl.Controls.Add(this.panel2);
            this.tituloPnl.Controls.Add(this.lblFecha);
            this.tituloPnl.Controls.Add(this.colapsarMenuIcon);
            this.tituloPnl.Controls.Add(this.lblNombre);
            this.tituloPnl.Controls.Add(this.minimizarIcon);
            this.tituloPnl.Controls.Add(this.cerrarIcon);
            this.tituloPnl.Controls.Add(this.menuIcon);
            this.tituloPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tituloPnl.Location = new System.Drawing.Point(203, 0);
            this.tituloPnl.Margin = new System.Windows.Forms.Padding(2);
            this.tituloPnl.Name = "tituloPnl";
            this.tituloPnl.Size = new System.Drawing.Size(797, 57);
            this.tituloPnl.TabIndex = 1;
            this.tituloPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tituloPnl_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::FrontEnd.Properties.Resources.logo2_01;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(232, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 49);
            this.panel2.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.LightGray;
            this.lblFecha.Location = new System.Drawing.Point(668, 33);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(41, 16);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "label1";
            // 
            // colapsarMenuIcon
            // 
            this.colapsarMenuIcon.BackColor = System.Drawing.Color.Black;
            this.colapsarMenuIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colapsarMenuIcon.Image = ((System.Drawing.Image)(resources.GetObject("colapsarMenuIcon.Image")));
            this.colapsarMenuIcon.Location = new System.Drawing.Point(4, 15);
            this.colapsarMenuIcon.Margin = new System.Windows.Forms.Padding(2);
            this.colapsarMenuIcon.Name = "colapsarMenuIcon";
            this.colapsarMenuIcon.Size = new System.Drawing.Size(33, 24);
            this.colapsarMenuIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.colapsarMenuIcon.TabIndex = 0;
            this.colapsarMenuIcon.TabStop = false;
            this.colapsarMenuIcon.Click += new System.EventHandler(this.colapsarMenuIcon_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.LightGray;
            this.lblNombre.Location = new System.Drawing.Point(83, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(41, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "label1";
            // 
            // minimizarIcon
            // 
            this.minimizarIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizarIcon.BackColor = System.Drawing.Color.Black;
            this.minimizarIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizarIcon.Image = ((System.Drawing.Image)(resources.GetObject("minimizarIcon.Image")));
            this.minimizarIcon.Location = new System.Drawing.Point(742, 2);
            this.minimizarIcon.Margin = new System.Windows.Forms.Padding(2);
            this.minimizarIcon.Name = "minimizarIcon";
            this.minimizarIcon.Size = new System.Drawing.Size(17, 14);
            this.minimizarIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizarIcon.TabIndex = 3;
            this.minimizarIcon.TabStop = false;
            this.minimizarIcon.Click += new System.EventHandler(this.minimizarIcon_Click);
            // 
            // cerrarIcon
            // 
            this.cerrarIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrarIcon.BackColor = System.Drawing.Color.Black;
            this.cerrarIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrarIcon.Image = ((System.Drawing.Image)(resources.GetObject("cerrarIcon.Image")));
            this.cerrarIcon.Location = new System.Drawing.Point(775, 2);
            this.cerrarIcon.Margin = new System.Windows.Forms.Padding(2);
            this.cerrarIcon.Name = "cerrarIcon";
            this.cerrarIcon.Size = new System.Drawing.Size(17, 14);
            this.cerrarIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrarIcon.TabIndex = 2;
            this.cerrarIcon.TabStop = false;
            this.cerrarIcon.Click += new System.EventHandler(this.cerrarIcon_Click);
            // 
            // menuIcon
            // 
            this.menuIcon.BackColor = System.Drawing.Color.Black;
            this.menuIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuIcon.Image = ((System.Drawing.Image)(resources.GetObject("menuIcon.Image")));
            this.menuIcon.Location = new System.Drawing.Point(6, 10);
            this.menuIcon.Margin = new System.Windows.Forms.Padding(2);
            this.menuIcon.Name = "menuIcon";
            this.menuIcon.Size = new System.Drawing.Size(32, 37);
            this.menuIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuIcon.TabIndex = 1;
            this.menuIcon.TabStop = false;
            this.menuIcon.Visible = false;
            this.menuIcon.Click += new System.EventHandler(this.menuIcon_Click);
            // 
            // contentPnl
            // 
            this.contentPnl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contentPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contentPnl.Controls.Add(this.label2);
            this.contentPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPnl.Location = new System.Drawing.Point(203, 57);
            this.contentPnl.Margin = new System.Windows.Forms.Padding(2);
            this.contentPnl.Name = "contentPnl";
            this.contentPnl.Size = new System.Drawing.Size(797, 513);
            this.contentPnl.TabIndex = 2;
            this.contentPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.contentPnl_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(224, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sistema de Control de Activos";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1000, 570);
            this.Controls.Add(this.contentPnl);
            this.Controls.Add(this.tituloPnl);
            this.Controls.Add(this.menuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuVertical.ResumeLayout(false);
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tituloPnl.ResumeLayout(false);
            this.tituloPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colapsarMenuIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuIcon)).EndInit();
            this.contentPnl.ResumeLayout(false);
            this.contentPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.Panel tituloPnl;
        private System.Windows.Forms.Panel contentPnl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox menuIcon;
        private System.Windows.Forms.PictureBox cerrarIcon;
        private System.Windows.Forms.PictureBox colapsarMenuIcon;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnMiPerfil;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnAsignaciones;
        private System.Windows.Forms.Button btnActivos;
        private System.Windows.Forms.Button btnReparaciones;
        private System.Windows.Forms.Button btnMisActivos;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox minimizarIcon;
        private System.Windows.Forms.Label label2;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Button btnFormRespaldos;
    }
}

