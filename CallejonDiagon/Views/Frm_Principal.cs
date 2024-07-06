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
    }
}
