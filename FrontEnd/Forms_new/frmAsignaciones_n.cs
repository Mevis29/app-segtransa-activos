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
    public partial class FrmAsignaciones_n : Form
    {
        private IAsignacionesDAL asignacionesDAL = new AsignacionesImplDAL();
        private IBitacoraDAL bitacoraDAL = new BitacoraImplDAL();
        private Bitacora bitacora = new Bitacora();
        public FrmAsignaciones_n()
        {
            InitializeComponent();
        }

    

        private void frmAsignaciones_n_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sEGTRANSADataSource_ASIGNACIONES.THAsignaciones' table. You can move, or remove it, as needed.
           this.tHAsignacionesTableAdapter.Fill(this.sEGTRANSADataSource_ASIGNACIONES.THAsignaciones);

            // TODO: This line of code loads data into the 'sEGTRANSADataSource_spListaTotalAsignaciones.spAsignUsuarioRetornaListaTotal' table. You can move, or remove it, as needed.
            //this.spAsignUsuarioRetornaListaTotalTableAdapter.Fill(this.sEGTRANSADataSource_spListaTotalAsignaciones.spAsignUsuarioRetornaListaTotal);
                        cargarAsignaciones();
        }


        private void cargarAsignaciones()
        {
            try
            {
                this.sEGTRANSADataSourceASIGNACIONESBindingSource.DataSource = null;
                this.sEGTRANSADataSourceASIGNACIONESBindingSource.DataSource = sEGTRANSADataSource_ASIGNACIONES.THAsignaciones;
                
              // this.spAsignUsuarioRetornaListaTotalBindingSource.DataSource = null;
                
               // this.spAsignUsuarioRetornaListaTotalBindingSource.DataSource = sEGTRANSADataSource_spListaTotalAsignaciones.spAsignUsuarioRetornaListaTotal;
                
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
            }
        }


        // Codigo para llamar al form de Agregar
        private void btnAsignAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmAsignacionesAgregar_n form = new FrmAsignacionesAgregar_n())
                {
                    form.ShowDialog(this);
                    cargarAsignaciones();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
            }
        }


       

        // Codigo para llamar al form de Modificar
        private void btnAsignModificar_Click(object sender, EventArgs e)
        {

            THAsignaciones asignaciones = (THAsignaciones)tblDatosAsignaciones.CurrentRow.DataBoundItem;

            try
            {
                              
                using (FrmActivosModificar_n form = new FrmActivosModificar_n(asignaciones.IdAsignacion))
                {
                   MessageBox.Show(asignaciones.IdAsignacion.ToString());
                    form.ShowDialog(this);
                    cargarAsignaciones();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
            }
        }

        // Codigo para llamar al form de Eliminar
        private void btnAsignEliminar_Click(object sender, EventArgs e)
        {
        
            try
            {
                THAsignaciones asignacionSelected = (THAsignaciones)tblDatosAsignaciones.CurrentRow.DataBoundItem;

                //int id = asignacionSelected.IdAsignacion;

               // THAsignaciones tH = asignacionesDAL.GetAsignacion(id);

                

                //MessageBox.Show(id.ToString());

                //asignacionesDAL.GetAsignacion(id);

                DialogResult dialogResult = MessageBox.Show("Seguro que desea remover la asignacion?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    asignacionesDAL.Delete(asignacionSelected.IdAsignacion);
                   
                    MessageBox.Show("Asignacion Eliminada");

                    //usuarios.Clear();
                    //lstUsuarios.DataSource = null;

                    cargarAsignaciones();
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
                tblDatosAsignaciones.CurrentCell = null;
                foreach (DataGridViewRow r in tblDatosAsignaciones.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in tblDatosAsignaciones.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString()).ToUpper().IndexOf(txtBusqueda.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                        //r.Selected = true;
                        tblDatosAsignaciones.Rows[0].Selected = true;

                    }

                }

            }
            else
            {
                cargarAsignaciones();
            }
        }
    }
}

