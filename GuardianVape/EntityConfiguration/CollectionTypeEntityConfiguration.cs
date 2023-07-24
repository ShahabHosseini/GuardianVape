using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace DataAccess.EntityConfiguration
{
    public class CollectionTypeEntityConfiguration : IEntityTypeConfiguration<CollectionType>
    {
        public void Configure(EntityTypeBuilder<CollectionType> builder)
        {
            builder.ToTable("CollectionType");
            builder.HasKey(e => e.Id); // Add primary key definition

            // Configure other properties as needed
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.CollType).IsRequired();
            builder.Property(e => e.ConditionType).IsRequired();
            builder.HasMany(e => e.Conditions)
                .WithOne(c => c.CollectionType)
                .HasForeignKey(c => c.CollectionTypeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
