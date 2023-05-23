using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace DataAccess.EntityConfiguration
{
    internal class ShopLocationEntityConfiguration : IEntityTypeConfiguration<ShopLocation>
    {
        public void Configure(EntityTypeBuilder<ShopLocation> builder)
        {
                builder.ToTable("ShopLocation");

                builder.Property(e => e.Id).HasColumnName("ID");
                builder.Property(e => e.Guid)
                    .HasMaxLength(36)
                    .HasColumnName("GUID");
                builder.Property(e => e.InventoryId).HasColumnName("InventoryID");

                builder.HasOne(d => d.Inventory).WithMany(p => p.ShopLocations)
                    .HasForeignKey(d => d.InventoryId)
                    .HasConstraintName("FK_ShopLocation_Product");
        }
    }
}