using System;
using System.Threading.Tasks;
using WebAPI.Domain.Models;

namespace WebAPI.Domain.Core.Interfaces.Services.Register
{
    public interface IAddressService : IBaseService<AddressModel> 
    {
        Task<AddressModel> GetByPersonId(Guid PersonId);
     }
}