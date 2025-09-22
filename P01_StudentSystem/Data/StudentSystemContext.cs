using Microsoft.EntityFrameworkCore;

namespace P01_StudentSystem.Data
{
    internal class StudentSystemContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=StudentSystem;Trusted_Connection=True;");
        }
    }
}
