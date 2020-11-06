using DataAccess.Repository;
using Model;
using Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Application
{
    // A class that communicates with the repositories in the Dataaccess layer
    public class PodCastController
    {
        private readonly PodCastRepository _podcastRepository;
        private readonly EpisodeRepository _episodeRepository;
        private readonly RSSFeed _rssFeed;
        public PodCastController()
        {
            _podcastRepository = new PodCastRepository();
            _episodeRepository = new EpisodeRepository();
            _rssFeed = new RSSFeed();
        }
        public async Task CreatePodcastAsync(PodCastDTO payLoad)
        {
            try
            {
                var pod = await _rssFeed.GetFeedAsync(payLoad.Url).CheckIfObjectIsEmpty();
                var episodes = pod.Episodes;
                pod.Id = Guid.NewGuid();
                pod.Episodes = null;
                pod.Url = payLoad.Url;
                pod.CategoryId = payLoad.CategoryId;
                pod.Name = payLoad.Name;
                pod.UpdateInterval = payLoad.Interval;
                pod.NextUpdate = DateTime.Now.AddMinutes(payLoad.Interval);
                foreach (var episode in episodes)
                {
                    episode.PodcastID = pod.Id;
                }

                _episodeRepository.Create(episodes, pod.Id);
                _podcastRepository.Create(pod);
            }
            catch (Exception){}
        }
        public IEnumerable<PodCast> GetAllPodCasts() 
        {
           return _podcastRepository.GetAll();   
        }
        public void DeletePodCast(Guid podcastToDelete)
        {
            _podcastRepository.Delete(podcastToDelete);
        }
        public PodCast GetPodCast(string name) 
        {
           return _podcastRepository.GetPodcast(name); ;
        }
        public List<PodCast> GetPodCastByCategory(Guid id)
        {
           return _podcastRepository.GetByCategory(id);
        }
        public async Task UpdatePodcastAsync(Guid id, PodCastDTO payLoad)
        {
            try
            {
                var pod = await _rssFeed.GetFeedAsync(payLoad.Url);
                var episodes = pod.Episodes;
                pod.Episodes = null;
                pod.Id = id;
                pod.Url = payLoad.Url;
                pod.CategoryId = payLoad.CategoryId;
                pod.Name = payLoad.Name;
                pod.UpdateInterval = payLoad.Interval;
                pod.NextUpdate = DateTime.Now.AddMinutes(payLoad.Interval);
                _episodeRepository.UpdateEpisodes(id, episodes);
                _podcastRepository.Update(id, pod);
            }
            catch (Exception){}
        }
        public async Task CheckUpdateAsync()
        {
            var podcasts = _podcastRepository.GetAll().ToList();
            foreach (var pod in podcasts)
            {
                if (pod.NeedsUpdate)
                {
                    await UpdatePodcastAsync(pod.Id, new PodCastDTO 
                    { 
                        Name = pod.Name, 
                        CategoryId = pod.CategoryId,
                        Interval = pod.UpdateInterval,
                        Url = pod.Url

                    });                   
                    
                }    
            }
        }
    }
}
