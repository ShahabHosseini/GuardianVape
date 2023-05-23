using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
using System.Reflection.Emit;

namespace DataAccess.EntityConfiguration
{
    internal class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
                builder.ToTable("User");

                builder.Property(e => e.Id).HasColumnName("ID");
                builder.Property(e => e.Guid)
                    .HasMaxLength(36)
                    .HasColumnName("GUID");
        }
    }
}