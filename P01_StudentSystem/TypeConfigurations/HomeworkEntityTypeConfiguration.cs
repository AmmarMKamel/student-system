using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_StudentSystem.Models;

namespace P01_StudentSystem.TypeConfigurations
{
    internal class HomeworkEntityTypeConfiguration : IEntityTypeConfiguration<Homework>
    {
        public void Configure(EntityTypeBuilder<Homework> builder)
        {
            builder.Property(h => h.Content)
                .IsUnicode(false);
        }
    }
}
