using System.Threading.Tasks;
using WebAPI.Domain.Core.Interfaces.Repositories;
using WebAPI.Domain.Models;
using WebAPI.Infrastructure.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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

        public async Task<LegalPersonModel> GetByCnpjAsync(string cnpj)
        {
            return await _context.LegalPersons.FirstOrDefaultAsync(x => x.Cnpj == cnpj);
        }
    }
}