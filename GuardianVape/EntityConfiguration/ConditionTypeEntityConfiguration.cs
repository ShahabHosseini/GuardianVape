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
        }
    }
}
