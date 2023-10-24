using Shavii.Entites;

namespace Shavii.Dtos
{
    public class InputBuyerDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Age { get; set; }
    }

    public class OutputBuyerDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Age { get; set; }
    }
}
