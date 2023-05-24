using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
using System.Reflection.Emit;

namespace DataAccess.EntityConfiguration
{
    internal class UnitEntityConfiguration : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> builder)
        {
                 builder.ToTable("Unit");

                builder.Property(e => e.Id).HasColumnName("ID");
                builder.Property(e => e.Title).HasMaxLength(50);
        }
    }
}