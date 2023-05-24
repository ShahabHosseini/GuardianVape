using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
using System.Reflection.Emit;

namespace DataAccess.EntityConfiguration
{
    internal class ProductTypeEntityConfiguration : IEntityTypeConfiguration<ProductType>
    {
        public void Configure(EntityTypeBuilder<ProductType> builder)
        {
                builder.ToTable("ProductType");

                builder.Property(e => e.Id).HasColumnName("ID");
                builder.Property(e => e.Title).HasMaxLength(50);
        }
    }
}