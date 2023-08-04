using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace DataAccess.EntityConfiguration
{
    internal class ConditionEntityConfiguration : IEntityTypeConfiguration<Condition>
    {
        public void Configure(EntityTypeBuilder<Condition> builder)
        {
            builder.ToTable("Condition");

            builder.Property(e => e.Id).HasColumnName("ID");

            // Define the relationship
            builder.HasOne(c => c.ConditionType)
               .WithMany() // Change from WithOne() to WithMany()
               .HasForeignKey(c => c.ConditionTypeId) // Add foreign key property
               .OnDelete(DeleteBehavior.Restrict);


        }


    }
}
