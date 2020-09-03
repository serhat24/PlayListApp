
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public class UnitOfWork : IUnitOfWork
    {

        private PlayListAppContext _playListAppContext;
       

        public UnitOfWork(PlayListAppContext playListAppContext)
        {
            _playListAppContext = playListAppContext;
            UserRepository = new UserRepository(_playListAppContext);

        }

        public UserRepository UserRepository { get; private set; }

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
