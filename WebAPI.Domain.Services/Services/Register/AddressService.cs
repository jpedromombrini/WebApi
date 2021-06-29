using System;
using System.Threading.Tasks;
using WebAPI.Domain.Core.Interfaces.Repositories.Register;
using WebAPI.Domain.Core.Interfaces.Services.Register;
using WebAPI.Domain.Models.Register;

namespace WebAPI.Domain.Services.Services.Register
{
    public class AddressService : BaseService<AddressModel>, IAddressService
    {
        private readonly IAddressRepository _addressRepository;
        public AddressService(IAddressRepository addressRepository)
            :base(addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public async Task<AddressModel> GetByPersonId(Guid PersonId)
        {
            return await _addressRepository.GetByPersonId(PersonId);
        }
    }
}