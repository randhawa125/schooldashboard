using ayush.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Configuration
{
	public class OneTimePasswordConfiguration : IEntityTypeConfiguration<OneTimePassword>
    {
        public void Configure(EntityTypeBuilder<OneTimePassword> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).UseIdentityColumn();
            builder.Property(m => m.CreatedOn).HasDefaultValueSql("getdate()").IsRequired(true);
            builder.Property(m => m.Key).HasMaxLength(50).IsRequired(true);
            builder.Property(m => m.Value).HasMaxLength(50).IsRequired(true);
            builder.Property(m => m.IsKeyUsed).HasDefaultValue(false).IsRequired(true);
        }
    }
}
