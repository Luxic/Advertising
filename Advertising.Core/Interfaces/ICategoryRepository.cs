
using Advertising.Core.Entities;
using Advertising.Core.Entities.Advertising;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Advertising.Core.Interfaces
{
	public interface ICategoryRepository : IAsyncRepository<Category>
	{
		Task<IEnumerable<Category>> GetByParrentId(int? parrentId);
		Task<IEnumerable<DataType>> GetDataTypes();
	}
}
