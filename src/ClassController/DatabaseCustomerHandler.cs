using ClassController.Abstractions;
using ClassModels;
using ClassDataAccess;

namespace ClassController
{
    public class DatabaseCustomerHandler : IDataHandler<Customer>
    {
        private readonly DatabaseContext _context;

        public DatabaseCustomerHandler(DatabaseContext context)
        {
            _context = context;
        }

        public List<Customer> LoadData(string fileName)
        {
            return _context.Customers.ToList();
        }

        public bool SaveData(List<Customer> data, string fileName)
        {
            _context.Customers.AddRange(data);
            _context.SaveChanges();
            return true;
        }
    }
}
