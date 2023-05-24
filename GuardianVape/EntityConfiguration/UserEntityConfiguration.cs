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
            builder.Property(e => e.FristName).HasMaxLength(50);
            builder.Property(e => e.LastName).HasMaxLength(50);
            builder.Property(e => e.UserName).HasMaxLength(50);
            builder.Property(e => e.Email).HasMaxLength(50);
        }
    }
}