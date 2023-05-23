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
            builder.Property(e => e.Guid)
                    .HasMaxLength(36)
                    .HasColumnName("GUID");
            builder.Property(e => e.MetaDescription).HasMaxLength(500);
            builder.Property(e => e.PageTitle).HasMaxLength(50);
            builder.Property(e => e.ParentId).HasColumnName("ParentID");
            builder.Property(e => e.Title).HasMaxLength(50);

            builder.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Collection_Collection1");
        }
    }
}
