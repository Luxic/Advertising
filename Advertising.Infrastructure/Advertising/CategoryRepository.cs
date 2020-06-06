using Advertising.Core.Entities;
using Advertising.Core.Entities.Advertising;
using Advertising.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertising.Infrastructure.Advertising
{
	public class CategoryRepository : EfRepository<Category>, ICategoryRepository
	{
		AdvertisingDbContext context;

		public CategoryRepository(AdvertisingDbContext dbContext) : base(dbContext)
		{
			context = dbContext;
		}

		public async Task<IEnumerable<Category>> GetByParrentId(int? parrentCatId)
		{
			return await context.Category.Where(x=>x.ParrentCategoryId == parrentCatId).ToListAsync();
		}

		public async Task<IEnumerable<DataType>> GetDataTypes()
		{
			return await context.DataTypes.ToListAsync();
		}

		
	}
}
