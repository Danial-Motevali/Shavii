using Shavii.Entites;

namespace Shavii.Dtos
{
    public class InputAddressDto
    {
        public int Id { get; set; }
        public string City { get; set; } = string.Empty;

        public string street { get; set; } = string.Empty;
    }

    public class OutputAddressDto
    {
        public string City { get; set; } = string.Empty;

        public string street { get; set; } = string.Empty;
    }
}
