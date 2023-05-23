﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace DataAccess.EntityConfiguration
{
    internal class VendorEntityConfiguration : IEntityTypeConfiguration<Vendor>
    {
        public void Configure(EntityTypeBuilder<Vendor> builder)
        {
            builder.ToTable("Vendor");

            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Guid)
                .HasMaxLength(36)
                .HasColumnName("GUID");
            builder.Property(e => e.Title).HasMaxLength(50);
        }
    }
}