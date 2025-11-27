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
        private MarketController _market;
        private ICartService _cart;
        private IStatisticsService _stats;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _market = new MarketController();
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                var basePath = AppDomain.CurrentDomain.BaseDirectory;

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

                cmbUsuarios.DataSource = _market.Users;
                cmbUsuarios.DisplayMember = "Name";
                cmbUsuarios.ValueMember = "Username";

                cmbFerias.DataSource = _market.Fairs;
                cmbFerias.DisplayMember = "Name";
                cmbFerias.ValueMember = "Id";

                MessageBox.Show("Datos cargados desde CSV.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void btnSetUsuarioFeria_Click(object sender, EventArgs e)
        {
            if (cmbUsuarios.SelectedValue == null || cmbFerias.SelectedValue == null)
            {
                MessageBox.Show("Seleccione usuario y feria.");
                return;
            }

            string username = cmbUsuarios.SelectedValue.ToString();
            int feriaId = (int)cmbFerias.SelectedValue;

            _cart.SetCurrentUserAndFair(username, feriaId);
            RefrescarCarrito();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (_cart == null)
            {
                MessageBox.Show("Debe cargar datos primero.");
                return;
            }

            int feriaSeleccionada = (int)cmbFerias.SelectedValue;

            var form = new FormAgregarProducto(_market.Products, feriaSeleccionada);
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
            if (dgvCarrito.CurrentRow == null) return;

            if (dgvCarrito.CurrentRow.DataBoundItem is CartItem item)
            {
                _cart.RemoveItem(item.ProductId);
                RefrescarCarrito();
            }
        }

        private void btnLimpiarCarrito_Click(object sender, EventArgs e)
        {
            _cart.ClearCart();
            RefrescarCarrito();
        }

        private void btnProcesarCompra_Click(object sender, EventArgs e)
        {
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
            if (_stats == null)
            {
                MessageBox.Show("Cargue datos primero.");
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


