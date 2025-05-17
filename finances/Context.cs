using Microsoft.EntityFrameworkCore;

namespace finances
{
    public class Context : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("TestDb");
        }
    }
}