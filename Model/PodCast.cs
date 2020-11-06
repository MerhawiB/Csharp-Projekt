using System;
using System.Collections.Generic;

namespace Model
  
{
    public class PodCast : BaseModel  
    {
        public string Url { get; set; }
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
        public double UpdateInterval { get; set; }
        public int AmountOfEpisodes { get; set; }
        public List<Episode> Episodes { get; set; } = new List<Episode>();
        public DateTime NextUpdate { get; set; }
        public bool NeedsUpdate => NextUpdate <= DateTime.Now;
    }
}
