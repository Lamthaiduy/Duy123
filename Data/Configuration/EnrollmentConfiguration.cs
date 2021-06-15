using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configuration
{
	public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
	{
		public void Configure(EntityTypeBuilder<Enrollment> builder)
		{
			builder.ToTable("Enrollment");
			builder.Property(x => x.Id).UseIdentityColumn();
			builder.HasKey(x => x.Id);
			builder.Property(x => x.IdCourse);
			builder.Property(x => x.IdUser);
			builder.HasOne(x => x.Users).WithMany(x => x.Enrollments).HasForeignKey(x => x.IdUser);
			builder.HasOne(x => x.Courses).WithMany(x => x.Enrollments).HasForeignKey(x => x.IdCourse);
		}
	}
}