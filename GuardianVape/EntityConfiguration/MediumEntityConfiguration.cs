using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace DataAccess.EntityConfiguration
{
    internal class MediumEntityConfiguration : IEntityTypeConfiguration<Medium>
    {
        public void Configure(EntityTypeBuilder<Medium> builder)
        {
                builder.Property(e => e.Id).HasColumnName("ID");
                builder.Property(e => e.CollectionId).HasColumnName("CollectionID");
                builder.Property(e => e.ProductId).HasColumnName("ProductID");
                builder.Property(e => e.Url)
                    .HasMaxLength(50)
                    .HasColumnName("URL");
                builder.Property(e => e.Value)
                    .HasMaxLength(50)
                    .IsFixedLength();

                builder.HasOne(d => d.Collection).WithMany(p => p.MediaNavigation)
                    .HasForeignKey(d => d.CollectionId)
                    .HasConstraintName("FK_Media_Collection");

                builder.HasOne(d => d.Product).WithMany(p => p.Media)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Media_Product");
        }
    }
}