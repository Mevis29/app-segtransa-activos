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
    public partial class frmReparacionesModificar : Form
    {
        private IReparacionesDAL reparacionesDAL = new ReparacionesDALImpl();
        THReparaciones reparacion = new THReparaciones();
        private IBitacoraDAL bitacoraDAL = new BitacoraImplDAL();
        private Bitacora bitacora = new Bitacora();
        int idActRepSelec;
        string idActivo;
        string codActivo;
        string descripcion;
        DateTime fechaInicial;
        DateTime fechaFinal;

        public frmReparacionesModificar()
        {
            InitializeComponent();
        }

        public frmReparacionesModificar(string idActivo, string codActivo, string descripcion, DateTime fechaInicial, DateTime fechaFinal, int id)
        {
            this.idActivo = idActivo;
            this.codActivo = codActivo;
            this.descripcion = descripcion;
            this.fechaInicial = fechaInicial;
            this.fechaFinal = fechaFinal;
            this.idActRepSelec = id;
            InitializeComponent();
        }

        #region eventos    

        private void frmReparacionesModificar_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.txtActivo.Text = codActivo;
            this.txtDescripcion.Text = descripcion;
            this.dpFechaInicial.Value = fechaInicial;
            this.dpFechaFinal.Value = fechaFinal;      
        }



        #endregion

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dpFechaInicial.Value >= dpFechaFinal.Value)
                {
                    MessageBox.Show("Seleccione una fecha inicial menor a la fecha final.", "Error");
                }
                else
                {
                    THReparaciones reparacion = new THReparaciones();
                    reparacion.FechaInicialReparacion = dpFechaInicial.Value;
                    reparacion.FechafinalReparacion = dpFechaFinal.Value;
                    reparacion.IdReparacion = idActRepSelec;
                    reparacionesDAL.ModificarReparacion(reparacion);
                    string detalleBitacora = "Se modificó la reparación del activo: " + codActivo;
                    bitacora.IdUsuario = ValoresAplicacion.idUsuario;
                    bitacora.DetalleBitacora = detalleBitacora;
                    bitacoraDAL.Add(bitacora);
                    MessageBox.Show("Reparación modificada", "Confirmación");
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
    }
}
