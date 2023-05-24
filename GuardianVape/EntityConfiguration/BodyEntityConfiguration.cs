using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace DataAccess.EntityConfiguration
{
    internal class BodyEntityConfiguration : IEntityTypeConfiguration<Body>
    {
        public void Configure(EntityTypeBuilder<Body> builder)
        {
            builder.ToTable("Body");
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Media)
                    .HasMaxLength(50)
                    .IsFixedLength();
        }
    }
}
