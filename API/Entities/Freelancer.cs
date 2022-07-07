using System.Collections.Generic;

namespace API.Entities
{
    public class Freelancer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }
        public string Skills { get; set; }
        public string Profession { get; set; }
        public int OverallRating { get; set; }
        public string WorkHistory { get; set; }
        public string Location { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}