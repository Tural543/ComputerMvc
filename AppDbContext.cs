using ComputerStore.Class;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ComputerStore
{
    public class AppDbContext: DbContext
    {
        public DbSet<Computer> Computers {  get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Marka> Marka { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-N1RAESR\\SQLEXPRESS;Initial Catalog=ComputerStory;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
