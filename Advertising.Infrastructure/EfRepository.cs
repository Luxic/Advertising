using Advertising.Core.Entities;
using Advertising.Core.Interfaces;
using Advertising.Infrastructure.Advertising;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Advertising.Infrastructure
{
	public class EfRepository<T> : IAsyncRepository<T> where T : BaseEntity, IAggregateRoot  
	{
		protected readonly IDbContext _dbContext;

		public EfRepository(IDbContext context)
		{
			_dbContext = context;
		}

		public async Task<T> AddAsync(T entity)
		{

			await _dbContext.Set<T>().AddAsync(entity);
			_dbContext.SaveChanges();

			return entity;
		}

		public void DeleteAsync(T entity)
		{
			_dbContext.Remove(entity);
			_dbContext.SaveChanges();
		}

		public async Task<IEnumerable<T>> GetAllAsync()
		{
			return await _dbContext.Set<T>().ToListAsync();
		}

		public Task<IEnumerable<T>> GetAllAsync(IFiltering<T> filter)
		{
			throw new NotImplementedException();
		}

		public async Task<T> GetByIdAsync(int Id)
		{
			return await _dbContext.Set<T>().FindAsync(Id);
		}

		public Task UpdateAsync(T entity)
		{
			throw new NotImplementedException();
		}
	}
}
