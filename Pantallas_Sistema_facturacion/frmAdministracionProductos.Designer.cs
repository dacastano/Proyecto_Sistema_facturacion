
namespace Pantallas_Sistema_facturacion
{
    partial class frmAdministracionProductos
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
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.txtProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCodReferencia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecioCompra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtVenta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCantidadStock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtRutaImagen = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBuscarProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblCategoria = new MaterialSkin.Controls.MaterialLabel();
            this.lblDetallesProducto = new MaterialSkin.Controls.MaterialLabel();
            this.txtBxDetallesProducto = new System.Windows.Forms.TextBox();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(279, 28);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(204, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Administracion de Productos";
            // 
            // txtProducto
            // 
            this.txtProducto.Depth = 0;
            this.txtProducto.Hint = "Nombre Producto";
            this.txtProducto.Location = new System.Drawing.Point(67, 78);
            this.txtProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.PasswordChar = '\0';
            this.txtProducto.SelectedText = "";
            this.txtProducto.SelectionLength = 0;
            this.txtProducto.SelectionStart = 0;
            this.txtProducto.Size = new System.Drawing.Size(255, 23);
            this.txtProducto.TabIndex = 1;
            this.txtProducto.UseSystemPasswordChar = false;
            // 
            // txtCodReferencia
            // 
            this.txtCodReferencia.Depth = 0;
            this.txtCodReferencia.Hint = "Código de Referencia";
            this.txtCodReferencia.Location = new System.Drawing.Point(67, 107);
            this.txtCodReferencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodReferencia.Name = "txtCodReferencia";
            this.txtCodReferencia.PasswordChar = '\0';
            this.txtCodReferencia.SelectedText = "";
            this.txtCodReferencia.SelectionLength = 0;
            this.txtCodReferencia.SelectionStart = 0;
            this.txtCodReferencia.Size = new System.Drawing.Size(255, 23);
            this.txtCodReferencia.TabIndex = 2;
            this.txtCodReferencia.UseSystemPasswordChar = false;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Depth = 0;
            this.txtPrecioCompra.Hint = "Precio Compra";
            this.txtPrecioCompra.Location = new System.Drawing.Point(67, 136);
            this.txtPrecioCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.PasswordChar = '\0';
            this.txtPrecioCompra.SelectedText = "";
            this.txtPrecioCompra.SelectionLength = 0;
            this.txtPrecioCompra.SelectionStart = 0;
            this.txtPrecioCompra.Size = new System.Drawing.Size(255, 23);
            this.txtPrecioCompra.TabIndex = 3;
            this.txtPrecioCompra.UseSystemPasswordChar = false;
            // 
            // txtVenta
            // 
            this.txtVenta.Depth = 0;
            this.txtVenta.Hint = "Venta";
            this.txtVenta.Location = new System.Drawing.Point(67, 165);
            this.txtVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.PasswordChar = '\0';
            this.txtVenta.SelectedText = "";
            this.txtVenta.SelectionLength = 0;
            this.txtVenta.SelectionStart = 0;
            this.txtVenta.Size = new System.Drawing.Size(255, 23);
            this.txtVenta.TabIndex = 4;
            this.txtVenta.UseSystemPasswordChar = false;
            // 
            // txtCantidadStock
            // 
            this.txtCantidadStock.Depth = 0;
            this.txtCantidadStock.Hint = "Cantidad Stock";
            this.txtCantidadStock.Location = new System.Drawing.Point(67, 194);
            this.txtCantidadStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCantidadStock.Name = "txtCantidadStock";
            this.txtCantidadStock.PasswordChar = '\0';
            this.txtCantidadStock.SelectedText = "";
            this.txtCantidadStock.SelectionLength = 0;
            this.txtCantidadStock.SelectionStart = 0;
            this.txtCantidadStock.Size = new System.Drawing.Size(255, 23);
            this.txtCantidadStock.TabIndex = 5;
            this.txtCantidadStock.UseSystemPasswordChar = false;
            // 
            // txtRutaImagen
            // 
            this.txtRutaImagen.Depth = 0;
            this.txtRutaImagen.Hint = "Ruta Imagen";
            this.txtRutaImagen.Location = new System.Drawing.Point(507, 122);
            this.txtRutaImagen.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRutaImagen.Name = "txtRutaImagen";
            this.txtRutaImagen.PasswordChar = '\0';
            this.txtRutaImagen.SelectedText = "";
            this.txtRutaImagen.SelectionLength = 0;
            this.txtRutaImagen.SelectionStart = 0;
            this.txtRutaImagen.Size = new System.Drawing.Size(255, 23);
            this.txtRutaImagen.TabIndex = 7;
            this.txtRutaImagen.UseSystemPasswordChar = false;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Depth = 0;
            this.txtBuscarProducto.Hint = "Buscar Producto";
            this.txtBuscarProducto.Location = new System.Drawing.Point(67, 326);
            this.txtBuscarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.PasswordChar = '\0';
            this.txtBuscarProducto.SelectedText = "";
            this.txtBuscarProducto.SelectionLength = 0;
            this.txtBuscarProducto.SelectionStart = 0;
            this.txtBuscarProducto.Size = new System.Drawing.Size(449, 23);
            this.txtBuscarProducto.TabIndex = 8;
            this.txtBuscarProducto.UseSystemPasswordChar = false;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Depth = 0;
            this.lblCategoria.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCategoria.Location = new System.Drawing.Point(503, 82);
            this.lblCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(74, 19);
            this.lblCategoria.TabIndex = 9;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblDetallesProducto
            // 
            this.lblDetallesProducto.AutoSize = true;
            this.lblDetallesProducto.Depth = 0;
            this.lblDetallesProducto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDetallesProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDetallesProducto.Location = new System.Drawing.Point(503, 165);
            this.lblDetallesProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDetallesProducto.Name = "lblDetallesProducto";
            this.lblDetallesProducto.Size = new System.Drawing.Size(129, 19);
            this.lblDetallesProducto.TabIndex = 10;
            this.lblDetallesProducto.Text = "Detalles Producto";
            // 
            // txtBxDetallesProducto
            // 
            this.txtBxDetallesProducto.Location = new System.Drawing.Point(507, 194);
            this.txtBxDetallesProducto.Multiline = true;
            this.txtBxDetallesProducto.Name = "txtBxDetallesProducto";
            this.txtBxDetallesProducto.Size = new System.Drawing.Size(255, 92);
            this.txtBxDetallesProducto.TabIndex = 11;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Location = new System.Drawing.Point(591, 317);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(103, 32);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Location = new System.Drawing.Point(809, 82);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(103, 32);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(809, 136);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(103, 32);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(809, 194);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(103, 32);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(809, 391);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(103, 32);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmAdministracionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 512);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBxDetallesProducto);
            this.Controls.Add(this.lblDetallesProducto);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.txtRutaImagen);
            this.Controls.Add(this.txtCantidadStock);
            this.Controls.Add(this.txtVenta);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.txtCodReferencia);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmAdministracionProductos";
            this.Text = "frmAdministracionProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodReferencia;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioCompra;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtVenta;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCantidadStock;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRutaImagen;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarProducto;
        private MaterialSkin.Controls.MaterialLabel lblCategoria;
        private MaterialSkin.Controls.MaterialLabel lblDetallesProducto;
        private System.Windows.Forms.TextBox txtBxDetallesProducto;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
    }
}