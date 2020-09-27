using ayush.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ayush.Configuration
{
    public class UserSiblingConfiguration : IEntityTypeConfiguration<UserSibling>
    {
        public void Configure(EntityTypeBuilder<UserSibling> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).UseIdentityColumn();
            builder.Property(m => m.Firstname).HasMaxLength(50).IsRequired();
            builder.Property(m => m.Lastname).HasMaxLength(50).IsRequired();
            builder.Property(m => m.Gender).HasMaxLength(10).IsRequired();
            builder.Property(m => m.DateOfBirth).IsRequired();
            builder.HasOne(m => m.IdentityUser).WithMany(m => m.Siblings).HasForeignKey(m => m.UserId);
            builder.ToTable("UserSibling");
        }
    }
}
