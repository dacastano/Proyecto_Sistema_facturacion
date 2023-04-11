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
    public partial class frmSeguridad : Form
    {
        public frmSeguridad()
        {
            InitializeComponent();
            fill_EmployeeCombo();
        }

        private void fill_EmployeeCombo()
        {
            DataTable dt = new DataTable();
            Acceso_datos acceso = new Acceso_datos();
            dt = acceso.cargarTabla("TBLEMPLEADO", "");

            cboEmployeeSec.DataSource = dt;
            cboEmployeeSec.DisplayMember = "strNombre";
            cboEmployeeSec.ValueMember = "IdEmpleado";
            acceso.CerrarrBd();
        }
    }
}
