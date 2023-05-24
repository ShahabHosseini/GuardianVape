using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;


namespace DataAccess.EntityConfiguration
{
    internal class ConditionRoleEntityConfiguration : IEntityTypeConfiguration<ConditionRole>
    {
        public void Configure(EntityTypeBuilder<ConditionRole> builder)
        {
            builder.ToTable("ConditionRole");

            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Title).HasMaxLength(50);
        }
    }
}