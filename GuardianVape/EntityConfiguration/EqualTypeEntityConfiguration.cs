using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfiguration
{
    public  class EqualTypeEntityConfiguration: IEntityTypeConfiguration<EqualType>
    {
        public void Configure(EntityTypeBuilder<EqualType> builder)
        {
            builder.ToTable("EqualType");
            builder.HasKey(e => e.Id); // Add primary key definition

            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Title).HasMaxLength(50);

            // Add navigation property for the one-to-many relationship
            builder.HasMany(c => c.Conditions)
                   .WithOne(c => c.EqualType)
                   .HasForeignKey(c => c.EqualTypeId) // Add foreign key property
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
