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
    public partial class FrmActivos_n : Form
    {
        private IActivosDAL activoDAL = new ActivosImplDAL();
        int idActivo;
        public FrmActivos_n()
        {
            InitializeComponent();
        }

        private void cargarActivos() {
            try
            {
                
                this.activosBindingSource.DataSource = null;
                this.activosBindingSource.DataSource = activoDAL.GetActivos();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
            }
        }

        private void frmActivos_n_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sEGTRANSADataSource_ACTIVOS.Activos' table. You can move, or remove it, as needed.
            this.activosTableAdapter.Fill(this.sEGTRANSADataSource_ACTIVOS.Activos);
            cargarActivos();
        }

        // Codigo para llamar al form de Agregar
        private void btnActivoAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmActivosAgregar_n form = new FrmActivosAgregar_n())
                {
                    form.ShowDialog(this);
                    cargarActivos();
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
            Activos activo = (Activos)tblDatosActivos.CurrentRow.DataBoundItem;

            try
            {
                              
                using (FrmActivosModificar_n form = new FrmActivosModificar_n(activo.IdActivo))
                {
                   MessageBox.Show(activo.IdActivo.ToString());
                    form.ShowDialog(this);
                    cargarActivos();
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

                Activos activo = (Activos)tblDatosActivos.CurrentRow.DataBoundItem;

                DialogResult dialogResult = MessageBox.Show("Seguro que desea eliminar el activo " + activo.IdActivo.ToString() + "?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    activoDAL.eliminarActivo(activo.IdActivo);
                    MessageBox.Show("Activo Eliminado");

                    //usuarios.Clear();
                    //lstUsuarios.DataSource = null;

                    cargarActivos();
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
                tblDatosActivos.CurrentCell = null;
                foreach (DataGridViewRow r in tblDatosActivos.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in tblDatosActivos.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString()).ToUpper().IndexOf(txtBusqueda.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                        //r.Selected = true;
                        tblDatosActivos.Rows[0].Selected = true;

                    }

                }

            }
            else
            {
                cargarActivos();
            }
        }
    }
}

