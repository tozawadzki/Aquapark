namespace Aquapark.Models
{
    public class Watch
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ServiceId { get; set; }

        public Watch(int id, int customerId, int serviceId)
        {
            Id = id;
            CustomerId = customerId;
            ServiceId = serviceId;
        }
    }
}
