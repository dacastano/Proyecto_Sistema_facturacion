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
    public partial class frmListaClientes : Form
    {
        public frmListaClientes()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        Acceso_datos acceso = new Acceso_datos();

        private void llenar_Grid()
        {
            dgClientes.Rows.Clear();

            string sentencia = $"Select IdCliente, StrNombre, NumDocumento, StrTelefono from TBLCLIENTES";
            dt = acceso.EjecutarComandoDatos(sentencia);

            foreach (DataRow row in dt.Rows)
            {
                dgClientes.Rows.Add(row[0], row[1], row[2], row[3]);
            }
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            llenar_Grid();
        }

        //public void llenar_grid()
        //{
        //    for (int i = 1; i < 10; i++)
        //    {
        //        dgClientes.Rows.Add(i, $"Nombre {i} Apellido1 Apellido2 ", $"{i * 12345}", $"{i * 12345}");
        //    }
        //}
        //private void frmListaClientes_Load(object sender, EventArgs e)
        //{
        //    llenar_grid();
        //}

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarCliente Cliente = new frmEditarCliente();
            Cliente.IdCliente = 0;
            Cliente.ShowDialog();
            llenar_Grid();
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgClientes.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgClientes.CurrentRow.Index;
                if (MessageBox.Show($"Seguro de Borrar al cliente {dgClientes[1, posActual].Value.ToString()}", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //MessageBox.Show($"Borrando indice {e.RowIndex} ID {dgClientes[0, posActual].Value.ToString()}");
                {
                    int IdCliente = Convert.ToInt32(dgClientes[0, posActual].Value.ToString());
                    string sentencia = $"Exec Eliminar_cliente '{IdCliente}'";
                    string Mensaje = acceso.EjecutarComando(sentencia);
                    MessageBox.Show(Mensaje);
                }
            }
            if (dgClientes.Columns[e.ColumnIndex].Name == "btnEditar") 
            {
                int posActual = dgClientes.CurrentRow.Index;
                frmEditarCliente Cliente = new frmEditarCliente();
                Cliente.IdCliente = int.Parse(dgClientes[0, posActual].Value.ToString());
                Cliente.ShowDialog();
            }
            llenar_Grid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgClientes.Rows.Clear();

                string sentencia = $"select * from TBLCLIENTES where strNombre like '%{txtBuscar.Text}%'";
                dt = acceso.EjecutarComandoDatos(sentencia);

                foreach (DataRow row in dt.Rows)
                {
                    dgClientes.Rows.Add(row[0], row[1], row[2], row[3]);
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
