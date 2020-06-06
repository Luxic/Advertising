using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Advertising.Infrastructure.Identity
{
	public class IdentityDbContext : IdentityDbContext<ApplicationUser>
	{
		public IdentityDbContext(DbContextOptions<IdentityDbContext> options) : base(options)
		{ }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);


		}
	}
}


//protected override void OnModelCreating(ModelBuilder modelBuilder)
//{
//	modelBuilder.Entity<Course>().ToTable("Course");
//	modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
//	modelBuilder.Entity<Student>().ToTable("Student");
//}