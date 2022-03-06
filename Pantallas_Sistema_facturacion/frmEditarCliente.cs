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

        DataTable dt = new DataTable(); 
        Acceso_datos Acceso = new Acceso_datos();

        private void llenar_Cliente()
        {
            if (IdCliente == 0)
            {
                lblTitulo.Text = "Ingreso Nuevo Cliente";
            }
            else
            {
                string sentencia = $"select * from TBLCLIENTES where IdCliente = {IdCliente}";
                dt = Acceso.EjecutarComandoDatos(sentencia);
                foreach (DataRow row in dt.Rows)
                {
                    txtNombre.Text = row[1].ToString();
                    txtDocumento.Text = row[2].ToString();
                    txtDireccion.Text= row[3].ToString();
                    txtTelefono.Text= row[4].ToString();
                    txtEmail.Text= row[1].ToString();
                }
            }
        }

        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            llenar_Cliente();
        }

        //private void frmEditarCliente_Load(object sender, EventArgs e)
        //{
        //    if (IdCliente == 0)
        //    {//Registro nuevo
        //        lblTitulo.Text = "Ingreso Nuevo Cliente";
        //    }
        //    else
        //    {//Actualizar el registro con el ID pasado
        //        lblTitulo.Text = "Modificar Cliente";
        //        txtIdCliente.Text = IdCliente.ToString();
        //        txtNombre.Text = "Nombre 1 Apellido";
        //        txtDocumento.Text = "34564813";
        //        txtDireccion.Text = "Calle donde vive el cliente";
        //        txtTelefono.Text = "54896321548";
        //    }


        //}

        public bool Guardar()
        {
            Boolean actualizado = false;
            if (validar())
            {
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec [actualizar_Cliente] {IdCliente},'{txtNombre.Text}',{txtDocumento.Text} ,'{txtDireccion.Text}','{txtTelefono.Text}', '{txtEmail.Text}','Javier','{DateTime.Now.ToShortDateString()}'";
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


    private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtNombre.Text == string.Empty)
            {
                MensajeError.SetError(txtNombre, "debeingresar el nombre del Cliente");
                txtNombre.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtNombre, ""); }
            if (txtDocumento.Text == "")
            {
                MensajeError.SetError(txtDocumento, "debe ingresar el documento");
                txtDocumento.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtDocumento, ""); }
            if (!esNumerico(txtDocumento.Text))
            {
                MensajeError.SetError(txtDocumento, "El Documento debe ser numerico");
                txtDocumento.Focus();
                return false;
            }
            MensajeError.SetError(txtDocumento, "");
            return errorCampos;
        }
        //función para validar si un valor dado es numerico
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

