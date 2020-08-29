using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IRepository<TEntity>
    {
        TEntity GetEntity();
        List<TEntity> GetEntities();
        void AddEntity();
        void AddAllEntities();
        

    }
}
