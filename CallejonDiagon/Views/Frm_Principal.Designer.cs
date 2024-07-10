namespace CallejonDiagon.Views
{
    partial class Frm_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_principal));
            this.Pnl_opciones = new System.Windows.Forms.Panel();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnTienda = new System.Windows.Forms.Button();
            this.Pnl_superior = new System.Windows.Forms.Panel();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.lbl_Tituloprin = new System.Windows.Forms.Label();
            this.Pnl_inferior = new System.Windows.Forms.Panel();
            this.lbl_DescRol = new System.Windows.Forms.Label();
            this.lblLoginUs = new System.Windows.Forms.Label();
            this.Pnl_contenido = new System.Windows.Forms.Panel();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.Pnl_opciones.SuspendLayout();
            this.Pnl_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.Pnl_inferior.SuspendLayout();
            this.Pnl_contenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_opciones
            // 
            this.Pnl_opciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(124)))));
            this.Pnl_opciones.Controls.Add(this.btnHistorial);
            this.Pnl_opciones.Controls.Add(this.btnCerrar);
            this.Pnl_opciones.Controls.Add(this.btnUsuarios);
            this.Pnl_opciones.Controls.Add(this.btnTienda);
            this.Pnl_opciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnl_opciones.Location = new System.Drawing.Point(1537, 0);
            this.Pnl_opciones.Name = "Pnl_opciones";
            this.Pnl_opciones.Size = new System.Drawing.Size(398, 1183);
            this.Pnl_opciones.TabIndex = 0;
            // 
            // btnHistorial
            // 
            this.btnHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorial.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.ImageKey = "Historial.png";
            this.btnHistorial.ImageList = this.imageList1;
            this.btnHistorial.Location = new System.Drawing.Point(137, 867);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(164, 135);
            this.btnHistorial.TabIndex = 12;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHistorial.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "tienda.png");
            this.imageList1.Images.SetKeyName(1, "Productos.png");
            this.imageList1.Images.SetKeyName(2, "categorias.png");
            this.imageList1.Images.SetKeyName(3, "Clientes.png");
            this.imageList1.Images.SetKeyName(4, "Empleados.png");
            this.imageList1.Images.SetKeyName(5, "Historial.png");
            this.imageList1.Images.SetKeyName(6, "Mantenimiento.png");
            this.imageList1.Images.SetKeyName(7, "Proveedores.png");
            this.imageList1.Images.SetKeyName(8, "Ventas.png");
            this.imageList1.Images.SetKeyName(9, "Buscar.png");
            this.imageList1.Images.SetKeyName(10, "Compras.png");
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(97, 548);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(204, 86);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar Sesión";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(103, 322);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(204, 86);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "Gestión Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnTienda
            // 
            this.btnTienda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTienda.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTienda.ImageKey = "tienda.png";
            this.btnTienda.ImageList = this.imageList1;
            this.btnTienda.Location = new System.Drawing.Point(103, 88);
            this.btnTienda.Name = "btnTienda";
            this.btnTienda.Size = new System.Drawing.Size(208, 125);
            this.btnTienda.TabIndex = 0;
            this.btnTienda.Text = "Tienda";
            this.btnTienda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTienda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTienda.UseVisualStyleBackColor = true;
            // 
            // Pnl_superior
            // 
            this.Pnl_superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Pnl_superior.Controls.Add(this.pb_Logo);
            this.Pnl_superior.Controls.Add(this.lbl_Tituloprin);
            this.Pnl_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_superior.Location = new System.Drawing.Point(0, 0);
            this.Pnl_superior.Name = "Pnl_superior";
            this.Pnl_superior.Size = new System.Drawing.Size(1537, 184);
            this.Pnl_superior.TabIndex = 1;
            // 
            // pb_Logo
            // 
            this.pb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_Logo.Image")));
            this.pb_Logo.Location = new System.Drawing.Point(12, 3);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(187, 166);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logo.TabIndex = 2;
            this.pb_Logo.TabStop = false;
            // 
            // lbl_Tituloprin
            // 
            this.lbl_Tituloprin.AutoSize = true;
            this.lbl_Tituloprin.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tituloprin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Tituloprin.Location = new System.Drawing.Point(524, 58);
            this.lbl_Tituloprin.Name = "lbl_Tituloprin";
            this.lbl_Tituloprin.Size = new System.Drawing.Size(407, 64);
            this.lbl_Tituloprin.TabIndex = 1;
            this.lbl_Tituloprin.Text = "Callejón Diagon";
            this.lbl_Tituloprin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_inferior
            // 
            this.Pnl_inferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Pnl_inferior.Controls.Add(this.lbl_DescRol);
            this.Pnl_inferior.Controls.Add(this.lblLoginUs);
            this.Pnl_inferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_inferior.Location = new System.Drawing.Point(0, 1002);
            this.Pnl_inferior.Name = "Pnl_inferior";
            this.Pnl_inferior.Size = new System.Drawing.Size(1537, 181);
            this.Pnl_inferior.TabIndex = 2;
            // 
            // lbl_DescRol
            // 
            this.lbl_DescRol.AutoSize = true;
            this.lbl_DescRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescRol.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_DescRol.Location = new System.Drawing.Point(55, 80);
            this.lbl_DescRol.Name = "lbl_DescRol";
            this.lbl_DescRol.Size = new System.Drawing.Size(63, 31);
            this.lbl_DescRol.TabIndex = 1;
            this.lbl_DescRol.Text = "Rol:";
            // 
            // lblLoginUs
            // 
            this.lblLoginUs.AutoSize = true;
            this.lblLoginUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginUs.ForeColor = System.Drawing.Color.LightGray;
            this.lblLoginUs.Location = new System.Drawing.Point(30, 29);
            this.lblLoginUs.Name = "lblLoginUs";
            this.lblLoginUs.Size = new System.Drawing.Size(88, 31);
            this.lblLoginUs.TabIndex = 0;
            this.lblLoginUs.Text = "Login:";
            // 
            // Pnl_contenido
            // 
            this.Pnl_contenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(240)))));
            this.Pnl_contenido.Controls.Add(this.btnVentas);
            this.Pnl_contenido.Controls.Add(this.btnCompras);
            this.Pnl_contenido.Controls.Add(this.btnClientes);
            this.Pnl_contenido.Controls.Add(this.btnProveedores);
            this.Pnl_contenido.Controls.Add(this.btnCategorias);
            this.Pnl_contenido.Controls.Add(this.btnProductos);
            this.Pnl_contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_contenido.Location = new System.Drawing.Point(0, 184);
            this.Pnl_contenido.Name = "Pnl_contenido";
            this.Pnl_contenido.Size = new System.Drawing.Size(1537, 818);
            this.Pnl_contenido.TabIndex = 3;
            // 
            // btnVentas
            // 
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ImageKey = "Ventas.png";
            this.btnVentas.ImageList = this.imageList1;
            this.btnVentas.Location = new System.Drawing.Point(421, 457);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(240, 191);
            this.btnVentas.TabIndex = 11;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVentas.UseVisualStyleBackColor = true;
            // 
            // btnCompras
            // 
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ImageKey = "Compras.png";
            this.btnCompras.ImageList = this.imageList1;
            this.btnCompras.Location = new System.Drawing.Point(776, 475);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(240, 173);
            this.btnCompras.TabIndex = 10;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCompras.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ImageKey = "Clientes.png";
            this.btnClientes.ImageList = this.imageList1;
            this.btnClientes.Location = new System.Drawing.Point(61, 457);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(240, 191);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnProveedores
            // 
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedores.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ImageKey = "Proveedores.png";
            this.btnProveedores.ImageList = this.imageList1;
            this.btnProveedores.Location = new System.Drawing.Point(776, 101);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(240, 191);
            this.btnProveedores.TabIndex = 3;
            this.btnProveedores.Text = "Proveedor";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProveedores.UseVisualStyleBackColor = true;
            // 
            // btnCategorias
            // 
            this.btnCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategorias.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ImageKey = "categorias.png";
            this.btnCategorias.ImageList = this.imageList1;
            this.btnCategorias.Location = new System.Drawing.Point(421, 101);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(240, 191);
            this.btnCategorias.TabIndex = 2;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCategorias.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ImageKey = "Productos.png";
            this.btnProductos.ImageList = this.imageList1;
            this.btnProductos.Location = new System.Drawing.Point(61, 101);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(240, 191);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // Frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1935, 1183);
            this.Controls.Add(this.Pnl_contenido);
            this.Controls.Add(this.Pnl_inferior);
            this.Controls.Add(this.Pnl_superior);
            this.Controls.Add(this.Pnl_opciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Callejon_Diagon";
            this.Load += new System.EventHandler(this.Frm_principal_Load);
            this.Pnl_opciones.ResumeLayout(false);
            this.Pnl_superior.ResumeLayout(false);
            this.Pnl_superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.Pnl_inferior.ResumeLayout(false);
            this.Pnl_inferior.PerformLayout();
            this.Pnl_contenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_opciones;
        private System.Windows.Forms.Panel Pnl_superior;
        private System.Windows.Forms.Panel Pnl_inferior;
        private System.Windows.Forms.Panel Pnl_contenido;
        private System.Windows.Forms.Button btnTienda;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Label lblLoginUs;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Label lbl_Tituloprin;
        private System.Windows.Forms.Label lbl_DescRol;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnUsuarios;
    }
}