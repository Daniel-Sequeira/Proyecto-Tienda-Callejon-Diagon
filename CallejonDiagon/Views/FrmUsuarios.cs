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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        #region "Variables"
        int nLoginUs = 0;
        int nEstadoGuarda = 0;


        #endregion


        #region"Metodos Us"

        private void LimpiaTexto()
        {
            txtLogin.Text = "";
            txtPassword.Text = "";
            txtNombre.Text = "";
            cbRol.Text = "";
        }
        private void EstadoTexto(bool lEstado)
        {
            txtLogin.Enabled = lEstado;
            txtPassword.Enabled = lEstado;
            txtNombre.Enabled = lEstado;
            cbRol.Enabled = lEstado;
        }

        private void EstadoBtnProcesos(bool lEstado) 
        {
            btnCancelar.Visible = lEstado;
            btnGuardar.Visible = lEstado; 
            
        }

        private void EstadoBtnPrincipales(bool lEstado) 
        {
            btnRegistrarUsuario.Enabled = lEstado;  
            btnActualizarUsuario.Enabled = lEstado;
            btnStatusU.Enabled = lEstado;
            btnRetorno.Enabled = lEstado;


        }
        #endregion

        private void btnRetorno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 1;
            this.LimpiaTexto();
            this.EstadoTexto(true);
            this.EstadoBtnProcesos(true);
            this.EstadoBtnPrincipales(false);
            this.txtLogin.Focus();  

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 0;
            this.LimpiaTexto();
            this.EstadoTexto(false);
            this.EstadoBtnProcesos(false);
            this.EstadoBtnPrincipales(true);
        }
    }



}
