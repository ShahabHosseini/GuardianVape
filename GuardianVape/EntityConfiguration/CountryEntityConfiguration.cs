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
            builder.Property(e => e.AreaCode).HasMaxLength(10);
            builder.Property(e => e.Title).HasMaxLength(50);
        }
    }
}
