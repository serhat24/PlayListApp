using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class UserRepository : IUserRepository
    {
        public void AddEntity(User entity)
        {
            throw new NotImplementedException();
        }

        public void AddRangeEntities(IEnumerable<User> entities)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(User entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntityById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRangeEntity(IEnumerable<User> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetEntities()
        {
            throw new NotImplementedException();
        }

        public User GetEntityById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
