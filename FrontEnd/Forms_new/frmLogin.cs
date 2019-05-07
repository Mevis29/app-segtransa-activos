using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend.DAL;
using Backend.Entities;
using FrontEnd;
using FrontEnd.Clases;

namespace FrontEnd
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public IUsuariosDAL usuariosDal = new UsuariosImplDAL();
        CryptoEngine cryptoEngine = new CryptoEngine();
        private IBitacoraDAL bitacoraDAL = new BitacoraImplDAL();
        private Bitacora bitacora = new Bitacora();
        public Usuarios user;
        int contadorIntentos = 0;

        private void showInfo(string Mensaje)
        {
            MessageBox.Show(Mensaje);
        }

        private void btnIng_Click(object sender, EventArgs e)
        {
            contadorIntentos = contadorIntentos + 1;
            int i = 0;
            int id = -1;
            string pass;
            string correo;
            if ((string.IsNullOrEmpty(tbxUserId.Text) || string.IsNullOrWhiteSpace(tbxUserId.Text)))
            {
                showInfo("El campo de Id usuario vacio o con formato equivocado! \nPor favor ingrese unicamente numeros!");
                tbxUserId.Clear();
                if (contadorIntentos > 5)
                {
                    showInfo("Alcanzo el numero maximo de Intentos! \nPor favor comuniquese con el departamento de Informatica!");
                    Close();
                }
            }
            else 
            {
                correo = tbxUserId.Text;

                if (string.IsNullOrWhiteSpace(tbxPassword.Text) || string.IsNullOrEmpty(tbxPassword.Text))
                {
                    showInfo("El campo de Password se encuentra vacio! \nPor favor ingrese su Password!");
                    if (contadorIntentos > 5)
                    {
                        showInfo("Alcanzo el numero maximo de Intentos! \nPor favor comuniquese con el departamento de Informatica!");
                        Close();
                    }
                }
                else
                {
                    pass = cryptoEngine.Encrypt(tbxPassword.Text);

                    /*user = usuariosDal.GetUsuario(id);*/
                    //showInfo("Password: " + tbxPassword.Text + " Encryptada: " + pass);
                    /*Validanado usuario*/
                    try
                    {
                        if (usuariosDal.isRealUser(correo))
                        {

                            if (usuariosDal.isValidPassword(pass, correo))
                            {
                                /*Validado usuario y password se le da acceso a un menu de opciones de acuerdo a su roll, admin o cualquier otro*/
                                user = usuariosDal.Getcorreo(correo);
                                ValoresAplicacion.correoUsuario = user.Correo;
                                ValoresAplicacion.idUsuario = user.IdUsuario;

                                //Actualiza el campo del ultimo Login

                                if (user.FechaUltLogin.ToString().Contains("2000"))
                                {
                                    //mostrar mensaje con datos de usuario y último login
                                    MessageBox.Show("Bienvenido " + user.Nombre + "." + Environment.NewLine +
                                    "Esta es la primera vez que ingresa al Sistema.",
                                    "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    //mostrar mensaje con datos de usuario y último login
                                    MessageBox.Show("Bienvenido " + user.Nombre + "." + Environment.NewLine +
                                    "Usted ingresó por última vez el " + user.FechaUltLogin.ToString(),
                                    "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                //actualizar fecha y hora de último login del usuario
                                usuariosDal.actualizaDatosLogin(user.IdUsuario);
                                string detalleBitacora = "El usuario " + user.Nombre + " " + user.Apellido + " inició sesión";
                                bitacora.DetalleBitacora = detalleBitacora;
                                bitacora.IdUsuario = ValoresAplicacion.idUsuario;
                                bitacoraDAL.Add(bitacora);



                                // abrir form Menu Principal


                                FrmMenuPrincipal menuPrincipal = new FrmMenuPrincipal(user);
                                menuPrincipal.Show();
                                tbxUserId.Clear();
                                tbxPassword.Clear();
                                this.Hide();
                            }
                            else
                            {
                                tbxUserId.Clear();
                                tbxPassword.Clear();
                                showInfo("Los datos ingresados no son correctos! \nPor favor ingrese sus datos!");
                                if (contadorIntentos > 5)
                                {
                                    showInfo("Alcanzo el numero maximo de Intentos! \nPor favor comuniquese con el departamento de Informatica!");
                                    Close();
                                }
                            }
                        }
                        else
                        {
                            tbxUserId.Clear();
                            tbxPassword.Clear();
                            showInfo("Los datos ingresados no son correctos! \nPor favor ingrese sus datos!");
                            if (contadorIntentos > 5)
                            {
                                showInfo("Alcanzo el numero maximo de Intentos! \nPor favor comuniquese con el departamento de Informatica!");
                                Close();
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Verifique que las credenciales de usuario sean correctas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                } 
            }
        }

        private void tbxUserId_Enter(object sender, EventArgs e)
        {
            if (tbxUserId.Text == "CORREO")
            {
                tbxUserId.Text = "";
                tbxUserId.ForeColor = Color.LightGray;
            }
        }


        private void tbxUserId_Leave(object sender, EventArgs e)
        {
            if (tbxUserId.Text == "")
            {
                tbxUserId.Text = "CORREO";
                tbxUserId.ForeColor = Color.DimGray;
            }
        }

        private void tbxPassword_Enter(object sender, EventArgs e)
        {
            if (tbxPassword.Text == "CONTRASEÑA")
            {
                tbxPassword.Text = "";
                tbxPassword.ForeColor = Color.LightGray;
                tbxPassword.UseSystemPasswordChar = true;
            }
        }

        private void tbxPassword_Leave(object sender, EventArgs e)
        {
            if (tbxPassword.Text == "")
            {
                tbxPassword.Text = "CONTRASEÑA";
                tbxPassword.ForeColor = Color.DimGray;
                tbxPassword.UseSystemPasswordChar = false;
            }
        }

        private void cerrarIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
           // ReleaseCapture();
           // SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
           // ReleaseCapture();
           // SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
