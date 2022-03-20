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
    public partial class frmAnadirFactura : Form
    {
        public frmAnadirFactura()
        {
            InitializeComponent();
        }

        public int IdFactura { get; set; }

        DataTable dt = new DataTable();
        Acceso_datos Acceso = new Acceso_datos();

        private void llenar_InfoFactura()
        {
            if (IdFactura == IdFactura)
            {
                string sentencia = $"Select tf.IdFactura, tc.StrNombre, tf.DtmFecha , tf.NumValorTotal, tef.StrDescripcion from TBLFACTURA tf  left join TBLESTADO_FACTURA tef on tf.IdEstado = tef.IdEstadoFactura left join TBLCLIENTES tc on tf.IdCliente = tc.IdCliente where IdFactura= {IdFactura}";
                dt = Acceso.EjecutarComandoDatos(sentencia);
                foreach (DataRow row in dt.Rows)
                {
                    txtNumFactura.Text = row[0].ToString();
                    txtCliente.Text = row[1].ToString();
                    txtFechaEmision.Text = row[2].ToString();
                    txtValor.Text = row[3].ToString();
                    txtEstado.Text = row[4].ToString();
                }
            }
        }

        public bool anadir()
        {
            Boolean anadido = false;
            if (validar())
            {
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec [actualizar_Factura] {txtNumFactura.Text}, {txtCliente.Text}, {txtEmpleado.Text}, '{DateTime.Now.ToShortDateString()}', {txtValor.Text}, '{txtEstado.Text}', {txtDescuento.Text}, {txtImpuesto.Text}";
                    MessageBox.Show(Acceso.EjecutarComando(sentencia));
                    anadido = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("falló inserción: " + ex);
                    anadido = false;
                }
            }
            return anadido;
        }

        //need to make it so that when this values are typed in the corresponding tables are updated
        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (!esNumerico(txtNumFactura.Text))
            {
                MensajeError.SetError(txtNumFactura, "debe ingresar el número de factura");
                txtNumFactura.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtNumFactura, ""); }
            if (!esNumerico(txtCliente.Text))
            {
                MensajeError.SetError(txtCliente, "debe ingresar identificardor del cliente");
                txtCliente.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtCliente, ""); }
            if (!esNumerico(txtEmpleado.Text))
            {
                MensajeError.SetError(txtEmpleado, "Edebe ingresar identificardor del empleado");
                txtEmpleado.Focus();
                return false;
            }
            else { MensajeError.SetError(txtEmpleado, ""); }
            if (txtFechaEmision.Text == "")
            {
                MensajeError.SetError(txtFechaEmision, "fecha emisión es hoy");
                txtFechaEmision.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtFechaEmision, ""); }
            if (!esNumerico(txtValor.Text))
            {
                MensajeError.SetError(txtValor, "debe ingresar el valor");
                txtValor.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtValor, ""); }
            if (txtEstado.Text == "")
            {
                MensajeError.SetError(txtEstado, "debe ingresar el estado de la factura");
                txtCliente.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtEstado, ""); }
            if (!esNumerico(txtDescuento.Text))
            {
                MensajeError.SetError(txtDescuento, "debe ingresar valor del descuento");
                txtDescuento.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtDescuento, ""); }
            if (!esNumerico(txtImpuesto.Text))
            {
                MensajeError.SetError(txtImpuesto, "El Documento debe ser numerico");
                txtImpuesto.Focus();
                return false;
            }
            MensajeError.SetError(txtImpuesto, "");
            return errorCampos;
        }

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
        private void frmEditarFactura_Load(object sender, EventArgs e)
        {
            llenar_InfoFactura();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            anadir();
        }
    }
}
