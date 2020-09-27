using ayush.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Configuration
{
	public class SystemInformationConfiguration: IEntityTypeConfiguration<SystemInformation>
	{
		public void Configure(EntityTypeBuilder<SystemInformation> builder)
		{
			builder.HasKey(m => m.Id);
			builder.Property(m => m.Id).UseIdentityColumn();
			builder.Property(m => m.PropertyName).HasMaxLength(50).IsRequired(true);
			builder.Property(m => m.PropertyValue).HasMaxLength(50).IsRequired(true);
		}
	}
}
