using ClassController;
using ClassModels;

namespace ClassProyecto
{
    public partial class FormMain : Form
    {
        private string _username;
        private MarketController _market;
        private ICartService _cart;
        private IStatisticsService _stats;
        private bool _dataLoaded = false;

        public FormMain(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            cmbUsers.DataSource = null;
            cmbUsers.Items.Clear();
            cmbUsers.Items.Add(_username);
            cmbUsers.SelectedIndex = 0;
            cmbUsers.Enabled = false;
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                var basePath = AppDomain.CurrentDomain.BaseDirectory;

                _market = new MarketController();
                _market.LoadCsvFiles(
                    Path.Combine(basePath, "users.csv"),
                    Path.Combine(basePath, "producers.csv"),
                    Path.Combine(basePath, "fairs.csv"),
                    Path.Combine(basePath, "products.csv"),
                    Path.Combine(basePath, "inventory.csv"),
                    Path.Combine(basePath, "expenses.csv")
                );

                _cart = _market.Cart();
                _stats = _market.Statistics();

                cmbFairs.DisplayMember = "Name";
                cmbFairs.ValueMember = "Id";
                cmbFairs.DataSource = _market.Fairs;

                if (cmbFairs.Items.Count > 0)
                    cmbFairs.SelectedIndex = 0;

                _dataLoaded = true;

                MessageBox.Show("Data loaded successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnSetUserFair_Click(object sender, EventArgs e)
        {
            if (!_dataLoaded)
            {
                MessageBox.Show("Load data before continuing.");
                return;
            }

            if (cmbFairs.SelectedValue == null)
            {
                MessageBox.Show("Select a fair first.");
                return;
            }

            int fairId = Convert.ToInt32(cmbFairs.SelectedValue);
            _cart.SetCurrentUserAndFair(_username, fairId);
            RefreshCart();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (!_dataLoaded)
            {
                MessageBox.Show("Load data before continuing.");
                return;
            }

            int fairId = Convert.ToInt32(cmbFairs.SelectedValue);

            var form = new FormAddProduct(_market.Products, fairId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _cart.AddItem(form.SelectedProduct.Id, form.SelectedQuantity);
                    RefreshCart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (!_dataLoaded)
            {
                MessageBox.Show("Load data before continuing.");
                return;
            }

            if (dgvCart.CurrentRow == null) return;

            if (dgvCart.CurrentRow.DataBoundItem is CartItem item)
            {
                _cart.RemoveItem(item.ProductId);
                RefreshCart();
            }
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            if (!_dataLoaded)
            {
                MessageBox.Show("Load data before continuing.");
                return;
            }

            _cart.ClearCart();
            RefreshCart();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (!_dataLoaded)
            {
                MessageBox.Show("Load data before continuing.");
                return;
            }

            try
            {
                var list = _cart.Checkout();
                RefreshCart();
                MessageBox.Show("Purchase processed. Records created: " + list.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing purchase: " + ex.Message);
            }
        }

        private void btnViewStats_Click(object sender, EventArgs e)
        {
            if (!_dataLoaded)
            {
                MessageBox.Show("Load data before continuing.");
                return;
            }

            new FormStatistics(_stats).ShowDialog();
        }

        private void RefreshCart()
        {
            dgvCart.DataSource = null;
            dgvCart.DataSource = _cart.GetCurrentCart().Items.ToList();
            lblTotal.Text = _cart.GetCurrentCart().Total.ToString("N2");
        }
    }
}





