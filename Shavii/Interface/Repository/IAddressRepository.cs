using Shavii.Dtos;

namespace Shavii.Interface.Repository
{
    public interface IAddressRepository
    {
        public bool Add();
        public bool Update();

        public bool Delete();

        public AddressDto GetById();

        public List<AddressDto> GetAll();
    }
}
