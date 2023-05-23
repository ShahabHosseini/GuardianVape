using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
using System.Reflection.Emit;

namespace DataAccess.EntityConfiguration
{
    internal class TimeLineEntityConfiguration : IEntityTypeConfiguration<TimeLine>
    {
        public void Configure(EntityTypeBuilder<TimeLine> builder)
        {
                builder.ToTable("TimeLine");

                builder.Property(e => e.Id).HasColumnName("ID");
                builder.Property(e => e.BodyId).HasColumnName("BodyID");
                builder.Property(e => e.CustomerId).HasColumnName("CustomerID");
                builder.Property(e => e.Guid)
                    .HasMaxLength(36)
                    .HasColumnName("GUID");
                builder.Property(e => e.Header).HasMaxLength(200);
                builder.Property(e => e.TimelineTypeId).HasColumnName("TimelineTypeID");
                builder.Property(e => e.UserId).HasColumnName("UserID");

                builder.HasOne(d => d.Body).WithMany(p => p.TimeLines)
                    .HasForeignKey(d => d.BodyId)
                    .HasConstraintName("FK_TimeLine_Body");

                builder.HasOne(d => d.Customer).WithMany(p => p.TimeLines)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_TimeLine_Customer");

                builder.HasOne(d => d.User).WithMany(p => p.TimeLines)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_TimeLine_User");
        }
    }
}