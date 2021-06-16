using Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Extensions
{
	public static class ModelBuilderExtensions
	{
		public static void Seed(this ModelBuilder modelBuilder)
		{
			var roleId = new Guid("9936B153-37A9-41D8-9781-F0532C25E732");
			var userId = new Guid("A0626E5F-0945-425C-9135-421CE9FFD4A1");
			var hasher = new PasswordHasher<User>();
			modelBuilder.Entity<User>().HasData(
				new User()
				{
					FullName = "Duy",
					Sex = true,
					Age = 18,
					AcademicLevelId = 1,
					DoB = new DateTime(12, 12, 2000),
					Email = "duy@gmail.com",
					NormalizedEmail = "duy@gmail.com",
					EmailConfirmed = true,
					Id = userId,
					UserName = "admin",
					NormalizedUserName = "admin",
					PasswordHash = hasher.HashPassword(null, "Admin@123"),
					SecurityStamp = string.Empty,
				}
				);
			modelBuilder.Entity<User>().HasData(
				new AcademicLevel()
				{
					Id = 1,
					Department = "student",
					ExperienceDetails = 10,
					Location = "student",
					ProgrammingLanguage = "c#",
					TOEICScore = 10,
				}
				);
		}
	}
}