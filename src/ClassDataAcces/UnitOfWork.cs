namespace ClassDataAccess
{
    public class UnitOfWork : IDisposable
    {
        private readonly DatabaseContext _context;

        private CustomerRepository _customerRepository;
        private ProductRepository _productRepository;
        private FairRepository _fairRepository;
        private ProducerRepository _producerRepository;
        private InventoryRepository _inventoryRepository;
        private ExpenseRecordRepository _expenseRecordRepository;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        public CustomerRepository Customers =>
            _customerRepository ??= new CustomerRepository(_context);

        public ProductRepository Products =>
            _productRepository ??= new ProductRepository(_context);

        public FairRepository Fairs =>
            _fairRepository ??= new FairRepository(_context);

        public ProducerRepository Producers =>
            _producerRepository ??= new ProducerRepository(_context);

        public InventoryRepository Inventory =>
            _inventoryRepository ??= new InventoryRepository(_context);

        public ExpenseRecordRepository ExpenseRecords =>
            _expenseRecordRepository ??= new ExpenseRecordRepository(_context);

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
