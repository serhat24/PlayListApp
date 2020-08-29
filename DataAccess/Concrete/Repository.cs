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
        public bool AddEntity(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Add(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public bool AddRangeEntities(IEnumerable<TEntity> entities)
        {
            try
            {
                _context.Set<TEntity>().AddRange(entities);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
           
        }

        public bool DeleteEntity(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Remove(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public bool DeleteEntityById(int id)
        {
            var entity=_context.Find<TEntity>(id);

            try
            {
                if (entity != null)
                {
                    _context.Set<TEntity>().Remove(entity);
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            

        }

        public bool DeleteRangeEntity(IEnumerable<TEntity> entities)
        {
            try
            {
                _context.Set<TEntity>().RemoveRange(entities);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
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
