using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configuration
{
	public class CourseConfiguration : IEntityTypeConfiguration<Course>
	{
		public void Configure(EntityTypeBuilder<Course> builder)
		{
			builder.ToTable("Course");
			builder.Property(x => x.Id).IsRequired(true);
			builder.HasKey(x => x.Id);

			builder.Property(x => x.IdUser);
			builder.Property(x => x.IdTopic);
			builder.Property(x => x.IdCourseCategory);
			builder.Property(x => x.Name);
			builder.Property(x => x.Description);
			builder.HasOne(x => x.Topics).WithMany(x => x.Courses).HasForeignKey(x => x.IdTopic);
			builder.HasOne(x => x.CourseCategories).WithMany(x => x.Courses).HasForeignKey(x => x.IdCourseCategory);
		}
	}
}