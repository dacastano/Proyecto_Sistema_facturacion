
namespace Pantallas_Sistema_facturacion
{
    partial class frmEditarFactura
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
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEditar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtEstado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtValor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNumFactura = new System.Windows.Forms.TextBox();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.dtmEditFactura = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(287, 352);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(96, 34);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Depth = 0;
            this.btnEditar.Location = new System.Drawing.Point(50, 352);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Primary = true;
            this.btnEditar.Size = new System.Drawing.Size(96, 34);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // txtEstado
            // 
            this.txtEstado.Depth = 0;
            this.txtEstado.Hint = "Estado";
            this.txtEstado.Location = new System.Drawing.Point(50, 296);
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
            this.txtValor.Location = new System.Drawing.Point(50, 253);
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
            this.txtCliente.Location = new System.Drawing.Point(50, 166);
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
            // txtFactura
            // 
            this.txtFactura.Depth = 0;
            this.txtFactura.Hint = "# Factura";
            this.txtFactura.Location = new System.Drawing.Point(50, 126);
            this.txtFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.PasswordChar = '\0';
            this.txtFactura.SelectedText = "";
            this.txtFactura.SelectionLength = 0;
            this.txtFactura.SelectionStart = 0;
            this.txtFactura.Size = new System.Drawing.Size(354, 23);
            this.txtFactura.TabIndex = 11;
            this.txtFactura.UseSystemPasswordChar = false;
            // 
            // txtNumFactura
            // 
            this.txtNumFactura.Location = new System.Drawing.Point(50, 83);
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.Size = new System.Drawing.Size(61, 20);
            this.txtNumFactura.TabIndex = 10;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(85, 25);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(110, 19);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Editar Facturas";
            // 
            // dtmEditFactura
            // 
            this.dtmEditFactura.Location = new System.Drawing.Point(50, 214);
            this.dtmEditFactura.Name = "dtmEditFactura";
            this.dtmEditFactura.Size = new System.Drawing.Size(214, 20);
            this.dtmEditFactura.TabIndex = 18;
            // 
            // frmEditarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 416);
            this.Controls.Add(this.dtmEditFactura);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.txtNumFactura);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmEditarFactura";
            this.Text = "frmEditarFactura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEstado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtValor;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFactura;
        private System.Windows.Forms.TextBox txtNumFactura;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private System.Windows.Forms.DateTimePicker dtmEditFactura;
    }
}