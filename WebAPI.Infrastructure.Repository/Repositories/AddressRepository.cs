using WebAPI.Domain.Core.Interfaces.Repositories;
using WebAPI.Domain.Models;
using WebAPI.Infrastructure.Data;

namespace WebAPI.Infrastructure.Repository.Repositories
{
    public class AddressRepository : BaseRepository<AddressModel>, IAddressRepository
    {
        private readonly DataContext _context;
        public AddressRepository(DataContext context)
            :base(context)
        {
            _context = context;
        }
    }
}