using Microsoft.EntityFrameworkCore;
using ClassModels;

namespace ClassDataAccess
{
    public class ExpenseRecordRepository : IRepository<ExpenseRecord>
    {
        private readonly DatabaseContext _context;

        public ExpenseRecordRepository(DatabaseContext context)
        {
            _context = context;
        }

        public ExpenseRecord GetById(int id)
        {
            return _context.ExpenseRecords.Find(id);
        }

        public List<ExpenseRecord> GetAll()
        {
            return _context.ExpenseRecords.ToList();
        }

        public List<ExpenseRecord> GetByUsername(string username)
        {
            return _context.ExpenseRecords.Where(e => e.Username == username).ToList();
        }

        public List<ExpenseRecord> GetByDateRange(DateTime start, DateTime end)
        {
            return _context.ExpenseRecords
                .Where(e => e.Date >= start && e.Date <= end)
                .ToList();
        }

        public void Add(ExpenseRecord record)
        {
            _context.ExpenseRecords.Add(record);
            _context.SaveChanges();
        }

        public void AddRange(List<ExpenseRecord> records)
        {
            _context.ExpenseRecords.AddRange(records);
            _context.SaveChanges();
        }

        public void Update(ExpenseRecord record)
        {
            _context.ExpenseRecords.Update(record);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var record = GetById(id);
            if (record != null)
            {
                _context.ExpenseRecords.Remove(record);
                _context.SaveChanges();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
