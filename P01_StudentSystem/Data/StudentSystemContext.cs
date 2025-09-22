using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Models;
using P01_StudentSystem.TypeConfigurations;

namespace P01_StudentSystem.Data
{
    internal class StudentSystemContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Homework> Homeworks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=StudentSystem;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new StudentEntityTypeConfiguration().Configure(modelBuilder.Entity<Student>());
            new CourseEntityTypeConfiguration().Configure(modelBuilder.Entity<Course>());
            new ResourceEntityTypeConfiguration().Configure(modelBuilder.Entity<Resource>());
            new HomeworkEntityTypeConfiguration().Configure(modelBuilder.Entity<Homework>());
        }
    }
}
