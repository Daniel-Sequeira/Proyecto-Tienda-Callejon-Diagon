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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }
        #region "Variables"//////////////////////////////////

        int nIdCliente = 0;
        int nEstadoCliente = 0;

        #endregion/////////////////////////////////////////
        #region"Metodos Us"//////////////////////////////////

        private void LimpiaTextoCliente()
        {
            txtCedulaCliente.Text = "";
            txtNombreCliente.Text = "";
            txtApellidosCliente.Text = "";
            txtCorreoCliente.Text = "";
            txtDireccionCliente.Text = "";
            txtTelefonoCliente.Text = "";

        }
        private void EstadoTextoCliente(bool lEstado)
        {
            txtCedulaCliente.Enabled = lEstado;
            txtNombreCliente.Enabled = lEstado;
            txtApellidosCliente.Enabled = lEstado;
            txtCorreoCliente.Enabled = lEstado;
            txtDireccionCliente.Enabled = lEstado;
            txtTelefonoCliente.Enabled = lEstado;
        }

        private void EstadoBtnProcesos(bool lEstado)
        {
            btnCancelar.Visible = lEstado;
            btnGuardar.Visible = lEstado;

        }

        private void EstadoBtnPrincipales(bool lEstado)
        {
            BtnRegistrarCliente.Enabled = lEstado;
            BtnEditarCliente.Enabled = lEstado;
            BtnEliminarCliente.Enabled = lEstado;
            BtnRegresar.Enabled = lEstado;


        }
        private void FormatoDGVCliente()
        {
            dgvClientes.Columns[0].Width = 100;
            dgvClientes.Columns[0].HeaderText = "NOMBRE";
            dgvClientes.Columns[1].Width = 120;
            dgvClientes.Columns[1].HeaderText = "APELLIDOS";
            dgvClientes.Columns[2].Width = 150;
            dgvClientes.Columns[2].HeaderText = "CORREO";
            dgvClientes.Columns[3].Width = 150;
            dgvClientes.Columns[3].HeaderText = "DIRECION";
            dgvClientes.Columns[4].Width = 90;
            dgvClientes.Columns[4].HeaderText = "TELEFONO";
            dgvClientes.Columns[5].Width = 90;
            dgvClientes.Columns[5].HeaderText = "ESTADO";
            dgvClientes.Columns[6].Width = 90;
            dgvClientes.Columns[6].HeaderText = "ID CLIENTE";

        }
        private void ListadoClientes(string cTexto)
        {
            D_Clientes Datos = new D_Clientes();
            dgvClientes.DataSource = Datos.ListaClientes(cTexto);
            this.FormatoDGVCliente();

        }
        private void SeleccionaItem()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgvClientes.CurrentRow.Cells["idCliente"].Value)))
            {
                MessageBox.Show("Selecione un registro",
                "Aviso del Sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

            }
            else
            {
                nIdCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["idCliente"].Value);
                txtNombreCliente.Text = dgvClientes.CurrentRow.Cells["nombreCliente"].Value.ToString();
            }

        }

        #endregion//////////////////////////////////////////////////

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRegistrarCliente_Click(object sender, EventArgs e)
        {
            nEstadoCliente = 1;
            this.LimpiaTextoCliente();
            this.EstadoTextoCliente(true);
            this.EstadoBtnProcesos(true);
            this.EstadoBtnPrincipales(false);
            this.txtCedulaCliente.Focus();
        }

        private void BtnEditarCliente_Click(object sender, EventArgs e)
        {
            nEstadoCliente = 2;
            this.EstadoTextoCliente(true);
            this.EstadoBtnProcesos(true);
            this.EstadoBtnPrincipales(false);
            this.ListadoClientes("%");
            this.txtCedulaCliente.Focus();
        }

        private void BtnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.Rows.Count > 0)
            {
                string Respuesta = "";
                D_Clientes Datos = new D_Clientes();
                Respuesta = Datos.ActivoCLiente(Convert.ToInt32(dgvClientes.CurrentRow.Cells["idCliente"].Value));
                if (Respuesta.Equals("OK"))
                {
                    this.ListadoClientes("%");
                    MessageBox.Show("Estado Actualizado Exitosamente",
                        "Aviso del Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(Respuesta, "Aviso del Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            nEstadoCliente = 0;
            this.LimpiaTextoCliente ();
            this.EstadoTextoCliente(false);
            this.EstadoBtnProcesos(false);
            this.EstadoBtnPrincipales(true);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtCedulaCliente.Text == string.Empty ||
                txtNombreCliente.Text == string.Empty ||
                txtApellidosCliente.Text == string.Empty ||
                txtCorreoCliente.Text == string.Empty ||
                txtDireccionCliente.Text == string.Empty ||
                txtTelefonoCliente.Text == string.Empty)

            {
                MessageBox.Show("Ingrese el dato requerido (*)",
                    "Aviso del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                string Respuesta;
                E_Cliente oPro = new E_Cliente();
                oPro.IdCliente = nIdCliente;
                oPro.CedulaCliente = txtCedulaCliente.Text;
                oPro.NombreCliente = txtNombreCliente.Text;
                oPro.ApellidosCliente = txtApellidosCliente.Text;
                oPro.CorreoCliente = txtCorreoCliente.Text;
                oPro.DireccionCliente = txtDireccionCliente.Text;
                oPro.TelefonoCliente = txtTelefonoCliente.Text;
                D_Clientes Datos = new D_Clientes();
                Respuesta = Datos.GuardarCliente(nEstadoCliente, oPro);
                bool esNumero = int.TryParse(Respuesta, out int xCodigo);
                if (esNumero == true)
                {
                    nEstadoCliente = 0;
                    nIdCliente = 0;
                    this.LimpiaTextoCliente();
                    this.EstadoTextoCliente(false);
                    this.EstadoBtnProcesos(false);
                    this.EstadoBtnPrincipales(true);
                    this.ListadoClientes("%");
                    MessageBox.Show("Datos Almacenados Correctamente con #" + Respuesta.Trim(),
                        "Aviso del Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }





            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SeleccionaItem();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            this.ListadoClientes("%");
            this.EstadoTextoCliente(false);
        }
    }
}
