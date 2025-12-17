using Microsoft.EntityFrameworkCore;
using ClassModels;

namespace ClassDataAccess
{
    public class CustomerRepository : IRepository<Customer>
    {
        private readonly DatabaseContext _context;

        public CustomerRepository(DatabaseContext context)
        {
            _context = context;
        }

        public Customer GetById(int id)
        {
            return _context.Customers.Find(id);
        }

        public Customer GetByUsername(string username)
        {
            return _context.Customers.FirstOrDefault(c => c.Username == username);
        }

        public List<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

        public void Add(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void Update(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var customer = GetById(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
