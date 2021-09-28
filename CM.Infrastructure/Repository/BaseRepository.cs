using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using CM.Domain.Interface.Repository;
using CM.Infrastructure.Data;
using System.Linq;

namespace CM.Infrastructure.Repository
{
	public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
	{
		CMContext _context;
		DbSet<TEntity> _dbSet;

		public BaseRepository(CMContext context)
		{
			_context = context;
			_dbSet = _context.Set<TEntity>();
		}

		public void Add(TEntity entity)
		{
			_dbSet.Add(entity);
			//_context.SaveChanges();
		}

		public IEnumerable<TEntity> GetAll()
		{
			return _dbSet.AsEnumerable<TEntity>();
		}

		public TEntity GetById(int id)
		{
			return _dbSet.Find(id);
		}

		public void Remove(TEntity entity)
		{
			_dbSet.Remove(entity);
		}

		public void Update(TEntity entity)
		{
			_dbSet.Attach(entity);
			_context.Entry(entity).State = EntityState.Modified;
		}

		public void Dispose()
		{
			_context.Dispose();
		}
	}
}
