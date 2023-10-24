using Shavii.Dtos;

namespace Shavii.Interface.Repository
{
    public interface IAddressRepository
    {
        Task<bool> Add(InputAddressDto inputAddress);

        Task<bool> Update(int Id, InputAddressDto inputAddress);

        Task<bool> Delete(int Id);

        Task<OutputAddressDto> GetById(int Id);

        Task<List<OutputAddressDto>>  GetAll();
    }
}
