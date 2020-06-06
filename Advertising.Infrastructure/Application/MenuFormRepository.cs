using Advertising.Core.Entities;
using Advertising.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advertising.Infrastructure.Application
{
	public class MenuFormRepository : EfRepository<MenuForm>, IMenuFormRepository
	{
		ApplicationDbContext context;
		public MenuFormRepository(ApplicationDbContext dbContext) : base(dbContext)
		{
			context = dbContext;
		}

		public async Task<IEnumerable<MenuForm>> GetAll()
		{
			return await context.MenuForm
				.Include(o => o.DCForm)
				.Include(x => x.DCForm.DCLink)
				.Include(x => x.childMenuForms)
				.ToListAsync();

			//(from s in context.MenuForm
			// join sa in context.DCForm on s.DCFormId equals sa.Id
			// join link in context.DCLink on sa.DCLinkId equals link.ID
			// select s).ToListAsync();

			//.Include(o => o.DCForm)
			//.Include(x=>x.DCForm.DCLink)
			//.Include(x => x.childMenuForms)
			//.ToListAsync();				
		}
	}
}
