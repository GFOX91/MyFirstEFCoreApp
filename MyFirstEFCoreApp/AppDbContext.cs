using Microsoft.EntityFrameworkCore;

namespace MyFirstEFCoreApp
{
    public class AppDbContext :DbContext
    {
        private const string ConnectionString = "Server=localhost\\SQLEXPRESS;Database=MyFirstEfCoreDb;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<Book> Books { get; set; }
    }
}
