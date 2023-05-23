using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace DataAccess.EntityConfiguration
{
    internal class TagEntityConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
                builder.ToTable("Tag");

                builder.Property(e => e.Id).HasColumnName("ID");
                builder.Property(e => e.Guid)
                    .HasMaxLength(36)
                    .HasColumnName("GUID");
                builder.Property(e => e.ParentId).HasColumnName("ParentID");
                builder.Property(e => e.Title).HasMaxLength(50);

                builder.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Tag_Tag");
        }
    }
}