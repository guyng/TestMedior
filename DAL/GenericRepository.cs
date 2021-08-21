using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
	public class GenericRepository<T> : IRepository<T>, IDisposable
		where T : class, new()
	{
		public DbSet<T> Table { get; set; }
		public TestMediorContext DbContext { get; set; }
		public GenericRepository(TestMediorContext dbContext)
		{
			DbContext = dbContext;
			Table = DbContext.Set<T>();
		}

		public IQueryable<T> Query()
		{
			return Table.AsQueryable();
		}

		public async Task<T> GetAsync(int id)
		{
			return await DbContext.FindAsync<T>(id);
		}

		public async Task InsertAsync(T entity)
		{
			await Table.AddAsync(entity);
			await DbContext.SaveChangesAsync();
		}

		public async Task<List<T>> AddManyAsync(List<T> entities)
		{
			await Table.AddRangeAsync(entities);
			await DbContext.SaveChangesAsync();
			return entities;
		}

		public async Task UpdateAsync(T entity)
		{
			DbContext.Entry(entity).State = EntityState.Modified;
			await DbContext.SaveChangesAsync();
		}

		public async Task RemoveAsync(T entity)
		{
			DbContext.Remove(entity);
			await DbContext.SaveChangesAsync();
		}

		public void Dispose()
		{
			DbContext?.Dispose();
		}
	}
}
