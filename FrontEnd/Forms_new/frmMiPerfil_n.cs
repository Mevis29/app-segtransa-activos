using Backend.DAL;
using Backend.Entities;
using FronEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class FrmMiPerfil_n : Form
    {
        Usuarios usuarios;
        public FrmMiPerfil_n()
        {
            InitializeComponent();
        }

        public FrmMiPerfil_n(Usuarios user)
        {
            InitializeComponent();
           usuarios = user;
            
        }

        

        
        private void FrmMiPerfil_n_Load(object sender, EventArgs e)
        {

            IUsuariosDAL usuariosDAL = new UsuariosImplDAL();
            List<spUsuariosRetornaListaId_Result> listaID;

            listaID = usuariosDAL.retornaListaUsuarioId(usuarios.IdUsuario);


            lblMiNombre.Text = listaID[0].Nombre + " " + listaID[0].Apellido;
            lblMiCedula.Text = listaID[0].Cedula.ToString();
            lblMiRol.Text = listaID[0].Rol;
            lblMiTelefono.Text = listaID[0].Telefono;
            lblMiEstado.Text = listaID[0].Estado;
            lblMiCorreo.Text = listaID[0].Correo;
            lblMiDireccion.Text = listaID[0].Direccion;
            lblMiFechaCreacion.Text = listaID[0].FechaCreacion;
            lblMiUltLogin.Text = listaID[0].FechaLogin;


            //lblMiNombre.Text = usuarios.Nombre +" " + usuarios.Apellido;
           
          //  lblMiCedula.Text = usuarios.Cedula.ToString();
           // lblMiRol.Text = usuarios.RolUsuario.ToString();
            
           // lblMiTelefono.Text = usuarios.Telefono;
            //lblMiEstado.Text = usuarios.EstadoUsuario.ToString();
            //lblMiCorreo.Text = usuarios.Correo;
            //lblMiDireccion.Text = usuarios.Telefono;
            //lblMiFechaCreacion.Text = usuarios.FechaCreacion.ToString();
            //lblMiUltLogin.Text = usuarios.FechaUltLogin.ToString();
        }

        private void btnActualizarClave_Click(object sender, EventArgs e)
        {
            try
            {
                IUsuariosDAL usuariosDAL = new UsuariosImplDAL();


                DialogResult dialogResult = MessageBox.Show("Seguro que desea cambiar su contrasena?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    usuarios.Contrasena = txtNuevaClave.Text;
                    usuariosDAL.Update(usuarios);
                    showInfo("Su clave de ingreso fue actualizada!");

                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Operacion Cancelada");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void showInfo(string Mensaje)
        {
            MessageBox.Show(Mensaje);
        }

 
    }
}

