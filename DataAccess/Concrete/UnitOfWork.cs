using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {

        private PlayListAppContext _playListAppContext;

        public UnitOfWork(PlayListAppContext playListAppContext)
        {
            _playListAppContext = playListAppContext;
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
