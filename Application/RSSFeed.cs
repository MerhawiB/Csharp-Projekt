
using Model;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Threading.Tasks;
using System.Xml;

namespace Application{

    public class RSSFeed
    {
        // Async method for downloading podcast feeds 
        public async Task<PodCast> GetFeedAsync(string url){
            try
            {
                var reader = XmlReader.Create(url);
                var feed = await Task.Run(() => SyndicationFeed.Load(reader));
                return MapFeedToPod(feed).CheckIfObjectIsEmpty();
            }
            catch (EmptyValueException)
            {
                return null;
            }
        }
        private PodCast MapFeedToPod(SyndicationFeed feed)
        {
                 var episodes = new List<Episode>();
                 var i = feed.Items.Count();
                 foreach (var episode in feed.Items)
                 {
                     episodes.Add(new Episode { EpisodeIndex = i, Title = episode.Title.Text, Description = episode.Summary.CheckIfURLIsValid().Text});
                     i--;
                 }
            var pod = new PodCast { Episodes = episodes, AmountOfEpisodes = feed.Items.Count() };          
            return pod;   
        }
    }
}