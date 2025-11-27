using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
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
        private bool _datosCargados = false;

        public FormMain(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            cmbUsuarios.DataSource = null;
            cmbUsuarios.Items.Clear();
            cmbUsuarios.Items.Add(_username);
            cmbUsuarios.SelectedIndex = 0;
            cmbUsuarios.Enabled = false;
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
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

                cmbFerias.DataSource = _market.Fairs;
                cmbFerias.DisplayMember = "Name";
                cmbFerias.ValueMember = "Id";

                if (cmbFerias.Items.Count > 0)
                    cmbFerias.SelectedIndex = 0;

                _datosCargados = true;

                MessageBox.Show("Datos cargados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void btnSetUsuarioFeria_Click(object sender, EventArgs e)
        {
            if (!_datosCargados)
            {
                MessageBox.Show("Cargue los datos antes de continuar.");
                return;
            }

            if (cmbFerias.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar una feria.");
                return;
            }

            int feriaId = Convert.ToInt32(cmbFerias.SelectedValue);
            _cart.SetCurrentUserAndFair(_username, feriaId);
            RefrescarCarrito();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (!_datosCargados)
            {
                MessageBox.Show("Cargue los datos antes de continuar.");
                return;
            }

            int feriaId = Convert.ToInt32(cmbFerias.SelectedValue);

            var form = new FormAgregarProducto(_market.Products, feriaId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _cart.AddItem(form.SelectedProduct.Id, form.SelectedQuantity);
                    RefrescarCarrito();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnEliminarItem_Click(object sender, EventArgs e)
        {
            if (!_datosCargados)
            {
                MessageBox.Show("Cargue los datos antes de continuar.");
                return;
            }

            if (dgvCarrito.CurrentRow == null) return;

            if (dgvCarrito.CurrentRow.DataBoundItem is CartItem item)
            {
                _cart.RemoveItem(item.ProductId);
                RefrescarCarrito();
            }
        }

        private void btnLimpiarCarrito_Click(object sender, EventArgs e)
        {
            if (!_datosCargados)
            {
                MessageBox.Show("Cargue los datos antes de continuar.");
                return;
            }

            _cart.ClearCart();
            RefrescarCarrito();
        }

        private void btnProcesarCompra_Click(object sender, EventArgs e)
        {
            if (!_datosCargados)
            {
                MessageBox.Show("Cargue los datos antes de continuar.");
                return;
            }

            try
            {
                var lista = _cart.Checkout();
                RefrescarCarrito();
                MessageBox.Show("Compra procesada. Registros creados: " + lista.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar: " + ex.Message);
            }
        }

        private void btnVerEstadisticas_Click(object sender, EventArgs e)
        {
            if (!_datosCargados)
            {
                MessageBox.Show("Cargue los datos antes de continuar.");
                return;
            }

            new FormEstadisticas(_stats).ShowDialog();
        }

        private void RefrescarCarrito()
        {
            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = _cart.GetCurrentCart().Items.ToList();
            lblTotal.Text = _cart.GetCurrentCart().Total.ToString("N2");
        }
    }
}




