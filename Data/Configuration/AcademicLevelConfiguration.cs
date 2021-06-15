using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configuration
{
	public class AcademicLevelConfiguration : IEntityTypeConfiguration<AcademicLevel>
	{
		public void Configure(EntityTypeBuilder<AcademicLevel> builder)
		{
			builder.ToTable("AcademicLevel");
			builder.Property(x => x.Id).IsRequired(true);
			builder.HasKey(x => x.Id);

			builder.Property(x => x.ExperienceDetails);
			builder.Property(x => x.ProgrammingLanguage);
			builder.Property(x => x.TOEICScore);
			builder.Property(x => x.Location);
		}
	}
}