using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Data.EF
{
	public class DuyDbContextFactory : IDesignTimeDbContextFactory<DuyDBContext>
	{
		public DuyDBContext CreateDbContext(string[] args)
		{
			IConfigurationRoot configuration = new ConfigurationBuilder()
			.SetBasePath(Directory.GetCurrentDirectory())
			.AddJsonFile("appsettings.json")
			.Build();
			var connectionString = configuration.GetConnectionString("DefaultConnection");
			var optionsBuilder = new DbContextOptionsBuilder<DuyDBContext>();
			optionsBuilder.UseSqlServer(connectionString);
			return new DuyDBContext(optionsBuilder.Options);
		}
	}
}