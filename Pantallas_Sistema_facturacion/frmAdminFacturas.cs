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
    public partial class frmAdminFacturas : Form
    {
        public frmAdminFacturas()
        {
            InitializeComponent();
        }

        public string DtmFecha { get; set; }

        DataTable dt = new DataTable();
        Acceso_datos acceso = new Acceso_datos();

        private void llenar_Grid()
        {
            dgFacturas.Rows.Clear();
            string sentencia = $"Select tf.IdFactura, tc.StrNombre, tf.DtmFecha , tf.NumValorTotal, tef.StrDescripcion from TBLFACTURA tf  left join TBLESTADO_FACTURA tef on tf.IdEstado = tef.IdEstadoFactura left join TBLCLIENTES tc on tf.IdCliente = tc.IdCliente";
            dt = acceso.EjecutarComandoDatos(sentencia);

            foreach (DataRow row in dt.Rows)
            {
                dgFacturas.Rows.Add(row[0], row[1], row[2].ToString(), row[3], row[4]);
            }
        }

        private void frmAdminFacturas_Load(object sender, EventArgs e)
        {
            llenar_Grid();
        }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            //need pop up for facturas
        }

        private void dgFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgFacturas.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgFacturas.CurrentRow.Index;
                //frmEditarCliente Cliente = new frmEditarCliente();
                //Cliente.IdFa = int.Parse(dgFacturas[0, posActual].Value.ToString());
                //Cliente.ShowDialog();
            }
            llenar_Grid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgFacturas.Rows.Clear();

                string sentencia = $"Select tf.IdFactura, tc.StrNombre, tf.DtmFecha , tf.NumValorTotal, tef.StrDescripcion from TBLFACTURA tf  left join TBLESTADO_FACTURA tef on tf.IdEstado = tef.IdEstadoFactura left join TBLCLIENTES tc on tf.IdCliente = tc.IdCliente where IdFactura = {txtBuscar.Text}";
                dt = acceso.EjecutarComandoDatos(sentencia);

                foreach (DataRow row in dt.Rows)
                {
                    dgFacturas.Rows.Add(row[0], row[1], row[2].ToString(), row[3], row[4]);
                }
                txtBuscar.Text = "";
            }
            else
            {
                llenar_Grid();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
