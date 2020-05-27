namespace Aquapark.Models
{
    public class TransactionType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public TransactionType(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
