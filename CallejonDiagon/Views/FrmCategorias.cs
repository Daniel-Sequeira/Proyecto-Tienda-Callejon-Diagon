using CallejonDiagon.Data;
using CallejonDiagon.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallejonDiagon.Views
{
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }
        #region "Variables"//////////////////////////////////

        int nIdCategoria = 0;
        int nEstadoCat = 0;

        #endregion/////////////////////////////////////////


        #region"Metodos Us"//////////////////////////////////

        private void LimpiaTextoCat()
        {
            txtDescCat.Text = "";
          
        }
        private void EstadoTextoCat(bool lEstado)
        {
            
            txtDescCat.Enabled = lEstado;
        }

        private void EstadoBtnProcesos(bool lEstado)
        {
            BtnGuardarCat.Visible = lEstado;
            BtnCancelarCat.Visible= lEstado;
        }

        private void EstadoBtnPrincipales(bool lEstado)
        {
            BtnModificarCat.Enabled = lEstado;
            BtnStatusCat.Enabled = lEstado;
           
        }
        private void FormatoDGVCat()
        {
            dgvListaCategorias.Columns[0].Width = 120;
            dgvListaCategorias.Columns[0].HeaderText = "DESCRIPCION";
            dgvListaCategorias.Columns[1].Width = 65;
            dgvListaCategorias.Columns[1].HeaderText = "ID_CAT";
       
            
           
        }
        private void ListadoCate(string cTexto)
        {
            D_Categorias Datos = new D_Categorias();
            dgvListaCategorias.DataSource = Datos.ListaCategorias(cTexto);
            this.FormatoDGVCat();

        }
        private void SeleccionaItem()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgvListaCategorias.CurrentRow.Cells["idCategoria"].Value)))
            {
                MessageBox.Show("Selecione un registro",
                "Aviso del Sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

            }
            else
            {
                nIdCategoria = Convert.ToInt32(dgvListaCategorias.CurrentRow.Cells["idCategoria"].Value);
                txtDescCat.Text = dgvListaCategorias.CurrentRow.Cells["descripcion"].Value.ToString();
            



            }

        }
        #endregion////////////////////////////////////////

        private void BtnRetornoCat_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void BtnRegistrarCat_Click(object sender, EventArgs e)
        {
            nEstadoCat = 1;
            this.LimpiaTextoCat();
            this.EstadoTextoCat(true);
            this.EstadoBtnProcesos(true);
            this.EstadoBtnPrincipales(false);
            this.txtDescCat.Focus();
        }


        private void BtnGuardarCat_Click(object sender, EventArgs e)
        {
            if (txtDescCat.Text == string.Empty )
            {
                MessageBox.Show("Ingrese el dato requerido (*)",
                    "Aviso del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                string Respuesta;
                E_Categoria oPro = new E_Categoria();
                oPro.IdCategoria = nIdCategoria;
                oPro.Descripcion = txtDescCat.Text;
                D_Categorias Datos = new D_Categorias();
                Respuesta = Datos.GuardarCategorias(nEstadoCat, oPro);
                bool esNumero = int.TryParse(Respuesta, out int xCodigo);
                if (esNumero == true)
                {
                    nEstadoCat = 0;
                    nIdCategoria = 0;
                    this.LimpiaTextoCat();
                    this.EstadoTextoCat(false);
                    this.EstadoBtnProcesos(false);
                    this.EstadoBtnPrincipales(true);
                    this.ListadoCate("%");
                    MessageBox.Show("Datos Almacenados Correctamente con #" + Respuesta.Trim(),
                        "Aviso del Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }





            }
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            this.ListadoCate("%");
            this.EstadoTextoCat(true);
            
        }

      
        private void BtnModificarCat_Click(object sender, EventArgs e)
        {
            nEstadoCat = 2;
            this.EstadoTextoCat(true);
            this.EstadoBtnProcesos(true);
            this.EstadoBtnPrincipales(false);
            this.ListadoCate("%");
            this.txtDescCat.Focus();
        }

        private void dgvListaCategorias_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.SeleccionaItem();
        }

        private void BtnStatusCat_Click(object sender, EventArgs e)
        {
            if (dgvListaCategorias.Rows.Count > 0)
            {
                string Respuesta = "";
                D_Categorias Datos = new D_Categorias();
                Respuesta = Datos.ActivoCate(Convert.ToInt32(dgvListaCategorias.CurrentRow.Cells["idCategoria"].Value));
                if (Respuesta.Equals("OK"))
                {
                    
                    MessageBox.Show("Estado Actualizado Exitosamente",
                        "Aviso del Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    this.ListadoCate("%");
                }
                else
                {
                    MessageBox.Show(Respuesta, "Aviso del Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCancelarCat_Click(object sender, EventArgs e)
        {
            nEstadoCat = 0;
            this.LimpiaTextoCat();
            this.EstadoTextoCat(false);
            this.EstadoBtnProcesos(false);
            this.EstadoBtnPrincipales(true);
        }
    }
}
