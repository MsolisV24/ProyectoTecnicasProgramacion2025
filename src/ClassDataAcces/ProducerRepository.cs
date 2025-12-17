using Microsoft.EntityFrameworkCore;
using ClassModels;

namespace ClassDataAccess
{
    public class ProducerRepository : IRepository<Producer>
    {
        private readonly DatabaseContext _context;

        public ProducerRepository(DatabaseContext context)
        {
            _context = context;
        }

        public Producer GetById(int id)
        {
            return _context.Producers.Find(id);
        }

        public List<Producer> GetAll()
        {
            return _context.Producers.ToList();
        }

        public void Add(Producer producer)
        {
            _context.Producers.Add(producer);
            _context.SaveChanges();
        }

        public void Update(Producer producer)
        {
            _context.Producers.Update(producer);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var producer = GetById(id);
            if (producer != null)
            {
                _context.Producers.Remove(producer);
                _context.SaveChanges();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
