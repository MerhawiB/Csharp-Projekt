using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Repository
{
    // PodCastRepositary communicats with IDatamanager interface. LINQ is mostly used for handling collections. 
    public class PodCastRepository : BaseRepository<PodCast>
    {
        private readonly IDatamanager _datamanager;
        private readonly string _podcastFileLocation = "Podcast";
        public PodCastRepository():base()
        {
            _datamanager =  new FileContext();
        }
        public override void Create(PodCast payLoad)
        {
            var temporary = GetAll().ToList();         
            temporary.Add(payLoad);         
           _datamanager.Save(temporary, _podcastFileLocation);
        }
        public override void Delete(Guid id)
        {
            var temporary = GetAll().Where(x=> x.Id != id).ToList();
            _datamanager.Save(temporary, _podcastFileLocation);
        }
        public void DeleteAllWithCategory(Guid id)
        {
            var temporary = GetAll().Where(x => x.CategoryId != id).ToList();
            _datamanager.Save(temporary, _podcastFileLocation); 
        }
        public override IEnumerable<PodCast> GetAll()
        {
           IEnumerable<PodCast> podCastToBeReturned;        
           podCastToBeReturned = _datamanager.Load<PodCast>(_podcastFileLocation);       
           return podCastToBeReturned ?? new List<PodCast>();    
        }
        public List<PodCast> GetByCategory(Guid id)
        {
            return GetAll().Where(x => x.CategoryId == id).ToList();
        }
        public  PodCast GetPodcast(string name)
        {
            return GetAll().Where(x => x.Name == name).FirstOrDefault();
        }
        public PodCast GetPodcastByUrl(string url)
        {
            return GetAll().Where(x => x.Url == url).FirstOrDefault();
        }
        public override void Update(Guid id, PodCast payLoad)
        {
            var temporary = GetAll().Where(x => x.Id != id).ToList();         
            temporary.Add(payLoad);
            _datamanager.Save(temporary, _podcastFileLocation);
        }
    }
}

