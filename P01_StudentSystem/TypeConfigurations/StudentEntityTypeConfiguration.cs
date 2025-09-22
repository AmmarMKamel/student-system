using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_StudentSystem.Models;

namespace P01_StudentSystem.TypeConfigurations
{
    internal class StudentEntityTypeConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(s => s.Name)
                .HasMaxLength(100)
                .IsUnicode(true);

            builder.Property(s => s.PhoneNumber)
                .HasMaxLength(10)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
