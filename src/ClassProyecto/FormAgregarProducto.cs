using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ClassModels;

namespace ClassProyecto
{
    public partial class FormAgregarProducto : Form
    {
        private List<Product> _products;

        public Product SelectedProduct { get; private set; }
        public decimal SelectedQuantity { get; private set; }

        public FormAgregarProducto(List<Product> products, int fairId)
        {
            InitializeComponent();
            _products = products.Where(x => x.FairId == fairId).ToList();
        }

        private void FormAgregarProducto_Load(object sender, EventArgs e)
        {
            cmbProductos.DataSource = _products;
            cmbProductos.DisplayMember = "Name";
            cmbProductos.ValueMember = "Id";

            nudCantidad.Value = 1;
            nudCantidad.Minimum = 0.1M;
            nudCantidad.Maximum = 999;
        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedItem is Product p)
            {
                lblUnidad.Text = p.Unit;
                lblPrecio.Text = p.UnitPrice.ToString("N2");
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedItem is Product p)
            {
                SelectedProduct = p;
                SelectedQuantity = nudCantidad.Value;
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

