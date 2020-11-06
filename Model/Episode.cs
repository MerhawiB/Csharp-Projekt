using System;

namespace Model
{
    public class Episode : BaseModel
    {
        public int EpisodeIndex{ get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid PodcastID { get; set; }
    }
}
