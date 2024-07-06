namespace CallejonDiagon.Views
{
    partial class FrmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            this.pnlTareasUsuarios = new System.Windows.Forms.Panel();
            this.btnRetorno = new System.Windows.Forms.Button();
            this.btnStatusU = new System.Windows.Forms.Button();
            this.btnActualizarUsuario = new System.Windows.Forms.Button();
            this.btnRegistrarUsuario = new System.Windows.Forms.Button();
            this.pnlTituloUsuarios = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTrabajoUsuarios = new System.Windows.Forms.Panel();
            this.lbl_Tituloprin = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblMarcador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvListaUsuarios = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnlTareasUsuarios.SuspendLayout();
            this.pnlTituloUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTrabajoUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTareasUsuarios
            // 
            this.pnlTareasUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(124)))));
            this.pnlTareasUsuarios.Controls.Add(this.btnRetorno);
            this.pnlTareasUsuarios.Controls.Add(this.btnStatusU);
            this.pnlTareasUsuarios.Controls.Add(this.btnActualizarUsuario);
            this.pnlTareasUsuarios.Controls.Add(this.btnRegistrarUsuario);
            this.pnlTareasUsuarios.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTareasUsuarios.Location = new System.Drawing.Point(1378, 0);
            this.pnlTareasUsuarios.Name = "pnlTareasUsuarios";
            this.pnlTareasUsuarios.Size = new System.Drawing.Size(438, 1131);
            this.pnlTareasUsuarios.TabIndex = 0;
            // 
            // btnRetorno
            // 
            this.btnRetorno.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetorno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRetorno.Location = new System.Drawing.Point(57, 965);
            this.btnRetorno.Name = "btnRetorno";
            this.btnRetorno.Size = new System.Drawing.Size(322, 108);
            this.btnRetorno.TabIndex = 3;
            this.btnRetorno.Text = "Regresar";
            this.btnRetorno.UseVisualStyleBackColor = false;
            this.btnRetorno.Click += new System.EventHandler(this.btnRetorno_Click);
            // 
            // btnStatusU
            // 
            this.btnStatusU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStatusU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatusU.Location = new System.Drawing.Point(57, 653);
            this.btnStatusU.Name = "btnStatusU";
            this.btnStatusU.Size = new System.Drawing.Size(322, 108);
            this.btnStatusU.TabIndex = 2;
            this.btnStatusU.Text = "Estado Usuario";
            this.btnStatusU.UseVisualStyleBackColor = false;
            // 
            // btnActualizarUsuario
            // 
            this.btnActualizarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnActualizarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarUsuario.Location = new System.Drawing.Point(57, 446);
            this.btnActualizarUsuario.Name = "btnActualizarUsuario";
            this.btnActualizarUsuario.Size = new System.Drawing.Size(322, 108);
            this.btnActualizarUsuario.TabIndex = 1;
            this.btnActualizarUsuario.Text = "Modificar Usuario";
            this.btnActualizarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRegistrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(57, 243);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(322, 108);
            this.btnRegistrarUsuario.TabIndex = 0;
            this.btnRegistrarUsuario.Text = "Registrar Usuario";
            this.btnRegistrarUsuario.UseVisualStyleBackColor = false;
            this.btnRegistrarUsuario.Click += new System.EventHandler(this.btnRegistrarUsuario_Click);
            // 
            // pnlTituloUsuarios
            // 
            this.pnlTituloUsuarios.AutoSize = true;
            this.pnlTituloUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlTituloUsuarios.Controls.Add(this.pictureBox1);
            this.pnlTituloUsuarios.Controls.Add(this.lbl_Tituloprin);
            this.pnlTituloUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloUsuarios.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloUsuarios.Name = "pnlTituloUsuarios";
            this.pnlTituloUsuarios.Size = new System.Drawing.Size(1378, 196);
            this.pnlTituloUsuarios.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnlTrabajoUsuarios
            // 
            this.pnlTrabajoUsuarios.AutoScroll = true;
            this.pnlTrabajoUsuarios.Controls.Add(this.btnBuscar);
            this.pnlTrabajoUsuarios.Controls.Add(this.dgvListaUsuarios);
            this.pnlTrabajoUsuarios.Controls.Add(this.txtBuscar);
            this.pnlTrabajoUsuarios.Controls.Add(this.lblBuscar);
            this.pnlTrabajoUsuarios.Controls.Add(this.btnGuardar);
            this.pnlTrabajoUsuarios.Controls.Add(this.btnCancelar);
            this.pnlTrabajoUsuarios.Controls.Add(this.label3);
            this.pnlTrabajoUsuarios.Controls.Add(this.label2);
            this.pnlTrabajoUsuarios.Controls.Add(this.label1);
            this.pnlTrabajoUsuarios.Controls.Add(this.lblMarcador);
            this.pnlTrabajoUsuarios.Controls.Add(this.lblRol);
            this.pnlTrabajoUsuarios.Controls.Add(this.cbRol);
            this.pnlTrabajoUsuarios.Controls.Add(this.txtNombre);
            this.pnlTrabajoUsuarios.Controls.Add(this.lblNombre);
            this.pnlTrabajoUsuarios.Controls.Add(this.txtPassword);
            this.pnlTrabajoUsuarios.Controls.Add(this.lblPassword);
            this.pnlTrabajoUsuarios.Controls.Add(this.txtLogin);
            this.pnlTrabajoUsuarios.Controls.Add(this.lblLogin);
            this.pnlTrabajoUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTrabajoUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlTrabajoUsuarios.Location = new System.Drawing.Point(0, 196);
            this.pnlTrabajoUsuarios.Name = "pnlTrabajoUsuarios";
            this.pnlTrabajoUsuarios.Size = new System.Drawing.Size(1378, 935);
            this.pnlTrabajoUsuarios.TabIndex = 1;
            // 
            // lbl_Tituloprin
            // 
            this.lbl_Tituloprin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Tituloprin.AutoSize = true;
            this.lbl_Tituloprin.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tituloprin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Tituloprin.Location = new System.Drawing.Point(199, 66);
            this.lbl_Tituloprin.Name = "lbl_Tituloprin";
            this.lbl_Tituloprin.Size = new System.Drawing.Size(495, 64);
            this.lbl_Tituloprin.TabIndex = 2;
            this.lbl_Tituloprin.Text = "Gestión de Usuarios";
            this.lbl_Tituloprin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(74, 21);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(86, 33);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(79, 72);
            this.txtLogin.MaxLength = 20;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(343, 40);
            this.txtLogin.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(538, 76);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(375, 40);
            this.txtPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(532, 21);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(143, 33);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(74, 143);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(119, 33);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(79, 193);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(853, 40);
            this.txtNombre.TabIndex = 6;
            // 
            // cbRol
            // 
            this.cbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Location = new System.Drawing.Point(79, 317);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(853, 41);
            this.cbRol.TabIndex = 7;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(74, 272);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(203, 33);
            this.lblRol.TabIndex = 8;
            this.lblRol.Text = "Rol de usuario";
            // 
            // lblMarcador
            // 
            this.lblMarcador.AutoSize = true;
            this.lblMarcador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcador.ForeColor = System.Drawing.Color.Red;
            this.lblMarcador.Location = new System.Drawing.Point(46, 193);
            this.lblMarcador.Name = "lblMarcador";
            this.lblMarcador.Size = new System.Drawing.Size(27, 33);
            this.lblMarcador.TabIndex = 9;
            this.lblMarcador.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(505, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(46, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(46, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 33);
            this.label3.TabIndex = 12;
            this.label3.Text = "*";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(186, 397);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(246, 85);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(538, 397);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(228, 85);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(46, 556);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(106, 33);
            this.lblBuscar.TabIndex = 15;
            this.lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(158, 554);
            this.txtBuscar.MaxLength = 100;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(590, 40);
            this.txtBuscar.TabIndex = 16;
            // 
            // dgvListaUsuarios
            // 
            this.dgvListaUsuarios.AllowUserToAddRows = false;
            this.dgvListaUsuarios.AllowUserToDeleteRows = false;
            this.dgvListaUsuarios.AllowUserToOrderColumns = true;
            this.dgvListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaUsuarios.Location = new System.Drawing.Point(52, 611);
            this.dgvListaUsuarios.Name = "dgvListaUsuarios";
            this.dgvListaUsuarios.ReadOnly = true;
            this.dgvListaUsuarios.RowHeadersWidth = 82;
            this.dgvListaUsuarios.RowTemplate.Height = 33;
            this.dgvListaUsuarios.Size = new System.Drawing.Size(1282, 295);
            this.dgvListaUsuarios.TabIndex = 17;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(787, 550);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(171, 44);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1816, 1131);
            this.Controls.Add(this.pnlTrabajoUsuarios);
            this.Controls.Add(this.pnlTituloUsuarios);
            this.Controls.Add(this.pnlTareasUsuarios);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlTareasUsuarios.ResumeLayout(false);
            this.pnlTituloUsuarios.ResumeLayout(false);
            this.pnlTituloUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTrabajoUsuarios.ResumeLayout(false);
            this.pnlTrabajoUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTareasUsuarios;
        private System.Windows.Forms.Button btnRetorno;
        private System.Windows.Forms.Button btnStatusU;
        private System.Windows.Forms.Button btnActualizarUsuario;
        private System.Windows.Forms.Button btnRegistrarUsuario;
        private System.Windows.Forms.FlowLayoutPanel pnlTituloUsuarios;
        private System.Windows.Forms.Panel pnlTrabajoUsuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Tituloprin;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMarcador;
        private System.Windows.Forms.DataGridView dgvListaUsuarios;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnBuscar;
    }
}