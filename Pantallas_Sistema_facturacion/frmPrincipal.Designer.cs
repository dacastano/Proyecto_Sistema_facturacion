
namespace Pantallas_Sistema_facturacion
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.tbpMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.Principal = new System.Windows.Forms.TabPage();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Clientes = new System.Windows.Forms.TabPage();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnClientes = new System.Windows.Forms.Button();
            this.Facturación = new System.Windows.Forms.TabPage();
            this.btnInformes = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.Seguridad = new System.Windows.Forms.TabPage();
            this.btnSeguridad = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.Acerca = new System.Windows.Forms.TabPage();
            this.btnAcerca = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.tabOpcionesMenu = new MaterialSkin.Controls.MaterialTabSelector();
            this.panel1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.tbpMenu.SuspendLayout();
            this.Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Facturación.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Seguridad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.Acerca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlContenedor);
            this.panel1.Controls.Add(this.pnlMenu);
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 589);
            this.panel1.TabIndex = 0;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(200, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1000, 589);
            this.pnlContenedor.TabIndex = 1;
            this.pnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenedor_Paint);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.tbpMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 589);
            this.pnlMenu.TabIndex = 0;
            // 
            // tbpMenu
            // 
            this.tbpMenu.Controls.Add(this.Principal);
            this.tbpMenu.Controls.Add(this.Clientes);
            this.tbpMenu.Controls.Add(this.Facturación);
            this.tbpMenu.Controls.Add(this.Seguridad);
            this.tbpMenu.Controls.Add(this.Acerca);
            this.tbpMenu.Depth = 0;
            this.tbpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpMenu.Location = new System.Drawing.Point(0, 0);
            this.tbpMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbpMenu.Name = "tbpMenu";
            this.tbpMenu.SelectedIndex = 0;
            this.tbpMenu.Size = new System.Drawing.Size(200, 589);
            this.tbpMenu.TabIndex = 0;
            // 
            // Principal
            // 
            this.Principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Principal.Controls.Add(this.btnSalir);
            this.Principal.Controls.Add(this.pictureBox1);
            this.Principal.Location = new System.Drawing.Point(4, 22);
            this.Principal.Name = "Principal";
            this.Principal.Padding = new System.Windows.Forms.Padding(3);
            this.Principal.Size = new System.Drawing.Size(192, 563);
            this.Principal.TabIndex = 0;
            this.Principal.Text = "Principal";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 65);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(192, 51);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Clientes
            // 
            this.Clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Clientes.Controls.Add(this.btnCategorias);
            this.Clientes.Controls.Add(this.btnProductos);
            this.Clientes.Controls.Add(this.pictureBox2);
            this.Clientes.Controls.Add(this.btnClientes);
            this.Clientes.Location = new System.Drawing.Point(4, 22);
            this.Clientes.Name = "Clientes";
            this.Clientes.Padding = new System.Windows.Forms.Padding(3);
            this.Clientes.Size = new System.Drawing.Size(192, 563);
            this.Clientes.TabIndex = 1;
            this.Clientes.Text = "Clientes";
            // 
            // btnCategorias
            // 
            this.btnCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnCategorias.ForeColor = System.Drawing.Color.White;
            this.btnCategorias.Image = ((System.Drawing.Image)(resources.GetObject("btnCategorias.Image")));
            this.btnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.Location = new System.Drawing.Point(-3, 188);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(192, 51);
            this.btnCategorias.TabIndex = 5;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(-1, 131);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(192, 51);
            this.btnProductos.TabIndex = 4;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(189, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(-3, 74);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(192, 51);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // Facturación
            // 
            this.Facturación.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Facturación.Controls.Add(this.btnInformes);
            this.Facturación.Controls.Add(this.pictureBox3);
            this.Facturación.Controls.Add(this.btnFacturacion);
            this.Facturación.Location = new System.Drawing.Point(4, 22);
            this.Facturación.Name = "Facturación";
            this.Facturación.Size = new System.Drawing.Size(192, 563);
            this.Facturación.TabIndex = 2;
            this.Facturación.Text = "Facturación";
            // 
            // btnInformes
            // 
            this.btnInformes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformes.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnInformes.ForeColor = System.Drawing.Color.White;
            this.btnInformes.Image = ((System.Drawing.Image)(resources.GetObject("btnInformes.Image")));
            this.btnInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformes.Location = new System.Drawing.Point(-3, 131);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(192, 51);
            this.btnInformes.TabIndex = 7;
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = true;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(189, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnFacturacion.ForeColor = System.Drawing.Color.White;
            this.btnFacturacion.Image = ((System.Drawing.Image)(resources.GetObject("btnFacturacion.Image")));
            this.btnFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturacion.Location = new System.Drawing.Point(-5, 74);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(192, 51);
            this.btnFacturacion.TabIndex = 5;
            this.btnFacturacion.Text = "Facturas";
            this.btnFacturacion.UseVisualStyleBackColor = true;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // Seguridad
            // 
            this.Seguridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Seguridad.Controls.Add(this.btnSeguridad);
            this.Seguridad.Controls.Add(this.btnRoles);
            this.Seguridad.Controls.Add(this.pictureBox4);
            this.Seguridad.Controls.Add(this.btnEmpleados);
            this.Seguridad.Location = new System.Drawing.Point(4, 22);
            this.Seguridad.Name = "Seguridad";
            this.Seguridad.Size = new System.Drawing.Size(192, 563);
            this.Seguridad.TabIndex = 3;
            this.Seguridad.Text = "Seguridad";
            // 
            // btnSeguridad
            // 
            this.btnSeguridad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeguridad.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnSeguridad.ForeColor = System.Drawing.Color.White;
            this.btnSeguridad.Image = ((System.Drawing.Image)(resources.GetObject("btnSeguridad.Image")));
            this.btnSeguridad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeguridad.Location = new System.Drawing.Point(-5, 185);
            this.btnSeguridad.Name = "btnSeguridad";
            this.btnSeguridad.Size = new System.Drawing.Size(192, 51);
            this.btnSeguridad.TabIndex = 9;
            this.btnSeguridad.Text = "Seguridad";
            this.btnSeguridad.UseVisualStyleBackColor = true;
            this.btnSeguridad.Click += new System.EventHandler(this.btnSeguridad_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoles.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnRoles.ForeColor = System.Drawing.Color.White;
            this.btnRoles.Image = ((System.Drawing.Image)(resources.GetObject("btnRoles.Image")));
            this.btnRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoles.Location = new System.Drawing.Point(-3, 128);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(192, 51);
            this.btnRoles.TabIndex = 8;
            this.btnRoles.Text = "Roles";
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(189, 55);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Image")));
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(-5, 71);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(192, 51);
            this.btnEmpleados.TabIndex = 6;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // Acerca
            // 
            this.Acerca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Acerca.Controls.Add(this.btnAcerca);
            this.Acerca.Controls.Add(this.pictureBox5);
            this.Acerca.Controls.Add(this.btnAyuda);
            this.Acerca.Location = new System.Drawing.Point(4, 22);
            this.Acerca.Name = "Acerca";
            this.Acerca.Size = new System.Drawing.Size(192, 563);
            this.Acerca.TabIndex = 4;
            this.Acerca.Text = "Acerca";
            // 
            // btnAcerca
            // 
            this.btnAcerca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAcerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcerca.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnAcerca.ForeColor = System.Drawing.Color.White;
            this.btnAcerca.Image = ((System.Drawing.Image)(resources.GetObject("btnAcerca.Image")));
            this.btnAcerca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcerca.Location = new System.Drawing.Point(0, 131);
            this.btnAcerca.Name = "btnAcerca";
            this.btnAcerca.Size = new System.Drawing.Size(192, 51);
            this.btnAcerca.TabIndex = 10;
            this.btnAcerca.Text = "Acerca de ...";
            this.btnAcerca.UseVisualStyleBackColor = true;
            this.btnAcerca.Click += new System.EventHandler(this.btnAcerca_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(4, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(189, 55);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // btnAyuda
            // 
            this.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnAyuda.ForeColor = System.Drawing.Color.White;
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.Location = new System.Drawing.Point(-2, 74);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(192, 51);
            this.btnAyuda.TabIndex = 8;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // tabOpcionesMenu
            // 
            this.tabOpcionesMenu.BaseTabControl = this.tbpMenu;
            this.tabOpcionesMenu.Depth = 0;
            this.tabOpcionesMenu.Location = new System.Drawing.Point(273, 33);
            this.tabOpcionesMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabOpcionesMenu.Name = "tabOpcionesMenu";
            this.tabOpcionesMenu.Size = new System.Drawing.Size(553, 23);
            this.tabOpcionesMenu.TabIndex = 1;
            this.tabOpcionesMenu.Text = "materialTabSelector1";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.tabOpcionesMenu);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrincipal";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Facturación";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.tbpMenu.ResumeLayout(false);
            this.Principal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Clientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Facturación.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Seguridad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.Acerca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMenu;
        private MaterialSkin.Controls.MaterialTabControl tbpMenu;
        private System.Windows.Forms.TabPage Principal;
        private System.Windows.Forms.TabPage Clientes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage Facturación;
        private System.Windows.Forms.TabPage Seguridad;
        private System.Windows.Forms.TabPage Acerca;
        private MaterialSkin.Controls.MaterialTabSelector tabOpcionesMenu;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Button btnSeguridad;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnAcerca;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnAyuda;
    }
}