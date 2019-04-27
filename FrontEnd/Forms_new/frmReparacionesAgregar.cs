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

namespace FrontEnd.Forms_new
{
    public partial class frmReparacionesAgregar : Form
    {
        private IReparacionesDAL reparacionesDAL = new ReparacionesDALImpl();
        THReparaciones reparacion = new THReparaciones();
        private IActivosDAL activosDAL = new ActivosImplDAL();
        private IBitacoraDAL bitacoraDAL = new BitacoraImplDAL();
        private Bitacora bitacora = new Bitacora();
        private string idActivSelec;

        public frmReparacionesAgregar()
        {
            InitializeComponent();
        }

        #region eventos
        private void FrmReparacionesAgregar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'activosDataSet.Activos' Puede moverla o quitarla según sea necesario.
            this.activosTableAdapter1.Fill(this.activosDataSet.Activos);
            this.CenterToScreen();
        }
        #endregion

        #region funciones externas

        private void cargarActivos()
        {
            this.tablaActivos.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
            this.tablaActivos.DataSource = null;
            this.tablaActivos.DataSource = activosDAL.obtenerActivos();
        }

        private bool validaActivoEnReparacion()
        {
            bool existeId = false;
            List<sp_RetornaReparacion_Result> reparaciones = reparacionesDAL.ObtenerReparaciones("");
            foreach (sp_RetornaReparacion_Result reparacion in reparaciones)
            {
                if (reparacion.IdActivo == Convert.ToInt32(idActivSelec))
                {
                    existeId = true;
                }
            }
            return existeId;
        }



        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dpFechaInicial.Value >= dpFechaFinal.Value)
                {
                    MessageBox.Show("Seleccione una fecha inicial menor a la fecha final.", "Error");
                }
                else if (idActivSelec == null)
                {
                    MessageBox.Show("Debe seleccionar un activo a reparar de la lista", "Error");
                }
                else if (validaActivoEnReparacion() == true) //Valida si el activo ya está siendo reparado.
                {
                    MessageBox.Show("Ese activo ya está en reparación.", "Error");
                }
                else
                {
                    THReparaciones reparacion = new THReparaciones();
                    reparacion.FechaInicialReparacion = dpFechaInicial.Value;
                    reparacion.FechafinalReparacion = dpFechaFinal.Value;

                    reparacionesDAL.AgregarReparacion(reparacion, Convert.ToInt32(idActivSelec));
                    string codigo = tablaActivos.Rows[tablaActivos.SelectedRows[0].Index].Cells[1].Value.ToString();
                    int id = Convert.ToInt16(tablaActivos.Rows[tablaActivos.SelectedRows[0].Index].Cells[0].Value.ToString());
                    string detalleBitacora = "Se agregó la reparación del activo: " + codigo.Trim() + id;
                    bitacora.IdUsuario = ValoresAplicacion.idUsuario;
                    bitacora.DetalleBitacora = detalleBitacora;
                    bitacoraDAL.Add(bitacora);
                    MessageBox.Show("Reparación agregada", "Confirmación");
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error \n Inténtelo nuevamente", "Error");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtBusqueda.Text != "")
            {
                tablaActivos.CurrentCell = null;
                bool seleccion = false;
                foreach (DataGridViewRow r in tablaActivos.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in tablaActivos.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString()).ToUpper().IndexOf(txtBusqueda.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            if (seleccion == false)
                            {
                                r.Selected = true;
                                seleccion = true;
                            }
                            break;
                        }
                    }
                }
            }
            else
            {
                cargarActivos();
            }
        }

        private void tablaActivos_SelectionChanged(object sender, EventArgs e)
        {
            if (tablaActivos.SelectedRows.Count != 0)
            {
                idActivSelec = tablaActivos.Rows[tablaActivos.SelectedRows[0].Index].Cells[0].Value.ToString();
            }
            else
            {
                idActivSelec = null;
            }
        }
    }
}
