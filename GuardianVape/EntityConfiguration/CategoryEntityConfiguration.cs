using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfiguration
{
    internal class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");

            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.CategoryGroupId).HasColumnName("CategoryGroupID");
            builder.Property(e => e.Title).HasMaxLength(50);

            builder.HasOne(d => d.CategoryGroup).WithMany(p => p.Categories)
                .HasForeignKey(d => d.CategoryGroupId)
                .HasConstraintName("FK_Category_CategoryGroup");
        }
    }
}
