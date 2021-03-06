﻿using Backend.DAL;
using Backend.Entities;
using FrontEnd.Clases;
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
        private IBitacoraDAL bitacoraDAL = new BitacoraImplDAL();
        private Bitacora bitacora = new Bitacora();
        private Usuarios Usuario;
        CryptoEngine aux = new CryptoEngine();
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
            for (int i = 0; i < rol_Usuarios.Count; i++)
            {
                if (rol_Usuarios[i].IdRol == Usuario.RolUsuario)
                {
                    cmbBoxRolA.SelectedItem = rol_Usuarios[i];
                }
            }
        }

        private void FrmUsuariosModificar_n_Load(object sender, EventArgs e)
        {
            CargaComboRoles();
            txtNombreA.Text = Usuario.Nombre;
            txtApellido1A.Text = Usuario.Apellido;
            txtContrasenaA.Text = aux.Decrypt(Usuario.Contrasena);
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
                String contrasena = aux.Encrypt(txtContrasenaA.Text);
                String correo = txtCorreoA.Text;
                CryptoEngine cryptoEngine = new CryptoEngine();
                // Valida que los campos requeridos tengan valores (Nombre, Apellido y/o Cedula)

                if (nombre.Length <= 0 || apellido.Length <=0 || cedula.Length <=0 || correo.Length <= 0 || contrasena.Length <= 0)
                {
                    this.errorLbl.Visible = true;
                   
                }
                //Valida que el campo de Cedula lleve solo numeros
                else if(Regex.IsMatch(cedula,@"^\d+$") == false){
                    this.lblErrorCed.Visible = true;
                    this.lblErrorApellido.Visible = false;
                    this.lblErrorNombre.Visible = false;
                    this.lblErrorCorreo.Visible = false;
                }
                //Valida que el nombre solo lleve letras
                else if (Regex.IsMatch(nombre, @"[a-zA-Z]+") == false)
                {
                    this.lblErrorCed.Visible = false;
                    this.lblErrorApellido.Visible = false;
                    this.lblErrorNombre.Visible = true;
                    this.lblErrorCorreo.Visible = false;
                }
                //Valida que el apellido solo lleve letras
                else if (Regex.IsMatch(apellido, @"[a-zA-Z]+") == false)
                {
                    this.lblErrorCed.Visible = false;
                    this.lblErrorApellido.Visible = false;
                    this.lblErrorNombre.Visible = true;
                    this.lblErrorCorreo.Visible = false;
                }
                else if (!validarCorreo())
                {
                    this.lblErrorCed.Visible = false;
                    this.lblErrorApellido.Visible = false;
                    this.lblErrorNombre.Visible = false;
                    this.lblErrorCorreo.Visible = true;
                }
                // Si estan esas validaciones, se crea el objeto a insertar en la Base de Datos
                else
                {
                    this.errorLbl.Visible = false;
                    this.lblErrorCed.Visible = false;
                    this.lblErrorNombre.Visible = false;
                    this.lblErrorApellido.Visible = false;
                    this.lblErrorCorreo.Visible = false;

                    //Usuario = new Usuarios();
                    
                    Usuario.Nombre = txtNombreA.Text;
                    Usuario.Apellido = txtApellido1A.Text;
                    Usuario.Telefono = txtTelefonoA.Text;
                    Usuario.Cedula = int.Parse(txtCedulaA.Text);
                    Usuario.Correo = txtCorreoA.Text;
                    Usuario.Direccion = txtDireccionA.Text;
                    Usuario.RolUsuario = (int)cmbBoxRolA.SelectedValue;
                    Usuario.RolUsuarios = (RolUsuarios)cmbBoxRolA.SelectedItem;
                    Usuario.Contrasena = aux.Encrypt(txtContrasenaA.Text);
                    //Si la contrasena en el txtContrasenaA es igual a la del usuario en bd
                    /*if (aux.Decrypt(txtContrasenaA.Text).Equals(aux.Decrypt(usuariosDAL.Getcorreo(Usuario.Correo).Contrasena)))
                    {
                        //mandarla como esta en el cuadro, ahi ya esta encriptada.
                       
                        Usuario.Contrasena = txtContrasenaA.Text;
                    }
                    else if (txtContrasenaA.Text.Equals(aux.Decrypt(usuariosDAL.Getcorreo(Usuario.Correo).Contrasena)))
                    {
                        Usuario.Contrasena = aux.Encrypt(txtContrasenaA.Text);
                    }else
                    {
                        //Si no, significa que cambio. Entonces aplicamos encripcion y la guardamos.
                        Usuario.Contrasena = aux.Encrypt(txtContrasenaA.Text);
                    }*/

                    
                    

                    usuariosDAL.Update(Usuario);
                    string detalleBitacora = "Se actualizaron los datos del usuario: " + Usuario.Nombre+" "+Usuario.Apellido;
                    bitacora.DetalleBitacora = detalleBitacora;
                    bitacora.IdUsuario = ValoresAplicacion.idUsuario;
                    bitacoraDAL.Add(bitacora);
                    MessageBox.Show("Usuario actualizado");
                    this.Hide();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error. Revise que la cédula y el correo no estén siendo usados por otro usuario" );
            }


        }

        private bool validarCorreo()
        {
            bool isEmail = Regex.IsMatch(txtCorreoA.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            return isEmail;
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
