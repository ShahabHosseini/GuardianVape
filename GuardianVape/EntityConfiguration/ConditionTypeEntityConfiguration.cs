using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace DataAccess.EntityConfiguration
{
    public class ConditionTypeEntityConfiguration : IEntityTypeConfiguration<ConditionType>
    {
        public void Configure(EntityTypeBuilder<ConditionType> builder)
        {
            builder.ToTable("ConditionType");
            builder.HasKey(e => e.Id); // Add primary key definition

            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Title).HasMaxLength(50);

            // Add navigation property for the one-to-many relationship
            builder.HasMany(c => c.Conditions)
                   .WithOne(c => c.ConditionType)
                   .HasForeignKey(c => c.ConditionTypeId) // Add foreign key property
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
