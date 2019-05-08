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
    public partial class FrmUsuarios_n : Form
    {
        private IUsuariosDAL usuarioDAL = new UsuariosImplDAL();
        private IBitacoraDAL bitacoraDAL = new BitacoraImplDAL();
        private Bitacora bitacora = new Bitacora();
        int idUsuario;
        public FrmUsuarios_n()
        {
            InitializeComponent();
        }

        private void cargarUsuarios() {
            try
            {
                
                this.usuariosBindingSource.DataSource = null;
                this.usuariosBindingSource.DataSource = usuarioDAL.GetUsuarios();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sEGTRANSADataSource_USUARIOS.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.sEGTRANSADataSource_USUARIOS.Usuarios);
            cargarUsuarios();
        }

        // Codigo para llamar al form de Agregar
        private void btnUsuarioAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmUsuariosAgregar_n form = new FrmUsuariosAgregar_n())
                {
                    form.ShowDialog(this);
                    cargarUsuarios();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
            }
        }


       

        // Codigo para llamar al form de Modificar
        private void btnUsuarioModificar_Click(object sender, EventArgs e)
        {          
            Usuarios usuario = (Usuarios)tblDatosUsuarios.CurrentRow.DataBoundItem;

            try
            {
                              
                using (FrmUsuariosModificar_n form = new FrmUsuariosModificar_n(usuario.IdUsuario))
                {
                   MessageBox.Show(usuario.Nombre);
                    form.ShowDialog(this);
                    cargarUsuarios();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
            }
        }

        // Codigo para llamar al form de Eliminar
        private void btnUsuarioEliminar_Click(object sender, EventArgs e)
        {


            try
            {
                //Usuarios usuario = (Usuarios)lstUsuarios.SelectedItem;
                Usuarios usuario = (Usuarios)tblDatosUsuarios.CurrentRow.DataBoundItem;

                DialogResult dialogResult = MessageBox.Show("Seguro que desea eliminar al usuario " + usuario.Nombre + "?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    usuarioDAL.Delete(usuario.IdUsuario);
                    string detalleBitacora = "Se eliminó el usuario: " +usuario.Nombre+" "+usuario.Apellido;
                    bitacora.DetalleBitacora = detalleBitacora;
                    bitacora.IdUsuario = ValoresAplicacion.idUsuario;
                    bitacoraDAL.Add(bitacora);
                    MessageBox.Show("Usuario Eliminado");

                    //usuarios.Clear();
                    //lstUsuarios.DataSource = null;

                    cargarUsuarios();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Operacion Cancelada");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: Este usuario tiene un activo asignado. Si desea eliminarlo, primero elimine sus asignaciones" );
            }



        }

        private void txtBusquedaU_TextChanged(object sender, EventArgs e)
        {

            if (txtBusquedaU.Text != "")
            {
                tblDatosUsuarios.CurrentCell = null;
                foreach (DataGridViewRow r in tblDatosUsuarios.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in tblDatosUsuarios.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString()).ToUpper().IndexOf(txtBusquedaU.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }

                        tblDatosUsuarios.Rows[0].Selected = true;

                    }

                }

            }
            else
            {
                cargarUsuarios();
            }
        }
    }
}

