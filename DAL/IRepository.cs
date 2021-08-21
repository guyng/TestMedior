using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
	public interface IRepository<T> where T : class
	{
		DbSet<T> Table { get; set; }

		IQueryable<T> Query();
		Task<T> GetAsync(int id);

		Task InsertAsync(T entity);
		Task<List<T>> AddManyAsync(List<T> entities);

		Task UpdateAsync(T entity);

		Task RemoveAsync(T entity);
	}
}
