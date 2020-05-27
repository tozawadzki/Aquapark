namespace Aquapark.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal PricePerHour { get; set; }
        public decimal PricePerMinute { get; set; }
        public int EntranceMethodId { get; set; }

        public Service(int id, string name, decimal pricePerHour, decimal pricePerMinute, int entranceMethodId)
        {
            Id = id;
            Name = name;
            PricePerHour = pricePerHour;
            PricePerMinute = pricePerMinute;
            EntranceMethodId = entranceMethodId;
        }
    }
}
