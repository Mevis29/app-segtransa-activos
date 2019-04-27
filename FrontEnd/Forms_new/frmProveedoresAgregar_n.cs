using Backend.DAL;
using Backend.Entities;
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
    public partial class FrmProveedoresAgregar_n : Form
    {
        private IProveedoresDAL proveedorDAL = new ProveedoresImplDAL();
        private IBitacoraDAL bitacoraDAL = new BitacoraImplDAL();
        private Bitacora bitacora = new Bitacora();
        private Proveedores proveedor;

        public FrmProveedoresAgregar_n()
        {
            InitializeComponent();
          
        }



        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregaProveedor_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (string.IsNullOrEmpty(txtNombreProv.Text) ||
                        string.IsNullOrEmpty(txtCorreo.Text)
                       
                        )
                    {

                        MessageBox.Show("Debe completar toda la informacion");

                        return;

                    }
                    else
                    {
                        Proveedores proveedor = new Proveedores();
                                                
                        proveedor.NombreProveedor = txtNombreProv.Text;
                        proveedor.Telefono = txtTelefonoProv.Text;
                        proveedor.Correo = txtCorreo.Text;
                        proveedor.Direccion = txtDireccion.Text;
                        proveedorDAL.Add(proveedor);
                        string detalleBitacora = "Se insertó el proveedor: " + proveedor.NombreProveedor;
                        bitacora.DetalleBitacora = detalleBitacora;
                        bitacora.IdUsuario = ValoresAplicacion.idUsuario;
                        bitacoraDAL.Add(bitacora);
                        MessageBox.Show("Proveedor agregado");
                        this.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe completar toda la informacion");
                }

            }


        }

    }
}
