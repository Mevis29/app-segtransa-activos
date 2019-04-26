using Backend.DAL;
using Backend.Entities;
using BackEnd.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FronEnd
{
    public partial class FrmAsignacionesModificar_n : Form
    {
        private IAsignacionesDAL asignacionesDAL = new AsignacionesImplDAL(); 
        
        private IUsuariosDAL usuariosDAL = new UsuariosImplDAL();
        private IActivosDAL activosDAL = new ActivosImplDAL();

        public FrmAsignacionesModificar_n()
        {
            InitializeComponent();
            CargaComboBox();
        }

        private void CargaComboBox()
        {
            //ComboBox de Empleados
            cmbBoxEmpleados.DisplayMember = "Nombre";
            cmbBoxEmpleados.ValueMember = "IdUsuario";
            List<Usuarios> usuarios = usuariosDAL.GetUsuarios();
            cmbBoxEmpleados.DataSource = usuarios; 

            //ComboBox de Activos
            cmbBoxActivos.DisplayMember = "Descripcion";
            cmbBoxActivos.ValueMember = "IdActivos";
            List<Activos> activos = activosDAL.GetActivos();
            cmbBoxActivos.DataSource = activos;
        }



        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregaAsignacion_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    THAsignaciones tHAsignaciones = new THAsignaciones();
                    Usuarios usuarios = new Usuarios();
                    Activos activo = new Activos();
                 

                        if ((Usuarios)cmbBoxEmpleados.SelectedItem != null && (Activos)cmbBoxActivos.SelectedItem != null)
                        {
                        usuarios = (Usuarios)cmbBoxEmpleados.SelectedItem;
                        activo = (Activos)cmbBoxActivos.SelectedItem;
                        tHAsignaciones.IdActivo = activo.IdActivo;
                        tHAsignaciones.IdUsuario = usuarios.IdUsuario;
                        tHAsignaciones.FechaInicialAsignacion = dateFechaInicio.Value;
                        tHAsignaciones.FechafinalAsignacion = dateFechaFin.Value;


                        asignacionesDAL.Add(tHAsignaciones);
                        MessageBox.Show("Asignacion agregada");
                        
                            this.Close();
                        }
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe completar toda la informacion");
                }

            }


        }


        private void cmbEmpleados_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
 

        private void cmbActivos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            // Let the default behavior to happen.
            base.OnClosing(e);
            // Do not allow cancellation of the close operation.
            e.Cancel = false;
            //frmUsuariosAgrega frmUsuarios = new frmUsuariosAgrega();

            //previousForm.Show();
        }

    }
}
