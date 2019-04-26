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
    public partial class FrmUsuariosAgregar_n : Form
    {
        private IUsuariosDAL usuarioDAL = new UsuariosImplDAL();
        private IRolUsuariosDAL rolUsuariosDAL = new RolUsuariosImplDAL();
        private Usuarios Usuario;

        public FrmUsuariosAgregar_n()
        {
            InitializeComponent();
            CargaComboRoles();
        }

        private void CargaComboRoles()
        {
            cmbBoxRol.DisplayMember = "nombreRol";
            cmbBoxRol.ValueMember = "idRol";
            List<RolUsuarios> rol_Usuarios = rolUsuariosDAL.GetRols();

            cmbBoxRol.DataSource = rol_Usuarios;
        }



        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregaUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                String nombre = this.txtNombre.Text;
                String apellido = this.txtApellido1.Text;
                String cedula = txtCedula.Text;
                String contrasena = txtContrasena.Text;

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
                    Usuario = new Usuarios();
                    Usuario.Nombre = txtNombre.Text;
                    Usuario.Apellido = txtApellido1.Text;
                    Usuario.Telefono = txtTelefono.Text;
                    Usuario.Cedula = int.Parse(txtCedula.Text);
                    Usuario.Correo = txtCorreo.Text;
                    Usuario.Direccion = txtDireccion.Text;
                    Usuario.RolUsuario = (int)cmbBoxRol.SelectedValue;
                    Usuario.RolUsuarios = (RolUsuarios)cmbBoxRol.SelectedItem;
                    Usuario.Contrasena = txtContrasena.Text;
                    Usuario.FechaCreacion = DateTime.Now;
                    Usuario.EstadoUsuario = 1; // Estado default al agregar un usuario es 1 de Activo

                    usuarioDAL.Add(Usuario);
                    MessageBox.Show("Usuario agregado");
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

    }
}
