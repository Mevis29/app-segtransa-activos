using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FrontEnd.Forms_new
{
    public partial class frmRptActivo : Form
    {
        public frmRptActivo()
        {
            InitializeComponent();
        }

        private void frmRptActivo_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'sEGTRANSADataSetActivo.sp_obtenerActivos' table. You can move, or remove it, as needed.
            this.sp_obtenerActivosTableAdapter.Fill(this.sEGTRANSADataSetActivo.sp_obtenerActivos);
            // TODO: This line of code loads data into the 'sEGTRANSADataSource_ACTIVOS.Activos' table. You can move, or remove it, as needed.
            this.activosTableAdapter.Fill(this.sEGTRANSADataSource_ACTIVOS.Activos);

            this.reportViewer1.RefreshReport();
        }
    }
}
