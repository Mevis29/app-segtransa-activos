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
    public partial class frmRptDepreciados : Form
    {
        public frmRptDepreciados()
        {
            InitializeComponent();
        }

        private void frmRptDepreciados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'depreciadosDS.sp_RetornaDepreciados' Puede moverla o quitarla según sea necesario.
            this.sp_RetornaDepreciadosTableAdapter.Fill(this.depreciadosDS.sp_RetornaDepreciados);
            this.rpvDepreciados.RefreshReport();

        }
    }
}
