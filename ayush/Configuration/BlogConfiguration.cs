using ayush.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ayush.Configuration
{
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
	{
		public void Configure(EntityTypeBuilder<Blog> builder)
		{
			builder.HasKey(m => m.Id);
			builder.Property(m => m.Id).UseIdentityColumn();
			builder.Property(m => m.Title).HasMaxLength(50).IsRequired(true);
			builder.Property(m => m.Description).IsRequired(true);
			builder.Property(m => m.IsActive).IsRequired(true).HasDefaultValue(false);
			builder.Property(m => m.ClassId).IsRequired(false);
			builder.Property(m => m.FeaturedImagePath).IsRequired(false);
			builder.Property(m => m.SubmittedDate).IsRequired(true).HasDefaultValueSql("getdate()");
		}
	}
}
