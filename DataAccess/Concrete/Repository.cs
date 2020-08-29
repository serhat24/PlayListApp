using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected DbContext _context;
        public Repository(DbContext context)
        {
            _context = context;
        }
        public void AddEntity(TEntity entity)
        {
              _context.Set<TEntity>().Add(entity);
                
        }

        public void AddRangeEntities(IEnumerable<TEntity> entities)
        {
                _context.Set<TEntity>().AddRange(entities);
        }

        public void DeleteEntity(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public void DeleteEntityById(int id)
        {
            var entity=_context.Find<TEntity>(id);

                if (entity != null)
                {
                    _context.Set<TEntity>().Remove(entity);
                }
        }

        public void DeleteRangeEntity(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
            
        }

        public IEnumerable<TEntity> GetEntities()
        {
           return _context.Set<TEntity>().ToList();
        }

        public TEntity GetEntityById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

    }
}
