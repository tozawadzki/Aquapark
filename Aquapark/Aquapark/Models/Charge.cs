namespace Aquapark.Models
{
    public class Charge
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public int WatchId { get; set; }

        public Charge(int id, decimal amount, int watchId)
        {
            Id = id;
            Amount = amount;
            WatchId = watchId;
        }
    }
}
