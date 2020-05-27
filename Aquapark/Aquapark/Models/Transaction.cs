using System;

namespace Aquapark.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int TransactionTypeId { get; set; }
        public int WatchId { get; set; }
        public DateTime? Time { get; set; }

        public Transaction(int id, int serviceId, int transactionTypeId, int watchId, DateTime time)
        {
            Id = id;
            ServiceId = serviceId;
            TransactionTypeId = transactionTypeId;
            WatchId = watchId;
            Time = time;
        }
    }
}
