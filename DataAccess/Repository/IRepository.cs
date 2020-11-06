using System;
using System.Collections.Generic;


//Custom made Repository that the abstract class BaseRepository uses.

namespace DataAccess.Repository
{
    public interface IRepository<T> 
    {
        void Create(T payLoad);       
        void Delete(Guid id);
        IEnumerable<T> GetAll();
    }
}
