using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
using System.Reflection.Emit;

namespace DataAccess.EntityConfiguration
{
    internal class OrderProductEntityConfiguration : IEntityTypeConfiguration<OrderProduct>
    {
        public void Configure(EntityTypeBuilder<OrderProduct> builder)
        {
                builder.ToTable("OrderProduct");

                builder.Property(e => e.Id).HasColumnName("ID");
                builder.Property(e => e.Guid)
                    .HasMaxLength(36)
                    .HasColumnName("GUID");
                builder.Property(e => e.OrderId).HasColumnName("OrderID");
                builder.Property(e => e.ProductId).HasColumnName("ProductID");

                builder.HasOne(d => d.Order).WithMany(p => p.OrderProducts)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderProduct_Order");

                builder.HasOne(d => d.Product).WithMany(p => p.OrderProducts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_OrderProduct_Product");
        }
    }
}