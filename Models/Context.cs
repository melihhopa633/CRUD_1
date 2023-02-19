using Microsoft.EntityFrameworkCore;

namespace test_proje_1.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-DA64VJP; database=test_proje_1; integrated security=true;TrustServerCertificate=True;");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
