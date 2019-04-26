using Backend.DAL;
using Backend.Entities;
using BackEnd.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FronEnd
{
    public partial class FrmActivosModificar_n : Form
    {
        private IActivosDAL activoDAL;
        private ICategoriasDAL categoriaDAL;
        private IProveedoresDAL proveedorDAL;
        private IEstadoActivosDAL estadoActivoDAL;
        private Activos Activo;

        public FrmActivosModificar_n()
        {
            InitializeComponent();
       
        }

        public FrmActivosModificar_n(int id)
        {
            InitializeComponent();
            activoDAL = new ActivosImplDAL();
            categoriaDAL = new CategoriasImplDAL();
            proveedorDAL = new ProveedoresImplDAL();
            estadoActivoDAL = new EstadoActivosImplDAL();
            Activo = activoDAL.mostrarActivo(id);

        }

        private void CargaComboBox()
        {
            //ComboBox de Proveedor
            cmbBoxProveedor.DisplayMember = "NombreProveedor";
            cmbBoxProveedor.ValueMember = "IdProveedor";
            List<Proveedores> proveedores = proveedorDAL.GetProveedores();
            cmbBoxProveedor.DataSource = proveedores;

            //ComboBox de Categorias
            cmbBoxCategorias.DisplayMember = "Descripcion";
            cmbBoxCategorias.ValueMember = "IdCategoria";
            List<Categorias> categorias = categoriaDAL.GetCategorias();
            cmbBoxCategorias.DataSource = categorias;

            //ComboBox de EstadoActivo
            cmbBoxEstadoActivos.DisplayMember = "NombreEstado";
            cmbBoxEstadoActivos.ValueMember = "IdEstadoActivo";
            List<EstadoActivos> estadoActivos = estadoActivoDAL.GetEstadoActivos();
            cmbBoxEstadoActivos.DataSource = estadoActivos;
        }

        private void FrmActivosModificar_n_Load(object sender, EventArgs e)
        {
            CargaComboBox();
            txtCodActivo.Text = Activo.CodActivo;
            txtDescripcion.Text = Activo.Descripcion;
            dateFechaCompra.Value = Activo.FechaCompra.Value;
            txtPrecio.Text = Activo.PrecioInicial.ToString();
            txtGarantia.Text = Activo.Garantia.ToString();
            txtPrecioActual.Text = Activo.PrecioActual.ToString();
           

        }


        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificaActivo_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (string.IsNullOrEmpty(txtDescripcion.Text) ||
                        string.IsNullOrEmpty(txtGarantia.Text) ||
                       string.IsNullOrEmpty(txtPrecio.Text)
                        )
                    {

                        MessageBox.Show("Debe completar toda la informacion");

                        return;

                    }
                    else
                    {

                        if ((Categorias)cmbBoxCategorias.SelectedItem != null)

                        {
                            //string codAct = cmbBoxCodActivo.Text;
                           
                            //proveedores = (Proveedores)cmbBoxProveedor.SelectedItem;
                            //estadoActivos = (EstadoActivos)cmbBoxEstadoActivos.SelectedItem;
                            Activo.PrecioInicial = Convert.ToDecimal(txtPrecio.Text);
                            Activo.PrecioActual = Convert.ToDecimal(txtPrecioActual.Text);
                            Activo.CodActivo = txtCodActivo.Text;
                            //activo.CodActivo = codAct.ToString();
                            Activo.Categoria = (int)cmbBoxCategorias.SelectedValue;
                            Activo.Categorias = (Categorias)cmbBoxCategorias.SelectedItem;
                            Activo.Descripcion = txtDescripcion.Text;
                            Activo.FechaCompra = dateFechaCompra.Value;
                            Activo.Proveedor = (int)cmbBoxProveedor.SelectedValue;
                            Activo.Proveedores = (Proveedores)cmbBoxProveedor.SelectedItem;
                            Activo.EstadoActivo = (int)cmbBoxEstadoActivos.SelectedValue;
                            Activo.EstadoActivos = (EstadoActivos)cmbBoxEstadoActivos.SelectedItem;
                            Activo.Garantia = Convert.ToInt32(txtGarantia.Text);


                            activoDAL.actualizarActivo(Activo);
                            MessageBox.Show("Activo actualizado");
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    // MessageBox.Show("Debe completar toda la informacion");
                    MessageBox.Show("Error " + ex.Message);
                }

            }


        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void txtGarantia_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }


        private void txtDescripcion_Enter(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "Descripcion del activo")
            {
                txtDescripcion.Text = "";

                txtDescripcion.ForeColor = Color.Black;
            }
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                txtDescripcion.Text = "Descripcion del activo";

                txtDescripcion.ForeColor = Color.Silver;
            }

        }

        private void txtPrecio_Enter(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "Precio(colones)")
            {
                txtPrecio.Text = "";

                txtPrecio.ForeColor = Color.Black;
            }

        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "")
            {
                txtPrecio.Text = "Precio(colones)";

                txtPrecio.ForeColor = Color.Silver;
            }

        }

        private void txtGarantia_Enter(object sender, EventArgs e)
        {
            if (txtGarantia.Text == "Garantia(meses)")
            {
                txtGarantia.Text = "";

                txtGarantia.ForeColor = Color.Black;
            }

        }

        private void txtGarantia_Leave(object sender, EventArgs e)
        {
            if (txtGarantia.Text == "")
            {
                txtGarantia.Text = "Garantia(meses)";

                txtGarantia.ForeColor = Color.Silver;
            }


        }


        private void cmbCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

 

        private void cmbEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            // Let the default behavior to happen.
            base.OnClosing(e);
            // Do not allow cancellation of the close operation.
            e.Cancel = false;
            //frmUsuariosAgrega frmUsuarios = new frmUsuariosAgrega();

            //previousForm.Show();
        }

    
    }
}
