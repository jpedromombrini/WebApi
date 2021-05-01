using System;
using System.Threading.Tasks;
using WebAPI.Domain.Models;

namespace WebAPI.Domain.Core.Interfaces.Repositories.Register
{
    public interface IAddressRepository : IBaseRepository<AddressModel> 
    {
        Task<AddressModel> GetByPersonId(Guid personId);
    }
}