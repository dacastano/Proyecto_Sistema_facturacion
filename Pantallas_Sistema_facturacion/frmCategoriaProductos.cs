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

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            fill_CategoryFields();
        }
    }
}
