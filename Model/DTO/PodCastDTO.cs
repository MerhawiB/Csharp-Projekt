using System;


namespace Model.DTO
{
    // We used the idea of Data transfer object to easier tranfer data regarding podcast objects. 

    public class PodCastDTO
    {
        public string Url { get; set; }
        public string Name { get; set; }
        public double Interval { get; set; }
        public Guid CategoryId { get; set; }
    }
}
