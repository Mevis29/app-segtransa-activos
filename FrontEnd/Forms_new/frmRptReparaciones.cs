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
    public partial class frmRptReparaciones : Form
    {
        public frmRptReparaciones()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRptReparaciones_Load(object sender, EventArgs e)
        {
            this.sp_RetornaReparacionTableAdapter.Fill(this.sp_RetornaReparacionesDS.sp_RetornaReparacion, "");
            this.rpvReparaciones.RefreshReport();
        }
    }
}
