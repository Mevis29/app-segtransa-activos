using Backend.DAL;
using Backend.Entities;
using BackEnd.DAL;
using FrontEnd.Clases;
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
    public partial class FrmActivosAgregar_n : Form
    {
        private IActivosDAL activoDAL = new ActivosImplDAL();
        private ICategoriasDAL categoriaDAL = new CategoriasImplDAL();
        private IProveedoresDAL proveedorDAL = new ProveedoresImplDAL();
        private IEstadoActivosDAL estadoActivoDAL = new EstadoActivosImplDAL();
        private IDepreciacionDAL depreciacionDAL = new DepreciacionDALImpl();
        private IBitacoraDAL bitacoraDAL = new BitacoraImplDAL();
        private Bitacora bitacora = new Bitacora();
        //private Activos activo;

        public FrmActivosAgregar_n()
        {
            InitializeComponent();
            CargaComboBox();
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



        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregaActivo_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (string.IsNullOrEmpty(txtDescripcion.Text) ||
                        string.IsNullOrEmpty(txtGarantia.Text) ||
                       string.IsNullOrEmpty(txtPrecio.Text) ||
                       string.IsNullOrEmpty(txtMesesDepreciacion.Text)
                        )
                    {

                        MessageBox.Show("Debe completar toda la informacion");

                        return;

                    }
                    else if (validarFecha() == false)
                    {
                        MessageBox.Show("La fecha de compra debe ser menor que la fecha actual");
                    }
                    else
                    {
                        Activos activo = new Activos();
                        Categorias categorias = new Categorias();
                        Proveedores proveedores = new Proveedores();
                        EstadoActivos estadoActivos = new EstadoActivos();

                        if ((Categorias)cmbBoxCategorias.SelectedItem != null)

                        {
                            //string codAct = cmbBoxCodActivo.Text;
                            categorias = (Categorias)cmbBoxCategorias.SelectedItem;
                            proveedores = (Proveedores)cmbBoxProveedor.SelectedItem;
                            estadoActivos = (EstadoActivos)cmbBoxEstadoActivos.SelectedItem;
                            activo.PrecioInicial = Convert.ToDecimal(txtPrecio.Text);
                            activo.PrecioActual = Convert.ToDecimal(txtPrecio.Text);
                            activo.CodActivo = txtCodActivo.Text;
                            //activo.CodActivo = codAct.ToString();
                            activo.Categoria = categorias.IdCategoria;
                            activo.Descripcion = txtDescripcion.Text;
                            activo.FechaCompra = dateFechaCompra.Value;
                            activo.Proveedor = proveedores.IdProveedor;
                            activo.EstadoActivo = estadoActivos.IdEstadoActivo;
                            activo.Garantia = Convert.ToInt32(txtGarantia.Text);
                            activo.MesesDepreciacion = Convert.ToInt32(txtMesesDepreciacion.Text);

                            activoDAL.agregarActivo(activo);
                            //Se agrega la depreciación de acuerdo al último activo agregado
                            depreciacionDAL.Add(activoDAL.obtenerActivos()[activoDAL.obtenerActivos().Count - 1]);
                            string detalleBitacora = "Se insertó el activo: " + activo.CodActivo + activo.IdActivo;
                            bitacora.DetalleBitacora = detalleBitacora;
                            bitacora.IdUsuario = ValoresAplicacion.idUsuario;
                            bitacoraDAL.Add(bitacora);
                            MessageBox.Show("Activo agregado");
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Uno de los datos ingresados no tiene el formato correcto");
                }

            }


        }

        private bool validarFecha()
        {
            bool fechaValidada = true;
            if (dateFechaCompra.Value > DateTime.Now)
            {
                fechaValidada = false;
            }
            return fechaValidada;
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

        private void txtMesesDepreciacion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMesesDepreciacion_Enter(object sender, EventArgs e)
        {
            if (txtMesesDepreciacion.Text == "Meses depreciación: ")
            {
                txtMesesDepreciacion.Text = "";

                txtMesesDepreciacion.ForeColor = Color.Black;
            }

        }

        private void txtMesesDepreciacion_Leave(object sender, EventArgs e)
        {
            if (txtMesesDepreciacion.Text == "")
            {
                txtMesesDepreciacion.Text = "Meses depreciación: ";

                txtMesesDepreciacion.ForeColor = Color.Silver;
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
