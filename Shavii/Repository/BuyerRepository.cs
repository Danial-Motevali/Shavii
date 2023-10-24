using Shavii.Dtos;
using Shavii.Interface.Repository;

namespace Shavii.Repository
{
    public class BuyerRepository : IBuyerRepository
    {
        public Task<bool> Add(InputBuyerDto inputBuyer)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<OutputBuyerDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<OutputBuyerDto> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(int Id, InputBuyerDto inputBuyer)
        {
            throw new NotImplementedException();
        }
    }
}
