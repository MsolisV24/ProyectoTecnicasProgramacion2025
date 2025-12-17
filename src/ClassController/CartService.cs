using ClassDataAccess;
using ClassModels;
using Microsoft.EntityFrameworkCore;

namespace ClassController
{
    public class CartService : ICartService
    {
        private readonly List<Product> _products;
        private readonly List<InventoryItem> _inventory;
        private readonly List<ExpenseRecord> _history;
        private readonly DatabaseContext _context;
        private Cart _cart = new();

        public CartService(
            List<Product> products,
            List<InventoryItem> inventory,
            List<ExpenseRecord> history,
            DatabaseContext context)
        {
            _products = products;
            _inventory = inventory;
            _history = history;
            _context = context;
        }

        public Cart GetCurrentCart() => _cart;

        public void SetCurrentUserAndFair(string username, int fairId)
        {
            _cart = new Cart
            {
                Username = username,
                FairId = fairId
            };
        }

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
            _context.InventoryItems.Update(inv);
            _context.SaveChanges();
        }

        public void RemoveItem(int productId)
        {
            var item = _cart.Items.FirstOrDefault(x => x.ProductId == productId);
            if (item == null) return;

            var inv = _inventory.First(x => x.ProductId == productId);
            inv.QuantityAvailable += item.Quantity;
            _context.InventoryItems.Update(inv);
            _context.SaveChanges();

            _cart.Items.Remove(item);
        }

        public void ClearCart()
        {
            foreach (var i in _cart.Items)
            {
                var inv = _inventory.First(x => x.ProductId == i.ProductId);
                inv.QuantityAvailable += i.Quantity;
                _context.InventoryItems.Update(inv);
            }
            _context.SaveChanges();

            _cart.Items.Clear();
        }

        public void SetDeliveryAddress(int addressId)
        {
            _cart.DeliveryAddressId = addressId;
        }

        public List<ExpenseRecord> Checkout()
        {
            var list = new List<ExpenseRecord>();

            foreach (var item in _cart.Items)
            {
                var p = _products.First(x => x.Id == item.ProductId);

                var record = new ExpenseRecord
                {
                    Username = _cart.Username,
                    FairId = _cart.FairId,
                    ProductId = item.ProductId,
                    ProducerId = p.ProducerId,
                    Date = DateTime.Now,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice
                };

                list.Add(record);
                _context.ExpenseRecords.Add(record);
            }

            _context.SaveChanges();
            ClearCart();
            return list;
        }
    }
}



