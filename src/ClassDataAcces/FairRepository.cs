using Microsoft.EntityFrameworkCore;
using ClassModels;

namespace ClassDataAccess
{
    public class FairRepository : IRepository<Fair>
    {
        private readonly DatabaseContext _context;

        public FairRepository(DatabaseContext context)
        {
            _context = context;
        }

        public Fair GetById(int id)
        {
            return _context.Fairs.Find(id);
        }

        public List<Fair> GetAll()
        {
            return _context.Fairs.ToList();
        }

        public void Add(Fair fair)
        {
            _context.Fairs.Add(fair);
            _context.SaveChanges();
        }

        public void Update(Fair fair)
        {
            _context.Fairs.Update(fair);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var fair = GetById(id);
            if (fair != null)
            {
                _context.Fairs.Remove(fair);
                _context.SaveChanges();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
