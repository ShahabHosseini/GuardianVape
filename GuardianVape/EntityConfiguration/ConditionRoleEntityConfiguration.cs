using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;


namespace DataAccess.EntityConfiguration
{
    internal class ConditionRoleEntityConfiguration : IEntityTypeConfiguration<ConditionType>
    {
        public void Configure(EntityTypeBuilder<ConditionType> builder)
        {
            builder.ToTable("ConditionRole");

            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Title).HasMaxLength(50);
        }
    }
}