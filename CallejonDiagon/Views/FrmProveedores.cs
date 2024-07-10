using CallejonDiagon.Data;
using CallejonDiagon.Entity;
using Google.Protobuf.WellKnownTypes;
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
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }
        #region "Variables"//////////////////////////////////

        int nIdProveedor = 0;
        int nEstadoProve = 0;

        #endregion/////////////////////////////////////////


        #region"Metodos Us"//////////////////////////////////

        private void LimpiaTextoProve()
        {
            txtCedulaProve.Text = "";
            txtNombreProve.Text = "";
            txtCorreoProve.Text = "";
            txtDireccionProve.Text = "";
            txtTelefonoProve.Text = "";

        }
        private void EstadoTextoProve(bool lEstado)
        {
            txtCedulaProve.Enabled = lEstado;
            txtNombreProve.Enabled = lEstado;
            txtCorreoProve.Enabled = lEstado;
            txtDireccionProve.Enabled = lEstado;
            txtTelefonoProve.Enabled = lEstado;
        }

        private void EstadoBtnProcesos(bool lEstado)
        {
            btnCancelar.Visible = lEstado;
            btnGuardar.Visible = lEstado;

        }

        private void EstadoBtnPrincipales(bool lEstado)
        {
            BtnRegistrarProve.Enabled = lEstado;
            BtnEditarProve.Enabled = lEstado;
            BtnEliminarProve.Enabled = lEstado;
            BtnRegresar.Enabled = lEstado;


        }
        private void FormatoDGVProve()
        {
            dgvProvedores.Columns[0].Width = 100;
            dgvProvedores.Columns[0].HeaderText = "NOMBRE";
            dgvProvedores.Columns[1].Width = 120;
            dgvProvedores.Columns[1].HeaderText = "ID PROV";
            dgvProvedores.Columns[2].Width = 150;
            dgvProvedores.Columns[2].HeaderText = "CORREO";
            dgvProvedores.Columns[3].Width = 150;
            dgvProvedores.Columns[3].HeaderText = "DIRECION";
            dgvProvedores.Columns[4].Width = 90;
            dgvProvedores.Columns[4].HeaderText = "TELEFONO";
            dgvProvedores.Columns[5].Width = 90;
            dgvProvedores.Columns[5].HeaderText = "ESTADO";
           
        }
        private void ListadoProve(string cTexto)
        {
            D_Proveedores Datos = new D_Proveedores();
            dgvProvedores.DataSource = Datos.ListaProve(cTexto);
            this.FormatoDGVProve();

        }
        private void SeleccionaItem()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgvProvedores.CurrentRow.Cells["idProveedor"].Value)))
            {
                MessageBox.Show("Selecione un registro",
                "Aviso del Sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

            }
            else
            {
                nIdProveedor = Convert.ToInt32(dgvProvedores.CurrentRow.Cells["idProveedor"].Value);
                txtNombreProve.Text = dgvProvedores.CurrentRow.Cells["nombreProveedor"].Value.ToString();
            }

        }


        #endregion//////////////////////////////////////////////////

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void BtnRegistrarProve_Click(object sender, EventArgs e)
        {
            nEstadoProve = 1;
            this.LimpiaTextoProve();
            this.EstadoTextoProve(true);
            this.EstadoBtnProcesos(true);
            this.EstadoBtnPrincipales(false);
            this.txtCedulaProve.Focus();
        }

        private void BtnEditarProve_Click(object sender, EventArgs e)
        {
            nEstadoProve = 2;
            this.EstadoTextoProve(true);
            this.EstadoBtnProcesos(true);
            this.EstadoBtnPrincipales(false);
            this.ListadoProve("%");
            this.txtCedulaProve.Focus();
        }

        private void BtnEliminarProve_Click(object sender, EventArgs e)
        {
            if (dgvProvedores.Rows.Count > 0)
            {
                string Respuesta = "";
                D_Proveedores Datos = new D_Proveedores();
                Respuesta = Datos.ActivoProve(Convert.ToInt32(dgvProvedores.CurrentRow.Cells["idProveedor"].Value));
                if (Respuesta.Equals("OK"))
                {
                    this.ListadoProve("%");
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
            nEstadoProve = 0;
            this.LimpiaTextoProve();
            this.EstadoTextoProve(false);
            this.EstadoBtnProcesos(false);
            this.EstadoBtnPrincipales(true);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtCedulaProve.Text == string.Empty ||
                txtNombreProve.Text == string.Empty ||
                txtCorreoProve.Text == string.Empty ||
                txtDireccionProve.Text == string.Empty ||
                txtTelefonoProve.Text == string.Empty)
                
            {
                MessageBox.Show("Ingrese el dato requerido (*)",
                    "Aviso del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                string Respuesta;
                E_Proveedor oPro = new E_Proveedor();
                oPro.IdProveedor = nIdProveedor;
                oPro.CedulaProveedor = txtCedulaProve.Text;
                oPro.NombreProveedor = txtNombreProve.Text;
                oPro.CorreoProveedor = txtCorreoProve.Text;
                oPro.DireccionProveedor = txtDireccionProve.Text;
                oPro.TelefonoProveedor = txtTelefonoProve.Text;
                D_Proveedores Datos = new D_Proveedores();
                Respuesta = Datos.GuardarProve(nEstadoProve, oPro);
                bool esNumero = int.TryParse(Respuesta, out int xCodigo);
                if (esNumero == true)
                {
                    nEstadoProve = 0;
                    nIdProveedor = 0;
                    this.LimpiaTextoProve();
                    this.EstadoTextoProve(false);
                    this.EstadoBtnProcesos(false);
                    this.EstadoBtnPrincipales(true);
                    this.ListadoProve("%");
                    MessageBox.Show("Datos Almacenados Correctamente con #" + Respuesta.Trim(),
                        "Aviso del Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }





            }
        }

        private void dgvProvedores_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.SeleccionaItem();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
           
            this.ListadoProve("%");
            this.EstadoTextoProve(false);
        }
    }
}

