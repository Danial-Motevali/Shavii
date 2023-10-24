using Shavii.Data.Ef;
using Shavii.Dtos;
using Shavii.Entites;
using Shavii.Interface.Repository;

namespace Shavii.Repository
{
    public class AddressRepository : IAddressRepository
    {
        private readonly ShaviiDbContext _db;

        public AddressRepository(ShaviiDbContext db)
        {
            _db = db; 
        }

        public async Task<bool> Add(InputAddressDto inputAddress)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<OutputAddressDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<OutputAddressDto> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(int Id, InputAddressDto inputAddress)
        {
            throw new NotImplementedException();
        }
    }
}
