using System;

namespace Aquapark.Models
{
    public class Exit
    {
        public int Id { get; set; }
        public int WatchId { get; set; }
        public DateTime? Time { get; set; }

        public Exit(int id, int watchId, DateTime time)
        {
            Id = id;
            WatchId = watchId;
            Time = time;
        }
    }
}
