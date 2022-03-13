using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion
{
    public partial class frmAdministracionProductos : Form
    {
        public frmAdministracionProductos()
        {
            InitializeComponent();
        }

        public int IdProducto { get; set; }
        public int IdCategoria { get; set; }

        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        Acceso_datos acceso = new Acceso_datos();

        private void fill_ProductFields()
        {
            if (txtBuscarProducto.Text == "")
            {
                MessageBox.Show("Ingreso un nombre de producto válido");
            }
            else
            {
                string sentencia = $"Select * from TBLPRODUCTO where StrNombre like '%{txtBuscarProducto.Text}%'";
                dt = acceso.EjecutarComandoDatos(sentencia);
                foreach (DataRow row in dt.Rows)
                {
                    txtBxProductID.Text = row[0].ToString();
                    txtProducto.Text = row[1].ToString();
                    txtCodReferencia.Text = row[2].ToString();
                    txtPrecioCompra.Text = row[3].ToString();
                    txtPrecioVenta.Text = row[4].ToString();
                    cBxDescripcionCategoria.Text = row[5].ToString();
                    txtBxDetallesProducto.Text = row[6].ToString();
                    txtRutaImagen.Text = row[7].ToString();
                    txtCantidadStock.Text = row[8].ToString();
                }
            }
        }

        public bool eliminarProducto()
        {
             Boolean borrado = false;
            if (txtBxProductID != null)
            {
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec [Eliminar_Producto] {txtBxProductID.Text}";
                    MessageBox.Show(Acceso.EjecutarComando(sentencia));
                    borrado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("falló borrado: " + ex);
                    borrado = false;
                }
            }
            return borrado;
        }

        ////Tengo un problema con ALTER TABLE [dbo].[TBLPRODUCTO]  WITH CHECK ADD  CONSTRAINT [FK__TBLPRODUC__IdCat__440B1D61] FOREIGN KEY([IdCategoria])
        //REFERENCES[dbo].[TBLCATEGORIA_PROD]
        //([IdCategoria])
        //GO
        //ALTER TABLE[dbo].[TBLPRODUCTO]
        //CHECK CONSTRAINT[FK__TBLPRODUC__IdCat__440B1D61]
        public bool Anadir_ActualizarProducto()
        {
            Boolean actualizado = false;
            if (validarCamposProducto())
            {
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec [actualizar_Producto] {IdProducto},'{txtProducto.Text}',{txtCodReferencia.Text} ,'{txtPrecioCompra.Text}','{txtPrecioVenta.Text}',{IdCategoria}, '{txtBxDetallesProducto.Text}', '{txtRutaImagen.Text}', '{txtCantidadStock.Text}', '{DateTime.Now.ToShortDateString()}', 'Javier'";
                    MessageBox.Show(Acceso.EjecutarComando(sentencia));
                    actualizado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("falló inserción: " + ex);
                    actualizado = false;
                }
            }
            return actualizado;
        }

        private Boolean validarCamposProducto()
        {
            Boolean errorCampos = true;
            if (txtProducto.Text == string.Empty)
            {
                MensajeError.SetError(txtProducto, "debe ingresar el nombre del producto");
                txtProducto.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtProducto, ""); }
            if (txtCodReferencia.Text == "")
            {
                MensajeError.SetError(txtCodReferencia, "debe ingresar el código de referencia");
                txtCodReferencia.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtCodReferencia, ""); }
            if (!esNumerico(txtPrecioCompra.Text))
            {
                MensajeError.SetError(txtPrecioCompra, "El Precio de compra debe ser numerico");
                txtPrecioCompra.Focus();
                return false;
            }
            MensajeError.SetError(txtPrecioCompra, "");
            if (!esNumerico(txtPrecioVenta.Text))
            {
                MensajeError.SetError(txtPrecioVenta, "El Precio de venta debe ser numerico");
                txtPrecioVenta.Focus();
                return false;
            }
            MensajeError.SetError(txtPrecioVenta, "");
            if (!esNumerico(txtCantidadStock.Text))
            {
                MensajeError.SetError(txtCantidadStock, "El stock debe ser numerico");
                txtCantidadStock.Focus();
                return false;
            }
            MensajeError.SetError(txtCantidadStock, "");
            if (txtRutaImagen.Text == "")
            {
                MensajeError.SetError(txtRutaImagen, "debe ingresar la cantidad de stock");
                txtRutaImagen.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtRutaImagen, ""); }
            if (txtBxDetallesProducto.Text == "")
            {
                MensajeError.SetError(txtBxDetallesProducto, "debe ingresar los detalles del producto");
                txtBxDetallesProducto.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtBxDetallesProducto, ""); }
            return errorCampos;
        }

        private bool esNumerico(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            fill_ProductFields();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Anadir_ActualizarProducto();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarProducto();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
