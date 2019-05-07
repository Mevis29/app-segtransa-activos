using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Frontend;
using Backend.Entities;
using FrontEnd.Forms_new;
using FrontEnd.Formularios;

namespace FrontEnd
{
    public partial class FrmMenuPrincipal : Form
    {
        private Usuarios usuario;
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            inicializarComponentes();
        }


        public FrmMenuPrincipal(Usuarios user)
        {
            InitializeComponent();
            inicializarComponentes();
            if (user.RolUsuario != 1)
            {
                pnlAdmin.Visible= false;
            }
            usuario = user;
             printInfo();
        }

        private void printInfo()
        {
            lblNombre.Text = usuario.Nombre + " " + usuario.Apellido;
            lblFecha.Text = DateTime.Today.ToShortDateString();
            //lblNombre2.Text = "Bienvenido" + usuario.Nombre + " " + usuario.Apellido;
        }



        private void inicializarComponentes()
        {
 
            this.menuVertical.Width = 201;
            this.btnUsuarios.Width = 190;
            this.btnProveedores.Width = 190;
            this.btnMiPerfil.Width = 190;
            this.btnAsignaciones.Width = 190;
            this.btnActivos.Width = 190;
            this.btnReparaciones.Width = 190;
            this.btnMisActivos.Width = 190;

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(menuVertical.Width == 201)
            {
                menuVertical.Width = 55;
            }
            else
            {
                menuVertical.Width = 201;
            }
        }

        private void cerrarIcon_Click(object sender, EventArgs e)
        {
            const string message = "¿Desea salir de la aplicación?";
            const string caption = "Salir";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void minimizarIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void colapsarMenuIcon_Click(object sender, EventArgs e)
        {
            try
            {
                menuVertical.Width = 55;
                menuIcon.Visible = true;
                colapsarMenuIcon.Visible = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void menuIcon_Click(object sender, EventArgs e)
        {
            try
            {
                menuVertical.Width = 201;
                menuIcon.Visible = false;
                colapsarMenuIcon.Visible = true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tituloPnl_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void abrirFormInPanel(object FormHijo)
        {
            try
            {
                if (this.contentPnl.Controls.Count > 0)
                {
                    this.contentPnl.Controls.RemoveAt(0);
                    Form fh = FormHijo as Form;
                    fh.TopLevel = false;
                    fh.Dock = DockStyle.Fill;
                    this.contentPnl.Controls.Add(fh);
                    this.contentPnl.Tag = fh;
                    fh.Show();
                }
                else
                {
                    Form fh = FormHijo as Form;
                    fh.TopLevel = false;
                    fh.Dock = DockStyle.Fill;
                    this.contentPnl.Controls.Add(fh);
                    this.contentPnl.Tag = fh;
                    fh.Show();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Un error");
            }
        }

        /// <summary>
        /// Botones para abrir los forms hijos
        /// </summary>

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new FrmUsuarios_n());
        }

        private void btnActivos_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new frmMenuPrincipal_n());
        }

        private void btnAsignaciones_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new FormAsignacionesLista());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new FrmProveedores_n());
        }

        private void btnMiPerfil_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new FrmMiPerfil_n(usuario));
        }

        private void btnReparaciones_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new frmReparaciones());
        }

        private void contentPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMisActivos_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new FrmMisActivos_n(usuario.IdUsuario));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            const string message = "¿Desea salir de la aplicación?";
            const string caption = "Salir";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new frmMenuReportes());
        }

        private void btnFormRespaldos_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new frmRespaldos());
        }
    }
}
