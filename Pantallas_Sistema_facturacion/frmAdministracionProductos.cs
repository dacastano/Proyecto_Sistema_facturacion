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

        DataTable dt = new DataTable();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            fill_ProductFields();
        }
    }
}
