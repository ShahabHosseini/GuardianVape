using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace DataAccess.EntityConfiguration
{
    internal class AddressEntityConfiguration : IEntityTypeConfiguration<Address>
    {
        public AddressEntityConfiguration() { }

        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK_Address1");
            builder.ToTable("Address");
            builder.Property(e => e.Id).HasColumnName("ID");
                builder.Property(e => e.Address1)
                    .HasMaxLength(200)
                    .HasColumnName("Address");
            builder.Property(e => e.City).HasMaxLength(50);
            builder.Property(e => e.Company).HasMaxLength(50);
            builder.Property(e => e.CountryId).HasColumnName("CountryID");
            builder.Property(e => e.FristName).HasMaxLength(50);
            builder.Property(e => e.Guid)
                    .HasMaxLength(36)
                    .HasColumnName("GUID");
            builder.Property(e => e.House).HasMaxLength(50);
            builder.Property(e => e.LastName).HasMaxLength(50);
            builder.Property(e => e.PhoneId).HasColumnName("PhoneID");
            builder.Property(e => e.Postcode).HasMaxLength(10);
            builder.HasOne(d => d.Country).WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Address1_Address1");
        }
    }
}
