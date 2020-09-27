using ayush.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Configuration
{
	public class NotificationConfiguration: IEntityTypeConfiguration<Notification>
	{
		public void Configure(EntityTypeBuilder<Notification> builder)
		{
			builder.HasKey(m => m.Id);
			builder.Property(m => m.Id).UseIdentityColumn();
			builder.Property(m => m.Title).HasMaxLength(50).IsRequired(true);
			builder.Property(m => m.Description).IsRequired(true);
			builder.Property(m => m.IsActive).IsRequired(true).HasDefaultValue(false);
			builder.Property(m => m.CreatedDate).IsRequired(true).HasDefaultValueSql("getdate()");
			builder.Property(m => m.CreatedDate).IsRequired(true);
		}
	}
}
