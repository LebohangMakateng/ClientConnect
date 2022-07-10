using Microsoft.AspNetCore.Identity;

namespace API.Entities
{
    public class AppUserRole : IdentityUserRole<int>
    {
        //public Client Client { get; set; }
        //public Freelancer Freelancer { get; set; }
        public AppUser User { get; set; }
        public AppRole Role { get; set; }
    }

}