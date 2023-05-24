using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace DataAccess.EntityConfiguration
{
    internal class RelatedTagEntityConfiguration : IEntityTypeConfiguration<RelatedTag>
    {
        public void Configure(EntityTypeBuilder<RelatedTag> builder)
        {
                builder.ToTable("RelatedTag");

                builder.Property(e => e.Id).HasColumnName("ID");
                builder.Property(e => e.CostumerId).HasColumnName("CostumerID");
                builder.Property(e => e.ProductId).HasColumnName("ProductID");

                builder.HasOne(d => d.Costumer).WithMany(p => p.RelatedTags)
                    .HasForeignKey(d => d.CostumerId)
                    .HasConstraintName("FK_RelatedTag_Customer");

                builder.HasOne(d => d.Product).WithMany(p => p.RelatedTags)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_RelatedTag_Product");
        }
    }
}