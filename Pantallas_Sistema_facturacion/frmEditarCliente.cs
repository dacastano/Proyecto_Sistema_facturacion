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
    public partial class frmEditarCliente : Form
    {
        public frmEditarCliente()
        {
            InitializeComponent();
        }

        public int IdCliente { get; set; }

        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            if (IdCliente == 0)
            {//Registro nuevo
                lblTitulo.Text = "Ingreso Nuevo Cliente";
            }
            else
            {//Actualizar el registro con el ID pasado
                lblTitulo.Text = "Modificar Cliente";
                txtIdCliente.Text = IdCliente.ToString();
                txtNombre.Text = "Nombre 1 Apellido";
                txtDocumento.Text = "34564813";
                txtDireccion.Text = "Calle donde vive el cliente";
                txtTelefono.Text = "54896321548";
            }


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Actualizados");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
