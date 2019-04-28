using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd.Forms_new
{
    public partial class frmRespaldos : Form
    {
        public frmRespaldos()
        {
            InitializeComponent();
        }

        private void btnRespaldarDatos_Click(object sender, EventArgs e)
        {
            if (txtDirectorio.Text=="")
            {
                MessageBox.Show("Por favor seleccione una ruta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               respaldarDatos();
            }
        }

        private void btnExplorar_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()== DialogResult.OK)
            {
                txtDirectorio.Text = folderBrowserDialog1.SelectedPath.ToString();
            }
        }

        private void respaldarDatos()
        {
            string bdNombreArchivo = "Segtransa.bak";
            string directorioActualBd = Path.Combine(Environment.CurrentDirectory, bdNombreArchivo);
            string backTimeStamp = Path.GetFileNameWithoutExtension(bdNombreArchivo);
            string nombreArchivoDestino = DateTime.Now.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture)+ bdNombreArchivo;
            string rutaRespaldo = txtDirectorio.Text;
            nombreArchivoDestino = Path.Combine(rutaRespaldo, nombreArchivoDestino);
            File.Copy(directorioActualBd, nombreArchivoDestino, true);
            MessageBox.Show("Respaldo exitoso");

        }
    }
}
