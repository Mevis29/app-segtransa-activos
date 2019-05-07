﻿using Backend.DAL;
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
    public partial class FormAsignacionesModifica : Form
    {
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

            this.dtpFechInicialAsig.Value = new DateTime(2019, 01, 01);
            this.dtpFechfinalAsig.Value = new DateTime(2019, 01, 01);
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
                this.cboEmpleado.SelectedValue = "";
                this.cboActivo.SelectedValue = "";
            }
            // this.dtpFechInicialAsg.Value = new DateTime(1980, 01, 01);
            // this.dtpFechFinAsgn.Value = new DateTime(1980, 01, 01);
        }
        #endregion

        #region Mètodo  CargarEmpleados
        void CargarEmpleados()
        {
            // Objeto de la instancia del Mètodo  pr q no se devuelvan vacios 
            UsuariosImplDAL Empleados = new UsuariosImplDAL();
            //Mètodo pr retornr lista de solo Empleados
            this.cboEmpleado.DataSource = Empleados.retornaListaEmpleados(null);
            ///el cbo invoca el origen de datos de Empleado pr retornarlo a la lista desplegada
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
                //obtiene la selcciòn del dato pr ser tratado
                this.cboEmpleado.SelectedValue = resultadoSP.Usuario;
                this.cboActivo.SelectedValue = resultadoSP.Activo;
                this.dtpFechInicialAsig.Value = DateTime.Parse(resultadoSP.FechaInicialAsig);
                this.dtpFechfinalAsig.Value = DateTime.Parse(resultadoSP.FechafinAsig);
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
                    Asignacion.ModificaAsignUsuario(this.IdAsignacion, IdUsuario, IdActivo, this.dtpFechInicialAsig.Value, this.dtpFechfinalAsig.Value);

                    MessageBox.Show("Registro modificado correctamente.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (asignacionDal.retornaListaAsignUsuario("", retornarFragmento(cboActivo.Text)).Count>1)
            {
                MessageBox.Show("Alerta: Ese activo ya tiene una asignación.");
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

