using Backend.DAL;
using Backend.Entities;
using FronEnd;
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

namespace Frontend
{
    public partial class FrmProveedores_n : Form
    {
        private IProveedoresDAL proveedorDAL = new ProveedoresImplDAL();
        private IBitacoraDAL bitacoraDAL = new BitacoraImplDAL();
        private Bitacora bitacora = new Bitacora();
        int idProveedor;
        public FrmProveedores_n()
        {
            InitializeComponent();
        }

        private void cargarProveedores() {
            try
            {
                
                this.proveedoresBindingSource.DataSource = null;
                this.proveedoresBindingSource.DataSource = proveedorDAL.GetProveedores();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
            }
        }

        private void frmProveedores_n_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sEGTRANSADataSource_PROVEEDORES.Proveedores' table. You can move, or remove it, as needed.
            this.proveedoresTableAdapter.Fill(this.sEGTRANSADataSource_PROVEEDORES.Proveedores);
           
            cargarProveedores();
        }

        // Codigo para llamar al form de Agregar
        private void btnProveedorAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmProveedoresAgregar_n form = new FrmProveedoresAgregar_n())
                {
                    form.ShowDialog(this);
                    cargarProveedores();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
            }
        }


       

        // Codigo para llamar al form de Modificar
        private void btnProveedorModificar_Click(object sender, EventArgs e)
        {          
            Proveedores proveedor = (Proveedores)tblDatosProveedores.CurrentRow.DataBoundItem;

            try
            {
                              
                using (FrmProveedoresModificar_n form = new FrmProveedoresModificar_n(proveedor.IdProveedor))
                {
                   MessageBox.Show(proveedor.IdProveedor.ToString());
                    form.ShowDialog(this);
                    cargarProveedores();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
            }
        }

        // Codigo para llamar al form de Eliminar
        private void btnProveedorEliminar_Click(object sender, EventArgs e)
        {
        
            try
            {

                Proveedores proveedor = (Proveedores)tblDatosProveedores.CurrentRow.DataBoundItem;

                DialogResult dialogResult = MessageBox.Show("Seguro que desea eliminar el proveedor " + proveedor.IdProveedor.ToString() + "?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    proveedorDAL.Delete(proveedor.IdProveedor);
                    string detalleBitacora = "Se eliminó el proveedor: " + proveedor.NombreProveedor;
                    bitacora.DetalleBitacora = detalleBitacora;
                    bitacora.IdUsuario = ValoresAplicacion.idUsuario;
                    bitacoraDAL.Add(bitacora);
                    MessageBox.Show("Proveedor Eliminado");

                    //usuarios.Clear();
                    //lstUsuarios.DataSource = null;

                    cargarProveedores();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Operacion Cancelada");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: ese proveedor está ligado a un activo." );
            }



        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtBusqueda.Text != "")
            {
                tblDatosProveedores.CurrentCell = null;
                foreach (DataGridViewRow r in tblDatosProveedores.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in tblDatosProveedores.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString()).ToUpper().IndexOf(txtBusqueda.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                        //r.Selected = true;
                        tblDatosProveedores.Rows[0].Selected = true;

                    }

                }

            }
            else
            {
                cargarProveedores();
            }
        }
    }
}

