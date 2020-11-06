using Model;
using System;
using System.Collections.Generic;
using System.Linq;

// CategoryRepositary communicats with IDatamanager interface. LINQ is mostly used for handling collections. 

namespace DataAccess.Repository
{
    public class CategoryRepository : BaseRepository<Category>
    {
        private readonly IDatamanager _datamanager;
        private readonly string _categoryFileLocation = "Category";
        public CategoryRepository():base()
        {
            _datamanager = new FileContext();
        }
        public override void Create(Category payLoad)
        {
            var temporary = GetAll().ToList();
            temporary.Add(payLoad);
            _datamanager.Save(temporary, _categoryFileLocation);
        }
        public override void Delete(Guid id)
        {
            var temporary = GetAll().Where(x => x.Id != id).ToList();
            _datamanager.Save(temporary, _categoryFileLocation);
        }
        public override IEnumerable<Category> GetAll()
        {
            IEnumerable<Category> categoryToBeReturned;
            categoryToBeReturned = _datamanager.Load<Category>(_categoryFileLocation);
            return categoryToBeReturned ?? new List<Category>();
        }
        // example of methodoverloading
        public Category GetCategory(string name)
        {
            return GetAll().Where(x => x.Name == name).ToList().FirstOrDefault();
        }
        public Category GetCategory(Guid id)
        {
            return GetAll().Where(x => x.Id == id).ToList().FirstOrDefault();
        }
        public  void UpdateCategory(Category payLoad)
        {
            var temporary = GetAll().Where(x => x.Id != payLoad.Id).ToList();
            temporary.Add(payLoad);         
            _datamanager.Save(temporary, _categoryFileLocation);
        }
    }
}
