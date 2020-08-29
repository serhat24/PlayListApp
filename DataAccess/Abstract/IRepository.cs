using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IRepository<TEntity> where TEntity:class
    {
        TEntity GetEntityById(int id);
        IEnumerable<TEntity> GetEntities();

        bool AddEntity(TEntity entity);
        bool AddRangeEntities(IEnumerable<TEntity> entities);

        bool DeleteEntity(TEntity entity);
        bool DeleteEntityById(int id);
        bool DeleteRangeEntity(IEnumerable<TEntity> entities);

    }
}
