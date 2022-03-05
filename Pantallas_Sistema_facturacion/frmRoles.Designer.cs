
namespace Pantallas_Sistema_facturacion
{
    partial class frmRoles
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
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscarRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDescripcionDetalladaRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombreEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(683, 376);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(103, 32);
            this.btnSalir.TabIndex = 52;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(683, 179);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(103, 32);
            this.btnEliminar.TabIndex = 51;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(683, 121);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(103, 32);
            this.btnActualizar.TabIndex = 50;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Location = new System.Drawing.Point(683, 67);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(103, 32);
            this.btnNuevo.TabIndex = 49;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Location = new System.Drawing.Point(515, 308);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(103, 32);
            this.btnBuscar.TabIndex = 48;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscarRol
            // 
            this.txtBuscarRol.Depth = 0;
            this.txtBuscarRol.Hint = "Buscar Rol";
            this.txtBuscarRol.Location = new System.Drawing.Point(41, 317);
            this.txtBuscarRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarRol.Name = "txtBuscarRol";
            this.txtBuscarRol.PasswordChar = '\0';
            this.txtBuscarRol.SelectedText = "";
            this.txtBuscarRol.SelectionLength = 0;
            this.txtBuscarRol.SelectionStart = 0;
            this.txtBuscarRol.Size = new System.Drawing.Size(449, 23);
            this.txtBuscarRol.TabIndex = 44;
            this.txtBuscarRol.UseSystemPasswordChar = false;
            // 
            // txtDescripcionDetalladaRol
            // 
            this.txtDescripcionDetalladaRol.Depth = 0;
            this.txtDescripcionDetalladaRol.Hint = "Descripción Detallada Rol";
            this.txtDescripcionDetalladaRol.Location = new System.Drawing.Point(41, 127);
            this.txtDescripcionDetalladaRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescripcionDetalladaRol.Name = "txtDescripcionDetalladaRol";
            this.txtDescripcionDetalladaRol.PasswordChar = '\0';
            this.txtDescripcionDetalladaRol.SelectedText = "";
            this.txtDescripcionDetalladaRol.SelectionLength = 0;
            this.txtDescripcionDetalladaRol.SelectionStart = 0;
            this.txtDescripcionDetalladaRol.Size = new System.Drawing.Size(255, 23);
            this.txtDescripcionDetalladaRol.TabIndex = 41;
            this.txtDescripcionDetalladaRol.UseSystemPasswordChar = false;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Depth = 0;
            this.txtNombreEmpleado.Hint = "Nombre Rol";
            this.txtNombreEmpleado.Location = new System.Drawing.Point(41, 69);
            this.txtNombreEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.PasswordChar = '\0';
            this.txtNombreEmpleado.SelectedText = "";
            this.txtNombreEmpleado.SelectionLength = 0;
            this.txtNombreEmpleado.SelectionStart = 0;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(255, 23);
            this.txtNombreEmpleado.TabIndex = 39;
            this.txtNombreEmpleado.UseSystemPasswordChar = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(253, 19);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(130, 19);
            this.lblTitulo.TabIndex = 38;
            this.lblTitulo.Text = "Rol de Empleados";
            // 
            // frmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 519);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarRol);
            this.Controls.Add(this.txtDescripcionDetalladaRol);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmRoles";
            this.Text = "frmRoles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarRol;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescripcionDetalladaRol;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreEmpleado;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
    }
}