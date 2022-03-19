
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
            this.numFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMISION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNuevaFactura = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.txtBxNumFactura = new System.Windows.Forms.TextBox();
            this.txtBxIdCliente = new System.Windows.Forms.TextBox();
            this.txtBxValor = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.dtmAsofToday = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.btnEditar});
            this.dgFacturas.Location = new System.Drawing.Point(35, 112);
            this.dgFacturas.Name = "dgFacturas";
            this.dgFacturas.Size = new System.Drawing.Size(789, 208);
            this.dgFacturas.TabIndex = 10;
            this.dgFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFacturas_CellContentClick);
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
            // btnEditar
            // 
            this.btnEditar.HeaderText = "EDITAR";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseColumnTextForButtonValue = true;
            this.btnEditar.Width = 80;
            // 
            // btnNuevaFactura
            // 
            this.btnNuevaFactura.Depth = 0;
            this.btnNuevaFactura.Location = new System.Drawing.Point(498, 370);
            this.btnNuevaFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevaFactura.Name = "btnNuevaFactura";
            this.btnNuevaFactura.Primary = true;
            this.btnNuevaFactura.Size = new System.Drawing.Size(92, 33);
            this.btnNuevaFactura.TabIndex = 9;
            this.btnNuevaFactura.Text = "Nueva Factura";
            this.btnNuevaFactura.UseVisualStyleBackColor = true;
            this.btnNuevaFactura.Click += new System.EventHandler(this.btnNuevaFactura_Click);
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
            // txtBxNumFactura
            // 
            this.txtBxNumFactura.Location = new System.Drawing.Point(35, 353);
            this.txtBxNumFactura.Name = "txtBxNumFactura";
            this.txtBxNumFactura.Size = new System.Drawing.Size(100, 20);
            this.txtBxNumFactura.TabIndex = 12;
            // 
            // txtBxIdCliente
            // 
            this.txtBxIdCliente.Location = new System.Drawing.Point(151, 353);
            this.txtBxIdCliente.Name = "txtBxIdCliente";
            this.txtBxIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txtBxIdCliente.TabIndex = 13;
            // 
            // txtBxValor
            // 
            this.txtBxValor.Location = new System.Drawing.Point(98, 408);
            this.txtBxValor.Name = "txtBxValor";
            this.txtBxValor.Size = new System.Drawing.Size(100, 20);
            this.txtBxValor.TabIndex = 15;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(243, 408);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 16;
            // 
            // dtmAsofToday
            // 
            this.dtmAsofToday.Location = new System.Drawing.Point(258, 353);
            this.dtmAsofToday.Name = "dtmAsofToday";
            this.dtmAsofToday.Size = new System.Drawing.Size(208, 20);
            this.dtmAsofToday.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "# Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Id Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Fecha Emisión";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Estado";
            // 
            // frmAdminFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 453);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtmAsofToday);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtBxValor);
            this.Controls.Add(this.txtBxIdCliente);
            this.Controls.Add(this.txtBxNumFactura);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgFacturas);
            this.Controls.Add(this.btnNuevaFactura);
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
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevaFactura;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMISION;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.TextBox txtBxNumFactura;
        private System.Windows.Forms.TextBox txtBxIdCliente;
        private System.Windows.Forms.TextBox txtBxValor;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.DateTimePicker dtmAsofToday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}