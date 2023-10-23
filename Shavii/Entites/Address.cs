namespace Shavii.Entites
{
    public class Address
    {
        public int Id { get; set; }

        public string City { get; set; } = string.Empty;

        public string street { get; set; } = string.Empty;

        public int BuyerId { get; set; }

        public Buyer Buyer { get; set; }
    }
}
