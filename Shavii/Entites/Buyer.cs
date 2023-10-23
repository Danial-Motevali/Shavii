namespace Shavii.Entites
{
    public class Buyer
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Age { get; set; }

        public IEnumerable<Address> Addresses { get; set; }
    }
}
