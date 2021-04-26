using WebAPI.Domain.Core.Interfaces.Repositories;
using WebAPI.Domain.Models;
using WebAPI.Infrastructure.Data;

namespace WebAPI.Infrastructure.Repository.Repositories
{
    public class LegalPersonRepository : BaseRepository<LegalPersonModel>, ILegalPersonRepository
    {
        private readonly DataContext _context;
        public LegalPersonRepository(DataContext context)
            :base(context)
        {
            _context = context;
        }
    }
}