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
    public partial class Frm_principal : Form
    {
        public Frm_principal()
        {
            InitializeComponent();
        }

        #region "Variables"
        internal int nIdEmpleado {  get; set; }
        internal string cLoginUs {  get; set; }
        internal string cNombreEmpleado { get; set; }
        internal string cDescripcionRol { get;set; }
        internal int nIdRol { get; set; }



        #endregion

        private void Frm_principal_Load(object sender, EventArgs e)
        {
            lblLoginUs.Text = "Login: "+cLoginUs;
            lbl_DescRol.Text = cDescripcionRol;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion= MessageBox.Show("Desea salir de la Aplicación?", "Aviso del Sistema", MessageBoxButtons.OKCancel,
                                      MessageBoxIcon.Question);
            if (Opcion == DialogResult.OK) 
            {
                this.Close();
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (nIdRol == 1)
            {
                FrmUsuarios oFrmUsuarios = new FrmUsuarios();
                oFrmUsuarios.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Acceso Denegado--Requiere Privilegios de Acceso Administrador", "Aviso del Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos oFrmProductos = new FrmProductos();
            oFrmProductos.ShowDialog();
        }
    }
}
