using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace DataAccess.EntityConfiguration
{
    internal class CategoryGroupEntityConfiguration : IEntityTypeConfiguration<CategoryGroup>
    {
        public void Configure(EntityTypeBuilder<CategoryGroup> builder)
        {

            builder.ToTable("CategoryGroup");

            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Title).HasMaxLength(50);
        }
    }
}
