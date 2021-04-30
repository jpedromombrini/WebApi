using WebAPI.Domain.Core.Interfaces.Repositories.Register;
using WebAPI.Domain.Core.Interfaces.Services.Register;
using WebAPI.Domain.Models;

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
    }
}