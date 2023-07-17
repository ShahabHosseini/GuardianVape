using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace DataAccess.EntityConfiguration
{
    internal class ProductCollectionEntityConfiguration : IEntityTypeConfiguration<ProductCollection>
    {
        public void Configure(EntityTypeBuilder<ProductCollection> builder)
        {
                  builder.Property(e => e.Id).HasColumnName("ID");
                builder.Property(e => e.CollectionId).HasColumnName("CollectionID");
                builder.Property(e => e.ProductId).HasColumnName("ProductID");


                builder.HasOne(d => d.Product).WithMany(p => p.ProductCollections)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductCollections_Product");
        }
    }
}