using Advertising.Core.Interfaces;
using Advertising.Infrastructure;
using Advertising.Infrastructure.Advertising;
using Advertising.Infrastructure.Application;
using Advertising.Infrastructure.Identity;
using Advertising.Interfaces;
using Advertising.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation;

namespace Advertising
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public void ConfigureDevelopmentServices(IServiceCollection services)
		{
			services.AddDbContext<IdentityDbContext>(options =>
				options.UseSqlServer(
					Configuration.GetConnectionString("AdministrationConnection"), x=>x.MigrationsAssembly("Advertising.Infrastructure")));

			services.AddDbContext<AdvertisingDbContext>(options =>
				options.UseSqlServer(
					Configuration.GetConnectionString("AdvertisingConnection")));

			services.AddDbContext<ApplicationDbContext>(options =>
				options.UseSqlServer(
					Configuration.GetConnectionString("AdministrationConnection")));

			ConfigureServices(services);
		}

		public void ConfigureServices(IServiceCollection services)
		{
			CreateIdentity(services);

			services.AddScoped(typeof(IAsyncRepository<>),typeof(EfRepository<>));
			services.AddScoped<ICategoryViewModelService, CategoryViewModelService>();
			services.AddScoped<IApplicationService, ApplicationService>();
			services.AddScoped<IMenuFormRepository, MenuFormRepository>();
			services.AddScoped<ICategoryRepository, CategoryRepository>();
			services.AddScoped<IPropertyRepository, PropertyRepository>();


			services.AddMvc();
			var mvcBuilder = services.AddControllersWithViews();

#if DEBUG
			mvcBuilder.AddRazorRuntimeCompilation();
#endif

			services.AddRazorPages();
		}

		private void CreateIdentity(IServiceCollection services)
		{
			var sp = services.BuildServiceProvider();
			using (var scope = sp.CreateScope())
			{
				var existingUserManager = scope.ServiceProvider
					.GetService<UserManager<ApplicationUser>>();
				if (existingUserManager == null)
				{
					services.AddIdentity<ApplicationUser, IdentityRole>()
						.AddDefaultUI()
						.AddEntityFrameworkStores<IdentityDbContext>()
										.AddDefaultTokenProviders();
				}
			}
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseDatabaseErrorPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthentication();
			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
				endpoints.MapRazorPages();
			});
		}
	}
}
