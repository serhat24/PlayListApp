
using DataAccess.Abstract;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class UserRepository : Repository<User>,IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {

        }


    }
}
