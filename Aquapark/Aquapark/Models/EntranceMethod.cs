namespace Aquapark.Models
{
    public class EntranceMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public EntranceMethod(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
