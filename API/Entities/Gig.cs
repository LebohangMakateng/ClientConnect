using System;
using API.Entities;

namespace API.Entities
{
    public class Gig
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Decimal TaskRate { get; set; }
        public RateType RateType { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public string Expertise { get; set; }
        public Client Client { get; set; }
        public TaskProgress Progress { get; set; }
        public int MyProperty { get; set; }
    }

    public enum RateType
    {
        Hourly, ProjectCompleted
    }
}