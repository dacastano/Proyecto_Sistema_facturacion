using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Pantallas_Sistema_facturacion
{
    public partial class frmPrincipal : MaterialForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void AbrirForm(Form formHijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(formHijo);
            formHijo.Show();
        }
        public void btnClientes_Click(object sender, EventArgs e)
        {
            frmListaClientes ListaCliente = new frmListaClientes();
            AbrirForm(ListaCliente);
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmAdministracionProductos ListaProductos = new frmAdministracionProductos();
            AbrirForm(ListaProductos);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmCategoriaProductos ListaCategorias = new frmCategoriaProductos();
            AbrirForm(ListaCategorias);
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            frmAdminFacturas facturas = new frmAdminFacturas();
            AbrirForm(facturas);
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            frmInformes informes = new frmInformes();
            AbrirForm(informes);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmAdminEmpleados Empleados = new frmAdminEmpleados();
            AbrirForm(Empleados);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            frmRoles Roles = new frmRoles();
            AbrirForm(Roles);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            frmSeguridad Seguridad = new frmSeguridad();
            AbrirForm(Seguridad);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            frmAyuda Ayuda = new frmAyuda();
            AbrirForm(Ayuda);
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            frmAcercaDe Acerca = new frmAcercaDe();
            AbrirForm(Acerca);
        }
    }
}
