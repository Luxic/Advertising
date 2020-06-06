using Advertising.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Advertising.Core.Interfaces
{
	public interface IMenuFormRepository : IAsyncRepository<MenuForm>
	{
		Task<IEnumerable<MenuForm>> GetAll();
	}
}
