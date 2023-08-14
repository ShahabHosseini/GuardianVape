using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace DataAccess.EntityConfiguration
{
    internal class CollectionEntityConfiguration : IEntityTypeConfiguration<Collection>
    {
        public void Configure(EntityTypeBuilder<Collection> builder)
        {
            builder.ToTable("Collection");

            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Description).HasMaxLength(500);

            builder.Property(e => e.Title).HasMaxLength(50);

            builder.HasOne(e => e.Parent) // Self-referencing navigation property
                .WithMany()               // Each collection can have multiple child collections
                .HasForeignKey(e => e.ParentId) // Foreign key property in the entity
                .OnDelete(DeleteBehavior.Restrict); // Define delete behavior if needed
        }

    }
}

