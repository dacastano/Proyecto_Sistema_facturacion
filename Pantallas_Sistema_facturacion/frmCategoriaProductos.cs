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
    public partial class frmCategoriaProductos : Form
    {
        public frmCategoriaProductos()
        {
            InitializeComponent();
        }

        public int IdCategoria { get; set; }

        public string StrDescripcion { get; set; }

        DataTable dt = new DataTable();
        Acceso_datos acceso = new Acceso_datos();

        private void fill_CategoryFields()
        {
            if (txtBuscarCategoria.Text == "")
            {
                MessageBox.Show("Ingreso un Id de categoría o un nombre de categoria válido");
            }
            else
            {
                string sentencia = $"Select * from TBLCATEGORIA_PROD where IdCategoria={txtBuscarCategoria.Text}";
                dt = acceso.EjecutarComandoDatos(sentencia);
                foreach (DataRow row in dt.Rows)
                {
                    txtCodigoCategoria.Text = "Código: " + row[0].ToString();
                    txtNombreCategoria.Text = "Nombre: " + row[1].ToString();
                }
            }
        }

        public Boolean validarCamposCat_Producto()
        {
            Boolean errorCampos = true;
            if (!esNumerico(txtCodigoCategoria.Text))
            {
                MensajeError.SetError(txtCodigoCategoria, "debe ingresar un código válido de categoria");
                txtCodigoCategoria.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtCodigoCategoria, ""); }
            if (txtNombreCategoria.Text == "")
            {
                MensajeError.SetError(txtNombreCategoria, "debe ingresar un nombre para la categoria");
                txtNombreCategoria.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtNombreCategoria, ""); }
            return errorCampos;
        }

        public bool esNumerico(string num)
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

        public bool anadir_ActualizarCatProducto()
        {
            Boolean actualizado = false;
            if (validarCamposCat_Producto())
            {
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec [actualizar_CategoriaProducto] {IdCategoria}, '{txtNombreCategoria.Text}', '{DateTime.Now.ToShortDateString()}', 'Javier'";
                    MessageBox.Show(Acceso.EjecutarComando(sentencia));
                    actualizado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("falló añadición/actualización: " + ex);
                    actualizado = false;
                }
            }
            return actualizado;
        }

        public bool eliminarCategoria_Producto()
        {
            Boolean borrado = false;
            if (txtCodigoCategoria != null)
            {
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec [Eliminar_CategoriaProducto] {txtCodigoCategoria.Text}";
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


        private void btnbuscar_Click(object sender, EventArgs e)
        {
            fill_CategoryFields();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            anadir_ActualizarCatProducto();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarCategoria_Producto();
        }
    }
}
