
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace Core
{
    public class UnitOfWork : IUnitOfWork
    {

        private DbContext _dbContext;

        public UnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;
            UserRepository = new UserRepository(_playListAppContext);

        }

        public IUserRepository UserRepository { get; private set; }

        public int Complete()
        {
            return _playListAppContext.SaveChanges();
        }

        public void Dispose()
        {
            _playListAppContext.Dispose();
        }

       
    }
}
