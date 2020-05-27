namespace Aquapark.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public int DiscountId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Customer(int id, int discountId, string firstName, string lastName)
        {
            Id = id;
            DiscountId = discountId;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
