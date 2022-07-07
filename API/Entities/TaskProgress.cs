using System;

namespace API.Entities
{
    public class TaskProgress
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string CurrentPoint { get; set; }
    }
}