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
    public partial class frmRptAsignaciones : Form
    {
        public frmRptAsignaciones()
        {
            InitializeComponent();
        }

        private void frmRptAsignaciones_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sEGTRANSADataSource_spListaTotalAsignaciones.spAsignUsuarioRetornaListaTotal' table. You can move, or remove it, as needed.
            this.spAsignUsuarioRetornaListaTableAdapter.Fill(this.segtransaDataSet.spAsignUsuarioRetornaLista, null, null);

            this.reportViewer1.RefreshReport();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
