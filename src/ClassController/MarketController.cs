using ClassModels;

namespace ClassController
{

    /// <summary>
    /// implementation of market controller
    /// </summary>
    public class MarketController
    {
        /// <summary>
        /// The loader
        /// </summary>
        private readonly IDataLoader _loader;

        /// <summary>
        /// Gets the username.
        /// </summary>
        /// <value>
        /// The username.
        /// </value>
        public List<Customer> Username { get; private set; } = new();

        /// <summary>
        /// Gets the producers.
        /// </summary>
        /// <value>
        /// The producers.
        /// </value>
        public List<Producer> Producers { get; private set; } = new();

        /// <summary>
        /// Gets the fairs.
        /// </summary>
        /// <value>
        /// The fairs.
        /// </value>
        public List<Fair> Fairs { get; private set; } = new();

        /// <summary>
        /// Gets the products.
        /// </summary>
        /// <value>
        /// The products.
        /// </value>
        public List<Product> Products { get; private set; } = new();

        /// <summary>
        /// Gets the inventory.
        /// </summary>
        /// <value>
        /// The inventory.
        /// </value>
        public List<InventoryItem> Inventory { get; private set; } = new();

        /// <summary>
        /// Gets the expense history.
        /// </summary>
        /// <value>
        /// The expense history.
        /// </value>
        public List<ExpenseRecord> ExpenseHistory { get; private set; } = new();

        /// <summary>
        /// The cart
        /// </summary>
        private ICartService _cart;

        /// <summary>
        /// The stats
        /// </summary>
        private IStatisticsService _stats;

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketController"/> class.
        /// </summary>
        public MarketController()
        {
            _loader = new DataLoaderCsv();
        }

        /// <summary>
        /// Loads the CSV files.
        /// </summary>
        /// <param name="usersCsv">The users CSV.</param>
        /// <param name="producersCsv">The producers CSV.</param>
        /// <param name="fairsCsv">The fairs CSV.</param>
        /// <param name="productsCsv">The products CSV.</param>
        /// <param name="inventoryCsv">The inventory CSV.</param>
        /// <param name="expensesCsv">The expenses CSV.</param>
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

        /// <summary>
        /// Carts this instance.
        /// </summary>
        /// <returns></returns>
        public ICartService Cart() => _cart;

        /// <summary>
        /// Statisticses this instance.
        /// </summary>
        /// <returns></returns>
        public IStatisticsService Statistics() => _stats;
    }
}

