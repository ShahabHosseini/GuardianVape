using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace DataAccess.EntityConfiguration
{
    internal class PhoneEntityConfiguration : IEntityTypeConfiguration<Phone>
    {
        public void Configure(EntityTypeBuilder<Phone> builder)
        {
                builder.ToTable("Phone");

                builder.Property(e => e.Id).HasColumnName("ID");
                builder.Property(e => e.AreaCode)
                    .HasMaxLength(10)
                    .IsFixedLength();
                builder.Property(e => e.PhoneNumber).HasMaxLength(12);
        }
    }
}