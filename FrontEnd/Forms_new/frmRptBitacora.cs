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
    public partial class frmRptBitacora : Form
    {
        public frmRptBitacora()
        {
            InitializeComponent();
        }

        private void frmRptBitacora_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sEGTRANSADataSetSp_RetornaBitacora.sp_RetornaBitacora' Puede moverla o quitarla según sea necesario.
            this.sp_RetornaBitacoraTableAdapter.Fill(this.sEGTRANSADataSetSp_RetornaBitacora.sp_RetornaBitacora);
            this.rpvBitacora.RefreshReport();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
