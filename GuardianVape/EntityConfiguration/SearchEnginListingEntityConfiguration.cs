using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace DataAccess.EntityConfiguration
{
    internal class SearchEnginListingEntityConfiguration : IEntityTypeConfiguration<SearchEnginListing>
    {
        public void Configure(EntityTypeBuilder<SearchEnginListing> builder)
        {
                builder.ToTable("SearchEnginListing");

                builder.Property(e => e.Id).HasColumnName("ID");
                builder.Property(e => e.MetaDescription).HasMaxLength(320);
                builder.Property(e => e.PageTitle).HasMaxLength(70);
                builder.Property(e => e.Urlhandle)
                    .HasMaxLength(100)
                    .HasColumnName("URLHandle");
        }
    }
}