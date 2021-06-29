using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI.Domain.Core.Interfaces.Repositories.Register;
using WebAPI.Domain.Models.Register;
using WebAPI.Infrastructure.Data;

namespace WebAPI.Infrastructure.Repository.Repositories.Register
{
    public class AddressRepository : BaseRepository<AddressModel>, IAddressRepository
    {
        private readonly DataContext _context;
        public AddressRepository(DataContext context)        
            :base(context)
        {
            _context = context;
        }

        public async Task<AddressModel> GetByPersonId(Guid PersonId)
        {
           return await _context.Addresses.FirstOrDefaultAsync(x => x.PersonId == PersonId);
        }
    }
}