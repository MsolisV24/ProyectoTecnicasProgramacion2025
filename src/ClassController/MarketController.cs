using ClassModels;
using ClassDataAccess;

namespace ClassController
{
    public class MarketController
    {
        private readonly DatabaseContext _context;

        public List<Customer> Username { get; private set; }
        public List<Producer> Producers { get; private set; }
        public List<Fair> Fairs { get; private set; }
        public List<Product> Products { get; private set; }
        public List<InventoryItem> Inventory { get; private set; }
        public List<ExpenseRecord> ExpenseHistory { get; private set; }

        private ICartService _cart;
        private IStatisticsService _stats;

        public MarketController()
        {
            _context = new DatabaseContext();

            var initializer = new DatabaseInitializer(_context);
            initializer.Initialize();

            LoadData();
        }

        public void LoadData()
        {
            Username = _context.Customers.ToList();
            Producers = _context.Producers.ToList();
            Fairs = _context.Fairs.ToList();
            Products = _context.Products.ToList();
            Inventory = _context.InventoryItems.ToList();
            ExpenseHistory = _context.ExpenseRecords.ToList();

            _cart = new CartService(
                Products,
                Inventory,
                ExpenseHistory,
                _context
            );

            _stats = new StatisticsService(
                ExpenseHistory,
                Producers,
                Products
            );
        }

        public ICartService Cart() => _cart;
        public IStatisticsService Statistics() => _stats;
    }
}

