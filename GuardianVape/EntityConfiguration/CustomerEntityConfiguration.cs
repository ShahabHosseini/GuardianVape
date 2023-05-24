using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
using System.Reflection.Emit;

namespace DataAccess.EntityConfiguration
{
    internal class CustomerEntityConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");

            builder.Property(e => e.Id).HasColumnName("ID");
                builder.Property(e => e.AddressId).HasColumnName("AddressID");
                builder.Property(e => e.AgreedSms).HasColumnName("AgreedSMS");
                builder.Property(e => e.Email).HasMaxLength(50);
                builder.Property(e => e.FristName).HasMaxLength(50);
                builder.Property(e => e.Language)
                    .HasMaxLength(10)
                    .IsFixedLength();
                builder.Property(e => e.LastName).HasMaxLength(50);
                builder.Property(e => e.Note).HasMaxLength(500);
                builder.Property(e => e.PhoneId).HasColumnName("PhoneID");

                builder.HasOne(d => d.Address).WithMany(p => p.Customers)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_Customer_Address");

                builder.HasOne(d => d.Phone).WithMany(p => p.Customers)
                    .HasForeignKey(d => d.PhoneId)
                    .HasConstraintName("FK_Customer_Customer");
        }
    }
}