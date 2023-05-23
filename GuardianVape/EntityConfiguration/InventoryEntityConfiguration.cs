using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace DataAccess.EntityConfiguration
{
    internal class InventoryEntityConfiguration : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
                builder.ToTable("Inventory");

                builder.Property(e => e.Id).HasColumnName("ID");
                builder.Property(e => e.Barcode).HasMaxLength(50);
                builder.Property(e => e.Guid)
                    .HasMaxLength(36)
                    .HasColumnName("GUID");
                builder.Property(e => e.ProductId).HasColumnName("ProductID");
                builder.Property(e => e.ShopLocationId).HasColumnName("ShopLocationID");
                builder.Property(e => e.Sku)
                    .HasMaxLength(50)
                    .HasColumnName("SKU");

                builder.HasOne(d => d.Product).WithMany(p => p.Inventories)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inventory_Product");
        }
    }
}