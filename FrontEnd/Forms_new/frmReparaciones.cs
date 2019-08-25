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

namespace FrontEnd.Forms_new
{
    public partial class frmReparaciones : Form
    {
        private IReparacionesDAL reparacionesDAL = new ReparacionesDALImpl();
        private IBitacoraDAL bitacoraDAL = new BitacoraImplDAL();
        private Bitacora bitacora = new Bitacora();
        string idReparacion;

        public frmReparaciones()
        {
            InitializeComponent();
           // tablaReparaciones.Columns[0].Width = 80;
           // tablaReparaciones.Columns[1].Width = 100;
        }
        #region funcionesExternas
        private void cargarReparaciones()
        {
            this.tablaReparaciones.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
            this.tablaReparaciones.Columns[6].DefaultCellStyle.Format = "MM/dd/yyyy";
            this.tablaReparaciones.DataSource = null;
            this.tablaReparaciones.DataSource = reparacionesDAL.ObtenerReparaciones(txtBusqueda.Text);
            this.senalarReparacionesTerminadas();
        }

        void EstablerAccesoRolUsuario()
        {
            if (ValoresAplicacion.rolUsuario == "Empleado")
            {
                //this.tablaReparaciones.Size = new Size(1240, 120);
                //this.tablaReparaciones.Location = new Point(10, 50);
                btnReparacionAgregar.Visible = false;
                btnReparacionModificar.Visible = false;
                btnReparacionEliminar.Visible = false;
                this.cargarReparaciones();
            }
            else
            {
                this.cargarReparaciones();
            }
        }

        private void recargar(object sender, FormClosingEventArgs e)
        {
            cargarReparaciones();
        }

        private void senalarReparacionesTerminadas()
        {
            List<sp_RetornaReparacion_Result> reparaciones = reparacionesDAL.ObtenerReparaciones("");
            foreach (sp_RetornaReparacion_Result reparacion in reparaciones)
            {
                if (reparacion.FechafinalReparacion <= DateTime.Now) //Si la fecha de una reparación ya pasó...
                {
                    foreach (DataGridViewRow r in tablaReparaciones.Rows)//Recorre el grid...
                    {
                        foreach (DataGridViewCell c in r.Cells)
                        {
                            if ((c.Value.ToString().Equals(reparacion.FechafinalReparacion.ToString()))) //Si el valor de la fecha es encontrado...
                            {
                                c.Style.ForeColor = Color.Red;
                                c.Style.SelectionForeColor = Color.Red; //La pinta de rojo...
                            }
                        }
                    }
                }
            }
        }

        

        #endregion

        #region eventos
        private void frmReparaciones_Load(object sender, EventArgs e)
        {
            this.EstablerAccesoRolUsuario();
            tablaReparaciones.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }


        #endregion

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtBusqueda.Text != "")
            {
                tablaReparaciones.CurrentCell = null;
                bool seleccion = false;
                foreach (DataGridViewRow r in tablaReparaciones.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in tablaReparaciones.Rows)
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
                cargarReparaciones();
            }
        }

        private void agregarReparacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tablaReparaciones_SelectionChanged(object sender, EventArgs e)
        {
            if (tablaReparaciones.SelectedRows.Count != 0)
            {
                idReparacion = tablaReparaciones.Rows[tablaReparaciones.SelectedRows[0].Index].Cells[0].Value.ToString();
            }
            else
            {
                idReparacion = null;
            }
        }

        private void eliminarReparacionSeleccionadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUsuarioAgregar_Click(object sender, EventArgs e)
        {
            frmReparacionesAgregar formReparacionesInsertar = new frmReparacionesAgregar();
            formReparacionesInsertar.FormClosing += new FormClosingEventHandler(this.recargar);
            formReparacionesInsertar.ShowDialog();
        }

        private void btnUsuarioModificar_Click(object sender, EventArgs e)
        {
            if (idReparacion == null)
            {
                MessageBox.Show("Debe seleccionar un activo a reparar de la lista", "Error");
            }
            else
            {
                string idActivo = tablaReparaciones.Rows[tablaReparaciones.SelectedRows[0].Index].Cells[1].Value.ToString();
                string codActivo = tablaReparaciones.Rows[tablaReparaciones.SelectedRows[0].Index].Cells[2].Value.ToString().Trim();
                string descripcion = tablaReparaciones.Rows[tablaReparaciones.SelectedRows[0].Index].Cells[3].Value.ToString();
                DateTime fechaInicial = Convert.ToDateTime(tablaReparaciones.Rows[tablaReparaciones.SelectedRows[0].Index].Cells[5].Value.ToString());
                DateTime fechaFinal = Convert.ToDateTime(tablaReparaciones.Rows[tablaReparaciones.SelectedRows[0].Index].Cells[6].Value.ToString());
                frmReparacionesModificar formModificar = new frmReparacionesModificar(idActivo, codActivo, descripcion, fechaInicial, fechaFinal, Convert.ToInt32(idReparacion));
                formModificar.FormClosing += new FormClosingEventHandler(this.recargar);
                formModificar.ShowDialog();
            }
        }

        private void btnUsuarioEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar la reparación seleccionada?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    reparacionesDAL.Eliminar(Convert.ToInt32(this.idReparacion));
                    //Se obtiene el código según el valos de la celda en la tabla
                    string codigo = tablaReparaciones.Rows[tablaReparaciones.SelectedRows[0].Index].Cells[2].Value.ToString();
                    int id = Convert.ToInt16(tablaReparaciones.Rows[tablaReparaciones.SelectedRows[0].Index].Cells[1].Value.ToString());
                    string detalleBitacora = "Se eliminó la reparación del activo: " + codigo.Trim() + id.ToString();
                    bitacora.IdUsuario = ValoresAplicacion.idUsuario;
                    bitacora.DetalleBitacora = detalleBitacora;
                    bitacoraDAL.Add(bitacora);
                    MessageBox.Show("Reparación eliminada", "Confirmacion");
                    cargarReparaciones();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede borrar el activo seleccionado", "Error");
            }
        }
    }
}
