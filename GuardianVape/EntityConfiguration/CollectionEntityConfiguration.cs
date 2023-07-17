using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace DataAccess.EntityConfiguration
{
    internal class CollectionEntityConfiguration : IEntityTypeConfiguration<Collection>
    {
        public void Configure(EntityTypeBuilder<Collection> builder)
        {
            builder.ToTable("Collection");

            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Description).HasMaxLength(500);
            builder.Property(e => e.MetaDescription).HasMaxLength(500);
            builder.Property(e => e.PageTitle).HasMaxLength(50);
            builder.Property(e => e.Title).HasMaxLength(50);
        }
    }
}
