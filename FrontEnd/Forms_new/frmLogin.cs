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

        private void showInfo(string Mensaje)
        {
            MessageBox.Show(Mensaje);
        }

        private void btnIng_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["contadorIntentos"] = (int)Properties.Settings.Default["contadorIntentos"] + 1;
            Properties.Settings.Default.Save();
            if ((int)Properties.Settings.Default["contadorIntentos"] == 6)
            {
                Properties.Settings.Default["fechaUltimoIntento"] = DateTime.Now;
                Properties.Settings.Default["bloqueado"] = true;
                Properties.Settings.Default.Save();
            }
            if (!(bool)Properties.Settings.Default["bloqueado"])
            {
                iniciarSesion();
            }
            else
            {
                desbloqueoIntentos();
                if (!(bool)Properties.Settings.Default["bloqueado"])
                {
                    Properties.Settings.Default["contadorIntentos"] = (int)Properties.Settings.Default["contadorIntentos"] + 1;
                    Properties.Settings.Default.Save();
                    iniciarSesion();
                }
                else
                {
                    showInfo("Alcanzó el número máximo de intentos. Por favor, esperar unos minutos.");
                }
            }
        }

        private void iniciarSesion()
        {
            int i = 0;
            int id = -1;
            string pass;
            string correo;
            if ((string.IsNullOrEmpty(tbxUserId.Text) || string.IsNullOrWhiteSpace(tbxUserId.Text) || !validarCorreo()))
            {
                showInfo("El campo de usuario vacio o con formato equivocado! \nPor favor ingrese su correo!");
                tbxUserId.Clear();
            }
            else
            {
                correo = tbxUserId.Text;
                if (string.IsNullOrWhiteSpace(tbxPassword.Text) || string.IsNullOrEmpty(tbxPassword.Text))
                {
                    showInfo("El campo de Password se encuentra vacio! \nPor favor ingrese su Password!");
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
                                string rolDescripcion = string.Empty;
                                /*Validado usuario y password se le da acceso a un menu de opciones de acuerdo a su roll, admin o cualquier otro*/
                                user = usuariosDal.Getcorreo(correo);
                                ValoresAplicacion.correoUsuario = user.Correo;
                                ValoresAplicacion.idUsuario = user.IdUsuario;
                                if (user.RolUsuario == 1)
                                {
                                    rolDescripcion = "Administrador";
                                }
                                else if (user.RolUsuario == 2)
                                {
                                    rolDescripcion = "Empleado";
                                }
                                ValoresAplicacion.rolUsuario = rolDescripcion;

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
                            }
                        }
                        else
                        {
                            tbxUserId.Clear();
                            tbxPassword.Clear();
                            showInfo("Los datos ingresados no son correctos! \nPor favor ingrese sus datos!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Verifique que las credenciales de usuario sean correctas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void desbloqueoIntentos()
        {
            double tiempobloqueo = DateTime.Now.Subtract((DateTime)Properties.Settings.Default["fechaUltimoIntento"]).TotalMinutes;
            if (tiempobloqueo > 15)
            {
                Properties.Settings.Default["contadorIntentos"] = 0;
                Properties.Settings.Default["bloqueado"] = false;
                Properties.Settings.Default.Save();
            }
        }

        private bool validarCorreo()
        {
            bool isEmail = Regex.IsMatch(tbxUserId.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            return isEmail;
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
