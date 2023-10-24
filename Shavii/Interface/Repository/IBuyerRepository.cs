using Shavii.Dtos;

namespace Shavii.Interface.Repository
{
    public interface IBuyerRepository
    {
        Task<bool> Add(InputBuyerDto inputBuyer);

        Task<bool> Update(int Id, InputBuyerDto inputBuyer);

        Task<bool> Delete(int Id);

        Task<OutputBuyerDto>  GetById(int Id);

        Task<List<OutputBuyerDto>>  GetAll();
    }
}
