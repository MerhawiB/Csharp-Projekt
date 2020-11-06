using DataAccess.Repository;
using Model;
using System;
using System.Collections.Generic;
namespace Application
{
    // A class that communicates with the repositories in the Dataaccess layer
    public class EpisodeController
    {
        private readonly EpisodeRepository _episodeRepository;
        public EpisodeController()
        {
            _episodeRepository = new EpisodeRepository();
        }
        public void DeleteEpisodes(Guid id)
        {
            _episodeRepository.DeleteAllEpisodesForPodCast(id);
        }
        public IEnumerable<Episode> GetAllEpisodes(Guid id)
        {
            return _episodeRepository.GetAllEpisodes(id);
        }       
    }
}
