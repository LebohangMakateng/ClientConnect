using System.Collections.Generic;

namespace API.Entities
{
    public class Freelancer:AppUser
    {
        public int NumberOfprojects { get; set; }
        public string Skills { get; set; }
        public int OverallRating { get; set; }
    }
}