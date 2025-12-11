using ClassModels;

namespace ClassController
{
    /// <summary>
    /// implements a shopping cart service for managing cart operations such as adding/removing items,
    /// </summary>
    /// <seealso cref="ClassController.ICartService" />
    public class CartService : ICartService
    {
        private readonly List<Product> _products;
        private readonly List<InventoryItem> _inventory;
        private readonly List<ExpenseRecord> _history;
        private Cart _cart = new();
        private List<Product> products;

        /// <summary>
        /// Initializes a new instance of the <see cref="CartService"/> class.
        /// </summary>
        /// <param name="products">The products.</param>
        /// <param name="inventory">The inventory.</param>
        /// <param name="history">The history.</param>
        public CartService(List<Product> products, List<InventoryItem> inventory, List<ExpenseRecord> history)
        {
            _products = products;
            _inventory = inventory;
            _history = history;
        }

        public CartService(List<Product> products)
        {
            this.products = products;
        }

        /// <summary>
        /// Gets the current cart.
        /// </summary>
        /// <returns></returns>
        public Cart GetCurrentCart() => _cart;

        /// <summary>
        /// Sets the current user and fair.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="fairId">The fair identifier.</param>
        public void SetCurrentUserAndFair(string username, int fairId)
        {
            _cart = new Cart
            {
                Username = username,
                FairId = fairId
            };
        }

        /// <summary>
        /// Adds the item.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        /// <param name="qty">The qty.</param>
        /// <exception cref="System.Exception">Inventario insuficiente.</exception>
        public void AddItem(int productId, decimal qty)
        {
            var p = _products.First(x => x.Id == productId);
            var inv = _inventory.First(x => x.ProductId == productId);

            if (inv.QuantityAvailable < qty)
                throw new Exception("Inventario insuficiente.");

            var existing = _cart.Items.FirstOrDefault(x => x.ProductId == productId);

            if (existing == null)
            {
                _cart.Items.Add(new CartItem
                {
                    ProductId = productId,
                    ProductName = p.Name,
                    UnitPrice = p.UnitPrice,
                    Quantity = qty
                });
            }
            else
            {
                existing.Quantity += qty;
            }

            inv.QuantityAvailable -= qty;
        }

        /// <summary>
        /// Removes the item.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        public void RemoveItem(int productId)
        {
            var item = _cart.Items.FirstOrDefault(x => x.ProductId == productId);
            if (item == null) return;

            var inv = _inventory.First(x => x.ProductId == productId);
            inv.QuantityAvailable += item.Quantity;

            _cart.Items.Remove(item);
        }

        /// <summary>
        /// Clears the cart.
        /// </summary>
        public void ClearCart()
        {
            foreach (var i in _cart.Items)
            {
                var inv = _inventory.First(x => x.ProductId == i.ProductId);
                inv.QuantityAvailable += i.Quantity;
            }

            _cart.Items.Clear();
        }

        /// <summary>
        /// Sets the delivery address.
        /// </summary>
        /// <param name="addressId">The address identifier.</param>
        public void SetDeliveryAddress(int addressId)
        {
            _cart.DeliveryAddressId = addressId;
        }

        /// <summary>
        /// Checkouts this instance.
        /// </summary>
        /// <returns></returns>
        public List<ExpenseRecord> Checkout()
        {
            var list = new List<ExpenseRecord>();

            foreach (var item in _cart.Items)
            {
                var p = _products.First(x => x.Id == item.ProductId);

                list.Add(new ExpenseRecord
                {
                    Id = _history.Count + list.Count + 1,
                    Username = _cart.Username,
                    FairId = _cart.FairId,
                    ProductId = item.ProductId,
                    ProducerId = p.ProducerId,
                    Date = DateTime.Now,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice
                });
            }

            _history.AddRange(list);
            ClearCart();
            return list;
        }
    }
}



