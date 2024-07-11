namespace CallejonDiagon.Views
{
    partial class FrmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            this.pnlTituloUsuarios = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_TituloVentas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvProdFiltrados = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbCargaCategorias = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pnlTituloUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdFiltrados)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTituloUsuarios
            // 
            this.pnlTituloUsuarios.AutoSize = true;
            this.pnlTituloUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlTituloUsuarios.Controls.Add(this.pictureBox1);
            this.pnlTituloUsuarios.Controls.Add(this.lbl_TituloVentas);
            this.pnlTituloUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloUsuarios.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloUsuarios.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pnlTituloUsuarios.Name = "pnlTituloUsuarios";
            this.pnlTituloUsuarios.Size = new System.Drawing.Size(1472, 118);
            this.pnlTituloUsuarios.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_TituloVentas
            // 
            this.lbl_TituloVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TituloVentas.AutoSize = true;
            this.lbl_TituloVentas.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TituloVentas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_TituloVentas.Location = new System.Drawing.Point(153, 27);
            this.lbl_TituloVentas.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_TituloVentas.Name = "lbl_TituloVentas";
            this.lbl_TituloVentas.Size = new System.Drawing.Size(200, 64);
            this.lbl_TituloVentas.TabIndex = 2;
            this.lbl_TituloVentas.Text = "Ventas";
            this.lbl_TituloVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1082, 759);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1209, 759);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 55);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgvProdFiltrados
            // 
            this.dgvProdFiltrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdFiltrados.Location = new System.Drawing.Point(373, 146);
            this.dgvProdFiltrados.Name = "dgvProdFiltrados";
            this.dgvProdFiltrados.RowHeadersWidth = 82;
            this.dgvProdFiltrados.RowTemplate.Height = 33;
            this.dgvProdFiltrados.Size = new System.Drawing.Size(1068, 243);
            this.dgvProdFiltrados.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1338, 759);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 55);
            this.button3.TabIndex = 9;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(7, 146);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(116, 25);
            this.lblCategoria.TabIndex = 11;
            this.lblCategoria.Text = "Categorias";
            // 
            // cbCargaCategorias
            // 
            this.cbCargaCategorias.FormattingEnabled = true;
            this.cbCargaCategorias.Location = new System.Drawing.Point(12, 188);
            this.cbCargaCategorias.Name = "cbCargaCategorias";
            this.cbCargaCategorias.Size = new System.Drawing.Size(317, 33);
            this.cbCargaCategorias.TabIndex = 12;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(12, 249);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(98, 25);
            this.lblCantidad.TabIndex = 13;
            this.lblCantidad.Text = "Cantidad";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 294);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(131, 33);
            this.comboBox2.TabIndex = 14;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 837);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cbCargaCategorias);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvProdFiltrados);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlTituloUsuarios);
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.pnlTituloUsuarios.ResumeLayout(false);
            this.pnlTituloUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdFiltrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlTituloUsuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_TituloVentas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvProdFiltrados;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbCargaCategorias;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}