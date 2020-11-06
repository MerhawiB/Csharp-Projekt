using Model;
using System;
using System.Collections.Generic;
using System.Linq;

// EpisodeRepositary communicats with IDatamanager interface. LINQ is mostly used for handling collections. 

namespace DataAccess.Repository
{
    public class EpisodeRepository : BaseRepository<Episode>
    {
        private readonly IDatamanager _datamanager;
        private readonly string _episodeFileLocation = "Episode";
        public EpisodeRepository() : base()
        {
            _datamanager = new FileContext();

        }
        public void Create(List<Episode> episodes, Guid podscastId)
        {
            var temporary = GetAll().Where(x => x.PodcastID != podscastId).ToList();
            temporary.AddRange(episodes);
            _datamanager.Save(temporary, _episodeFileLocation);
        }
        public override void Delete(Guid id)
        {
            var temporary = GetAll().Where(x => x.Id != id).ToList();
            _datamanager.Save(temporary, _episodeFileLocation);
        }
        public override IEnumerable<Episode> GetAll()
        {
            IEnumerable<Episode> podCastToBeReturned;
            podCastToBeReturned = _datamanager.Load<Episode>(_episodeFileLocation);
            return podCastToBeReturned ?? new List<Episode>();
        }
        public IEnumerable<Episode> GetAllEpisodes(Guid id)
        {
            return GetAll().Where(x => x.PodcastID == id).ToList();
        }
        public void DeleteAllEpisodesForPodCast(Guid id)
        {
            var temporary = GetAll().Where(x => x.PodcastID != id).ToList();
            _datamanager.Save(temporary, _episodeFileLocation);
        }
        public  void UpdateEpisodes(Guid id, List<Episode> episodes)
        {
            var temporary = GetAll().Where(x => x.PodcastID != id).ToList();
            foreach (var episode in episodes)
            {         
                episode.PodcastID = id;           
                temporary.Add(episode);
            }      
            _datamanager.Save(temporary, _episodeFileLocation);
        }
    }
}
