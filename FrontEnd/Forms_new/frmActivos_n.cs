using Backend.DAL;
using Backend.Entities;
using BackEnd.DAL;
using FronEnd;
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

namespace Frontend
{
    public partial class FrmActivos_n : Form
    {
        private IActivosDAL activoDAL = new ActivosImplDAL();
        private IDepreciacionDAL depreciacionDAL = new DepreciacionDALImpl();
        private IBitacoraDAL bitacoraDAL = new BitacoraImplDAL();
        private Bitacora bitacora = new Bitacora();
        int idActivo;
        public FrmActivos_n()
        {
            InitializeComponent();
        }

        private void cargarActivos()
        {
            try
            {
                actualizarDepreciacion();
                this.activosBindingSource.DataSource = null;
                this.activosBindingSource.DataSource = activoDAL.GetActivos();
                senalarDepreciados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void actualizarDepreciacion()
        {
            if (depreciacionDAL.GetDepreciaciones() != null) //Si no hay depreciaciones, no hace el proceso.
            {
                bool depreciado = false;
                for (int i = 0; depreciacionDAL.GetDepreciaciones().Count > i; i++) //Recorre lista de depreciaciones.
                {
                    Depreciacion depreciacion = depreciacionDAL.GetDepreciaciones()[i]; //Variable de depreciación actual en el recorrido.
                    System.TimeSpan dif = DateTime.Now.Subtract(depreciacion.FechaDepreciacion); //Esta vabiable guarda la diferencia de días entre el día actual y la fecha de la última depreciación.
                    int diasSobrantes = dif.Days;
                    while (diasSobrantes >= 30 && depreciacion.Valor > 0) //Mientras haya más de 30 días de diferencia (se deprecia cada 30 días)...
                    {
                        depreciacion.Valor = depreciacion.Valor - depreciacion.MontoDepreciacion; //Se le resta al valor actual el monto de la depreciación del activo.
                        diasSobrantes = diasSobrantes - 30;//Se hace una resta de los días sobrantes al mes para ver si hay que realizar otra resta.
                        depreciado = true;
                    }
                    if (depreciacion.Valor < 0)
                    {
                        diasSobrantes = diasSobrantes + 30;
                        depreciacion.Valor = 0;
                    }
                    if (depreciado == true)
                    {
                        depreciacion.FechaDepreciacion = DateTime.Now.AddDays(-diasSobrantes); //La fecha de depreciación se actualiza, restándole a la fecha actual la cantidad de días que sobraron después del cálculo para que sea exacta.
                        depreciacionDAL.Update(depreciacion); //Se actualiza la depreciación correspondiente y se continúa con el recorrido.
                        depreciado = false;
                    }

                }
            }
        }

        private void senalarDepreciados()
        {

            foreach (DataGridViewRow r in tblDatosActivos.Rows)//Recorre el grid...
            {
                foreach (DataGridViewCell c in r.Cells)
                {
                    if ((c.Value.ToString().Equals("0.0000"))) //Si el valor de la depreciación 0 es encontrado...
                    {
                        c.Style.ForeColor = Color.Red;
                        c.Style.SelectionForeColor = Color.Red;//Lo pinta de rojo...

                    }
                }
            }
        }



        private void frmActivos_n_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sEGTRANSADataSource_ACTIVOS.Activos' table. You can move, or remove it, as needed.
            this.activosTableAdapter.Fill(this.sEGTRANSADataSource_ACTIVOS.Activos);
            cargarActivos();
        }

        // Codigo para llamar al form de Agregar
        private void btnActivoAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmActivosAgregar_n form = new FrmActivosAgregar_n())
                {
                    form.ShowDialog(this);
                    cargarActivos();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
            }
        }




        // Codigo para llamar al form de Modificar
        private void btnActivoModificar_Click(object sender, EventArgs e)
        {
            Activos activo = (Activos)tblDatosActivos.CurrentRow.DataBoundItem;

            try
            {

                using (FrmActivosModificar_n form = new FrmActivosModificar_n(activo.IdActivo))
                {
                    MessageBox.Show(activo.IdActivo.ToString());
                    form.ShowDialog(this);
                    cargarActivos();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
            }
        }

        // Codigo para llamar al form de Eliminar
        private void btnActivoEliminar_Click(object sender, EventArgs e)
        {

            try
            {

                Activos activo = (Activos)tblDatosActivos.CurrentRow.DataBoundItem;

                DialogResult dialogResult = MessageBox.Show("Seguro que desea eliminar el activo " + activo.IdActivo.ToString() + "?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    activoDAL.eliminarActivo(activo.IdActivo);
                    depreciacionDAL.Delete(activo.IdActivo);
                    string detalleBitacora = "Se eliminó el activo:" + activo.CodActivo.Trim() + activo.IdActivo;
                    bitacora.DetalleBitacora = detalleBitacora;
                    bitacora.IdUsuario = ValoresAplicacion.idUsuario;
                    bitacoraDAL.Add(bitacora);
                    MessageBox.Show("Activo Eliminado");

                    //usuarios.Clear();
                    //lstUsuarios.DataSource = null;

                    cargarActivos();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Operacion Cancelada");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }



        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtBusqueda.Text != "")
            {
                tblDatosActivos.CurrentCell = null;
                foreach (DataGridViewRow r in tblDatosActivos.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in tblDatosActivos.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString()).ToUpper().IndexOf(txtBusqueda.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                        //r.Selected = true;
                        tblDatosActivos.Rows[0].Selected = true;

                    }

                }

            }
            else
            {
                cargarActivos();
            }
        }
    }
}

