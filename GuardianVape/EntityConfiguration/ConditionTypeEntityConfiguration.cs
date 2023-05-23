using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace DataAccess.EntityConfiguration
{
    internal class ConditionTypeEntityConfiguration : IEntityTypeConfiguration<ConditionType>
    {
        public void Configure(EntityTypeBuilder<ConditionType> builder)
        {
            builder.ToTable("ConditionType");

            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Guid)
                    .HasMaxLength(36)
                    .HasColumnName("GUID");
            builder.Property(e => e.Title).HasMaxLength(50);
        }
    }
}