using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace DataAccess.EntityConfiguration
{
    internal class ProductTagEntityConfiguration : IEntityTypeConfiguration<ProductTag>
    {
        public void Configure(EntityTypeBuilder<ProductTag> builder)
        {
                builder.Property(e => e.Id).HasColumnName("ID");
                builder.Property(e => e.Guid)
                    .HasMaxLength(36)
                    .HasColumnName("GUID");
                builder.Property(e => e.ProductId).HasColumnName("ProductID");
                builder.Property(e => e.TagId).HasColumnName("TagID");

                builder.HasOne(d => d.Product).WithMany(p => p.ProductTags)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductTags_Product");

                builder.HasOne(d => d.Tag).WithMany(p => p.ProductTags)
                    .HasForeignKey(d => d.TagId)
                    .HasConstraintName("FK_ProductTags_Tag");
        }
    }
}