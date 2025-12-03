using ClassModels;

namespace ClassProyecto
{
    public partial class FormAddProduct : Form
    {
        private List<Product> _products;

        public Product SelectedProduct { get; private set; }
        public decimal SelectedQuantity { get; private set; }

        public FormAddProduct(List<Product> products, int fairId)
        {
            InitializeComponent();
            _products = products.Where(x => x.FairId == fairId).ToList();
        }

        private void FormAgregarProducto_Load(object sender, EventArgs e)
        {
            cmbProducts.DataSource = _products;
            cmbProducts.DisplayMember = "Name";
            cmbProducts.ValueMember = "Id";

            nudQuantity.Value = 1;
            nudQuantity.Minimum = 0.1M;
            nudQuantity.Maximum = 999;
        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducts.SelectedItem is Product p)
            {
                lblUnit.Text = p.Unit;
                lblPrice.Text = p.UnitPrice.ToString("N2");
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (cmbProducts.SelectedItem is Product p)
            {
                SelectedProduct = p;
                SelectedQuantity = nudQuantity.Value;
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}


