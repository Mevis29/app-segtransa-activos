using Backend.DAL;
using Backend.Entities;
using BackEnd.DAL;
using FrontEnd.Clases;
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
    public partial class FormAsignacionesModifica : Form
    {
        private IBitacoraDAL bitacoraDAL = new BitacoraImplDAL();
        private Bitacora bitacora = new Bitacora();
        string codigo = string.Empty;
        string nombreEmpleado = string.Empty;
        #region definir variables, inicilizaciòn
        //definir variable para indicar IdAsignacion
        //IdAsignacion =  spAsignUsuarioRetornaDatosId_Result retornaIdAsignacionId(int pIdAsignacion)
        int IdAsignacion { set; get; }
        public FormAsignacionesModifica(int pIdAsignacion)
        {
            InitializeComponent();
            this.IdAsignacion = pIdAsignacion;
        }
        #endregion

        #region cargar FormAsignacionesModifica
        //invoca los mètodos
        private void FormAsignacionesModifica_Load(object sender, EventArgs e)
        {
            this.CargarEmpleados();
            this.CargarActivos();
            this.CargarDatos();
        }
        #endregion

        #region botòn Cancelar
        //salir del form
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region botòn Aceptar
        //invocar mètodo ModificarDatos
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarExisteAsignacion() == false)
            {
                this.ModificarDatos();
            }
            // this.dtpFechInicialAsg.Value = new DateTime(1980, 01, 01);
            // this.dtpFechFinAsgn.Value = new DateTime(1980, 01, 01);
        }
        #endregion

        #region Mètodo  CargarEmpleados
        void CargarEmpleados()
        {
            UsuariosImplDAL Empleados = new UsuariosImplDAL();
            //metodo pr retornar list resumns de adccns
            this.cboEmpleado.DataSource = Empleados.retornaListaEmpleados(null);
            ///el cbo invoca el origen de datos de Adiccions pr retornarlo a la lista desplegada
        }
        #endregion

        #region Mètodo CargarActivos
        void CargarActivos()
        {
            // Objeto de la instancia del Mètodo
            ActivosImplDAL Activo = new ActivosImplDAL();
            //metodo pr retornar list resumns de adccns
            this.cboActivo.DataSource = Activo.retornaListaActivosResumen(null);
            ///el cbo invoca el origen de datos de Adiccions pr retornarlo a la lista desplegada
        }
        #endregion
        /// Duda cn este sp - Revisar
        #region Mètodo  CargarDatos
        /// <summary>
        /// Método para cargar datos actuales y IdUsuario
        /// </summary>
        void CargarDatos()
        {
            /*   UsuariosDALImpl Usuario = new UsuariosDALImpl();
               ActivosDALImpl Activo = new ActivosDALImpl();*/

            // Objeto de la instancia del Mètodo
            AsignacionesImplDAL Asignacion = new AsignacionesImplDAL();
            //Metod pr retornar activo x empleado x id
            spAsignUsuarioRetornaDatosId_Result resultadoSP = Asignacion.retornaAsignUsuarioId(this.IdAsignacion);
            if (resultadoSP != null)
            {
                this.cboActivo.SelectedValue = resultadoSP.Activo;
                this.cboEmpleado.SelectedValue = resultadoSP.Usuario;
                this.dtpFechInicialAsig.Value = DateTime.Parse(resultadoSP.FechaInicialAsig);
            }
            else
            {
                MessageBox.Show("El registro seleccionado no existe.",
                    "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.btnAceptar.Enabled = false;
            }
        }
        #endregion

        #region Mètodo ModificarDatos
        void ModificarDatos()
        {
            if (ValidarIngresoDatos())
            {
                try
                {

                    // Objeto de la instancia del Mètodo
                    AsignacionesImplDAL Asignacion = new AsignacionesImplDAL();

                    int IdUsuario = 0, IdActivo = 0;

                    IdUsuario = Convert.ToInt16(this.cboEmpleado.SelectedValue);
                    IdActivo = Convert.ToInt16(this.cboActivo.SelectedValue);


                    //metodo pr modificar adiccn x client existnt
                    Asignacion.ModificaAsignUsuario(this.IdAsignacion, IdUsuario, IdActivo, this.dtpFechInicialAsig.Value, DateTime.MaxValue);
                    string detalleBitacora = "Se modificó la asignación del activo: " + codigo.Trim() + " al empleado: " + nombreEmpleado.Trim();
                    bitacora.IdUsuario = ValoresAplicacion.idUsuario;
                    bitacora.DetalleBitacora = detalleBitacora;
                    bitacoraDAL.Add(bitacora);
                    MessageBox.Show("Registro modificado correctamente.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("No fue posible modificar el registro. \nEs posible que esté agregando datos duplicados",
                       "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Mètodo  ValidarIngresoDatos
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

            string codigoActivo = retornarFragmento(cboActivo.Text)[0];
            string descripcionActivo = retornarFragmento(cboActivo.Text)[1];
            int contadorAsignacion = 0;
            foreach (spAsignUsuarioRetornaLista_Result asignacion in asignacionDal.retornaListaAsignUsuario("", descripcionActivo.Trim()))
            {
                if (asignacion.Usuario.Trim().Equals(nombreEmpleado.Trim()) && asignacion.Codigo.Trim().Equals(codigoActivo.Trim()))
                {
                    MessageBox.Show("Esa asignación ya existe.");
                    return true;
                }
                if (asignacion.Codigo.Trim().Equals(codigoActivo.Trim()))
                {
                    contadorAsignacion++;
                }
            }
            if (contadorAsignacion >= 1)
            {
                MessageBox.Show("Alerta: Ese activo ya tiene una asignación.", "Alerta");
                return true;
            }
            return false;
        }

        private string[] retornarFragmento(string concatenacion)
        {
            string[] tokens = concatenacion.Split('-');
            return tokens;
        }
    }
}

