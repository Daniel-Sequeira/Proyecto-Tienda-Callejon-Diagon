using CallejonDiagon.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallejonDiagon.Views
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.btn_Iniciar, "Iniciar sesion");
            this.toolTip1.SetToolTip(this.btn_Salir, "Salir del Sistema");
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        #region "Metod"
        private void Logout(object sender, FormClosedEventArgs e)
        {
            this.txt_Login.Text = "";
            this.txt_Password.Text = "";
            this.txt_Login.Select();
        
        }

        #endregion

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            DataTable TablaLogin = new DataTable();
            D_User Datos = new D_User();
            TablaLogin = Datos.LoginUs(txt_Login.Text,txt_Password.Text);
            if(TablaLogin.Rows.Count > 0)
            {
               Frm_principal oFrm_Principal = new Frm_principal();
                oFrm_Principal.nIdEmpleado = Convert.ToInt32(TablaLogin.Rows[0][0]);
                oFrm_Principal.cLoginUs = Convert.ToString(TablaLogin.Rows[0][1]);
                oFrm_Principal.cNombreEmpleado = Convert.ToString(TablaLogin.Rows[0][2]);
                oFrm_Principal.cDescripcionRol = Convert.ToString(TablaLogin.Rows[0][3]);
                oFrm_Principal.nIdRol = Convert.ToInt32(TablaLogin.Rows[0][4]);
                oFrm_Principal.Show();
                oFrm_Principal.FormClosed += Logout;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login o Password Incorrecto", "Aviso del Sistema",
                    MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
    }
}
