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
    public partial class frmAyuda : Form
    {
        public frmAyuda()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void frmAyuda_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.docs.microsoft.com", null);
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.Text = e.Url.ToString() + "la página se está cargando...";
        }
    }
}
