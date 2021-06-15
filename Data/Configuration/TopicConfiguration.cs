using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configuration
{
	public class TopicConfiguration : IEntityTypeConfiguration<Topic>
	{
		public void Configure(EntityTypeBuilder<Topic> builder)
		{
			builder.ToTable("Topic");
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).IsRequired(true);
			builder.Property(x => x.Name);
		}
	}
}