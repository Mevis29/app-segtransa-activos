using Backend.DAL;
using Backend.Entities;
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
    public partial class FormAsignacionesLista : Form
    {
    
         private IBitacoraDAL bitacoraDAL = new BitacoraImplDAL();
         private Bitacora bitacora = new Bitacora();

        int IdAsignacion { set; get; }
       
        public FormAsignacionesLista()
        {
            InitializeComponent();
            this.IdAsignacion = IdAsignacion;

        }
        #region evento mnuCerrar
        //salir del form
        private void mnuCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        #region cargar formAsignacionesLista
        private void FormAsignacionesLista_Load(object sender, EventArgs e)
        {
            //          this.tHAsignacionesTableAdapterBindingSource.Fill(this.SegtransaDataSetTableAdapters.THAsignaciones);
            this.CargarDatos();
            this.EstablerAccesoRolUsuario();

        }
        #endregion

        #region solo el Admin puede dar mantenimiento a Asignaciones de Activos y el empleado puede ver sus asignaciones
        void EstablerAccesoRolUsuario()
        {
            if (ValoresAplicacion.rolUsuario == "Empleado")
            {
                this.dgvLista.Size = new Size(1240, 120);
                this.dgvLista.Location = new Point(10, 50);
                this.mnuAgregar.Visible = false;
                this.mnuModificar.Visible = false;
                this.btnEliminar.Visible = false;
                this.CargarDatos();
            }
            else
            {
                this.CargarDatos();
            }
        }
        #endregion


        #region botòn Buscar
        //invoca mètodo CD
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.CargarDatos();
        }
        #endregion

        #region Mètodo CargarDatos
        /// <summary>
        /// Carga los datos del Stored Procedure en el DGV
        /// </summary>
        void CargarDatos()
        {
            try
            {
                /// Objeto de la instancia del Mètodo
                AsignacionesImplDAL datos = new AsignacionesImplDAL();
                //Mètodo pr retornar list completa de asignacions x Usuario
                this.dgvLista.DataSource = datos.retornaListaAsignUsuario(this.txtEmpleado.Text, this.txtActivo.Text);


            }

            catch (Exception ex)
            {
                // MessageBox.Show("Hubo un error");
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region Mètodo RetornarIdSeleccionado
        /// <summary>
        /// Retorna el valor del Id seleccionado en el DGV
        /// </summary>
        int RetornarIdSeleccionado()
        {
            int resultado = -1;

            try
            {
                //selecciona los datos de la fila cn color pr ser tratados
                //int filaSeleccionada = this.dgvLista.CurrentCell.RowIndex;
                resultado = Convert.ToInt16(dgvLista.Rows[dgvLista.SelectedRows[0].Index].Cells[0].Value.ToString());

            }
            catch (Exception)
            {
                throw;
                /* MessageBox.Show("Debe seleccionar una fila válida",
                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
            }

            return resultado;
        }
        #endregion

        #region evento mnuAgregar
        private void mnuAgregar_Click(object sender, EventArgs e)
        {
            ///al agregar, cargar y muestra los datos en el dgv
            FormAsignacionesInserta formInsertarAsignacion = new FormAsignacionesInserta();
            formInsertarAsignacion.ShowDialog();
            this.CargarDatos();
        }
        #endregion

        #region evento mnuModificar
        private void mnuModificar_Click(object sender, EventArgs e)
        {
            int valorSeleccionado = this.RetornarIdSeleccionado(); //retorna el valor del id seleccdo en el dgv

            if (valorSeleccionado > -1)
            {
                //mostrar el formulario enviando como valor lo seleccionado en el DGV
                FormAsignacionesModifica formModificarAsignacion = new FormAsignacionesModifica(valorSeleccionado);
                formModificarAsignacion.ShowDialog();
                this.CargarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila válida",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion



        ///     ELIMINAR ASIGNACION

        #region Boton Eliminar dato seleccionado

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            {
                int valorSeleccionado = RetornarIdSeleccionado(); //retorna el valor del id seleccdo en el dgv

                if (valorSeleccionado > -1)
                //    if (valorSeleccionado > this.IdAsignacion)
                {
                    this.EliminarDatos(valorSeleccionado);
                    this.CargarDatos();                 
                    //   this.IdAsignacion = IdAsignacion;
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila válida",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion



        ///METODO PR CARGAR Y ELIMINAR DATOS DESDE EL FORM ELIMINAR DATOS




        #region

        void EliminarDatos(int valorSeleccionado)
        {

            try
            {
                //objeto de la instancia del mètodo
                AsignacionesImplDAL Asignacion = new AsignacionesImplDAL();

                ///variable de la instancia q llama al Método para eliminar Asigncn existente
                Asignacion.EliminaAsignUsuario(valorSeleccionado);

                MessageBox.Show("Registro eliminado correctamente.",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // dgvLista.Rows.RemoveAt(IdAsignacion);
                this.btnEliminar.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("No fue posible eliminar el registro. \nEs posible que el registro se encuentre en uso.",
                    "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnEliminar.Enabled = false;
            }
        }
    }
}
#endregion


