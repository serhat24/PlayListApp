using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface IUnitOfWork:IDisposable
    {

        int Complete();
        
    }
}
