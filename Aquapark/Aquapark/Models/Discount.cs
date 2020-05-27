namespace Aquapark.Models
{
    public class Discount
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Name { get; set; }

        public Discount(int id, decimal amount, string name)
        {
            Id = id;
            Amount = amount;
            Name = name;
        }
    }
}
