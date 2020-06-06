using Advertising.Core.Entities.Advertising;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Advertising.Core.Interfaces
{
	public interface IPropertyRepository : IAsyncRepository<Property>
	{
		Task<IEnumerable<Property>> GetByCategoryId(int? parrentId);
		void AddProperty(CategoryProperty property);
	}
}
