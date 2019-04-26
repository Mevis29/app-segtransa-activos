using Backend.DAL;
using Backend.Entities;
using BackEnd.DAL;
using FronEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class FrmReparaciones_n : Form
    {
        private IReparacionesDAL reparacionesDAL = new ReparacionesDALImpl();
        
        //int idActivo;
        public FrmReparaciones_n()
        {
            InitializeComponent();
        }

        private void cargarReparaciones() {
            try
            {
                
                this.tHReparacionesBindingSource.DataSource = null;
                this.tHReparacionesBindingSource.DataSource = reparacionesDAL.GetReparaciones();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
            }
        }

        private void frmActivos_n_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sEGTRANSADataSource_REPARACIONES.THReparaciones' table. You can move, or remove it, as needed.
            this.tHReparacionesTableAdapter.Fill(this.sEGTRANSADataSource_REPARACIONES.THReparaciones);
            // TODO: This line of code loads data into the 'sEGTRANSADataSource_ACTIVOS.Activos' table. You can move, or remove it, as needed.
           // this.activosTableAdapter.Fill(this.sEGTRANSADataSource_ACTIVOS.Activos);
            cargarReparaciones();
        }

        // Codigo para llamar al form de Agregar
        private void btnActivoAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmActivosAgregar_n form = new FrmActivosAgregar_n())
                {
                    form.ShowDialog(this);
                    cargarReparaciones();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
            }
        }


       

        // Codigo para llamar al form de Modificar
        private void btnActivoModificar_Click(object sender, EventArgs e)
        {          
            Activos activo = (Activos)tblReparaciones.CurrentRow.DataBoundItem;

            try
            {
                              
                using (FrmActivosModificar_n form = new FrmActivosModificar_n(activo.IdActivo))
                {
                   MessageBox.Show(activo.IdActivo.ToString());
                    form.ShowDialog(this);
                    cargarReparaciones();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
            }
        }

        // Codigo para llamar al form de Eliminar
        private void btnActivoEliminar_Click(object sender, EventArgs e)
        {
        
            try
            {

                THReparaciones reparaciones = (THReparaciones)tblReparaciones.CurrentRow.DataBoundItem;

                DialogResult dialogResult = MessageBox.Show("Seguro que desea eliminar la reparacion?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    reparacionesDAL.Eliminar(reparaciones.IdReparacion);
                    MessageBox.Show("Reparacion Eliminada");

                    //usuarios.Clear();
                    //lstUsuarios.DataSource = null;

                    cargarReparaciones();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Operacion Cancelada");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }



        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtBusqueda.Text != "")
            {
                tblReparaciones.CurrentCell = null;
                foreach (DataGridViewRow r in tblReparaciones.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in tblReparaciones.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString()).ToUpper().IndexOf(txtBusqueda.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                        //r.Selected = true;
                        tblReparaciones.Rows[0].Selected = true;

                    }

                }

            }
            else
            {
                cargarReparaciones();
            }
        }
    }
}

