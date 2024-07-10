namespace CallejonDiagon.Views
{
    partial class FrmCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategorias));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTituloUsuarios = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_TituloCat = new System.Windows.Forms.Label();
            this.pnlTareasUsuarios = new System.Windows.Forms.Panel();
            this.BtnRetornoCat = new System.Windows.Forms.Button();
            this.BtnStatusCat = new System.Windows.Forms.Button();
            this.BtnModificarCat = new System.Windows.Forms.Button();
            this.BtnRegistrarCat = new System.Windows.Forms.Button();
            this.txtDescCat = new System.Windows.Forms.TextBox();
            this.lblDescCat = new System.Windows.Forms.Label();
            this.BtnGuardarCat = new System.Windows.Forms.Button();
            this.BtnCancelarCat = new System.Windows.Forms.Button();
            this.dgvListaCategorias = new System.Windows.Forms.DataGridView();
            this.pnlTituloUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTareasUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTituloUsuarios
            // 
            this.pnlTituloUsuarios.AutoSize = true;
            this.pnlTituloUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlTituloUsuarios.Controls.Add(this.pictureBox1);
            this.pnlTituloUsuarios.Controls.Add(this.lbl_TituloCat);
            this.pnlTituloUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloUsuarios.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloUsuarios.Name = "pnlTituloUsuarios";
            this.pnlTituloUsuarios.Size = new System.Drawing.Size(1660, 197);
            this.pnlTituloUsuarios.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_TituloCat
            // 
            this.lbl_TituloCat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TituloCat.AutoSize = true;
            this.lbl_TituloCat.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TituloCat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_TituloCat.Location = new System.Drawing.Point(199, 66);
            this.lbl_TituloCat.Name = "lbl_TituloCat";
            this.lbl_TituloCat.Size = new System.Drawing.Size(270, 64);
            this.lbl_TituloCat.TabIndex = 2;
            this.lbl_TituloCat.Text = "Categorias";
            this.lbl_TituloCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTareasUsuarios
            // 
            this.pnlTareasUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(124)))));
            this.pnlTareasUsuarios.Controls.Add(this.BtnRetornoCat);
            this.pnlTareasUsuarios.Controls.Add(this.BtnStatusCat);
            this.pnlTareasUsuarios.Controls.Add(this.BtnModificarCat);
            this.pnlTareasUsuarios.Controls.Add(this.BtnRegistrarCat);
            this.pnlTareasUsuarios.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTareasUsuarios.Location = new System.Drawing.Point(1222, 197);
            this.pnlTareasUsuarios.Name = "pnlTareasUsuarios";
            this.pnlTareasUsuarios.Size = new System.Drawing.Size(438, 635);
            this.pnlTareasUsuarios.TabIndex = 2;
            // 
            // BtnRetornoCat
            // 
            this.BtnRetornoCat.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnRetornoCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRetornoCat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRetornoCat.Location = new System.Drawing.Point(57, 495);
            this.BtnRetornoCat.Name = "BtnRetornoCat";
            this.BtnRetornoCat.Size = new System.Drawing.Size(322, 84);
            this.BtnRetornoCat.TabIndex = 3;
            this.BtnRetornoCat.Text = "Regresar";
            this.BtnRetornoCat.UseVisualStyleBackColor = false;
            this.BtnRetornoCat.Click += new System.EventHandler(this.BtnRetornoCat_Click);
            // 
            // BtnStatusCat
            // 
            this.BtnStatusCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnStatusCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStatusCat.Location = new System.Drawing.Point(57, 301);
            this.BtnStatusCat.Name = "BtnStatusCat";
            this.BtnStatusCat.Size = new System.Drawing.Size(322, 80);
            this.BtnStatusCat.TabIndex = 2;
            this.BtnStatusCat.Text = "Estado Categoria";
            this.BtnStatusCat.UseVisualStyleBackColor = false;
            this.BtnStatusCat.Click += new System.EventHandler(this.BtnStatusCat_Click);
            // 
            // BtnModificarCat
            // 
            this.BtnModificarCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnModificarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarCat.Location = new System.Drawing.Point(57, 156);
            this.BtnModificarCat.Name = "BtnModificarCat";
            this.BtnModificarCat.Size = new System.Drawing.Size(322, 87);
            this.BtnModificarCat.TabIndex = 1;
            this.BtnModificarCat.Text = "Modificar Categoria";
            this.BtnModificarCat.UseVisualStyleBackColor = false;
            this.BtnModificarCat.Click += new System.EventHandler(this.BtnModificarCat_Click);
            // 
            // BtnRegistrarCat
            // 
            this.BtnRegistrarCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnRegistrarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarCat.Location = new System.Drawing.Point(57, 36);
            this.BtnRegistrarCat.Name = "BtnRegistrarCat";
            this.BtnRegistrarCat.Size = new System.Drawing.Size(322, 83);
            this.BtnRegistrarCat.TabIndex = 0;
            this.BtnRegistrarCat.Text = "Registrar Categoria";
            this.BtnRegistrarCat.UseVisualStyleBackColor = false;
            this.BtnRegistrarCat.Click += new System.EventHandler(this.BtnRegistrarCat_Click);
            // 
            // txtDescCat
            // 
            this.txtDescCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescCat.Location = new System.Drawing.Point(374, 270);
            this.txtDescCat.MaxLength = 50;
            this.txtDescCat.Name = "txtDescCat";
            this.txtDescCat.Size = new System.Drawing.Size(457, 40);
            this.txtDescCat.TabIndex = 20;
            // 
            // lblDescCat
            // 
            this.lblDescCat.AutoSize = true;
            this.lblDescCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescCat.Location = new System.Drawing.Point(49, 273);
            this.lblDescCat.Name = "lblDescCat";
            this.lblDescCat.Size = new System.Drawing.Size(303, 33);
            this.lblDescCat.TabIndex = 22;
            this.lblDescCat.Text = "Descripcion Categoria";
            // 
            // BtnGuardarCat
            // 
            this.BtnGuardarCat.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnGuardarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarCat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGuardarCat.Location = new System.Drawing.Point(925, 498);
            this.BtnGuardarCat.Name = "BtnGuardarCat";
            this.BtnGuardarCat.Size = new System.Drawing.Size(246, 83);
            this.BtnGuardarCat.TabIndex = 26;
            this.BtnGuardarCat.Text = "Guardar";
            this.BtnGuardarCat.UseVisualStyleBackColor = false;
            this.BtnGuardarCat.Visible = false;
            this.BtnGuardarCat.Click += new System.EventHandler(this.BtnGuardarCat_Click);
            // 
            // BtnCancelarCat
            // 
            this.BtnCancelarCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnCancelarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarCat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancelarCat.Location = new System.Drawing.Point(925, 637);
            this.BtnCancelarCat.Name = "BtnCancelarCat";
            this.BtnCancelarCat.Size = new System.Drawing.Size(246, 80);
            this.BtnCancelarCat.TabIndex = 25;
            this.BtnCancelarCat.Text = "Cancelar";
            this.BtnCancelarCat.UseVisualStyleBackColor = false;
            this.BtnCancelarCat.Visible = false;
            this.BtnCancelarCat.Click += new System.EventHandler(this.BtnCancelarCat_Click);
            // 
            // dgvListaCategorias
            // 
            this.dgvListaCategorias.AllowUserToAddRows = false;
            this.dgvListaCategorias.AllowUserToDeleteRows = false;
            this.dgvListaCategorias.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaCategorias.ColumnHeadersHeight = 40;
            this.dgvListaCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaCategorias.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaCategorias.EnableHeadersVisualStyles = false;
            this.dgvListaCategorias.Location = new System.Drawing.Point(68, 462);
            this.dgvListaCategorias.Name = "dgvListaCategorias";
            this.dgvListaCategorias.ReadOnly = true;
            this.dgvListaCategorias.RowHeadersWidth = 82;
            this.dgvListaCategorias.RowTemplate.Height = 33;
            this.dgvListaCategorias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListaCategorias.Size = new System.Drawing.Size(763, 255);
            this.dgvListaCategorias.TabIndex = 27;
            this.dgvListaCategorias.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaCategorias_CellEnter);
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1660, 832);
            this.Controls.Add(this.dgvListaCategorias);
            this.Controls.Add(this.BtnGuardarCat);
            this.Controls.Add(this.BtnCancelarCat);
            this.Controls.Add(this.lblDescCat);
            this.Controls.Add(this.txtDescCat);
            this.Controls.Add(this.pnlTareasUsuarios);
            this.Controls.Add(this.pnlTituloUsuarios);
            this.Name = "FrmCategorias";
            this.Text = "FrmCategorias";
            this.Load += new System.EventHandler(this.FrmCategorias_Load);
            this.pnlTituloUsuarios.ResumeLayout(false);
            this.pnlTituloUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTareasUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlTituloUsuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_TituloCat;
        private System.Windows.Forms.Panel pnlTareasUsuarios;
        private System.Windows.Forms.Button BtnRetornoCat;
        private System.Windows.Forms.Button BtnStatusCat;
        private System.Windows.Forms.Button BtnModificarCat;
        private System.Windows.Forms.Button BtnRegistrarCat;
        private System.Windows.Forms.TextBox txtDescCat;
        private System.Windows.Forms.Label lblDescCat;
        private System.Windows.Forms.Button BtnGuardarCat;
        private System.Windows.Forms.Button BtnCancelarCat;
        private System.Windows.Forms.DataGridView dgvListaCategorias;
    }
}