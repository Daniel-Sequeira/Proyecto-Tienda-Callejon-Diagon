namespace CallejonDiagon.Views
{
    partial class FrmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            this.pnlTituloUsuarios = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Tituloprin = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.pnlTareasUsuarios = new System.Windows.Forms.Panel();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.btnRetorno = new System.Windows.Forms.Button();
            this.BtnEliminarProd = new System.Windows.Forms.Button();
            this.BtnEditarProd = new System.Windows.Forms.Button();
            this.BtnRegistrarProd = new System.Windows.Forms.Button();
            this.lblDescripcionProd = new System.Windows.Forms.Label();
            this.txtDescripcionprod = new System.Windows.Forms.TextBox();
            this.lblUniMedida = new System.Windows.Forms.Label();
            this.txtPrecioCosto = new System.Windows.Forms.TextBox();
            this.cbUniMedida = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.lblPrecioCosto = new System.Windows.Forms.Label();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.lblExistencias = new System.Windows.Forms.Label();
            this.txtExistencias = new System.Windows.Forms.TextBox();
            this.btnCancelarProd = new System.Windows.Forms.Button();
            this.btnGuardarProd = new System.Windows.Forms.Button();
            this.lblBuscarProd = new System.Windows.Forms.Label();
            this.txtBuscarProd = new System.Windows.Forms.TextBox();
            this.BtnBuscarProd = new System.Windows.Forms.Button();
            this.pnlTituloUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.pnlTareasUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTituloUsuarios
            // 
            this.pnlTituloUsuarios.AutoSize = true;
            this.pnlTituloUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlTituloUsuarios.Controls.Add(this.pictureBox1);
            this.pnlTituloUsuarios.Controls.Add(this.lbl_Tituloprin);
            this.pnlTituloUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloUsuarios.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloUsuarios.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pnlTituloUsuarios.Name = "pnlTituloUsuarios";
            this.pnlTituloUsuarios.Size = new System.Drawing.Size(1371, 145);
            this.pnlTituloUsuarios.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Tituloprin
            // 
            this.lbl_Tituloprin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Tituloprin.AutoSize = true;
            this.lbl_Tituloprin.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tituloprin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Tituloprin.Location = new System.Drawing.Point(153, 40);
            this.lbl_Tituloprin.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_Tituloprin.Name = "lbl_Tituloprin";
            this.lbl_Tituloprin.Size = new System.Drawing.Size(259, 64);
            this.lbl_Tituloprin.TabIndex = 2;
            this.lbl_Tituloprin.Text = "Productos";
            this.lbl_Tituloprin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(33, 160);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 82;
            this.dgvProductos.RowTemplate.Height = 33;
            this.dgvProductos.Size = new System.Drawing.Size(948, 219);
            this.dgvProductos.TabIndex = 2;
            this.dgvProductos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellEnter);
            // 
            // pnlTareasUsuarios
            // 
            this.pnlTareasUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(124)))));
            this.pnlTareasUsuarios.Controls.Add(this.BtnRegresar);
            this.pnlTareasUsuarios.Controls.Add(this.btnRetorno);
            this.pnlTareasUsuarios.Controls.Add(this.BtnEliminarProd);
            this.pnlTareasUsuarios.Controls.Add(this.BtnEditarProd);
            this.pnlTareasUsuarios.Controls.Add(this.BtnRegistrarProd);
            this.pnlTareasUsuarios.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTareasUsuarios.Location = new System.Drawing.Point(1050, 145);
            this.pnlTareasUsuarios.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pnlTareasUsuarios.Name = "pnlTareasUsuarios";
            this.pnlTareasUsuarios.Size = new System.Drawing.Size(321, 625);
            this.pnlTareasUsuarios.TabIndex = 6;
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRegresar.Location = new System.Drawing.Point(45, 470);
            this.BtnRegresar.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(253, 78);
            this.BtnRegresar.TabIndex = 4;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click_1);
            // 
            // btnRetorno
            // 
            this.btnRetorno.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetorno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRetorno.Location = new System.Drawing.Point(58, 1125);
            this.btnRetorno.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnRetorno.Name = "btnRetorno";
            this.btnRetorno.Size = new System.Drawing.Size(322, 108);
            this.btnRetorno.TabIndex = 3;
            this.btnRetorno.Text = "Regresar";
            this.btnRetorno.UseVisualStyleBackColor = false;
            // 
            // BtnEliminarProd
            // 
            this.BtnEliminarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnEliminarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarProd.Location = new System.Drawing.Point(45, 320);
            this.BtnEliminarProd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.BtnEliminarProd.Name = "BtnEliminarProd";
            this.BtnEliminarProd.Size = new System.Drawing.Size(244, 86);
            this.BtnEliminarProd.TabIndex = 2;
            this.BtnEliminarProd.Text = "Estado Producto";
            this.BtnEliminarProd.UseVisualStyleBackColor = false;
            this.BtnEliminarProd.Click += new System.EventHandler(this.BtnEliminarProd_Click);
            // 
            // BtnEditarProd
            // 
            this.BtnEditarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnEditarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarProd.Location = new System.Drawing.Point(45, 186);
            this.BtnEditarProd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.BtnEditarProd.Name = "BtnEditarProd";
            this.BtnEditarProd.Size = new System.Drawing.Size(244, 80);
            this.BtnEditarProd.TabIndex = 1;
            this.BtnEditarProd.Text = "Editar Producto";
            this.BtnEditarProd.UseVisualStyleBackColor = false;
            this.BtnEditarProd.Click += new System.EventHandler(this.BtnEditarProd_Click_1);
            // 
            // BtnRegistrarProd
            // 
            this.BtnRegistrarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnRegistrarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarProd.Location = new System.Drawing.Point(45, 61);
            this.BtnRegistrarProd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.BtnRegistrarProd.Name = "BtnRegistrarProd";
            this.BtnRegistrarProd.Size = new System.Drawing.Size(244, 79);
            this.BtnRegistrarProd.TabIndex = 0;
            this.BtnRegistrarProd.Text = "Registrar Producto";
            this.BtnRegistrarProd.UseVisualStyleBackColor = false;
            this.BtnRegistrarProd.Click += new System.EventHandler(this.BtnRegistrarProd_Click_1);
            // 
            // lblDescripcionProd
            // 
            this.lblDescripcionProd.AutoSize = true;
            this.lblDescripcionProd.Location = new System.Drawing.Point(29, 467);
            this.lblDescripcionProd.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblDescripcionProd.Name = "lblDescripcionProd";
            this.lblDescripcionProd.Size = new System.Drawing.Size(217, 25);
            this.lblDescripcionProd.TabIndex = 7;
            this.lblDescripcionProd.Text = "Descripcion Producto";
            // 
            // txtDescripcionprod
            // 
            this.txtDescripcionprod.Location = new System.Drawing.Point(33, 495);
            this.txtDescripcionprod.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtDescripcionprod.MaxLength = 200;
            this.txtDescripcionprod.Name = "txtDescripcionprod";
            this.txtDescripcionprod.Size = new System.Drawing.Size(251, 31);
            this.txtDescripcionprod.TabIndex = 8;
            // 
            // lblUniMedida
            // 
            this.lblUniMedida.AutoSize = true;
            this.lblUniMedida.Location = new System.Drawing.Point(29, 550);
            this.lblUniMedida.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblUniMedida.Name = "lblUniMedida";
            this.lblUniMedida.Size = new System.Drawing.Size(186, 25);
            this.lblUniMedida.TabIndex = 9;
            this.lblUniMedida.Text = "Unidad de medida";
            // 
            // txtPrecioCosto
            // 
            this.txtPrecioCosto.Location = new System.Drawing.Point(331, 597);
            this.txtPrecioCosto.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtPrecioCosto.MaxLength = 50;
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.Size = new System.Drawing.Size(251, 31);
            this.txtPrecioCosto.TabIndex = 10;
            // 
            // cbUniMedida
            // 
            this.cbUniMedida.FormattingEnabled = true;
            this.cbUniMedida.Location = new System.Drawing.Point(33, 586);
            this.cbUniMedida.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cbUniMedida.Name = "cbUniMedida";
            this.cbUniMedida.Size = new System.Drawing.Size(104, 33);
            this.cbUniMedida.TabIndex = 11;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(33, 633);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(105, 25);
            this.lblCategoria.TabIndex = 12;
            this.lblCategoria.Text = "Categoria";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(33, 669);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(130, 33);
            this.cbCategoria.TabIndex = 13;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(328, 467);
            this.lblProveedor.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(111, 25);
            this.lblProveedor.TabIndex = 14;
            this.lblProveedor.Text = "Proveedor";
            // 
            // cbProveedor
            // 
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(329, 507);
            this.cbProveedor.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(101, 33);
            this.cbProveedor.TabIndex = 15;
            // 
            // lblPrecioCosto
            // 
            this.lblPrecioCosto.AutoSize = true;
            this.lblPrecioCosto.Location = new System.Drawing.Point(328, 558);
            this.lblPrecioCosto.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPrecioCosto.Name = "lblPrecioCosto";
            this.lblPrecioCosto.Size = new System.Drawing.Size(129, 25);
            this.lblPrecioCosto.TabIndex = 16;
            this.lblPrecioCosto.Text = "PrecioCosto";
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Location = new System.Drawing.Point(328, 642);
            this.lblPrecioVenta.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(129, 25);
            this.lblPrecioVenta.TabIndex = 18;
            this.lblPrecioVenta.Text = "PrecioVenta";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(329, 680);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtPrecioVenta.MaxLength = 50;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(251, 31);
            this.txtPrecioVenta.TabIndex = 17;
            // 
            // lblExistencias
            // 
            this.lblExistencias.AutoSize = true;
            this.lblExistencias.Location = new System.Drawing.Point(535, 480);
            this.lblExistencias.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblExistencias.Name = "lblExistencias";
            this.lblExistencias.Size = new System.Drawing.Size(122, 25);
            this.lblExistencias.TabIndex = 19;
            this.lblExistencias.Text = "Existencias";
            // 
            // txtExistencias
            // 
            this.txtExistencias.Location = new System.Drawing.Point(539, 520);
            this.txtExistencias.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtExistencias.MaxLength = 50;
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(251, 31);
            this.txtExistencias.TabIndex = 20;
            // 
            // btnCancelarProd
            // 
            this.btnCancelarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCancelarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarProd.Location = new System.Drawing.Point(837, 650);
            this.btnCancelarProd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnCancelarProd.Name = "btnCancelarProd";
            this.btnCancelarProd.Size = new System.Drawing.Size(168, 61);
            this.btnCancelarProd.TabIndex = 21;
            this.btnCancelarProd.Text = "Cancelar";
            this.btnCancelarProd.UseVisualStyleBackColor = false;
            this.btnCancelarProd.Visible = false;
            this.btnCancelarProd.Click += new System.EventHandler(this.btnCancelarProd_Click_1);
            // 
            // btnGuardarProd
            // 
            this.btnGuardarProd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuardarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarProd.Location = new System.Drawing.Point(649, 649);
            this.btnGuardarProd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnGuardarProd.Name = "btnGuardarProd";
            this.btnGuardarProd.Size = new System.Drawing.Size(141, 62);
            this.btnGuardarProd.TabIndex = 22;
            this.btnGuardarProd.Text = "Guardar";
            this.btnGuardarProd.UseVisualStyleBackColor = false;
            this.btnGuardarProd.Visible = false;
            this.btnGuardarProd.Click += new System.EventHandler(this.btnGuardarProd_Click_1);
            // 
            // lblBuscarProd
            // 
            this.lblBuscarProd.AutoSize = true;
            this.lblBuscarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarProd.Location = new System.Drawing.Point(29, 406);
            this.lblBuscarProd.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblBuscarProd.Name = "lblBuscarProd";
            this.lblBuscarProd.Size = new System.Drawing.Size(106, 33);
            this.lblBuscarProd.TabIndex = 23;
            this.lblBuscarProd.Text = "Buscar";
            // 
            // txtBuscarProd
            // 
            this.txtBuscarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProd.Location = new System.Drawing.Point(146, 403);
            this.txtBuscarProd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtBuscarProd.MaxLength = 100;
            this.txtBuscarProd.Name = "txtBuscarProd";
            this.txtBuscarProd.Size = new System.Drawing.Size(413, 40);
            this.txtBuscarProd.TabIndex = 24;
            // 
            // BtnBuscarProd
            // 
            this.BtnBuscarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnBuscarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarProd.Location = new System.Drawing.Point(602, 403);
            this.BtnBuscarProd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.BtnBuscarProd.Name = "BtnBuscarProd";
            this.BtnBuscarProd.Size = new System.Drawing.Size(119, 44);
            this.BtnBuscarProd.TabIndex = 25;
            this.BtnBuscarProd.Text = "Buscar";
            this.BtnBuscarProd.UseVisualStyleBackColor = false;
            this.BtnBuscarProd.Click += new System.EventHandler(this.BtnBuscarProd_Click_1);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1371, 770);
            this.Controls.Add(this.BtnBuscarProd);
            this.Controls.Add(this.txtBuscarProd);
            this.Controls.Add(this.lblBuscarProd);
            this.Controls.Add(this.btnGuardarProd);
            this.Controls.Add(this.btnCancelarProd);
            this.Controls.Add(this.txtExistencias);
            this.Controls.Add(this.lblExistencias);
            this.Controls.Add(this.lblPrecioVenta);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.lblPrecioCosto);
            this.Controls.Add(this.cbProveedor);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cbUniMedida);
            this.Controls.Add(this.txtPrecioCosto);
            this.Controls.Add(this.lblUniMedida);
            this.Controls.Add(this.txtDescripcionprod);
            this.Controls.Add(this.lblDescripcionProd);
            this.Controls.Add(this.pnlTareasUsuarios);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.pnlTituloUsuarios);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.pnlTituloUsuarios.ResumeLayout(false);
            this.pnlTituloUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.pnlTareasUsuarios.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlTituloUsuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Tituloprin;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Panel pnlTareasUsuarios;
        private System.Windows.Forms.Button btnRetorno;
        private System.Windows.Forms.Button BtnEliminarProd;
        private System.Windows.Forms.Button BtnEditarProd;
        private System.Windows.Forms.Button BtnRegistrarProd;
        private System.Windows.Forms.Label lblDescripcionProd;
        private System.Windows.Forms.TextBox txtDescripcionprod;
        private System.Windows.Forms.Label lblUniMedida;
        private System.Windows.Forms.TextBox txtPrecioCosto;
        private System.Windows.Forms.ComboBox cbUniMedida;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Label lblPrecioCosto;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label lblExistencias;
        private System.Windows.Forms.TextBox txtExistencias;
        private System.Windows.Forms.Button btnCancelarProd;
        private System.Windows.Forms.Button btnGuardarProd;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Label lblBuscarProd;
        private System.Windows.Forms.TextBox txtBuscarProd;
        private System.Windows.Forms.Button BtnBuscarProd;
    }
}