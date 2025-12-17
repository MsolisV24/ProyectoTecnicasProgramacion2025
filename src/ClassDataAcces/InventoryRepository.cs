using Microsoft.EntityFrameworkCore;
using ClassModels;

namespace ClassDataAccess
{
    public class InventoryRepository : IRepository<InventoryItem>
    {
        private readonly DatabaseContext _context;

        public InventoryRepository(DatabaseContext context)
        {
            _context = context;
        }

        public InventoryItem GetById(int id)
        {
            return _context.InventoryItems.Find(id);
        }

        public InventoryItem GetByProductId(int productId)
        {
            return _context.InventoryItems.FirstOrDefault(i => i.ProductId == productId);
        }

        public List<InventoryItem> GetAll()
        {
            return _context.InventoryItems.ToList();
        }

        public void Add(InventoryItem item)
        {
            _context.InventoryItems.Add(item);
            _context.SaveChanges();
        }

        public void Update(InventoryItem item)
        {
            _context.InventoryItems.Update(item);
            _context.SaveChanges();
        }

        public void UpdateQuantity(int productId, decimal quantity)
        {
            var item = GetByProductId(productId);
            if (item != null)
            {
                item.QuantityAvailable = quantity;
                Update(item);
            }
        }

        public void Delete(int id)
        {
            var item = GetById(id);
            if (item != null)
            {
                _context.InventoryItems.Remove(item);
                _context.SaveChanges();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
