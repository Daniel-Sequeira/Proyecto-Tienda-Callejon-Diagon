namespace CallejonDiagon.Views
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.pnlTituloUsuarios = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_TituloCliente = new System.Windows.Forms.Label();
            this.pnlTareasClientes = new System.Windows.Forms.Panel();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.btnRetorno = new System.Windows.Forms.Button();
            this.BtnEliminarCliente = new System.Windows.Forms.Button();
            this.BtnEditarCliente = new System.Windows.Forms.Button();
            this.BtnRegistrarCliente = new System.Windows.Forms.Button();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDireccionCliente = new System.Windows.Forms.Label();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTelefonoCliente = new System.Windows.Forms.Label();
            this.txtCorreoCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCorreoCliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblcedulaCliente = new System.Windows.Forms.Label();
            this.txtCedulaCliente = new System.Windows.Forms.TextBox();
            this.lblMarcador = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellidosCliente = new System.Windows.Forms.TextBox();
            this.lblApellidosCliente = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.pnlTituloUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTareasClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTituloUsuarios
            // 
            this.pnlTituloUsuarios.AutoSize = true;
            this.pnlTituloUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlTituloUsuarios.Controls.Add(this.pictureBox1);
            this.pnlTituloUsuarios.Controls.Add(this.lbl_TituloCliente);
            this.pnlTituloUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloUsuarios.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloUsuarios.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pnlTituloUsuarios.Name = "pnlTituloUsuarios";
            this.pnlTituloUsuarios.Size = new System.Drawing.Size(1326, 145);
            this.pnlTituloUsuarios.TabIndex = 3;
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
            // lbl_TituloCliente
            // 
            this.lbl_TituloCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TituloCliente.AutoSize = true;
            this.lbl_TituloCliente.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TituloCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_TituloCliente.Location = new System.Drawing.Point(153, 40);
            this.lbl_TituloCliente.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_TituloCliente.Name = "lbl_TituloCliente";
            this.lbl_TituloCliente.Size = new System.Drawing.Size(212, 64);
            this.lbl_TituloCliente.TabIndex = 2;
            this.lbl_TituloCliente.Text = "Clientes";
            this.lbl_TituloCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTareasClientes
            // 
            this.pnlTareasClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(124)))));
            this.pnlTareasClientes.Controls.Add(this.BtnRegresar);
            this.pnlTareasClientes.Controls.Add(this.btnRetorno);
            this.pnlTareasClientes.Controls.Add(this.BtnEliminarCliente);
            this.pnlTareasClientes.Controls.Add(this.BtnEditarCliente);
            this.pnlTareasClientes.Controls.Add(this.BtnRegistrarCliente);
            this.pnlTareasClientes.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTareasClientes.Location = new System.Drawing.Point(1005, 145);
            this.pnlTareasClientes.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pnlTareasClientes.Name = "pnlTareasClientes";
            this.pnlTareasClientes.Size = new System.Drawing.Size(321, 712);
            this.pnlTareasClientes.TabIndex = 8;
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRegresar.Location = new System.Drawing.Point(45, 575);
            this.BtnRegresar.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(253, 78);
            this.BtnRegresar.TabIndex = 4;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
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
            // BtnEliminarCliente
            // 
            this.BtnEliminarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnEliminarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarCliente.Location = new System.Drawing.Point(45, 320);
            this.BtnEliminarCliente.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.BtnEliminarCliente.Name = "BtnEliminarCliente";
            this.BtnEliminarCliente.Size = new System.Drawing.Size(244, 86);
            this.BtnEliminarCliente.TabIndex = 2;
            this.BtnEliminarCliente.Text = "Estado Cliente";
            this.BtnEliminarCliente.UseVisualStyleBackColor = false;
            this.BtnEliminarCliente.Click += new System.EventHandler(this.BtnEliminarCliente_Click);
            // 
            // BtnEditarCliente
            // 
            this.BtnEditarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnEditarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarCliente.Location = new System.Drawing.Point(45, 186);
            this.BtnEditarCliente.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.BtnEditarCliente.Name = "BtnEditarCliente";
            this.BtnEditarCliente.Size = new System.Drawing.Size(244, 80);
            this.BtnEditarCliente.TabIndex = 1;
            this.BtnEditarCliente.Text = "Editar Cliente";
            this.BtnEditarCliente.UseVisualStyleBackColor = false;
            this.BtnEditarCliente.Click += new System.EventHandler(this.BtnEditarCliente_Click);
            // 
            // BtnRegistrarCliente
            // 
            this.BtnRegistrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnRegistrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarCliente.Location = new System.Drawing.Point(45, 61);
            this.BtnRegistrarCliente.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.BtnRegistrarCliente.Name = "BtnRegistrarCliente";
            this.BtnRegistrarCliente.Size = new System.Drawing.Size(244, 79);
            this.BtnRegistrarCliente.TabIndex = 0;
            this.BtnRegistrarCliente.Text = "Registrar Cliente";
            this.BtnRegistrarCliente.UseVisualStyleBackColor = false;
            this.BtnRegistrarCliente.Click += new System.EventHandler(this.BtnRegistrarCliente_Click);
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionCliente.Location = new System.Drawing.Point(199, 444);
            this.txtDireccionCliente.MaxLength = 100;
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(457, 40);
            this.txtDireccionCliente.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(168, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 33);
            this.label1.TabIndex = 56;
            this.label1.Text = "*";
            // 
            // lblDireccionCliente
            // 
            this.lblDireccionCliente.AutoSize = true;
            this.lblDireccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionCliente.Location = new System.Drawing.Point(17, 444);
            this.lblDireccionCliente.Name = "lblDireccionCliente";
            this.lblDireccionCliente.Size = new System.Drawing.Size(138, 33);
            this.lblDireccionCliente.TabIndex = 55;
            this.lblDireccionCliente.Text = "Direccion";
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoCliente.Location = new System.Drawing.Point(199, 520);
            this.txtTelefonoCliente.MaxLength = 20;
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(457, 40);
            this.txtTelefonoCliente.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(168, 527);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 33);
            this.label8.TabIndex = 53;
            this.label8.Text = "*";
            // 
            // lblTelefonoCliente
            // 
            this.lblTelefonoCliente.AutoSize = true;
            this.lblTelefonoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoCliente.Location = new System.Drawing.Point(23, 518);
            this.lblTelefonoCliente.Name = "lblTelefonoCliente";
            this.lblTelefonoCliente.Size = new System.Drawing.Size(128, 33);
            this.lblTelefonoCliente.TabIndex = 52;
            this.lblTelefonoCliente.Text = "Teléfono";
            // 
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoCliente.Location = new System.Drawing.Point(199, 371);
            this.txtCorreoCliente.MaxLength = 100;
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.Size = new System.Drawing.Size(457, 40);
            this.txtCorreoCliente.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(168, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 33);
            this.label6.TabIndex = 50;
            this.label6.Text = "*";
            // 
            // lblCorreoCliente
            // 
            this.lblCorreoCliente.AutoSize = true;
            this.lblCorreoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoCliente.Location = new System.Drawing.Point(47, 374);
            this.lblCorreoCliente.Name = "lblCorreoCliente";
            this.lblCorreoCliente.Size = new System.Drawing.Size(104, 33);
            this.lblCorreoCliente.TabIndex = 49;
            this.lblCorreoCliente.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(166, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 33);
            this.label4.TabIndex = 48;
            this.label4.Text = "*";
            // 
            // lblcedulaCliente
            // 
            this.lblcedulaCliente.AutoSize = true;
            this.lblcedulaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcedulaCliente.Location = new System.Drawing.Point(44, 171);
            this.lblcedulaCliente.Name = "lblcedulaCliente";
            this.lblcedulaCliente.Size = new System.Drawing.Size(107, 33);
            this.lblcedulaCliente.TabIndex = 47;
            this.lblcedulaCliente.Text = "Cédula";
            // 
            // txtCedulaCliente
            // 
            this.txtCedulaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaCliente.Location = new System.Drawing.Point(199, 164);
            this.txtCedulaCliente.MaxLength = 20;
            this.txtCedulaCliente.Name = "txtCedulaCliente";
            this.txtCedulaCliente.Size = new System.Drawing.Size(457, 40);
            this.txtCedulaCliente.TabIndex = 46;
            // 
            // lblMarcador
            // 
            this.lblMarcador.AutoSize = true;
            this.lblMarcador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcador.ForeColor = System.Drawing.Color.Red;
            this.lblMarcador.Location = new System.Drawing.Point(166, 233);
            this.lblMarcador.Name = "lblMarcador";
            this.lblMarcador.Size = new System.Drawing.Size(27, 33);
            this.lblMarcador.TabIndex = 45;
            this.lblMarcador.Text = "*";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(199, 233);
            this.txtNombreCliente.MaxLength = 20;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(457, 40);
            this.txtNombreCliente.TabIndex = 44;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(32, 229);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(119, 33);
            this.lblNombreCliente.TabIndex = 43;
            this.lblNombreCliente.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(168, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 33);
            this.label2.TabIndex = 60;
            this.label2.Text = "*";
            // 
            // txtApellidosCliente
            // 
            this.txtApellidosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidosCliente.Location = new System.Drawing.Point(199, 292);
            this.txtApellidosCliente.MaxLength = 20;
            this.txtApellidosCliente.Name = "txtApellidosCliente";
            this.txtApellidosCliente.Size = new System.Drawing.Size(457, 40);
            this.txtApellidosCliente.TabIndex = 59;
            // 
            // lblApellidosCliente
            // 
            this.lblApellidosCliente.AutoSize = true;
            this.lblApellidosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidosCliente.Location = new System.Drawing.Point(17, 292);
            this.lblApellidosCliente.Name = "lblApellidosCliente";
            this.lblApellidosCliente.Size = new System.Drawing.Size(134, 33);
            this.lblApellidosCliente.TabIndex = 58;
            this.lblApellidosCliente.Text = "Apellidos";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(710, 211);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(246, 83);
            this.btnGuardar.TabIndex = 62;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(710, 336);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(246, 80);
            this.btnCancelar.TabIndex = 61;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 624);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 82;
            this.dgvClientes.RowTemplate.Height = 33;
            this.dgvClientes.Size = new System.Drawing.Size(968, 194);
            this.dgvClientes.TabIndex = 63;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 857);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApellidosCliente);
            this.Controls.Add(this.lblApellidosCliente);
            this.Controls.Add(this.txtDireccionCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDireccionCliente);
            this.Controls.Add(this.txtTelefonoCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTelefonoCliente);
            this.Controls.Add(this.txtCorreoCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCorreoCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblcedulaCliente);
            this.Controls.Add(this.txtCedulaCliente);
            this.Controls.Add(this.lblMarcador);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.pnlTareasClientes);
            this.Controls.Add(this.pnlTituloUsuarios);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.pnlTituloUsuarios.ResumeLayout(false);
            this.pnlTituloUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTareasClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlTituloUsuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_TituloCliente;
        private System.Windows.Forms.Panel pnlTareasClientes;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Button btnRetorno;
        private System.Windows.Forms.Button BtnEliminarCliente;
        private System.Windows.Forms.Button BtnEditarCliente;
        private System.Windows.Forms.Button BtnRegistrarCliente;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDireccionCliente;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTelefonoCliente;
        private System.Windows.Forms.TextBox txtCorreoCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCorreoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblcedulaCliente;
        private System.Windows.Forms.TextBox txtCedulaCliente;
        private System.Windows.Forms.Label lblMarcador;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellidosCliente;
        private System.Windows.Forms.Label lblApellidosCliente;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvClientes;
    }
}