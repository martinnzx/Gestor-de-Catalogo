using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class frmDetalle : Form
    {
        public frmDetalle()
        {
            InitializeComponent();
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
         
            ArticuloNegocio negocio = new ArticuloNegocio();
            dgvDetalle.DataSource = negocio.listarDetalle();
            
            dgvDetalle.Columns["Id"].Visible = false;
            dgvDetalle.Columns["Codigo"].Visible = false;
            dgvDetalle.Columns["ImagenUrl"].Visible = false;
            dgvDetalle.Columns["Categoria"].Visible = false;
        }
    }
}
