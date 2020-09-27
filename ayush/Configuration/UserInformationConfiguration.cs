using ayush.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ayush.Configuration
{
    public class UserInformationConfiguration : IEntityTypeConfiguration<UserInformation>
    {
        public void Configure(EntityTypeBuilder<UserInformation> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).UseIdentityColumn();
            builder.Property(m => m.Firstname).HasMaxLength(50).IsRequired(false);
            builder.Property(m => m.Lastname).HasMaxLength(50).IsRequired(false);
            builder.Property(m => m.Gender).HasMaxLength(10).IsRequired(false);
            builder.Property(m => m.ProfilePictureFilePath).IsRequired(false);
            builder.Property(m => m.Address).HasMaxLength(250).IsRequired(false);
            builder.Property(m => m.ClassName).HasMaxLength(20).IsRequired(false);
            builder.Property(m => m.SchoolName).HasMaxLength(50).IsRequired(false);
            builder.Property(m => m.DateOfBirth).IsRequired(false);
            builder.Property(m => m.FatherName).HasMaxLength(50).IsRequired(false);
            builder.Property(m => m.MotherName).HasMaxLength(50).IsRequired(false);
            builder.Property(m => m.FatherProfession).HasMaxLength(50).IsRequired(false);
            builder.Property(m => m.FatherQualification).HasMaxLength(50).IsRequired(false);
            builder.Property(m => m.MotherProfession).HasMaxLength(50).IsRequired(false);
            builder.Property(m => m.MotherQualification).HasMaxLength(50).IsRequired(false);
            builder.Property(m => m.LastTest).HasMaxLength(50).IsRequired(false);
            builder.Property(m => m.IsPlanPurchased).HasDefaultValue(false);
            builder.Property(m => m.CreatedOn).IsRequired().HasDefaultValueSql("getdate()");
            builder.HasOne(m => m.IdentityUser).WithMany(m => m.UserInformations).HasForeignKey(m => m.UserId);
            builder.Property(m => m.CodeSentOn).IsRequired(false);
            builder.Property(m => m.IscodeUsed).IsRequired(false);
            builder.Property(m => m.Code).IsRequired(false);            
        }
    }
}
