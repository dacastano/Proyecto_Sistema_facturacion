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


        public void llenar_grid()
        {
            for (int i = 1; i < 10; i++)
            {
                dgClientes.Rows.Add(i, $"Nombre {i} Apellido1 Apellido2 ", $"{i * 12345}", $"{i * 12345}");
            }
        }
        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarCliente Cliente = new frmEditarCliente();
            Cliente.IdCliente = 0;
            Cliente.ShowDialog();
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgClientes.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgClientes.CurrentRow.Index;
                if (MessageBox.Show("Seguro de Borrar", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"Borrando indice {e.RowIndex} ID {dgClientes[0, posActual].Value.ToString()}");
            }
            if (dgClientes.Columns[e.ColumnIndex].Name == "Editar")
            {
                int posActual = dgClientes.CurrentRow.Index;
                frmEditarCliente Cliente = new frmEditarCliente();
                Cliente.IdCliente = int.Parse(dgClientes[0, posActual].Value.ToString());
                Cliente.ShowDialog();
            }
        }
    }
}
