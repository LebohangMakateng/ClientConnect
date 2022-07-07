using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace API.Entities
{
    public class AppUser: IdentityUser<int>
    {
        public string City { get; set; }
        public string Country { get; set; }
        public int NumberOfprojects { get; set; }
         public string Biography { get; set; }
        public string Skills { get; set; }
        public string Profession { get; set; }
        public int OverallRating { get; set; }
        public string Role { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}