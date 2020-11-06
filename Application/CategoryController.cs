using DataAccess.Repository;
using Model;
using System;
using System.Collections.Generic;
// A class that communicates with the repositories in the Dataaccess layer
namespace Application
{
   public class CategoryController
    {
        private readonly CategoryRepository _categoryRepository;
        private readonly PodCastRepository _podcastRepository;
        private readonly EpisodeRepository _episodeRepository;
        public CategoryController()
        {
            _categoryRepository = new CategoryRepository();
            _podcastRepository = new PodCastRepository();
            _episodeRepository = new EpisodeRepository();
        }
        public void CreateCategory(Category payload)
        {
            Category category = new Category
            {
                Name = payload.Name,
                Id = Guid.NewGuid()
            };
            _categoryRepository.Create(category);
        }
        public IEnumerable<Category> GetAllCategory()
        {
            return _categoryRepository.GetAll();
        }
        public void DeleteCategory(Guid id)
        {           
          _categoryRepository.Delete(id);
          var podcast =_podcastRepository.GetByCategory(id);         
            foreach (var pod in podcast)
            {
                _episodeRepository.DeleteAllEpisodesForPodCast(pod.Id);            
            } 
          _podcastRepository.DeleteAllWithCategory(id); 
        }
        // GetCategory is using method overloading the one with  a string parameter returns a Guid while the Guid parameter returns a string 
        public Guid GetCategory(string name)
        { 
            return _categoryRepository.GetCategory(name).Id;
        }
        public string GetCategory(Guid id)
        {
            return _categoryRepository.GetCategory(id).Name;
        }
        public void UpdateCategory(Guid id, string name)
        {
             var category = new Category { Id = id, Name = name}; 
             _categoryRepository.UpdateCategory(category);       
        }
    }
}
