using WebAPI.Domain.Core.Interfaces.Repositories;
using WebAPI.Domain.Core.Interfaces.Services;
using WebAPI.Domain.Models;

namespace WebAPI.Domain.Services.Services
{
    public class AddressService : BaseService<AddressModel>, IAddressService
    {
        private readonly IAddressRepository _addressRepository;
        public AddressService(IAddressRepository addressRepository)
            :base(addressRepository)
        {
            _addressRepository = addressRepository;
        }
    }
}