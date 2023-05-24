using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace DataAccess.EntityConfiguration
{
    internal class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
                builder.ToTable("Product");

                builder.Property(e => e.Id).HasColumnName("ID");
                builder.Property(e => e.CategoryId).HasColumnName("CategoryID");
                builder.Property(e => e.CompareatPrice).HasColumnType("decimal(18, 0)");
                builder.Property(e => e.CostPerItem).HasColumnType("decimal(18, 0)");
                builder.Property(e => e.Description).HasMaxLength(1000);
                builder.Property(e => e.Price).HasColumnType("decimal(18, 0)");
                builder.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");
                builder.Property(e => e.SearchEnginListingId).HasColumnName("SearchEnginListingID");
                builder.Property(e => e.Title).HasMaxLength(100);
                builder.Property(e => e.UnitId).HasColumnName("UnitID");
                builder.Property(e => e.VendorId).HasColumnName("VendorID");

                builder.HasOne(d => d.Category).WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Category");

                builder.HasOne(d => d.ProductType).WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductTypeId)
                    .HasConstraintName("FK_Product_ProductType");

                builder.HasOne(d => d.SearchEnginListing).WithMany(p => p.Products)
                    .HasForeignKey(d => d.SearchEnginListingId)
                    .HasConstraintName("FK_Product_SearchEnginListing");

                builder.HasOne(d => d.Unit).WithMany(p => p.Products)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Unit");

                builder.HasOne(d => d.Vendor).WithMany(p => p.Products)
                    .HasForeignKey(d => d.VendorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Vendor");
        }
    }
}