using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace DataAccess.EntityConfiguration
{
    internal class ProductVariantEntityConfiguration : IEntityTypeConfiguration<ProductVariant>
    {
        public void Configure(EntityTypeBuilder<ProductVariant> builder)
        {
                builder.Property(e => e.Id).HasColumnName("ID");
                builder.Property(e => e.ProductId).HasColumnName("ProductID");
                builder.Property(e => e.Value).HasMaxLength(50);
                builder.Property(e => e.VariantId).HasColumnName("VariantID");

                builder.HasOne(d => d.Product).WithMany(p => p.ProductVariants)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductVariants_Product");

                builder.HasOne(d => d.Variant).WithMany(p => p.ProductVariants)
                    .HasForeignKey(d => d.VariantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductVariants_Variant");
        }
    }
}