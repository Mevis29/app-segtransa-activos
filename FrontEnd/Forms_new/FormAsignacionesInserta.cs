using Backend.DAL;
using Backend.Entities;
using BackEnd.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd.Formularios
{
    public partial class FormAsignacionesInserta : Form
    {
        public FormAsignacionesInserta()
        {
            InitializeComponent();
        }

        #region cargar FormAsignacionesInsertar
        //invoca los mètodos y propiedds del form, 
        ///q carguen en "0", vacias o cn valores del sistema
        private void FormAsignacionesInsertar_Load(object sender, EventArgs e)
        {
            //Incovar mètodos de carga
            //  this.ValidarFecha();
            this.CargarEmpleados();
            this.CargarActivos();

            //Invocar las herramientas refereciadas a valores del sistema
            this.dtpFechInicialAsig.Value = new DateTime(2019, 01, 01);
            this.dtpFechfinalAsig.Value = new DateTime(2019, 01, 01);
            this.cboEmpleado.SelectedValue = "";
            this.cboActivo.SelectedValue = "";
        }
        #endregion

        #region Botòn Cancelar
        //salir del form
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        #region Botòn Aceptar
        //invocar mètodo ID y propiedds del form 
        //q carguen vacias esperando obtener valores
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarExisteAsignacion()==false)
            {
                this.InsertarDatos();
                this.cboEmpleado.SelectedValue = "";
                this.cboActivo.SelectedValue = "";
            }

        }
        #endregion

        #region Mètodo CargarEmpleados 
        void CargarEmpleados()
        {
            // Objeto de la instancia del Mètodo - spUsuariosRetornaListaEmpleado
            UsuariosImplDAL Empleados = new UsuariosImplDAL();
            this.cboEmpleado.DataSource = Empleados.retornaListaEmpleados(null);
            ///el cbo invoca el origen de datos de Empleado pr retornarlo a la lista desplegada
        }
        #endregion

        #region Mètodo CargarActivos
        void CargarActivos()
        {
            // Objeto de la instancia del Mètodo - spActivosRetornaListaResumen
            ActivosImplDAL Activo = new ActivosImplDAL();
            this.cboActivo.DataSource = Activo.retornaListaActivosResumen(null);
            ///el cbo invoca el origen de datos de Activos pr retornarlo a la lista desplegada
        }
        #endregion

        #region Mètodo InsertarDatos
        void InsertarDatos()
        {
            if (ValidarIngresoDatos())
            {
                try
                {
                    //SE PUEDE METER MAS INGRESS Y VALIDAR - Instancias
                    //UsuariosDALImpl Usuario = new UsuarioDALImpl();
                    //ActivosDALImpl Avtivos = new ActivosDALImpl();

                    // Objeto de la instancia del Mètodo
                    AsignacionesImplDAL Asignacion = new AsignacionesImplDAL();

                    int IdUsuario = 0, IdActivo = 0;  //el valor de los paramtrs del SP,

                    //convierte los valores de los datos pr ser ingresados
                    IdUsuario = Convert.ToInt16(this.cboEmpleado.SelectedValue);
                    IdActivo = Convert.ToInt16(this.cboActivo.SelectedValue);


                    //mètodo pr insertar nvo  activo x empleado
                    Asignacion.InsertaAsignUsuario(IdUsuario, IdActivo,
                               this.dtpFechInicialAsig.Value, this.dtpFechfinalAsig.Value);

                    MessageBox.Show("Registro insertado correctamente.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //carga los datos vacios pr obtener valores
                    this.cboEmpleado.Text = "";
                    this.cboActivo.Text = "";
                    this.dtpFechInicialAsig.Value = new DateTime(1980, 01, 01);
                    this.dtpFechfinalAsig.Value = new DateTime(1980, 01, 01);
                }
                catch (Exception)
                {
                    MessageBox.Show("No fue posible insertar el registro. \nEs posible que esté agregando datos duplicados",
                       "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Metodo ValidarIngresoDatos
        bool ValidarIngresoDatos()
        {
            bool resultado = true;
            string mensaje = "";

            if (this.cboEmpleado.Text == "")
            {
                mensaje += "Debe ingresar un valor para Empleado.";
            }

            if (this.cboActivo.Text == "")

            {
                mensaje += "\nDebe ingresar un valor para Activo.";
            }

            if (dtpFechInicialAsig.Value >= dtpFechfinalAsig.Value)
            {
                mensaje += "\nLa fecha inicial no puede ser mayor a la fecha final.";
            }

                if (mensaje != "")
            {
                MessageBox.Show(mensaje, "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultado = false;
            }

            return resultado;
        }
        #endregion

        private bool validarExisteAsignacion()
        {
            AsignacionesImplDAL asignacionDal = new AsignacionesImplDAL();
            UsuariosImplDAL usuariosDal = new UsuariosImplDAL();

            foreach (spAsignUsuarioRetornaLista_Result asignacion in asignacionDal.retornaListaAsignUsuario("", retornarFragmento(cboActivo.Text)))
            {
                if (asignacion.Usuario.Trim().Equals(retornarFragmento(cboEmpleado.Text)))
                {
                    MessageBox.Show("Esa asignación ya existe.");
                    return true;
                }
            }
            if (asignacionDal.retornaListaAsignUsuario("", retornarFragmento(cboActivo.Text)).Count >= 1)
            {
                MessageBox.Show("Alerta: Ese activo ya tiene una asignación.", "Alerta");
            }
            return false;
        }

        private string retornarFragmento(string concatenacion)
        {
            string[] tokens = concatenacion.Split('-');
            return tokens[1].Trim();
        }
    }
}
