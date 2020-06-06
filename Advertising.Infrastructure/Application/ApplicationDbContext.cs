using Advertising.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Advertising.Infrastructure.Application
{
	public class ApplicationDbContext : IDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
		{
			
		}

		public DbSet<MenuForm> MenuForm { get; set; }
		public DbSet<DCForm> DCForm { get; set; }
		public DbSet<DCLink> DCLink { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
		}
	}
}
