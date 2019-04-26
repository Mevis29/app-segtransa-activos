using Backend.DAL;
using Backend.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FronEnd
{
    public partial class FrmUsuariosModificar_n : Form
    {
        private IUsuariosDAL usuariosDAL;
        private IRolUsuariosDAL rolUsuariosDAL;
        private IEstadoUsuariosDAL estadoUsuariosDAL;
        private Usuarios Usuario;

      public FrmUsuariosModificar_n()
        {
            InitializeComponent();
        }

        public FrmUsuariosModificar_n(int id)
        {
            InitializeComponent();
            rolUsuariosDAL = new RolUsuariosImplDAL();
            usuariosDAL = new UsuariosImplDAL();
            estadoUsuariosDAL = new EstadoUsuariosImplDAL();
            Usuario = usuariosDAL.GetUsuario(id);
           

        }

        private void CargaComboRoles()
        {
            //ComboBox de Roles
            cmbBoxRolA.DisplayMember = "NombreRol";
            cmbBoxRolA.ValueMember = "IdRol";
            List<RolUsuarios> rol_Usuarios = rolUsuariosDAL.GetRols();
            cmbBoxRolA.DataSource = rol_Usuarios;
           // cmbBoxRolA.SelectedValue = Usuario.RolUsuario.ToString();

            //ComboBox de Estado del Usuario
            cmbBoxEstadoA.DisplayMember = "NombreEstado";
            cmbBoxEstadoA.ValueMember = "IdEstadoUsuario";
            List<EstadoUsuarios> estado_Usuarios = estadoUsuariosDAL.GetEstadoUsuarios();
            cmbBoxEstadoA.DataSource = estado_Usuarios;
            //cmbBoxEstadoA.SelectedItem = Usuario.EstadoUsuario.ToString();
          

        }

        private void FrmUsuariosModificar_n_Load(object sender, EventArgs e)
        {
            CargaComboRoles();
            txtNombreA.Text = Usuario.Nombre;
            txtApellido1A.Text = Usuario.Apellido;
            txtContrasenaA.Text = Usuario.Contrasena;
            txtDireccionA.Text = Usuario.Direccion;
            txtCorreoA.Text = Usuario.Correo;
            txtTelefonoA.Text = Usuario.Telefono;
            txtCedulaA.Text = Usuario.Cedula.ToString();
           

        }



        private void btnModificaUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                String nombre = this.txtNombreA.Text;
                String apellido = this.txtApellido1A.Text;
                String cedula = txtCedulaA.Text;
                String contrasena = txtContrasenaA.Text;

                // Valida que los campos requeridos tengan valores (Nombre, Apellido y/o Cedula)

                if (nombre.Length <= 0 || apellido.Length <=0 || cedula.Length <=0)
                {
                    this.errorLbl.Visible = true;
                    this.lblErrorApellido.Visible = true;
                    this.lblErrorContrasena.Visible = true;
                    this.lblErrorNombre.Visible = true;
                }
                //Valida que el campo de Cedula lleve solo numeros
                else if(Regex.IsMatch(cedula,@"^\d+$") == false){
                    this.lblErrorCed.Visible = true;
                }
                // Si estan esas validaciones, se crea el objeto a insertar en la Base de Datos
                else
                {
                    this.errorLbl.Visible = false;
                    this.lblErrorCed.Visible = false;

                    //Usuario = new Usuarios();

                    Usuario.Nombre = txtNombreA.Text;
                    Usuario.Apellido = txtApellido1A.Text;
                    Usuario.Telefono = txtTelefonoA.Text;
                    Usuario.Cedula = int.Parse(txtCedulaA.Text);
                    Usuario.Correo = txtCorreoA.Text;
                    Usuario.Direccion = txtDireccionA.Text;
                    Usuario.RolUsuario = (int)cmbBoxRolA.SelectedValue;
                    Usuario.RolUsuarios = (RolUsuarios)cmbBoxRolA.SelectedItem;
                    Usuario.Contrasena = txtContrasenaA.Text;
                    Usuario.EstadoUsuario = (int)cmbBoxEstadoA.SelectedValue;
                    Usuario.EstadoUsuarios = (EstadoUsuarios)cmbBoxEstadoA.SelectedItem;
                    

                    usuariosDAL.Update(Usuario);
                    MessageBox.Show("Usuario actualizado");
                    this.Hide();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex.Message);
            }


        }


       protected override void OnClosing(CancelEventArgs e)
        {
            // Let the default behavior to happen.
            base.OnClosing(e);
            // Do not allow cancellation of the close operation.
            e.Cancel = false;
            //frmUsuariosAgrega frmUsuarios = new frmUsuariosAgrega();

            //previousForm.Show();
        }

        //Boton de Cancelar
        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
