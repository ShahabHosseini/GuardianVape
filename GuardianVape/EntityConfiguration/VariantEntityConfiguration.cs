using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
using System.Reflection.Emit;

namespace DataAccess.EntityConfiguration
{
    internal class VariantEntityConfiguration : IEntityTypeConfiguration<Variant>
    {
        public void Configure(EntityTypeBuilder<Variant> builder)
        {
                 builder.ToTable("Variant");

                builder.Property(e => e.Id).HasColumnName("ID");
                builder.Property(e => e.ColorId).HasColumnName("ColorID");
                builder.Property(e => e.Guid)
                    .HasMaxLength(36)
                    .HasColumnName("GUID");
                builder.Property(e => e.Image)
                    .HasMaxLength(50)
                    .IsFixedLength();
                builder.Property(e => e.Price).HasColumnType("money");
                builder.Property(e => e.Title).HasMaxLength(50);
        }
    }
}