
namespace Pantallas_Sistema_facturacion
{
    partial class frmAnadirFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAnadir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtEstado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtValor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNumFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.txtFechaEmision = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDescuento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtImpuesto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(294, 309);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(96, 34);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAnadir
            // 
            this.btnAnadir.Depth = 0;
            this.btnAnadir.Location = new System.Drawing.Point(57, 309);
            this.btnAnadir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Primary = true;
            this.btnAnadir.Size = new System.Drawing.Size(96, 34);
            this.btnAnadir.TabIndex = 16;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Depth = 0;
            this.txtEstado.Hint = "Estado";
            this.txtEstado.Location = new System.Drawing.Point(50, 205);
            this.txtEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.PasswordChar = '\0';
            this.txtEstado.SelectedText = "";
            this.txtEstado.SelectionLength = 0;
            this.txtEstado.SelectionStart = 0;
            this.txtEstado.Size = new System.Drawing.Size(354, 23);
            this.txtEstado.TabIndex = 15;
            this.txtEstado.UseSystemPasswordChar = false;
            // 
            // txtValor
            // 
            this.txtValor.Depth = 0;
            this.txtValor.Hint = "Valor";
            this.txtValor.Location = new System.Drawing.Point(50, 177);
            this.txtValor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.SelectedText = "";
            this.txtValor.SelectionLength = 0;
            this.txtValor.SelectionStart = 0;
            this.txtValor.Size = new System.Drawing.Size(354, 23);
            this.txtValor.TabIndex = 14;
            this.txtValor.UseSystemPasswordChar = false;
            // 
            // txtCliente
            // 
            this.txtCliente.Depth = 0;
            this.txtCliente.Hint = "Identificación del Cliente";
            this.txtCliente.Location = new System.Drawing.Point(50, 89);
            this.txtCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.PasswordChar = '\0';
            this.txtCliente.SelectedText = "";
            this.txtCliente.SelectionLength = 0;
            this.txtCliente.SelectionStart = 0;
            this.txtCliente.Size = new System.Drawing.Size(354, 23);
            this.txtCliente.TabIndex = 12;
            this.txtCliente.UseSystemPasswordChar = false;
            // 
            // txtNumFactura
            // 
            this.txtNumFactura.Depth = 0;
            this.txtNumFactura.Hint = "# Factura";
            this.txtNumFactura.Location = new System.Drawing.Point(50, 58);
            this.txtNumFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.PasswordChar = '\0';
            this.txtNumFactura.SelectedText = "";
            this.txtNumFactura.SelectionLength = 0;
            this.txtNumFactura.SelectionStart = 0;
            this.txtNumFactura.Size = new System.Drawing.Size(354, 23);
            this.txtNumFactura.TabIndex = 11;
            this.txtNumFactura.UseSystemPasswordChar = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(46, 22);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(114, 19);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Añadir Facturas";
            // 
            // txtFechaEmision
            // 
            this.txtFechaEmision.Depth = 0;
            this.txtFechaEmision.Hint = "Fecha de Emisión(DD/MM/YYYY)";
            this.txtFechaEmision.Location = new System.Drawing.Point(50, 148);
            this.txtFechaEmision.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFechaEmision.Name = "txtFechaEmision";
            this.txtFechaEmision.PasswordChar = '\0';
            this.txtFechaEmision.SelectedText = "";
            this.txtFechaEmision.SelectionLength = 0;
            this.txtFechaEmision.SelectionStart = 0;
            this.txtFechaEmision.Size = new System.Drawing.Size(354, 23);
            this.txtFechaEmision.TabIndex = 18;
            this.txtFechaEmision.UseSystemPasswordChar = false;
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Depth = 0;
            this.txtEmpleado.Hint = "Identificación del Empleado";
            this.txtEmpleado.Location = new System.Drawing.Point(50, 118);
            this.txtEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.PasswordChar = '\0';
            this.txtEmpleado.SelectedText = "";
            this.txtEmpleado.SelectionLength = 0;
            this.txtEmpleado.SelectionStart = 0;
            this.txtEmpleado.Size = new System.Drawing.Size(354, 23);
            this.txtEmpleado.TabIndex = 19;
            this.txtEmpleado.UseSystemPasswordChar = false;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Depth = 0;
            this.txtDescuento.Hint = "Descuento";
            this.txtDescuento.Location = new System.Drawing.Point(50, 233);
            this.txtDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.PasswordChar = '\0';
            this.txtDescuento.SelectedText = "";
            this.txtDescuento.SelectionLength = 0;
            this.txtDescuento.SelectionStart = 0;
            this.txtDescuento.Size = new System.Drawing.Size(354, 23);
            this.txtDescuento.TabIndex = 20;
            this.txtDescuento.UseSystemPasswordChar = false;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Depth = 0;
            this.txtImpuesto.Hint = "Impuesto";
            this.txtImpuesto.Location = new System.Drawing.Point(50, 263);
            this.txtImpuesto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.PasswordChar = '\0';
            this.txtImpuesto.SelectedText = "";
            this.txtImpuesto.SelectionLength = 0;
            this.txtImpuesto.SelectionStart = 0;
            this.txtImpuesto.Size = new System.Drawing.Size(354, 23);
            this.txtImpuesto.TabIndex = 21;
            this.txtImpuesto.UseSystemPasswordChar = false;
            // 
            // frmAnadirFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 367);
            this.Controls.Add(this.txtImpuesto);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.txtFechaEmision);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtNumFactura);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmAnadirFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAnadirFactura";
            this.Load += new System.EventHandler(this.frmEditarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnAnadir;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEstado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtValor;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumFactura;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFechaEmision;
        private System.Windows.Forms.ErrorProvider MensajeError;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtImpuesto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescuento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmpleado;
    }
}