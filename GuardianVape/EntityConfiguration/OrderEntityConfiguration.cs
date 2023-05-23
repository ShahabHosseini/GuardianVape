using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace DataAccess.EntityConfiguration
{
    internal class OrderEntityConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
                builder.ToTable("Order");
                builder.Property(e => e.Id).HasColumnName("ID");
                builder.Property(e => e.Channel).HasMaxLength(50);
                builder.Property(e => e.CustomerId).HasColumnName("CustomerID");
                builder.Property(e => e.Date).HasColumnType("datetime");
                builder.Property(e => e.DeliveryMethodId).HasColumnName("DeliveryMethodID");
                builder.Property(e => e.FulfillmentStatusId).HasColumnName("FulfillmentStatusID");
                builder.Property(e => e.Guid)
                    .HasMaxLength(36)
                    .HasColumnName("GUID");
                builder.Property(e => e.Name).HasMaxLength(50);
                builder.Property(e => e.OrderProductId).HasColumnName("OrderProductID");
                builder.Property(e => e.PaymentStatusId).HasColumnName("PaymentStatusID");
                builder.Property(e => e.Total).HasColumnType("decimal(18, 0)");

                builder.HasOne(d => d.Customer).WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Order_Customer");

                builder.HasOne(d => d.OrderProduct).WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderProductId)
                    .HasConstraintName("FK_Order_OrderProduct");
        }
    }
}