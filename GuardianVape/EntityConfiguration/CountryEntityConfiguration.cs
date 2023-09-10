using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace DataAccess.EntityConfiguration
{
    internal class CountryEntityConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Country");

            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Numcode).HasMaxLength(6);
            builder.Property(e => e.Iso3).HasMaxLength(3);

            builder.Property(e => e.Phonecode).HasMaxLength(5);


            builder.Property(e => e.Title).HasMaxLength(50);
        }
    }
}
