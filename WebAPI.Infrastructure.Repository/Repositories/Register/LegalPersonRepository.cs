using System.Threading.Tasks;
using WebAPI.Domain.Core.Interfaces.Repositories.Register;
using WebAPI.Domain.Models.Register;
using WebAPI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace WebAPI.Infrastructure.Repository.Repositories.Register
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

        public async Task<IEnumerable<LegalPersonModel>> GetByCompanyNameAsync(string companyName)
        {
            return await _context.LegalPersons
                    .Where(x => x.CompanyName
                    .Contains(companyName))
                    .Include(a => a.Address)
                    .ToListAsync();
        }
    }
}