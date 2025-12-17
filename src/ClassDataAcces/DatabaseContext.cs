using Microsoft.EntityFrameworkCore;
using ClassModels;
using Microsoft.EntityFrameworkCore;
using ClassModels;

namespace ClassDataAccess
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Fair> Fairs { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<InventoryItem> InventoryItems { get; set; }
        public DbSet<ExpenseRecord> ExpenseRecords { get; set; }
        public DbSet<Direction> Directions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=market.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasKey(c => c.Id);
            modelBuilder.Entity<Customer>().Property(c => c.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Producer>().HasKey(p => p.Id);
            modelBuilder.Entity<Producer>().Property(p => p.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Fair>().HasKey(f => f.Id);
            modelBuilder.Entity<Fair>().Property(f => f.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Product>().HasKey(p => p.Id);
            modelBuilder.Entity<Product>().Property(p => p.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<InventoryItem>().HasKey(i => i.Id);
            modelBuilder.Entity<InventoryItem>().Property(i => i.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<ExpenseRecord>().HasKey(e => e.Id);
            modelBuilder.Entity<ExpenseRecord>().Property(e => e.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Direction>().HasKey(d => d.Id);
            modelBuilder.Entity<Direction>().Property(d => d.Id).ValueGeneratedOnAdd();
        }
    }
}
