using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
	public class UserConfigurations : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.ToTable("Users");
			builder.Property(x => x.FullName).IsRequired(true).HasMaxLength(200);
			builder.Property(x => x.Sex).IsRequired(true);
			builder.Property(x => x.UserName).IsRequired(true);
			builder.Property(x => x.DoB).IsRequired(true);
			builder.Property(x => x.Age).IsRequired(true);
			builder.Property(x => x.AcademicLevelId).IsRequired(true);
			builder.HasOne(xt => xt.AcademicLevels).WithMany(x => x.Users).HasForeignKey(xt => xt.AcademicLevelId);
		}
	}
}