using ClassModels;

namespace ClassController
{
    public class MarketController
    {
        private readonly IDataLoader _loader;

        public List<Customer> Username { get; private set; } = new();
        public List<Producer> Producers { get; private set; } = new();
        public List<Fair> Fairs { get; private set; } = new();
        public List<Product> Products { get; private set; } = new();
        public List<InventoryItem> Inventory { get; private set; } = new();
        public List<ExpenseRecord> ExpenseHistory { get; private set; } = new();

        private ICartService _cart;
        private IStatisticsService _stats;

        public MarketController()
        {
            _loader = new DataLoaderCsv();
        }

        public void LoadCsvFiles(
            string usersCsv,
            string producersCsv,
            string fairsCsv,
            string productsCsv,
            string inventoryCsv,
            string expensesCsv)
        {
            Username = _loader.LoadCsv<Customer>(usersCsv);
            Producers = _loader.LoadCsv<Producer>(producersCsv);
            Fairs = _loader.LoadCsv<Fair>(fairsCsv);
            Products = _loader.LoadCsv<Product>(productsCsv);
            Inventory = _loader.LoadCsv<InventoryItem>(inventoryCsv);
            ExpenseHistory = _loader.LoadCsv<ExpenseRecord>(expensesCsv);

            _cart = new CartService(Products, Inventory, ExpenseHistory);
            _stats = new StatisticsService(ExpenseHistory, Producers, Products);
        }

        public ICartService Cart() => _cart;
        public IStatisticsService Statistics() => _stats;
    }
}

