namespace API.DTOs
{
    public class FreelancerDto
    {
        public int Id { get; set; }
        public string PhotoUrl { get; set; }
        public string UserName { get; set; }
        public string Biography { get; set; }
        public string Skills { get; set; }
        public string Profession { get; set; }
        public int OverallRating { get; set; }
        public string WorkHistory { get; set; }
        public string Location { get; set; }
    }
}