using Advertising.Core.Entities.Advertising;
using Advertising.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advertising.Infrastructure.Advertising
{
	public class PropertyRepository : EfRepository<Property>, IPropertyRepository
	{
		AdvertisingDbContext context;

		public PropertyRepository(AdvertisingDbContext dbContext) : base(dbContext)
		{
			context = dbContext;
		}

		public void AddProperty(CategoryProperty property)
		{
			context.Add(property);
		}

		public async Task<IEnumerable<Property>> GetByCategoryId(int? parrentCatId)
		{
			return await context.Property.Where(x => x.Id == parrentCatId).ToListAsync();
		}
	}
}
