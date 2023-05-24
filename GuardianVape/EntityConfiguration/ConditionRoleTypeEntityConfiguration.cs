using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
using System.Reflection.Emit;

namespace DataAccess.EntityConfiguration
{
    internal class ConditionRoleTypeEntityConfiguration : IEntityTypeConfiguration<ConditionRoleType>
    {
        public void Configure(EntityTypeBuilder<ConditionRoleType> builder)
        {
            builder.ToTable("ConditionRoleType");

            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.CategoryId).HasColumnName("CategoryID");
            builder.Property(e => e.CollectionId).HasColumnName("CollectionID");
            builder.Property(e => e.ConditionRoleId).HasColumnName("ConditionRoleID");
            builder.Property(e => e.ConditionTypeId).HasColumnName("ConditionTypeID");
            builder.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");
            builder.Property(e => e.TagId).HasColumnName("TagID");
            builder.Property(e => e.VendorId).HasColumnName("VendorID");

            builder.HasOne(d => d.Category).WithMany(p => p.ConditionRoleTypes)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_ConditionRoleType_Category");

            builder.HasOne(d => d.Collection).WithMany(p => p.ConditionRoleTypes)
                .HasForeignKey(d => d.CollectionId)
                .HasConstraintName("FK_ConditionRoleType_Collection");

            builder.HasOne(d => d.ConditionRole).WithMany(p => p.ConditionRoleTypes)
                .HasForeignKey(d => d.ConditionRoleId)
                .HasConstraintName("FK_ConditionRoleType_ConditionRole");

            builder.HasOne(d => d.ConditionType).WithMany(p => p.ConditionRoleTypes)
                .HasForeignKey(d => d.ConditionTypeId)
                .HasConstraintName("FK_ConditionRoleType_ConditionType");

            builder.HasOne(d => d.ProductType).WithMany(p => p.ConditionRoleTypes)
                .HasForeignKey(d => d.ProductTypeId)
                .HasConstraintName("FK_ConditionRoleType_ProductType");

            builder.HasOne(d => d.Tag).WithMany(p => p.ConditionRoleTypes)
                .HasForeignKey(d => d.TagId)
                .HasConstraintName("FK_ConditionRoleType_Tag");

            builder.HasOne(d => d.Vendor).WithMany(p => p.ConditionRoleTypes)
                .HasForeignKey(d => d.VendorId)
                .HasConstraintName("FK_ConditionRoleType_Vendor");
        }
    }
}