using System.Collections.Generic;

namespace API.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int NumberOfprojects { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}