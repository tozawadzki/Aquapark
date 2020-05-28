using System;

namespace Aquapark.Models
{
    public class Entrances
    {
        public int Id { get; set; }
        public int WatchId { get; set; }
        public int EntranceMethodId { get; set; }
        public DateTime? Time { get; set; }
        public int CustomerId { get; set; }
        public int Hours { get; set; }

        public Entrances(int id, int watchId, int entranceMethodId, DateTime time, int customerId, int hours)
        {
            Id = id;
            WatchId = watchId;
            EntranceMethodId = entranceMethodId;
            Time = time;
            CustomerId = customerId;
            Hours = hours;
        }
    }
}
