using WebAPI.Domain.Core.Interfaces.Repositories;
using WebAPI.Domain.Models;
using WebAPI.Infrastructure.Data;

namespace WebAPI.Infrastructure.Repository.Repositories
{
    public class PhysicalPersonRepository : BaseRepository<PhysicalPersonModel>, IPhysicalPersonRepository
    {
        private readonly DataContext _context;
        public PhysicalPersonRepository(DataContext context)
            :base(context)
        {
            _context = context;
        }
    }
}