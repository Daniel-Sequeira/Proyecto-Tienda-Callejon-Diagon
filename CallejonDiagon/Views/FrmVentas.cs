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
    public partial class FrmVentas : Form
    {
        int nidCategoria;

        public FrmVentas()
        {
            InitializeComponent();
        }

        private void FormatoDGVVentas()
        {
            dgvProdFiltrados.Columns[0].Width = 60;
            dgvProdFiltrados.Columns[0].HeaderText = "ID_PROD";
            dgvProdFiltrados.Columns[1].Width = 180;
            dgvProdFiltrados.Columns[1].HeaderText = "DESCRIPCION";
            dgvProdFiltrados.Columns[2].Width = 60;
            dgvProdFiltrados.Columns[2].HeaderText = "EXISTENCIAS";
            dgvProdFiltrados.Columns[3].Width = 55;
            dgvProdFiltrados.Columns[3].HeaderText = "UNI MEDIDA";
            dgvProdFiltrados.Columns[4].Width = 150;
            dgvProdFiltrados.Columns[4].HeaderText = "PRECIO VENTA ";
       
        }
        private void FrmVentas_Load(object sender, EventArgs e)
        {
           
            CargarCategoria();
            ListadoGridViewCateg(nidCategoria);




        }
        private void CargarCategoria()
        {
            try
            {
                D_Productos Datos = new D_Productos();
                cbCargaCategorias.DataSource = Datos.ListaCategorias();
                cbCargaCategorias.ValueMember = "idCategoria";
                cbCargaCategorias.DisplayMember = "descripcion";


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void CbCargaCategorias(object sender, EventArgs e)
        {
            if(cbCargaCategorias.SelectedValue != null) 
            {
                int nidCategoria = Convert.ToInt32(cbCargaCategorias.SelectedValue);
            
            }

        }
        private void ListadoGridViewCateg(int nidCategoria)
        {
            D_SalidaProductos Datos = new D_SalidaProductos();
            dgvProdFiltrados.DataSource = Datos.ListaFiltroCategorias(nidCategoria);
            this.FormatoDGVVentas();

        }



    }
}
