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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }
        #region "Variables"//////////////////////////////////

        int nIdProducto = 0;
        int nEstadoG= 0;

        #endregion/////////////////////////////////////////

        #region"Metodos Prod"//////////////////////////////////

        private void LimpiaTextoProd()
        {
            txtDescripcionprod.Text = "";
            cbUniMedida.Text = "";
            cbCategoria.Text = "";
            cbProveedor.Text = "";
            txtPrecioCosto.Text = "";
            txtPrecioVenta.Text = "";
        }
        private void EstadoTextoProd(bool lEstado)
        {
            txtDescripcionprod.Enabled = lEstado;
            cbUniMedida.Enabled = lEstado;
            cbCategoria.Enabled = lEstado;
            cbProveedor.Enabled = lEstado;
            txtPrecioCosto.Enabled = lEstado;
            txtPrecioVenta.Enabled = lEstado;

        }
        private void EstadoBtnProcesos(bool lEstado)
        {
            btnCancelarProd.Visible = lEstado;
            btnGuardarProd.Visible = lEstado;

        }
        private void EstadoBtnPrincipales(bool lEstado)
        {
            BtnRegistrarProd.Visible = lEstado;
            BtnEditarProd.Visible = lEstado;
            BtnEliminarProd.Visible = lEstado;

        }
        private void FormatoDGVProd()
        {
            dgvProductos.Columns[0].Width = 60;
            dgvProductos.Columns[0].HeaderText = "ID_PROD";
            dgvProductos.Columns[1].Width = 180;
            dgvProductos.Columns[1].HeaderText = "DESCRIPCION PROD";
            dgvProductos.Columns[2].Width = 60;
            dgvProductos.Columns[2].HeaderText = "EXISTENCIAS";
            dgvProductos.Columns[3].Width = 55;
            dgvProductos.Columns[3].HeaderText = "UNI MEDIDA";
            dgvProductos.Columns[4].Width = 80;
            dgvProductos.Columns[4].HeaderText = "CATEG";
            dgvProductos.Columns[5].Width = 55;
            dgvProductos.Columns[5].HeaderText = "ID_PROV";
            dgvProductos.Columns[6].Width = 150;
            dgvProductos.Columns[6].HeaderText = "PRECIO COMPRA ";
            dgvProductos.Columns[7].Width = 150;
            dgvProductos.Columns[7].HeaderText = "PRECIO VENTA ";
            dgvProductos.Columns[8].Width = 60;
            dgvProductos.Columns[8].HeaderText = "ESTADO";

        }

        private void ListadoProd(string cTexto)
        {
            D_Productos Datos = new D_Productos();
            dgvProductos.DataSource = Datos.ListaProductos(cTexto);
            this.FormatoDGVProd();

        }
        private void ListadoUniMedida()
        {
            try
            {
                D_Productos Datos = new D_Productos();
                cbUniMedida.DataSource = Datos.ListaUnidadMedidas();
                cbUniMedida.ValueMember = "idUnidadMedida";
                cbUniMedida.DisplayMember = "abreviaturaMed";


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void ListadoCategoria()
        {
            try
            {
                D_Productos Datos = new D_Productos();
                cbCategoria.DataSource = Datos.ListaCategorias();
                cbCategoria.ValueMember = "idCategoria";
                cbCategoria.DisplayMember = "descripcion";


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void ListadoProveedor()
        {
            try
            {
                D_Productos Datos = new D_Productos();
                cbProveedor.DataSource = Datos.ListaProveedores();
                cbProveedor.ValueMember = "idProveedor";
                cbProveedor.DisplayMember = "nombreProveedor";


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void SeleccionaItem()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgvProductos.CurrentRow.Cells["idProducto"].Value)))
            {
                MessageBox.Show("Selecione un registro",
                "Aviso del Sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

            }
            else
            {
                nIdProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells["idProducto"].Value);
                txtDescripcionprod.Text = dgvProductos.CurrentRow.Cells["descripcionProducto"].Value.ToString();
                txtExistencias.Text = dgvProductos.CurrentRow.Cells["Existencias"].Value.ToString();
                cbUniMedida.Text = dgvProductos.CurrentRow.Cells["idUnidadMedida"].Value.ToString();
                cbCategoria.Text = dgvProductos.CurrentRow.Cells["idCategoria"].Value.ToString();
                cbProveedor.Text = dgvProductos.CurrentRow.Cells["idProveedor"].Value.ToString();
                txtPrecioVenta.Text = dgvProductos.CurrentRow.Cells["precioVenta"].Value.ToString();


            }

        }

        #endregion////////////////////////////////////////

        private void BtnRegistrarProd_Click_1(object sender, EventArgs e)
        {
            nEstadoG = 1;
            this.LimpiaTextoProd();
            this.EstadoTextoProd(true);
            this.EstadoBtnProcesos(true);
            this.EstadoBtnPrincipales(false);
            this.txtDescripcionprod.Focus();
        }

        private void BtnEditarProd_Click_1(object sender, EventArgs e)
        {
            nEstadoG = 2;
            this.EstadoTextoProd(true);
            this.EstadoBtnProcesos(true);
            this.EstadoBtnPrincipales(false);
            this.ListadoProd("%");
            this.txtPrecioVenta.Focus();
        }

        private void BtnEliminarProd_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                string Respuesta = "";
                D_Productos Datos = new D_Productos();
                Respuesta = Datos.ActivoProd(Convert.ToInt32(dgvProductos.CurrentRow.Cells["idProducto"].Value));
                if (Respuesta.Equals("OK"))
                {
                    this.ListadoProd("%");
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

        private void BtnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarProd_Click_1(object sender, EventArgs e)
        {
            nEstadoG = 0;
            this.LimpiaTextoProd();
            this.EstadoTextoProd(false);
            this.EstadoBtnProcesos(false);
            this.EstadoBtnPrincipales(true);
        }

        private void btnGuardarProd_Click_1(object sender, EventArgs e)
        {


            if (txtDescripcionprod.Text == string.Empty ||
                cbUniMedida.Text == string.Empty ||
                txtPrecioCosto.Text == string.Empty ||
                txtPrecioVenta.Text == string.Empty)

            {
                MessageBox.Show("Ingrese el dato requerido (*)",
                    "Aviso del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                string Respuesta;
                E_Producto oProdu = new E_Producto();
                oProdu.IdProducto = nIdProducto;
                oProdu.DescripcionProducto = txtDescripcionprod.Text;
                oProdu.Existencias = Convert.ToInt32(txtExistencias.Text);
                oProdu.IdUnidadMedida = Convert.ToInt32(cbUniMedida.SelectedValue);
                oProdu.IdCategoria = Convert.ToInt32(cbCategoria.SelectedValue);
                oProdu.IdProveedor = Convert.ToInt32(cbProveedor.SelectedValue);
                oProdu.PrecioCosto = Convert.ToDecimal(txtPrecioCosto.Text);
                oProdu.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
                D_Productos Datos = new D_Productos();
                Respuesta = Datos.GuardarProductos(nEstadoG, oProdu);
                bool esNumero = int.TryParse(Respuesta, out int xCodigo);
                if (esNumero == true)
                {
                    nEstadoG = 0;
                    nIdProducto = 0;
                    this.LimpiaTextoProd();
                    this.EstadoTextoProd(false);
                    this.EstadoBtnProcesos(false);
                    this.EstadoBtnPrincipales(true);
                    this.ListadoProd("%");
                    MessageBox.Show("Datos Almacenados Correctamente con #" + Respuesta.Trim(),
                        "Aviso del Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }


            }
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            this.ListadoProveedor();
            this.ListadoCategoria();
            this.ListadoUniMedida();
            this.ListadoProd("%");
            this.EstadoTextoProd(false);
        }

        private void BtnBuscarProd_Click_1(object sender, EventArgs e)
        {
            this.ListadoProd(txtBuscarProd.Text);
        }

        private void dgvProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.SeleccionaItem();
        }
    }
}
