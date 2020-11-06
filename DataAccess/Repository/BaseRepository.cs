using Model;
using System;
using System.Collections.Generic;
using System.Linq;

// This Class is a abstract class with the keyword virtual for those methods that the other repositories(Podcast, Category & Episode) override in respective class.

namespace DataAccess.Repository
{
    public abstract class BaseRepository<T> : IRepository<T> where T: BaseModel
    {   
        private readonly IDatamanager _datamanager;   
        private readonly string _fileLocation;
        
        public BaseRepository()
        {
            _fileLocation = "File";
            _datamanager = new FileContext();
        }
        public virtual void Create(T payLoad)
        {
            var temporary = GetAll().ToList();
            temporary.Add(payLoad);
            _datamanager.Save(temporary, _fileLocation);
        }
        public virtual IEnumerable<T> GetAll()
        {
           IEnumerable<T> entityToBeReturned;
           entityToBeReturned = _datamanager.Load<T>(_fileLocation);
           return entityToBeReturned ?? new List<T>();
        }
        public virtual void Delete(Guid id)
        {
            var temporary = GetAll().Where(x => x.Id != id).ToList();
            _datamanager.Save(temporary, _fileLocation);
        }
        public virtual void Update(Guid id, T payLoad)
        {
            var temporary = GetAll().Where(x => x.Id != id).ToList();
            temporary.Add(payLoad);
            _datamanager.Save(temporary, _fileLocation);
        }   
    }
}
