using System.Runtime.InteropServices;

namespace Aquapark.Models
{
    public class Visit
    {
        public int Id { get; set; }
        public int WatchId { get; set; }
        public int CustomerId { get; set; }
        public int ServiceId { get; set; }
        public decimal ExitPayment { get; set; }

        public Visit(int id, int watchId, int customerId, int serviceId, decimal exitPayment)
        {
            Id = id;
            WatchId = watchId;
            CustomerId = customerId;
            ServiceId = serviceId;
            ExitPayment = exitPayment;
        }
    }
}
