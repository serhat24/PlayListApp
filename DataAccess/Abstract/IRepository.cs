using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IRepository<TEntity> where TEntity:class
    {
        TEntity GetEntityById(int id);
        IEnumerable<TEntity> GetEntities();

        void AddEntity(TEntity entity);
        void AddRangeEntities(IEnumerable<TEntity> entities);

        void DeleteEntity(TEntity entity);
        void DeleteEntityById(int id);
        void DeleteRangeEntity(IEnumerable<TEntity> entities);

    }
}
