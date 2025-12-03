using ClassController;
using ClassModels;

namespace ClassProyecto
{
    /// <summary>
    /// interaction logic for FormMain.xaml
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class FormMain : Form
    {
        private string _username;
        private MarketController _market;
        private ICartService _cart;
        private IStatisticsService _stats;
        private bool _dataLoaded = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormMain"/> class.
        /// </summary>
        /// <param name="username">The username.</param>
        public FormMain(string username)
        {
            InitializeComponent();
            _username = username;
        }

        /// <summary>
        /// Handles the Load event of the FormMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            cmbUsers.DataSource = null;
            cmbUsers.Items.Clear();
            cmbUsers.Items.Add(_username);
            cmbUsers.SelectedIndex = 0;
            cmbUsers.Enabled = false;
        }

        /// <summary>
        /// Handles the Click event of the btnLoadData control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the btnSetUserFair control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the btnAddProduct control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the btnRemoveItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the btnClearCart control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the btnCheckout control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the btnViewStats control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnViewStats_Click(object sender, EventArgs e)
        {
            if (!_dataLoaded)
            {
                MessageBox.Show("Load data before continuing.");
                return;
            }

            new FormStatistics(_stats).ShowDialog();
        }

        /// <summary>
        /// Refreshes the cart.
        /// </summary>
        private void RefreshCart()
        {
            dgvCart.DataSource = null;
            dgvCart.DataSource = _cart.GetCurrentCart().Items.ToList();
            lblTotal.Text = _cart.GetCurrentCart().Total.ToString("N2");
        }

        /// <summary>
        /// Handles the Click event of the btnGenerateInvoice control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            Cart cart = _cart.GetCurrentCart();

            if (cart.Items.Count == 0)
            {
                MessageBox.Show("Your cart is empty.");
                return;
            }

            if (cmbFairs.SelectedItem == null)
            {
                MessageBox.Show("Please select a fair before generating the invoice.");
                return;
            }

            Fair selectedFair = (Fair)cmbFairs.SelectedItem;
            string fairName = selectedFair.Name;

            decimal subtotal = cart.Total;

            InvoiceBuilder builder = new InvoiceBuilder();
            InvoiceDirector director = new InvoiceDirector();

            Invoice invoice = director.CreateInvoice(builder, fairName, subtotal);

            MessageBox.Show(invoice.ToString(), "Invoice");
        }
    }
}





