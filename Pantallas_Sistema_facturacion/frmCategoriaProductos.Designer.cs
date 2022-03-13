
namespace Pantallas_Sistema_facturacion
{
    partial class frmCategoriaProductos
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
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscarCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombreCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCodigoCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(437, 263);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(103, 32);
            this.btnSalir.TabIndex = 32;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(437, 183);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(103, 32);
            this.btnEliminar.TabIndex = 31;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(437, 125);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(103, 32);
            this.btnActualizar.TabIndex = 30;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Location = new System.Drawing.Point(437, 71);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(103, 32);
            this.btnNuevo.TabIndex = 29;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Location = new System.Drawing.Point(301, 166);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(103, 32);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtBuscarCategoria
            // 
            this.txtBuscarCategoria.Depth = 0;
            this.txtBuscarCategoria.Hint = "Buscar Categoria por ID";
            this.txtBuscarCategoria.Location = new System.Drawing.Point(37, 175);
            this.txtBuscarCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarCategoria.Name = "txtBuscarCategoria";
            this.txtBuscarCategoria.PasswordChar = '\0';
            this.txtBuscarCategoria.SelectedText = "";
            this.txtBuscarCategoria.SelectionLength = 0;
            this.txtBuscarCategoria.SelectionStart = 0;
            this.txtBuscarCategoria.Size = new System.Drawing.Size(258, 23);
            this.txtBuscarCategoria.TabIndex = 24;
            this.txtBuscarCategoria.UseSystemPasswordChar = false;
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Depth = 0;
            this.txtNombreCategoria.Hint = "Nombre Categoria";
            this.txtNombreCategoria.Location = new System.Drawing.Point(40, 109);
            this.txtNombreCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.PasswordChar = '\0';
            this.txtNombreCategoria.SelectedText = "";
            this.txtNombreCategoria.SelectionLength = 0;
            this.txtNombreCategoria.SelectionStart = 0;
            this.txtNombreCategoria.Size = new System.Drawing.Size(255, 23);
            this.txtNombreCategoria.TabIndex = 19;
            this.txtNombreCategoria.UseSystemPasswordChar = false;
            // 
            // txtCodigoCategoria
            // 
            this.txtCodigoCategoria.Depth = 0;
            this.txtCodigoCategoria.Hint = "Código Categoria";
            this.txtCodigoCategoria.Location = new System.Drawing.Point(40, 80);
            this.txtCodigoCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigoCategoria.Name = "txtCodigoCategoria";
            this.txtCodigoCategoria.PasswordChar = '\0';
            this.txtCodigoCategoria.SelectedText = "";
            this.txtCodigoCategoria.SelectionLength = 0;
            this.txtCodigoCategoria.SelectionStart = 0;
            this.txtCodigoCategoria.Size = new System.Drawing.Size(255, 23);
            this.txtCodigoCategoria.TabIndex = 18;
            this.txtCodigoCategoria.UseSystemPasswordChar = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(36, 34);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(167, 19);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "Categoria de Productos";
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // frmCategoriaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 365);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarCategoria);
            this.Controls.Add(this.txtNombreCategoria);
            this.Controls.Add(this.txtCodigoCategoria);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmCategoriaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCategoriaProductos";
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigoCategoria;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}