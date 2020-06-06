using Microsoft.EntityFrameworkCore;

namespace Advertising.Infrastructure
{
	public abstract class IDbContext : DbContext 
	{
		public IDbContext(DbContextOptions contextOptions) : base(contextOptions) 
		{ }
	}
}
