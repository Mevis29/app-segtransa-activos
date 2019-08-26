using Backend.DAL;
using Backend.Entities;
using BackEnd.DAL;
using FronEnd;
using FrontEnd.Clases;
using FrontEnd.Forms_new;
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
    public partial class FrmMisActivos_n : Form
    {
        IAsignacionesDAL asignacionesDAL = new AsignacionesImplDAL();
        IActivosDAL activosDAL = new ActivosImplDAL();
        int id;

        public FrmMisActivos_n()
        {
            InitializeComponent();
        }

        public FrmMisActivos_n(int idUsuario)
        {
            InitializeComponent();
            id = idUsuario;
            
        }

        private void FrmMisActivos_n_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sEGTRANSADataSource_ACTIVOS.Activos' table. You can move, or remove it, as needed.
            this.spAsignUsuarioRetornaListaIdTableAdapter.Fill(this.sEGTRANSADataSource_spActivosPorIdUsuario.spAsignUsuarioRetornaListaId, id);

            DataGridViewColumn columnFechaInicio = tblMisActivos.Columns[3];
            columnFechaInicio.Width = 150;
            DataGridViewColumn columnFechaFin = tblMisActivos.Columns[4];
            columnFechaFin.Width = 160;
            cargarMisActivos();

            if (ValoresAplicacion.rolUsuario.Equals("Administrador"))
            {
                btnSolicitarRep.Visible = true;
            }

        }

        private void cargarMisActivos()
        {
            try
            {
                IAsignacionesDAL asignacionesDAL = new AsignacionesImplDAL();

                this.spAsignUsuarioRetornaListaIdBindingSource.DataSource = null;
                this.spAsignUsuarioRetornaListaIdBindingSource.DataSource = asignacionesDAL.retornaListaAsignUsuarioId(id);
                //this.tblMisActivos.DataSource = asignacionesDAL.retornaListaAsignUsuarioId(this.id);
            }
            catch (Exception)
            {
              MessageBox.Show("Hubo un error");
            }
        }

        private void btnSolicitarRep_Click(object sender, EventArgs e)
        {
            frmReparacionesAgregar formReparacionesInsertar = new frmReparacionesAgregar();
            formReparacionesInsertar.Show();
           
        }
    }
}

