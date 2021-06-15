using Data.Entities;
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
			modelBuilder.Entity<User>().HasData(
				new User()
				{
					Id = 1,
					Name = "Duy",
					Street = "Tran Phu",
				}
				);
		}
	}
}