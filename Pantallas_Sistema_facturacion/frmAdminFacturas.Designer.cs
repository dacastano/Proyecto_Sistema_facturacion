
namespace Pantallas_Sistema_facturacion
{
    partial class frmAdminFacturas
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
            this.dgFacturas = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.numFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMISION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNuevo = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(717, 395);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(92, 33);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgFacturas
            // 
            this.dgFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numFactura,
            this.CLIENTE,
            this.EMISION,
            this.VALOR,
            this.ESTADO,
            this.btnBorrar,
            this.btnNuevo});
            this.dgFacturas.Location = new System.Drawing.Point(35, 112);
            this.dgFacturas.Name = "dgFacturas";
            this.dgFacturas.Size = new System.Drawing.Size(789, 208);
            this.dgFacturas.TabIndex = 10;
            this.dgFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFacturas_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Location = new System.Drawing.Point(519, 73);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(92, 33);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar Por # Factura";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "Buscar por Cliente";
            this.txtBuscar.Location = new System.Drawing.Point(35, 73);
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(360, 23);
            this.txtBuscar.TabIndex = 7;
            this.txtBuscar.UseSystemPasswordChar = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(308, 23);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(193, 19);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Administracion de Facturas";
            // 
            // numFactura
            // 
            this.numFactura.HeaderText = "NRO. FACTURA";
            this.numFactura.Name = "numFactura";
            // 
            // CLIENTE
            // 
            this.CLIENTE.HeaderText = "CLIENTE";
            this.CLIENTE.Name = "CLIENTE";
            // 
            // EMISION
            // 
            this.EMISION.HeaderText = "EMISION";
            this.EMISION.Name = "EMISION";
            // 
            // VALOR
            // 
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            // 
            // btnBorrar
            // 
            this.btnBorrar.HeaderText = "BORRAR";
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseColumnTextForButtonValue = true;
            this.btnBorrar.Width = 80;
            // 
            // btnNuevo
            // 
            this.btnNuevo.HeaderText = "NUEVO";
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseColumnTextForButtonValue = true;
            this.btnNuevo.Width = 80;
            // 
            // frmAdminFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 453);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgFacturas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmAdminFacturas";
            this.Text = "frmAdminFacturas";
            this.Load += new System.EventHandler(this.frmAdminFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.DataGridView dgFacturas;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMISION;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
        private System.Windows.Forms.DataGridViewButtonColumn btnNuevo;
    }
}