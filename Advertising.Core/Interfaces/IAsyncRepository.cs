using Advertising.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Advertising.Core.Interfaces
{
	public interface IAsyncRepository<T> where T : BaseEntity, IAggregateRoot
	{
		Task<T> GetByIdAsync(int Id);
		Task<IEnumerable<T>> GetAllAsync();
		Task<IEnumerable<T>> GetAllAsync(IFiltering<T> filter);
		Task<T> AddAsync(T entity);
		Task UpdateAsync(T entity);
		void DeleteAsync(T entity);
	}
}
