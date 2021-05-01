using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI.Domain.Core.Interfaces.Repositories.Register;
using WebAPI.Domain.Models;
using WebAPI.Infrastructure.Data;

namespace WebAPI.Infrastructure.Repository.Repositories.Register
{
    public class PhysicalPersonRepository : BaseRepository<PhysicalPersonModel>, IPhysicalPersonRepository
    {
        private readonly DataContext _context;
        public PhysicalPersonRepository(DataContext context)
            :base(context)
        {
            _context = context;
        }

        public async Task<PhysicalPersonModel> GetByCpfAsync(string cpf)
        {
            return await _context.PhysicalPersons.FirstOrDefaultAsync(x => x.Cpf == cpf);
        }

        public async Task<IEnumerable<PhysicalPersonModel>> GetByNameAsync(string name)
        {
             return await _context.PhysicalPersons
                    .Where(x => x.Name
                    .Contains(name))
                    .Include(a => a.Address)
                    .ToListAsync();
        }
    }
}