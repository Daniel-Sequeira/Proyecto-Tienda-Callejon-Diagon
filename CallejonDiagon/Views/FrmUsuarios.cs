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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            
        }

        #region "Variables"

        int nIdEmpleado = 0;
        int nEstadoGuarda = 0;

        #endregion




        #region"Metodos Us"

        private void LimpiaTexto()
        {
            txtCedula.Text = "";
            txtNombre.Text= "";
            txtApellidos.Text = "";
            txtLogin.Text = "";
            txtPassword.Text = "";
            txtCorreoEmp.Text = "";
            txtTelefonoEmp.Text = "";
            cbRol.Text = "";
        }
        private void EstadoTexto(bool lEstado)
        {
            txtCedula.Enabled = lEstado;
            txtNombre.Enabled = lEstado;
            txtApellidos.Enabled = lEstado;
            txtLogin.Enabled = lEstado;
            txtPassword.Enabled = lEstado;
            txtCorreoEmp.Enabled = lEstado;
            txtTelefonoEmp.Enabled = lEstado;
            cbRol.Enabled = lEstado;
            cbSalario.Enabled = lEstado;
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
        private void FormatoDGV()
        {
            dgvListaUsuarios.Columns[0].Width = 100;
            dgvListaUsuarios.Columns[0].HeaderText = "ID_EMPLEADO";
            dgvListaUsuarios.Columns[1].Width = 120;
            dgvListaUsuarios.Columns[1].HeaderText = "LOGIN";
            dgvListaUsuarios.Columns[2].Width = 150;
            dgvListaUsuarios.Columns[2].HeaderText = "NOMBRE_EMPLEADO";
            dgvListaUsuarios.Columns[3].Width = 150;
            dgvListaUsuarios.Columns[3].HeaderText = "ROL_EMPLEADO";
            dgvListaUsuarios.Columns[4].Width = 90;
            dgvListaUsuarios.Columns[4].HeaderText = "ESTADO";
            dgvListaUsuarios.Columns[5].Visible = false;
        }
        private void ListadoUs(string cTexto)
        {
            D_User Datos = new D_User();
            dgvListaUsuarios.DataSource = Datos.ListaUs(cTexto);
            this.FormatoDGV();

        }

        private void ListadoRol()
        {
            try
            {
                D_User Datos = new D_User();
                cbRol.DataSource = Datos.ListaRol();
                cbRol.ValueMember = "idRol";
                cbRol.DisplayMember = "descripcionRol";


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void ListadoSalario()
        {
            try
            {
                D_User Datos = new D_User();
                cbSalario.DataSource = Datos.ListaSalario();
                cbSalario.ValueMember = "idSalario";
                cbSalario.DisplayMember = "descripcionSalario";


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
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
            this.txtCedula.Focus();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 0;
            this.LimpiaTexto();
            this.EstadoTexto(false);
            this.EstadoBtnProcesos(false);
            this.EstadoBtnPrincipales(true);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtCedula.Text == string.Empty ||
                txtNombre.Text == string.Empty ||
                txtApellidos.Text == string.Empty ||
                txtLogin.Text == string.Empty ||
                txtPassword.Text == string.Empty ||
                txtCorreoEmp.Text == string.Empty ||
                txtTelefonoEmp.Text == string.Empty)
            {
                MessageBox.Show("Ingrese el dato requerido (*)",
                    "Aviso del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                string Respuesta;
                E_Empleado oPro = new E_Empleado();
                oPro.IdEmpleado = nIdEmpleado;
                oPro.CedulaEmpleado = txtCedula.Text;
                oPro.NombreEmpleado = txtNombre.Text;
                oPro.ApellidoEmpleado = txtApellidos.Text;
                oPro.IdRol = Convert.ToInt32(cbRol.SelectedValue);
                oPro.LoginUs = txtLogin.Text;
                oPro.PasswordUs = txtPassword.Text;
                oPro.IdSalario = Convert.ToInt32(cbSalario.SelectedValue);
                oPro.CorreoEmp = txtCorreoEmp.Text;
                oPro.TelefonoEmp = txtTelefonoEmp.Text;
                D_User Datos = new D_User();
                Respuesta = Datos.GuardarUs(nEstadoGuarda, oPro);
                bool esNumero = int.TryParse(Respuesta, out int xCodigo);
                if (esNumero == true)
                {
                    nEstadoGuarda = 0;
                    nIdEmpleado = 0;
                    this.LimpiaTexto();
                    this.EstadoTexto(false);
                    this.EstadoBtnProcesos(false);
                    this.EstadoBtnPrincipales(true);
                    this.ListadoUs("%");
                    MessageBox.Show("Datos Almacenados Correctamente con #" + Respuesta.Trim(),
                        "Aviso del Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }





            }
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            this.ListadoSalario();
            this.ListadoRol();
            this.ListadoUs("%");
            this.EstadoTexto(false);
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.ListadoUs(txtBuscar.Text);
        }

        
    }



}
