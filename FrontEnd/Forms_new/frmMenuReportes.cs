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
    public partial class frmMenuReportes : Form
    {
        public frmMenuReportes()
        {
            InitializeComponent();
        }

        private void abrirFormInPanel(object FormHijo)
        {
            try
            {
                if (this.contentPnl.Controls.Count > 0)
                {
                    this.contentPnl.Controls.RemoveAt(0);
                    Form fh = FormHijo as Form;
                    fh.TopLevel = false;
                    fh.Dock = DockStyle.Fill;
                    this.contentPnl.Controls.Add(fh);
                    this.contentPnl.Tag = fh;
                    fh.Show();
                }
                else
                {
                    Form fh = FormHijo as Form;
                    fh.TopLevel = false;
                    fh.Dock = DockStyle.Fill;
                    this.contentPnl.Controls.Add(fh);
                    this.contentPnl.Tag = fh;
                    fh.Show();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Un error");
            }
        }

        private void opcionRptBitacora_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new frmRptBitacora());
        }

        private void optionRptReparaciones_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new frmRptReparaciones());
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
