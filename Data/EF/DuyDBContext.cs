using Data.Configuration;
using Data.Entities;
using Data.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data.EF
{
	public class DuyDBContext : DbContext
	{
		public DuyDBContext(DbContextOptions options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new AcademicLevelConfiguration());
			modelBuilder.ApplyConfiguration(new UserConfigurations());
			modelBuilder.ApplyConfiguration(new CourseCategoryConfiguration());
			modelBuilder.ApplyConfiguration(new CourseConfiguration());
			modelBuilder.ApplyConfiguration(new GroupUserConfiguration());
			modelBuilder.ApplyConfiguration(new TopicConfiguration());
			modelBuilder.ApplyConfiguration(new EnrollmentConfiguration());

			modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
			modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
			modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);
			modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaim");
			modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserToken").HasKey(x => x.UserId);

			modelBuilder.Seed();
			base.OnModelCreating(modelBuilder);
		}

		public DbSet<AcademicLevel> AcademicLevel { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Course> Course { get; set; }
		public DbSet<CourseCategory> CourseCategory { get; set; }
		public DbSet<Topic> Topic { get; set; }
		public DbSet<GroupUser> GroupUser { get; set; }
		public DbSet<Enrollment> Enrollments { get; set; }
	}
}