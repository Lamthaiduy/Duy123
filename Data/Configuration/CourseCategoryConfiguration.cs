using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configuration
{
	public class CourseCategoryConfiguration : IEntityTypeConfiguration<CourseCategory>
	{
		public void Configure(EntityTypeBuilder<CourseCategory> builder)
		{
			builder.ToTable("CourseCategory");
			builder.Property(x => x.Id).IsRequired(true);
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Name);
		}
	}
}