using Advertising.Core.Entities;
using Advertising.Core.Entities.Advertising;
using Microsoft.EntityFrameworkCore;

namespace Advertising.Infrastructure.Advertising
{
	public class AdvertisingDbContext : IDbContext
	{
		public AdvertisingDbContext(DbContextOptions<AdvertisingDbContext> options) : base(options)
		{ }

		public DbSet<Category> Category { get; set; }

		public DbSet<Property> Property { get; set; }

		public DbSet<CategoryProperty> CategoryProperties { get; set; }

		public DbSet<DataType> DataTypes { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			//builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}
	}
}
