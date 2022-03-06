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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string respuesta = "";

            if (txtUsuario.Text != "" && txtPassword.Text != string.Empty)
            {
                    Acceso_datos Acceso = new Acceso_datos();

                    respuesta = Acceso.ValidarUsuario(txtUsuario.Text, txtPassword.Text);

                if (respuesta != "")
                {
                    MessageBox.Show("Bienvenido : " + respuesta);
                    frmPrincipal frmppal = new frmPrincipal();
                    this.Hide();
                    frmppal.Show();
                }
                else
                {
                    MessageBox.Show("Usuarios y clave no encontrados");
                    txtUsuario.Text = "";
                    txtUsuario.Focus();
                    txtPassword.Text = "";    
                }
            }
            else
            {
                MessageBox.Show("Debes ingresar un usuario y una clave");
            }
        }
    }
}
